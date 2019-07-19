﻿Imports System.Data.OleDb
Imports System.Speech.Synthesis
Public Class ViewParkingBay
    Dim spc As New SpeechSynthesizer
    Dim conn As OleDbConnection
    Dim cmd As OleDbCommand
    Dim DBDataAdapter As OleDbDataAdapter
    Dim sql As String
    Dim A As DataTable
    Private Sub btnViewOwner_Click(sender As Object, e As EventArgs) Handles btnViewParkingBay.Click
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

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        View.Show()
    End Sub

    Private Sub ViewParkingBay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        spc.SpeakAsync("Click the button to view the Parking bay details!")
    End Sub

    Private Sub dgvView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvView.CellContentClick

    End Sub
End Class