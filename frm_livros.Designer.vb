<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_livros
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_livros))
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BunifuCards1 = New Bunifu.Framework.UI.BunifuCards()
        Me.BunifuCards2 = New Bunifu.Framework.UI.BunifuCards()
        Me.lbl_status = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_num = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lbl_ano = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lbl_editora = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbl_genero = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_autor = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_titulo_livros = New System.Windows.Forms.Label()
        Me.img_capa_livros = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_tipos_livros = New System.Windows.Forms.ComboBox()
        Me.txt_buscas_livros = New System.Windows.Forms.TextBox()
        Me.dgv_dados_livros = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.BunifuCards1.SuspendLayout()
        Me.BunifuCards2.SuspendLayout()
        CType(Me.img_capa_livros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_dados_livros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuCards1
        '
        Me.BunifuCards1.BackColor = System.Drawing.Color.Silver
        Me.BunifuCards1.BorderRadius = 5
        Me.BunifuCards1.BottomSahddow = True
        Me.BunifuCards1.color = System.Drawing.Color.Firebrick
        Me.BunifuCards1.Controls.Add(Me.BunifuCards2)
        Me.BunifuCards1.Controls.Add(Me.cmb_tipos_livros)
        Me.BunifuCards1.Controls.Add(Me.txt_buscas_livros)
        Me.BunifuCards1.Controls.Add(Me.dgv_dados_livros)
        Me.BunifuCards1.LeftSahddow = False
        Me.BunifuCards1.Location = New System.Drawing.Point(12, 12)
        Me.BunifuCards1.Name = "BunifuCards1"
        Me.BunifuCards1.RightSahddow = True
        Me.BunifuCards1.ShadowDepth = 20
        Me.BunifuCards1.Size = New System.Drawing.Size(695, 422)
        Me.BunifuCards1.TabIndex = 0
        '
        'BunifuCards2
        '
        Me.BunifuCards2.BackColor = System.Drawing.Color.DarkGray
        Me.BunifuCards2.BorderRadius = 5
        Me.BunifuCards2.BottomSahddow = True
        Me.BunifuCards2.color = System.Drawing.Color.Gray
        Me.BunifuCards2.Controls.Add(Me.lbl_status)
        Me.BunifuCards2.Controls.Add(Me.Label4)
        Me.BunifuCards2.Controls.Add(Me.lbl_num)
        Me.BunifuCards2.Controls.Add(Me.Label12)
        Me.BunifuCards2.Controls.Add(Me.lbl_ano)
        Me.BunifuCards2.Controls.Add(Me.Label10)
        Me.BunifuCards2.Controls.Add(Me.lbl_editora)
        Me.BunifuCards2.Controls.Add(Me.Label8)
        Me.BunifuCards2.Controls.Add(Me.lbl_genero)
        Me.BunifuCards2.Controls.Add(Me.Label5)
        Me.BunifuCards2.Controls.Add(Me.lbl_autor)
        Me.BunifuCards2.Controls.Add(Me.Label3)
        Me.BunifuCards2.Controls.Add(Me.lbl_titulo_livros)
        Me.BunifuCards2.Controls.Add(Me.img_capa_livros)
        Me.BunifuCards2.Controls.Add(Me.Label1)
        Me.BunifuCards2.LeftSahddow = False
        Me.BunifuCards2.Location = New System.Drawing.Point(24, 212)
        Me.BunifuCards2.Name = "BunifuCards2"
        Me.BunifuCards2.RightSahddow = True
        Me.BunifuCards2.ShadowDepth = 20
        Me.BunifuCards2.Size = New System.Drawing.Size(644, 195)
        Me.BunifuCards2.TabIndex = 11
        '
        'lbl_status
        '
        Me.lbl_status.AutoSize = True
        Me.lbl_status.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_status.ForeColor = System.Drawing.Color.Red
        Me.lbl_status.Location = New System.Drawing.Point(348, 130)
        Me.lbl_status.Name = "lbl_status"
        Me.lbl_status.Size = New System.Drawing.Size(0, 17)
        Me.lbl_status.TabIndex = 32
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(296, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 17)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Status:"
        '
        'lbl_num
        '
        Me.lbl_num.AutoSize = True
        Me.lbl_num.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_num.Location = New System.Drawing.Point(430, 56)
        Me.lbl_num.Name = "lbl_num"
        Me.lbl_num.Size = New System.Drawing.Size(0, 17)
        Me.lbl_num.TabIndex = 30
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(296, 56)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(128, 17)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "Número de páginas:"
        '
        'lbl_ano
        '
        Me.lbl_ano.AutoSize = True
        Me.lbl_ano.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ano.Location = New System.Drawing.Point(422, 95)
        Me.lbl_ano.Name = "lbl_ano"
        Me.lbl_ano.Size = New System.Drawing.Size(0, 17)
        Me.lbl_ano.TabIndex = 28
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(296, 95)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(120, 17)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Ano de publicação:"
        '
        'lbl_editora
        '
        Me.lbl_editora.AutoSize = True
        Me.lbl_editora.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_editora.Location = New System.Drawing.Point(63, 95)
        Me.lbl_editora.Name = "lbl_editora"
        Me.lbl_editora.Size = New System.Drawing.Size(0, 17)
        Me.lbl_editora.TabIndex = 26
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(4, 95)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 17)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Editora:"
        '
        'lbl_genero
        '
        Me.lbl_genero.AutoSize = True
        Me.lbl_genero.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_genero.Location = New System.Drawing.Point(65, 56)
        Me.lbl_genero.Name = "lbl_genero"
        Me.lbl_genero.Size = New System.Drawing.Size(0, 17)
        Me.lbl_genero.TabIndex = 24
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(5, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 17)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Gênero:"
        '
        'lbl_autor
        '
        Me.lbl_autor.AutoSize = True
        Me.lbl_autor.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_autor.Location = New System.Drawing.Point(55, 130)
        Me.lbl_autor.Name = "lbl_autor"
        Me.lbl_autor.Size = New System.Drawing.Size(0, 17)
        Me.lbl_autor.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(5, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 17)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Autor:"
        '
        'lbl_titulo_livros
        '
        Me.lbl_titulo_livros.AutoSize = True
        Me.lbl_titulo_livros.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_titulo_livros.Location = New System.Drawing.Point(134, 13)
        Me.lbl_titulo_livros.Name = "lbl_titulo_livros"
        Me.lbl_titulo_livros.Size = New System.Drawing.Size(0, 21)
        Me.lbl_titulo_livros.TabIndex = 20
        '
        'img_capa_livros
        '
        Me.img_capa_livros.Image = CType(resources.GetObject("img_capa_livros.Image"), System.Drawing.Image)
        Me.img_capa_livros.Location = New System.Drawing.Point(489, 13)
        Me.img_capa_livros.Name = "img_capa_livros"
        Me.img_capa_livros.Size = New System.Drawing.Size(152, 179)
        Me.img_capa_livros.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_capa_livros.TabIndex = 17
        Me.img_capa_livros.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(3, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Dados do livro:"
        '
        'cmb_tipos_livros
        '
        Me.cmb_tipos_livros.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_tipos_livros.FormattingEnabled = True
        Me.cmb_tipos_livros.Items.AddRange(New Object() {"TITULO", "GENERO"})
        Me.cmb_tipos_livros.Location = New System.Drawing.Point(323, 28)
        Me.cmb_tipos_livros.Name = "cmb_tipos_livros"
        Me.cmb_tipos_livros.Size = New System.Drawing.Size(121, 21)
        Me.cmb_tipos_livros.TabIndex = 10
        '
        'txt_buscas_livros
        '
        Me.txt_buscas_livros.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_buscas_livros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_buscas_livros.Location = New System.Drawing.Point(217, 29)
        Me.txt_buscas_livros.Name = "txt_buscas_livros"
        Me.txt_buscas_livros.Size = New System.Drawing.Size(100, 20)
        Me.txt_buscas_livros.TabIndex = 9
        '
        'dgv_dados_livros
        '
        Me.dgv_dados_livros.AllowUserToAddRows = False
        Me.dgv_dados_livros.AllowUserToDeleteRows = False
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgv_dados_livros.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.dgv_dados_livros.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dgv_dados_livros.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_dados_livros.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.Brown
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_dados_livros.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgv_dados_livros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_dados_livros.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column3, Me.Column6, Me.Column2, Me.Column4, Me.Column5})
        Me.dgv_dados_livros.DoubleBuffered = True
        Me.dgv_dados_livros.EnableHeadersVisualStyles = False
        Me.dgv_dados_livros.HeaderBgColor = System.Drawing.Color.Brown
        Me.dgv_dados_livros.HeaderForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgv_dados_livros.Location = New System.Drawing.Point(24, 55)
        Me.dgv_dados_livros.Name = "dgv_dados_livros"
        Me.dgv_dados_livros.ReadOnly = True
        Me.dgv_dados_livros.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgv_dados_livros.Size = New System.Drawing.Size(644, 130)
        Me.dgv_dados_livros.TabIndex = 8
        '
        'Column1
        '
        Me.Column1.HeaderText = "Nº"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 50
        '
        'Column3
        '
        Me.Column3.HeaderText = "ISBN"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "TÍTULO"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 170
        '
        'Column2
        '
        Me.Column2.HeaderText = "GÊNERO"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "AUTOR"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "SELECIONAR"
        Me.Column5.Image = CType(resources.GetObject("Column5.Image"), System.Drawing.Image)
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 80
        '
        'frm_livros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(719, 446)
        Me.Controls.Add(Me.BunifuCards1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_livros"
        Me.Text = "frm_livros"
        Me.BunifuCards1.ResumeLayout(False)
        Me.BunifuCards1.PerformLayout()
        Me.BunifuCards2.ResumeLayout(False)
        Me.BunifuCards2.PerformLayout()
        CType(Me.img_capa_livros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_dados_livros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuCards1 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents BunifuCards2 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents Label1 As Label
    Friend WithEvents cmb_tipos_livros As ComboBox
    Friend WithEvents txt_buscas_livros As TextBox
    Friend WithEvents dgv_dados_livros As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents img_capa_livros As PictureBox
    Friend WithEvents lbl_titulo_livros As Label
    Friend WithEvents lbl_num As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lbl_ano As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lbl_editora As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lbl_genero As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lbl_autor As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_status As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewImageColumn
End Class
