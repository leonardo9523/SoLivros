Public Class frm_acervo
    Private Sub img_capa_Click(sender As Object, e As EventArgs) Handles img_capa.Click
        Try
            With OpenFileDialog1
                .Title = "Selecione uma capa"
                .InitialDirectory = Application.StartupPath & "\Capas\"
                .ShowDialog()
                diretorio = .FileName
                img_capa.Load(diretorio)
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub
    Private Sub btn_gravar_livro_Click(sender As Object, e As EventArgs) Handles btn_gravar_livro.Click
        Try
            If txt_titulo.Text = "" Or
                    txt_ano.Text = "" Or
                    txt_autor.Text = "" Or
                    txt_editora.Text = "" Or
                    txt_genero.Text = "" Or
                    Not txt_isbn.MaskCompleted Or
                    txt_pag.Text = "" Then
                MsgBox("Preencha todos os campos", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
                Exit Sub
            Else
                status = "disponível"
                sql = "select * from tb_acervo where isbn='" & txt_isbn.Text & "'"
                rs = db.Execute(sql)
                If rs.EOF = False Then
                    sql = "update tb_acervo set titulo='" & txt_titulo.Text & "', " &
                      "autor='" & txt_autor.Text & "', ano=" & txt_ano.Text & ", " &
                      "editora='" & txt_editora.Text & "', numero_pag=" & txt_pag.Text & ", " &
                      "genero='" & txt_genero.Text & "', capa='" & diretorio & "', " &
                      "status='" & status & "' where isbn='" & txt_isbn.Text & "'"
                    rs = db.Execute(UCase(sql))
                    atualizar_acervo()
                    MsgBox("Dados alterados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                Else
                    sql = "insert into tb_acervo values ('" & txt_isbn.Text & "', " &
                      "'" & txt_titulo.Text & "', '" & txt_autor.Text & "', " &
                      "" & txt_ano.Text & ", '" & txt_editora.Text & "', " &
                      "" & txt_pag.Text & ", '" & txt_genero.Text & "', '" & diretorio & "', '" & status & "')"
                    rs = db.Execute(UCase(sql))
                    atualizar_acervo()
                    MsgBox("Dados gravados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                End If
            End If
            txt_isbn.Clear()
            txt_titulo.Clear()
            txt_ano.Clear()
            txt_autor.Clear()
            txt_editora.Clear()
            txt_pag.Clear()
            txt_genero.Clear()
            txt_isbn.Focus()
            img_capa.Load(Application.StartupPath & "\fotos\62861-blue-book-icon.png")
        Catch ex As Exception
            MsgBox("Erro ao gravar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub
    Private Sub txt_buscas_acervo_TextChanged(sender As Object, e As EventArgs) Handles txt_buscas_acervo.TextChanged
        Try
            sql = "select * from tb_acervo where " & cmb_tipo_acervo.Text & " like '" & txt_buscas_acervo.Text & "%'"
            rs = db.Execute(sql)
            cont = 1
            With dgv_dados_acervo
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(cont, rs.Fields(0).Value, rs.Fields(1).Value, Nothing, Nothing)
                    rs.MoveNext()
                    cont += 1
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro ao carregar dados", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub dgv_dados_acervo_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dados_acervo.CellContentClick
        Try
            With dgv_dados_acervo
                If .CurrentRow.Cells(3).Selected = True Then
                    aux_isbn = .CurrentRow.Cells(1).Value
                    sql = "select * from tb_acervo where isbn='" & aux_isbn & "'"
                    rs = db.Execute(sql)
                    If rs.EOF = False Then
                        tbc_acervo.SelectTab(0)
                        txt_isbn.Text = rs.Fields(0).Value
                        txt_titulo.Text = rs.Fields(1).Value
                        txt_autor.Text = rs.Fields(2).Value
                        txt_ano.Text = rs.Fields(3).Value
                        txt_editora.Text = rs.Fields(4).Value
                        txt_pag.Text = rs.Fields(5).Value
                        txt_genero.Text = rs.Fields(6).Value
                        img_capa.Load(rs.Fields(7).Value)
                    End If
                ElseIf .CurrentRow.Cells(4).Selected = True Then
                    aux_isbn = .CurrentRow.Cells(1).Value
                    resp = MsgBox("Deseja realmente excluir" + vbNewLine &
                                 "ISBN: " & aux_isbn & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                    If resp = MsgBoxResult.Yes Then
                        sql = "delete * from tb_acervo where isbn='" & aux_isbn & "'"
                        rs = db.Execute(sql)
                        atualizar_acervo()
                    End If
                Else
                    Exit Sub
                End If
            End With
        Catch ex As Exception
            MsgBox("Erro ao carregar dados", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub atualizar_acervo()
        Try
            sql = "select * from tb_acervo order by titulo asc"
            rs = db.Execute(sql)
            cont = 1
            With dgv_dados_acervo
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(cont, rs.Fields(0).Value, rs.Fields(1).Value, Nothing, Nothing)
                    rs.MoveNext()
                    cont += 1
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro ao carregar dados", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub frm_acervo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        atualizar_acervo()
    End Sub
End Class