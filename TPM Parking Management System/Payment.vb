Imports System.Speech.Synthesis
Imports System.Data.OleDb
Public Class Payment
    Dim conn As OleDbConnection
    Dim cmd As OleDbCommand
    Dim sql As String
    Dim sql2 As String
    Dim ABC As OleDbDataReader
    Dim a As String
    Dim b As String
    Dim parkingpayment As Decimal
    Dim Total As Decimal
    Dim Deposit As String
    Dim spc As New SpeechSynthesizer
    Public psid As Integer
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtPaymentDate.Clear()
        lblParkingSpaceID.Text = ""
        txtParkingBayPayment.Clear()
        txtTotalPayment.Clear()
    End Sub

    Private Sub btnProceedPayment_Click(sender As Object, e As EventArgs) Handles btnProceedPayment.Click
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "INSERT INTO PAYMENT(PaymentDate,ParkingSpaceID,ParkingBayPayment,TotalPayment) VALUES (@PaymentDate,@ParkingSpaceID,@ParkingBayPayment,@TotalPayment)"
        cmd = New OleDbCommand(sql, conn)
        cmd.Parameters.AddWithValue("@PaymentDate", Date.Parse(txtPaymentDate.Text))
        cmd.Parameters.AddWithValue("@ParkingSpaceID", lblParkingSpaceID.Text)
        cmd.Parameters.AddWithValue("@ParkingBayPayment", Decimal.Parse(txtParkingBayPayment.Text))
        cmd.Parameters.AddWithValue("@TotalPayment", Decimal.Parse(txtTotalPayment.Text))
        Dim i As Integer = cmd.ExecuteNonQuery()
        If (i >= 1) Then
            spc.SpeakAsync("Payment paid successfully!")
            ToolStripStatusLabel1.Text = "Payment paid successfully"
            ClearAll()
        Else
            ToolStripStatusLabel1.Text = "Unable to proceed payment. Please check the details"
        End If
        MessageBox.Show("Payment Successfully.")


        conn.Close()

    End Sub
    Sub ClearAll()

        txtPaymentDate.Clear()

        txtParkingBayPayment.Clear()
        txtTotalPayment.Clear()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        ParkingBaySelection.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        spc.SpeakAsync("Are you Sure you want to exit?")
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

    Private Sub MainMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MainMenuToolStripMenuItem.Click
        Me.Close()
        Mainmenu.Show()
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

    Private Sub UpdateDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateDetailsToolStripMenuItem.Click
        Me.Close()
        Update1.Show()
    End Sub



    Private Sub txtPaymentDate_GotFocus(sender As Object, e As EventArgs) Handles txtPaymentDate.GotFocus
        ToolTip1.IsBalloon = True
        ToolTip1.InitialDelay = 10
        ToolTip1.SetToolTip(txtPaymentDate, "Please enter payment date here")
    End Sub

    Private Sub txtParkingSpaceID_GotFocus(sender As Object, e As EventArgs)
        ToolTip1.IsBalloon = True
        ToolTip1.InitialDelay = 10
        ToolTip1.SetToolTip(lblParkingSpaceID, "Please enter parking space ID here")
    End Sub

    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs)
        Me.Close()
        Mainmenu.Show()
    End Sub

    Private Sub Payment_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtPaymentDate.Text = Now.ToString("ddd dd MMMM yyyy")
        spc.SpeakAsync("Welcome to payment! Please insert the information in the text box below")
        lblParkingSpaceID.Text = y
        lblDepositPaid.Text = z
        cboLevel.Items.Add("Level 1")
        cboLevel.Items.Add("Level 2")
        cboLevel.Items.Add("Level 3")
        cboLevel.Items.Add("Level 4")

    End Sub
    Private Sub txtDepositPaid_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblDepositPaid_Click(sender As Object, e As EventArgs) Handles lblDepositPaid.Click

    End Sub

    Private Sub lblParkingSpaceID_Click(sender As Object, e As EventArgs) Handles lblParkingSpaceID.Click

    End Sub

    Private Sub cboLevel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboLevel.SelectedIndexChanged
        Deposit = z
        lblDepositPaid.Text = Deposit

        If cboLevel.Text = "Level 1" Then
            parkingpayment = 120 * g
        ElseIf cboLevel.Text = "Level 2" Then
            parkingpayment = 120 * g
        ElseIf cboLevel.Text = "Level 3" Then
            parkingpayment = 120 * g
        Else
            parkingpayment = 80 * g
        End If

        Total = Deposit + parkingpayment
        txtParkingBayPayment.Text = parkingpayment
        txtTotalPayment.Text = Total
        'parkingpayment = Decimal.Parse(txtParkingBayPayment.Text)
        'Total = Decimal.Parse(txtTotalPayment.Text)

    End Sub

    Private Sub btnPrintReceipt_Click(sender As Object, e As EventArgs) Handles btnPrintReceipt.Click
        Dim T As String
        T = lblParkingSpaceID.Text
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql2 = "Select * FROM Payment Where ParkingSpaceID=@ID"
        cmd = New OleDbCommand(sql2, conn)
        cmd.Parameters.AddWithValue("@ID", T)
        ABC = cmd.ExecuteReader
        If (ABC.HasRows) Then
            ABC.Read()
            psid = ABC.Item("PaymentCode")
        End If
        conn.Close()
        Receipt.Show()
    End Sub

    Private Sub AboutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem1.Click
        Me.Close()
        About.Show()
    End Sub
End Class