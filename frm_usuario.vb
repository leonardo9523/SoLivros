Public Class frm_usuario
    Private Sub frm_usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregar_usuario()
    End Sub

    Private Sub img_foto_Click(sender As Object, e As EventArgs) Handles img_foto.Click
        Try
            With OpenFileDialog1
                .Title = "Selecione uma foto"
                .InitialDirectory = Application.StartupPath & "\Fotos\"
                .ShowDialog()
                diretorio = .FileName
                img_foto.Load(diretorio)
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub
    Private Sub txt_buscas_TextChanged(sender As Object, e As EventArgs) Handles txt_buscas.TextChanged
        Try
            sql = "select * from tb_cadastro where " & cmb_tipos.Text & " like '" & txt_buscas.Text & "%'"
            rs = db.Execute(sql)
            cont = 1
            With dgv_dados_usuarios
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(cont, rs.Fields(0).Value, rs.Fields(2).Value, Nothing, Nothing)
                    rs.MoveNext()
                    cont += 1
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro ao carregar dados", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub txt_cep_Leave(sender As Object, e As EventArgs) Handles txt_cep.Leave
        Try
            sql = "select * from tb_cep where cep='" & txt_cep.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                txt_endereco.Text = rs.Fields(1).Value
                txt_bairro.Text = rs.Fields(3).Value
                txt_cidade.Text = rs.Fields(2).Value
                txt_uf.Text = rs.Fields(4).Value
            Else
                MsgBox("CEP não localizado!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
            End If
        Catch ex As Exception
            MsgBox("Erro ao carregar dados", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub
    Private Sub dgv_dados_usuarios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dados_usuarios.CellContentClick
        Try
            With dgv_dados_usuarios
                If .CurrentRow.Cells(3).Selected = True Then
                    aux_cpf = .CurrentRow.Cells(1).Value
                    sql = "select * from tb_cadastro where cpf='" & aux_cpf & "'"
                    rs = db.Execute(sql)
                    If rs.EOF = False Then
                        TabControl1.SelectTab(0)
                        txt_cpf.Text = rs.Fields(0).Value
                        txt_data.Value = rs.Fields(1).Value
                        txt_nome.Text = rs.Fields(2).Value
                        txt_cep.Text = rs.Fields(3).Value
                        txt_endereco.Text = rs.Fields(4).Value
                        txt_bairro.Text = rs.Fields(5).Value
                        txt_cidade.Text = rs.Fields(6).Value
                        txt_uf.Text = rs.Fields(7).Value
                        txt_telefone.Text = rs.Fields(8).Value
                        txt_email.Text = rs.Fields(9).Value
                        img_foto.Load(rs.Fields(10).Value)
                    End If
                ElseIf .CurrentRow.Cells(4).Selected = True Then
                    aux_cpf = .CurrentRow.Cells(1).Value
                    sql = "select * from tb_cadastro where cpf='" & aux_cpf & "'"
                    rs = db.Execute(sql)
                    If rs.EOF = False Then
                        If rs.Fields(11).Value = "ATIVA" Then
                            resp = MsgBox("Deseja realmente bloquear" + vbNewLine &
                                 "CPF:  " & aux_cpf & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                            If resp = MsgBoxResult.Yes Then
                                sql = "update tb_cadastro set status_conta='BLOQUEADA' where cpf='" & aux_cpf & "'"
                                rs = db.Execute(sql)
                                carregar_usuario()
                            End If
                        Else
                            resp = MsgBox("Deseja realmente desbloquear" + vbNewLine &
                                 "CPF:  " & aux_cpf & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                            If resp = MsgBoxResult.Yes Then
                                sql = "update tb_cadastro set status_conta='ATIVA' where cpf='" & aux_cpf & "'"
                                rs = db.Execute(sql)
                                carregar_usuario()
                            End If
                        End If
                    End If
                ElseIf .CurrentRow.Cells(5).Selected = True Then
                    aux_cpf = .CurrentRow.Cells(1).Value
                    resp = MsgBox("Deseja realmente excluir" + vbNewLine &
                                 "CPF: " & aux_cpf & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                    If resp = MsgBoxResult.Yes Then
                        sql = "delete * from tb_cadastro where cpf='" & aux_cpf & "'"
                        rs = db.Execute(sql)
                        carregar_usuario()
                    End If
                Else
                    Exit Sub
                End If
            End With
        Catch ex As Exception
            MsgBox("Erro ao carregar dados", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub carregar_usuario()
        Try
            sql = "select * from tb_cadastro order by nome asc"
            rs = db.Execute(sql)
            cont = 1
            With dgv_dados_usuarios
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(cont, rs.Fields(0).Value, rs.Fields(2).Value, Nothing, Nothing)
                    rs.MoveNext()
                    cont += 1
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro ao carregar dados", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub btn_gravar_Click(sender As Object, e As EventArgs) Handles btn_gravar.Click
        Try
            If Not txt_cpf.MaskCompleted Or
                    txt_data.Value = Now Or
                    txt_nome.Text = "" Or
                    Not txt_cep.MaskCompleted Or
                    txt_endereco.Text = "" Or
                    txt_bairro.Text = "" Or
                    txt_cidade.Text = "" Or
                    txt_uf.Text = "" Or
                    Not txt_telefone.MaskCompleted Or
                    txt_email.Text = "" Then
                MsgBox("Preencha todos os campos", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
                Exit Sub
            Else
                status = "ativa"
                sql = "select * from tb_cadastro where cpf='" & txt_cpf.Text & "'"
                rs = db.Execute(sql)
                If rs.EOF = False Then
                    sql = "update tb_cadastro set data_nasc='" & txt_data.Value & "', " &
                              "nome='" & txt_nome.Text & "', cep='" & txt_cep.Text & "', " &
                              "endereco='" & txt_endereco.Text & "', bairro='" & txt_bairro.Text & "', " &
                              "cidade='" & txt_cidade.Text & "', uf='" & txt_uf.Text & "', fone='" & txt_telefone.Text & "', " &
                              "email='" & txt_email.Text & "', foto='" & diretorio & "', " &
                              "status_conta='" & status & "' where cpf='" & txt_cpf.Text & "'"
                    rs = db.Execute(UCase(sql))
                    MsgBox("Dados alterados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                Else
                    sql = "insert into tb_cadastro values ('" & txt_cpf.Text & "', " &
                           "'" & txt_data.Value & "', '" & txt_nome.Text & "', " &
                           "'" & txt_cep.Text & "', '" & txt_endereco.Text & "', " &
                           "'" & txt_bairro.Text & "', '" & txt_cidade.Text & "', " &
                           "'" & txt_uf.Text & "', '" & txt_telefone.Text & "', " &
                           "'" & txt_email.Text & "', '" & diretorio & "', '" & status & "')"
                    rs = db.Execute(UCase(sql))
                    MsgBox("Dados gravados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                End If
            End If
            carregar_usuario()
            txt_cpf.Clear()
            txt_data.Value = Now
            txt_nome.Clear()
            txt_cep.Clear()
            txt_endereco.Clear()
            txt_bairro.Clear()
            txt_cidade.Clear()
            txt_uf.Clear()
            txt_telefone.Clear()
            txt_email.Clear()
            txt_cpf.Focus()
            img_foto.Load(Application.StartupPath & "\fotos\nova_foto.png")
        Catch ex As Exception
            MsgBox("Erro ao gravar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub
End Class