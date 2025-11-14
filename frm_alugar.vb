Imports System.Drawing.Text
Imports System.Net.Mail

Public Class frm_alugar
    Dim num As Integer = 0
    Private Sub frm_alugar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_data.Text = data.ToShortDateString
        lbl_data_devolucao.Text = data.AddDays(14).ToShortDateString
        atualizar_Emprestimo()
    End Sub

    Private Sub btn_aluga_Click(sender As Object, e As EventArgs) Handles btn_aluga.Click
        Try
            contar_livro_membro()
            If num > 2 Then
                MsgBox("Limite de livros alcançado", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
                Exit Sub
            ElseIf Not txt_isbn_aluga.MaskCompleted Or
                    Not txt_cpf_aluga.MaskCompleted Or
                    lbl_status_livro.Text = "" Or
                    lbl_status_membro.Text = "" Then
                MsgBox("Preencha todos os campos", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
                Exit Sub
            ElseIf lbl_status_livro.Text = "INDISPONÍVEL" Then
                MsgBox("Livro indisponível!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
                Exit Sub
            ElseIf lbl_status_membro.Text = "BLOQUEADA" Then
                MsgBox("Membro bloqueado!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
                Exit Sub
            Else
                sql = "select * from tb_emprestimos where isbn='" & txt_isbn_aluga.Text & "'"
                rs = db.Execute(sql)
                If rs.EOF = False Then
                    MsgBox("Empréstimo já existente!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
                    Exit Sub
                Else
                    sql = "insert into tb_emprestimos (isbn,data_emprestimo,data_retorno,cpf) values ('" & txt_isbn_aluga.Text & "', " &
                          "'" & lbl_data.Text & "', '" & lbl_data_devolucao.Text & "', '" & txt_cpf_aluga.Text & "')"
                    rs = db.Execute(UCase(sql))
                    status_atualiza()
                    texto = Label11.Text.Replace("empre1", lbl_titulo.Text)
                    texto = texto.Replace("datadev2", lbl_data_devolucao.Text)
                    texto = texto.Replace("tal", lbl_titulo.Text)
                    aux_cpf = txt_cpf_aluga.Text
                    assunto = "Empréstimo"
                    enviar_email()
                    MsgBox("Empréstimo realizado com sucesso!" & num, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                    atualizar_Emprestimo()
                End If
            End If
            txt_cpf_aluga.Clear()
            txt_isbn_aluga.Clear()
            lbl_membro.Text = ""
            lbl_titulo.Text = ""
            lbl_status_livro.Text = ""
            lbl_status_membro.Text = ""
            img_capa_emprestimos.Load(Application.StartupPath & "\fotos\62861-blue-book-icon.png")
            img_foto_usuario.Load(Application.StartupPath & "\fotos\nova_foto.png")
            txt_cpf_aluga.Focus()
        Catch ex As Exception
            MsgBox("Erro ao gravar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub
    Sub atualizar_Emprestimo()
        Try
            sql = "select * from tb_emprestimos order by cpf asc"
            rs = db.Execute(sql)
            cont = 1
            With dgv_dados_emprestimos
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(cont, rs.Fields(4).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value)
                    rs.MoveNext()
                    cont += 1
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro ao carregar dados", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub
    Sub checagem_membro()
        Try
            sql = "select * from tb_cadastro where cpf='" & txt_cpf_aluga.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                lbl_membro.Text = rs.Fields(2).Value
                lbl_status_membro.Text = rs.Fields(11).Value
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
            sql = "select * from tb_acervo where isbn='" & txt_isbn_aluga.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                lbl_titulo.Text = rs.Fields(1).Value
                lbl_status_livro.Text = rs.Fields(8).Value
                img_capa_emprestimos.Load(rs.Fields(7).Value)
            Else
                MsgBox("ISBN não localizado!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
            End If
        Catch ex As Exception
            MsgBox("Erro ao carregar dados", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub btn_checagem_Click(sender As Object, e As EventArgs) Handles btn_checagem.Click
        checagem_membro()
        checagem_livro()
    End Sub

    Sub status_atualiza()
        Try
            aux_isbn = txt_isbn_aluga.Text
            sql = "update tb_acervo set status='INDISPONÍVEL' where isbn='" & aux_isbn & "'"
            rs = db.Execute(sql)
        Catch ex As Exception
            MsgBox("Erro: " & ex.Message)
        End Try
    End Sub

    Private Sub txt_buscas_emprestimos_TextChanged(sender As Object, e As EventArgs) Handles txt_buscas_emprestimos.TextChanged
        Try
            sql = "select * from tb_emprestimos where " & cmb_tipos_emprestimos.Text & " like '" & txt_buscas_emprestimos.Text & "%'"
            rs = db.Execute(sql)
            cont = 1
            With dgv_dados_emprestimos
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(cont, rs.Fields(4).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value)
                    rs.MoveNext()
                    cont += 1
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro ao carregar dados", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub contar_livro_membro()
        Try
            aux_cpf = txt_cpf_aluga.Text
            sql = "select Count(*) from tb_emprestimos where cpf='" & txt_cpf_aluga.Text & "'"
            rs = db.Execute(sql)
            Do While rs.EOF = False
                rs.MoveNext()
                num += 1
            Loop
        Catch ex As Exception
            MsgBox("Erro: " & ex.Message)
        End Try
    End Sub
End Class