Imports System.Data.SqlClient

Public Class Dashboard

    'Variable con for the sqlconnection string
    Dim con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\AcademicNexusPRO\AcademicNexusPRO\Database\ACADEMICNEXUS_DATABASE.mdf;Integrated Security=True;connect Timeout=30")

    'upon loading the dashboard
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CountStud()
        CountLec()
        CountDep()
    End Sub

    'count lecturer function
    Private Sub CountLec()
        Dim LNum As Integer
        con.open()
        Dim query = "select count(*) from LecturerTbl"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(query, con)
        LNum = cmd.ExecuteScalar
        NumLecturers.Text = LNum
        con.close()
    End Sub
    'count students function
    Private Sub CountStud()
        Dim StNum As Integer
        con.open()
        Dim query = "select count(*) from StudentTbl"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(query, con)
        StNum = cmd.ExecuteScalar
        NumStudents.Text = StNum
        con.close()
    End Sub
    'count departments function
    Private Sub CountDep()
        Dim UNum As Integer
        con.open()
        Dim query = "select count(*) from UnitsTbl"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(query, con)
        UNum = cmd.ExecuteScalar
        NumDepartments.Text = UNum
        con.close()
    End Sub

    Private Sub ExitLbl_Click(sender As Object, e As EventArgs) Handles ExitLbl.Click
        Application.Exit()
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click
        Students.Show()
        Me.Hide()
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        Units.Show()
        Me.Hide()
    End Sub


    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click
        Lecturers.Show()
        Me.Hide()
    End Sub
End Class