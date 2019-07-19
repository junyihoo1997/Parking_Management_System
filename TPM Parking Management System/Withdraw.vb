Imports System.Data.OleDb
Imports System.Speech.Synthesis
Public Class Withdraw
    Dim spc As New SpeechSynthesizer
    Dim DBDataAdapter As OleDbDataAdapter
    Dim A As DataTable
    Dim month As Decimal
    Dim percent As Decimal
    Dim total As Decimal
    Dim conn As OleDbConnection
    Dim cmd As OleDbCommand
    Dim sql As String
    Dim ABC As OleDbDataReader
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        Mainmenu.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sql = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;"
        conn = New OleDbConnection(sql)
        DBDataAdapter = New OleDbDataAdapter()
        A = New DataTable()
        cmd = New OleDbCommand("ParkingBay")
        cmd.CommandType = CommandType.TableDirect
        DBDataAdapter.SelectCommand = cmd
        DBDataAdapter.SelectCommand.Connection = conn
        conn.Open()
        DBDataAdapter.Fill(A)
        dgvView.DataSource = A
        conn.Close()
    End Sub

    Private Sub txtViewPSID_Click(sender As Object, e As EventArgs) Handles txtViewPSID.Click
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "SELECT ParkingSpaceID, Status, DateRegistered, DateExpired, DepositPaid FROM ParkingBay WHERE ICNumber =@ICN"
        cmd = New OleDbCommand(sql, conn)
        cmd.Parameters.AddWithValue("@ICN", txtICNumber.Text)
        ABC = cmd.ExecuteReader
        While ABC.Read()
            txtParkingSpaceID.Text = ABC("ParkingSpaceID")
            txtStatus.Text = ABC("Status")
            txtDateRegistered.Text = ABC("DateRegistered")
            txtDateExpired.Text = ABC("DateExpired")
            txtDepositPaid.Text = ABC("DepositPaid")
        End While
    End Sub

    Private Sub btnChooseParkingBay_Click(sender As Object, e As EventArgs) Handles btnChooseParkingBay.Click
        Dim DTime As DateTime
        Dim Demo As Decimal
        DTime = Nothing
        Demo = Nothing
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "UPDATE PARKINGBAY SET ICNumber=@ICNumber, Status='Available', DateRegistered=@DateRegistered, DateExpired=@DateExpired, DepositPaid=@DepositPaid WHERE ParkingSpaceID=@ParkingSpace "
        cmd = New OleDbCommand(sql, conn)
        cmd.Parameters.AddWithValue("@ICNumber", Demo)
        cmd.Parameters.AddWithValue("@DateRegistered", DTime)
        cmd.Parameters.AddWithValue("@DateExpired", DTime)
        cmd.Parameters.AddWithValue("@DepositPaid", Demo)
        cmd.Parameters.AddWithValue("@DepositPaid", txtParkingSpaceID.Text)
        cmd.ExecuteNonQuery()
        Dim i As Integer = cmd.ExecuteNonQuery()
        If (i >= 1) Then
            ToolStripStatusLabel1.Text = "Parking bay released successfully"
            ClearAll()
        Else

            ToolStripStatusLabel1.Text = "Unable to released parking bay. Please check the details"
        End If
        spc.SpeakAsync("Parking Bay released Successfully. Enter Next Parking Bay Details.")
        MessageBox.Show("Parking Bay released Successfully. Enter Next Parking Bay Details.")
        conn.Close()
    End Sub
    Sub ClearAll()
        txtParkingSpaceID.Text = ""
        txtDateRegistered.Clear()
        txtDepositPaid.Clear()
        txtDateExpired.Clear()
        txtStatus.Clear()
    End Sub

    Private Sub Withdraw_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        spc.SpeakAsync("Welcome to withdraw page! Please enter the information text box below to release the parking bay!")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

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

    Private Sub AboutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem1.Click
        Me.Close()
        About.Show()
    End Sub

    Private Sub RegisterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegisterToolStripMenuItem.Click
        Me.Close()
        Register.Show()
    End Sub

    Private Sub RenewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RenewToolStripMenuItem.Click
        Me.Close()
        Renew.Show()
    End Sub

    Private Sub UpdateDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateDetailsToolStripMenuItem.Click
        Me.Close()
        Update1.Show()
    End Sub

    Private Sub ViewToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ViewToolStripMenuItem1.Click
        Me.Close()
        View.Show()
    End Sub
End Class