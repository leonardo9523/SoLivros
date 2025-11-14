<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_usuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_usuario))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btn_gravar = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.img_foto = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_data = New System.Windows.Forms.DateTimePicker()
        Me.txt_cep = New System.Windows.Forms.MaskedTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_cpf = New System.Windows.Forms.MaskedTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_telefone = New System.Windows.Forms.MaskedTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_cidade = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_uf = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_bairro = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_endereco = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgv_dados_usuarios = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.txt_buscas = New System.Windows.Forms.TextBox()
        Me.cmb_tipos = New System.Windows.Forms.ComboBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.img_foto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgv_dados_usuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(55, 58)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(610, 334)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.btn_gravar)
        Me.TabPage1.Controls.Add(Me.img_foto)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.txt_data)
        Me.TabPage1.Controls.Add(Me.txt_cep)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.txt_cpf)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.txt_telefone)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.txt_cidade)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.txt_uf)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.txt_bairro)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.txt_endereco)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.txt_email)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.txt_nome)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(602, 308)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Cadastro de usuários"
        '
        'btn_gravar
        '
        Me.btn_gravar.ActiveBorderThickness = 1
        Me.btn_gravar.ActiveCornerRadius = 20
        Me.btn_gravar.ActiveFillColor = System.Drawing.Color.MediumBlue
        Me.btn_gravar.ActiveForecolor = System.Drawing.Color.White
        Me.btn_gravar.ActiveLineColor = System.Drawing.Color.Black
        Me.btn_gravar.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btn_gravar.BackgroundImage = CType(resources.GetObject("btn_gravar.BackgroundImage"), System.Drawing.Image)
        Me.btn_gravar.ButtonText = "Gravar membro"
        Me.btn_gravar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_gravar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_gravar.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btn_gravar.IdleBorderThickness = 1
        Me.btn_gravar.IdleCornerRadius = 25
        Me.btn_gravar.IdleFillColor = System.Drawing.Color.RoyalBlue
        Me.btn_gravar.IdleForecolor = System.Drawing.Color.White
        Me.btn_gravar.IdleLineColor = System.Drawing.Color.Black
        Me.btn_gravar.Location = New System.Drawing.Point(431, 215)
        Me.btn_gravar.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_gravar.Name = "btn_gravar"
        Me.btn_gravar.Size = New System.Drawing.Size(145, 56)
        Me.btn_gravar.TabIndex = 23
        Me.btn_gravar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'img_foto
        '
        Me.img_foto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.img_foto.Image = CType(resources.GetObject("img_foto.Image"), System.Drawing.Image)
        Me.img_foto.Location = New System.Drawing.Point(431, 33)
        Me.img_foto.Name = "img_foto"
        Me.img_foto.Size = New System.Drawing.Size(145, 140)
        Me.img_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_foto.TabIndex = 22
        Me.img_foto.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(143, 91)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(102, 13)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Data de nascimento"
        '
        'txt_data
        '
        Me.txt_data.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_data.Location = New System.Drawing.Point(146, 107)
        Me.txt_data.Name = "txt_data"
        Me.txt_data.Size = New System.Drawing.Size(100, 20)
        Me.txt_data.TabIndex = 20
        '
        'txt_cep
        '
        Me.txt_cep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cep.Location = New System.Drawing.Point(21, 193)
        Me.txt_cep.Mask = "00000-999"
        Me.txt_cep.Name = "txt_cep"
        Me.txt_cep.Size = New System.Drawing.Size(100, 20)
        Me.txt_cep.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(18, 177)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(28, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "CEP"
        '
        'txt_cpf
        '
        Me.txt_cpf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cpf.Location = New System.Drawing.Point(146, 49)
        Me.txt_cpf.Mask = "000,000,000-00"
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.Size = New System.Drawing.Size(100, 20)
        Me.txt_cpf.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(143, 33)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(27, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "CPF"
        '
        'txt_telefone
        '
        Me.txt_telefone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_telefone.Location = New System.Drawing.Point(269, 49)
        Me.txt_telefone.Mask = "(99) 00000-0000"
        Me.txt_telefone.Name = "txt_telefone"
        Me.txt_telefone.Size = New System.Drawing.Size(100, 20)
        Me.txt_telefone.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(266, 33)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Telefone"
        '
        'txt_cidade
        '
        Me.txt_cidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cidade.Location = New System.Drawing.Point(21, 242)
        Me.txt_cidade.Name = "txt_cidade"
        Me.txt_cidade.Size = New System.Drawing.Size(100, 20)
        Me.txt_cidade.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(18, 226)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Cidade"
        '
        'txt_uf
        '
        Me.txt_uf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_uf.Location = New System.Drawing.Point(154, 242)
        Me.txt_uf.Name = "txt_uf"
        Me.txt_uf.Size = New System.Drawing.Size(31, 20)
        Me.txt_uf.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(151, 226)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(21, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "UF"
        '
        'txt_bairro
        '
        Me.txt_bairro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_bairro.Location = New System.Drawing.Point(269, 193)
        Me.txt_bairro.Name = "txt_bairro"
        Me.txt_bairro.Size = New System.Drawing.Size(100, 20)
        Me.txt_bairro.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(266, 177)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Bairro"
        '
        'txt_endereco
        '
        Me.txt_endereco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_endereco.Location = New System.Drawing.Point(148, 193)
        Me.txt_endereco.Name = "txt_endereco"
        Me.txt_endereco.Size = New System.Drawing.Size(100, 20)
        Me.txt_endereco.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(145, 177)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Endereço"
        '
        'txt_email
        '
        Me.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_email.Location = New System.Drawing.Point(21, 107)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(100, 20)
        Me.txt_email.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(18, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Email"
        '
        'txt_nome
        '
        Me.txt_nome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_nome.Location = New System.Drawing.Point(21, 49)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(100, 20)
        Me.txt_nome.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(18, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nome"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.dgv_dados_usuarios)
        Me.TabPage2.Controls.Add(Me.txt_buscas)
        Me.TabPage2.Controls.Add(Me.cmb_tipos)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(602, 308)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Lista de usuários"
        '
        'dgv_dados_usuarios
        '
        Me.dgv_dados_usuarios.AllowUserToAddRows = False
        Me.dgv_dados_usuarios.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgv_dados_usuarios.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_dados_usuarios.BackgroundColor = System.Drawing.Color.Silver
        Me.dgv_dados_usuarios.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_dados_usuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.SlateBlue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_dados_usuarios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_dados_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_dados_usuarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column6, Me.Column5})
        Me.dgv_dados_usuarios.DoubleBuffered = True
        Me.dgv_dados_usuarios.EnableHeadersVisualStyles = False
        Me.dgv_dados_usuarios.HeaderBgColor = System.Drawing.Color.SlateBlue
        Me.dgv_dados_usuarios.HeaderForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgv_dados_usuarios.Location = New System.Drawing.Point(6, 98)
        Me.dgv_dados_usuarios.Name = "dgv_dados_usuarios"
        Me.dgv_dados_usuarios.ReadOnly = True
        Me.dgv_dados_usuarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgv_dados_usuarios.Size = New System.Drawing.Size(590, 204)
        Me.dgv_dados_usuarios.TabIndex = 4
        '
        'Column1
        '
        Me.Column1.HeaderText = "Nº"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 30
        '
        'Column2
        '
        Me.Column2.HeaderText = "CPF"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 90
        '
        'Column3
        '
        Me.Column3.HeaderText = "NOME"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "EDITAR"
        Me.Column4.Image = CType(resources.GetObject("Column4.Image"), System.Drawing.Image)
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 80
        '
        'Column6
        '
        Me.Column6.HeaderText = "BLOQUEAR/DESBLOQUEAR"
        Me.Column6.Image = CType(resources.GetObject("Column6.Image"), System.Drawing.Image)
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 170
        '
        'Column5
        '
        Me.Column5.HeaderText = "EXCLUIR"
        Me.Column5.Image = CType(resources.GetObject("Column5.Image"), System.Drawing.Image)
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 80
        '
        'txt_buscas
        '
        Me.txt_buscas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_buscas.Location = New System.Drawing.Point(244, 38)
        Me.txt_buscas.Name = "txt_buscas"
        Me.txt_buscas.Size = New System.Drawing.Size(100, 20)
        Me.txt_buscas.TabIndex = 3
        '
        'cmb_tipos
        '
        Me.cmb_tipos.FormattingEnabled = True
        Me.cmb_tipos.Items.AddRange(New Object() {"NOME", "CPF"})
        Me.cmb_tipos.Location = New System.Drawing.Point(350, 38)
        Me.cmb_tipos.Name = "cmb_tipos"
        Me.cmb_tipos.Size = New System.Drawing.Size(121, 21)
        Me.cmb_tipos.TabIndex = 2
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frm_usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(719, 446)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_usuario"
        Me.Text = "frm_usuario"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.img_foto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.dgv_dados_usuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents img_foto As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_data As DateTimePicker
    Friend WithEvents txt_cep As MaskedTextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_cpf As MaskedTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_telefone As MaskedTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_cidade As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_uf As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_bairro As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_endereco As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_email As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_buscas As TextBox
    Friend WithEvents cmb_tipos As ComboBox
    Friend WithEvents dgv_dados_usuarios As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewImageColumn
    Friend WithEvents Column6 As DataGridViewImageColumn
    Friend WithEvents Column5 As DataGridViewImageColumn
    Friend WithEvents btn_gravar As Bunifu.Framework.UI.BunifuThinButton2
End Class
