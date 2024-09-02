Imports System.Data.SqlClient

Public Class Students

    'Variable con for the sqlconnection string
    Dim con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\AcademicNexusPRO\AcademicNexusPRO\Database\ACADEMICNEXUS_DATABASE.mdf;Integrated Security=True;connect Timeout=30")


    'upon loading students form
    Private Sub Students_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillDepartment()
        Display()
    End Sub

    'The save button
    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        If NameTxt.Text = "" Or FeesTxt.Text = "" Or PhoneTxt.Text = "" Or GenderCmb.SelectedIndex = -1 Or UnitCmb.SelectedIndex = -1 Then
            MessageBox.Show("Please fill out missing information", "ACADEMIC NEXUS PRO", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
        Else
            Try
                con.open()
                Dim query = "insert into StudentTbl values('" & NameTxt.Text & "','" & GenderCmb.SelectedItem.ToString() & "','" & DOB.Text & "','" & PhoneTxt.Text & "', '" & UnitCmb.SelectedValue.ToString() & "','" & FeesTxt.Text & "')"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Student details captured!", "ACADEMIC NEXUS PRO", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
                con.close()
                Display()
                Reset()
            Catch ex As Exception
                MessageBox.Show("An error occured with the Database! contact support.", "ACADEMIC NEXUS PRO", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
            End Try
        End If
    End Sub

    'edit button click event
    'this is my comment
    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        If NameTxt.Text = "" Or PhoneTxt.Text = "" Or GenderCmb.SelectedIndex = -1 Or UnitCmb.SelectedIndex = -1 Then
            MessageBox.Show("Please fill out missing information", "ACADEMIC NEXUS PRO", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
        Else
            Try
                con.open()
                Dim query = "update StudentTbl set StName='" & NameTxt.Text & "',StGender='" & GenderCmb.SelectedItem.ToString() & "',StDOB='" & DOB.Text & "',StPhone='" & PhoneTxt.Text & "',StUnit='" & UnitCmb.SelectedValue.ToString() & "' where StId='" & key & "'"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Student details updated!", "ACADEMIC NEXUS PRO", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
                con.Close()
                Display()
                Reset()
            Catch ex As Exception
                MessageBox.Show("An error occured with the Database! contact support.", "ACADEMIC NEXUS PRO", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
            End Try
        End If
    End Sub

    'delete button click event
    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        If key = 0 Then
            MessageBox.Show("Select the student to delete", "ACADEMIC NEXUS PRO", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
        Else
            Try
                con.open()
                Dim query = "delete from StudentTbl where StId =" & key & ""
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Student deleted!", "ACADEMIC NEXUS PRO", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
                con.Close()
                Display()
                Reset()
            Catch ex As Exception
                MessageBox.Show("An error occured with the Database! contact support.", "ACADEMIC NEXUS PRO", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
            End Try
        End If
    End Sub

    'post onto textboxes from DGV; key to be used in edit and delete
    Dim key = 0
    Private Sub StudentDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles StudentDGV.CellMouseClick
        Dim row As DataGridViewRow = StudentDGV.Rows(e.RowIndex)
        NameTxt.Text = row.Cells(1).Value.ToString
        GenderCmb.SelectedItem = row.Cells(2).Value.ToString
        DOB.Text = row.Cells(3).Value.ToString
        PhoneTxt.Text = row.Cells(4).Value.ToString
        UnitCmb.SelectedItem = row.Cells(5).Value.ToString
        FeesTxt.Text = row.Cells(6).Value.ToString
        If NameTxt.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub

    'function to populate the DGV
    Private Sub FillDepartment()
        con.open()
        Dim query = "select * from UnitsTbl"
        Dim cmd As New SqlCommand(query, con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim Tbl As New DataTable()
        adapter.Fill(Tbl)
        UnitCmb.DataSource = Tbl
        UnitCmb.DisplayMember = "UnitName"
        UnitCmb.ValueMember = "UnitName"
        con.close()
    End Sub

    'function to retrieve data from StudentTbl to the DGV
    Private Sub Display()
        con.open()
        Dim query = "select * from StudentTbl"
        Dim cmd = New SqlCommand(query, con)
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        StudentDGV.DataSource = ds.Tables(0)
        con.Close()
    End Sub

    'Function to clear textboxes
    Private Sub Reset()
        NameTxt.Text = ""
        GenderCmb.SelectedIndex = -1
        DOB.Text = ""
        PhoneTxt.Text = ""
        UnitCmb.SelectedIndex = -1
        FeesTxt.Text = ""
    End Sub

    'function to get school fees to FeesTxt
    Private Sub GetFees()
        con.Close()
        con.Open()
        Dim cmd As SqlCommand = New SqlCommand("select * from UnitsTbl where UnitName like '" & UnitCmb.Text & "'", con)
        Dim dtr As SqlDataReader = cmd.ExecuteReader()
        While dtr.Read
            FeesTxt.Text = String.Format("{0:0.00}", dtr.Item(4))
        End While
        dtr.Close()
        con.Close()
    End Sub

    'insert fee to feetxt upon choosing department
    Private Sub DepCmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles UnitCmb.SelectedIndexChanged
        GetFees()
    End Sub

    'exit the app
    Private Sub ExitLbl_Click(sender As Object, e As EventArgs) Handles ExitLbl.Click
        Application.Exit()
    End Sub

    'reset function
    Private Sub ResetBtn_Click(sender As Object, e As EventArgs) Handles ResetBtn.Click
        Reset()
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        Units.Show()
        Me.Hide()
    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click
        Dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Lecturers.Show()
        Me.Hide()
    End Sub
End Class