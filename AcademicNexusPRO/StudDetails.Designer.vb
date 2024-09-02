<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudDetails
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
        Panel1 = New Panel()
        ExitLbl = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        FetchBtn = New Button()
        NameLbl = New Label()
        StudentNameTxt = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        GenderLbl = New Label()
        DOBLbl = New Label()
        PhoneLbl = New Label()
        UnitLbl = New Label()
        FeeLbl = New Label()
        GoBackBtn = New Button()
        Panel1.SuspendLayout()
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
        Panel1.Size = New Size(600, 53)
        Panel1.TabIndex = 15
        ' 
        ' ExitLbl
        ' 
        ExitLbl.AutoSize = True
        ExitLbl.Font = New Font("Reem Kufi", 14.25F, FontStyle.Bold Or FontStyle.Underline)
        ExitLbl.ForeColor = Color.Red
        ExitLbl.Location = New Point(566, 0)
        ExitLbl.Name = "ExitLbl"
        ExitLbl.Size = New Size(29, 35)
        ExitLbl.TabIndex = 7
        ExitLbl.Text = "X"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Reem Kufi", 14.25F, FontStyle.Bold)
        Label3.Location = New Point(129, 9)
        Label3.Name = "Label3"
        Label3.Size = New Size(330, 35)
        Label3.TabIndex = 4
        Label3.Text = "Academic Nexus Pro Student Details"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Reem Kufi", 14.25F, FontStyle.Bold)
        Label2.Location = New Point(120, 118)
        Label2.Name = "Label2"
        Label2.Size = New Size(107, 35)
        Label2.TabIndex = 14
        Label2.Text = "Full Name:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Reem Kufi", 14.25F, FontStyle.Bold)
        Label1.Location = New Point(0, 65)
        Label1.Name = "Label1"
        Label1.Size = New Size(145, 35)
        Label1.TabIndex = 13
        Label1.Text = "Student Name:"
        ' 
        ' FetchBtn
        ' 
        FetchBtn.BackColor = Color.LightSkyBlue
        FetchBtn.Font = New Font("Reem Kufi", 14.25F, FontStyle.Bold)
        FetchBtn.Location = New Point(428, 61)
        FetchBtn.Name = "FetchBtn"
        FetchBtn.Size = New Size(140, 47)
        FetchBtn.TabIndex = 12
        FetchBtn.Text = "Fetch Data"
        FetchBtn.UseVisualStyleBackColor = False
        ' 
        ' NameLbl
        ' 
        NameLbl.AutoSize = True
        NameLbl.Font = New Font("Reem Kufi", 14.25F, FontStyle.Bold Or FontStyle.Underline)
        NameLbl.Location = New Point(245, 116)
        NameLbl.Name = "NameLbl"
        NameLbl.Size = New Size(0, 35)
        NameLbl.TabIndex = 16
        ' 
        ' StudentNameTxt
        ' 
        StudentNameTxt.Font = New Font("Reem Kufi", 14.25F, FontStyle.Bold)
        StudentNameTxt.Location = New Point(151, 67)
        StudentNameTxt.Name = "StudentNameTxt"
        StudentNameTxt.Size = New Size(271, 36)
        StudentNameTxt.TabIndex = 17
        StudentNameTxt.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Reem Kufi", 14.25F, FontStyle.Bold)
        Label4.Location = New Point(142, 162)
        Label4.Name = "Label4"
        Label4.Size = New Size(85, 35)
        Label4.TabIndex = 18
        Label4.Text = "Gender:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Reem Kufi", 14.25F, FontStyle.Bold)
        Label5.Location = New Point(166, 208)
        Label5.Name = "Label5"
        Label5.Size = New Size(61, 35)
        Label5.TabIndex = 19
        Label5.Text = "DOB:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Reem Kufi", 14.25F, FontStyle.Bold)
        Label6.Location = New Point(153, 255)
        Label6.Name = "Label6"
        Label6.Size = New Size(74, 35)
        Label6.TabIndex = 20
        Label6.Text = "Phone:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Reem Kufi", 14.25F, FontStyle.Bold)
        Label7.Location = New Point(172, 303)
        Label7.Name = "Label7"
        Label7.Size = New Size(55, 35)
        Label7.TabIndex = 21
        Label7.Text = "Unit:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Reem Kufi", 14.25F, FontStyle.Bold)
        Label8.Location = New Point(169, 349)
        Label8.Name = "Label8"
        Label8.Size = New Size(58, 35)
        Label8.TabIndex = 22
        Label8.Text = "Fees:"
        ' 
        ' GenderLbl
        ' 
        GenderLbl.AutoSize = True
        GenderLbl.Font = New Font("Reem Kufi", 14.25F, FontStyle.Bold Or FontStyle.Underline)
        GenderLbl.Location = New Point(245, 160)
        GenderLbl.Name = "GenderLbl"
        GenderLbl.Size = New Size(0, 35)
        GenderLbl.TabIndex = 23
        ' 
        ' DOBLbl
        ' 
        DOBLbl.AutoSize = True
        DOBLbl.Font = New Font("Reem Kufi", 14.25F, FontStyle.Bold Or FontStyle.Underline)
        DOBLbl.Location = New Point(245, 206)
        DOBLbl.Name = "DOBLbl"
        DOBLbl.Size = New Size(0, 35)
        DOBLbl.TabIndex = 24
        ' 
        ' PhoneLbl
        ' 
        PhoneLbl.AutoSize = True
        PhoneLbl.Font = New Font("Reem Kufi", 14.25F, FontStyle.Bold Or FontStyle.Underline)
        PhoneLbl.Location = New Point(245, 255)
        PhoneLbl.Name = "PhoneLbl"
        PhoneLbl.Size = New Size(0, 35)
        PhoneLbl.TabIndex = 25
        ' 
        ' UnitLbl
        ' 
        UnitLbl.AutoSize = True
        UnitLbl.Font = New Font("Reem Kufi", 14.25F, FontStyle.Bold Or FontStyle.Underline)
        UnitLbl.Location = New Point(245, 303)
        UnitLbl.Name = "UnitLbl"
        UnitLbl.Size = New Size(0, 35)
        UnitLbl.TabIndex = 26
        ' 
        ' FeeLbl
        ' 
        FeeLbl.AutoSize = True
        FeeLbl.Font = New Font("Reem Kufi", 14.25F, FontStyle.Bold Or FontStyle.Underline)
        FeeLbl.Location = New Point(245, 349)
        FeeLbl.Name = "FeeLbl"
        FeeLbl.Size = New Size(0, 35)
        FeeLbl.TabIndex = 27
        ' 
        ' GoBackBtn
        ' 
        GoBackBtn.BackColor = Color.LightSkyBlue
        GoBackBtn.Font = New Font("Reem Kufi", 14.25F, FontStyle.Bold)
        GoBackBtn.Location = New Point(248, 399)
        GoBackBtn.Name = "GoBackBtn"
        GoBackBtn.Size = New Size(140, 47)
        GoBackBtn.TabIndex = 28
        GoBackBtn.Text = "Go Back"
        GoBackBtn.UseVisualStyleBackColor = False
        ' 
        ' StudDetails
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(600, 453)
        Controls.Add(GoBackBtn)
        Controls.Add(FeeLbl)
        Controls.Add(UnitLbl)
        Controls.Add(PhoneLbl)
        Controls.Add(DOBLbl)
        Controls.Add(GenderLbl)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(StudentNameTxt)
        Controls.Add(Panel1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(FetchBtn)
        Controls.Add(NameLbl)
        FormBorderStyle = FormBorderStyle.None
        Name = "StudDetails"
        StartPosition = FormStartPosition.CenterScreen
        Text = "StudDetails"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents ExitLbl As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents FetchBtn As Button
    Friend WithEvents NameLbl As Label
    Friend WithEvents StudentNameTxt As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents GenderLbl As Label
    Friend WithEvents DOBLbl As Label
    Friend WithEvents PhoneLbl As Label
    Friend WithEvents UnitLbl As Label
    Friend WithEvents FeeLbl As Label
    Friend WithEvents GoBackBtn As Button
End Class
