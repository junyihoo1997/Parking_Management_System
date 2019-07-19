Imports System.Data.OleDb
Imports System.Speech.Synthesis
Public Class LoginForm
    Dim spc As New SpeechSynthesizer
    Dim Connection As OleDbConnection
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim sql As String
        Connection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        sql = "Select * From LoginAccount where Username='" & txtUsername.Text & "' And Password='" & txtPassword.Text & "' And Role='" & cboRole.Text & "'"
        Connection.Open()
        cmd = New OleDbCommand(sql, Connection)
        dr = cmd.ExecuteReader
        If (dr.HasRows) Then
            MessageBox.Show("Welcome", "Login Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Mainmenu.Show()
            If Mainmenu.Visible Then
                Me.Hide()
            End If
        Else
            MessageBox.Show("Username or Password or Role Not Found", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        spc.SpeakAsync("Are you sure you want to exit the system? ")
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

    Private Sub txtUsername_GotFocus(sender As Object, e As EventArgs) Handles txtUsername.GotFocus
        ToolTip1.IsBalloon = True
        ToolTip1.InitialDelay = 10
        ToolTip1.SetToolTip(txtUsername, "Please enter your Username here")
    End Sub

    Private Sub txtPassword_GotFocus(sender As Object, e As EventArgs) Handles txtPassword.GotFocus
        ToolTip1.IsBalloon = True
        ToolTip1.InitialDelay = 10
        ToolTip1.SetToolTip(txtPassword, "Please enter your Password here")
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        spc.SpeakAsync("Welcome to TPM Parking Management system Login Page! Please insert the username and password to login! ")
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub cboRole_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboRole.SelectedIndexChanged
        m = cboRole.Text
    End Sub
End Class
