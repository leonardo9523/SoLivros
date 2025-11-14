Public Class frm_alterar
    Private Sub btn_sair_alterar_Click(sender As Object, e As EventArgs) Handles btn_sair_alterar.Click
        Application.Exit()
    End Sub

    Private Sub chk_vsenha_alterar_CheckedChanged(sender As Object, e As EventArgs) Handles chk_vsenha_alterar.CheckedChanged
        Try
            If chk_vsenha_alterar.Checked Then
                txt_senha_alterar.PasswordChar = ""
                txt_rsenha_alterar.PasswordChar = ""
            Else
                txt_senha_alterar.PasswordChar = "*"
                txt_rsenha_alterar.PasswordChar = "*"
            End If
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub btn_redefinir_Click(sender As Object, e As EventArgs) Handles btn_redefinir.Click
        Try
            If txt_usuario_alterar.Text = "" Or
                    txt_senha_alterar.Text = "" Or
                    txt_rsenha_alterar.Text = "" Then
            ElseIf txt_senha_alterar.Text <> txt_rsenha_alterar.Text Then
                MsgBox("Senhas não conferem", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
                Exit Sub
            Else
                sql = "select * from tb_login where (usuario='" & txt_usuario_alterar.Text & "' or email='" & txt_usuario_alterar.Text & "')"
                rs = db.Execute(sql)
                If rs.EOF = False Then
                    sql = "update tb_login set senha='" & txt_senha_alterar.Text & "' where (usuario='" & txt_usuario_alterar.Text & "' or email='" & txt_usuario_alterar.Text & "')"
                    rs = db.Execute(LCase(sql))
                    MsgBox("Dados alterados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                    frm_login.Show()
                    Me.Close()
                    Exit Sub
                Else
                    MsgBox("Usuário ou email inexistente!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            MsgBox("Erro: " & ex.Message)
        End Try
    End Sub
End Class