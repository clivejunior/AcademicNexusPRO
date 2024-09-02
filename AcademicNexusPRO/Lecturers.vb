Imports System.Data.SqlClient

Public Class Lecturers
     'Variable con for the sqlconnection string
    Dim con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\AcademicNexusPRO\AcademicNexusPRO\Database\ACADEMICNEXUS_DATABASE.mdf;Integrated Security=True;connect Timeout=30")

    'upon loading form
    Private Sub Lecturers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Display()
        FillDepartment()
    End Sub

    'the save button
    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        If NameTxt.Text = "" Or AddressTxt.Text = "" Or PhoneTxt.Text = "" Or GenderCmb.SelectedIndex = -1 Or UnitCmb.SelectedIndex = -1 Then
            MessageBox.Show("Please fill out missing information", "ACADEMIC NEXUS PRO", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
        Else
            Try
                con.open()
                Dim query = "insert into LecturerTbl values('" & NameTxt.Text & "','" & GenderCmb.SelectedItem.ToString() & "','" & DOB.Text & "','" & PhoneTxt.Text & "', '" & UnitCmb.SelectedValue.ToString() & "','" & AddressTxt.Text & "' )"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Lecturer details captured!", "ACADEMIC NEXUS PRO", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
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
        If NameTxt.Text = "" Or AddressTxt.Text = "" Or PhoneTxt.Text = "" Or GenderCmb.SelectedIndex = -1 Or UnitCmb.SelectedIndex = -1 Then
            MessageBox.Show("Please fill out missing information", "ACADEMIC NEXUS PRO", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
        Else
            Try
                con.open()
                Dim query = "update LecturerTbl set LName='" & NameTxt.Text & "',LGender='" & GenderCmb.SelectedItem.ToString() & "',LDOB='" & DOB.Text & "',LPhone='" & PhoneTxt.Text & "',LUnit='" & UnitCmb.SelectedValue.ToString() & "',LAddress='" & AddressTxt.Text & "' where LId='" & key & "'"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Lecturer details updated!", "ACADEMIC NEXUS PRO", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
                con.Close()
                Display()
                Reset()
            Catch ex As Exception
                MessageBox.Show("An error occured with the Database! contact support.", "ACADEMIC NEXUS PRO", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
            End Try
        End If
    End Sub

    'Delete button
    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        If key = 0 Then
            MessageBox.Show("Select the lecturer to delete", "ACADEMIC NEXUS PRO", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
        Else
            Try
                con.open()
                Dim query = "delete from LecturerTbl where LId =" & key & ""
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Lecturer deleted!", "ACADEMIC NEXUS PRO", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
                con.Close()
                Display()
                Reset()
            Catch ex As Exception
                MessageBox.Show("An error occured with the Database! contact support.", "ACADEMIC NEXUS PRO", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
            End Try
        End If
    End Sub

    'Click cell on DGV
    Dim key = 0
    Private Sub LecturerDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles LecturerDGV.CellMouseClick
        Dim row As DataGridViewRow = LecturerDGV.Rows(e.RowIndex)
        NameTxt.Text = row.Cells(1).Value.ToString
        GenderCmb.SelectedItem = row.Cells(2).Value.ToString
        DOB.Text = row.Cells(3).Value.ToString
        PhoneTxt.Text = row.Cells(4).Value.ToString
        UnitCmb.SelectedItem = row.Cells(5).Value.ToString
        AddressTxt.Text = row.Cells(6).Value.ToString
        If NameTxt.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub

    'clear button 
    Private Sub ResetBtn_Click(sender As Object, e As EventArgs) Handles ResetBtn.Click
        Reset()
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

    'function to retrieve data from LecturerTbl to the DGV
    Private Sub Display()
        con.open()
        Dim query = "select * from LecturerTbl"
        Dim cmd = New SqlCommand(query, con)
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        LecturerDGV.DataSource = ds.Tables(0)
        con.Close()
    End Sub

    'reset function that clears txts
    Private Sub Reset()
        NameTxt.Text = ""
        GenderCmb.SelectedIndex = -1
        DOB.Text = ""
        PhoneTxt.Text = ""
        UnitCmb.SelectedIndex = -1
        AddressTxt.Text = ""
    End Sub

    'Exit label
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

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click
        Dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub AddressTxt_TextChanged(sender As Object, e As EventArgs) Handles AddressTxt.TextChanged

    End Sub
End Class