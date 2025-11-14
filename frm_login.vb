Imports System.Windows

Public Class frm_login
    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco()
    End Sub

    Private Sub btn_sair_Click(sender As Object, e As EventArgs) Handles btn_sair.Click
        Application.Exit()
    End Sub

    Private Sub btn_minimizar_Click(sender As Object, e As EventArgs) Handles btn_minimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub chk_vsenha_CheckedChanged(sender As Object, e As EventArgs) Handles chk_vsenha.CheckedChanged
        Try
            If chk_vsenha.Checked Then
                txt_senha.PasswordChar = ""
            Else
                txt_senha.PasswordChar = "*"
            End If
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub btn_entrar_Click(sender As Object, e As EventArgs) Handles btn_entrar.Click
        Try
            If txt_usuario.Text = "admin" And txt_senha.Text = "admin" Then
                txt_usuario.Clear()
                txt_senha.Clear()
                With frm_menu
                    .Show()
                    .btn_alugar.Visible = True
                    .btn_alugar.Enabled = True
                    .btn_devolucao.Visible = True
                    .btn_devolucao.Enabled = True
                    .btn_user.Visible = True
                    .btn_user.Enabled = True
                    .btn_relatorios.Visible = True
                    .btn_relatorios.Enabled = True
                    .btn_acervo.Visible = True
                    .btn_acervo.Enabled = True
                    .btn_bibliotecarios.Visible = True
                    .btn_bibliotecarios.Enabled = True
                End With
                Exit Sub
            End If
            sql = "select * from tb_login where (usuario='" & txt_usuario.Text & "' or email='" & txt_usuario.Text & "') and senha='" & txt_senha.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                If rs.Fields(4).Value = "ATIVA" Then
                    txt_usuario.Clear()
                    txt_senha.Clear()
                    MsgBox("Conta logada com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                    With frm_menu
                        .Show()
                        .btn_alugar.Visible = True
                        .btn_alugar.Enabled = True
                        .btn_devolucao.Visible = True
                        .btn_devolucao.Enabled = True
                        .btn_user.Visible = True
                        .btn_user.Enabled = True
                        .btn_relatorios.Visible = True
                        .btn_relatorios.Enabled = True
                    End With
                Else
                    MsgBox("Conta bloqueada!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                    txt_usuario.Clear()
                    txt_senha.Clear()
                    txt_usuario.Focus()
                End If
            Else
                MsgBox("Conta Inválida!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                txt_usuario.Clear()
                txt_senha.Clear()
                txt_usuario.Focus()
            End If
        Catch ex As Exception
            MsgBox("Erro: " & ex.Message)
        End Try
    End Sub

    Private Sub lbl_sem_login_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl_sem_login.LinkClicked
        Try
            frm_menu.Show()
        Catch ex As Exception
            MsgBox("Erro: " & ex.Message)
        End Try
    End Sub

    Private Sub lbl_esqueceu_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl_esqueceu.LinkClicked
        Try
            frm_alterar.ShowDialog()
        Catch ex As Exception
            MsgBox("Erro: " & ex.Message)
        End Try
    End Sub
End Class