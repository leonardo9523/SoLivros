<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_acervo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_acervo))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tbc_acervo = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btn_gravar_livro = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_isbn = New System.Windows.Forms.MaskedTextBox()
        Me.img_capa = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_genero = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_pag = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_editora = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_ano = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_autor = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_titulo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgv_dados_acervo = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.txt_buscas_acervo = New System.Windows.Forms.TextBox()
        Me.cmb_tipo_acervo = New System.Windows.Forms.ComboBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.tbc_acervo.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.img_capa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgv_dados_acervo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbc_acervo
        '
        Me.tbc_acervo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbc_acervo.Controls.Add(Me.TabPage1)
        Me.tbc_acervo.Controls.Add(Me.TabPage2)
        Me.tbc_acervo.Location = New System.Drawing.Point(52, 86)
        Me.tbc_acervo.Name = "tbc_acervo"
        Me.tbc_acervo.SelectedIndex = 0
        Me.tbc_acervo.Size = New System.Drawing.Size(615, 273)
        Me.tbc_acervo.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.btn_gravar_livro)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.txt_isbn)
        Me.TabPage1.Controls.Add(Me.img_capa)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.txt_genero)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.txt_pag)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.txt_editora)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.txt_ano)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.txt_autor)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.txt_titulo)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(607, 247)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Cadastro de livros"
        '
        'btn_gravar_livro
        '
        Me.btn_gravar_livro.ActiveBorderThickness = 1
        Me.btn_gravar_livro.ActiveCornerRadius = 20
        Me.btn_gravar_livro.ActiveFillColor = System.Drawing.Color.MediumBlue
        Me.btn_gravar_livro.ActiveForecolor = System.Drawing.Color.White
        Me.btn_gravar_livro.ActiveLineColor = System.Drawing.Color.Black
        Me.btn_gravar_livro.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_gravar_livro.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btn_gravar_livro.BackgroundImage = CType(resources.GetObject("btn_gravar_livro.BackgroundImage"), System.Drawing.Image)
        Me.btn_gravar_livro.ButtonText = "Gravar livro"
        Me.btn_gravar_livro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_gravar_livro.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_gravar_livro.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_gravar_livro.IdleBorderThickness = 1
        Me.btn_gravar_livro.IdleCornerRadius = 20
        Me.btn_gravar_livro.IdleFillColor = System.Drawing.Color.RoyalBlue
        Me.btn_gravar_livro.IdleForecolor = System.Drawing.Color.White
        Me.btn_gravar_livro.IdleLineColor = System.Drawing.Color.Black
        Me.btn_gravar_livro.Location = New System.Drawing.Point(228, 185)
        Me.btn_gravar_livro.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_gravar_livro.Name = "btn_gravar_livro"
        Me.btn_gravar_livro.Size = New System.Drawing.Size(151, 45)
        Me.btn_gravar_livro.TabIndex = 21
        Me.btn_gravar_livro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label8.Location = New System.Drawing.Point(442, 4)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Capa"
        '
        'txt_isbn
        '
        Me.txt_isbn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_isbn.Location = New System.Drawing.Point(14, 61)
        Me.txt_isbn.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_isbn.Mask = "000-0000000000"
        Me.txt_isbn.Name = "txt_isbn"
        Me.txt_isbn.Size = New System.Drawing.Size(100, 20)
        Me.txt_isbn.TabIndex = 19
        '
        'img_capa
        '
        Me.img_capa.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.img_capa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.img_capa.Image = CType(resources.GetObject("img_capa.Image"), System.Drawing.Image)
        Me.img_capa.Location = New System.Drawing.Point(445, 20)
        Me.img_capa.Name = "img_capa"
        Me.img_capa.Size = New System.Drawing.Size(128, 128)
        Me.img_capa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_capa.TabIndex = 18
        Me.img_capa.TabStop = False
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(11, 111)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Gênero"
        '
        'txt_genero
        '
        Me.txt_genero.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_genero.Location = New System.Drawing.Point(14, 127)
        Me.txt_genero.Name = "txt_genero"
        Me.txt_genero.Size = New System.Drawing.Size(100, 20)
        Me.txt_genero.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(330, 111)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Número de páginas"
        '
        'txt_pag
        '
        Me.txt_pag.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_pag.Location = New System.Drawing.Point(333, 127)
        Me.txt_pag.Name = "txt_pag"
        Me.txt_pag.Size = New System.Drawing.Size(96, 20)
        Me.txt_pag.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(127, 111)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Editora"
        '
        'txt_editora
        '
        Me.txt_editora.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_editora.Location = New System.Drawing.Point(130, 127)
        Me.txt_editora.Name = "txt_editora"
        Me.txt_editora.Size = New System.Drawing.Size(129, 20)
        Me.txt_editora.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(268, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Ano"
        '
        'txt_ano
        '
        Me.txt_ano.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_ano.Location = New System.Drawing.Point(271, 127)
        Me.txt_ano.Name = "txt_ano"
        Me.txt_ano.Size = New System.Drawing.Size(50, 20)
        Me.txt_ano.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(268, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Autor"
        '
        'txt_autor
        '
        Me.txt_autor.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_autor.Location = New System.Drawing.Point(271, 61)
        Me.txt_autor.Name = "txt_autor"
        Me.txt_autor.Size = New System.Drawing.Size(140, 20)
        Me.txt_autor.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(127, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Título"
        '
        'txt_titulo
        '
        Me.txt_titulo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_titulo.Location = New System.Drawing.Point(130, 61)
        Me.txt_titulo.Name = "txt_titulo"
        Me.txt_titulo.Size = New System.Drawing.Size(129, 20)
        Me.txt_titulo.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(11, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ISBN"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.dgv_dados_acervo)
        Me.TabPage2.Controls.Add(Me.txt_buscas_acervo)
        Me.TabPage2.Controls.Add(Me.cmb_tipo_acervo)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(607, 247)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Acervo"
        '
        'dgv_dados_acervo
        '
        Me.dgv_dados_acervo.AllowUserToAddRows = False
        Me.dgv_dados_acervo.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgv_dados_acervo.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_dados_acervo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgv_dados_acervo.BackgroundColor = System.Drawing.Color.Silver
        Me.dgv_dados_acervo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_dados_acervo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.SlateBlue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_dados_acervo.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_dados_acervo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_dados_acervo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.dgv_dados_acervo.DoubleBuffered = True
        Me.dgv_dados_acervo.EnableHeadersVisualStyles = False
        Me.dgv_dados_acervo.HeaderBgColor = System.Drawing.Color.SlateBlue
        Me.dgv_dados_acervo.HeaderForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgv_dados_acervo.Location = New System.Drawing.Point(6, 63)
        Me.dgv_dados_acervo.Name = "dgv_dados_acervo"
        Me.dgv_dados_acervo.ReadOnly = True
        Me.dgv_dados_acervo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgv_dados_acervo.Size = New System.Drawing.Size(595, 178)
        Me.dgv_dados_acervo.TabIndex = 6
        '
        'Column1
        '
        Me.Column1.HeaderText = "Nº"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "ISBN"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "TÍTULO"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "EDITAR"
        Me.Column4.Image = CType(resources.GetObject("Column4.Image"), System.Drawing.Image)
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
        'txt_buscas_acervo
        '
        Me.txt_buscas_acervo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_buscas_acervo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_buscas_acervo.Location = New System.Drawing.Point(250, 23)
        Me.txt_buscas_acervo.Name = "txt_buscas_acervo"
        Me.txt_buscas_acervo.Size = New System.Drawing.Size(100, 20)
        Me.txt_buscas_acervo.TabIndex = 5
        '
        'cmb_tipo_acervo
        '
        Me.cmb_tipo_acervo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmb_tipo_acervo.FormattingEnabled = True
        Me.cmb_tipo_acervo.Items.AddRange(New Object() {"ISBN", "TITULO"})
        Me.cmb_tipo_acervo.Location = New System.Drawing.Point(356, 22)
        Me.cmb_tipo_acervo.Name = "cmb_tipo_acervo"
        Me.cmb_tipo_acervo.Size = New System.Drawing.Size(121, 21)
        Me.cmb_tipo_acervo.TabIndex = 4
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frm_acervo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(719, 446)
        Me.Controls.Add(Me.tbc_acervo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_acervo"
        Me.Text = "frm_acervo"
        Me.tbc_acervo.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.img_capa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.dgv_dados_acervo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbc_acervo As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_genero As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_pag As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_editora As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_ano As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_autor As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_titulo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents img_capa As PictureBox
    Friend WithEvents txt_buscas_acervo As TextBox
    Friend WithEvents cmb_tipo_acervo As ComboBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents txt_isbn As MaskedTextBox
    Friend WithEvents dgv_dados_acervo As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewImageColumn
    Friend WithEvents Column5 As DataGridViewImageColumn
    Friend WithEvents Label8 As Label
    Friend WithEvents btn_gravar_livro As Bunifu.Framework.UI.BunifuThinButton2
End Class
