<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Units
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
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Panel1 = New Panel()
        ExitLbl = New Label()
        Label3 = New Label()
        DurationTxt = New TextBox()
        Label7 = New Label()
        DescriptionTxt = New TextBox()
        Label1 = New Label()
        UnitNameTxt = New TextBox()
        ResetBtn = New Button()
        DeleteBtn = New Button()
        EditBtn = New Button()
        SaveBtn = New Button()
        UnitDGV = New DataGridView()
        Label9 = New Label()
        Label8 = New Label()
        Panel2 = New Panel()
        Panel6 = New Panel()
        GoToLogin = New Label()
        Panel5 = New Panel()
        GoToLecturers = New Label()
        Panel4 = New Panel()
        GoToStudents = New Label()
        Panel3 = New Panel()
        GoToFees = New Label()
        UnitFees = New TextBox()
        Label2 = New Label()
        Panel1.SuspendLayout()
        CType(UnitDGV, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel6.SuspendLayout()
        Panel5.SuspendLayout()
        Panel4.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.RoyalBlue
        Panel1.Controls.Add(ExitLbl)
        Panel1.Controls.Add(Label3)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(721, 53)
        Panel1.TabIndex = 56
        ' 
        ' ExitLbl
        ' 
        ExitLbl.AutoSize = True
        ExitLbl.Font = New Font("Reem Kufi", 14.25F, FontStyle.Bold Or FontStyle.Underline)
        ExitLbl.ForeColor = Color.Red
        ExitLbl.Location = New Point(689, 0)
        ExitLbl.Name = "ExitLbl"
        ExitLbl.Size = New Size(29, 35)
        ExitLbl.TabIndex = 7
        ExitLbl.Text = "X"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Reem Kufi", 14.25F, FontStyle.Bold)
        Label3.Location = New Point(246, 9)
        Label3.Name = "Label3"
        Label3.Size = New Size(344, 35)
        Label3.TabIndex = 4
        Label3.Text = "Academic Nexus Pro Unit Registration"
        ' 
        ' DurationTxt
        ' 
        DurationTxt.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        DurationTxt.Location = New Point(531, 93)
        DurationTxt.Name = "DurationTxt"
        DurationTxt.Size = New Size(159, 29)
        DurationTxt.TabIndex = 68
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Reem Kufi", 14.25F, FontStyle.Bold)
        Label7.Location = New Point(342, 55)
        Label7.Name = "Label7"
        Label7.Size = New Size(120, 35)
        Label7.TabIndex = 67
        Label7.Text = "Description:"
        ' 
        ' DescriptionTxt
        ' 
        DescriptionTxt.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        DescriptionTxt.Location = New Point(342, 93)
        DescriptionTxt.Multiline = True
        DescriptionTxt.Name = "DescriptionTxt"
        DescriptionTxt.Size = New Size(169, 99)
        DescriptionTxt.TabIndex = 66
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Reem Kufi", 14.25F, FontStyle.Bold)
        Label1.Location = New Point(173, 55)
        Label1.Name = "Label1"
        Label1.Size = New Size(73, 35)
        Label1.TabIndex = 59
        Label1.Text = "Name:"
        ' 
        ' UnitNameTxt
        ' 
        UnitNameTxt.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        UnitNameTxt.Location = New Point(173, 93)
        UnitNameTxt.Name = "UnitNameTxt"
        UnitNameTxt.Size = New Size(152, 29)
        UnitNameTxt.TabIndex = 58
        ' 
        ' ResetBtn
        ' 
        ResetBtn.BackColor = Color.LightSkyBlue
        ResetBtn.Font = New Font("Reem Kufi", 14.25F, FontStyle.Bold)
        ResetBtn.Location = New Point(571, 202)
        ResetBtn.Name = "ResetBtn"
        ResetBtn.Size = New Size(119, 39)
        ResetBtn.TabIndex = 75
        ResetBtn.Text = "Clear"
        ResetBtn.UseVisualStyleBackColor = False
        ' 
        ' DeleteBtn
        ' 
        DeleteBtn.BackColor = Color.LightSkyBlue
        DeleteBtn.Font = New Font("Reem Kufi", 14.25F, FontStyle.Bold)
        DeleteBtn.Location = New Point(446, 202)
        DeleteBtn.Name = "DeleteBtn"
        DeleteBtn.Size = New Size(119, 39)
        DeleteBtn.TabIndex = 74
        DeleteBtn.Text = "Delete"
        DeleteBtn.UseVisualStyleBackColor = False
        ' 
        ' EditBtn
        ' 
        EditBtn.BackColor = Color.LightSkyBlue
        EditBtn.Font = New Font("Reem Kufi", 14.25F, FontStyle.Bold)
        EditBtn.Location = New Point(321, 202)
        EditBtn.Name = "EditBtn"
        EditBtn.Size = New Size(119, 39)
        EditBtn.TabIndex = 73
        EditBtn.Text = "Edit"
        EditBtn.UseVisualStyleBackColor = False
        ' 
        ' SaveBtn
        ' 
        SaveBtn.BackColor = Color.LightSkyBlue
        SaveBtn.Font = New Font("Reem Kufi", 14.25F, FontStyle.Bold)
        SaveBtn.Location = New Point(196, 202)
        SaveBtn.Name = "SaveBtn"
        SaveBtn.Size = New Size(119, 39)
        SaveBtn.TabIndex = 72
        SaveBtn.Text = "Save"
        SaveBtn.UseVisualStyleBackColor = False
        ' 
        ' UnitDGV
        ' 
        UnitDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        UnitDGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        UnitDGV.BackgroundColor = Color.LightSkyBlue
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Control
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        UnitDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        UnitDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        UnitDGV.GridColor = SystemColors.InactiveCaption
        UnitDGV.Location = New Point(173, 283)
        UnitDGV.Name = "UnitDGV"
        UnitDGV.SelectionMode = DataGridViewSelectionMode.CellSelect
        UnitDGV.Size = New Size(517, 210)
        UnitDGV.TabIndex = 71
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Reem Kufi", 15F, FontStyle.Bold Or FontStyle.Underline)
        Label9.Location = New Point(388, 244)
        Label9.Name = "Label9"
        Label9.Size = New Size(104, 36)
        Label9.TabIndex = 70
        Label9.Text = "Units List"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Reem Kufi", 14.25F, FontStyle.Bold)
        Label8.Location = New Point(523, 55)
        Label8.Name = "Label8"
        Label8.Size = New Size(163, 35)
        Label8.TabIndex = 69
        Label8.Text = "Duration(Sem's):"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.RoyalBlue
        Panel2.Controls.Add(Panel6)
        Panel2.Controls.Add(Panel5)
        Panel2.Controls.Add(Panel4)
        Panel2.Controls.Add(Panel3)
        Panel2.Dock = DockStyle.Left
        Panel2.Location = New Point(0, 53)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(152, 452)
        Panel2.TabIndex = 78
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.LightSkyBlue
        Panel6.BorderStyle = BorderStyle.Fixed3D
        Panel6.Controls.Add(GoToLogin)
        Panel6.Dock = DockStyle.Top
        Panel6.Location = New Point(0, 141)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(152, 47)
        Panel6.TabIndex = 3
        ' 
        ' GoToLogin
        ' 
        GoToLogin.AutoSize = True
        GoToLogin.Font = New Font("Reem Kufi", 14.25F, FontStyle.Bold)
        GoToLogin.Location = New Point(22, 2)
        GoToLogin.Name = "GoToLogin"
        GoToLogin.Size = New Size(98, 35)
        GoToLogin.TabIndex = 5
        GoToLogin.Text = "LOGOUT"
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.LightSkyBlue
        Panel5.BorderStyle = BorderStyle.Fixed3D
        Panel5.Controls.Add(GoToLecturers)
        Panel5.Dock = DockStyle.Top
        Panel5.Location = New Point(0, 94)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(152, 47)
        Panel5.TabIndex = 2
        ' 
        ' GoToLecturers
        ' 
        GoToLecturers.AutoSize = True
        GoToLecturers.Font = New Font("Reem Kufi", 14.25F, FontStyle.Bold)
        GoToLecturers.Location = New Point(10, 1)
        GoToLecturers.Name = "GoToLecturers"
        GoToLecturers.Size = New Size(128, 35)
        GoToLecturers.TabIndex = 5
        GoToLecturers.Text = "LECTURERS"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.LightSkyBlue
        Panel4.BorderStyle = BorderStyle.Fixed3D
        Panel4.Controls.Add(GoToStudents)
        Panel4.Dock = DockStyle.Top
        Panel4.Location = New Point(0, 47)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(152, 47)
        Panel4.TabIndex = 1
        ' 
        ' GoToStudents
        ' 
        GoToStudents.AutoSize = True
        GoToStudents.Font = New Font("Reem Kufi", 14.25F, FontStyle.Bold)
        GoToStudents.Location = New Point(12, 3)
        GoToStudents.Name = "GoToStudents"
        GoToStudents.Size = New Size(117, 35)
        GoToStudents.TabIndex = 5
        GoToStudents.Text = "STUDENTS"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.LightSkyBlue
        Panel3.BorderStyle = BorderStyle.Fixed3D
        Panel3.Controls.Add(GoToFees)
        Panel3.Dock = DockStyle.Top
        Panel3.Location = New Point(0, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(152, 47)
        Panel3.TabIndex = 0
        ' 
        ' GoToFees
        ' 
        GoToFees.AutoSize = True
        GoToFees.Font = New Font("Reem Kufi", 14.25F, FontStyle.Bold)
        GoToFees.Location = New Point(3, 7)
        GoToFees.Name = "GoToFees"
        GoToFees.Size = New Size(136, 35)
        GoToFees.TabIndex = 5
        GoToFees.Text = "DASHBOARD"
        ' 
        ' UnitFees
        ' 
        UnitFees.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        UnitFees.Location = New Point(529, 163)
        UnitFees.Name = "UnitFees"
        UnitFees.Size = New Size(159, 29)
        UnitFees.TabIndex = 79
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Reem Kufi", 14.25F, FontStyle.Bold)
        Label2.Location = New Point(531, 125)
        Label2.Name = "Label2"
        Label2.Size = New Size(118, 35)
        Label2.TabIndex = 80
        Label2.Text = "School Fees:"
        ' 
        ' Departments
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(721, 505)
        Controls.Add(UnitFees)
        Controls.Add(Label2)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(DurationTxt)
        Controls.Add(Label7)
        Controls.Add(DescriptionTxt)
        Controls.Add(Label1)
        Controls.Add(UnitNameTxt)
        Controls.Add(ResetBtn)
        Controls.Add(DeleteBtn)
        Controls.Add(EditBtn)
        Controls.Add(SaveBtn)
        Controls.Add(UnitDGV)
        Controls.Add(Label9)
        Controls.Add(Label8)
        FormBorderStyle = FormBorderStyle.None
        Name = "Departments"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Departments"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(UnitDGV, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents ExitLbl As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DurationTxt As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents DescriptionTxt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents UnitNameTxt As TextBox
    Friend WithEvents ResetBtn As Button
    Friend WithEvents DeleteBtn As Button
    Friend WithEvents EditBtn As Button
    Friend WithEvents SaveBtn As Button
    Friend WithEvents UnitDGV As DataGridView
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents GoToLogin As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents GoToFees As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents GoToStudents As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents GoToLecturers As Label
    Friend WithEvents UnitFees As TextBox
    Friend WithEvents Label2 As Label
End Class
