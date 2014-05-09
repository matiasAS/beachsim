Imports System.Data
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient



Public Class Login

    Private Sub CreateAccountLink_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles CreateAccountLink.LinkClicked
        Registration.Show()
    End Sub

    Private Sub SignInBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SignInBtn.Click
        Dim Connection As MySqlConnection
        Dim Result As MySqlDataReader
        Dim resultpass As String
        Connection = New MySqlConnection("Server=144.76.19.105;Database=beachsim;Uid=beachsim;pwd=bAtCFWe5KpZG")
        Try
            Connection.Open()
        Catch ex As MySql.Data.MySqlClient.MySqlException
            MsgBox("Can't connect to database. Your internet may be off")
            Exit Sub
        End Try

    Dim cmd As New MySqlCommand
        With cmd
            .Connection = Connection
            .CommandText = "SELECT Password FROM Accounts WHERE Email = '" & UsernameTxtBx.Text & "'"
            Result = cmd.ExecuteReader

            If Result.Read Then
                resultpass = Result.GetString(0)
            End If

        End With
        If UsernameTxtBx.Text = "" Then
            MsgBox("Please enter an username")
            Exit Sub
        End If

        If PasswordTxtBx.Text = "" Then
            MsgBox("Please enter a password")
            Exit Sub
        End If


        If resultpass = PasswordTxtBx.Text Then
            Simulation.Show()
            Connection.Close()
            Result.Close()
            Me.Hide()
        Else
            MsgBox("invalid Email or password")
            Connection.Close()
            Result.Close()
            Exit Sub
        End If

        Connection.Close()
        Result.Close()
    End Sub

    Public Sub UsernameTxtBx_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs)

    End Sub

    Private Sub ForgotPasswordLink_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles ForgotPasswordLink.LinkClicked
        Forgot_password.Show()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsernameTxtBx.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasswordTxtBx.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OfflineButton.Click
        Simulation.Show()
        UsernameTxtBx.Text = "Offline"
        Me.Hide()
    End Sub
End Class