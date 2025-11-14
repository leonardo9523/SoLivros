<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_devolver
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_devolver))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txt_devolucao_data = New System.Windows.Forms.DateTimePicker()
        Me.lbl_cpf_devolver = New System.Windows.Forms.Label()
        Me.btn_calc = New System.Windows.Forms.Button()
        Me.lbl_taxa = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btn_checagem = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_data_devolve = New System.Windows.Forms.Label()
        Me.txt_isbn_devolve = New System.Windows.Forms.MaskedTextBox()
        Me.BunifuCards1 = New Bunifu.Framework.UI.BunifuCards()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl_membro_devolver = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.img_foto_usuario = New System.Windows.Forms.PictureBox()
        Me.BunifuCards2 = New Bunifu.Framework.UI.BunifuCards()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_titulo_devolver = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.img_capa_emprestimos = New System.Windows.Forms.PictureBox()
        Me.btn_devolve = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgv_dados_devolve = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.txt_buscas_devolve = New System.Windows.Forms.TextBox()
        Me.cmb_tipos_devolve = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.BunifuCards1.SuspendLayout()
        CType(Me.img_foto_usuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuCards2.SuspendLayout()
        CType(Me.img_capa_emprestimos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgv_dados_devolve, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 24)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(695, 399)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.txt_devolucao_data)
        Me.TabPage1.Controls.Add(Me.lbl_cpf_devolver)
        Me.TabPage1.Controls.Add(Me.btn_calc)
        Me.TabPage1.Controls.Add(Me.lbl_taxa)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.btn_checagem)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.lbl_data_devolve)
        Me.TabPage1.Controls.Add(Me.txt_isbn_devolve)
        Me.TabPage1.Controls.Add(Me.BunifuCards1)
        Me.TabPage1.Controls.Add(Me.BunifuCards2)
        Me.TabPage1.Controls.Add(Me.btn_devolve)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(687, 373)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Devolução"
        '
        'txt_devolucao_data
        '
        Me.txt_devolucao_data.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_devolucao_data.Location = New System.Drawing.Point(446, 55)
        Me.txt_devolucao_data.Name = "txt_devolucao_data"
        Me.txt_devolucao_data.Size = New System.Drawing.Size(100, 20)
        Me.txt_devolucao_data.TabIndex = 32
        '
        'lbl_cpf_devolver
        '
        Me.lbl_cpf_devolver.AutoSize = True
        Me.lbl_cpf_devolver.Location = New System.Drawing.Point(188, 55)
        Me.lbl_cpf_devolver.Name = "lbl_cpf_devolver"
        Me.lbl_cpf_devolver.Size = New System.Drawing.Size(0, 13)
        Me.lbl_cpf_devolver.TabIndex = 31
        '
        'btn_calc
        '
        Me.btn_calc.Location = New System.Drawing.Point(571, 75)
        Me.btn_calc.Name = "btn_calc"
        Me.btn_calc.Size = New System.Drawing.Size(80, 29)
        Me.btn_calc.TabIndex = 30
        Me.btn_calc.Text = "Calcular Taxa"
        Me.btn_calc.UseVisualStyleBackColor = True
        '
        'lbl_taxa
        '
        Me.lbl_taxa.AutoSize = True
        Me.lbl_taxa.Location = New System.Drawing.Point(568, 59)
        Me.lbl_taxa.Name = "lbl_taxa"
        Me.lbl_taxa.Size = New System.Drawing.Size(21, 13)
        Me.lbl_taxa.TabIndex = 29
        Me.lbl_taxa.Text = "R$"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(568, 36)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(31, 13)
        Me.Label13.TabIndex = 28
        Me.Label13.Text = "Taxa"
        '
        'btn_checagem
        '
        Me.btn_checagem.Image = CType(resources.GetObject("btn_checagem.Image"), System.Drawing.Image)
        Me.btn_checagem.Location = New System.Drawing.Point(142, 50)
        Me.btn_checagem.Name = "btn_checagem"
        Me.btn_checagem.Size = New System.Drawing.Size(28, 29)
        Me.btn_checagem.TabIndex = 27
        Me.btn_checagem.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(443, 36)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 13)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Data de devolução"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(302, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Data prevista"
        '
        'lbl_data_devolve
        '
        Me.lbl_data_devolve.AutoSize = True
        Me.lbl_data_devolve.Location = New System.Drawing.Point(302, 55)
        Me.lbl_data_devolve.Name = "lbl_data_devolve"
        Me.lbl_data_devolve.Size = New System.Drawing.Size(0, 13)
        Me.lbl_data_devolve.TabIndex = 23
        '
        'txt_isbn_devolve
        '
        Me.txt_isbn_devolve.Location = New System.Drawing.Point(36, 55)
        Me.txt_isbn_devolve.Mask = "000-0000000000"
        Me.txt_isbn_devolve.Name = "txt_isbn_devolve"
        Me.txt_isbn_devolve.Size = New System.Drawing.Size(100, 20)
        Me.txt_isbn_devolve.TabIndex = 22
        '
        'BunifuCards1
        '
        Me.BunifuCards1.BackColor = System.Drawing.Color.Silver
        Me.BunifuCards1.BorderRadius = 10
        Me.BunifuCards1.BottomSahddow = False
        Me.BunifuCards1.color = System.Drawing.Color.Gray
        Me.BunifuCards1.Controls.Add(Me.Label7)
        Me.BunifuCards1.Controls.Add(Me.lbl_membro_devolver)
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
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Membro"
        '
        'lbl_membro_devolver
        '
        Me.lbl_membro_devolver.AutoSize = True
        Me.lbl_membro_devolver.Location = New System.Drawing.Point(3, 69)
        Me.lbl_membro_devolver.Name = "lbl_membro_devolver"
        Me.lbl_membro_devolver.Size = New System.Drawing.Size(0, 13)
        Me.lbl_membro_devolver.TabIndex = 18
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
        Me.BunifuCards2.color = System.Drawing.Color.Gray
        Me.BunifuCards2.Controls.Add(Me.Label4)
        Me.BunifuCards2.Controls.Add(Me.lbl_titulo_devolver)
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Livro"
        '
        'lbl_titulo_devolver
        '
        Me.lbl_titulo_devolver.AutoSize = True
        Me.lbl_titulo_devolver.Location = New System.Drawing.Point(3, 69)
        Me.lbl_titulo_devolver.Name = "lbl_titulo_devolver"
        Me.lbl_titulo_devolver.Size = New System.Drawing.Size(0, 13)
        Me.lbl_titulo_devolver.TabIndex = 18
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
        'btn_devolve
        '
        Me.btn_devolve.ActiveBorderThickness = 1
        Me.btn_devolve.ActiveCornerRadius = 20
        Me.btn_devolve.ActiveFillColor = System.Drawing.Color.Maroon
        Me.btn_devolve.ActiveForecolor = System.Drawing.Color.White
        Me.btn_devolve.ActiveLineColor = System.Drawing.Color.Black
        Me.btn_devolve.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btn_devolve.BackgroundImage = CType(resources.GetObject("btn_devolve.BackgroundImage"), System.Drawing.Image)
        Me.btn_devolve.ButtonText = "Devolver"
        Me.btn_devolve.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_devolve.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_devolve.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btn_devolve.IdleBorderThickness = 1
        Me.btn_devolve.IdleCornerRadius = 25
        Me.btn_devolve.IdleFillColor = System.Drawing.Color.Firebrick
        Me.btn_devolve.IdleForecolor = System.Drawing.Color.White
        Me.btn_devolve.IdleLineColor = System.Drawing.Color.Black
        Me.btn_devolve.Location = New System.Drawing.Point(271, 111)
        Me.btn_devolve.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_devolve.Name = "btn_devolve"
        Me.btn_devolve.Size = New System.Drawing.Size(145, 39)
        Me.btn_devolve.TabIndex = 14
        Me.btn_devolve.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "ISBN"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(188, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "CPF"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.dgv_dados_devolve)
        Me.TabPage2.Controls.Add(Me.txt_buscas_devolve)
        Me.TabPage2.Controls.Add(Me.cmb_tipos_devolve)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(687, 373)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Lista de devoluções"
        '
        'dgv_dados_devolve
        '
        Me.dgv_dados_devolve.AllowUserToAddRows = False
        Me.dgv_dados_devolve.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgv_dados_devolve.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_dados_devolve.BackgroundColor = System.Drawing.Color.Silver
        Me.dgv_dados_devolve.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_dados_devolve.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Firebrick
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_dados_devolve.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_dados_devolve.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_dados_devolve.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column6, Me.Column4, Me.Column5})
        Me.dgv_dados_devolve.DoubleBuffered = True
        Me.dgv_dados_devolve.EnableHeadersVisualStyles = False
        Me.dgv_dados_devolve.HeaderBgColor = System.Drawing.Color.Firebrick
        Me.dgv_dados_devolve.HeaderForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgv_dados_devolve.Location = New System.Drawing.Point(6, 114)
        Me.dgv_dados_devolve.Name = "dgv_dados_devolve"
        Me.dgv_dados_devolve.ReadOnly = True
        Me.dgv_dados_devolve.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgv_dados_devolve.Size = New System.Drawing.Size(675, 253)
        Me.dgv_dados_devolve.TabIndex = 7
        '
        'txt_buscas_devolve
        '
        Me.txt_buscas_devolve.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_buscas_devolve.Location = New System.Drawing.Point(296, 54)
        Me.txt_buscas_devolve.Name = "txt_buscas_devolve"
        Me.txt_buscas_devolve.Size = New System.Drawing.Size(100, 20)
        Me.txt_buscas_devolve.TabIndex = 6
        '
        'cmb_tipos_devolve
        '
        Me.cmb_tipos_devolve.FormattingEnabled = True
        Me.cmb_tipos_devolve.Items.AddRange(New Object() {"CPF", "ISBN"})
        Me.cmb_tipos_devolve.Location = New System.Drawing.Point(402, 54)
        Me.cmb_tipos_devolve.Name = "cmb_tipos_devolve"
        Me.cmb_tipos_devolve.Size = New System.Drawing.Size(121, 21)
        Me.cmb_tipos_devolve.TabIndex = 5
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(58, 321)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(2474, 13)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = resources.GetString("Label11.Text")
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.Label11.Visible = False
        '
        'Column1
        '
        Me.Column1.HeaderText = "Nº"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "CPF"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "ISBN"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "DATA_RETORNO"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 130
        '
        'Column4
        '
        Me.Column4.HeaderText = "TAXA"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "EXCLUIR"
        Me.Column5.Image = CType(resources.GetObject("Column5.Image"), System.Drawing.Image)
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'frm_devolver
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(719, 446)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_devolver"
        Me.Text = "frm_devolver"
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
        CType(Me.dgv_dados_devolve, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents btn_calc As Button
    Friend WithEvents lbl_taxa As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents btn_checagem As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lbl_data_devolve As Label
    Friend WithEvents txt_isbn_devolve As MaskedTextBox
    Friend WithEvents BunifuCards1 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents Label7 As Label
    Friend WithEvents lbl_membro_devolver As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents img_foto_usuario As PictureBox
    Friend WithEvents BunifuCards2 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents Label4 As Label
    Friend WithEvents lbl_titulo_devolver As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents img_capa_emprestimos As PictureBox
    Friend WithEvents btn_devolve As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents dgv_dados_devolve As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents txt_buscas_devolve As TextBox
    Friend WithEvents cmb_tipos_devolve As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents lbl_cpf_devolver As Label
    Friend WithEvents txt_devolucao_data As DateTimePicker
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewImageColumn
End Class
