<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_menu
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_menu))
        Me.Panelform = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panelmenu = New System.Windows.Forms.Panel()
        Me.btn_relatorios = New System.Windows.Forms.Button()
        Me.btn_livros = New System.Windows.Forms.Button()
        Me.btn_bibliotecarios = New System.Windows.Forms.Button()
        Me.btn_acervo = New System.Windows.Forms.Button()
        Me.btn_user = New System.Windows.Forms.Button()
        Me.btn_devolucao = New System.Windows.Forms.Button()
        Me.btn_alugar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_voltar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_minimizar = New System.Windows.Forms.Button()
        Me.btn_maximizar = New System.Windows.Forms.Button()
        Me.btn_sair = New System.Windows.Forms.Button()
        Me.Panelform.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panelmenu.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panelform
        '
        Me.Panelform.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panelform.AutoSize = True
        Me.Panelform.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panelform.Controls.Add(Me.PictureBox3)
        Me.Panelform.Location = New System.Drawing.Point(213, 32)
        Me.Panelform.Name = "Panelform"
        Me.Panelform.Size = New System.Drawing.Size(719, 446)
        Me.Panelform.TabIndex = 0
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(48, 88)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(624, 268)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = False
        '
        'Panelmenu
        '
        Me.Panelmenu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panelmenu.BackColor = System.Drawing.Color.Firebrick
        Me.Panelmenu.Controls.Add(Me.btn_relatorios)
        Me.Panelmenu.Controls.Add(Me.btn_livros)
        Me.Panelmenu.Controls.Add(Me.btn_bibliotecarios)
        Me.Panelmenu.Controls.Add(Me.btn_acervo)
        Me.Panelmenu.Controls.Add(Me.btn_user)
        Me.Panelmenu.Controls.Add(Me.btn_devolucao)
        Me.Panelmenu.Controls.Add(Me.btn_alugar)
        Me.Panelmenu.Controls.Add(Me.Panel1)
        Me.Panelmenu.Controls.Add(Me.PictureBox1)
        Me.Panelmenu.Location = New System.Drawing.Point(0, 0)
        Me.Panelmenu.Name = "Panelmenu"
        Me.Panelmenu.Size = New System.Drawing.Size(213, 478)
        Me.Panelmenu.TabIndex = 1
        '
        'btn_relatorios
        '
        Me.btn_relatorios.Enabled = False
        Me.btn_relatorios.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick
        Me.btn_relatorios.FlatAppearance.BorderSize = 0
        Me.btn_relatorios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_relatorios.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_relatorios.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btn_relatorios.Location = New System.Drawing.Point(0, 249)
        Me.btn_relatorios.Name = "btn_relatorios"
        Me.btn_relatorios.Size = New System.Drawing.Size(214, 42)
        Me.btn_relatorios.TabIndex = 9
        Me.btn_relatorios.Text = "Relatórios"
        Me.btn_relatorios.UseVisualStyleBackColor = False
        Me.btn_relatorios.Visible = False
        '
        'btn_livros
        '
        Me.btn_livros.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick
        Me.btn_livros.FlatAppearance.BorderSize = 0
        Me.btn_livros.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_livros.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_livros.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btn_livros.Location = New System.Drawing.Point(0, 81)
        Me.btn_livros.Name = "btn_livros"
        Me.btn_livros.Size = New System.Drawing.Size(214, 42)
        Me.btn_livros.TabIndex = 8
        Me.btn_livros.Text = "Acervo"
        Me.btn_livros.UseVisualStyleBackColor = False
        '
        'btn_bibliotecarios
        '
        Me.btn_bibliotecarios.Enabled = False
        Me.btn_bibliotecarios.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick
        Me.btn_bibliotecarios.FlatAppearance.BorderSize = 0
        Me.btn_bibliotecarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_bibliotecarios.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_bibliotecarios.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btn_bibliotecarios.Location = New System.Drawing.Point(0, 333)
        Me.btn_bibliotecarios.Name = "btn_bibliotecarios"
        Me.btn_bibliotecarios.Size = New System.Drawing.Size(214, 50)
        Me.btn_bibliotecarios.TabIndex = 7
        Me.btn_bibliotecarios.Text = "Controle de bibliotecários"
        Me.btn_bibliotecarios.UseVisualStyleBackColor = False
        Me.btn_bibliotecarios.Visible = False
        '
        'btn_acervo
        '
        Me.btn_acervo.Enabled = False
        Me.btn_acervo.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick
        Me.btn_acervo.FlatAppearance.BorderSize = 0
        Me.btn_acervo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_acervo.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_acervo.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btn_acervo.Location = New System.Drawing.Point(0, 291)
        Me.btn_acervo.Name = "btn_acervo"
        Me.btn_acervo.Size = New System.Drawing.Size(214, 42)
        Me.btn_acervo.TabIndex = 6
        Me.btn_acervo.Text = "Controle de acervo"
        Me.btn_acervo.UseVisualStyleBackColor = False
        Me.btn_acervo.Visible = False
        '
        'btn_user
        '
        Me.btn_user.Enabled = False
        Me.btn_user.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick
        Me.btn_user.FlatAppearance.BorderSize = 0
        Me.btn_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_user.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_user.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btn_user.Location = New System.Drawing.Point(0, 207)
        Me.btn_user.Name = "btn_user"
        Me.btn_user.Size = New System.Drawing.Size(214, 42)
        Me.btn_user.TabIndex = 5
        Me.btn_user.Text = "Controle de membros"
        Me.btn_user.UseVisualStyleBackColor = False
        Me.btn_user.Visible = False
        '
        'btn_devolucao
        '
        Me.btn_devolucao.Enabled = False
        Me.btn_devolucao.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick
        Me.btn_devolucao.FlatAppearance.BorderSize = 0
        Me.btn_devolucao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_devolucao.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_devolucao.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btn_devolucao.Location = New System.Drawing.Point(0, 165)
        Me.btn_devolucao.Name = "btn_devolucao"
        Me.btn_devolucao.Size = New System.Drawing.Size(214, 42)
        Me.btn_devolucao.TabIndex = 4
        Me.btn_devolucao.Text = "Devolução"
        Me.btn_devolucao.UseVisualStyleBackColor = False
        Me.btn_devolucao.Visible = False
        '
        'btn_alugar
        '
        Me.btn_alugar.Enabled = False
        Me.btn_alugar.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick
        Me.btn_alugar.FlatAppearance.BorderSize = 0
        Me.btn_alugar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_alugar.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_alugar.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btn_alugar.Location = New System.Drawing.Point(0, 123)
        Me.btn_alugar.Name = "btn_alugar"
        Me.btn_alugar.Size = New System.Drawing.Size(214, 42)
        Me.btn_alugar.TabIndex = 3
        Me.btn_alugar.Text = "Emprestar"
        Me.btn_alugar.UseVisualStyleBackColor = False
        Me.btn_alugar.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Firebrick
        Me.Panel1.Controls.Add(Me.btn_voltar)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(214, 75)
        Me.Panel1.TabIndex = 2
        '
        'btn_voltar
        '
        Me.btn_voltar.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.btn_voltar.FlatAppearance.BorderSize = 0
        Me.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_voltar.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_voltar.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btn_voltar.Image = CType(resources.GetObject("btn_voltar.Image"), System.Drawing.Image)
        Me.btn_voltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_voltar.Location = New System.Drawing.Point(0, 0)
        Me.btn_voltar.Name = "btn_voltar"
        Me.btn_voltar.Size = New System.Drawing.Size(213, 42)
        Me.btn_voltar.TabIndex = 9
        Me.btn_voltar.Text = "Voltar"
        Me.btn_voltar.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(72, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(65, 52)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.Silver
        Me.Panel2.Controls.Add(Me.btn_minimizar)
        Me.Panel2.Controls.Add(Me.btn_maximizar)
        Me.Panel2.Controls.Add(Me.btn_sair)
        Me.Panel2.Location = New System.Drawing.Point(811, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(121, 32)
        Me.Panel2.TabIndex = 3
        '
        'btn_minimizar
        '
        Me.btn_minimizar.FlatAppearance.BorderSize = 0
        Me.btn_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_minimizar.Font = New System.Drawing.Font("Segoe UI Variable Display Semil", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_minimizar.Image = CType(resources.GetObject("btn_minimizar.Image"), System.Drawing.Image)
        Me.btn_minimizar.Location = New System.Drawing.Point(5, 3)
        Me.btn_minimizar.Name = "btn_minimizar"
        Me.btn_minimizar.Size = New System.Drawing.Size(33, 26)
        Me.btn_minimizar.TabIndex = 5
        Me.btn_minimizar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_minimizar.UseVisualStyleBackColor = True
        '
        'btn_maximizar
        '
        Me.btn_maximizar.FlatAppearance.BorderSize = 0
        Me.btn_maximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_maximizar.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_maximizar.Image = CType(resources.GetObject("btn_maximizar.Image"), System.Drawing.Image)
        Me.btn_maximizar.Location = New System.Drawing.Point(44, 3)
        Me.btn_maximizar.Name = "btn_maximizar"
        Me.btn_maximizar.Size = New System.Drawing.Size(33, 26)
        Me.btn_maximizar.TabIndex = 4
        Me.btn_maximizar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_maximizar.UseVisualStyleBackColor = True
        '
        'btn_sair
        '
        Me.btn_sair.FlatAppearance.BorderSize = 0
        Me.btn_sair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btn_sair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_sair.Font = New System.Drawing.Font("Segoe UI Variable Display Semil", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_sair.Image = CType(resources.GetObject("btn_sair.Image"), System.Drawing.Image)
        Me.btn_sair.Location = New System.Drawing.Point(85, 3)
        Me.btn_sair.Name = "btn_sair"
        Me.btn_sair.Size = New System.Drawing.Size(33, 26)
        Me.btn_sair.TabIndex = 3
        Me.btn_sair.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_sair.UseVisualStyleBackColor = True
        '
        'frm_menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(931, 478)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panelmenu)
        Me.Controls.Add(Me.Panelform)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SoLivros"
        Me.Panelform.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panelmenu.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panelform As Panel
    Friend WithEvents Panelmenu As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_acervo As Button
    Friend WithEvents btn_user As Button
    Friend WithEvents btn_devolucao As Button
    Friend WithEvents btn_alugar As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btn_minimizar As Button
    Friend WithEvents btn_maximizar As Button
    Friend WithEvents btn_sair As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents btn_livros As Button
    Friend WithEvents btn_bibliotecarios As Button
    Friend WithEvents btn_voltar As Button
    Friend WithEvents btn_relatorios As Button
End Class
