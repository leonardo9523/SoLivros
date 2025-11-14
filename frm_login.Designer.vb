<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_login))
        Me.btn_entrar = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_minimizar = New System.Windows.Forms.Button()
        Me.btn_sair = New System.Windows.Forms.Button()
        Me.chk_vsenha = New System.Windows.Forms.CheckBox()
        Me.lbl_esqueceu = New System.Windows.Forms.LinkLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.txt_senha = New System.Windows.Forms.TextBox()
        Me.lbl_sem_login = New System.Windows.Forms.LinkLabel()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_entrar
        '
        Me.btn_entrar.ActiveBorderThickness = 1
        Me.btn_entrar.ActiveCornerRadius = 20
        Me.btn_entrar.ActiveFillColor = System.Drawing.Color.Maroon
        Me.btn_entrar.ActiveForecolor = System.Drawing.SystemColors.ControlLight
        Me.btn_entrar.ActiveLineColor = System.Drawing.Color.Black
        Me.btn_entrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btn_entrar.BackgroundImage = CType(resources.GetObject("btn_entrar.BackgroundImage"), System.Drawing.Image)
        Me.btn_entrar.ButtonText = "Entrar"
        Me.btn_entrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_entrar.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_entrar.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_entrar.IdleBorderThickness = 1
        Me.btn_entrar.IdleCornerRadius = 20
        Me.btn_entrar.IdleFillColor = System.Drawing.Color.Firebrick
        Me.btn_entrar.IdleForecolor = System.Drawing.SystemColors.ControlLight
        Me.btn_entrar.IdleLineColor = System.Drawing.SystemColors.Desktop
        Me.btn_entrar.Location = New System.Drawing.Point(87, 287)
        Me.btn_entrar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_entrar.Name = "btn_entrar"
        Me.btn_entrar.Size = New System.Drawing.Size(298, 41)
        Me.btn_entrar.TabIndex = 4
        Me.btn_entrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.Silver
        Me.Panel2.Controls.Add(Me.btn_minimizar)
        Me.Panel2.Controls.Add(Me.btn_sair)
        Me.Panel2.Location = New System.Drawing.Point(396, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(76, 32)
        Me.Panel2.TabIndex = 6
        '
        'btn_minimizar
        '
        Me.btn_minimizar.FlatAppearance.BorderSize = 0
        Me.btn_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_minimizar.Font = New System.Drawing.Font("Segoe UI Variable Display Semil", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_minimizar.Image = CType(resources.GetObject("btn_minimizar.Image"), System.Drawing.Image)
        Me.btn_minimizar.Location = New System.Drawing.Point(3, 3)
        Me.btn_minimizar.Name = "btn_minimizar"
        Me.btn_minimizar.Size = New System.Drawing.Size(33, 26)
        Me.btn_minimizar.TabIndex = 5
        Me.btn_minimizar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_minimizar.UseVisualStyleBackColor = True
        '
        'btn_sair
        '
        Me.btn_sair.FlatAppearance.BorderSize = 0
        Me.btn_sair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btn_sair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_sair.Font = New System.Drawing.Font("Segoe UI Variable Display Semil", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_sair.Image = CType(resources.GetObject("btn_sair.Image"), System.Drawing.Image)
        Me.btn_sair.Location = New System.Drawing.Point(42, 3)
        Me.btn_sair.Name = "btn_sair"
        Me.btn_sair.Size = New System.Drawing.Size(33, 26)
        Me.btn_sair.TabIndex = 3
        Me.btn_sair.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_sair.UseVisualStyleBackColor = True
        '
        'chk_vsenha
        '
        Me.chk_vsenha.AutoSize = True
        Me.chk_vsenha.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_vsenha.ForeColor = System.Drawing.Color.Firebrick
        Me.chk_vsenha.Location = New System.Drawing.Point(87, 250)
        Me.chk_vsenha.Name = "chk_vsenha"
        Me.chk_vsenha.Size = New System.Drawing.Size(120, 21)
        Me.chk_vsenha.TabIndex = 8
        Me.chk_vsenha.Text = "Visualizar senha"
        Me.chk_vsenha.UseVisualStyleBackColor = True
        '
        'lbl_esqueceu
        '
        Me.lbl_esqueceu.ActiveLinkColor = System.Drawing.Color.MediumBlue
        Me.lbl_esqueceu.AutoSize = True
        Me.lbl_esqueceu.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_esqueceu.LinkColor = System.Drawing.Color.SlateBlue
        Me.lbl_esqueceu.Location = New System.Drawing.Point(267, 251)
        Me.lbl_esqueceu.Name = "lbl_esqueceu"
        Me.lbl_esqueceu.Size = New System.Drawing.Size(118, 17)
        Me.lbl_esqueceu.TabIndex = 9
        Me.lbl_esqueceu.TabStop = True
        Me.lbl_esqueceu.Text = "Esqueceu a senha?"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(83, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 19)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Usuário ou email"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(83, 171)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 19)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Senha" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Firebrick
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 36)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Entrar"
        '
        'txt_usuario
        '
        Me.txt_usuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_usuario.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_usuario.Location = New System.Drawing.Point(87, 130)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(298, 23)
        Me.txt_usuario.TabIndex = 13
        '
        'txt_senha
        '
        Me.txt_senha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_senha.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_senha.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_senha.Location = New System.Drawing.Point(87, 204)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_senha.Size = New System.Drawing.Size(298, 23)
        Me.txt_senha.TabIndex = 14
        '
        'lbl_sem_login
        '
        Me.lbl_sem_login.ActiveLinkColor = System.Drawing.Color.MediumBlue
        Me.lbl_sem_login.AutoSize = True
        Me.lbl_sem_login.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_sem_login.LinkColor = System.Drawing.Color.SlateBlue
        Me.lbl_sem_login.Location = New System.Drawing.Point(15, 350)
        Me.lbl_sem_login.Name = "lbl_sem_login"
        Me.lbl_sem_login.Size = New System.Drawing.Size(104, 17)
        Me.lbl_sem_login.TabIndex = 15
        Me.lbl_sem_login.TabStop = True
        Me.lbl_sem_login.Text = "Entrar sem login"
        '
        'frm_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(473, 387)
        Me.Controls.Add(Me.lbl_sem_login)
        Me.Controls.Add(Me.txt_senha)
        Me.Controls.Add(Me.txt_usuario)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_esqueceu)
        Me.Controls.Add(Me.chk_vsenha)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btn_entrar)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_login"
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_entrar As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btn_minimizar As Button
    Friend WithEvents btn_sair As Button
    Friend WithEvents chk_vsenha As CheckBox
    Friend WithEvents lbl_esqueceu As LinkLabel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_usuario As TextBox
    Friend WithEvents txt_senha As TextBox
    Friend WithEvents lbl_sem_login As LinkLabel
End Class
