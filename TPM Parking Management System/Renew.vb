Imports System.Data.OleDb
Imports System.Speech.Synthesis
Public Class Renew
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
    Private Sub btnBack_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Mainmenu.Show()
    End Sub

    Private Sub Renew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        spc.SpeakAsync("Welcome to the renew page! Please enter the information the text box below to renew!")
        txtDateRegistered.Text = Now.ToString("ddd dd MMMM yyyy")

    End Sub

    Private Sub btnChooseParkingBay_Click(sender As Object, e As EventArgs) Handles btnChooseParkingBay.Click


        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "UPDATE PARKINGBAY SET [DateRegistered]= @DR, [DateExpired]= @DE, [Status]='Available' WHERE [ICNumber]= @ICN AND [ParkingSpaceID]= @PSID "
        cmd = New OleDbCommand(sql, conn)
        cmd.Parameters.AddWithValue("@ICN", txtICNumber.Text)
        cmd.Parameters.AddWithValue("@PSID", lblParkingSpaceID.Text)
        cmd.Parameters.AddWithValue("@DR", Date.Parse(txtDateRegistered.Text))
        cmd.Parameters.AddWithValue("@DE", Date.Parse(txtDateExpired.Text))
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            conn.Close()
            lblParkingSpaceID.Text = ""
            txtICNumber.Clear()
            txtDateRegistered.Clear()
            txtDateExpired.Clear()
            txtStatus.Clear()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        spc.SpeakAsync("Renew Parking Bay Successfully. Enter Next Parking Bay Renew Details.")
        MessageBox.Show("Renew Parking Bay Successfully. Enter Next Parking Bay Renew Details.")
        conn.Close()

        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "INSERT INTO PAYMENT(ParkingSpaceID,TotalPayment) VALUES (@ParkingSpaceID,@TotalPayment)"
        cmd = New OleDbCommand(sql, conn)
        cmd.Parameters.AddWithValue("@ParkingSpaceID", lblParkingSpaceID.Text)
        cmd.Parameters.AddWithValue("@TotalPayment", txtTotal.Text)
        conn.Close()




    End Sub
    Sub ClearAll()
        lblParkingSpaceID.Text = ""
        txtICNumber.Clear()
        txtDateExpired.Clear()
        cboDuration.Text = ""
        txtTotal.Clear()
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

    Private Sub btnBack_Click_1(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        Mainmenu.Show()
    End Sub
    Private Sub cboDuration_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDuration.SelectedIndexChanged
        month = Decimal.Parse(cboDuration.Text)
        total = txtParkingBayPayment.Text
        txtDateExpired.Text = DateAdd("m", Double.Parse(cboDuration.Text), Now).ToString("ddd dd MMMM yyyy")
        txtTotal.Text = total


    End Sub

    Private Sub txtICNumber_TextChanged(sender As Object, e As EventArgs) Handles txtICNumber.TextChanged

    End Sub

    Private Sub txtViewPSID_Click(sender As Object, e As EventArgs) Handles btnViewPSID.Click
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "SELECT ParkingSpaceID, Status FROM ParkingBay WHERE ICNumber =@ICN"
        cmd = New OleDbCommand(sql, conn)
        cmd.Parameters.AddWithValue("@ICN", txtICNumber.Text)
        ABC = cmd.ExecuteReader
        While ABC.Read()
            lblParkingSpaceID.Text = ABC("ParkingSpaceID").ToString
            txtStatus.Text = ABC("Status").ToString
        End While

        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "SELECT ParkingBayPayment FROM Payment WHERE ParkingSpaceID =@PSID"
        cmd = New OleDbCommand(sql, conn)
        cmd.Parameters.AddWithValue("@PSID", lblParkingSpaceID.Text)
        ABC = cmd.ExecuteReader
        While ABC.Read()
            txtParkingBayPayment.Text = ABC("ParkingBayPayment").ToString
        End While
    End Sub

    Private Sub txtTotal_TextChanged(sender As Object, e As EventArgs) Handles txtTotal.TextChanged

    End Sub

    Private Sub txtParkingBayPayment_TextChanged(sender As Object, e As EventArgs) Handles txtParkingBayPayment.TextChanged

    End Sub

    Private Sub AboutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem1.Click
        Me.Close()
        About.Show()
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

    Private Sub RegisterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegisterToolStripMenuItem.Click
        Me.Close()
        Register.Show()
    End Sub

    Private Sub dgvView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvView.CellContentClick

    End Sub
End Class