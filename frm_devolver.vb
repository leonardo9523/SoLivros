Imports System.Runtime.InteropServices.ComTypes

Public Class frm_devolver
    Private Sub frm_devolver_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        atualizar_devolve()
    End Sub

    Private Sub btn_checagem_Click(sender As Object, e As EventArgs) Handles btn_checagem.Click
        Try
            sql = "select * from tb_emprestimos where isbn='" & txt_isbn_devolve.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                lbl_cpf_devolver.Text = rs.Fields(4).Value
                lbl_data_devolve.Text = rs.Fields(3).Value
                checagem_membro()
                checagem_livro()
            Else
                MsgBox("Livro não foi emprestado!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
            End If
        Catch ex As Exception
            MsgBox("Erro ao carregar dados", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub
    Sub checagem_membro()
        Try
            sql = "select * from tb_cadastro where cpf='" & lbl_cpf_devolver.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                lbl_membro_devolver.Text = rs.Fields(2).Value
                img_foto_usuario.Load(rs.Fields(10).Value)
            Else
                MsgBox("CPF não localizado!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
            End If
        Catch ex As Exception
            MsgBox("Erro ao carregar dados", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub checagem_livro()
        Try
            sql = "select * from tb_acervo where isbn='" & txt_isbn_devolve.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                lbl_titulo_devolver.Text = rs.Fields(1).Value
                img_capa_emprestimos.Load(rs.Fields(7).Value)
            Else
                MsgBox("ISBN não localizado!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
            End If
        Catch ex As Exception
            MsgBox("Erro ao carregar dados", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub btn_calc_Click(sender As Object, e As EventArgs) Handles btn_calc.Click
        Try
            Dim datap, datad As Date
            Dim dias As TimeSpan
            Dim diasz As Integer
            datap = lbl_data_devolve.Text
            datad = txt_devolucao_data.Value
            dias = datad.Subtract(datap)
            diasz = dias.Days
            If diasz > 0 Then
                lbl_taxa.Text = "R$" & diasz & ",00"
            Else
                lbl_taxa.Text = "R$0,00"
            End If
        Catch ex As Exception
            MsgBox("Erro: " & ex.Message)
        End Try
    End Sub

    Private Sub btn_devolve_Click(sender As Object, e As EventArgs) Handles btn_devolve.Click
        Try
            If txt_devolucao_data.Text = "" Or
                    Not txt_isbn_devolve.MaskCompleted Or
                    lbl_data_devolve.Text = "" Or
                    lbl_cpf_devolver.Text = "" Or
                    lbl_membro_devolver.Text = "" Or
                    lbl_titulo_devolver.Text = "" Or
                    lbl_taxa.Text = "R$" Then
                MsgBox("Preencha todos os campos", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
                Exit Sub
            Else
                sql = "insert into tb_devolver (isbn,data_original,data_retorno,cpf,taxa) values ('" & txt_isbn_devolve.Text & "', " &
                  "'" & lbl_data_devolve.Text & "', '" & txt_devolucao_data.Value & "', " &
                  "'" & lbl_cpf_devolver.Text & "', '" & lbl_taxa.Text & "')"
                rs = db.Execute(UCase(sql))
                deletar_emprestimo()
                atualizar_acervo()
                texto = Label11.Text.Replace("empre1", lbl_taxa.Text)
                texto = texto.Replace("datadev2", txt_devolucao_data.Value)
                texto = texto.Replace("tal", lbl_titulo_devolver.Text)
                aux_cpf = lbl_cpf_devolver.Text
                assunto = "Devolução"
                enviar_email()
                MsgBox("Devolução realizada com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                atualizar_devolve()
                lbl_cpf_devolver.Text = ""
                txt_isbn_devolve.Clear()
                txt_devolucao_data.Value = Now
                lbl_data_devolve.Text = ""
                lbl_taxa.Text = "R$"
                lbl_titulo_devolver.Text = ""
                lbl_membro_devolver.Text = ""
                img_capa_emprestimos.Load(Application.StartupPath & "\fotos\62861-blue-book-icon.png")
                img_foto_usuario.Load(Application.StartupPath & "\fotos\nova_foto.png")
                txt_isbn_devolve.Focus()
            End If
        Catch ex As Exception
            MsgBox("Erro: " & ex.Message)
        End Try
    End Sub

    Sub deletar_emprestimo()
        Try
            aux_isbn = txt_isbn_devolve.Text
            sql = "delete * from tb_emprestimos where isbn='" & aux_isbn & "'"
            rs = db.Execute(sql)
        Catch ex As Exception
            MsgBox("Erro: " & ex.Message)
        End Try
    End Sub

    Sub atualizar_acervo()
        Try
            sql = "update tb_acervo set status='DISPONÍVEL' where isbn='" & aux_isbn & "'"
            rs = db.Execute(sql)
        Catch ex As Exception
            MsgBox("Erro: " & ex.Message)
        End Try
    End Sub

    Sub atualizar_devolve()
        Try
            sql = "select * from tb_devolver order by isbn asc"
            rs = db.Execute(sql)
            cont = 1
            With dgv_dados_devolve
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(cont, rs.Fields(4).Value, rs.Fields(1).Value, rs.Fields(3).Value, rs.Fields(5).Value, Nothing)
                    rs.MoveNext()
                    cont += 1
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro ao carregar dados", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub txt_buscas_devolve_TextChanged(sender As Object, e As EventArgs) Handles txt_buscas_devolve.TextChanged
        Try
            sql = "select * from tb_devolver where " & cmb_tipos_devolve.Text & " like '" & txt_buscas_devolve.Text & "%'"
            rs = db.Execute(sql)
            cont = 1
            With dgv_dados_devolve
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(cont, rs.Fields(4).Value, rs.Fields(1).Value, rs.Fields(3).Value, rs.Fields(5).Value, Nothing)
                    rs.MoveNext()
                    cont += 1
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro ao carregar dados", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub
End Class