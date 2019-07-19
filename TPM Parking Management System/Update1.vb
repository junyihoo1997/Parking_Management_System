Imports System.Data.OleDb
Imports System.Speech.Synthesis
Public Class Update1
    Dim spc As New SpeechSynthesizer
    Dim DBDataAdapter As OleDbDataAdapter
    Dim A As DataTable
    Dim conn As OleDbConnection
    Dim cmd As OleDbCommand
    Dim sql As String
    Private Sub btnBack_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Mainmenu.Show()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "UPDATE Owner SET [OwnerName] = @name, [ContactNumber] = @cno, [EmailAddress] = @email, [CarNumber] = @car WHERE [ICNumber] = @ic"
        cmd = New OleDbCommand(sql, conn)
        cmd.Parameters.AddWithValue("@name", txtOwnerName.Text)
        cmd.Parameters.AddWithValue("@cno", mskContactNumber.Text)
        cmd.Parameters.AddWithValue("@email", txtEmailAddress.Text)
        cmd.Parameters.AddWithValue("@car", txtCarNumber.Text)
        cmd.Parameters.AddWithValue("@ic", txtICNumber.Text)
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            conn.Close()
            txtICNumber.Clear()
            txtOwnerName.Clear()
            mskContactNumber.Clear()
            txtEmailAddress.Clear()
            txtCarNumber.Clear()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "UPDATE Owner SET [OwnerName] = @name, [ContactNumber] = @cno, [EmailAddress] = @email, [CarNumber] = @car WHERE [ICNumber] = @ic"
        cmd = New OleDbCommand(sql, conn)
        cmd.Parameters.AddWithValue("@name", txtOwnerName.Text)
        cmd.Parameters.AddWithValue("@cno", mskContactNumber.Text)
        cmd.Parameters.AddWithValue("@email", txtEmailAddress.Text)
        cmd.Parameters.AddWithValue("@car", txtCarNumber.Text)
        cmd.Parameters.AddWithValue("@ic", txtICNumber.Text)
        Dim i As Integer = cmd.ExecuteNonQuery()
        If (i >= 1) Then
            ToolStripStatusLabel1.Text = "Owner update successfully"
            ClearAll()
        Else
            ToolStripStatusLabel1.Text = "Unable to update owner record. Please check the details"
        End If
        spc.SpeakAsync("Update Successfully. Enter Next Owner Details.")
        MessageBox.Show("Update Successfully. Enter Next Owner Details.")
        conn.Close()
    End Sub
    Sub ClearAll()
        txtICNumber.Clear()
        txtOwnerName.Clear()
        mskContactNumber.Clear()
        txtEmailAddress.Clear()
        txtCarNumber.Clear()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtICNumber.Clear()
        txtOwnerName.Clear()
        mskContactNumber.Clear()
        txtEmailAddress.Clear()
        txtCarNumber.Clear()
    End Sub

    Private Sub btnBack_Click_1(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        Mainmenu.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        spc.SpeakAsync("Are you sure you want to exit?")
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

    Private Sub RegisterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegisterToolStripMenuItem.Click
        Me.Close()
        Register.Show()
    End Sub

    Private Sub RenewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RenewToolStripMenuItem.Click
        Me.Close()
        Renew.Show()
    End Sub

    Private Sub WithdrawToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WithdrawToolStripMenuItem.Click
        Me.Close()
        Withdraw.Show()
    End Sub
    Private Sub Update1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnViewOwner_Click(sender As Object, e As EventArgs) Handles btnViewOwner.Click
        spc.SpeakAsync("Welcome to the update page! Please enter the information in the text box below!")
        sql = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;"
        conn = New OleDbConnection(sql)
        DBDataAdapter = New OleDbDataAdapter()
        A = New DataTable()
        cmd = New OleDbCommand("Owner")
        cmd.CommandType = CommandType.TableDirect
        DBDataAdapter.SelectCommand = cmd
        DBDataAdapter.SelectCommand.Connection = conn
        conn.Open()
        DBDataAdapter.Fill(A)
        dgvView.DataSource = A
        conn.Close()
    End Sub

    Private Sub ViewToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ViewToolStripMenuItem1.Click
        Me.Close()
        View.Show()
    End Sub



    Private Sub AboutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem1.Click
        Me.Close()
        About.Show()
    End Sub
End Class