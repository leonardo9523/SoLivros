Imports System.Net.Mail

Module Module1
    Public diretorio, sql, aux_cpf, resp, aux_isbn, status As String
    Public texto, assunto As String
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public dirbanco = Application.StartupPath & "\Banco_Dados\cadastro.mdb"
    Public cont As Integer
    Public data As Date = Now

    Sub conecta_banco()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=Microsoft.JET.OLEDB.4.0;Data Source=" & dirbanco)
            MsgBox("Conexão OK", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        Catch ex As Exception
            MsgBox("Erro ao Conectar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Sub enviar_email()
        Try
            Dim destinatario As String
            sql = "select * from tb_cadastro where cpf='" & aux_cpf & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                destinatario = rs.Fields(9).Value
            End If
            Using smtp As New SmtpClient
                Using email As New MailMessage()

                    'Servidor SMTP
                    smtp.Host = "smtp.gmail.com"
                    smtp.UseDefaultCredentials = False
                    smtp.Credentials = New Net.NetworkCredential("...", "...")
                    smtp.Port = 587
                    smtp.EnableSsl = True

                    'Email(mensagem)
                    email.From = New MailAddress("...")
                    email.To.Add(destinatario)
                    email.Subject = assunto
                    email.IsBodyHtml = True
                    email.Body = (texto) 'mudar a parte debaixo
                    'email.Attachments.Add(New Attachment(capa))

                    'Enviar email
                    smtp.Send(email)
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Erro: " & ex.Message)
        End Try
    End Sub
End Module
