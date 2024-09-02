<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        GoToFees = New Panel()
        Label14 = New Label()
        Label16 = New Label()
        GoToLogout = New Panel()
        ExitLbl = New Label()
        Label3 = New Label()
        GoToDepartments = New Panel()
        Label12 = New Label()
        Label13 = New Label()
        GoToStudents = New Panel()
        Panel2 = New Panel()
        Panel1 = New Panel()
        Panel3 = New Panel()
        Panel4 = New Panel()
        Label2 = New Label()
        NumStudents = New Label()
        Panel5 = New Panel()
        Panel6 = New Panel()
        Label4 = New Label()
        NumLecturers = New Label()
        Panel7 = New Panel()
        Panel8 = New Panel()
        Label6 = New Label()
        NumDepartments = New Label()
        GoToFees.SuspendLayout()
        GoToLogout.SuspendLayout()
        GoToDepartments.SuspendLayout()
        GoToStudents.SuspendLayout()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        Panel5.SuspendLayout()
        Panel6.SuspendLayout()
        Panel7.SuspendLayout()
        Panel8.SuspendLayout()
        SuspendLayout()
        ' 
        ' GoToFees
        ' 
        GoToFees.BackColor = Color.LightSkyBlue
        GoToFees.BorderStyle = BorderStyle.Fixed3D
        GoToFees.Controls.Add(Label14)
        GoToFees.Dock = DockStyle.Top
        GoToFees.Location = New Point(0, 94)
        GoToFees.Name = "GoToFees"
        GoToFees.Size = New Size(160, 47)
        GoToFees.TabIndex = 2
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Reem Kufi", 14.25F, FontStyle.Bold)
        Label14.Location = New Point(9, 5)
        Label14.Name = "Label14"
        Label14.Size = New Size(128, 35)
        Label14.TabIndex = 5
        Label14.Text = "LECTURERS"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Reem Kufi", 14.25F, FontStyle.Bold)
        Label16.ForeColor = Color.Black
        Label16.Location = New Point(23, 1)
        Label16.Name = "Label16"
        Label16.Size = New Size(98, 35)
        Label16.TabIndex = 5
        Label16.Text = "LOGOUT"
        ' 
        ' GoToLogout
        ' 
        GoToLogout.BackColor = Color.LightSkyBlue
        GoToLogout.BorderStyle = BorderStyle.Fixed3D
        GoToLogout.Controls.Add(Label16)
        GoToLogout.Dock = DockStyle.Top
        GoToLogout.Location = New Point(0, 141)
        GoToLogout.Name = "GoToLogout"
        GoToLogout.Size = New Size(160, 47)
        GoToLogout.TabIndex = 4
        ' 
        ' ExitLbl
        ' 
        ExitLbl.AutoSize = True
        ExitLbl.Font = New Font("Reem Kufi", 14.25F, FontStyle.Bold Or FontStyle.Underline)
        ExitLbl.ForeColor = Color.Red
        ExitLbl.Location = New Point(708, 9)
        ExitLbl.Name = "ExitLbl"
        ExitLbl.Size = New Size(29, 35)
        ExitLbl.TabIndex = 7
        ExitLbl.Text = "X"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Reem Kufi", 14.25F, FontStyle.Bold)
        Label3.Location = New Point(256, 9)
        Label3.Name = "Label3"
        Label3.Size = New Size(296, 35)
        Label3.TabIndex = 4
        Label3.Text = "Academic Nexus Pro Dashboard"
        ' 
        ' GoToDepartments
        ' 
        GoToDepartments.BackColor = Color.LightSkyBlue
        GoToDepartments.BorderStyle = BorderStyle.Fixed3D
        GoToDepartments.Controls.Add(Label12)
        GoToDepartments.Dock = DockStyle.Top
        GoToDepartments.Location = New Point(0, 47)
        GoToDepartments.Name = "GoToDepartments"
        GoToDepartments.Size = New Size(160, 47)
        GoToDepartments.TabIndex = 1
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Reem Kufi", 14.25F, FontStyle.Bold)
        Label12.Location = New Point(10, 7)
        Label12.Name = "Label12"
        Label12.Size = New Size(117, 35)
        Label12.TabIndex = 5
        Label12.Text = "STUDENTS"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Reem Kufi", 14.25F, FontStyle.Bold)
        Label13.Location = New Point(33, 5)
        Label13.Name = "Label13"
        Label13.Size = New Size(73, 35)
        Label13.TabIndex = 5
        Label13.Text = "UNITS"
        ' 
        ' GoToStudents
        ' 
        GoToStudents.BackColor = Color.LightSkyBlue
        GoToStudents.BorderStyle = BorderStyle.Fixed3D
        GoToStudents.Controls.Add(Label13)
        GoToStudents.Dock = DockStyle.Top
        GoToStudents.Location = New Point(0, 0)
        GoToStudents.Name = "GoToStudents"
        GoToStudents.Size = New Size(160, 47)
        GoToStudents.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.RoyalBlue
        Panel2.Controls.Add(GoToLogout)
        Panel2.Controls.Add(GoToFees)
        Panel2.Controls.Add(GoToDepartments)
        Panel2.Controls.Add(GoToStudents)
        Panel2.Dock = DockStyle.Left
        Panel2.Location = New Point(0, 53)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(160, 449)
        Panel2.TabIndex = 96
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.RoyalBlue
        Panel1.Controls.Add(ExitLbl)
        Panel1.Controls.Add(Label3)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(741, 53)
        Panel1.TabIndex = 95
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.LightSkyBlue
        Panel3.BorderStyle = BorderStyle.Fixed3D
        Panel3.Controls.Add(Panel4)
        Panel3.Controls.Add(NumStudents)
        Panel3.Location = New Point(335, 82)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(217, 150)
        Panel3.TabIndex = 97
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.RoyalBlue
        Panel4.Controls.Add(Label2)
        Panel4.Dock = DockStyle.Bottom
        Panel4.Location = New Point(0, 99)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(213, 47)
        Panel4.TabIndex = 98
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Reem Kufi", 14.25F, FontStyle.Bold)
        Label2.Location = New Point(52, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(117, 35)
        Label2.TabIndex = 5
        Label2.Text = "STUDENTS"
        ' 
        ' NumStudents
        ' 
        NumStudents.AutoSize = True
        NumStudents.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold)
        NumStudents.Location = New Point(92, 26)
        NumStudents.Name = "NumStudents"
        NumStudents.Size = New Size(33, 37)
        NumStudents.TabIndex = 5
        NumStudents.Text = "0"
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.LightSkyBlue
        Panel5.BorderStyle = BorderStyle.Fixed3D
        Panel5.Controls.Add(Panel6)
        Panel5.Controls.Add(NumLecturers)
        Panel5.Location = New Point(476, 274)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(223, 164)
        Panel5.TabIndex = 99
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.RoyalBlue
        Panel6.Controls.Add(Label4)
        Panel6.Dock = DockStyle.Bottom
        Panel6.Location = New Point(0, 113)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(219, 47)
        Panel6.TabIndex = 98
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Reem Kufi", 14.25F, FontStyle.Bold)
        Label4.Location = New Point(46, 9)
        Label4.Name = "Label4"
        Label4.Size = New Size(128, 35)
        Label4.TabIndex = 5
        Label4.Text = "LECTURERS"
        ' 
        ' NumLecturers
        ' 
        NumLecturers.AutoSize = True
        NumLecturers.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold)
        NumLecturers.Location = New Point(97, 37)
        NumLecturers.Name = "NumLecturers"
        NumLecturers.Size = New Size(33, 37)
        NumLecturers.TabIndex = 5
        NumLecturers.Text = "0"
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.LightSkyBlue
        Panel7.BorderStyle = BorderStyle.Fixed3D
        Panel7.Controls.Add(Panel8)
        Panel7.Controls.Add(NumDepartments)
        Panel7.Location = New Point(187, 274)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(223, 164)
        Panel7.TabIndex = 100
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = Color.RoyalBlue
        Panel8.Controls.Add(Label6)
        Panel8.Dock = DockStyle.Bottom
        Panel8.Location = New Point(0, 113)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(219, 47)
        Panel8.TabIndex = 98
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Reem Kufi", 14.25F, FontStyle.Bold)
        Label6.Location = New Point(76, 9)
        Label6.Name = "Label6"
        Label6.Size = New Size(73, 35)
        Label6.TabIndex = 5
        Label6.Text = "UNITS"
        ' 
        ' NumDepartments
        ' 
        NumDepartments.AutoSize = True
        NumDepartments.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold)
        NumDepartments.Location = New Point(94, 37)
        NumDepartments.Name = "NumDepartments"
        NumDepartments.Size = New Size(33, 37)
        NumDepartments.TabIndex = 5
        NumDepartments.Text = "0"
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(741, 502)
        Controls.Add(Panel7)
        Controls.Add(Panel5)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Dashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Dashboard"
        GoToFees.ResumeLayout(False)
        GoToFees.PerformLayout()
        GoToLogout.ResumeLayout(False)
        GoToLogout.PerformLayout()
        GoToDepartments.ResumeLayout(False)
        GoToDepartments.PerformLayout()
        GoToStudents.ResumeLayout(False)
        GoToStudents.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        Panel7.ResumeLayout(False)
        Panel7.PerformLayout()
        Panel8.ResumeLayout(False)
        Panel8.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents GoToFees As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents GoToLogout As Panel
    Friend WithEvents ExitLbl As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GoToDepartments As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents GoToStudents As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents NumStudents As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents NumLecturers As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents NumDepartments As Label
End Class
