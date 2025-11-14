<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_bibliotecarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_bibliotecarios))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txt_rsenha_user = New System.Windows.Forms.TextBox()
        Me.btn_cadastrar_bibli = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.chk_vsenha_user = New System.Windows.Forms.CheckBox()
        Me.txt_senha_user = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_email_user = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_nome_user = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txt_buscas_users = New System.Windows.Forms.TextBox()
        Me.dgv_dados_users = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgv_dados_users, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txt_rsenha_user)
        Me.Panel1.Controls.Add(Me.btn_cadastrar_bibli)
        Me.Panel1.Controls.Add(Me.chk_vsenha_user)
        Me.Panel1.Controls.Add(Me.txt_senha_user)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txt_email_user)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txt_nome_user)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(107, 21)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(355, 272)
        Me.Panel1.TabIndex = 0
        '
        'txt_rsenha_user
        '
        Me.txt_rsenha_user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_rsenha_user.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_rsenha_user.Location = New System.Drawing.Point(197, 144)
        Me.txt_rsenha_user.Name = "txt_rsenha_user"
        Me.txt_rsenha_user.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_rsenha_user.Size = New System.Drawing.Size(138, 23)
        Me.txt_rsenha_user.TabIndex = 52
        '
        'btn_cadastrar_bibli
        '
        Me.btn_cadastrar_bibli.ActiveBorderThickness = 1
        Me.btn_cadastrar_bibli.ActiveCornerRadius = 35
        Me.btn_cadastrar_bibli.ActiveFillColor = System.Drawing.Color.DarkSlateBlue
        Me.btn_cadastrar_bibli.ActiveForecolor = System.Drawing.SystemColors.ControlLight
        Me.btn_cadastrar_bibli.ActiveLineColor = System.Drawing.Color.Black
        Me.btn_cadastrar_bibli.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_cadastrar_bibli.BackgroundImage = CType(resources.GetObject("btn_cadastrar_bibli.BackgroundImage"), System.Drawing.Image)
        Me.btn_cadastrar_bibli.ButtonText = "Cadastrar bibliotecário"
        Me.btn_cadastrar_bibli.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cadastrar_bibli.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cadastrar_bibli.ForeColor = System.Drawing.Color.SeaShell
        Me.btn_cadastrar_bibli.IdleBorderThickness = 1
        Me.btn_cadastrar_bibli.IdleCornerRadius = 35
        Me.btn_cadastrar_bibli.IdleFillColor = System.Drawing.Color.RoyalBlue
        Me.btn_cadastrar_bibli.IdleForecolor = System.Drawing.SystemColors.ControlLight
        Me.btn_cadastrar_bibli.IdleLineColor = System.Drawing.Color.Black
        Me.btn_cadastrar_bibli.Location = New System.Drawing.Point(20, 207)
        Me.btn_cadastrar_bibli.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_cadastrar_bibli.Name = "btn_cadastrar_bibli"
        Me.btn_cadastrar_bibli.Size = New System.Drawing.Size(315, 49)
        Me.btn_cadastrar_bibli.TabIndex = 51
        Me.btn_cadastrar_bibli.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'chk_vsenha_user
        '
        Me.chk_vsenha_user.AutoSize = True
        Me.chk_vsenha_user.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_vsenha_user.Location = New System.Drawing.Point(21, 173)
        Me.chk_vsenha_user.Name = "chk_vsenha_user"
        Me.chk_vsenha_user.Size = New System.Drawing.Size(116, 19)
        Me.chk_vsenha_user.TabIndex = 50
        Me.chk_vsenha_user.Text = "Visualizar senha"
        Me.chk_vsenha_user.UseVisualStyleBackColor = True
        '
        'txt_senha_user
        '
        Me.txt_senha_user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_senha_user.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_senha_user.Location = New System.Drawing.Point(21, 144)
        Me.txt_senha_user.Name = "txt_senha_user"
        Me.txt_senha_user.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_senha_user.Size = New System.Drawing.Size(138, 23)
        Me.txt_senha_user.TabIndex = 49
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(16, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 21)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "Senha"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(193, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 21)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Repetir senha" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txt_email_user
        '
        Me.txt_email_user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_email_user.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_email_user.Location = New System.Drawing.Point(21, 91)
        Me.txt_email_user.Name = "txt_email_user"
        Me.txt_email_user.Size = New System.Drawing.Size(314, 23)
        Me.txt_email_user.TabIndex = 45
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(17, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 21)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Email"
        '
        'txt_nome_user
        '
        Me.txt_nome_user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_nome_user.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nome_user.Location = New System.Drawing.Point(20, 36)
        Me.txt_nome_user.Name = "txt_nome_user"
        Me.txt_nome_user.Size = New System.Drawing.Size(315, 23)
        Me.txt_nome_user.TabIndex = 43
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(16, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 21)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Nome de usuário"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(43, 64)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(569, 334)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(561, 308)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Cadastro de contas"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.txt_buscas_users)
        Me.TabPage2.Controls.Add(Me.dgv_dados_users)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(561, 308)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Lista de contas"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'txt_buscas_users
        '
        Me.txt_buscas_users.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_buscas_users.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_buscas_users.Location = New System.Drawing.Point(272, 49)
        Me.txt_buscas_users.Name = "txt_buscas_users"
        Me.txt_buscas_users.Size = New System.Drawing.Size(100, 21)
        Me.txt_buscas_users.TabIndex = 10
        '
        'dgv_dados_users
        '
        Me.dgv_dados_users.AllowUserToAddRows = False
        Me.dgv_dados_users.AllowUserToDeleteRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgv_dados_users.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_dados_users.BackgroundColor = System.Drawing.Color.Silver
        Me.dgv_dados_users.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_dados_users.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.SlateBlue
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_dados_users.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_dados_users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_dados_users.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.dgv_dados_users.DoubleBuffered = True
        Me.dgv_dados_users.EnableHeadersVisualStyles = False
        Me.dgv_dados_users.HeaderBgColor = System.Drawing.Color.SlateBlue
        Me.dgv_dados_users.HeaderForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgv_dados_users.Location = New System.Drawing.Point(6, 96)
        Me.dgv_dados_users.Name = "dgv_dados_users"
        Me.dgv_dados_users.ReadOnly = True
        Me.dgv_dados_users.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgv_dados_users.Size = New System.Drawing.Size(549, 206)
        Me.dgv_dados_users.TabIndex = 8
        '
        'Column1
        '
        Me.Column1.HeaderText = "Nº"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 40
        '
        'Column2
        '
        Me.Column2.HeaderText = "NOME"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "STATUS"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 75
        '
        'Column4
        '
        Me.Column4.HeaderText = "BLOQUEAR/DESBLOQUEAR"
        Me.Column4.Image = CType(resources.GetObject("Column4.Image"), System.Drawing.Image)
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 200
        '
        'Column5
        '
        Me.Column5.HeaderText = "EXCLUIR"
        Me.Column5.Image = CType(resources.GetObject("Column5.Image"), System.Drawing.Image)
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 90
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(145, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 19)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Busca por nome:"
        '
        'frm_bibliotecarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(719, 446)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_bibliotecarios"
        Me.Text = "Bibliotecarios"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.dgv_dados_users, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_cadastrar_bibli As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents chk_vsenha_user As CheckBox
    Friend WithEvents txt_senha_user As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_email_user As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_nome_user As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_rsenha_user As TextBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents dgv_dados_users As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents txt_buscas_users As TextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewImageColumn
    Friend WithEvents Column5 As DataGridViewImageColumn
    Friend WithEvents Label5 As Label
End Class
