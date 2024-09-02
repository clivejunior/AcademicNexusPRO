<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LecDetails
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
        GoBackBtn = New Button()
        LAddressLbl = New Label()
        LUnitLbl = New Label()
        LPhoneLbl = New Label()
        LDOBLbl = New Label()
        LGenderLbl = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        LecNameTxt = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        FetchBtn = New Button()
        LNameLbl = New Label()
        ExitLbl = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Panel1 = New Panel()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GoBackBtn
        ' 
        GoBackBtn.BackColor = Color.LightSkyBlue
        GoBackBtn.Font = New Font("Reem Kufi", 14.25F, FontStyle.Bold)
        GoBackBtn.Location = New Point(248, 401)
        GoBackBtn.Name = "GoBackBtn"
        GoBackBtn.Size = New Size(140, 47)
        GoBackBtn.TabIndex = 45
        GoBackBtn.Text = "Go Back"
        GoBackBtn.UseVisualStyleBackColor = False
        ' 
        ' LAddressLbl
        ' 
        LAddressLbl.AutoSize = True
        LAddressLbl.Font = New Font("Reem Kufi", 14.25F, FontStyle.Bold Or FontStyle.Underline)
        LAddressLbl.Location = New Point(245, 351)
        LAddressLbl.Name = "LAddressLbl"
        LAddressLbl.Size = New Size(0, 35)
        LAddressLbl.TabIndex = 44
        ' 
        ' LUnitLbl
        ' 
        LUnitLbl.AutoSize = True
        LUnitLbl.Font = New Font("Reem Kufi", 14.25F, FontStyle.Bold Or FontStyle.Underline)
        LUnitLbl.Location = New Point(245, 305)
        LUnitLbl.Name = "LUnitLbl"
        LUnitLbl.Size = New Size(0, 35)
        LUnitLbl.TabIndex = 43
        ' 
        ' LPhoneLbl
        ' 
        LPhoneLbl.AutoSize = True
        LPhoneLbl.Font = New Font("Reem Kufi", 14.25F, FontStyle.Bold Or FontStyle.Underline)
        LPhoneLbl.Location = New Point(245, 257)
        LPhoneLbl.Name = "LPhoneLbl"
        LPhoneLbl.Size = New Size(0, 35)
        LPhoneLbl.TabIndex = 42
        ' 
        ' LDOBLbl
        ' 
        LDOBLbl.AutoSize = True
        LDOBLbl.Font = New Font("Reem Kufi", 14.25F, FontStyle.Bold Or FontStyle.Underline)
        LDOBLbl.Location = New Point(245, 208)
        LDOBLbl.Name = "LDOBLbl"
        LDOBLbl.Size = New Size(0, 35)
        LDOBLbl.TabIndex = 41
        ' 
        ' LGenderLbl
        ' 
        LGenderLbl.AutoSize = True
        LGenderLbl.Font = New Font("Reem Kufi", 14.25F, FontStyle.Bold Or FontStyle.Underline)
        LGenderLbl.Location = New Point(245, 162)
        LGenderLbl.Name = "LGenderLbl"
        LGenderLbl.Size = New Size(0, 35)
        LGenderLbl.TabIndex = 40
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Reem Kufi", 14.25F, FontStyle.Bold)
        Label8.Location = New Point(134, 351)
        Label8.Name = "Label8"
        Label8.Size = New Size(90, 35)
        Label8.TabIndex = 39
        Label8.Text = "Address:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Reem Kufi", 14.25F, FontStyle.Bold)
        Label7.Location = New Point(169, 305)
        Label7.Name = "Label7"
        Label7.Size = New Size(55, 35)
        Label7.TabIndex = 38
        Label7.Text = "Unit:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Reem Kufi", 14.25F, FontStyle.Bold)
        Label6.Location = New Point(150, 257)
        Label6.Name = "Label6"
        Label6.Size = New Size(74, 35)
        Label6.TabIndex = 37
        Label6.Text = "Phone:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Reem Kufi", 14.25F, FontStyle.Bold)
        Label5.Location = New Point(163, 208)
        Label5.Name = "Label5"
        Label5.Size = New Size(61, 35)
        Label5.TabIndex = 36
        Label5.Text = "DOB:"
        ' 
        ' LecNameTxt
        ' 
        LecNameTxt.Font = New Font("Reem Kufi", 14.25F, FontStyle.Bold)
        LecNameTxt.Location = New Point(151, 69)
        LecNameTxt.Name = "LecNameTxt"
        LecNameTxt.Size = New Size(271, 36)
        LecNameTxt.TabIndex = 34
        LecNameTxt.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Reem Kufi", 14.25F, FontStyle.Bold)
        Label2.Location = New Point(117, 118)
        Label2.Name = "Label2"
        Label2.Size = New Size(107, 35)
        Label2.TabIndex = 31
        Label2.Text = "Full Name:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Reem Kufi", 14.25F, FontStyle.Bold)
        Label1.Location = New Point(0, 67)
        Label1.Name = "Label1"
        Label1.Size = New Size(152, 35)
        Label1.TabIndex = 30
        Label1.Text = "Lecturer Name:"
        ' 
        ' FetchBtn
        ' 
        FetchBtn.BackColor = Color.LightSkyBlue
        FetchBtn.Font = New Font("Reem Kufi", 14.25F, FontStyle.Bold)
        FetchBtn.Location = New Point(428, 63)
        FetchBtn.Name = "FetchBtn"
        FetchBtn.Size = New Size(140, 47)
        FetchBtn.TabIndex = 29
        FetchBtn.Text = "Fetch Data"
        FetchBtn.UseVisualStyleBackColor = False
        ' 
        ' LNameLbl
        ' 
        LNameLbl.AutoSize = True
        LNameLbl.Font = New Font("Reem Kufi", 14.25F, FontStyle.Bold Or FontStyle.Underline)
        LNameLbl.Location = New Point(245, 118)
        LNameLbl.Name = "LNameLbl"
        LNameLbl.Size = New Size(0, 35)
        LNameLbl.TabIndex = 33
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
        Label3.Size = New Size(337, 35)
        Label3.TabIndex = 4
        Label3.Text = "Academic Nexus Pro Lecturer Details"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Reem Kufi", 14.25F, FontStyle.Bold)
        Label4.Location = New Point(139, 162)
        Label4.Name = "Label4"
        Label4.Size = New Size(85, 35)
        Label4.TabIndex = 35
        Label4.Text = "Gender:"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.RoyalBlue
        Panel1.Controls.Add(ExitLbl)
        Panel1.Controls.Add(Label3)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(594, 53)
        Panel1.TabIndex = 32
        ' 
        ' LecDetails
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(594, 450)
        Controls.Add(GoBackBtn)
        Controls.Add(LAddressLbl)
        Controls.Add(LUnitLbl)
        Controls.Add(LPhoneLbl)
        Controls.Add(LDOBLbl)
        Controls.Add(LGenderLbl)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(LecNameTxt)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(FetchBtn)
        Controls.Add(LNameLbl)
        Controls.Add(Label4)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "LecDetails"
        StartPosition = FormStartPosition.CenterScreen
        Text = "LecDetails"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GoBackBtn As Button
    Friend WithEvents LAddressLbl As Label
    Friend WithEvents LUnitLbl As Label
    Friend WithEvents LPhoneLbl As Label
    Friend WithEvents LDOBLbl As Label
    Friend WithEvents LGenderLbl As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LecNameTxt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents FetchBtn As Button
    Friend WithEvents LNameLbl As Label
    Friend WithEvents ExitLbl As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
End Class
