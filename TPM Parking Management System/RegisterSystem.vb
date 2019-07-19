Imports System.Data.OleDb
Imports System.Speech.Synthesis
Public Class RegisterSystem
    Dim spc As New SpeechSynthesizer
    Dim conn As OleDbConnection
    Dim cmd As OleDbCommand
    Dim sql As String
    Private Sub RegisterSystem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        spc.SpeakAsync(" Welcome to register system page. Please enter the information in the text box to register system!")
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        Register.Show()
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "INSERT INTO LoginAccount ([Username],[Password],[FirstName],[LastName],[Role],[Gender]) VALUES (@Username, @Password, @FirstName, @LastName, @Role, @Gender)"

        cmd = New OleDbCommand(sql, conn)
        cmd.Parameters.AddWithValue("@Username", txtUsername.Text)
        cmd.Parameters.AddWithValue("@Password", txtPassword.Text)
        cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text)
        cmd.Parameters.AddWithValue("@LastName", txtLastName.Text)
        cmd.Parameters.AddWithValue("@Role", cboRole.Text)
        cmd.Parameters.AddWithValue("@Gender", cboGender.Text)
        Dim i As Integer = cmd.ExecuteNonQuery()
        If (i >= 1) Then
            ToolStripStatusLabel1.Text = "Staff or admin added successfully"
            ClearAll()
        Else
            ToolStripStatusLabel1.Text = "Unable to add account. Please check the details"
        End If
        spc.SpeakAsync("Register Successfully. Enter Next account Details.")
        MessageBox.Show("Register Successfully. Enter Next account Details.")
        conn.Close()
    End Sub
    Sub ClearAll()
        txtUsername.Clear()
        txtPassword.Clear()
        txtFirstName.Clear()
        txtLastName.Clear()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtUsername.Clear()
        txtPassword.Clear()
        txtFirstName.Clear()
        txtLastName.Clear()
    End Sub

    Private Sub txtUsername_GotFocus(sender As Object, e As EventArgs) Handles txtUsername.GotFocus
        ToolTip1.IsBalloon = True
        ToolTip1.InitialDelay = 10
        ToolTip1.SetToolTip(txtUsername, "Please enter username here")
    End Sub

    Private Sub txtPassword_GotFocus(sender As Object, e As EventArgs) Handles txtPassword.GotFocus
        ToolTip1.IsBalloon = True
        ToolTip1.InitialDelay = 10
        ToolTip1.SetToolTip(txtPassword, "Please enter password here")
    End Sub

    Private Sub txtFirstName_GotFocus(sender As Object, e As EventArgs) Handles txtFirstName.GotFocus
        ToolTip1.IsBalloon = True
        ToolTip1.InitialDelay = 10
        ToolTip1.SetToolTip(txtFirstName, "Please enter first name here")
    End Sub

    Private Sub txtLastName_GotFocus(sender As Object, e As EventArgs) Handles txtLastName.GotFocus
        ToolTip1.IsBalloon = True
        ToolTip1.InitialDelay = 10
        ToolTip1.SetToolTip(txtLastName, "Please enter last name here")
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



    Private Sub AboutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem1.Click
        Me.Close()
        About.Show()
    End Sub

    Private Sub RegisterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegisterToolStripMenuItem.Click
        Me.Close()
        Register.Show()
    End Sub
End Class