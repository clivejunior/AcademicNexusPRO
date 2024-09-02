Imports System.Data.SqlClient

Public Class LecDetails

    'Variable con for the sqlconnection string
    Dim con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\AcademicNexusPRO\AcademicNexusPRO\Database\ACADEMICNEXUS_DATABASE.mdf;Integrated Security=True;connect Timeout=30")

    Private Sub GoBackBtn_Click(sender As Object, e As EventArgs) Handles GoBackBtn.Click
        Dim obj = New Login()
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub ExitLbl_Click(sender As Object, e As EventArgs) Handles ExitLbl.Click
        Application.Exit()
    End Sub

    Private Sub FetchBtn_Click(sender As Object, e As EventArgs) Handles FetchBtn.Click
        FetchLecDetails()
    End Sub

    Private Sub FetchLecDetails()
        'function to fetch data
        If LecNameTxt.Text = "" Then
            MessageBox.Show("Please fill out all details", "ACADEMIC NEXUS PRO", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        Else
            con.Open()
            Dim query = "select * from LecturerTbl where LName='" & LecNameTxt.Text & "' "
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, con)
            Dim dt As DataTable
            dt = New DataTable
            Dim sda As SqlDataAdapter
            sda = New SqlDataAdapter(cmd)
            sda.Fill(dt)
            For Each dr As DataRow In dt.Rows
                LNameLbl.Text = dr(1).ToString()
                LGenderLbl.Text = dr(2).ToString()
                LDOBLbl.Text = dr(3).ToString()
                LPhoneLbl.Text = dr(4).ToString()
                LUnitLbl.Text = dr(5).ToString()
                LAddressLbl.Text = dr(6).ToString()
            Next
            con.Close()
        End If
    End Sub

End Class