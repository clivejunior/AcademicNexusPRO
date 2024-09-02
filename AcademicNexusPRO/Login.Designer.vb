<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        UsernameTxt = New TextBox()
        PasswordTxt = New TextBox()
        LoginButton = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Panel1 = New Panel()
        ExitLbl = New Label()
        Label3 = New Label()
        ClearLbl = New Label()
        PassCheck = New CheckBox()
        cmbChoice = New ComboBox()
        Label4 = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' UsernameTxt
        ' 
        UsernameTxt.Font = New Font("Reem Kufi", 14.25F, FontStyle.Bold)
        UsernameTxt.Location = New Point(122, 70)
        UsernameTxt.Name = "UsernameTxt"
        UsernameTxt.Size = New Size(271, 36)
        UsernameTxt.TabIndex = 0
        UsernameTxt.TextAlign = HorizontalAlignment.Center
        ' 
        ' PasswordTxt
        ' 
        PasswordTxt.Font = New Font("Reem Kufi", 14.25F, FontStyle.Bold)
        PasswordTxt.Location = New Point(122, 117)
        PasswordTxt.Name = "PasswordTxt"
        PasswordTxt.PasswordChar = "*"c
        PasswordTxt.Size = New Size(271, 36)
        PasswordTxt.TabIndex = 1
        PasswordTxt.TextAlign = HorizontalAlignment.Center
        ' 
        ' LoginButton
        ' 
        LoginButton.BackColor = Color.LightSkyBlue
        LoginButton.Font = New Font("Reem Kufi", 14.25F, FontStyle.Bold)
        LoginButton.Location = New Point(166, 231)
        LoginButton.Name = "LoginButton"
        LoginButton.Size = New Size(140, 46)
        LoginButton.TabIndex = 2
        LoginButton.Text = "Login"
        LoginButton.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Reem Kufi", 14.25F, FontStyle.Bold)
        Label1.Location = New Point(6, 70)
        Label1.Name = "Label1"
        Label1.Size = New Size(114, 35)
        Label1.TabIndex = 3
        Label1.Text = "UserName:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Reem Kufi", 14.25F, FontStyle.Bold)
        Label2.Location = New Point(18, 118)
        Label2.Name = "Label2"
        Label2.Size = New Size(102, 35)
        Label2.TabIndex = 4
        Label2.Text = "Password:"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.RoyalBlue
        Panel1.Controls.Add(ExitLbl)
        Panel1.Controls.Add(Label3)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(458, 53)
        Panel1.TabIndex = 5
        ' 
        ' ExitLbl
        ' 
        ExitLbl.AutoSize = True
        ExitLbl.Font = New Font("Reem Kufi", 14.25F, FontStyle.Bold Or FontStyle.Underline)
        ExitLbl.ForeColor = Color.Red
        ExitLbl.Location = New Point(427, 0)
        ExitLbl.Name = "ExitLbl"
        ExitLbl.Size = New Size(29, 35)
        ExitLbl.TabIndex = 7
        ExitLbl.Text = "X"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Reem Kufi", 14.25F, FontStyle.Bold)
        Label3.Location = New Point(125, 9)
        Label3.Name = "Label3"
        Label3.Size = New Size(259, 35)
        Label3.TabIndex = 4
        Label3.Text = "Academic Nexus Pro LOGIN"
        ' 
        ' ClearLbl
        ' 
        ClearLbl.AutoSize = True
        ClearLbl.Font = New Font("Reem Kufi", 14.25F, FontStyle.Bold Or FontStyle.Underline)
        ClearLbl.Location = New Point(202, 280)
        ClearLbl.Name = "ClearLbl"
        ClearLbl.Size = New Size(65, 35)
        ClearLbl.TabIndex = 6
        ClearLbl.Text = "Reset"
        ' 
        ' PassCheck
        ' 
        PassCheck.AutoSize = True
        PassCheck.Font = New Font("Reem Kufi", 10F, FontStyle.Bold)
        PassCheck.Location = New Point(122, 182)
        PassCheck.Name = "PassCheck"
        PassCheck.Size = New Size(128, 30)
        PassCheck.TabIndex = 7
        PassCheck.Text = "View Password"
        PassCheck.UseVisualStyleBackColor = True
        ' 
        ' cmbChoice
        ' 
        cmbChoice.Font = New Font("Reem Kufi", 10F, FontStyle.Bold)
        cmbChoice.FormattingEnabled = True
        cmbChoice.Items.AddRange(New Object() {"Admin", "Lecturer", "Student"})
        cmbChoice.Location = New Point(256, 182)
        cmbChoice.Name = "cmbChoice"
        cmbChoice.Size = New Size(137, 31)
        cmbChoice.TabIndex = 8
        cmbChoice.Text = "CHOOSE TYPE"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Reem Kufi", 10F, FontStyle.Bold)
        Label4.Location = New Point(287, 156)
        Label4.Name = "Label4"
        Label4.Size = New Size(76, 26)
        Label4.TabIndex = 9
        Label4.Text = "User Type"
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(458, 324)
        Controls.Add(Label4)
        Controls.Add(cmbChoice)
        Controls.Add(PassCheck)
        Controls.Add(ClearLbl)
        Controls.Add(Panel1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(LoginButton)
        Controls.Add(PasswordTxt)
        Controls.Add(UsernameTxt)
        FormBorderStyle = FormBorderStyle.None
        Name = "Login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents UsernameTxt As TextBox
    Friend WithEvents PasswordTxt As TextBox
    Friend WithEvents LoginButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents ClearLbl As Label
    Friend WithEvents ExitLbl As Label
    Friend WithEvents PassCheck As CheckBox
    Friend WithEvents cmbChoice As ComboBox
    Friend WithEvents Label4 As Label

End Class
