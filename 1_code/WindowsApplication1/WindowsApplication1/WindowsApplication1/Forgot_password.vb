Imports System.Windows.Forms
Imports System.Data
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports System.Net.Mail


Public Class Forgot_password

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Dim Connection As MySqlConnection
        Dim Result As MySqlDataReader
        Dim resultpass As String
        Connection = New MySqlConnection("Server=144.76.19.105;Database=beachsim;Uid=beachsim;pwd=bAtCFWe5KpZG")
        Try
            Connection.Open()
        Catch ex As MySql.Data.MySqlClient.MySqlException
            MsgBox("Can't connect to database. Your internet may be off")
        End Try

        Dim cmd As New MySqlCommand
        With cmd
            .Connection = Connection
            .CommandText = "SELECT Password FROM Accounts WHERE Email = '" & EmailTxtBx.Text & "'"
            Result = cmd.ExecuteReader

            If Result.Read Then
                resultpass = Result.GetString(0)
            Else
                MsgBox("Error. Did not find Email")
                Exit Sub
            End If

        End With


        Dim email As New Mail
        email.receiver = EmailTxtBx.Text
        email.subject = "password"
        email.body = "Here is your password: " & resultpass
        email.send()

        Connection.Close()
        Result.Close()


        MsgBox("Your E-mail has been sent" + vbCrLf + vbCrLf + "This e-mail contains your " & _
               "password. If you do not recieve the e-mail please check your spam folder" & _
               " or try again.", , "E-mail Sent!")
        Me.Close()
    End Sub

    Private Sub EmailTxtBx_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmailTxtBx.TextChanged

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Forgot_password_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class


Public NotInheritable Class Mail
    Public Property subject As String
    Public Property body As String
    Public Property receiver As String

    Public Sub send()
        Try
            Dim smtpServer As New SmtpClient()
            Dim mail As New MailMessage()
            smtpServer.UseDefaultCredentials = False
            smtpServer.Credentials = New Net.NetworkCredential("beachsim123@gmail.com", "bAtCFWe5KpZG&")
            smtpServer.Port = 587
            smtpServer.EnableSsl = True
            smtpServer.Host = "smtp.gmail.com"

            mail = New MailMessage()
            mail.From = New MailAddress("beachsim123@gmail.com")
            mail.To.Add(receiver)
            mail.Subject = subject
            mail.Body = body
            smtpServer.Send(mail)
        Catch ex As Exception
            MsgBox(ex.Message & vbNewLine & ex.StackTrace)
        End Try
    End Sub
End Class