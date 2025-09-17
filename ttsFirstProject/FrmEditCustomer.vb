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

                ' --- Get Customer ---
                Using cmd As New SqlCommand("GetCustomerById", con)
                    cmd.CommandType = CommandType.StoredProcedure
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

                ' --- Get Contacts ---
                Using da As New SqlDataAdapter("GetContactsByCustomerId", con)
                    da.SelectCommand.CommandType = CommandType.StoredProcedure
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

            If CustomerId.HasValue Then
                ' --- Update existing customer ---
                cmd = New SqlCommand("UpdateCustomer", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@CustomerID", CustomerId.Value)
            Else
                ' --- Insert new customer ---
                cmd = New SqlCommand("InsertCustomer", con)
                cmd.CommandType = CommandType.StoredProcedure
            End If

            cmd.Parameters.AddWithValue("@FirstName", TextEdit1.Text)
            cmd.Parameters.AddWithValue("@Email", TextEdit2.Text)
            cmd.Parameters.AddWithValue("@Phone", TextEdit3.Text)
            cmd.Parameters.AddWithValue("@City", TextEdit4.Text)

            If CustomerId.HasValue Then
                cmd.ExecuteNonQuery()
            Else
                newCustomerId = Convert.ToInt32(cmd.ExecuteScalar())
                CustomerId = newCustomerId
            End If

            ' --- Save contacts ---
            Dim view As DevExpress.XtraGrid.Views.Grid.GridView = CType(GridControl1.MainView, DevExpress.XtraGrid.Views.Grid.GridView)
            For i As Integer = 0 To view.RowCount - 1
                Dim contactIdObj As Object = view.GetRowCellValue(i, "ContactID")
                Dim contactName As String = view.GetRowCellValue(i, "ContactName").ToString()
                Dim contactPhone As String = view.GetRowCellValue(i, "Phone").ToString()

                If String.IsNullOrWhiteSpace(contactName) AndAlso String.IsNullOrWhiteSpace(contactPhone) Then
                    ' Delete if exists
                    If contactIdObj IsNot Nothing AndAlso contactIdObj IsNot DBNull.Value Then
                        Using cmdDelete As New SqlCommand("DeleteContact", con)
                            cmdDelete.CommandType = CommandType.StoredProcedure
                            cmdDelete.Parameters.AddWithValue("@ContactID", Convert.ToInt32(contactIdObj))
                            cmdDelete.ExecuteNonQuery()
                        End Using
                    End If
                    Continue For
                End If

                If contactIdObj Is Nothing OrElse contactIdObj Is DBNull.Value OrElse Convert.ToInt32(contactIdObj) < 0 Then
                    ' Insert new contact
                    Using cmdInsert As New SqlCommand("InsertContact", con)
                        cmdInsert.CommandType = CommandType.StoredProcedure
                        cmdInsert.Parameters.AddWithValue("@CustomerID", CustomerId.Value)
                        cmdInsert.Parameters.AddWithValue("@ContactName", contactName)
                        cmdInsert.Parameters.AddWithValue("@Phone", contactPhone)
                        cmdInsert.ExecuteNonQuery()
                    End Using
                Else
                    ' Update existing contact
                    Using cmdUpdate As New SqlCommand("UpdateContact", con)
                        cmdUpdate.CommandType = CommandType.StoredProcedure
                        cmdUpdate.Parameters.AddWithValue("@ContactID", Convert.ToInt32(contactIdObj))
                        cmdUpdate.Parameters.AddWithValue("@ContactName", contactName)
                        cmdUpdate.Parameters.AddWithValue("@Phone", contactPhone)
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
                        Using cmdDelete As New SqlCommand("DeleteContact", con)
                            cmdDelete.CommandType = CommandType.StoredProcedure
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
