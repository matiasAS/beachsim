Public Class Registration

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PersonalInformationLabel.Click

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReenterPasswordLabel.Click

    End Sub

    Private Sub Label3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CardTypeLabel.Click

    End Sub

    Private Sub ExpDateLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExpDateLabel.Click

    End Sub

    Private Sub StateComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StateComboBox.SelectedIndexChanged
        
    End Sub

    Private Sub BillingStateComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BillingStateComboBox.SelectedIndexChanged
       
    End Sub

    Private Sub CardTypeComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CardTypeComboBox.SelectedIndexChanged

    End Sub

    Private Sub LoginInfoGrpBx_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginInfoGrpBx.Enter

    End Sub

    Private Sub Registration_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        StateComboBox.Items.Clear()
        StateComboBox.Items.Add("AL")
        StateComboBox.Items.Add("AK")
        StateComboBox.Items.Add("AZ")
        StateComboBox.Items.Add("AR")
        StateComboBox.Items.Add("CA")
        StateComboBox.Items.Add("CO")
        StateComboBox.Items.Add("CT")
        StateComboBox.Items.Add("DE")
        StateComboBox.Items.Add("DC")
        StateComboBox.Items.Add("FL")
        StateComboBox.Items.Add("GA")
        StateComboBox.Items.Add("HI")
        StateComboBox.Items.Add("ID")
        StateComboBox.Items.Add("IL")
        StateComboBox.Items.Add("IN")
        StateComboBox.Items.Add("IA")
        StateComboBox.Items.Add("KS")
        StateComboBox.Items.Add("KY")
        StateComboBox.Items.Add("LA")
        StateComboBox.Items.Add("ME")
        StateComboBox.Items.Add("MD")
        StateComboBox.Items.Add("MA")
        StateComboBox.Items.Add("MI")
        StateComboBox.Items.Add("MN")
        StateComboBox.Items.Add("MS")
        StateComboBox.Items.Add("MO")
        StateComboBox.Items.Add("MT")
        StateComboBox.Items.Add("NE")
        StateComboBox.Items.Add("NV")
        StateComboBox.Items.Add("NH")
        StateComboBox.Items.Add("NJ")
        StateComboBox.Items.Add("NM")
        StateComboBox.Items.Add("NY")
        StateComboBox.Items.Add("NC")
        StateComboBox.Items.Add("ND")
        StateComboBox.Items.Add("OH")
        StateComboBox.Items.Add("OK")
        StateComboBox.Items.Add("OR")
        StateComboBox.Items.Add("PA")
        StateComboBox.Items.Add("RI")
        StateComboBox.Items.Add("SC")
        StateComboBox.Items.Add("SD")
        StateComboBox.Items.Add("TN")
        StateComboBox.Items.Add("TX")
        StateComboBox.Items.Add("UT")
        StateComboBox.Items.Add("VT")
        StateComboBox.Items.Add("VA")
        StateComboBox.Items.Add("WA")
        StateComboBox.Items.Add("WV")
        StateComboBox.Items.Add("WI")
        StateComboBox.Items.Add("WY")

        BillingStateComboBox.Items.Clear()
        BillingStateComboBox.Items.Add("AL")
        BillingStateComboBox.Items.Add("AK")
        BillingStateComboBox.Items.Add("AZ")
        BillingStateComboBox.Items.Add("AR")
        BillingStateComboBox.Items.Add("CA")
        BillingStateComboBox.Items.Add("CO")
        BillingStateComboBox.Items.Add("CT")
        BillingStateComboBox.Items.Add("DE")
        BillingStateComboBox.Items.Add("DC")
        BillingStateComboBox.Items.Add("FL")
        BillingStateComboBox.Items.Add("GA")
        BillingStateComboBox.Items.Add("HI")
        BillingStateComboBox.Items.Add("ID")
        BillingStateComboBox.Items.Add("IL")
        BillingStateComboBox.Items.Add("IN")
        BillingStateComboBox.Items.Add("IA")
        BillingStateComboBox.Items.Add("KS")
        BillingStateComboBox.Items.Add("KY")
        BillingStateComboBox.Items.Add("LA")
        BillingStateComboBox.Items.Add("ME")
        BillingStateComboBox.Items.Add("MD")
        BillingStateComboBox.Items.Add("MA")
        BillingStateComboBox.Items.Add("MI")
        BillingStateComboBox.Items.Add("MN")
        BillingStateComboBox.Items.Add("MS")
        BillingStateComboBox.Items.Add("MO")
        BillingStateComboBox.Items.Add("MT")
        BillingStateComboBox.Items.Add("NE")
        BillingStateComboBox.Items.Add("NV")
        BillingStateComboBox.Items.Add("NH")
        BillingStateComboBox.Items.Add("NJ")
        BillingStateComboBox.Items.Add("NM")
        BillingStateComboBox.Items.Add("NY")
        BillingStateComboBox.Items.Add("NC")
        BillingStateComboBox.Items.Add("ND")
        BillingStateComboBox.Items.Add("OH")
        BillingStateComboBox.Items.Add("OK")
        BillingStateComboBox.Items.Add("OR")
        BillingStateComboBox.Items.Add("PA")
        BillingStateComboBox.Items.Add("RI")
        BillingStateComboBox.Items.Add("SC")
        BillingStateComboBox.Items.Add("SD")
        BillingStateComboBox.Items.Add("TN")
        BillingStateComboBox.Items.Add("TX")
        BillingStateComboBox.Items.Add("UT")
        BillingStateComboBox.Items.Add("VT")
        BillingStateComboBox.Items.Add("VA")
        BillingStateComboBox.Items.Add("WA")
        BillingStateComboBox.Items.Add("WV")
        BillingStateComboBox.Items.Add("WI")
        BillingStateComboBox.Items.Add("WY")

        CardTypeComboBox.Items.Clear()
        CardTypeComboBox.Items.Add("Visa")
        CardTypeComboBox.Items.Add("MasterCard")
        CardTypeComboBox.Items.Add("Amex")
    End Sub

    Private Sub SubmitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubmitButton.Click
        If PasswordTxtBx.Text <> ReenterPasswordTxtBx.Text Then
            MsgBox("Passwords do not match")
        Else



            Me.Hide()
        End If
    End Sub

    Private Sub MaskedTextBox1_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles FirstNameTxtBx.MaskInputRejected

    End Sub

    Private Sub LastNameTxtBx_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub MaskedTextBox4_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles AddressTxtBx.MaskInputRejected

    End Sub

    Private Sub PasswordTxtBx_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles PasswordTxtBx.MaskInputRejected

    End Sub
End Class