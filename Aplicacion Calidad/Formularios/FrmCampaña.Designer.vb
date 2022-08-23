<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCampaña
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCampaña))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbEjecutivoCalidad = New System.Windows.Forms.ComboBox()
        Me.txtClave = New System.Windows.Forms.TextBox()
        Me.lblUsuarioTelefonia = New System.Windows.Forms.Label()
        Me.lblClaveInvalida = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(91, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(295, 225)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(390, 386)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(71, 77)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Salir"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnIngresar
        '
        Me.btnIngresar.Font = New System.Drawing.Font("Microsoft PhagsPa", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIngresar.ForeColor = System.Drawing.Color.Maroon
        Me.btnIngresar.Location = New System.Drawing.Point(149, 386)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(163, 56)
        Me.btnIngresar.TabIndex = 5
        Me.btnIngresar.Text = "Ingresar"
        Me.btnIngresar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 278)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Usuario Ingreso"
        '
        'cmbEjecutivoCalidad
        '
        Me.cmbEjecutivoCalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEjecutivoCalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEjecutivoCalidad.FormattingEnabled = True
        Me.cmbEjecutivoCalidad.Location = New System.Drawing.Point(126, 275)
        Me.cmbEjecutivoCalidad.Name = "cmbEjecutivoCalidad"
        Me.cmbEjecutivoCalidad.Size = New System.Drawing.Size(229, 24)
        Me.cmbEjecutivoCalidad.TabIndex = 3
        '
        'txtClave
        '
        Me.txtClave.AcceptsReturn = True
        Me.txtClave.BackColor = System.Drawing.Color.White
        Me.txtClave.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtClave.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtClave.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtClave.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClave.ForeColor = System.Drawing.Color.Silver
        Me.txtClave.Location = New System.Drawing.Point(126, 316)
        Me.txtClave.MaxLength = 0
        Me.txtClave.Name = "txtClave"
        Me.txtClave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtClave.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtClave.Size = New System.Drawing.Size(229, 22)
        Me.txtClave.TabIndex = 35
        '
        'lblUsuarioTelefonia
        '
        Me.lblUsuarioTelefonia.BackColor = System.Drawing.Color.Transparent
        Me.lblUsuarioTelefonia.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblUsuarioTelefonia.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuarioTelefonia.ForeColor = System.Drawing.Color.Black
        Me.lblUsuarioTelefonia.Location = New System.Drawing.Point(29, 316)
        Me.lblUsuarioTelefonia.Name = "lblUsuarioTelefonia"
        Me.lblUsuarioTelefonia.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblUsuarioTelefonia.Size = New System.Drawing.Size(91, 22)
        Me.lblUsuarioTelefonia.TabIndex = 36
        Me.lblUsuarioTelefonia.Text = "Clave"
        '
        'lblClaveInvalida
        '
        Me.lblClaveInvalida.BackColor = System.Drawing.Color.Transparent
        Me.lblClaveInvalida.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblClaveInvalida.Font = New System.Drawing.Font("Ebrima", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClaveInvalida.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblClaveInvalida.Location = New System.Drawing.Point(122, 350)
        Me.lblClaveInvalida.Name = "lblClaveInvalida"
        Me.lblClaveInvalida.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblClaveInvalida.Size = New System.Drawing.Size(222, 22)
        Me.lblClaveInvalida.TabIndex = 37
        Me.lblClaveInvalida.Text = "(*) La contraseña no es valida"
        Me.lblClaveInvalida.Visible = False
        '
        'FrmCampaña
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(481, 478)
        Me.Controls.Add(Me.lblClaveInvalida)
        Me.Controls.Add(Me.txtClave)
        Me.Controls.Add(Me.lblUsuarioTelefonia)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnIngresar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbEjecutivoCalidad)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "FrmCampaña"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Evaluaciones Calidad"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btnIngresar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbEjecutivoCalidad As ComboBox
    Public WithEvents txtClave As TextBox
    Public WithEvents lblUsuarioTelefonia As Label
    Public WithEvents lblClaveInvalida As Label
End Class
