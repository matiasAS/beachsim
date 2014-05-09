Imports System.Data
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient


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

        Dim emptyTextBoxes As String
        emptyTextBoxes = ""

        If FirstNameTxtBx.Text = "" Then
            emptyTextBoxes = String.Concat(emptyTextBoxes, "First Name, " & vbCrLf)
        End If
        If LastNameTxtBx.Text = "" Then
            emptyTextBoxes = String.Concat(emptyTextBoxes, "Last Name, " & vbCrLf)
        End If
        If UsernameTxtBx.Text = "" Then
            emptyTextBoxes = String.Concat(emptyTextBoxes, "Email Address, " & vbCrLf)
        End If
        If PasswordTxtBx.Text = "" Then
            emptyTextBoxes = String.Concat(emptyTextBoxes, "Password, " & vbCrLf)
        End If
        If AddressTxtBx.Text = "" Then
            emptyTextBoxes = String.Concat(emptyTextBoxes, "Address, " & vbCrLf)
        End If
        If CityTxtBx.Text = "" Then
            emptyTextBoxes = String.Concat(emptyTextBoxes, "City, " & vbCrLf)
        End If
        If StateComboBox.Text = "" Then
            emptyTextBoxes = String.Concat(emptyTextBoxes, "State, " & vbCrLf)
        End If
        If ZipTxtBx.Text = "" Then
            emptyTextBoxes = String.Concat(emptyTextBoxes, "Zip, " & vbCrLf)
        End If
        If ReenterPasswordTxtBx.Text = "" Then
            emptyTextBoxes = String.Concat(emptyTextBoxes, "Second Password, " & vbCrLf)
        End If
        If CardNumberTxtBx.Text = "" Then
            emptyTextBoxes = String.Concat(emptyTextBoxes, "Card Number, " & vbCrLf)
        End If
        If CvvTxtBx.Text = "" Then
            emptyTextBoxes = String.Concat(emptyTextBoxes, "CVV, " & vbCrLf)
        End If
        If CardTypeComboBox.Text = "" Then
            emptyTextBoxes = String.Concat(emptyTextBoxes, "Card Type, " & vbCrLf)
        End If
        If ExpDateTxtBx.Text = "" Then
            emptyTextBoxes = String.Concat(emptyTextBoxes, "Expiration Date, " & vbCrLf)
        End If
        If NameOnCardTxtBx.Text = "" Then
            emptyTextBoxes = String.Concat(emptyTextBoxes, "Name on Card, " & vbCrLf)
        End If

        If emptyTextBoxes <> "" Then
            MsgBox("Please in the below field(s): " & emptyTextBoxes)
        ElseIf PasswordTxtBx.Text <> ReenterPasswordTxtBx.Text Then
            MsgBox("Passwords do not match")
        ElseIf ValidateEmail(UsernameTxtBx.Text) = False Then
            MsgBox("Email format is invalid")
        Else
            Dim Connection As MySqlConnection
            Dim Result As Integer
            Connection = New MySqlConnection("Server=144.76.19.105;Database=beachsim;Uid=beachsim;pwd=bAtCFWe5KpZG")
            Try
                Connection.Open()
            Catch ex As MySql.Data.MySqlClient.MySqlException
                MsgBox("Can't connect to database. Your internet may be off")
            End Try

            Dim cmd As New MySqlCommand
            With cmd
                .Connection = Connection
                .CommandText = "INSERT INTO `Accounts` (`NULLCOLUMN`, `Email`, `Password`, `First Name`, `Last Name`, `Business`, `Address`, `City`, `State`, `Zip`, `Card Number`, `CVV`, `Card Type`, `Exp Date`, `Name On Card`, `Billing Address`, `Billing City`, `Billing State`, `Billing Zip` ) " & _
                               "VALUES (NULL, '" & UsernameTxtBx.Text & "', '" & PasswordTxtBx.Text & "', '" & FirstNameTxtBx.Text & "','" & LastNameTxtBx.Text & "','" & BusinessTxtBx.Text & "','" & AddressTxtBx.Text & "','" & CityTxtBx.Text & "','" & StateComboBox.Text & "','" & ZipTxtBx.Text & "','" & CardNumberTxtBx.Text & "','" & CvvTxtBx.Text & "','" & CardNumberTxtBx.Text & "','" & CardTypeComboBox.Text & "','" & ExpDateTxtBx.Text & "','" & NameOnCardTxtBx.Text & "','" & Address1TxtBx.Text & "','" & CityBillingTxtBx.Text & "','" & BillingStateComboBox.Text & ZipBillingTxtBx.Text & "');"
                Result = cmd.ExecuteNonQuery

                If Result = 0 Then
                    MsgBox("Failure")
                Else
                    MsgBox("success")
                End If
            End With

            Connection.Close()
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

    Private Sub UsernameTxtBx_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs)

    End Sub

    Private Sub Address1TxtBx_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles Address1TxtBx.MaskInputRejected

    End Sub

    Private Sub FirstNameLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FirstNameLabel.Click

    End Sub

    Private Sub UsernameLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsernameLabel.Click

    End Sub
    Function ValidateEmail(ByVal email As String) As Boolean
        Dim emailRegex As New System.Text.RegularExpressions.Regex(
            "^(?<user>[^@]+)@(?<host>.+)$")
        Dim emailMatch As System.Text.RegularExpressions.Match =
           emailRegex.Match(email)
        Return emailMatch.Success
    End Function
End Class

