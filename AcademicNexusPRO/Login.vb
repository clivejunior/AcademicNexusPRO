Imports System.Data.SqlClient

Public Class Login

    'Variable con for the sqlconnection string
    Dim con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\AcademicNexusPRO\AcademicNexusPRO\Database\ACADEMICNEXUS_DATABASE.mdf;Integrated Security=True;connect Timeout=30")


    'the login button event
    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        If UsernameTxt.Text = "" Or PasswordTxt.Text = "" Then
            MessageBox.Show("Please fill out all textboxes!", "ACADEMIC NEXUS PRO", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)

            'ADMIN
        ElseIf cmbChoice.selecteditem.tostring() = "Admin" Then
            Try
                con.Open()
                Dim query = "select * from UserTable where username = '" & UsernameTxt.Text & "' and password = '" & PasswordTxt.Text & "' and privilege like 'admin' "
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                Dim dtr As SqlDataReader
                dtr = cmd.ExecuteReader()
                dtr.Read()
                If dtr.HasRows Then

                    Dim obj = New Dashboard()
                    obj.Show()
                    Me.Hide()
                    MessageBox.Show("Login successful! Welcome.", "ACADEMIC NEXUS PRO", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                End If
                dtr.Close()
                con.Close()
            Catch ex As Exception
                MessageBox.Show("Error Logging in. Contact Support!", "ACADEMIC NEXUS PRO", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
            End Try


            'LECTURER
        ElseIf cmbChoice.selecteditem.tostring() = "Lecturer" Then
            Try
                con.Open()
                Dim query = "select * from UserTable where username = '" & UsernameTxt.Text & "' and password = '" & PasswordTxt.Text & "' and privilege like 'lecturer' "
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                Dim dtr As SqlDataReader
                dtr = cmd.ExecuteReader()
                dtr.Read()
                If dtr.HasRows Then

                    Dim obj = New LecDetails()
                    obj.Show()
                    Me.Hide()
                    MessageBox.Show("Login successful! Welcome.", "ACADEMIC NEXUS PRO", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                End If
                dtr.Close()
                con.Close()
            Catch ex As Exception
                MessageBox.Show("Error Logging in. Contact Support!", "ACADEMIC NEXUS PRO", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
            End Try


            'STUDENT
        ElseIf cmbChoice.selecteditem.tostring() = "Student" Then
            Try
                con.Open()
                Dim query = "select * from UserTable where username = '" & UsernameTxt.Text & "' and password = '" & PasswordTxt.Text & "' and privilege like 'student' "
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                Dim dtr As SqlDataReader
                dtr = cmd.ExecuteReader()
                dtr.Read()
                If dtr.HasRows Then

                    Dim obj = New StudDetails()
                    obj.Show()
                    Me.Hide()
                    MessageBox.Show("Login successful! Welcome.", "ACADEMIC NEXUS PRO", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                End If
                dtr.Close()
                con.Close()
            Catch ex As Exception
                MessageBox.Show("Error Logging in. Contact Support!", "ACADEMIC NEXUS PRO", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
            End Try

        Else
            MessageBox.Show("Invalid admin user or login credentials!", "ACADEMIC NEXUS PRO", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)

        End If

        UsernameTxt.Clear()
        PasswordTxt.Clear()
    End Sub

    'clear the textboxes
    Private Sub ClearLbl_Click(sender As Object, e As EventArgs) Handles ClearLbl.Click
        UsernameTxt.Clear()
        PasswordTxt.Clear()
    End Sub


    'exit the app -stop execution
    Private Sub ExitLbl_Click(sender As Object, e As EventArgs) Handles ExitLbl.Click
        Application.Exit()
    End Sub

    Private Sub PassCheck_CheckedChanged(sender As Object, e As EventArgs) Handles PassCheck.CheckedChanged
        If PassCheck.Checked = True Then
            PasswordTxt.PasswordChar = ""
        Else
            PasswordTxt.PasswordChar = "*"
        End If
    End Sub
End Class
