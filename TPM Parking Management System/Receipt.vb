Imports System.Data.OleDb
Public Class Receipt
    Private Sub Receipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet3.DataTable1' table. You can move, or remove it, as needed.
        'Me.DataTable1TableAdapter.Fill(Me.DataSet3.DataTable1)
        'TODO: This line of code loads data into the 'DataSet3.DataTable1' table. You can move, or remove it, as needed.
        'Me.DataTable1TableAdapter.Fill(Me.DataSet3.DataTable1)
        getFilterValues(Payment.psid)
        'Me.ReportViewer1.RefreshReport()
    End Sub
    Public Shared Sub getFilterValues(ByVal psid As Integer)
        Receipt.DataTable1TableAdapter.FillBy(Receipt.DataSet3.DataTable1, psid)
        Receipt.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim v = MessageBox.Show("Do you want to back to main menu?", "Do you want to back to main menu?", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If v = Windows.Forms.DialogResult.Yes Then
            Me.Close()
            Payment.Close()
            Mainmenu.Show()
        End If
    End Sub
End Class