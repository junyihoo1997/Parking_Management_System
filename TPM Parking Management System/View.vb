Imports System.Speech.Synthesis
Public Class View
    Dim spc As New SpeechSynthesizer
    Private Sub btnOwner_Click(sender As Object, e As EventArgs) Handles btnOwner.Click
        Me.Close()
        ViewOwner.Show()
    End Sub

    Private Sub btnParkingBay_Click(sender As Object, e As EventArgs) Handles btnParkingBay.Click
        Me.Close()
        ViewParkingBay.Show()
    End Sub

    Private Sub btnPayment_Click(sender As Object, e As EventArgs) Handles btnPayment.Click
        Me.Close()
        ViewPayment.Show()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        Mainmenu.Show()
    End Sub

    Private Sub View_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        spc.SpeakAsync("Welcome the view page! Choose the option below to view the infomation!")
    End Sub
End Class