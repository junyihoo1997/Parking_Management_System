Imports System.Speech.Synthesis
Public Class ParkingBaySelection
    Dim spc As New SpeechSynthesizer
    Private Sub btnLevel1_Click(sender As Object, e As EventArgs) Handles btnLevel1.Click
        Me.Close()
        ParkingBayLevel1.Show()
    End Sub

    Private Sub btnLevel2_Click(sender As Object, e As EventArgs) Handles btnLevel2.Click
        Me.Close()
        ParkingBayLevel2.Show()
    End Sub

    Private Sub btnLevel3_Click(sender As Object, e As EventArgs) Handles btnLevel3.Click
        Me.Close()
        ParkingBayLevel3.Show()
    End Sub

    Private Sub btnLevel4_Click(sender As Object, e As EventArgs) Handles btnLevel4.Click
        Me.Close()
        ParkingBayLevel4.Show()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        Register.Show()
    End Sub

    Private Sub ParkingBaySelection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SPC.SpeakAsync("There are 4 level of Parking Bay. Please choose one to continue!")
    End Sub
End Class