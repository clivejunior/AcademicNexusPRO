Imports System.Data.SqlClient

Public Class StudDetails

     'Variable con for the sqlconnection string
    Dim con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\AcademicNexusPRO\AcademicNexusPRO\Database\ACADEMICNEXUS_DATABASE.mdf;Integrated Security=True;connect Timeout=30")


    'exit label
    Private Sub ExitLbl_Click(sender As Object, e As EventArgs) Handles ExitLbl.Click
        Application.Exit()
    End Sub

    'go to dashboard
    Private Sub GoBackBtn_Click(sender As Object, e As EventArgs) Handles GoBackBtn.Click
        Dim obj = New Login()
        obj.Show()
        Me.Hide()
    End Sub

    'the fetch btn
    Private Sub FetchBtn_Click(sender As Object, e As EventArgs) Handles FetchBtn.Click
        FetchStudentDetails()
    End Sub

    Private Sub FetchStudentDetails()
        'function to fetch data
        If StudentNameTxt.Text = "" Then
            MessageBox.Show("Please fill out all details", "ACADEMIC NEXUS PRO", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        Else
            con.Open()
            Dim query = "select * from StudentTbl where StName='" & StudentNameTxt.Text & "' "
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, con)
            Dim dt As DataTable
            dt = New DataTable
            Dim sda As SqlDataAdapter
            sda = New SqlDataAdapter(cmd)
            sda.Fill(dt)
            For Each dr As DataRow In dt.Rows
                NameLbl.Text = dr(1).ToString()
                GenderLbl.Text = dr(2).ToString()
                DOBLbl.Text = dr(3).ToString()
                PhoneLbl.Text = dr(4).ToString()
                UnitLbl.Text = dr(5).ToString()
                FeeLbl.Text = dr(6).ToString()
            Next
            con.Close()
        End If
    End Sub
End Class