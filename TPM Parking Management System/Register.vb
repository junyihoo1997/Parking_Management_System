Imports System.Speech.Synthesis
Public Class Register
    Dim spc As New SpeechSynthesizer
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        Mainmenu.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Dim reply As DialogResult
        'or Dim reply As MsgBoxResult

        reply = MessageBox.Show("Do you want to exit the program?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If reply = DialogResult.Yes Then
            Application.Exit()
        End If
        'If using msgboxresult
        'If reply = MsgBoxResult.Yes Then...
        'If reply = 6 Then
    End Sub

    Private Sub RenewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RenewToolStripMenuItem.Click
        Me.Close()
        Renew.Show()
    End Sub

    Private Sub WithdrawToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WithdrawToolStripMenuItem.Click
        Me.Close()
        Withdraw.Show()
    End Sub

    Private Sub UpdateDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateDetailsToolStripMenuItem.Click
        Me.Close()
        Update1.Show()
    End Sub


    Private Sub ViewToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ViewToolStripMenuItem1.Click
        Me.Close()
        View.Show()
    End Sub

    Private Sub PaymentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PaymentToolStripMenuItem.Click
        Me.Close()
        Payment.Show()
    End Sub

    Private Sub btnSystemAcc_Click(sender As Object, e As EventArgs) Handles btnSystemAcc.Click
        If m = "Staff" Then
            MessageBox.Show("You have no right to register system account!")
            btnSystemAcc.Enabled = False
        ElseIf m = "Admin" Then
            MessageBox.Show("Welcome Admin!")
            btnSystemAcc.Enabled = True
            Me.Close()
            RegisterSystem.Show()
        End If
    End Sub

    Private Sub btnOwnerDetail_Click(sender As Object, e As EventArgs) Handles btnOwner.Click
        Me.Close()
        RegisterOwner.Show()
    End Sub

    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        spc.SpeakAsync("Please choose the option below to register")
    End Sub

    Private Sub AboutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem1.Click
        Me.Close()
        About.Show()
    End Sub
End Class

