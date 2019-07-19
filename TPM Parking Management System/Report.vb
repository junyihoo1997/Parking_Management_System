Imports System.Speech.Synthesis
Public Class Report
    Dim spc As New SpeechSynthesizer
    Private Sub Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        spc.SpeakAsync("This is the report of the system!")
        'TODO: This line of code loads data into the 'DataSet1.DataTable1' table. You can move, or remove it, as needed.
        Me.DataTable1TableAdapter.Fill(Me.DataSet1.DataTable1)

        Me.ReportViewer1.RefreshReport()
    End Sub


    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        Mainmenu.Show()
    End Sub
End Class