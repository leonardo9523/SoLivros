<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_alugar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_alugar))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btn_checagem = New System.Windows.Forms.Button()
        Me.lbl_data_devolucao = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_data = New System.Windows.Forms.Label()
        Me.txt_isbn_aluga = New System.Windows.Forms.MaskedTextBox()
        Me.BunifuCards1 = New Bunifu.Framework.UI.BunifuCards()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lbl_status_membro = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl_membro = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.img_foto_usuario = New System.Windows.Forms.PictureBox()
        Me.BunifuCards2 = New Bunifu.Framework.UI.BunifuCards()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_status_livro = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_titulo = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.img_capa_emprestimos = New System.Windows.Forms.PictureBox()
        Me.btn_aluga = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_cpf_aluga = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgv_dados_emprestimos = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_buscas_emprestimos = New System.Windows.Forms.TextBox()
        Me.cmb_tipos_emprestimos = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.BunifuCards1.SuspendLayout()
        CType(Me.img_foto_usuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuCards2.SuspendLayout()
        CType(Me.img_capa_emprestimos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgv_dados_emprestimos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 27)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(695, 399)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.btn_checagem)
        Me.TabPage1.Controls.Add(Me.lbl_data_devolucao)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.lbl_data)
        Me.TabPage1.Controls.Add(Me.txt_isbn_aluga)
        Me.TabPage1.Controls.Add(Me.BunifuCards1)
        Me.TabPage1.Controls.Add(Me.BunifuCards2)
        Me.TabPage1.Controls.Add(Me.btn_aluga)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.txt_cpf_aluga)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(687, 373)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Empréstimos"
        '
        'btn_checagem
        '
        Me.btn_checagem.Image = CType(resources.GetObject("btn_checagem.Image"), System.Drawing.Image)
        Me.btn_checagem.Location = New System.Drawing.Point(298, 47)
        Me.btn_checagem.Name = "btn_checagem"
        Me.btn_checagem.Size = New System.Drawing.Size(28, 29)
        Me.btn_checagem.TabIndex = 27
        Me.btn_checagem.UseVisualStyleBackColor = True
        '
        'lbl_data_devolucao
        '
        Me.lbl_data_devolucao.AutoSize = True
        Me.lbl_data_devolucao.Location = New System.Drawing.Point(487, 59)
        Me.lbl_data_devolucao.Name = "lbl_data_devolucao"
        Me.lbl_data_devolucao.Size = New System.Drawing.Size(0, 13)
        Me.lbl_data_devolucao.TabIndex = 26
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(487, 36)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 13)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Data de devolução"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(341, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Data do empréstimo"
        '
        'lbl_data
        '
        Me.lbl_data.AutoSize = True
        Me.lbl_data.Location = New System.Drawing.Point(341, 55)
        Me.lbl_data.Name = "lbl_data"
        Me.lbl_data.Size = New System.Drawing.Size(0, 13)
        Me.lbl_data.TabIndex = 23
        '
        'txt_isbn_aluga
        '
        Me.txt_isbn_aluga.Location = New System.Drawing.Point(192, 52)
        Me.txt_isbn_aluga.Mask = "000-0000000000"
        Me.txt_isbn_aluga.Name = "txt_isbn_aluga"
        Me.txt_isbn_aluga.Size = New System.Drawing.Size(100, 20)
        Me.txt_isbn_aluga.TabIndex = 22
        '
        'BunifuCards1
        '
        Me.BunifuCards1.BackColor = System.Drawing.Color.Silver
        Me.BunifuCards1.BorderRadius = 10
        Me.BunifuCards1.BottomSahddow = False
        Me.BunifuCards1.color = System.Drawing.Color.Firebrick
        Me.BunifuCards1.Controls.Add(Me.Label10)
        Me.BunifuCards1.Controls.Add(Me.lbl_status_membro)
        Me.BunifuCards1.Controls.Add(Me.Label7)
        Me.BunifuCards1.Controls.Add(Me.lbl_membro)
        Me.BunifuCards1.Controls.Add(Me.Label9)
        Me.BunifuCards1.Controls.Add(Me.img_foto_usuario)
        Me.BunifuCards1.LeftSahddow = False
        Me.BunifuCards1.Location = New System.Drawing.Point(3, 174)
        Me.BunifuCards1.Name = "BunifuCards1"
        Me.BunifuCards1.RightSahddow = False
        Me.BunifuCards1.ShadowDepth = 20
        Me.BunifuCards1.Size = New System.Drawing.Size(336, 196)
        Me.BunifuCards1.TabIndex = 21
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(3, 118)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(95, 13)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Status do membro:"
        '
        'lbl_status_membro
        '
        Me.lbl_status_membro.AutoSize = True
        Me.lbl_status_membro.Location = New System.Drawing.Point(113, 118)
        Me.lbl_status_membro.Name = "lbl_status_membro"
        Me.lbl_status_membro.Size = New System.Drawing.Size(0, 13)
        Me.lbl_status_membro.TabIndex = 20
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Membro"
        '
        'lbl_membro
        '
        Me.lbl_membro.AutoSize = True
        Me.lbl_membro.Location = New System.Drawing.Point(3, 69)
        Me.lbl_membro.Name = "lbl_membro"
        Me.lbl_membro.Size = New System.Drawing.Size(0, 13)
        Me.lbl_membro.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(3, 46)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(93, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Nome do membro:"
        '
        'img_foto_usuario
        '
        Me.img_foto_usuario.Image = CType(resources.GetObject("img_foto_usuario.Image"), System.Drawing.Image)
        Me.img_foto_usuario.Location = New System.Drawing.Point(199, 15)
        Me.img_foto_usuario.Name = "img_foto_usuario"
        Me.img_foto_usuario.Size = New System.Drawing.Size(134, 134)
        Me.img_foto_usuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_foto_usuario.TabIndex = 16
        Me.img_foto_usuario.TabStop = False
        '
        'BunifuCards2
        '
        Me.BunifuCards2.BackColor = System.Drawing.Color.Silver
        Me.BunifuCards2.BorderRadius = 10
        Me.BunifuCards2.BottomSahddow = False
        Me.BunifuCards2.color = System.Drawing.Color.Firebrick
        Me.BunifuCards2.Controls.Add(Me.Label2)
        Me.BunifuCards2.Controls.Add(Me.lbl_status_livro)
        Me.BunifuCards2.Controls.Add(Me.Label4)
        Me.BunifuCards2.Controls.Add(Me.lbl_titulo)
        Me.BunifuCards2.Controls.Add(Me.Label6)
        Me.BunifuCards2.Controls.Add(Me.img_capa_emprestimos)
        Me.BunifuCards2.LeftSahddow = False
        Me.BunifuCards2.Location = New System.Drawing.Point(348, 174)
        Me.BunifuCards2.Name = "BunifuCards2"
        Me.BunifuCards2.RightSahddow = False
        Me.BunifuCards2.ShadowDepth = 20
        Me.BunifuCards2.Size = New System.Drawing.Size(336, 196)
        Me.BunifuCards2.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Status do livro:"
        '
        'lbl_status_livro
        '
        Me.lbl_status_livro.AutoSize = True
        Me.lbl_status_livro.Location = New System.Drawing.Point(93, 118)
        Me.lbl_status_livro.Name = "lbl_status_livro"
        Me.lbl_status_livro.Size = New System.Drawing.Size(0, 13)
        Me.lbl_status_livro.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Livro"
        '
        'lbl_titulo
        '
        Me.lbl_titulo.AutoSize = True
        Me.lbl_titulo.Location = New System.Drawing.Point(3, 69)
        Me.lbl_titulo.Name = "lbl_titulo"
        Me.lbl_titulo.Size = New System.Drawing.Size(0, 13)
        Me.lbl_titulo.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 46)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Título do livro:"
        '
        'img_capa_emprestimos
        '
        Me.img_capa_emprestimos.Image = CType(resources.GetObject("img_capa_emprestimos.Image"), System.Drawing.Image)
        Me.img_capa_emprestimos.Location = New System.Drawing.Point(214, 15)
        Me.img_capa_emprestimos.Name = "img_capa_emprestimos"
        Me.img_capa_emprestimos.Size = New System.Drawing.Size(119, 134)
        Me.img_capa_emprestimos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_capa_emprestimos.TabIndex = 16
        Me.img_capa_emprestimos.TabStop = False
        '
        'btn_aluga
        '
        Me.btn_aluga.ActiveBorderThickness = 1
        Me.btn_aluga.ActiveCornerRadius = 20
        Me.btn_aluga.ActiveFillColor = System.Drawing.Color.Maroon
        Me.btn_aluga.ActiveForecolor = System.Drawing.Color.White
        Me.btn_aluga.ActiveLineColor = System.Drawing.Color.Black
        Me.btn_aluga.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btn_aluga.BackgroundImage = CType(resources.GetObject("btn_aluga.BackgroundImage"), System.Drawing.Image)
        Me.btn_aluga.ButtonText = "Emprestar"
        Me.btn_aluga.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_aluga.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_aluga.ForeColor = System.Drawing.Color.White
        Me.btn_aluga.IdleBorderThickness = 1
        Me.btn_aluga.IdleCornerRadius = 20
        Me.btn_aluga.IdleFillColor = System.Drawing.Color.Firebrick
        Me.btn_aluga.IdleForecolor = System.Drawing.Color.White
        Me.btn_aluga.IdleLineColor = System.Drawing.Color.Black
        Me.btn_aluga.Location = New System.Drawing.Point(271, 111)
        Me.btn_aluga.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_aluga.Name = "btn_aluga"
        Me.btn_aluga.Size = New System.Drawing.Size(145, 39)
        Me.btn_aluga.TabIndex = 14
        Me.btn_aluga.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(189, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "ISBN"
        '
        'txt_cpf_aluga
        '
        Me.txt_cpf_aluga.Location = New System.Drawing.Point(75, 52)
        Me.txt_cpf_aluga.Mask = "000,000,000-00"
        Me.txt_cpf_aluga.Name = "txt_cpf_aluga"
        Me.txt_cpf_aluga.Size = New System.Drawing.Size(100, 20)
        Me.txt_cpf_aluga.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(72, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "CPF"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.dgv_dados_emprestimos)
        Me.TabPage2.Controls.Add(Me.txt_buscas_emprestimos)
        Me.TabPage2.Controls.Add(Me.cmb_tipos_emprestimos)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(687, 373)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Lista de empréstimos"
        '
        'dgv_dados_emprestimos
        '
        Me.dgv_dados_emprestimos.AllowUserToAddRows = False
        Me.dgv_dados_emprestimos.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgv_dados_emprestimos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_dados_emprestimos.BackgroundColor = System.Drawing.Color.Silver
        Me.dgv_dados_emprestimos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_dados_emprestimos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Firebrick
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_dados_emprestimos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_dados_emprestimos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_dados_emprestimos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column6})
        Me.dgv_dados_emprestimos.DoubleBuffered = True
        Me.dgv_dados_emprestimos.EnableHeadersVisualStyles = False
        Me.dgv_dados_emprestimos.HeaderBgColor = System.Drawing.Color.Firebrick
        Me.dgv_dados_emprestimos.HeaderForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgv_dados_emprestimos.Location = New System.Drawing.Point(6, 114)
        Me.dgv_dados_emprestimos.Name = "dgv_dados_emprestimos"
        Me.dgv_dados_emprestimos.ReadOnly = True
        Me.dgv_dados_emprestimos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgv_dados_emprestimos.Size = New System.Drawing.Size(675, 253)
        Me.dgv_dados_emprestimos.TabIndex = 7
        '
        'Column1
        '
        Me.Column1.HeaderText = "Nº"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 50
        '
        'Column2
        '
        Me.Column2.HeaderText = "CPF"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 150
        '
        'Column3
        '
        Me.Column3.HeaderText = "ISBN"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 150
        '
        'Column4
        '
        Me.Column4.HeaderText = "DATA_EMPRESTIMO"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 150
        '
        'Column6
        '
        Me.Column6.HeaderText = "DATA_RETORNO"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 130
        '
        'txt_buscas_emprestimos
        '
        Me.txt_buscas_emprestimos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_buscas_emprestimos.Location = New System.Drawing.Point(296, 54)
        Me.txt_buscas_emprestimos.Name = "txt_buscas_emprestimos"
        Me.txt_buscas_emprestimos.Size = New System.Drawing.Size(100, 20)
        Me.txt_buscas_emprestimos.TabIndex = 6
        '
        'cmb_tipos_emprestimos
        '
        Me.cmb_tipos_emprestimos.FormattingEnabled = True
        Me.cmb_tipos_emprestimos.Items.AddRange(New Object() {"CPF", "ISBN"})
        Me.cmb_tipos_emprestimos.Location = New System.Drawing.Point(402, 53)
        Me.cmb_tipos_emprestimos.Name = "cmb_tipos_emprestimos"
        Me.cmb_tipos_emprestimos.Size = New System.Drawing.Size(121, 21)
        Me.cmb_tipos_emprestimos.TabIndex = 5
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(58, 321)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(2530, 13)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = resources.GetString("Label11.Text")
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.Label11.Visible = False
        '
        'frm_alugar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(719, 446)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_alugar"
        Me.Text = "frm_alugar"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.BunifuCards1.ResumeLayout(False)
        Me.BunifuCards1.PerformLayout()
        CType(Me.img_foto_usuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuCards2.ResumeLayout(False)
        Me.BunifuCards2.PerformLayout()
        CType(Me.img_capa_emprestimos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.dgv_dados_emprestimos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents txt_cpf_aluga As MaskedTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label3 As Label
    Friend WithEvents BunifuCards1 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents Label7 As Label
    Friend WithEvents lbl_membro As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents img_foto_usuario As PictureBox
    Friend WithEvents BunifuCards2 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents Label4 As Label
    Friend WithEvents lbl_titulo As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents img_capa_emprestimos As PictureBox
    Friend WithEvents btn_aluga As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents txt_isbn_aluga As MaskedTextBox
    Friend WithEvents lbl_data As Label
    Friend WithEvents lbl_data_devolucao As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents dgv_dados_emprestimos As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents txt_buscas_emprestimos As TextBox
    Friend WithEvents cmb_tipos_emprestimos As ComboBox
    Friend WithEvents lbl_status_membro As Label
    Friend WithEvents lbl_status_livro As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents btn_checagem As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
End Class
