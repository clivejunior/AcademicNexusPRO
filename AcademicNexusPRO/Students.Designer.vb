<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Students
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Panel1 = New Panel()
        ExitLbl = New Label()
        Label3 = New Label()
        Panel2 = New Panel()
        Panel3 = New Panel()
        Label16 = New Label()
        GoToLogout = New Panel()
        Label5 = New Label()
        GoToDashboard = New Panel()
        Label13 = New Label()
        GoToDepartments = New Panel()
        Label15 = New Label()
        Label1 = New Label()
        NameTxt = New TextBox()
        GenderCmb = New ComboBox()
        Label2 = New Label()
        DOB = New DateTimePicker()
        Label4 = New Label()
        Label6 = New Label()
        UnitCmb = New ComboBox()
        Label7 = New Label()
        FeesTxt = New TextBox()
        Label8 = New Label()
        PhoneTxt = New TextBox()
        Label9 = New Label()
        SaveBtn = New Button()
        EditBtn = New Button()
        DeleteBtn = New Button()
        ResetBtn = New Button()
        StudentDGV = New DataGridView()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        GoToLogout.SuspendLayout()
        GoToDashboard.SuspendLayout()
        GoToDepartments.SuspendLayout()
        CType(StudentDGV, ComponentModel.ISupportInitialize).BeginInit()
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
        Panel1.Size = New Size(765, 53)
        Panel1.TabIndex = 12
        ' 
        ' ExitLbl
        ' 
        ExitLbl.AutoSize = True
        ExitLbl.Font = New Font("Reem Kufi", 14.25F, FontStyle.Bold Or FontStyle.Underline)
        ExitLbl.ForeColor = Color.Red
        ExitLbl.Location = New Point(733, 0)
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
        Label3.Size = New Size(396, 35)
        Label3.TabIndex = 4
        Label3.Text = "Academic Nexus Pro Students Management"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.RoyalBlue
        Panel2.Controls.Add(Panel3)
        Panel2.Controls.Add(GoToLogout)
        Panel2.Controls.Add(GoToDashboard)
        Panel2.Controls.Add(GoToDepartments)
        Panel2.Dock = DockStyle.Left
        Panel2.Location = New Point(0, 53)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(160, 498)
        Panel2.TabIndex = 13
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.LightSkyBlue
        Panel3.BorderStyle = BorderStyle.Fixed3D
        Panel3.Controls.Add(Label16)
        Panel3.Dock = DockStyle.Top
        Panel3.Location = New Point(0, 141)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(160, 47)
        Panel3.TabIndex = 5
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Reem Kufi", 14.25F, FontStyle.Bold)
        Label16.ForeColor = Color.Black
        Label16.Location = New Point(22, 8)
        Label16.Name = "Label16"
        Label16.Size = New Size(98, 35)
        Label16.TabIndex = 5
        Label16.Text = "LOGOUT"
        ' 
        ' GoToLogout
        ' 
        GoToLogout.BackColor = Color.LightSkyBlue
        GoToLogout.BorderStyle = BorderStyle.Fixed3D
        GoToLogout.Controls.Add(Label5)
        GoToLogout.Dock = DockStyle.Top
        GoToLogout.Location = New Point(0, 94)
        GoToLogout.Name = "GoToLogout"
        GoToLogout.Size = New Size(160, 47)
        GoToLogout.TabIndex = 4
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Reem Kufi", 14.25F, FontStyle.Bold)
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(10, 7)
        Label5.Name = "Label5"
        Label5.Size = New Size(128, 35)
        Label5.TabIndex = 5
        Label5.Text = "LECTURERS"
        ' 
        ' GoToDashboard
        ' 
        GoToDashboard.BackColor = Color.LightSkyBlue
        GoToDashboard.BorderStyle = BorderStyle.Fixed3D
        GoToDashboard.Controls.Add(Label13)
        GoToDashboard.Dock = DockStyle.Top
        GoToDashboard.Location = New Point(0, 47)
        GoToDashboard.Name = "GoToDashboard"
        GoToDashboard.Size = New Size(160, 47)
        GoToDashboard.TabIndex = 3
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Reem Kufi", 14.25F, FontStyle.Bold)
        Label13.Location = New Point(35, 5)
        Label13.Name = "Label13"
        Label13.Size = New Size(73, 35)
        Label13.TabIndex = 5
        Label13.Text = "UNITS"
        ' 
        ' GoToDepartments
        ' 
        GoToDepartments.BackColor = Color.LightSkyBlue
        GoToDepartments.BorderStyle = BorderStyle.Fixed3D
        GoToDepartments.Controls.Add(Label15)
        GoToDepartments.Dock = DockStyle.Top
        GoToDepartments.Location = New Point(0, 0)
        GoToDepartments.Name = "GoToDepartments"
        GoToDepartments.Size = New Size(160, 47)
        GoToDepartments.TabIndex = 1
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Reem Kufi", 14.25F, FontStyle.Bold)
        Label15.Location = New Point(10, 7)
        Label15.Name = "Label15"
        Label15.Size = New Size(136, 35)
        Label15.TabIndex = 5
        Label15.Text = "DASHBOARD"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Reem Kufi", 14.25F, FontStyle.Bold)
        Label1.Location = New Point(178, 55)
        Label1.Name = "Label1"
        Label1.Size = New Size(73, 35)
        Label1.TabIndex = 15
        Label1.Text = "Name:"
        ' 
        ' NameTxt
        ' 
        NameTxt.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        NameTxt.Location = New Point(178, 93)
        NameTxt.Name = "NameTxt"
        NameTxt.Size = New Size(162, 29)
        NameTxt.TabIndex = 14
        ' 
        ' GenderCmb
        ' 
        GenderCmb.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        GenderCmb.FormattingEnabled = True
        GenderCmb.Items.AddRange(New Object() {"Male", "Female"})
        GenderCmb.Location = New Point(357, 93)
        GenderCmb.Name = "GenderCmb"
        GenderCmb.Size = New Size(159, 29)
        GenderCmb.TabIndex = 16
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Reem Kufi", 14.25F, FontStyle.Bold)
        Label2.Location = New Point(357, 54)
        Label2.Name = "Label2"
        Label2.Size = New Size(85, 35)
        Label2.TabIndex = 17
        Label2.Text = "Gender:"
        ' 
        ' DOB
        ' 
        DOB.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        DOB.Location = New Point(536, 93)
        DOB.Name = "DOB"
        DOB.Size = New Size(159, 29)
        DOB.TabIndex = 18
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Reem Kufi", 14.25F, FontStyle.Bold)
        Label4.Location = New Point(536, 54)
        Label4.Name = "Label4"
        Label4.Size = New Size(129, 35)
        Label4.TabIndex = 19
        Label4.Text = "Date of Birth:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Reem Kufi", 14.25F, FontStyle.Bold)
        Label6.Location = New Point(178, 132)
        Label6.Name = "Label6"
        Label6.Size = New Size(55, 35)
        Label6.TabIndex = 21
        Label6.Text = "Unit:"
        ' 
        ' UnitCmb
        ' 
        UnitCmb.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        UnitCmb.FormattingEnabled = True
        UnitCmb.Location = New Point(178, 171)
        UnitCmb.Name = "UnitCmb"
        UnitCmb.Size = New Size(162, 29)
        UnitCmb.TabIndex = 20
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Reem Kufi", 14.25F, FontStyle.Bold)
        Label7.Location = New Point(357, 133)
        Label7.Name = "Label7"
        Label7.Size = New Size(58, 35)
        Label7.TabIndex = 23
        Label7.Text = "Fees:"
        ' 
        ' FeesTxt
        ' 
        FeesTxt.Enabled = False
        FeesTxt.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        FeesTxt.Location = New Point(357, 171)
        FeesTxt.Name = "FeesTxt"
        FeesTxt.Size = New Size(159, 29)
        FeesTxt.TabIndex = 22
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Reem Kufi", 14.25F, FontStyle.Bold)
        Label8.Location = New Point(536, 133)
        Label8.Name = "Label8"
        Label8.Size = New Size(74, 35)
        Label8.TabIndex = 25
        Label8.Text = "Phone:"
        ' 
        ' PhoneTxt
        ' 
        PhoneTxt.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        PhoneTxt.Location = New Point(536, 171)
        PhoneTxt.Name = "PhoneTxt"
        PhoneTxt.Size = New Size(159, 29)
        PhoneTxt.TabIndex = 24
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Reem Kufi", 15F, FontStyle.Bold Or FontStyle.Underline)
        Label9.Location = New Point(388, 263)
        Label9.Name = "Label9"
        Label9.Size = New Size(138, 36)
        Label9.TabIndex = 26
        Label9.Text = "Students List"
        ' 
        ' SaveBtn
        ' 
        SaveBtn.BackColor = Color.LightSkyBlue
        SaveBtn.Font = New Font("Reem Kufi", 14.25F, FontStyle.Bold)
        SaveBtn.Location = New Point(185, 219)
        SaveBtn.Name = "SaveBtn"
        SaveBtn.Size = New Size(119, 39)
        SaveBtn.TabIndex = 28
        SaveBtn.Text = "Save"
        SaveBtn.UseVisualStyleBackColor = False
        ' 
        ' EditBtn
        ' 
        EditBtn.BackColor = Color.LightSkyBlue
        EditBtn.Font = New Font("Reem Kufi", 14.25F, FontStyle.Bold)
        EditBtn.Location = New Point(319, 219)
        EditBtn.Name = "EditBtn"
        EditBtn.Size = New Size(119, 39)
        EditBtn.TabIndex = 29
        EditBtn.Text = "Edit"
        EditBtn.UseVisualStyleBackColor = False
        ' 
        ' DeleteBtn
        ' 
        DeleteBtn.BackColor = Color.LightSkyBlue
        DeleteBtn.Font = New Font("Reem Kufi", 14.25F, FontStyle.Bold)
        DeleteBtn.Location = New Point(456, 219)
        DeleteBtn.Name = "DeleteBtn"
        DeleteBtn.Size = New Size(119, 39)
        DeleteBtn.TabIndex = 30
        DeleteBtn.Text = "Delete"
        DeleteBtn.UseVisualStyleBackColor = False
        ' 
        ' ResetBtn
        ' 
        ResetBtn.BackColor = Color.LightSkyBlue
        ResetBtn.Font = New Font("Reem Kufi", 14.25F, FontStyle.Bold)
        ResetBtn.Location = New Point(594, 219)
        ResetBtn.Name = "ResetBtn"
        ResetBtn.Size = New Size(119, 39)
        ResetBtn.TabIndex = 31
        ResetBtn.Text = "Clear"
        ResetBtn.UseVisualStyleBackColor = False
        ' 
        ' StudentDGV
        ' 
        StudentDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        StudentDGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        StudentDGV.BackgroundColor = Color.LightSkyBlue
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        StudentDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        StudentDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        StudentDGV.GridColor = SystemColors.InactiveCaption
        StudentDGV.Location = New Point(185, 313)
        StudentDGV.Name = "StudentDGV"
        StudentDGV.SelectionMode = DataGridViewSelectionMode.CellSelect
        StudentDGV.Size = New Size(535, 226)
        StudentDGV.TabIndex = 72
        ' 
        ' Students
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(765, 551)
        Controls.Add(StudentDGV)
        Controls.Add(ResetBtn)
        Controls.Add(DeleteBtn)
        Controls.Add(EditBtn)
        Controls.Add(SaveBtn)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(PhoneTxt)
        Controls.Add(Label7)
        Controls.Add(FeesTxt)
        Controls.Add(Label6)
        Controls.Add(UnitCmb)
        Controls.Add(Label4)
        Controls.Add(DOB)
        Controls.Add(Label2)
        Controls.Add(GenderCmb)
        Controls.Add(Label1)
        Controls.Add(NameTxt)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Students"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Students"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        GoToLogout.ResumeLayout(False)
        GoToLogout.PerformLayout()
        GoToDashboard.ResumeLayout(False)
        GoToDashboard.PerformLayout()
        GoToDepartments.ResumeLayout(False)
        GoToDepartments.PerformLayout()
        CType(StudentDGV, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents ExitLbl As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents NameTxt As TextBox
    Friend WithEvents GenderCmb As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DOB As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents UnitCmb As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents FeesTxt As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents PhoneTxt As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents SaveBtn As Button
    Friend WithEvents EditBtn As Button
    Friend WithEvents DeleteBtn As Button
    Friend WithEvents ResetBtn As Button
    Friend WithEvents GoToDepartments As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents GoToDashboard As Panel
    Friend WithEvents Label15 As Label
    Friend WithEvents GoToLogout As Panel
    Friend WithEvents Label16 As Label
    Friend WithEvents StudentDGV As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label5 As Label
End Class
