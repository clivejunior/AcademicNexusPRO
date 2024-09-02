Imports System.Data.SqlClient
Public Class Units

    'Variable con for the sqlconnection string
    Dim con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\AcademicNexusPRO\AcademicNexusPRO\Database\ACADEMICNEXUS_DATABASE.mdf;Integrated Security=True;connect Timeout=30")


    'save button click event
    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        If UnitNameTxt.Text = "" Or DescriptionTxt.Text = "" Or DurationTxt.Text = "" Or UnitFees.Text = "" Then
            MessageBox.Show("Please fill out missing information", "ACADEMIC NEXUS PRO", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
        Else
            Try
                con.open()
                Dim query = "insert into UnitsTbl values('" & UnitNameTxt.Text & "','" & DescriptionTxt.Text & "','" & DurationTxt.Text & "','" & UnitFees.Text & "')"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Unit saved successfully!", "ACADEMIC NEXUS PRO", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
                con.close()
                Display()
                Reset()
            Catch ex As Exception
                MessageBox.Show("An error occured with the Database! contact support.", "ACADEMIC NEXUS PRO", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
            End Try
        End If
    End Sub

    'edit button click event
    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        If UnitNameTxt.Text = "" Or DescriptionTxt.Text = "" Or DurationTxt.Text = "" Then
            MessageBox.Show("Please fill out missing information", "ACADEMIC NEXUS PRO", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
        Else
            Try
                con.open()
                Dim query = "update UnitsTbl set UnitName='" & UnitNameTxt.Text & "',UnitDescription='" & DescriptionTxt.Text & "',UnitDuration='" & DurationTxt.Text & "',UnitFees='" & UnitFees.Text & "' where UnitId='" & key & "'"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Unit information updated!", "ACADEMIC NEXUS PRO", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
                con.Close()
                Display()
                Reset()
            Catch ex As Exception
                MessageBox.Show("An error occured with the Database! contact support.", "ACADEMIC NEXUS PRO", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
            End Try
        End If
    End Sub

    'delete button upon clicking
    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        If key = 0 Then
            MessageBox.Show("Select the Unit to delete", "ACADEMIC NEXUS PRO", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
        Else
            Try
                con.open()
                Dim query = "delete from UnitsTbl where UnitId =" & key & ""
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Unit deleted!", "ACADEMIC NEXUS PRO", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
                con.Close()
                Display()
                Reset()
            Catch ex As Exception
                MessageBox.Show("An error occured with the Database! contact support.", "ACADEMIC NEXUS PRO", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
            End Try
        End If
    End Sub

    'reset button event- invokes reset function to clear txtboxes
    Private Sub ResetBtn_Click(sender As Object, e As EventArgs) Handles ResetBtn.Click
        Reset()
    End Sub

    'upon selecting data from the Datagridview-> put it in the textboxes; key to be used in delete and edit
    Dim key = 0
    Private Sub DepartmentDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles UnitDGV.CellMouseClick
        Dim row As DataGridViewRow = UnitDGV.Rows(e.RowIndex)
        UnitNameTxt.Text = row.Cells(1).Value.ToString
        DescriptionTxt.Text = row.Cells(2).Value.ToString
        DurationTxt.Text = row.Cells(3).Value.ToString
        UnitFees.Text = row.Cells(4).Value.ToString
        If UnitNameTxt.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub


    'function to retrieve data from UnitsTbl to the DGV
    Private Sub Display()
        con.open()
        Dim query = "select * from UnitsTbl"
        Dim cmd = New SqlCommand(query, con)
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        UnitDGV.DataSource = ds.Tables(0)
        con.Close()
    End Sub

    'Function to clear textboxes
    Private Sub Reset()
        UnitNameTxt.Text = ""
        DurationTxt.Text = ""
        DescriptionTxt.Text = ""
        UnitFees.Text = ""
    End Sub

    'exit application label
    Private Sub ExitLbl_Click(sender As Object, e As EventArgs) Handles ExitLbl.Click
        Application.Exit()
    End Sub

    'upon loading the form
    Private Sub Departments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Display()
    End Sub

    Private Sub GoToLecturers_Click(sender As Object, e As EventArgs) Handles GoToLecturers.Click
        Lecturers.Show()
        Me.Hide()
    End Sub

    Private Sub GoToStudents_Click(sender As Object, e As EventArgs) Handles GoToStudents.Click
        Students.Show()
        Me.Hide()
    End Sub

    Private Sub GoToFees_Click(sender As Object, e As EventArgs) Handles GoToFees.Click
        Dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub GoToLogin_Click(sender As Object, e As EventArgs) Handles GoToLogin.Click
        Login.Show()
        Me.Hide()
    End Sub

End Class