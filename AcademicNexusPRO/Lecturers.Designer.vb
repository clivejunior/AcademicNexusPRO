<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Lecturers
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.LecturerDGV = New System.Windows.Forms.DataGridView()
        Me.ResetBtn = New System.Windows.Forms.Button()
        Me.DeleteBtn = New System.Windows.Forms.Button()
        Me.EditBtn = New System.Windows.Forms.Button()
        Me.SaveBtn = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PhoneTxt = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.AddressTxt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.UnitCmb = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DOB = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GenderCmb = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GoToStudents = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GoToDepartments = New System.Windows.Forms.Panel()
        Me.GoToDashboard = New System.Windows.Forms.Panel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GoToLogout = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ExitLbl = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NameTxt = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.LecturerDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GoToStudents.SuspendLayout()
        Me.GoToDepartments.SuspendLayout()
        Me.GoToDashboard.SuspendLayout()
        Me.GoToLogout.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LecturerDGV
        '
        Me.LecturerDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.LecturerDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.LecturerDGV.BackgroundColor = System.Drawing.Color.LightSkyBlue
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.LecturerDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.LecturerDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LecturerDGV.GridColor = System.Drawing.SystemColors.InactiveCaption
        Me.LecturerDGV.Location = New System.Drawing.Point(257, 512)
        Me.LecturerDGV.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LecturerDGV.Name = "LecturerDGV"
        Me.LecturerDGV.RowHeadersWidth = 62
        Me.LecturerDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.LecturerDGV.Size = New System.Drawing.Size(764, 373)
        Me.LecturerDGV.TabIndex = 94
        '
        'ResetBtn
        '
        Me.ResetBtn.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ResetBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ResetBtn.Location = New System.Drawing.Point(826, 373)
        Me.ResetBtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ResetBtn.Name = "ResetBtn"
        Me.ResetBtn.Size = New System.Drawing.Size(170, 65)
        Me.ResetBtn.TabIndex = 91
        Me.ResetBtn.Text = "Clear"
        Me.ResetBtn.UseVisualStyleBackColor = False
        '
        'DeleteBtn
        '
        Me.DeleteBtn.BackColor = System.Drawing.Color.LightSkyBlue
        Me.DeleteBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.DeleteBtn.Location = New System.Drawing.Point(647, 373)
        Me.DeleteBtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DeleteBtn.Name = "DeleteBtn"
        Me.DeleteBtn.Size = New System.Drawing.Size(170, 65)
        Me.DeleteBtn.TabIndex = 90
        Me.DeleteBtn.Text = "Delete"
        Me.DeleteBtn.UseVisualStyleBackColor = False
        '
        'EditBtn
        '
        Me.EditBtn.BackColor = System.Drawing.Color.LightSkyBlue
        Me.EditBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.EditBtn.Location = New System.Drawing.Point(449, 373)
        Me.EditBtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.EditBtn.Name = "EditBtn"
        Me.EditBtn.Size = New System.Drawing.Size(170, 65)
        Me.EditBtn.TabIndex = 89
        Me.EditBtn.Text = "Edit"
        Me.EditBtn.UseVisualStyleBackColor = False
        '
        'SaveBtn
        '
        Me.SaveBtn.BackColor = System.Drawing.Color.LightSkyBlue
        Me.SaveBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.SaveBtn.Location = New System.Drawing.Point(257, 373)
        Me.SaveBtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(170, 65)
        Me.SaveBtn.TabIndex = 88
        Me.SaveBtn.Text = "Save"
        Me.SaveBtn.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(543, 447)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(208, 36)
        Me.Label9.TabIndex = 87
        Me.Label9.Text = "Lecturers List"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(769, 230)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(112, 33)
        Me.Label8.TabIndex = 86
        Me.Label8.Text = "Phone:"
        '
        'PhoneTxt
        '
        Me.PhoneTxt.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.PhoneTxt.Location = New System.Drawing.Point(769, 293)
        Me.PhoneTxt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PhoneTxt.Name = "PhoneTxt"
        Me.PhoneTxt.Size = New System.Drawing.Size(225, 39)
        Me.PhoneTxt.TabIndex = 85
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(513, 230)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(138, 33)
        Me.Label7.TabIndex = 84
        Me.Label7.Text = "Address:"
        '
        'AddressTxt
        '
        Me.AddressTxt.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.AddressTxt.Location = New System.Drawing.Point(513, 293)
        Me.AddressTxt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AddressTxt.Name = "AddressTxt"
        Me.AddressTxt.Size = New System.Drawing.Size(225, 39)
        Me.AddressTxt.TabIndex = 83
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(257, 228)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 33)
        Me.Label6.TabIndex = 82
        Me.Label6.Text = "Unit:"
        '
        'UnitCmb
        '
        Me.UnitCmb.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.UnitCmb.FormattingEnabled = True
        Me.UnitCmb.Items.AddRange(New Object() {"Male", "Female"})
        Me.UnitCmb.Location = New System.Drawing.Point(257, 293)
        Me.UnitCmb.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.UnitCmb.Name = "UnitCmb"
        Me.UnitCmb.Size = New System.Drawing.Size(230, 40)
        Me.UnitCmb.TabIndex = 81
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(769, 98)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(198, 33)
        Me.Label4.TabIndex = 80
        Me.Label4.Text = "Date of Birth:"
        '
        'DOB
        '
        Me.DOB.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.DOB.Location = New System.Drawing.Point(769, 158)
        Me.DOB.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DOB.Name = "DOB"
        Me.DOB.Size = New System.Drawing.Size(225, 39)
        Me.DOB.TabIndex = 79
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(513, 98)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 33)
        Me.Label2.TabIndex = 78
        Me.Label2.Text = "Gender:"
        '
        'GenderCmb
        '
        Me.GenderCmb.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GenderCmb.FormattingEnabled = True
        Me.GenderCmb.Items.AddRange(New Object() {"Male", "Female"})
        Me.GenderCmb.Location = New System.Drawing.Point(513, 163)
        Me.GenderCmb.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GenderCmb.Name = "GenderCmb"
        Me.GenderCmb.Size = New System.Drawing.Size(225, 40)
        Me.GenderCmb.TabIndex = 77
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(257, 100)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 33)
        Me.Label1.TabIndex = 76
        Me.Label1.Text = "Name:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label12.Location = New System.Drawing.Point(14, 2)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(179, 33)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "STUDENTS"
        '
        'GoToStudents
        '
        Me.GoToStudents.BackColor = System.Drawing.Color.LightSkyBlue
        Me.GoToStudents.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GoToStudents.Controls.Add(Me.Label15)
        Me.GoToStudents.Dock = System.Windows.Forms.DockStyle.Top
        Me.GoToStudents.Location = New System.Drawing.Point(0, 0)
        Me.GoToStudents.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GoToStudents.Name = "GoToStudents"
        Me.GoToStudents.Size = New System.Drawing.Size(229, 76)
        Me.GoToStudents.TabIndex = 0
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label15.Location = New System.Drawing.Point(14, 7)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(207, 33)
        Me.Label15.TabIndex = 5
        Me.Label15.Text = "DASHBOARD"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label13.Location = New System.Drawing.Point(54, 8)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(107, 33)
        Me.Label13.TabIndex = 5
        Me.Label13.Text = "UNITS"
        '
        'GoToDepartments
        '
        Me.GoToDepartments.BackColor = System.Drawing.Color.LightSkyBlue
        Me.GoToDepartments.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GoToDepartments.Controls.Add(Me.Label13)
        Me.GoToDepartments.Dock = System.Windows.Forms.DockStyle.Top
        Me.GoToDepartments.Location = New System.Drawing.Point(0, 76)
        Me.GoToDepartments.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GoToDepartments.Name = "GoToDepartments"
        Me.GoToDepartments.Size = New System.Drawing.Size(229, 76)
        Me.GoToDepartments.TabIndex = 1
        '
        'GoToDashboard
        '
        Me.GoToDashboard.BackColor = System.Drawing.Color.LightSkyBlue
        Me.GoToDashboard.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GoToDashboard.Controls.Add(Me.Label12)
        Me.GoToDashboard.Dock = System.Windows.Forms.DockStyle.Top
        Me.GoToDashboard.Location = New System.Drawing.Point(0, 152)
        Me.GoToDashboard.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GoToDashboard.Name = "GoToDashboard"
        Me.GoToDashboard.Size = New System.Drawing.Size(229, 76)
        Me.GoToDashboard.TabIndex = 3
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(30, 5)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(145, 33)
        Me.Label16.TabIndex = 5
        Me.Label16.Text = "LOGOUT"
        '
        'GoToLogout
        '
        Me.GoToLogout.BackColor = System.Drawing.Color.LightSkyBlue
        Me.GoToLogout.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GoToLogout.Controls.Add(Me.Label16)
        Me.GoToLogout.Dock = System.Windows.Forms.DockStyle.Top
        Me.GoToLogout.Location = New System.Drawing.Point(0, 228)
        Me.GoToLogout.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GoToLogout.Name = "GoToLogout"
        Me.GoToLogout.Size = New System.Drawing.Size(229, 76)
        Me.GoToLogout.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel2.Controls.Add(Me.GoToLogout)
        Me.Panel2.Controls.Add(Me.GoToDashboard)
        Me.Panel2.Controls.Add(Me.GoToDepartments)
        Me.Panel2.Controls.Add(Me.GoToStudents)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 88)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(229, 837)
        Me.Panel2.TabIndex = 74
        '
        'ExitLbl
        '
        Me.ExitLbl.AutoSize = True
        Me.ExitLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.ExitLbl.ForeColor = System.Drawing.Color.Red
        Me.ExitLbl.Location = New System.Drawing.Point(1011, 15)
        Me.ExitLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ExitLbl.Name = "ExitLbl"
        Me.ExitLbl.Size = New System.Drawing.Size(35, 33)
        Me.ExitLbl.TabIndex = 7
        Me.ExitLbl.Text = "X"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(347, 15)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(634, 33)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Academic Nexus Pro Lecturers Management"
        '
        'NameTxt
        '
        Me.NameTxt.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.NameTxt.Location = New System.Drawing.Point(257, 163)
        Me.NameTxt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.NameTxt.Name = "NameTxt"
        Me.NameTxt.Size = New System.Drawing.Size(230, 39)
        Me.NameTxt.TabIndex = 75
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel1.Controls.Add(Me.ExitLbl)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1066, 88)
        Me.Panel1.TabIndex = 73
        '
        'Lecturers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1066, 925)
        Me.Controls.Add(Me.LecturerDGV)
        Me.Controls.Add(Me.ResetBtn)
        Me.Controls.Add(Me.DeleteBtn)
        Me.Controls.Add(Me.EditBtn)
        Me.Controls.Add(Me.SaveBtn)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.PhoneTxt)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.AddressTxt)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.UnitCmb)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DOB)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GenderCmb)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.NameTxt)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Lecturers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lecturers"
        CType(Me.LecturerDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GoToStudents.ResumeLayout(False)
        Me.GoToStudents.PerformLayout()
        Me.GoToDepartments.ResumeLayout(False)
        Me.GoToDepartments.PerformLayout()
        Me.GoToDashboard.ResumeLayout(False)
        Me.GoToDashboard.PerformLayout()
        Me.GoToLogout.ResumeLayout(False)
        Me.GoToLogout.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LecturerDGV As DataGridView
    Friend WithEvents ResetBtn As Button
    Friend WithEvents DeleteBtn As Button
    Friend WithEvents EditBtn As Button
    Friend WithEvents SaveBtn As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents PhoneTxt As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents AddressTxt As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents UnitCmb As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DOB As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents GenderCmb As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents GoToStudents As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents GoToDepartments As Panel
    Friend WithEvents Label15 As Label
    Friend WithEvents GoToDashboard As Panel
    Friend WithEvents Label16 As Label
    Friend WithEvents GoToLogout As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ExitLbl As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents NameTxt As TextBox
    Friend WithEvents Panel1 As Panel
End Class
