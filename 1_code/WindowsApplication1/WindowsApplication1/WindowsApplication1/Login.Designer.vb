<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.UsernameLbl = New System.Windows.Forms.Label()
        Me.Passwordlbl = New System.Windows.Forms.Label()
        Me.SignInBtn = New System.Windows.Forms.Button()
        Me.CreateAccountLink = New System.Windows.Forms.LinkLabel()
        Me.ForgotPasswordLink = New System.Windows.Forms.LinkLabel()
        Me.UsernameTxtBx = New System.Windows.Forms.TextBox()
        Me.PasswordTxtBx = New System.Windows.Forms.TextBox()
        Me.OfflineButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'UsernameLbl
        '
        Me.UsernameLbl.AutoSize = True
        Me.UsernameLbl.Location = New System.Drawing.Point(49, 49)
        Me.UsernameLbl.Name = "UsernameLbl"
        Me.UsernameLbl.Size = New System.Drawing.Size(58, 13)
        Me.UsernameLbl.TabIndex = 0
        Me.UsernameLbl.Text = "Username:"
        '
        'Passwordlbl
        '
        Me.Passwordlbl.AutoSize = True
        Me.Passwordlbl.Location = New System.Drawing.Point(51, 84)
        Me.Passwordlbl.Name = "Passwordlbl"
        Me.Passwordlbl.Size = New System.Drawing.Size(56, 13)
        Me.Passwordlbl.TabIndex = 1
        Me.Passwordlbl.Text = "Password:"
        '
        'SignInBtn
        '
        Me.SignInBtn.Location = New System.Drawing.Point(286, 62)
        Me.SignInBtn.Name = "SignInBtn"
        Me.SignInBtn.Size = New System.Drawing.Size(87, 26)
        Me.SignInBtn.TabIndex = 4
        Me.SignInBtn.Text = "Sign In"
        Me.SignInBtn.UseVisualStyleBackColor = True
        '
        'CreateAccountLink
        '
        Me.CreateAccountLink.AutoSize = True
        Me.CreateAccountLink.Location = New System.Drawing.Point(51, 128)
        Me.CreateAccountLink.Name = "CreateAccountLink"
        Me.CreateAccountLink.Size = New System.Drawing.Size(81, 13)
        Me.CreateAccountLink.TabIndex = 5
        Me.CreateAccountLink.TabStop = True
        Me.CreateAccountLink.Text = "Create Account"
        '
        'ForgotPasswordLink
        '
        Me.ForgotPasswordLink.AutoSize = True
        Me.ForgotPasswordLink.Location = New System.Drawing.Point(51, 152)
        Me.ForgotPasswordLink.Name = "ForgotPasswordLink"
        Me.ForgotPasswordLink.Size = New System.Drawing.Size(92, 13)
        Me.ForgotPasswordLink.TabIndex = 6
        Me.ForgotPasswordLink.TabStop = True
        Me.ForgotPasswordLink.Text = "Forgot Password?"
        '
        'UsernameTxtBx
        '
        Me.UsernameTxtBx.Location = New System.Drawing.Point(133, 47)
        Me.UsernameTxtBx.Name = "UsernameTxtBx"
        Me.UsernameTxtBx.Size = New System.Drawing.Size(128, 20)
        Me.UsernameTxtBx.TabIndex = 9
        '
        'PasswordTxtBx
        '
        Me.PasswordTxtBx.Location = New System.Drawing.Point(135, 89)
        Me.PasswordTxtBx.Name = "PasswordTxtBx"
        Me.PasswordTxtBx.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTxtBx.Size = New System.Drawing.Size(126, 20)
        Me.PasswordTxtBx.TabIndex = 10
        '
        'OfflineButton
        '
        Me.OfflineButton.Location = New System.Drawing.Point(294, 135)
        Me.OfflineButton.Name = "OfflineButton"
        Me.OfflineButton.Size = New System.Drawing.Size(75, 23)
        Me.OfflineButton.TabIndex = 11
        Me.OfflineButton.Text = "Offline"
        Me.OfflineButton.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(396, 183)
        Me.Controls.Add(Me.OfflineButton)
        Me.Controls.Add(Me.PasswordTxtBx)
        Me.Controls.Add(Me.UsernameTxtBx)
        Me.Controls.Add(Me.ForgotPasswordLink)
        Me.Controls.Add(Me.CreateAccountLink)
        Me.Controls.Add(Me.SignInBtn)
        Me.Controls.Add(Me.Passwordlbl)
        Me.Controls.Add(Me.UsernameLbl)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UsernameLbl As System.Windows.Forms.Label
    Friend WithEvents Passwordlbl As System.Windows.Forms.Label
    Friend WithEvents SignInBtn As System.Windows.Forms.Button
    Friend WithEvents CreateAccountLink As System.Windows.Forms.LinkLabel
    Friend WithEvents ForgotPasswordLink As System.Windows.Forms.LinkLabel
    Friend WithEvents UsernameTxtBx As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTxtBx As System.Windows.Forms.TextBox
    Friend WithEvents OfflineButton As System.Windows.Forms.Button
End Class
