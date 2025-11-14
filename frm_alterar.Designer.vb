<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_alterar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_alterar))
        Me.txt_senha_alterar = New System.Windows.Forms.TextBox()
        Me.txt_usuario_alterar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chk_vsenha_alterar = New System.Windows.Forms.CheckBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_sair_alterar = New System.Windows.Forms.Button()
        Me.btn_redefinir = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.txt_rsenha_alterar = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_senha_alterar
        '
        Me.txt_senha_alterar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_senha_alterar.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_senha_alterar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_senha_alterar.Location = New System.Drawing.Point(88, 179)
        Me.txt_senha_alterar.Name = "txt_senha_alterar"
        Me.txt_senha_alterar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_senha_alterar.Size = New System.Drawing.Size(298, 23)
        Me.txt_senha_alterar.TabIndex = 23
        '
        'txt_usuario_alterar
        '
        Me.txt_usuario_alterar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_usuario_alterar.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_usuario_alterar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_usuario_alterar.Location = New System.Drawing.Point(88, 106)
        Me.txt_usuario_alterar.Name = "txt_usuario_alterar"
        Me.txt_usuario_alterar.Size = New System.Drawing.Size(298, 23)
        Me.txt_usuario_alterar.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(252, 36)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Redefinir a senha"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(84, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 19)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Senha" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(84, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 19)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Usuário ou email"
        '
        'chk_vsenha_alterar
        '
        Me.chk_vsenha_alterar.AutoSize = True
        Me.chk_vsenha_alterar.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_vsenha_alterar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.chk_vsenha_alterar.Location = New System.Drawing.Point(88, 283)
        Me.chk_vsenha_alterar.Name = "chk_vsenha_alterar"
        Me.chk_vsenha_alterar.Size = New System.Drawing.Size(120, 21)
        Me.chk_vsenha_alterar.TabIndex = 17
        Me.chk_vsenha_alterar.Text = "Visualizar senha"
        Me.chk_vsenha_alterar.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.Silver
        Me.Panel2.Controls.Add(Me.btn_sair_alterar)
        Me.Panel2.Location = New System.Drawing.Point(433, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(40, 31)
        Me.Panel2.TabIndex = 16
        '
        'btn_sair_alterar
        '
        Me.btn_sair_alterar.FlatAppearance.BorderSize = 0
        Me.btn_sair_alterar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btn_sair_alterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btn_sair_alterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_sair_alterar.Font = New System.Drawing.Font("Segoe UI Variable Display Semil", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_sair_alterar.Image = CType(resources.GetObject("btn_sair_alterar.Image"), System.Drawing.Image)
        Me.btn_sair_alterar.Location = New System.Drawing.Point(4, 3)
        Me.btn_sair_alterar.Name = "btn_sair_alterar"
        Me.btn_sair_alterar.Size = New System.Drawing.Size(33, 26)
        Me.btn_sair_alterar.TabIndex = 3
        Me.btn_sair_alterar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_sair_alterar.UseVisualStyleBackColor = True
        '
        'btn_redefinir
        '
        Me.btn_redefinir.ActiveBorderThickness = 1
        Me.btn_redefinir.ActiveCornerRadius = 30
        Me.btn_redefinir.ActiveFillColor = System.Drawing.Color.MediumBlue
        Me.btn_redefinir.ActiveForecolor = System.Drawing.SystemColors.ControlLight
        Me.btn_redefinir.ActiveLineColor = System.Drawing.Color.Black
        Me.btn_redefinir.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btn_redefinir.BackgroundImage = CType(resources.GetObject("btn_redefinir.BackgroundImage"), System.Drawing.Image)
        Me.btn_redefinir.ButtonText = "Redefinir"
        Me.btn_redefinir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_redefinir.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_redefinir.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_redefinir.IdleBorderThickness = 1
        Me.btn_redefinir.IdleCornerRadius = 30
        Me.btn_redefinir.IdleFillColor = System.Drawing.Color.RoyalBlue
        Me.btn_redefinir.IdleForecolor = System.Drawing.SystemColors.ControlLight
        Me.btn_redefinir.IdleLineColor = System.Drawing.Color.Black
        Me.btn_redefinir.Location = New System.Drawing.Point(88, 320)
        Me.btn_redefinir.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_redefinir.Name = "btn_redefinir"
        Me.btn_redefinir.Size = New System.Drawing.Size(298, 41)
        Me.btn_redefinir.TabIndex = 15
        Me.btn_redefinir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_rsenha_alterar
        '
        Me.txt_rsenha_alterar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_rsenha_alterar.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_rsenha_alterar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_rsenha_alterar.Location = New System.Drawing.Point(88, 250)
        Me.txt_rsenha_alterar.Name = "txt_rsenha_alterar"
        Me.txt_rsenha_alterar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_rsenha_alterar.Size = New System.Drawing.Size(298, 23)
        Me.txt_rsenha_alterar.TabIndex = 25
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(84, 217)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 19)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Repetir a senha" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'frm_alterar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(473, 387)
        Me.Controls.Add(Me.txt_rsenha_alterar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_senha_alterar)
        Me.Controls.Add(Me.txt_usuario_alterar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.chk_vsenha_alterar)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btn_redefinir)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_alterar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_alterar"
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_senha_alterar As TextBox
    Friend WithEvents txt_usuario_alterar As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents chk_vsenha_alterar As CheckBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btn_sair_alterar As Button
    Friend WithEvents btn_redefinir As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents txt_rsenha_alterar As TextBox
    Friend WithEvents Label4 As Label
End Class
