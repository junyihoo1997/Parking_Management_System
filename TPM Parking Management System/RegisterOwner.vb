Imports System.Data.OleDb
Imports System.Speech.Synthesis
Public Class RegisterOwner
    Dim spc As New SpeechSynthesizer
    Dim conn As OleDbConnection
    Dim cmd As OleDbCommand
    Dim sql As String
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click

        h = txtICNumber.Text
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "INSERT INTO OWNER(ICNumber,OwnerName,ContactNumber,EmailAddress,CarNumber,Gender ) VALUES (@ICNumber,@OwnerName,@ContactNumber,@EmailAddress,@CarNumber,@Gender)"
        cmd = New OleDbCommand(sql, conn)
        cmd.Parameters.AddWithValue("@ICNumber", txtICNumber.Text)
        cmd.Parameters.AddWithValue("@OwnerName", txtOwnerName.Text)
        cmd.Parameters.AddWithValue("@ContactNumber", mskContactNumber.Text)
        cmd.Parameters.AddWithValue("@EmailAddress", txtEmailAddress.Text)
        cmd.Parameters.AddWithValue("@CarNumber", txtCarNumber.Text)
        cmd.Parameters.AddWithValue("@Gender", cboGender.Text)
        Dim i As Integer = cmd.ExecuteNonQuery()
        If (i >= 1) Then

            ToolStripStatusLabel1.Text = "Owner added successfully"
            ClearAll()
        Else
            ToolStripStatusLabel1.Text = "Unable to add owner record. Please check the details"
        End If
        spc.SpeakAsync("Register successfully! Entering to Parking Bay seclection menu!")
        MessageBox.Show("Register Successfully. Enter Next Owner Details.")
        conn.Close()
        Me.Close()
        ParkingBaySelection.Show()
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        Register.Show()
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtICNumber.Clear()
        txtOwnerName.Clear()
        mskContactNumber.Clear()
        txtEmailAddress.Clear()
        txtCarNumber.Clear()
    End Sub


    Sub ClearAll()
        txtICNumber.Clear()
        txtOwnerName.Clear()
        mskContactNumber.Clear()
        txtEmailAddress.Clear()
        txtCarNumber.Clear()
    End Sub

    Private Sub txtICNumber_GotFocus(sender As Object, e As EventArgs) Handles txtICNumber.GotFocus
        ToolTip1.IsBalloon = True
        ToolTip1.InitialDelay = 10
        ToolTip1.SetToolTip(txtICNumber, "Please enter owner IC Number or Passport Number here")
    End Sub

    Private Sub txtOwnerName_GotFocus(sender As Object, e As EventArgs) Handles txtOwnerName.GotFocus
        ToolTip1.IsBalloon = True
        ToolTip1.InitialDelay = 10
        ToolTip1.SetToolTip(txtOwnerName, "Please enter owner name here")
    End Sub

    Private Sub mskContactNumber_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles mskContactNumber.MaskInputRejected
        ToolTip1.IsBalloon = True
        ToolTip1.InitialDelay = 10
        ToolTip1.SetToolTip(mskContactNumber, "Please enter owner contact number here")
    End Sub

    Private Sub txtEmailAddress_GotFocus(sender As Object, e As EventArgs) Handles txtEmailAddress.GotFocus
        ToolTip1.IsBalloon = True
        ToolTip1.InitialDelay = 10
        ToolTip1.SetToolTip(txtEmailAddress, "Please enter owner email address here")
    End Sub

    Private Sub txtCarNumber_GotFocus(sender As Object, e As EventArgs) Handles txtCarNumber.GotFocus
        ToolTip1.IsBalloon = True
        ToolTip1.InitialDelay = 10
        ToolTip1.SetToolTip(txtCarNumber, "Please enter owner car number here")
    End Sub

    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        spc.SpeakAsync(" Welcome to register owner page. Please enter the information in the text box to register owner!")
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
End Class