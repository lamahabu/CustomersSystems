Imports System.ComponentModel
Imports System.Text
Imports System.Data.SqlClient

Partial Public Class Form1
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub BarBtnCustomers_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarBtnCustomers.ItemClick
        FrmCustomers.Show()
    End Sub
End Class
