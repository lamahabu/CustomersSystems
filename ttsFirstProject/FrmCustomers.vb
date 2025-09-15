Imports System.Data.SqlClient

Public Class FrmCustomers
    Dim connectionString As String = "Server=LAPTOP-A4ULI8SL\SQLEXPRESS;Database=AccountingTTS;Trusted_Connection=True;"
    Private CustomerId As String = Nothing '

    Public Function GetCustomers() As DataTable
        Dim dt As New DataTable()
        Using con As New SqlConnection(connectionString)
            Dim query As String = "SELECT CustomerID, FirstName, Phone, Email, City FROM Customers"
            Using cmd As New SqlCommand(query, con)
                con.Open()
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    dt.Load(reader)
                End Using
            End Using
        End Using
        Return dt
    End Function

    Private Sub LoadCustomers()
        Dim dt As DataTable = GetCustomers()
        GridControl1.DataSource = dt
        CustomerName.FieldName = "FirstName"
        Email.FieldName = "Email"
        Phone.FieldName = "Phone"
        City.FieldName = "City"
        customerId = "CustomerID"
        GridControl1.RefreshDataSource()
    End Sub

    Private Sub RefreshButton_ItemClick(sender As Object, e As EventArgs) Handles RefreshButton.Click
        LoadCustomers()
    End Sub

    Private Sub RepositoryItemButtonEdit1_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles RepositoryItemButtonEdit1.ButtonClick

        Dim rowHandle As Integer = GridView1.FocusedRowHandle
        If rowHandle < 0 Then Exit Sub

        Dim customerId As Integer = CInt(GridView1.GetRowCellValue(rowHandle, "CustomerID"))

        Dim frmEdit As New FrmEditCustomer(customerId)
        frmEdit.ShowDialog()

        LoadCustomers()
    End Sub
    Private Sub Addbtn_ItemClick(sender As Object, e As EventArgs) Handles Addbtn.Click

        Dim frmEdit As New FrmEditCustomer(customerId)
        frmEdit.ShowDialog()

        LoadCustomers()
    End Sub

    Private Sub GridControl1_Click(sender As Object, e As EventArgs) Handles GridControl1.Click

    End Sub
End Class