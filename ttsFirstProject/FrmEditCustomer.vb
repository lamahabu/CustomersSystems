Imports System.Data.SqlClient

Public Class FrmEditCustomer
    Private CustomerId As Integer? = Nothing
    Private connectionString As String = "Server=LAPTOP-A4ULI8SL\SQLEXPRESS;Database=AccountingTTS;Trusted_Connection=True;"

    Public Sub New(Optional ByVal id As String = Nothing)
        InitializeComponent()

        Dim tempId As Integer
        If Not String.IsNullOrEmpty(id) AndAlso Integer.TryParse(id, tempId) Then
            CustomerId = tempId
            Savebtn.Text = "Save Changes"
        Else
            Savebtn.Text = "Add Customer"
        End If
    End Sub

    Private Sub FrmEditCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If CustomerId.HasValue Then
            Using con As New SqlConnection(connectionString)
                con.Open()

                Dim queryCustomer As String = "SELECT FirstName, Email, Phone, City FROM Customers WHERE CustomerID=@CustomerID"
                Using cmd As New SqlCommand(queryCustomer, con)
                    cmd.Parameters.AddWithValue("@CustomerID", CustomerId.Value)
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            TextEdit1.Text = reader("FirstName").ToString()
                            TextEdit2.Text = reader("Email").ToString()
                            TextEdit3.Text = reader("Phone").ToString()
                            TextEdit4.Text = reader("City").ToString()
                        End If
                    End Using
                End Using


                Dim queryContacts As String = "SELECT ContactID, ContactName, Phone, CreatedAt FROM Contacts WHERE CustomerID=@CustomerID"
                Using da As New SqlDataAdapter(queryContacts, con)
                    da.SelectCommand.Parameters.AddWithValue("@CustomerID", CustomerId.Value)
                    Dim dt As New DataTable()
                    da.Fill(dt)
                    GridControl1.DataSource = dt
                    ContactName.FieldName = "ContactName"
                    ContactPhone.FieldName = "Phone"
                    GridControl1.RefreshDataSource()
                End Using
            End Using
        End If

    End Sub

    Private Sub Savebtn_Click(sender As Object, e As EventArgs) Handles Savebtn.Click
        Dim newCustomerId As Integer = 0

        Using con As New SqlConnection(connectionString)
            con.Open()

            Dim cmd As SqlCommand

            ' --- Update existing customer ---
            If CustomerId.HasValue Then
                Dim query As String = "UPDATE Customers SET FirstName=@FirstName, Email=@Email, Phone=@Phone, City=@City, UpdatedAt=GETDATE() WHERE CustomerID=@CustomerID"
                cmd = New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@CustomerID", CustomerId.Value)
                cmd.Parameters.AddWithValue("@FirstName", TextEdit1.Text)
                cmd.Parameters.AddWithValue("@Email", TextEdit2.Text)
                cmd.Parameters.AddWithValue("@Phone", TextEdit3.Text)
                cmd.Parameters.AddWithValue("@City", TextEdit4.Text)
                cmd.ExecuteNonQuery()
            Else
                ' --- Insert new customer ---
                Dim query As String = "INSERT INTO Customers (FirstName, Email, Phone, City) VALUES (@FirstName, @Email, @Phone, @City); SELECT SCOPE_IDENTITY();"
                cmd = New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@FirstName", TextEdit1.Text)
                cmd.Parameters.AddWithValue("@Email", TextEdit2.Text)
                cmd.Parameters.AddWithValue("@Phone", TextEdit3.Text)
                cmd.Parameters.AddWithValue("@City", TextEdit4.Text)
                newCustomerId = Convert.ToInt32(cmd.ExecuteScalar())
                CustomerId = newCustomerId
            End If

            Dim view As DevExpress.XtraGrid.Views.Grid.GridView = CType(GridControl1.MainView, DevExpress.XtraGrid.Views.Grid.GridView)

            For i As Integer = 0 To view.RowCount - 1
                Dim contactIdObj As Object = view.GetRowCellValue(i, "ContactID")
                Dim contactName As String = view.GetRowCellValue(i, "ContactName").ToString()
                Dim contactPhone As String = view.GetRowCellValue(i, "Phone").ToString()

                ' --- If both columns are empty ---
                If String.IsNullOrWhiteSpace(contactName) AndAlso String.IsNullOrWhiteSpace(contactPhone) Then
                    ' If this contact exists in the database, delete it
                    If contactIdObj IsNot Nothing AndAlso contactIdObj IsNot DBNull.Value Then
                        Dim contactId As Integer = Convert.ToInt32(contactIdObj)
                        Dim queryDelete As String = "DELETE FROM Contacts WHERE ContactID=@ContactID"
                        Using cmdDelete As New SqlCommand(queryDelete, con)
                            cmdDelete.Parameters.AddWithValue("@ContactID", contactId)
                            cmdDelete.ExecuteNonQuery()
                        End Using
                    End If
                    Continue For
                End If

                ' --- Insert new contact ---
                If contactIdObj Is Nothing OrElse contactIdObj Is DBNull.Value OrElse Convert.ToInt32(contactIdObj) < 0 Then
                    Dim queryInsert As String = "INSERT INTO Contacts (CustomerID, ContactName, Phone) VALUES (@CustomerID, @ContactName, @Phone)"
                    Using cmdInsert As New SqlCommand(queryInsert, con)
                        cmdInsert.Parameters.AddWithValue("@CustomerID", CustomerId.Value)
                        cmdInsert.Parameters.AddWithValue("@ContactName", contactName)
                        cmdInsert.Parameters.AddWithValue("@Phone", contactPhone)
                        cmdInsert.ExecuteNonQuery()
                    End Using
                Else
                    ' --- Update existing contact ---
                    Dim contactId As Integer = Convert.ToInt32(contactIdObj)
                    Dim queryUpdate As String = "UPDATE Contacts SET ContactName=@ContactName, Phone=@Phone WHERE ContactID=@ContactID"
                    Using cmdUpdate As New SqlCommand(queryUpdate, con)
                        cmdUpdate.Parameters.AddWithValue("@ContactName", contactName)
                        cmdUpdate.Parameters.AddWithValue("@Phone", contactPhone)
                        cmdUpdate.Parameters.AddWithValue("@ContactID", contactId)
                        cmdUpdate.ExecuteNonQuery()
                    End Using
                End If
            Next
        End Using

        MessageBox.Show("Customer and contacts saved successfully!")
        Me.Close()
    End Sub

    Private Sub AddContactBtn_Click(sender As Object, e As EventArgs) Handles btnAddContact.Click
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = CType(GridControl1.MainView, DevExpress.XtraGrid.Views.Grid.GridView)
        Dim dt As DataTable = CType(GridControl1.DataSource, DataTable)

        Dim newRow As DataRow = dt.NewRow()
        newRow("ContactName") = ""
        newRow("Phone") = ""
        dt.Rows.Add(newRow)

        GridControl1.RefreshDataSource()

        Dim newRowHandle As Integer = view.GetRowHandle(dt.Rows.Count - 1)
        view.FocusedRowHandle = newRowHandle
        view.FocusedColumn = view.Columns("ContactName")
        view.ShowEditor()
    End Sub

    Private Sub RepositoryItemButtonEdit_Delete_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles RepositoryItemButtonEdit1.ButtonClick
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = CType(GridControl1.MainView, DevExpress.XtraGrid.Views.Grid.GridView)
        Dim rowHandle As Integer = view.FocusedRowHandle

        If rowHandle >= 0 Then
            Dim contactIdObj As Object = view.GetRowCellValue(rowHandle, "ContactID")

            If MessageBox.Show("Are you sure you want to delete this contact?", "Confirm", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                If contactIdObj IsNot Nothing AndAlso contactIdObj IsNot DBNull.Value Then
                    Using con As New SqlConnection(connectionString)
                        con.Open()
                        Dim queryDelete As String = "DELETE FROM Contacts WHERE ContactID=@ContactID"
                        Using cmdDelete As New SqlCommand(queryDelete, con)
                            cmdDelete.Parameters.AddWithValue("@ContactID", Convert.ToInt32(contactIdObj))
                            cmdDelete.ExecuteNonQuery()
                        End Using
                    End Using
                End If
                view.DeleteRow(rowHandle)
            End If
        End If
    End Sub

End Class
