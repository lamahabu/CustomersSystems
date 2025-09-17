Imports System.Text
Imports System.Management
Imports System.Security.Cryptography
Imports System.Data.SqlClient


Public Class FrmLogIn

    Private Const Pbkdf2Iterations As Integer = 20000
    Private Const HashBytes As Integer = 32
    Private Const SaltBytes As Integer = 32
    Dim connectionString As String = "Server=LAPTOP-A4ULI8SL\SQLEXPRESS;Database=AccountingTTS;Trusted_Connection=True;"


    Public Sub New()
        InitializeComponent()
    End Sub

    Private Function GetDeviceFingerprint() As String
        Dim mbSerial As String = GetWMIProperty("Win32_BaseBoard", "SerialNumber")
        Dim cpuId As String = GetWMIProperty("Win32_Processor", "ProcessorId")

        Dim rawId As String = mbSerial & "|" & cpuId & "|"
        Using sha As SHA256 = SHA256.Create()
            Dim bytes As Byte() = Encoding.UTF8.GetBytes(rawId)
            Dim hashBytes As Byte() = sha.ComputeHash(bytes)
            Return BitConverter.ToString(hashBytes).Replace("-", "")
        End Using
    End Function


    Private Function GetWMIProperty(className As String, propertyName As String) As String
        Try
            Dim searcher As New ManagementObjectSearcher("SELECT " & propertyName & " FROM " & className)
            For Each obj As ManagementObject In searcher.Get()
                Return obj(propertyName).ToString()
            Next
        Catch
            Return "Unknown"
        End Try
        Return "Unknown"
    End Function

    Private Function GenerateSalt() As Byte()
        Dim salt(SaltBytes - 1) As Byte
        Using rng As New RNGCryptoServiceProvider()
            rng.GetBytes(salt)
        End Using
        Return salt
    End Function

    Private Function HashPassword(password As String, salt As Byte()) As Byte()
        Using pbkdf2 As New Rfc2898DeriveBytes(password, salt, Pbkdf2Iterations, HashAlgorithmName.SHA256)
            Return pbkdf2.GetBytes(HashBytes)
        End Using
    End Function

    Private Function VerifyPassword(enteredPassword As String, storedSalt As Byte(), storedHash As Byte()) As Boolean
        Dim attempt As Byte() = HashPassword(enteredPassword, storedSalt)
        Return CryptographicEquals(storedHash, attempt)
    End Function

    Private Function CryptographicEquals(a As Byte(), b As Byte()) As Boolean
        If a Is Nothing Or b Is Nothing Or a.Length <> b.Length Then Return False
        Dim result As Integer = 0
        For i As Integer = 0 To a.Length - 1
            result = result Or (a(i) Xor b(i))
        Next
        Return result = 0
    End Function

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim username As String = TxtEditUserName.Text.Trim()
        Dim password As String = TxtEditPass.Text
        Dim deviceFp As String = GetDeviceFingerprint()

        If String.IsNullOrEmpty(username) OrElse String.IsNullOrEmpty(password) Then
            MessageBox.Show("Enter username and password.")
            Return
        End If

        Try
            Dim salt() As Byte = GenerateSalt()
            Dim hash() As Byte = HashPassword(password, salt)

            Using con As New SqlConnection(connectionString)
                con.Open()
                ' Insert user
                Using cmd As New SqlCommand("INSERT INTO Users (Username, PasswordHash, Salt) VALUES (@u,@h,@s); SELECT SCOPE_IDENTITY()", con)
                    cmd.Parameters.AddWithValue("@u", username)
                    cmd.Parameters.Add("@h", SqlDbType.VarBinary).Value = hash
                    cmd.Parameters.Add("@s", SqlDbType.VarBinary).Value = salt
                    Dim userId As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                    ' Insert first trusted device
                    Using devCmd As New SqlCommand("INSERT INTO TrustedDevices (UserID, DeviceFingerprint) VALUES (@uid,@fp)", con)
                        devCmd.Parameters.AddWithValue("@uid", userId)
                        devCmd.Parameters.AddWithValue("@fp", deviceFp)
                        devCmd.ExecuteNonQuery()
                    End Using
                End Using
            End Using

            MessageBox.Show("Registration successful!")
        Catch ex As SqlException
            If ex.Number = 2627 Then
                MessageBox.Show("Username already exists.")
            Else
                MessageBox.Show("Database error: " & ex.Message)
            End If
        End Try
    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogIn.Click
        Dim username As String = TxtEditUserName.Text.Trim()
        Dim password As String = TxtEditPass.Text
        Dim deviceFp As String = GetDeviceFingerprint()

        Using con As New SqlConnection(connectionString)
            con.Open()
            Using cmd As New SqlCommand("SELECT UserID, PasswordHash, Salt FROM Users WHERE Username=@u", con)
                cmd.Parameters.AddWithValue("@u", username)
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        Dim userId As Integer = reader("UserID")
                        Dim storedHash() As Byte = CType(reader("PasswordHash"), Byte())
                        Dim storedSalt() As Byte = CType(reader("Salt"), Byte())

                        ' Verify password
                        If VerifyPassword(password, storedSalt, storedHash) Then
                            reader.Close()

                            ' Check if device is trusted
                            Using devCmd As New SqlCommand("SELECT COUNT(*) FROM TrustedDevices WHERE UserID=@uid AND DeviceFingerprint=@fp", con)
                                devCmd.Parameters.AddWithValue("@uid", userId)
                                devCmd.Parameters.AddWithValue("@fp", deviceFp)
                                Dim count As Integer = Convert.ToInt32(devCmd.ExecuteScalar())

                                If count = 0 Then
                                    ' New device detected → ask for verification / register it
                                    If MessageBox.Show("New device detected. Add this device?", "Device Verification", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                                        Using addCmd As New SqlCommand("INSERT INTO TrustedDevices (UserID, DeviceFingerprint) VALUES (@uid,@fp)", con)
                                            addCmd.Parameters.AddWithValue("@uid", userId)
                                            addCmd.Parameters.AddWithValue("@fp", deviceFp)
                                            addCmd.ExecuteNonQuery()
                                        End Using
                                        MessageBox.Show("Device registered. Login successful!")
                                    Else
                                        MessageBox.Show("Login cancelled for this device.")
                                        Return
                                    End If
                                Else
                                    MessageBox.Show("Login successful!")
                                    Dim frm As New Form1()
                                    frm.Show()
                                    Me.Hide()

                                End If
                            End Using
                        Else
                            MessageBox.Show("Invalid password.")
                        End If
                    Else
                        MessageBox.Show("User not found.")
                    End If
                End Using
            End Using
        End Using
    End Sub

End Class