Imports System.Data.OleDb
Imports System.Speech.Synthesis
Public Class ParkingBayLevel2
    Dim a As String
    Dim AA As Date
    Dim month As Decimal
    Dim percent As Decimal
    Dim deposit As Decimal
    Dim conn As OleDbConnection
    Dim cmd As OleDbCommand
    Dim sql As String
    Dim ABC As OleDbDataReader
    Dim spc As New SpeechSynthesizer

    Private Sub ParkingBayLevel2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        spc.SpeakAsync("Welcome to the Parking Bay Level 2! Please insert the information in the text box below!")
        lblICNumber.Text = h
        txtDateRegistered.Text = Now.ToString("ddd dd MMMM yyyy")
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "SELECT Status FROM ParkingBay WHERE ParkingSpaceID='Lv2-01'"
        cmd = New OleDbCommand(sql, conn)
        ABC = cmd.ExecuteReader
        ABC.Read()
        a = ABC.Item("Status")
        If a = "Assigned" Then
            btn1.BackColor = Color.Red
        Else
            btn1.BackColor = Color.Blue
        End If
        conn.Close()

        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "SELECT Status FROM ParkingBay WHERE ParkingSpaceID='Lv2-02'"
        cmd = New OleDbCommand(sql, conn)
        ABC = cmd.ExecuteReader
        ABC.Read()
        a = ABC.Item("Status")
        If a = "Assigned" Then
            btn2.BackColor = Color.Red
        Else
            btn2.BackColor = Color.Blue
        End If
        conn.Close()

        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "SELECT Status FROM ParkingBay WHERE ParkingSpaceID='Lv2-03'"
        cmd = New OleDbCommand(sql, conn)
        ABC = cmd.ExecuteReader
        ABC.Read()
        a = ABC.Item("Status")
        If a = "Assigned" Then
            btn3.BackColor = Color.Red
        Else
            btn3.BackColor = Color.Blue
        End If
        conn.Close()

        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "SELECT Status FROM ParkingBay WHERE ParkingSpaceID='Lv2-02'"
        cmd = New OleDbCommand(sql, conn)
        ABC = cmd.ExecuteReader
        ABC.Read()
        a = ABC.Item("Status")
        If a = "Assigned" Then
            btn2.BackColor = Color.Red
        Else
            btn2.BackColor = Color.Blue
        End If
        conn.Close()

        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "SELECT Status FROM ParkingBay WHERE ParkingSpaceID='Lv2-03'"
        cmd = New OleDbCommand(sql, conn)
        ABC = cmd.ExecuteReader
        ABC.Read()
        a = ABC.Item("Status")
        If a = "Assigned" Then
            btn3.BackColor = Color.Red
        Else
            btn3.BackColor = Color.Blue
        End If
        conn.Close()

        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "SELECT Status FROM ParkingBay WHERE ParkingSpaceID='Lv2-04'"
        cmd = New OleDbCommand(sql, conn)
        ABC = cmd.ExecuteReader
        ABC.Read()
        a = ABC.Item("Status")
        If a = "Assigned" Then
            btn4.BackColor = Color.Red
        Else
            btn4.BackColor = Color.Blue
        End If
        conn.Close()

        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "SELECT Status FROM ParkingBay WHERE ParkingSpaceID='Lv2-05'"
        cmd = New OleDbCommand(sql, conn)
        ABC = cmd.ExecuteReader
        ABC.Read()
        a = ABC.Item("Status")
        If a = "Assigned" Then
            btn5.BackColor = Color.Red
        Else
            btn5.BackColor = Color.Blue
        End If
        conn.Close()

        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "SELECT Status FROM ParkingBay WHERE ParkingSpaceID='Lv2-06'"
        cmd = New OleDbCommand(sql, conn)
        ABC = cmd.ExecuteReader
        ABC.Read()
        a = ABC.Item("Status")
        If a = "Assigned" Then
            btn6.BackColor = Color.Red
        Else
            btn6.BackColor = Color.Blue
        End If
        conn.Close()

        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "SELECT Status FROM ParkingBay WHERE ParkingSpaceID='Lv2-07'"
        cmd = New OleDbCommand(sql, conn)
        ABC = cmd.ExecuteReader
        ABC.Read()
        a = ABC.Item("Status")
        If a = "Assigned" Then
            btn7.BackColor = Color.Red
        Else
            btn7.BackColor = Color.Blue
        End If
        conn.Close()

        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "SELECT Status FROM ParkingBay WHERE ParkingSpaceID='Lv2-08'"
        cmd = New OleDbCommand(sql, conn)
        ABC = cmd.ExecuteReader
        ABC.Read()
        a = ABC.Item("Status")
        If a = "Assigned" Then
            btn8.BackColor = Color.Red
        Else
            btn8.BackColor = Color.Blue
        End If
        conn.Close()

        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "SELECT Status FROM ParkingBay WHERE ParkingSpaceID='Lv2-09'"
        cmd = New OleDbCommand(sql, conn)
        ABC = cmd.ExecuteReader
        ABC.Read()
        a = ABC.Item("Status")
        If a = "Assigned" Then
            btn9.BackColor = Color.Red
        Else
            btn9.BackColor = Color.Blue
        End If
        conn.Close()

        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "SELECT Status FROM ParkingBay WHERE ParkingSpaceID='Lv2-10'"
        cmd = New OleDbCommand(sql, conn)
        ABC = cmd.ExecuteReader
        ABC.Read()
        a = ABC.Item("Status")
        If a = "Assigned" Then
            btn10.BackColor = Color.Red
        Else
            btn10.BackColor = Color.Blue
        End If
        conn.Close()

        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "SELECT Status FROM ParkingBay WHERE ParkingSpaceID='Lv2-11'"
        cmd = New OleDbCommand(sql, conn)
        ABC = cmd.ExecuteReader
        ABC.Read()
        a = ABC.Item("Status")
        If a = "Assigned" Then
            btn11.BackColor = Color.Red
        Else
            btn11.BackColor = Color.Blue
        End If
        conn.Close()

        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "SELECT Status FROM ParkingBay WHERE ParkingSpaceID='Lv2-12'"
        cmd = New OleDbCommand(sql, conn)
        ABC = cmd.ExecuteReader
        ABC.Read()
        a = ABC.Item("Status")
        If a = "Assigned" Then
            btn12.BackColor = Color.Red
        Else
            btn12.BackColor = Color.Blue
        End If
        conn.Close()

        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "SELECT Status FROM ParkingBay WHERE ParkingSpaceID='Lv2-13'"
        cmd = New OleDbCommand(sql, conn)
        ABC = cmd.ExecuteReader
        ABC.Read()
        a = ABC.Item("Status")
        If a = "Assigned" Then
            btn13.BackColor = Color.Red
        Else
            btn13.BackColor = Color.Blue
        End If
        conn.Close()

        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "SELECT Status FROM ParkingBay WHERE ParkingSpaceID='Lv2-14'"
        cmd = New OleDbCommand(sql, conn)
        ABC = cmd.ExecuteReader
        ABC.Read()
        a = ABC.Item("Status")
        If a = "Assigned" Then
            btn14.BackColor = Color.Red
        Else
            btn14.BackColor = Color.Blue
        End If
        conn.Close()

        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "SELECT Status FROM ParkingBay WHERE ParkingSpaceID='Lv2-15'"
        cmd = New OleDbCommand(sql, conn)
        ABC = cmd.ExecuteReader
        ABC.Read()
        a = ABC.Item("Status")
        If a = "Assigned" Then
            btn15.BackColor = Color.Red
        Else
            btn15.BackColor = Color.Blue
        End If
        conn.Close()

        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "SELECT Status FROM ParkingBay WHERE ParkingSpaceID='Lv2-16'"
        cmd = New OleDbCommand(sql, conn)
        ABC = cmd.ExecuteReader
        ABC.Read()
        a = ABC.Item("Status")
        If a = "Assigned" Then
            btn16.BackColor = Color.Red
        Else
            btn16.BackColor = Color.Blue
        End If
        conn.Close()

        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "SELECT Status FROM ParkingBay WHERE ParkingSpaceID='Lv2-17'"
        cmd = New OleDbCommand(sql, conn)
        ABC = cmd.ExecuteReader
        ABC.Read()
        a = ABC.Item("Status")
        If a = "Assigned" Then
            btn17.BackColor = Color.Red
        Else
            btn17.BackColor = Color.Blue
        End If
        conn.Close()

        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "SELECT Status FROM ParkingBay WHERE ParkingSpaceID='Lv2-18'"
        cmd = New OleDbCommand(sql, conn)
        ABC = cmd.ExecuteReader
        ABC.Read()
        a = ABC.Item("Status")
        If a = "Assigned" Then
            btn18.BackColor = Color.Red
        Else
            btn18.BackColor = Color.Blue
        End If
        conn.Close()

        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "SELECT Status FROM ParkingBay WHERE ParkingSpaceID='Lv2-19'"
        cmd = New OleDbCommand(sql, conn)
        ABC = cmd.ExecuteReader
        ABC.Read()
        a = ABC.Item("Status")
        If a = "Assigned" Then
            btn19.BackColor = Color.Red
        Else
            btn19.BackColor = Color.Blue
        End If
        conn.Close()

        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "SELECT Status FROM ParkingBay WHERE ParkingSpaceID='Lv2-20'"
        cmd = New OleDbCommand(sql, conn)
        ABC = cmd.ExecuteReader
        ABC.Read()
        a = ABC.Item("Status")
        If a = "Assigned" Then
            btn20.BackColor = Color.Red
        Else
            btn20.BackColor = Color.Blue
        End If
        conn.Close()

        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "SELECT Status FROM ParkingBay WHERE ParkingSpaceID='Lv2-21'"
        cmd = New OleDbCommand(sql, conn)
        ABC = cmd.ExecuteReader
        ABC.Read()
        a = ABC.Item("Status")
        If a = "Assigned" Then
            btn21.BackColor = Color.Red
        Else
            btn21.BackColor = Color.Blue
        End If
        conn.Close()

        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "SELECT Status FROM ParkingBay WHERE ParkingSpaceID='Lv2-22'"
        cmd = New OleDbCommand(sql, conn)
        ABC = cmd.ExecuteReader
        ABC.Read()
        a = ABC.Item("Status")
        If a = "Assigned" Then
            btn22.BackColor = Color.Red
        Else
            btn22.BackColor = Color.Blue
        End If
        conn.Close()

        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "SELECT Status FROM ParkingBay WHERE ParkingSpaceID='Lv2-23'"
        cmd = New OleDbCommand(sql, conn)
        ABC = cmd.ExecuteReader
        ABC.Read()
        a = ABC.Item("Status")
        If a = "Assigned" Then
            btn23.BackColor = Color.Red
        Else
            btn23.BackColor = Color.Blue
        End If
        conn.Close()

        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "SELECT Status FROM ParkingBay WHERE ParkingSpaceID='Lv2-24'"
        cmd = New OleDbCommand(sql, conn)
        ABC = cmd.ExecuteReader
        ABC.Read()
        a = ABC.Item("Status")
        If a = "Assigned" Then
            btn24.BackColor = Color.Red
        Else
            btn24.BackColor = Color.Blue
        End If
        conn.Close()

        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "SELECT Status FROM ParkingBay WHERE ParkingSpaceID='Lv2-25'"
        cmd = New OleDbCommand(sql, conn)
        ABC = cmd.ExecuteReader
        ABC.Read()
        a = ABC.Item("Status")
        If a = "Assigned" Then
            btn25.BackColor = Color.Red
        Else
            btn25.BackColor = Color.Blue
        End If
        conn.Close()

        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "SELECT Status FROM ParkingBay WHERE ParkingSpaceID='Lv2-26'"
        cmd = New OleDbCommand(sql, conn)
        ABC = cmd.ExecuteReader
        ABC.Read()
        a = ABC.Item("Status")
        If a = "Assigned" Then
            btn26.BackColor = Color.Red
        Else
            btn26.BackColor = Color.Blue
        End If
        conn.Close()

        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "SELECT Status FROM ParkingBay WHERE ParkingSpaceID='Lv2-27'"
        cmd = New OleDbCommand(sql, conn)
        ABC = cmd.ExecuteReader
        ABC.Read()
        a = ABC.Item("Status")
        If a = "Assigned" Then
            btn27.BackColor = Color.Red
        Else
            btn27.BackColor = Color.Blue
        End If
        conn.Close()

        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "SELECT Status FROM ParkingBay WHERE ParkingSpaceID='Lv2-28'"
        cmd = New OleDbCommand(sql, conn)
        ABC = cmd.ExecuteReader
        ABC.Read()
        a = ABC.Item("Status")
        If a = "Assigned" Then
            btn28.BackColor = Color.Red
        Else
            btn28.BackColor = Color.Blue
        End If
        conn.Close()

        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "SELECT Status FROM ParkingBay WHERE ParkingSpaceID='Lv2-29'"
        cmd = New OleDbCommand(sql, conn)
        ABC = cmd.ExecuteReader
        ABC.Read()
        a = ABC.Item("Status")
        If a = "Assigned" Then
            btn29.BackColor = Color.Red
        Else
            btn29.BackColor = Color.Blue
        End If
        conn.Close()

        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "SELECT Status FROM ParkingBay WHERE ParkingSpaceID='Lv2-30'"
        cmd = New OleDbCommand(sql, conn)
        ABC = cmd.ExecuteReader
        ABC.Read()
        a = ABC.Item("Status")
        If a = "Assigned" Then
            btn30.BackColor = Color.Red
        Else
            btn30.BackColor = Color.Blue
        End If
        conn.Close()

        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "SELECT Status FROM ParkingBay WHERE ParkingSpaceID='Lv2-31'"
        cmd = New OleDbCommand(sql, conn)
        ABC = cmd.ExecuteReader
        ABC.Read()
        a = ABC.Item("Status")
        If a = "Assigned" Then
            btn31.BackColor = Color.Red
        Else
            btn31.BackColor = Color.Blue
        End If
        conn.Close()

        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "SELECT Status FROM ParkingBay WHERE ParkingSpaceID='Lv2-32'"
        cmd = New OleDbCommand(sql, conn)
        ABC = cmd.ExecuteReader
        ABC.Read()
        a = ABC.Item("Status")
        If a = "Assigned" Then
            btn32.BackColor = Color.Red
        Else
            btn32.BackColor = Color.Blue
        End If
        conn.Close()

        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "SELECT Status FROM ParkingBay WHERE ParkingSpaceID='Lv2-33'"
        cmd = New OleDbCommand(sql, conn)
        ABC = cmd.ExecuteReader
        ABC.Read()
        a = ABC.Item("Status")
        If a = "Assigned" Then
            btn33.BackColor = Color.Red
        Else
            btn33.BackColor = Color.Blue
        End If
        conn.Close()

        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "SELECT Status FROM ParkingBay WHERE ParkingSpaceID='Lv2-34'"
        cmd = New OleDbCommand(sql, conn)
        ABC = cmd.ExecuteReader
        ABC.Read()
        a = ABC.Item("Status")
        If a = "Assigned" Then
            btn34.BackColor = Color.Red
        Else
            btn34.BackColor = Color.Blue
        End If
        conn.Close()

        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "SELECT Status FROM ParkingBay WHERE ParkingSpaceID='Lv2-35'"
        cmd = New OleDbCommand(sql, conn)
        ABC = cmd.ExecuteReader
        ABC.Read()
        a = ABC.Item("Status")
        If a = "Assigned" Then
            btn35.BackColor = Color.Red
        Else
            btn35.BackColor = Color.Blue
        End If
        conn.Close()

        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "SELECT Status FROM ParkingBay WHERE ParkingSpaceID='Lv2-36'"
        cmd = New OleDbCommand(sql, conn)
        ABC = cmd.ExecuteReader
        ABC.Read()
        a = ABC.Item("Status")
        If a = "Assigned" Then
            btn36.BackColor = Color.Red
        Else
            btn36.BackColor = Color.Blue
        End If
        conn.Close()

        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "SELECT Status FROM ParkingBay WHERE ParkingSpaceID='Lv2-37'"
        cmd = New OleDbCommand(sql, conn)
        ABC = cmd.ExecuteReader
        ABC.Read()
        a = ABC.Item("Status")
        If a = "Assigned" Then
            btn37.BackColor = Color.Red
        Else
            btn37.BackColor = Color.Blue
        End If
        conn.Close()

        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "SELECT Status FROM ParkingBay WHERE ParkingSpaceID='Lv2-38'"
        cmd = New OleDbCommand(sql, conn)
        ABC = cmd.ExecuteReader
        ABC.Read()
        a = ABC.Item("Status")
        If a = "Assigned" Then
            btn38.BackColor = Color.Red
        Else
            btn38.BackColor = Color.Blue
        End If
        conn.Close()

        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "SELECT Status FROM ParkingBay WHERE ParkingSpaceID='Lv2-39'"
        cmd = New OleDbCommand(sql, conn)
        ABC = cmd.ExecuteReader
        ABC.Read()
        a = ABC.Item("Status")
        If a = "Assigned" Then
            btn39.BackColor = Color.Red
        Else
            btn39.BackColor = Color.Blue
        End If
        conn.Close()

        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "SELECT Status FROM ParkingBay WHERE ParkingSpaceID='Lv2-40'"
        cmd = New OleDbCommand(sql, conn)
        ABC = cmd.ExecuteReader
        ABC.Read()
        a = ABC.Item("Status")
        If a = "Assigned" Then
            btn40.BackColor = Color.Red
        Else
            btn40.BackColor = Color.Blue
        End If
        conn.Close()

        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "SELECT Status FROM ParkingBay WHERE ParkingSpaceID='Lv2-41'"
        cmd = New OleDbCommand(sql, conn)
        ABC = cmd.ExecuteReader
        ABC.Read()
        a = ABC.Item("Status")
        If a = "Assigned" Then
            btn41.BackColor = Color.Red
        Else
            btn41.BackColor = Color.Blue
        End If
        conn.Close()

        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "SELECT Status FROM ParkingBay WHERE ParkingSpaceID='Lv2-42'"
        cmd = New OleDbCommand(sql, conn)
        ABC = cmd.ExecuteReader
        ABC.Read()
        a = ABC.Item("Status")
        If a = "Assigned" Then
            btn42.BackColor = Color.Red
        Else
            btn42.BackColor = Color.Blue
        End If
        conn.Close()

        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "SELECT Status FROM ParkingBay WHERE ParkingSpaceID='Lv2-43'"
        cmd = New OleDbCommand(sql, conn)
        ABC = cmd.ExecuteReader
        ABC.Read()
        a = ABC.Item("Status")
        If a = "Assigned" Then
            btn43.BackColor = Color.Red
        Else
            btn43.BackColor = Color.Blue
        End If
        conn.Close()

        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "SELECT Status FROM ParkingBay WHERE ParkingSpaceID='Lv2-44'"
        cmd = New OleDbCommand(sql, conn)
        ABC = cmd.ExecuteReader
        ABC.Read()
        a = ABC.Item("Status")
        If a = "Assigned" Then
            btn44.BackColor = Color.Red
        Else
            btn44.BackColor = Color.Blue
        End If
        conn.Close()

        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "SELECT Status FROM ParkingBay WHERE ParkingSpaceID='Lv2-45'"
        cmd = New OleDbCommand(sql, conn)
        ABC = cmd.ExecuteReader
        ABC.Read()
        a = ABC.Item("Status")
        If a = "Assigned" Then
            btn45.BackColor = Color.Red
        Else
            btn45.BackColor = Color.Blue
        End If
        conn.Close()

        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "SELECT Status FROM ParkingBay WHERE ParkingSpaceID='Lv2-46'"
        cmd = New OleDbCommand(sql, conn)
        ABC = cmd.ExecuteReader
        ABC.Read()
        a = ABC.Item("Status")
        If a = "Assigned" Then
            btn46.BackColor = Color.Red
        Else
            btn46.BackColor = Color.Blue
        End If
        conn.Close()

        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "SELECT Status FROM ParkingBay WHERE ParkingSpaceID='Lv2-47'"
        cmd = New OleDbCommand(sql, conn)
        ABC = cmd.ExecuteReader
        ABC.Read()
        a = ABC.Item("Status")
        If a = "Assigned" Then
            btn47.BackColor = Color.Red
        Else
            btn47.BackColor = Color.Blue
        End If
        conn.Close()

        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "SELECT Status FROM ParkingBay WHERE ParkingSpaceID='Lv2-48'"
        cmd = New OleDbCommand(sql, conn)
        ABC = cmd.ExecuteReader
        ABC.Read()
        a = ABC.Item("Status")
        If a = "Assigned" Then
            btn48.BackColor = Color.Red
        Else
            btn48.BackColor = Color.Blue
        End If
        conn.Close()

        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "SELECT Status FROM ParkingBay WHERE ParkingSpaceID='Lv2-49'"
        cmd = New OleDbCommand(sql, conn)
        ABC = cmd.ExecuteReader
        ABC.Read()
        a = ABC.Item("Status")
        If a = "Assigned" Then
            btn49.BackColor = Color.Red
        Else
            btn49.BackColor = Color.Blue
        End If
        conn.Close()

        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "SELECT Status FROM ParkingBay WHERE ParkingSpaceID='Lv2-50'"
        cmd = New OleDbCommand(sql, conn)
        ABC = cmd.ExecuteReader
        ABC.Read()
        a = ABC.Item("Status")
        If a = "Assigned" Then
            btn50.BackColor = Color.Red
        Else
            btn50.BackColor = Color.Blue
        End If
        conn.Close()
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "SELECT Status FROM ParkingBay WHERE ParkingSpaceID='Lv2-01'"
        cmd = New OleDbCommand(sql, conn)
        ABC = cmd.ExecuteReader
        While ABC.Read()
            txtStatus.Text = ABC("Status").ToString
        End While
        txtParkingSpaceID.Text = btn1.Text
        If txtStatus.Text = "Assigned" Then
            btn1.BackColor = Color.Red
        Else
            btn1.BackColor = Color.Blue
        End If
        conn.Close()
    End Sub
    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "SELECT Status FROM ParkingBay WHERE ParkingSpaceID='Lv2-02'"
        cmd = New OleDbCommand(sql, conn)
        ABC = cmd.ExecuteReader
        While ABC.Read()
            txtStatus.Text = ABC("Status").ToString
        End While
        txtParkingSpaceID.Text = btn2.Text
        If txtStatus.Text = "Assigned" Then
            btn2.BackColor = Color.Red
        Else
            btn2.BackColor = Color.Blue
        End If
        conn.Close()
    End Sub
    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "SELECT Status FROM ParkingBay WHERE ParkingSpaceID='Lv2-03'"
        cmd = New OleDbCommand(sql, conn)
        ABC = cmd.ExecuteReader
        While ABC.Read()
            txtStatus.Text = ABC("Status").ToString
        End While
        txtParkingSpaceID.Text = btn3.Text
        If txtStatus.Text = "Assigned" Then
            btn3.BackColor = Color.Red
        Else
            btn3.BackColor = Color.Blue
        End If
        conn.Close()
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "SELECT Status FROM ParkingBay WHERE ParkingSpaceID='Lv2-04'"
        cmd = New OleDbCommand(sql, conn)
        ABC = cmd.ExecuteReader
        While ABC.Read()
            txtStatus.Text = ABC("Status").ToString
        End While
        txtParkingSpaceID.Text = btn4.Text
        If txtStatus.Text = "Assigned" Then
            btn4.BackColor = Color.Red
        Else
            btn4.BackColor = Color.Blue
        End If
        conn.Close()
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "SELECT Status FROM ParkingBay WHERE ParkingSpaceID='Lv2-05'"
        cmd = New OleDbCommand(sql, conn)
        ABC = cmd.ExecuteReader
        While ABC.Read()
            txtStatus.Text = ABC("Status").ToString
        End While
        txtParkingSpaceID.Text = btn5.Text
        If txtStatus.Text = "Assigned" Then
            btn5.BackColor = Color.Red
        Else
            btn5.BackColor = Color.Blue
        End If
        conn.Close()
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "SELECT Status FROM ParkingBay WHERE ParkingSpaceID='Lv2-06'"
        cmd = New OleDbCommand(sql, conn)
        ABC = cmd.ExecuteReader
        While ABC.Read()
            txtStatus.Text = ABC("Status").ToString
        End While
        txtParkingSpaceID.Text = btn6.Text
        If txtStatus.Text = "Assigned" Then
            btn6.BackColor = Color.Red
        Else
            btn6.BackColor = Color.Blue
        End If
        conn.Close()
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "SELECT Status FROM ParkingBay WHERE ParkingSpaceID='Lv2-07'"
        cmd = New OleDbCommand(sql, conn)
        ABC = cmd.ExecuteReader
        While ABC.Read()
            txtStatus.Text = ABC("Status").ToString
        End While
        txtParkingSpaceID.Text = btn7.Text
        If txtStatus.Text = "Assigned" Then
            btn7.BackColor = Color.Red
        Else
            btn7.BackColor = Color.Blue
        End If
        conn.Close()
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "SELECT Status FROM ParkingBay WHERE ParkingSpaceID='Lv2-08'"
        cmd = New OleDbCommand(sql, conn)
        ABC = cmd.ExecuteReader
        While ABC.Read()
            txtStatus.Text = ABC("Status").ToString
        End While
        txtParkingSpaceID.Text = btn8.Text
        If txtStatus.Text = "Assigned" Then
            btn8.BackColor = Color.Red
        Else
            btn8.BackColor = Color.Blue
        End If
        conn.Close()
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "SELECT Status FROM ParkingBay WHERE ParkingSpaceID='Lv2-09'"
        cmd = New OleDbCommand(sql, conn)
        ABC = cmd.ExecuteReader
        While ABC.Read()
            txtStatus.Text = ABC("Status").ToString
        End While
        txtParkingSpaceID.Text = btn9.Text
        If txtStatus.Text = "Assigned" Then
            btn9.BackColor = Color.Red
        Else
            btn9.BackColor = Color.Blue
        End If
        conn.Close()
    End Sub

    Private Sub btn10_Click(sender As Object, e As EventArgs) Handles btn10.Click
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "SELECT Status FROM ParkingBay WHERE ParkingSpaceID='Lv2-10'"
        cmd = New OleDbCommand(sql, conn)
        ABC = cmd.ExecuteReader
        While ABC.Read()
            txtStatus.Text = ABC("Status").ToString
        End While
        txtParkingSpaceID.Text = btn10.Text
        If txtStatus.Text = "Assigned" Then
            btn10.BackColor = Color.Red
        Else
            btn10.BackColor = Color.Blue
        End If
        conn.Close()
    End Sub

    Private Sub btn11_Click(sender As Object, e As EventArgs) Handles btn11.Click
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "SELECT Status FROM ParkingBay WHERE ParkingSpaceID='Lv2-11'"
        cmd = New OleDbCommand(sql, conn)
        ABC = cmd.ExecuteReader
        While ABC.Read()
            txtStatus.Text = ABC("Status").ToString
        End While
        txtParkingSpaceID.Text = btn11.Text
        If txtStatus.Text = "Assigned" Then
            btn11.BackColor = Color.Red
        Else
            btn11.BackColor = Color.Blue
        End If
        conn.Close()
    End Sub

    Private Sub btn12_Click(sender As Object, e As EventArgs) Handles btn12.Click
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "SELECT Status FROM ParkingBay WHERE ParkingSpaceID='Lv2-12'"
        cmd = New OleDbCommand(sql, conn)
        ABC = cmd.ExecuteReader
        While ABC.Read()
            txtStatus.Text = ABC("Status").ToString
        End While
        txtParkingSpaceID.Text = btn12.Text
        If txtStatus.Text = "Assigned" Then
            btn12.BackColor = Color.Red
        Else
            btn12.BackColor = Color.Blue
        End If
        conn.Close()
    End Sub

    Private Sub btn13_Click(sender As Object, e As EventArgs) Handles btn13.Click
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "SELECT Status FROM ParkingBay WHERE ParkingSpaceID='Lv2-13'"
        cmd = New OleDbCommand(sql, conn)
        ABC = cmd.ExecuteReader
        While ABC.Read()
            txtStatus.Text = ABC("Status").ToString
        End While
        txtParkingSpaceID.Text = btn13.Text
        If txtStatus.Text = "Assigned" Then
            btn13.BackColor = Color.Red
        Else
            btn13.BackColor = Color.Blue
        End If
        conn.Close()
    End Sub

    Private Sub btn14_Click(sender As Object, e As EventArgs) Handles btn14.Click
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "SELECT Status FROM ParkingBay WHERE ParkingSpaceID='Lv2-14'"
        cmd = New OleDbCommand(sql, conn)
        ABC = cmd.ExecuteReader
        While ABC.Read()
            txtStatus.Text = ABC("Status").ToString
        End While
        txtParkingSpaceID.Text = btn14.Text
        If txtStatus.Text = "Assigned" Then
            btn14.BackColor = Color.Red
        Else
            btn14.BackColor = Color.Blue
        End If
        conn.Close()
    End Sub

    Private Sub btn15_Click(sender As Object, e As EventArgs) Handles btn15.Click
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "SELECT Status FROM ParkingBay WHERE ParkingSpaceID='Lv2-15'"
        cmd = New OleDbCommand(sql, conn)
        ABC = cmd.ExecuteReader
        While ABC.Read()
            txtStatus.Text = ABC("Status").ToString
        End While
        txtParkingSpaceID.Text = btn15.Text
        If txtStatus.Text = "Assigned" Then
            btn15.BackColor = Color.Red
        Else
            btn15.BackColor = Color.Blue
        End If
        conn.Close()
    End Sub

    Private Sub btn16_Click(sender As Object, e As EventArgs) Handles btn16.Click
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "SELECT Status FROM ParkingBay WHERE ParkingSpaceID='Lv2-16'"
        cmd = New OleDbCommand(sql, conn)
        ABC = cmd.ExecuteReader
        While ABC.Read()
            txtStatus.Text = ABC("Status").ToString
        End While
        txtParkingSpaceID.Text = btn16.Text
        If txtStatus.Text = "Assigned" Then
            btn16.BackColor = Color.Red
        Else
            btn16.BackColor = Color.Blue
        End If
        conn.Close()
    End Sub

    Private Sub btn17_Click(sender As Object, e As EventArgs) Handles btn17.Click
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "SELECT Status FROM ParkingBay WHERE ParkingSpaceID='Lv2-17'"
        cmd = New OleDbCommand(sql, conn)
        ABC = cmd.ExecuteReader
        While ABC.Read()
            txtStatus.Text = ABC("Status").ToString
        End While
        txtParkingSpaceID.Text = btn17.Text
        If txtStatus.Text = "Assigned" Then
            btn17.BackColor = Color.Red
        Else
            btn17.BackColor = Color.Blue
        End If
        conn.Close()
    End Sub

    Private Sub btn18_Click(sender As Object, e As EventArgs) Handles btn18.Click
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "SELECT Status FROM ParkingBay WHERE ParkingSpaceID='Lv2-18'"
        cmd = New OleDbCommand(sql, conn)
        ABC = cmd.ExecuteReader
        While ABC.Read()
            txtStatus.Text = ABC("Status").ToString
        End While
        txtParkingSpaceID.Text = btn18.Text
        If txtStatus.Text = "Assigned" Then
            btn18.BackColor = Color.Red
        Else
            btn18.BackColor = Color.Blue
        End If
        conn.Close()
    End Sub

    Private Sub btn19_Click(sender As Object, e As EventArgs) Handles btn19.Click
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "SELECT Status FROM ParkingBay WHERE ParkingSpaceID='Lv2-19'"
        cmd = New OleDbCommand(sql, conn)
        ABC = cmd.ExecuteReader
        While ABC.Read()
            txtStatus.Text = ABC("Status").ToString
        End While
        txtParkingSpaceID.Text = btn19.Text
        If txtStatus.Text = "Assigned" Then
            btn19.BackColor = Color.Red
        Else
            btn19.BackColor = Color.Blue
        End If
        conn.Close()
    End Sub

    Private Sub btn20_Click(sender As Object, e As EventArgs) Handles btn20.Click
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "SELECT Status FROM ParkingBay WHERE ParkingSpaceID='Lv2-20'"
        cmd = New OleDbCommand(sql, conn)
        ABC = cmd.ExecuteReader
        While ABC.Read()
            txtStatus.Text = ABC("Status").ToString
        End While
        txtParkingSpaceID.Text = btn20.Text
        If txtStatus.Text = "Assigned" Then
            btn20.BackColor = Color.Red
        Else
            btn20.BackColor = Color.Blue
        End If
        conn.Close()
    End Sub

    Private Sub btn21_Click(sender As Object, e As EventArgs) Handles btn21.Click
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "SELECT Status FROM ParkingBay WHERE ParkingSpaceID='Lv2-21'"
        cmd = New OleDbCommand(sql, conn)
        ABC = cmd.ExecuteReader
        While ABC.Read()
            txtStatus.Text = ABC("Status").ToString
        End While
        txtParkingSpaceID.Text = btn21.Text
        If txtStatus.Text = "Assigned" Then
            btn21.BackColor = Color.Red
        Else
            btn21.BackColor = Color.Blue
        End If
        conn.Close()
    End Sub

    Private Sub btn22_Click(sender As Object, e As EventArgs) Handles btn22.Click
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "SELECT Status FROM ParkingBay WHERE ParkingSpaceID='Lv2-22'"
        cmd = New OleDbCommand(sql, conn)
        ABC = cmd.ExecuteReader
        While ABC.Read()
            txtStatus.Text = ABC("Status").ToString
        End While
        txtParkingSpaceID.Text = btn22.Text
        If txtStatus.Text = "Assigned" Then
            btn22.BackColor = Color.Red
        Else
            btn22.BackColor = Color.Blue
        End If
        conn.Close()
    End Sub

    Private Sub btn23_Click(sender As Object, e As EventArgs) Handles btn23.Click
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "SELECT Status FROM ParkingBay WHERE ParkingSpaceID='Lv2-23'"
        cmd = New OleDbCommand(sql, conn)
        ABC = cmd.ExecuteReader
        While ABC.Read()
            txtStatus.Text = ABC("Status").ToString
        End While
        txtParkingSpaceID.Text = btn23.Text
        If txtStatus.Text = "Assigned" Then
            btn23.BackColor = Color.Red
        Else
            btn23.BackColor = Color.Blue
        End If
        conn.Close()
    End Sub

    Private Sub btn24_Click(sender As Object, e As EventArgs) Handles btn24.Click
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "SELECT Status FROM ParkingBay WHERE ParkingSpaceID='Lv2-24'"
        cmd = New OleDbCommand(sql, conn)
        ABC = cmd.ExecuteReader
        While ABC.Read()
            txtStatus.Text = ABC("Status").ToString
        End While
        txtParkingSpaceID.Text = btn24.Text
        If txtStatus.Text = "Assigned" Then
            btn24.BackColor = Color.Red
        Else
            btn24.BackColor = Color.Blue
        End If
        conn.Close()
    End Sub

    Private Sub btn25_Click(sender As Object, e As EventArgs) Handles btn25.Click
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "SELECT Status FROM ParkingBay WHERE ParkingSpaceID='Lv2-25'"
        cmd = New OleDbCommand(sql, conn)
        ABC = cmd.ExecuteReader
        While ABC.Read()
            txtStatus.Text = ABC("Status").ToString
        End While
        txtParkingSpaceID.Text = btn25.Text
        If txtStatus.Text = "Assigned" Then
            btn25.BackColor = Color.Red
        Else
            btn25.BackColor = Color.Blue
        End If
        conn.Close()
    End Sub

    Private Sub btn26_Click(sender As Object, e As EventArgs) Handles btn26.Click
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "SELECT Status FROM ParkingBay WHERE ParkingSpaceID='Lv2-26'"
        cmd = New OleDbCommand(sql, conn)
        ABC = cmd.ExecuteReader
        While ABC.Read()
            txtStatus.Text = ABC("Status").ToString
        End While
        txtParkingSpaceID.Text = btn26.Text
        If txtStatus.Text = "Assigned" Then
            btn26.BackColor = Color.Red
        Else
            btn26.BackColor = Color.Blue
        End If
        conn.Close()
    End Sub

    Private Sub btn27_Click(sender As Object, e As EventArgs) Handles btn27.Click
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "SELECT Status FROM ParkingBay WHERE ParkingSpaceID='Lv2-27'"
        cmd = New OleDbCommand(sql, conn)
        ABC = cmd.ExecuteReader
        While ABC.Read()
            txtStatus.Text = ABC("Status").ToString
        End While
        txtParkingSpaceID.Text = btn27.Text
        If txtStatus.Text = "Assigned" Then
            btn27.BackColor = Color.Red
        Else
            btn27.BackColor = Color.Blue
        End If
        conn.Close()
    End Sub

    Private Sub btn28_Click(sender As Object, e As EventArgs) Handles btn28.Click
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "SELECT Status FROM ParkingBay WHERE ParkingSpaceID='Lv2-28'"
        cmd = New OleDbCommand(sql, conn)
        ABC = cmd.ExecuteReader
        While ABC.Read()
            txtStatus.Text = ABC("Status").ToString
        End While
        txtParkingSpaceID.Text = btn28.Text
        If txtStatus.Text = "Assigned" Then
            btn28.BackColor = Color.Red
        Else
            btn28.BackColor = Color.Blue
        End If
        conn.Close()
    End Sub

    Private Sub btn29_Click(sender As Object, e As EventArgs) Handles btn29.Click
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "SELECT Status FROM ParkingBay WHERE ParkingSpaceID='Lv2-29'"
        cmd = New OleDbCommand(sql, conn)
        ABC = cmd.ExecuteReader
        While ABC.Read()
            txtStatus.Text = ABC("Status").ToString
        End While
        txtParkingSpaceID.Text = btn29.Text
        If txtStatus.Text = "Assigned" Then
            btn29.BackColor = Color.Red
        Else
            btn29.BackColor = Color.Blue
        End If
        conn.Close()
    End Sub

    Private Sub btn30_Click(sender As Object, e As EventArgs) Handles btn30.Click
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "SELECT Status FROM ParkingBay WHERE ParkingSpaceID='Lv2-30'"
        cmd = New OleDbCommand(sql, conn)
        ABC = cmd.ExecuteReader
        While ABC.Read()
            txtStatus.Text = ABC("Status").ToString
        End While
        txtParkingSpaceID.Text = btn30.Text
        If txtStatus.Text = "Assigned" Then
            btn30.BackColor = Color.Red
        Else
            btn30.BackColor = Color.Blue
        End If
        conn.Close()
    End Sub

    Private Sub btn31_Click(sender As Object, e As EventArgs) Handles btn31.Click
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "SELECT Status FROM ParkingBay WHERE ParkingSpaceID='Lv2-31'"
        cmd = New OleDbCommand(sql, conn)
        ABC = cmd.ExecuteReader
        While ABC.Read()
            txtStatus.Text = ABC("Status").ToString
        End While
        txtParkingSpaceID.Text = btn31.Text
        If txtStatus.Text = "Assigned" Then
            btn31.BackColor = Color.Red
        Else
            btn31.BackColor = Color.Blue
        End If
        conn.Close()
    End Sub

    Private Sub btn32_Click(sender As Object, e As EventArgs) Handles btn32.Click
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "SELECT Status FROM ParkingBay WHERE ParkingSpaceID='Lv2-32'"
        cmd = New OleDbCommand(sql, conn)
        ABC = cmd.ExecuteReader
        While ABC.Read()
            txtStatus.Text = ABC("Status").ToString
        End While
        txtParkingSpaceID.Text = btn32.Text
        If txtStatus.Text = "Assigned" Then
            btn32.BackColor = Color.Red
        Else
            btn32.BackColor = Color.Blue
        End If
        conn.Close()
    End Sub

    Private Sub btn33_Click(sender As Object, e As EventArgs) Handles btn33.Click
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "SELECT Status FROM ParkingBay WHERE ParkingSpaceID='Lv2-33'"
        cmd = New OleDbCommand(sql, conn)
        ABC = cmd.ExecuteReader
        While ABC.Read()
            txtStatus.Text = ABC("Status").ToString
        End While
        txtParkingSpaceID.Text = btn33.Text
        If txtStatus.Text = "Assigned" Then
            btn33.BackColor = Color.Red
        Else
            btn33.BackColor = Color.Blue
        End If
        conn.Close()
    End Sub

    Private Sub btn34_Click(sender As Object, e As EventArgs) Handles btn34.Click
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "SELECT Status FROM ParkingBay WHERE ParkingSpaceID='Lv2-34'"
        cmd = New OleDbCommand(sql, conn)
        ABC = cmd.ExecuteReader
        While ABC.Read()
            txtStatus.Text = ABC("Status").ToString
        End While
        txtParkingSpaceID.Text = btn34.Text
        If txtStatus.Text = "Assigned" Then
            btn34.BackColor = Color.Red
        Else
            btn34.BackColor = Color.Blue
        End If
        conn.Close()
    End Sub

    Private Sub btn35_Click(sender As Object, e As EventArgs) Handles btn35.Click
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "SELECT Status FROM ParkingBay WHERE ParkingSpaceID='Lv2-35'"
        cmd = New OleDbCommand(sql, conn)
        ABC = cmd.ExecuteReader
        While ABC.Read()
            txtStatus.Text = ABC("Status").ToString
        End While
        txtParkingSpaceID.Text = btn35.Text
        If txtStatus.Text = "Assigned" Then
            btn35.BackColor = Color.Red
        Else
            btn35.BackColor = Color.Blue
        End If
        conn.Close()
    End Sub

    Private Sub btn36_Click(sender As Object, e As EventArgs) Handles btn36.Click
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "SELECT Status FROM ParkingBay WHERE ParkingSpaceID='Lv2-36'"
        cmd = New OleDbCommand(sql, conn)
        ABC = cmd.ExecuteReader
        While ABC.Read()
            txtStatus.Text = ABC("Status").ToString
        End While
        txtParkingSpaceID.Text = btn36.Text
        If txtStatus.Text = "Assigned" Then
            btn36.BackColor = Color.Red
        Else
            btn36.BackColor = Color.Blue
        End If
        conn.Close()
    End Sub

    Private Sub btn37_Click(sender As Object, e As EventArgs) Handles btn37.Click
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "SELECT Status FROM ParkingBay WHERE ParkingSpaceID='Lv2-37'"
        cmd = New OleDbCommand(sql, conn)
        ABC = cmd.ExecuteReader
        While ABC.Read()
            txtStatus.Text = ABC("Status").ToString
        End While
        txtParkingSpaceID.Text = btn37.Text
        If txtStatus.Text = "Assigned" Then
            btn37.BackColor = Color.Red
        Else
            btn37.BackColor = Color.Blue
        End If
        conn.Close()
    End Sub

    Private Sub btn38_Click(sender As Object, e As EventArgs) Handles btn38.Click
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "SELECT Status FROM ParkingBay WHERE ParkingSpaceID='Lv2-38'"
        cmd = New OleDbCommand(sql, conn)
        ABC = cmd.ExecuteReader
        While ABC.Read()
            txtStatus.Text = ABC("Status").ToString
        End While
        txtParkingSpaceID.Text = btn38.Text
        If txtStatus.Text = "Assigned" Then
            btn38.BackColor = Color.Red
        Else
            btn38.BackColor = Color.Blue
        End If
        conn.Close()
    End Sub

    Private Sub btn39_Click(sender As Object, e As EventArgs) Handles btn39.Click
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "SELECT Status FROM ParkingBay WHERE ParkingSpaceID='Lv2-39'"
        cmd = New OleDbCommand(sql, conn)
        ABC = cmd.ExecuteReader
        While ABC.Read()
            txtStatus.Text = ABC("Status").ToString
        End While
        txtParkingSpaceID.Text = btn39.Text
        If txtStatus.Text = "Assigned" Then
            btn39.BackColor = Color.Red
        Else
            btn39.BackColor = Color.Blue
        End If
        conn.Close()
    End Sub

    Private Sub btn40_Click(sender As Object, e As EventArgs) Handles btn40.Click
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "SELECT Status FROM ParkingBay WHERE ParkingSpaceID='Lv2-40'"
        cmd = New OleDbCommand(sql, conn)
        ABC = cmd.ExecuteReader
        While ABC.Read()
            txtStatus.Text = ABC("Status").ToString
        End While
        txtParkingSpaceID.Text = btn40.Text
        If txtStatus.Text = "Assigned" Then
            btn40.BackColor = Color.Red
        Else
            btn40.BackColor = Color.Blue
        End If
        conn.Close()
    End Sub

    Private Sub btn41_Click(sender As Object, e As EventArgs) Handles btn41.Click
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "SELECT Status FROM ParkingBay WHERE ParkingSpaceID='Lv2-41'"
        cmd = New OleDbCommand(sql, conn)
        ABC = cmd.ExecuteReader
        While ABC.Read()
            txtStatus.Text = ABC("Status").ToString
        End While
        txtParkingSpaceID.Text = btn41.Text
        If txtStatus.Text = "Assigned" Then
            btn41.BackColor = Color.Red
        Else
            btn41.BackColor = Color.Blue
        End If
        conn.Close()
    End Sub

    Private Sub btn42_Click(sender As Object, e As EventArgs) Handles btn42.Click
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "SELECT Status FROM ParkingBay WHERE ParkingSpaceID='Lv2-42'"
        cmd = New OleDbCommand(sql, conn)
        ABC = cmd.ExecuteReader
        While ABC.Read()
            txtStatus.Text = ABC("Status").ToString
        End While
        txtParkingSpaceID.Text = btn42.Text
        If txtStatus.Text = "Assigned" Then
            btn42.BackColor = Color.Red
        Else
            btn42.BackColor = Color.Blue
        End If
        conn.Close()
    End Sub

    Private Sub btn43_Click(sender As Object, e As EventArgs) Handles btn43.Click
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "SELECT Status FROM ParkingBay WHERE ParkingSpaceID='Lv2-43'"
        cmd = New OleDbCommand(sql, conn)
        ABC = cmd.ExecuteReader
        While ABC.Read()
            txtStatus.Text = ABC("Status").ToString
        End While
        txtParkingSpaceID.Text = btn43.Text
        If txtStatus.Text = "Assigned" Then
            btn43.BackColor = Color.Red
        Else
            btn43.BackColor = Color.Blue
        End If
        conn.Close()
    End Sub

    Private Sub btn44_Click(sender As Object, e As EventArgs) Handles btn44.Click
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "SELECT Status FROM ParkingBay WHERE ParkingSpaceID='Lv2-44'"
        cmd = New OleDbCommand(sql, conn)
        ABC = cmd.ExecuteReader
        While ABC.Read()
            txtStatus.Text = ABC("Status").ToString
        End While
        txtParkingSpaceID.Text = btn44.Text
        If txtStatus.Text = "Assigned" Then
            btn44.BackColor = Color.Red
        Else
            btn44.BackColor = Color.Blue
        End If
        conn.Close()
    End Sub

    Private Sub btn45_Click(sender As Object, e As EventArgs) Handles btn45.Click
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "SELECT Status FROM ParkingBay WHERE ParkingSpaceID='Lv2-45'"
        cmd = New OleDbCommand(sql, conn)
        ABC = cmd.ExecuteReader
        While ABC.Read()
            txtStatus.Text = ABC("Status").ToString
        End While
        txtParkingSpaceID.Text = btn45.Text
        If txtStatus.Text = "Assigned" Then
            btn45.BackColor = Color.Red
        Else
            btn45.BackColor = Color.Blue
        End If
        conn.Close()
    End Sub

    Private Sub btn46_Click(sender As Object, e As EventArgs) Handles btn46.Click
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "SELECT Status FROM ParkingBay WHERE ParkingSpaceID='Lv2-46'"
        cmd = New OleDbCommand(sql, conn)
        ABC = cmd.ExecuteReader
        While ABC.Read()
            txtStatus.Text = ABC("Status").ToString
        End While
        txtParkingSpaceID.Text = btn46.Text
        If txtStatus.Text = "Assigned" Then
            btn46.BackColor = Color.Red
        Else
            btn46.BackColor = Color.Blue
        End If
        conn.Close()
    End Sub

    Private Sub btn47_Click(sender As Object, e As EventArgs) Handles btn47.Click
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "SELECT Status FROM ParkingBay WHERE ParkingSpaceID='Lv2-47'"
        cmd = New OleDbCommand(sql, conn)
        ABC = cmd.ExecuteReader
        While ABC.Read()
            txtStatus.Text = ABC("Status").ToString
        End While
        txtParkingSpaceID.Text = btn47.Text
        If txtStatus.Text = "Assigned" Then
            btn47.BackColor = Color.Red
        Else
            btn47.BackColor = Color.Blue
        End If
        conn.Close()
    End Sub

    Private Sub btn48_Click(sender As Object, e As EventArgs) Handles btn48.Click
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "SELECT Status FROM ParkingBay WHERE ParkingSpaceID='Lv2-48'"
        cmd = New OleDbCommand(sql, conn)
        ABC = cmd.ExecuteReader
        While ABC.Read()
            txtStatus.Text = ABC("Status").ToString
        End While
        txtParkingSpaceID.Text = btn48.Text
        If txtStatus.Text = "Assigned" Then
            btn48.BackColor = Color.Red
        Else
            btn48.BackColor = Color.Blue
        End If
        conn.Close()
    End Sub

    Private Sub btn49_Click(sender As Object, e As EventArgs) Handles btn49.Click
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "SELECT Status FROM ParkingBay WHERE ParkingSpaceID='Lv2-49'"
        cmd = New OleDbCommand(sql, conn)
        ABC = cmd.ExecuteReader
        While ABC.Read()
            txtStatus.Text = ABC("Status").ToString
        End While
        txtParkingSpaceID.Text = btn49.Text
        If txtStatus.Text = "Assigned" Then
            btn49.BackColor = Color.Red
        Else
            btn49.BackColor = Color.Blue
        End If
        conn.Close()
    End Sub

    Private Sub btn50_Click(sender As Object, e As EventArgs) Handles btn50.Click
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "SELECT Status FROM ParkingBay WHERE ParkingSpaceID='Lv2-50'"
        cmd = New OleDbCommand(sql, conn)
        ABC = cmd.ExecuteReader
        While ABC.Read()
            txtStatus.Text = ABC("Status").ToString
        End While
        txtParkingSpaceID.Text = btn50.Text
        If txtStatus.Text = "Assigned" Then
            btn50.BackColor = Color.Red
        Else
            btn50.BackColor = Color.Blue
        End If
        conn.Close()
    End Sub
    Sub ClearAll()
        txtParkingSpaceID.Clear()
        txtDateRegistered.Clear()
        txtDepositPaid.Clear()
        txtDateExpired.Clear()
        txtStatus.Clear()
    End Sub


    Private Sub txtParkingSpaceID_GotFocus(sender As Object, e As EventArgs) Handles txtParkingSpaceID.GotFocus
        ToolTip1.IsBalloon = True
        ToolTip1.InitialDelay = 10
        ToolTip1.SetToolTip(txtParkingSpaceID, "Please enter parking space ID here")
    End Sub

    Private Sub txtDateRegistered_GotFocus(sender As Object, e As EventArgs) Handles txtDateRegistered.GotFocus
        ToolTip1.IsBalloon = True
        ToolTip1.InitialDelay = 10
        ToolTip1.SetToolTip(txtDateRegistered, "Please enter the date registered here")
    End Sub

    Private Sub txtDepositPaid_GotFocus(sender As Object, e As EventArgs) Handles txtDepositPaid.GotFocus
        ToolTip1.IsBalloon = True
        ToolTip1.InitialDelay = 10
        ToolTip1.SetToolTip(txtDepositPaid, "Please enter the amount of deposit paid here")
    End Sub

    Private Sub txtDateExpired_GotFocus(sender As Object, e As EventArgs) Handles txtDateExpired.GotFocus
        ToolTip1.IsBalloon = True
        ToolTip1.InitialDelay = 10
        ToolTip1.SetToolTip(txtDateExpired, "Please enter the date expired here")
    End Sub

    Private Sub txtStatus_GotFocus(sender As Object, e As EventArgs) Handles txtStatus.GotFocus
        ToolTip1.IsBalloon = True
        ToolTip1.InitialDelay = 10
        ToolTip1.SetToolTip(txtStatus, "Please enter the status of the parking here")
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


    Private Sub cboDuration_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDuration.SelectedIndexChanged
        txtDateExpired.Text = DateAdd("m", Double.Parse(cboDuration.Text), Now).ToString("ddd dd MMMM yyyy")
        month = Decimal.Parse(cboDuration.Text)
        deposit = 120 * (80 / 100)
        txtDepositPaid.Text = deposit
    End Sub

    Private Sub btnChooseParkingBay_Click_1(sender As Object, e As EventArgs) Handles btnChooseParkingBay.Click
        y = txtParkingSpaceID.Text
        z = txtDepositPaid.Text
        g = cboDuration.Text

        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "UPDATE PARKINGBAY SET [ICNumber]= @ICN, [DateRegistered]= @DR, [DepositPaid]= @DP, [DateExpired]= @DE, [Status]='Assigned' WHERE [ParkingSpaceID]= @PSID"
        cmd = New OleDbCommand(sql, conn)
        cmd.Parameters.AddWithValue("@ICN", lblICNumber.Text)
        cmd.Parameters.AddWithValue("@DR", Date.Parse(txtDateRegistered.Text))
        cmd.Parameters.AddWithValue("@DP", Decimal.Parse(txtDepositPaid.Text))
        cmd.Parameters.AddWithValue("@DE", Date.Parse(txtDateExpired.Text))
        cmd.Parameters.AddWithValue("@PSID", txtParkingSpaceID.Text)
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            conn.Close()
            txtParkingSpaceID.Clear()
            txtDateRegistered.Clear()
            txtDepositPaid.Clear()
            txtDateExpired.Clear()
            txtStatus.Clear()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VB.Net Assignment.accdb;Persist Security Info=False;")
        conn.Open()
        sql = "UPDATE PARKINGBAY SET [ICNumber] =@ICN, [DateRegistered]= @DR, [DepositPaid]= @DP, [DateExpired]= @DE, [Status]= 'Assigned' WHERE [ParkingSpaceID]= @PSID"
        cmd = New OleDbCommand(sql, conn)
        cmd.Parameters.AddWithValue("@ICN", lblICNumber.Text)
        cmd.Parameters.AddWithValue("@DR", (txtDateRegistered.Text))
        cmd.Parameters.AddWithValue("@DP", (txtDepositPaid.Text))
        cmd.Parameters.AddWithValue("@DE", (txtDateExpired.Text))
        cmd.Parameters.AddWithValue("@PSID", txtParkingSpaceID.Text)
        Dim i As Integer = cmd.ExecuteNonQuery()
        If (i >= 1) Then
            ToolStripStatusLabel1.Text = "Parking bay added successfully"
            ClearAll()
        Else

            ToolStripStatusLabel1.Text = "Unable to add parking bay. Please check the details"
        End If
        spc.SpeakAsync("Parking Bay Choose Successfully. Entering to payment.")
        MessageBox.Show("Parking Bay Choose Successfully. Entering to payment.")
        conn.Close()
        Me.Hide()
        Payment.Show()

    End Sub

    Private Sub btnClear_Click_1(sender As Object, e As EventArgs) Handles btnClear.Click
        txtParkingSpaceID.Clear()
        txtDateRegistered.Clear()
        txtDepositPaid.Clear()
        txtDateExpired.Clear()
        txtStatus.Clear()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        ParkingBaySelection.Show()
    End Sub

    Private Sub txtStatus_TextChanged(sender As Object, e As EventArgs) Handles txtStatus.TextChanged
        Dim r As String
        r = txtStatus.Text
        If r = "Assigned" Then
            MessageBox.Show("Parking Bay is Assigned")
            btnChooseParkingBay.Enabled = False
        Else
            btnChooseParkingBay.Enabled = True
        End If
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

    Private Sub MainmenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MainmenuToolStripMenuItem.Click
        Me.Close()
        Mainmenu.Show()
    End Sub
End Class