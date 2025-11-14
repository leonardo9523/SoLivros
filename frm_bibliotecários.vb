Public Class frm_bibliotecarios
    Private Sub frm_bibliotecarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregar_users()
    End Sub

    Private Sub chk_vsenha_user_CheckedChanged(sender As Object, e As EventArgs) Handles chk_vsenha_user.CheckedChanged
        Try
            If chk_vsenha_user.Checked Then
                txt_senha_user.PasswordChar = ""
                txt_rsenha_user.PasswordChar = ""
            Else
                txt_senha_user.PasswordChar = "*"
                txt_rsenha_user.PasswordChar = "*"
            End If
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub btn_cadastrar_bibli_Click(sender As Object, e As EventArgs) Handles btn_cadastrar_bibli.Click
        Try
            If txt_nome_user.Text = "" Or
                    txt_email_user.Text = "" Or
                    txt_senha_user.Text = "" Or
                    txt_rsenha_user.Text = "" Then
                MsgBox("Preencha todos os campos", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
                Exit Sub
            ElseIf txt_senha_user.Text <> txt_rsenha_user.Text Then
                MsgBox("Senhas não conferem", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
                Exit Sub
            Else
                sql = "select * from tb_login where usuario='" & txt_nome_user.Text & "' or email='" & txt_email_user.Text & "'"
                rs = db.Execute(sql)
                If rs.EOF = False Then
                    MsgBox("Conta já cadastrada!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
                Else
                    sql = "insert into tb_login (usuario,email,senha,status_conta) values ('" & txt_nome_user.Text & "', " &
                        "'" & txt_email_user.Text & "', '" & txt_senha_user.Text & "','ATIVA')"
                    rs = db.Execute(sql)
                    carregar_users()
                    MsgBox("Conta criada com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                End If
                txt_nome_user.Clear()
                txt_email_user.Clear()
                txt_senha_user.Clear()
                txt_rsenha_user.Clear()
                txt_nome_user.Focus()
            End If
        Catch ex As Exception
            MsgBox("Erro ao gravar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Sub carregar_users()
        Try
            sql = "select * from tb_login order by usuario asc"
            rs = db.Execute(sql)
            cont = 1
            With dgv_dados_users
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(cont, rs.Fields(1).Value, rs.Fields(4).Value, Nothing, Nothing)
                    rs.MoveNext()
                    cont += 1
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro ao carregar dados", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub dgv_dados_users_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dados_users.CellContentClick
        Dim aux_login As String
        Try
            With dgv_dados_users
                If .CurrentRow.Cells(3).Selected = True Then
                    aux_login = .CurrentRow.Cells(1).Value
                    sql = "select * from tb_login where usuario='" & aux_login & "'"
                    rs = db.Execute(sql)
                    If rs.EOF = False Then
                        If rs.Fields(4).Value = "ATIVA" Then
                            resp = MsgBox("Deseja realmente bloquear" + vbNewLine &
                                 "Usuário:  " & aux_login & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                            If resp = MsgBoxResult.Yes Then
                                sql = "update tb_login set status_conta='BLOQUEADA' where usuario='" & aux_login & "'"
                                rs = db.Execute(sql)
                                carregar_users()
                            End If
                        Else
                            resp = MsgBox("Deseja realmente desbloquear" + vbNewLine &
                                 "Usuário:  " & aux_login & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                            If resp = MsgBoxResult.Yes Then
                                sql = "update tb_login set status_conta='ATIVA' where usuario='" & aux_login & "'"
                                rs = db.Execute(sql)
                                carregar_users()
                            End If
                        End If
                    End If
                ElseIf .CurrentRow.Cells(4).Selected = True Then
                    aux_login = .CurrentRow.Cells(1).Value
                    resp = MsgBox("Deseja realmente excluir" + vbNewLine &
                                 "Usuario: " & aux_login & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                    If resp = MsgBoxResult.Yes Then
                        sql = "delete * from tb_login where usuario='" & aux_login & "'"
                        rs = db.Execute(sql)
                        carregar_users()
                    End If
                Else
                    Exit Sub
                End If
            End With
        Catch ex As Exception
            MsgBox("Erro ao carregar dados", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub txt_buscas_users_TextChanged(sender As Object, e As EventArgs) Handles txt_buscas_users.TextChanged
        Try
            sql = "select * from tb_login where usuario like '" & txt_buscas_users.Text & "%'"
            rs = db.Execute(sql)
            cont = 1
            With dgv_dados_users
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(cont, rs.Fields(1).Value, rs.Fields(4).Value, Nothing, Nothing)
                    rs.MoveNext()
                    cont += 1
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro ao carregar dados", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub
End Class