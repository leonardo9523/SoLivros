Public Class frm_livros
    Private Sub frm_livros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregar_livros()
    End Sub

    Sub carregar_livros()
        Try
            sql = "select * from tb_acervo order by titulo asc"
            rs = db.Execute(UCase(sql))
            cont = 1
            With dgv_dados_livros
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(cont, rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(6).Value, rs.Fields(2).Value, Nothing)
                    rs.MoveNext()
                    cont += 1
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro: " & ex.Message)
        End Try
    End Sub

    Private Sub dgv_dados_livros_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dados_livros.CellContentClick
        Try
            With dgv_dados_livros
                If .CurrentRow.Cells(5).Selected = True Then
                    aux_isbn = .CurrentRow.Cells(1).Value
                    sql = "select * from tb_acervo where isbn='" & aux_isbn & "'"
                    rs = db.Execute(sql)
                    If rs.EOF = False Then
                        lbl_titulo_livros.Text = rs.Fields(1).Value
                        lbl_autor.Text = rs.Fields(2).Value
                        lbl_ano.Text = rs.Fields(3).Value
                        lbl_editora.Text = rs.Fields(4).Value
                        lbl_num.Text = rs.Fields(5).Value
                        lbl_genero.Text = rs.Fields(6).Value
                        img_capa_livros.Load(rs.Fields(7).Value)
                        lbl_status.Text = rs.Fields(8).Value
                        If lbl_status.Text = "DISPONÍVEL" Then
                            lbl_status.ForeColor = System.Drawing.Color.Blue
                        Else
                            lbl_status.ForeColor = System.Drawing.Color.Red
                        End If
                        Exit Sub
                    End If
                End If
            End With
        Catch ex As Exception
            MsgBox("Erro: " & ex.Message)
        End Try
    End Sub

    Private Sub txt_buscas_livros_TextChanged(sender As Object, e As EventArgs) Handles txt_buscas_livros.TextChanged
        Try
            sql = "select * from tb_acervo where " & cmb_tipos_livros.Text & " like '" & txt_buscas_livros.Text & "%'"
            rs = db.Execute(sql)
            cont = 1
            With dgv_dados_livros
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(cont, rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(6).Value, rs.Fields(2).Value, Nothing)
                    rs.MoveNext()
                    cont += 1
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro: " & ex.Message)
            'MsgBox("Erro ao carregar dados", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub
End Class