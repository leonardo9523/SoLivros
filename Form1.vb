Public Class frm_menu

    Private frmAtivo As Form

    Private Sub formshow(frm As Form)
        ActiveFormClose()
        frmAtivo = frm
        frm.TopLevel = False
        Panelform.Controls.Add(frm)
        frm.BringToFront()
        frm.Show()
    End Sub

    Private Sub ActiveFormClose()
        If frmAtivo IsNot Nothing Then
            frmAtivo.Close()
        End If
    End Sub

    Private Sub Activebutton(frmativo As Button)
        For Each ctrl As Control In Panelmenu.Controls
            ctrl.BackColor = Color.Firebrick
        Next
        frmativo.BackColor = Color.Maroon
    End Sub

    Private Sub btn_alugar_Click(sender As Object, e As EventArgs) Handles btn_alugar.Click
        Activebutton(btn_alugar)
        formshow(New frm_alugar())
    End Sub

    Private Sub btn_devolucao_Click(sender As Object, e As EventArgs) Handles btn_devolucao.Click
        Activebutton(btn_devolucao)
        formshow(New frm_devolver())
    End Sub

    Private Sub btn_user_Click(sender As Object, e As EventArgs) Handles btn_user.Click
        Activebutton(btn_user)
        formshow(New frm_usuario())
    End Sub

    Private Sub btn_acervo_Click(sender As Object, e As EventArgs) Handles btn_acervo.Click
        Activebutton(btn_acervo)
        formshow(New frm_acervo())
    End Sub

    Private Sub btn_sair_Click(sender As Object, e As EventArgs) Handles btn_sair.Click
        Application.Exit()
    End Sub

    Private Sub btn_maximizar_Click(sender As Object, e As EventArgs) Handles btn_maximizar.Click
        Try
            If Me.WindowState = FormWindowState.Normal Then
                Me.WindowState = FormWindowState.Maximized
            Else
                Me.WindowState = FormWindowState.Normal
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btn_minimizar_Click(sender As Object, e As EventArgs) Handles btn_minimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btn_bibliotecarios_Click(sender As Object, e As EventArgs) Handles btn_bibliotecarios.Click
        Activebutton(btn_bibliotecarios)
        formshow(New frm_bibliotecarios())
    End Sub

    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        Try
            frm_login.Show()
            Me.Close()
            Exit Sub
        Catch ex As Exception
            MsgBox("Erro :" & ex.Message)
        End Try
    End Sub

    Private Sub btn_livros_Click(sender As Object, e As EventArgs) Handles btn_livros.Click
        Activebutton(btn_livros)
        formshow(New frm_livros())
    End Sub

    Private Sub btn_relatorios_Click(sender As Object, e As EventArgs) Handles btn_relatorios.Click
        Activebutton(btn_relatorios)
        Try
            resp = MsgBox("Deseja realmente abrir os relatórios?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
            If resp = MsgBoxResult.Yes Then
                Process.Start(Application.StartupPath & "\Banco_Dados\cadastro.mdb")
            End If
        Catch ex As Exception
            MsgBox("Erro: " & ex.Message)
        End Try
    End Sub
End Class
