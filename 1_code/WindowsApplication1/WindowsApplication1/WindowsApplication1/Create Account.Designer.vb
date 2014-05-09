<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registration
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
        Me.PersonalInformationLabel = New System.Windows.Forms.Label()
        Me.FirstNameLabel = New System.Windows.Forms.Label()
        Me.LastNameLabel = New System.Windows.Forms.Label()
        Me.BusinessLabel = New System.Windows.Forms.Label()
        Me.AddressLabel = New System.Windows.Forms.Label()
        Me.CityLabel = New System.Windows.Forms.Label()
        Me.StateLabel = New System.Windows.Forms.Label()
        Me.StateComboBox = New System.Windows.Forms.ComboBox()
        Me.ZipLabel = New System.Windows.Forms.Label()
        Me.PersonalInfoGrpBx = New System.Windows.Forms.GroupBox()
        Me.ZipTxtBx = New System.Windows.Forms.MaskedTextBox()
        Me.CityTxtBx = New System.Windows.Forms.MaskedTextBox()
        Me.AddressTxtBx = New System.Windows.Forms.MaskedTextBox()
        Me.BusinessTxtBx = New System.Windows.Forms.MaskedTextBox()
        Me.LastNameTxtBx = New System.Windows.Forms.MaskedTextBox()
        Me.FirstNameTxtBx = New System.Windows.Forms.MaskedTextBox()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.ReenterPasswordLabel = New System.Windows.Forms.Label()
        Me.LoginInfoGrpBx = New System.Windows.Forms.GroupBox()
        Me.ReenterPasswordTxtBx = New System.Windows.Forms.MaskedTextBox()
        Me.PasswordTxtBx = New System.Windows.Forms.MaskedTextBox()
        Me.CardNumberLabel = New System.Windows.Forms.Label()
        Me.CVVlabel = New System.Windows.Forms.Label()
        Me.CardTypeLabel = New System.Windows.Forms.Label()
        Me.ExpDateLabel = New System.Windows.Forms.Label()
        Me.NameOnCardLabel = New System.Windows.Forms.Label()
        Me.CardTypeComboBox = New System.Windows.Forms.ComboBox()
        Me.PaymentInfoGrpBx = New System.Windows.Forms.GroupBox()
        Me.NameOnCardTxtBx = New System.Windows.Forms.MaskedTextBox()
        Me.ExpDateTxtBx = New System.Windows.Forms.MaskedTextBox()
        Me.CvvTxtBx = New System.Windows.Forms.MaskedTextBox()
        Me.CardNumberTxtBx = New System.Windows.Forms.MaskedTextBox()
        Me.Address1Label = New System.Windows.Forms.Label()
        Me.Address2Label = New System.Windows.Forms.Label()
        Me.BillingCityLabel = New System.Windows.Forms.Label()
        Me.BillingStateLabel = New System.Windows.Forms.Label()
        Me.BillingZipLabel = New System.Windows.Forms.Label()
        Me.BillingStateComboBox = New System.Windows.Forms.ComboBox()
        Me.BillingAddressGrpBx = New System.Windows.Forms.GroupBox()
        Me.ZipBillingTxtBx = New System.Windows.Forms.MaskedTextBox()
        Me.CityBillingTxtBx = New System.Windows.Forms.MaskedTextBox()
        Me.Address2TxtBx = New System.Windows.Forms.MaskedTextBox()
        Me.Address1TxtBx = New System.Windows.Forms.MaskedTextBox()
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.UsernameTxtBx = New System.Windows.Forms.TextBox()
        Me.PersonalInfoGrpBx.SuspendLayout()
        Me.LoginInfoGrpBx.SuspendLayout()
        Me.PaymentInfoGrpBx.SuspendLayout()
        Me.BillingAddressGrpBx.SuspendLayout()
        Me.SuspendLayout()
        '
        'PersonalInformationLabel
        '
        Me.PersonalInformationLabel.AutoSize = True
        Me.PersonalInformationLabel.Location = New System.Drawing.Point(6, 0)
        Me.PersonalInformationLabel.Name = "PersonalInformationLabel"
        Me.PersonalInformationLabel.Size = New System.Drawing.Size(103, 13)
        Me.PersonalInformationLabel.TabIndex = 0
        Me.PersonalInformationLabel.Text = "Personal Information"
        '
        'FirstNameLabel
        '
        Me.FirstNameLabel.AutoSize = True
        Me.FirstNameLabel.Location = New System.Drawing.Point(6, 24)
        Me.FirstNameLabel.Name = "FirstNameLabel"
        Me.FirstNameLabel.Size = New System.Drawing.Size(67, 13)
        Me.FirstNameLabel.TabIndex = 1
        Me.FirstNameLabel.Text = "* First Name:"
        '
        'LastNameLabel
        '
        Me.LastNameLabel.AutoSize = True
        Me.LastNameLabel.Location = New System.Drawing.Point(168, 24)
        Me.LastNameLabel.Name = "LastNameLabel"
        Me.LastNameLabel.Size = New System.Drawing.Size(68, 13)
        Me.LastNameLabel.TabIndex = 3
        Me.LastNameLabel.Text = "* Last Name:"
        '
        'BusinessLabel
        '
        Me.BusinessLabel.AutoSize = True
        Me.BusinessLabel.Location = New System.Drawing.Point(6, 54)
        Me.BusinessLabel.Name = "BusinessLabel"
        Me.BusinessLabel.Size = New System.Drawing.Size(55, 13)
        Me.BusinessLabel.TabIndex = 5
        Me.BusinessLabel.Text = "Business: "
        '
        'AddressLabel
        '
        Me.AddressLabel.AutoSize = True
        Me.AddressLabel.Location = New System.Drawing.Point(6, 85)
        Me.AddressLabel.Name = "AddressLabel"
        Me.AddressLabel.Size = New System.Drawing.Size(55, 13)
        Me.AddressLabel.TabIndex = 7
        Me.AddressLabel.Text = "* Address:"
        '
        'CityLabel
        '
        Me.CityLabel.AutoSize = True
        Me.CityLabel.Location = New System.Drawing.Point(6, 114)
        Me.CityLabel.Name = "CityLabel"
        Me.CityLabel.Size = New System.Drawing.Size(34, 13)
        Me.CityLabel.TabIndex = 9
        Me.CityLabel.Text = "* City:"
        '
        'StateLabel
        '
        Me.StateLabel.AutoSize = True
        Me.StateLabel.Location = New System.Drawing.Point(161, 114)
        Me.StateLabel.Name = "StateLabel"
        Me.StateLabel.Size = New System.Drawing.Size(42, 13)
        Me.StateLabel.TabIndex = 11
        Me.StateLabel.Text = "* State:"
        '
        'StateComboBox
        '
        Me.StateComboBox.FormattingEnabled = True
        Me.StateComboBox.Location = New System.Drawing.Point(199, 111)
        Me.StateComboBox.Name = "StateComboBox"
        Me.StateComboBox.Size = New System.Drawing.Size(47, 21)
        Me.StateComboBox.TabIndex = 21
        '
        'ZipLabel
        '
        Me.ZipLabel.AutoSize = True
        Me.ZipLabel.Location = New System.Drawing.Point(252, 114)
        Me.ZipLabel.Name = "ZipLabel"
        Me.ZipLabel.Size = New System.Drawing.Size(29, 13)
        Me.ZipLabel.TabIndex = 13
        Me.ZipLabel.Text = "*Zip:"
        '
        'PersonalInfoGrpBx
        '
        Me.PersonalInfoGrpBx.Controls.Add(Me.ZipTxtBx)
        Me.PersonalInfoGrpBx.Controls.Add(Me.CityTxtBx)
        Me.PersonalInfoGrpBx.Controls.Add(Me.AddressTxtBx)
        Me.PersonalInfoGrpBx.Controls.Add(Me.BusinessTxtBx)
        Me.PersonalInfoGrpBx.Controls.Add(Me.LastNameTxtBx)
        Me.PersonalInfoGrpBx.Controls.Add(Me.FirstNameTxtBx)
        Me.PersonalInfoGrpBx.Controls.Add(Me.ZipLabel)
        Me.PersonalInfoGrpBx.Controls.Add(Me.StateComboBox)
        Me.PersonalInfoGrpBx.Controls.Add(Me.StateLabel)
        Me.PersonalInfoGrpBx.Controls.Add(Me.CityLabel)
        Me.PersonalInfoGrpBx.Controls.Add(Me.AddressLabel)
        Me.PersonalInfoGrpBx.Controls.Add(Me.BusinessLabel)
        Me.PersonalInfoGrpBx.Controls.Add(Me.LastNameLabel)
        Me.PersonalInfoGrpBx.Controls.Add(Me.FirstNameLabel)
        Me.PersonalInfoGrpBx.Controls.Add(Me.PersonalInformationLabel)
        Me.PersonalInfoGrpBx.Location = New System.Drawing.Point(6, 9)
        Me.PersonalInfoGrpBx.Name = "PersonalInfoGrpBx"
        Me.PersonalInfoGrpBx.Size = New System.Drawing.Size(359, 141)
        Me.PersonalInfoGrpBx.TabIndex = 15
        Me.PersonalInfoGrpBx.TabStop = False
        Me.PersonalInfoGrpBx.Text = "GroupBox1"
        '
        'ZipTxtBx
        '
        Me.ZipTxtBx.Location = New System.Drawing.Point(277, 111)
        Me.ZipTxtBx.Mask = "00000"
        Me.ZipTxtBx.Name = "ZipTxtBx"
        Me.ZipTxtBx.Size = New System.Drawing.Size(68, 20)
        Me.ZipTxtBx.TabIndex = 22
        '
        'CityTxtBx
        '
        Me.CityTxtBx.Location = New System.Drawing.Point(62, 111)
        Me.CityTxtBx.Mask = "LLL????????????????????"
        Me.CityTxtBx.Name = "CityTxtBx"
        Me.CityTxtBx.Size = New System.Drawing.Size(100, 20)
        Me.CityTxtBx.TabIndex = 19
        '
        'AddressTxtBx
        '
        Me.AddressTxtBx.Location = New System.Drawing.Point(62, 82)
        Me.AddressTxtBx.Mask = "&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&"
        Me.AddressTxtBx.Name = "AddressTxtBx"
        Me.AddressTxtBx.Size = New System.Drawing.Size(283, 20)
        Me.AddressTxtBx.TabIndex = 18
        '
        'BusinessTxtBx
        '
        Me.BusinessTxtBx.Location = New System.Drawing.Point(62, 54)
        Me.BusinessTxtBx.Name = "BusinessTxtBx"
        Me.BusinessTxtBx.Size = New System.Drawing.Size(283, 20)
        Me.BusinessTxtBx.TabIndex = 17
        '
        'LastNameTxtBx
        '
        Me.LastNameTxtBx.Location = New System.Drawing.Point(236, 24)
        Me.LastNameTxtBx.Name = "LastNameTxtBx"
        Me.LastNameTxtBx.Size = New System.Drawing.Size(109, 20)
        Me.LastNameTxtBx.TabIndex = 16
        '
        'FirstNameTxtBx
        '
        Me.FirstNameTxtBx.Location = New System.Drawing.Point(72, 21)
        Me.FirstNameTxtBx.Name = "FirstNameTxtBx"
        Me.FirstNameTxtBx.Size = New System.Drawing.Size(91, 20)
        Me.FirstNameTxtBx.TabIndex = 15
        '
        'UsernameLabel
        '
        Me.UsernameLabel.AutoSize = True
        Me.UsernameLabel.Location = New System.Drawing.Point(3, 14)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(42, 13)
        Me.UsernameLabel.TabIndex = 17
        Me.UsernameLabel.Text = "* Email:"
        '
        'PasswordLabel
        '
        Me.PasswordLabel.AutoSize = True
        Me.PasswordLabel.Location = New System.Drawing.Point(3, 40)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(63, 13)
        Me.PasswordLabel.TabIndex = 18
        Me.PasswordLabel.Text = "* Password:"
        '
        'ReenterPasswordLabel
        '
        Me.ReenterPasswordLabel.AutoSize = True
        Me.ReenterPasswordLabel.Location = New System.Drawing.Point(3, 66)
        Me.ReenterPasswordLabel.Name = "ReenterPasswordLabel"
        Me.ReenterPasswordLabel.Size = New System.Drawing.Size(104, 13)
        Me.ReenterPasswordLabel.TabIndex = 19
        Me.ReenterPasswordLabel.Text = "* Reenter Password:"
        '
        'LoginInfoGrpBx
        '
        Me.LoginInfoGrpBx.Controls.Add(Me.UsernameTxtBx)
        Me.LoginInfoGrpBx.Controls.Add(Me.ReenterPasswordTxtBx)
        Me.LoginInfoGrpBx.Controls.Add(Me.PasswordTxtBx)
        Me.LoginInfoGrpBx.Controls.Add(Me.ReenterPasswordLabel)
        Me.LoginInfoGrpBx.Controls.Add(Me.PasswordLabel)
        Me.LoginInfoGrpBx.Controls.Add(Me.UsernameLabel)
        Me.LoginInfoGrpBx.Location = New System.Drawing.Point(6, 156)
        Me.LoginInfoGrpBx.Name = "LoginInfoGrpBx"
        Me.LoginInfoGrpBx.Size = New System.Drawing.Size(359, 106)
        Me.LoginInfoGrpBx.TabIndex = 23
        Me.LoginInfoGrpBx.TabStop = False
        Me.LoginInfoGrpBx.Text = "Login Information"
        '
        'ReenterPasswordTxtBx
        '
        Me.ReenterPasswordTxtBx.Location = New System.Drawing.Point(108, 65)
        Me.ReenterPasswordTxtBx.Mask = "AAAAAAAAAAAAAAA"
        Me.ReenterPasswordTxtBx.Name = "ReenterPasswordTxtBx"
        Me.ReenterPasswordTxtBx.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.ReenterPasswordTxtBx.Size = New System.Drawing.Size(142, 20)
        Me.ReenterPasswordTxtBx.TabIndex = 25
        '
        'PasswordTxtBx
        '
        Me.PasswordTxtBx.Location = New System.Drawing.Point(108, 38)
        Me.PasswordTxtBx.Mask = "AAAAAAAAAAAAAAA"
        Me.PasswordTxtBx.Name = "PasswordTxtBx"
        Me.PasswordTxtBx.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTxtBx.Size = New System.Drawing.Size(142, 20)
        Me.PasswordTxtBx.TabIndex = 24
        '
        'CardNumberLabel
        '
        Me.CardNumberLabel.AutoSize = True
        Me.CardNumberLabel.Location = New System.Drawing.Point(4, 30)
        Me.CardNumberLabel.Name = "CardNumberLabel"
        Me.CardNumberLabel.Size = New System.Drawing.Size(76, 13)
        Me.CardNumberLabel.TabIndex = 24
        Me.CardNumberLabel.Text = "*Card Number:"
        '
        'CVVlabel
        '
        Me.CVVlabel.AutoSize = True
        Me.CVVlabel.Location = New System.Drawing.Point(259, 30)
        Me.CVVlabel.Name = "CVVlabel"
        Me.CVVlabel.Size = New System.Drawing.Size(35, 13)
        Me.CVVlabel.TabIndex = 25
        Me.CVVlabel.Text = "*CVV:"
        '
        'CardTypeLabel
        '
        Me.CardTypeLabel.AutoSize = True
        Me.CardTypeLabel.Location = New System.Drawing.Point(1, 69)
        Me.CardTypeLabel.Name = "CardTypeLabel"
        Me.CardTypeLabel.Size = New System.Drawing.Size(63, 13)
        Me.CardTypeLabel.TabIndex = 26
        Me.CardTypeLabel.Text = "*Card Type:"
        '
        'ExpDateLabel
        '
        Me.ExpDateLabel.AutoSize = True
        Me.ExpDateLabel.Location = New System.Drawing.Point(100, 69)
        Me.ExpDateLabel.Name = "ExpDateLabel"
        Me.ExpDateLabel.Size = New System.Drawing.Size(58, 13)
        Me.ExpDateLabel.TabIndex = 27
        Me.ExpDateLabel.Text = "*Exp Date:"
        '
        'NameOnCardLabel
        '
        Me.NameOnCardLabel.AutoSize = True
        Me.NameOnCardLabel.Location = New System.Drawing.Point(171, 69)
        Me.NameOnCardLabel.Name = "NameOnCardLabel"
        Me.NameOnCardLabel.Size = New System.Drawing.Size(82, 13)
        Me.NameOnCardLabel.TabIndex = 28
        Me.NameOnCardLabel.Text = "*Name on Card:"
        '
        'CardTypeComboBox
        '
        Me.CardTypeComboBox.FormattingEnabled = True
        Me.CardTypeComboBox.Location = New System.Drawing.Point(4, 85)
        Me.CardTypeComboBox.Name = "CardTypeComboBox"
        Me.CardTypeComboBox.Size = New System.Drawing.Size(93, 21)
        Me.CardTypeComboBox.TabIndex = 28
        '
        'PaymentInfoGrpBx
        '
        Me.PaymentInfoGrpBx.Controls.Add(Me.NameOnCardTxtBx)
        Me.PaymentInfoGrpBx.Controls.Add(Me.ExpDateTxtBx)
        Me.PaymentInfoGrpBx.Controls.Add(Me.CvvTxtBx)
        Me.PaymentInfoGrpBx.Controls.Add(Me.CardNumberTxtBx)
        Me.PaymentInfoGrpBx.Controls.Add(Me.CardTypeComboBox)
        Me.PaymentInfoGrpBx.Controls.Add(Me.NameOnCardLabel)
        Me.PaymentInfoGrpBx.Controls.Add(Me.ExpDateLabel)
        Me.PaymentInfoGrpBx.Controls.Add(Me.CardTypeLabel)
        Me.PaymentInfoGrpBx.Controls.Add(Me.CVVlabel)
        Me.PaymentInfoGrpBx.Controls.Add(Me.CardNumberLabel)
        Me.PaymentInfoGrpBx.Location = New System.Drawing.Point(8, 268)
        Me.PaymentInfoGrpBx.Name = "PaymentInfoGrpBx"
        Me.PaymentInfoGrpBx.Size = New System.Drawing.Size(356, 117)
        Me.PaymentInfoGrpBx.TabIndex = 34
        Me.PaymentInfoGrpBx.TabStop = False
        Me.PaymentInfoGrpBx.Text = "Payment Information"
        '
        'NameOnCardTxtBx
        '
        Me.NameOnCardTxtBx.Location = New System.Drawing.Point(174, 86)
        Me.NameOnCardTxtBx.Mask = "LLLLLLLLLLLLLLLLLLLLLLLLLLLLLL"
        Me.NameOnCardTxtBx.Name = "NameOnCardTxtBx"
        Me.NameOnCardTxtBx.Size = New System.Drawing.Size(140, 20)
        Me.NameOnCardTxtBx.TabIndex = 30
        '
        'ExpDateTxtBx
        '
        Me.ExpDateTxtBx.Location = New System.Drawing.Point(106, 85)
        Me.ExpDateTxtBx.Mask = "00/00"
        Me.ExpDateTxtBx.Name = "ExpDateTxtBx"
        Me.ExpDateTxtBx.Size = New System.Drawing.Size(62, 20)
        Me.ExpDateTxtBx.TabIndex = 29
        '
        'CvvTxtBx
        '
        Me.CvvTxtBx.Location = New System.Drawing.Point(262, 45)
        Me.CvvTxtBx.Mask = "000"
        Me.CvvTxtBx.Name = "CvvTxtBx"
        Me.CvvTxtBx.Size = New System.Drawing.Size(52, 20)
        Me.CvvTxtBx.TabIndex = 27
        '
        'CardNumberTxtBx
        '
        Me.CardNumberTxtBx.Location = New System.Drawing.Point(8, 46)
        Me.CardNumberTxtBx.Mask = "0000000000000000"
        Me.CardNumberTxtBx.Name = "CardNumberTxtBx"
        Me.CardNumberTxtBx.Size = New System.Drawing.Size(236, 20)
        Me.CardNumberTxtBx.TabIndex = 26
        '
        'Address1Label
        '
        Me.Address1Label.AutoSize = True
        Me.Address1Label.Location = New System.Drawing.Point(5, 22)
        Me.Address1Label.Name = "Address1Label"
        Me.Address1Label.Size = New System.Drawing.Size(54, 13)
        Me.Address1Label.TabIndex = 35
        Me.Address1Label.Text = "Address1:"
        '
        'Address2Label
        '
        Me.Address2Label.AutoSize = True
        Me.Address2Label.Location = New System.Drawing.Point(5, 52)
        Me.Address2Label.Name = "Address2Label"
        Me.Address2Label.Size = New System.Drawing.Size(54, 13)
        Me.Address2Label.TabIndex = 36
        Me.Address2Label.Text = "Address2:"
        '
        'BillingCityLabel
        '
        Me.BillingCityLabel.AutoSize = True
        Me.BillingCityLabel.Location = New System.Drawing.Point(5, 81)
        Me.BillingCityLabel.Name = "BillingCityLabel"
        Me.BillingCityLabel.Size = New System.Drawing.Size(27, 13)
        Me.BillingCityLabel.TabIndex = 37
        Me.BillingCityLabel.Text = "City:"
        '
        'BillingStateLabel
        '
        Me.BillingStateLabel.AutoSize = True
        Me.BillingStateLabel.Location = New System.Drawing.Point(159, 81)
        Me.BillingStateLabel.Name = "BillingStateLabel"
        Me.BillingStateLabel.Size = New System.Drawing.Size(35, 13)
        Me.BillingStateLabel.TabIndex = 38
        Me.BillingStateLabel.Text = "State:"
        '
        'BillingZipLabel
        '
        Me.BillingZipLabel.AutoSize = True
        Me.BillingZipLabel.Location = New System.Drawing.Point(244, 81)
        Me.BillingZipLabel.Name = "BillingZipLabel"
        Me.BillingZipLabel.Size = New System.Drawing.Size(25, 13)
        Me.BillingZipLabel.TabIndex = 39
        Me.BillingZipLabel.Text = "Zip:"
        '
        'BillingStateComboBox
        '
        Me.BillingStateComboBox.FormattingEnabled = True
        Me.BillingStateComboBox.Location = New System.Drawing.Point(191, 78)
        Me.BillingStateComboBox.Name = "BillingStateComboBox"
        Me.BillingStateComboBox.Size = New System.Drawing.Size(46, 21)
        Me.BillingStateComboBox.TabIndex = 34
        '
        'BillingAddressGrpBx
        '
        Me.BillingAddressGrpBx.Controls.Add(Me.ZipBillingTxtBx)
        Me.BillingAddressGrpBx.Controls.Add(Me.CityBillingTxtBx)
        Me.BillingAddressGrpBx.Controls.Add(Me.Address2TxtBx)
        Me.BillingAddressGrpBx.Controls.Add(Me.Address1TxtBx)
        Me.BillingAddressGrpBx.Controls.Add(Me.BillingStateComboBox)
        Me.BillingAddressGrpBx.Controls.Add(Me.BillingZipLabel)
        Me.BillingAddressGrpBx.Controls.Add(Me.BillingStateLabel)
        Me.BillingAddressGrpBx.Controls.Add(Me.BillingCityLabel)
        Me.BillingAddressGrpBx.Controls.Add(Me.Address2Label)
        Me.BillingAddressGrpBx.Controls.Add(Me.Address1Label)
        Me.BillingAddressGrpBx.Location = New System.Drawing.Point(8, 400)
        Me.BillingAddressGrpBx.Name = "BillingAddressGrpBx"
        Me.BillingAddressGrpBx.Size = New System.Drawing.Size(354, 124)
        Me.BillingAddressGrpBx.TabIndex = 45
        Me.BillingAddressGrpBx.TabStop = False
        Me.BillingAddressGrpBx.Text = "Billing Address"
        '
        'ZipBillingTxtBx
        '
        Me.ZipBillingTxtBx.Location = New System.Drawing.Point(275, 78)
        Me.ZipBillingTxtBx.Mask = "00000"
        Me.ZipBillingTxtBx.Name = "ZipBillingTxtBx"
        Me.ZipBillingTxtBx.Size = New System.Drawing.Size(61, 20)
        Me.ZipBillingTxtBx.TabIndex = 35
        '
        'CityBillingTxtBx
        '
        Me.CityBillingTxtBx.Location = New System.Drawing.Point(54, 78)
        Me.CityBillingTxtBx.Mask = "LLLLLLLLLLLLLLLLLLLL"
        Me.CityBillingTxtBx.Name = "CityBillingTxtBx"
        Me.CityBillingTxtBx.Size = New System.Drawing.Size(100, 20)
        Me.CityBillingTxtBx.TabIndex = 33
        '
        'Address2TxtBx
        '
        Me.Address2TxtBx.Location = New System.Drawing.Point(62, 49)
        Me.Address2TxtBx.Name = "Address2TxtBx"
        Me.Address2TxtBx.Size = New System.Drawing.Size(275, 20)
        Me.Address2TxtBx.TabIndex = 32
        '
        'Address1TxtBx
        '
        Me.Address1TxtBx.Location = New System.Drawing.Point(61, 19)
        Me.Address1TxtBx.Name = "Address1TxtBx"
        Me.Address1TxtBx.Size = New System.Drawing.Size(275, 20)
        Me.Address1TxtBx.TabIndex = 31
        '
        'SubmitButton
        '
        Me.SubmitButton.Location = New System.Drawing.Point(255, 531)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(110, 24)
        Me.SubmitButton.TabIndex = 46
        Me.SubmitButton.Text = "Submit"
        Me.SubmitButton.UseVisualStyleBackColor = True
        '
        'UsernameTxtBx
        '
        Me.UsernameTxtBx.Location = New System.Drawing.Point(108, 12)
        Me.UsernameTxtBx.Name = "UsernameTxtBx"
        Me.UsernameTxtBx.Size = New System.Drawing.Size(142, 20)
        Me.UsernameTxtBx.TabIndex = 23
        '
        'Registration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(376, 566)
        Me.Controls.Add(Me.SubmitButton)
        Me.Controls.Add(Me.BillingAddressGrpBx)
        Me.Controls.Add(Me.PaymentInfoGrpBx)
        Me.Controls.Add(Me.LoginInfoGrpBx)
        Me.Controls.Add(Me.PersonalInfoGrpBx)
        Me.Name = "Registration"
        Me.Text = "Create Account"
        Me.PersonalInfoGrpBx.ResumeLayout(False)
        Me.PersonalInfoGrpBx.PerformLayout()
        Me.LoginInfoGrpBx.ResumeLayout(False)
        Me.LoginInfoGrpBx.PerformLayout()
        Me.PaymentInfoGrpBx.ResumeLayout(False)
        Me.PaymentInfoGrpBx.PerformLayout()
        Me.BillingAddressGrpBx.ResumeLayout(False)
        Me.BillingAddressGrpBx.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PersonalInformationLabel As System.Windows.Forms.Label
    Friend WithEvents FirstNameLabel As System.Windows.Forms.Label
    Friend WithEvents LastNameLabel As System.Windows.Forms.Label
    Friend WithEvents BusinessLabel As System.Windows.Forms.Label
    Friend WithEvents AddressLabel As System.Windows.Forms.Label
    Friend WithEvents CityLabel As System.Windows.Forms.Label
    Friend WithEvents StateLabel As System.Windows.Forms.Label
    Friend WithEvents StateComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ZipLabel As System.Windows.Forms.Label
    Friend WithEvents PersonalInfoGrpBx As System.Windows.Forms.GroupBox
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents ReenterPasswordLabel As System.Windows.Forms.Label
    Friend WithEvents LoginInfoGrpBx As System.Windows.Forms.GroupBox
    Friend WithEvents CardNumberLabel As System.Windows.Forms.Label
    Friend WithEvents CVVlabel As System.Windows.Forms.Label
    Friend WithEvents CardTypeLabel As System.Windows.Forms.Label
    Friend WithEvents ExpDateLabel As System.Windows.Forms.Label
    Friend WithEvents NameOnCardLabel As System.Windows.Forms.Label
    Friend WithEvents CardTypeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents PaymentInfoGrpBx As System.Windows.Forms.GroupBox
    Friend WithEvents Address1Label As System.Windows.Forms.Label
    Friend WithEvents Address2Label As System.Windows.Forms.Label
    Friend WithEvents BillingCityLabel As System.Windows.Forms.Label
    Friend WithEvents BillingStateLabel As System.Windows.Forms.Label
    Friend WithEvents BillingZipLabel As System.Windows.Forms.Label
    Friend WithEvents BillingStateComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents BillingAddressGrpBx As System.Windows.Forms.GroupBox
    Friend WithEvents SubmitButton As System.Windows.Forms.Button
    Friend WithEvents FirstNameTxtBx As System.Windows.Forms.MaskedTextBox
    Friend WithEvents AddressTxtBx As System.Windows.Forms.MaskedTextBox
    Friend WithEvents BusinessTxtBx As System.Windows.Forms.MaskedTextBox
    Friend WithEvents LastNameTxtBx As System.Windows.Forms.MaskedTextBox
    Friend WithEvents ZipTxtBx As System.Windows.Forms.MaskedTextBox
    Friend WithEvents CityTxtBx As System.Windows.Forms.MaskedTextBox
    Friend WithEvents ReenterPasswordTxtBx As System.Windows.Forms.MaskedTextBox
    Friend WithEvents PasswordTxtBx As System.Windows.Forms.MaskedTextBox
    Friend WithEvents NameOnCardTxtBx As System.Windows.Forms.MaskedTextBox
    Friend WithEvents ExpDateTxtBx As System.Windows.Forms.MaskedTextBox
    Friend WithEvents CvvTxtBx As System.Windows.Forms.MaskedTextBox
    Friend WithEvents CardNumberTxtBx As System.Windows.Forms.MaskedTextBox
    Friend WithEvents ZipBillingTxtBx As System.Windows.Forms.MaskedTextBox
    Friend WithEvents CityBillingTxtBx As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Address2TxtBx As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Address1TxtBx As System.Windows.Forms.MaskedTextBox
    Friend WithEvents UsernameTxtBx As System.Windows.Forms.TextBox
End Class
