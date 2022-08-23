<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModificarRegistro
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtC_ID = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtPaterno = New System.Windows.Forms.TextBox()
        Me.txtMaterno = New System.Windows.Forms.TextBox()
        Me.txtNum = New System.Windows.Forms.TextBox()
        Me.txtRef = New System.Windows.Forms.TextBox()
        Me.dtFecNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.cbCRM = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbComuna = New System.Windows.Forms.ComboBox()
        Me.cbCiudad = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblSuministro = New System.Windows.Forms.Label()
        Me.txtSuministro = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(374, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID"
        '
        'txtC_ID
        '
        Me.txtC_ID.Location = New System.Drawing.Point(398, 35)
        Me.txtC_ID.Name = "txtC_ID"
        Me.txtC_ID.Size = New System.Drawing.Size(100, 20)
        Me.txtC_ID.TabIndex = 1
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(578, 34)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(138, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(89, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Fecha Nacimiento"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(130, 186)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Direccion"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(136, 223)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Comuna"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(188, 101)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(114, 20)
        Me.txtNombre.TabIndex = 7
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(188, 183)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(171, 20)
        Me.txtDireccion.TabIndex = 9
        '
        'txtPaterno
        '
        Me.txtPaterno.Location = New System.Drawing.Point(317, 101)
        Me.txtPaterno.Name = "txtPaterno"
        Me.txtPaterno.Size = New System.Drawing.Size(100, 20)
        Me.txtPaterno.TabIndex = 11
        '
        'txtMaterno
        '
        Me.txtMaterno.Location = New System.Drawing.Point(432, 101)
        Me.txtMaterno.Name = "txtMaterno"
        Me.txtMaterno.Size = New System.Drawing.Size(100, 20)
        Me.txtMaterno.TabIndex = 12
        '
        'txtNum
        '
        Me.txtNum.Location = New System.Drawing.Point(367, 183)
        Me.txtNum.Name = "txtNum"
        Me.txtNum.Size = New System.Drawing.Size(50, 20)
        Me.txtNum.TabIndex = 13
        '
        'txtRef
        '
        Me.txtRef.Location = New System.Drawing.Point(429, 183)
        Me.txtRef.Name = "txtRef"
        Me.txtRef.Size = New System.Drawing.Size(175, 20)
        Me.txtRef.TabIndex = 14
        '
        'dtFecNacimiento
        '
        Me.dtFecNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFecNacimiento.Location = New System.Drawing.Point(188, 143)
        Me.dtFecNacimiento.Name = "dtFecNacimiento"
        Me.dtFecNacimiento.Size = New System.Drawing.Size(114, 20)
        Me.dtFecNacimiento.TabIndex = 16
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(317, 313)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(75, 23)
        Me.btnActualizar.TabIndex = 17
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'cbCRM
        '
        Me.cbCRM.FormattingEnabled = True
        Me.cbCRM.Location = New System.Drawing.Point(188, 34)
        Me.cbCRM.Name = "cbCRM"
        Me.cbCRM.Size = New System.Drawing.Size(176, 21)
        Me.cbCRM.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(143, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "CRM"
        '
        'cbComuna
        '
        Me.cbComuna.FormattingEnabled = True
        Me.cbComuna.Location = New System.Drawing.Point(188, 220)
        Me.cbComuna.Name = "cbComuna"
        Me.cbComuna.Size = New System.Drawing.Size(121, 21)
        Me.cbComuna.TabIndex = 20
        '
        'cbCiudad
        '
        Me.cbCiudad.FormattingEnabled = True
        Me.cbCiudad.Location = New System.Drawing.Point(337, 220)
        Me.cbCiudad.Name = "cbCiudad"
        Me.cbCiudad.Size = New System.Drawing.Size(121, 21)
        Me.cbCiudad.TabIndex = 21
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(454, 294)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(272, 16)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Los campos a modificar se destacan en rojo"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(443, 288)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(15, 24)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "!"
        '
        'lblSuministro
        '
        Me.lblSuministro.AutoSize = True
        Me.lblSuministro.Location = New System.Drawing.Point(325, 145)
        Me.lblSuministro.Name = "lblSuministro"
        Me.lblSuministro.Size = New System.Drawing.Size(70, 13)
        Me.lblSuministro.TabIndex = 24
        Me.lblSuministro.Text = "N° Suministro"
        '
        'txtSuministro
        '
        Me.txtSuministro.Location = New System.Drawing.Point(401, 142)
        Me.txtSuministro.Name = "txtSuministro"
        Me.txtSuministro.Size = New System.Drawing.Size(131, 20)
        Me.txtSuministro.TabIndex = 25
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(150, 262)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 13)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Email"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(188, 259)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(270, 20)
        Me.txtEmail.TabIndex = 27
        '
        'frmModificarRegistro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(752, 378)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtSuministro)
        Me.Controls.Add(Me.lblSuministro)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cbCiudad)
        Me.Controls.Add(Me.cbComuna)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbCRM)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.dtFecNacimiento)
        Me.Controls.Add(Me.txtRef)
        Me.Controls.Add(Me.txtNum)
        Me.Controls.Add(Me.txtMaterno)
        Me.Controls.Add(Me.txtPaterno)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtC_ID)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmModificarRegistro"
        Me.Text = "frmModificarRegistro"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtC_ID As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtPaterno As TextBox
    Friend WithEvents txtMaterno As TextBox
    Friend WithEvents txtNum As TextBox
    Friend WithEvents txtRef As TextBox
    Friend WithEvents dtFecNacimiento As DateTimePicker
    Friend WithEvents btnActualizar As Button
    Friend WithEvents cbCRM As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cbComuna As ComboBox
    Friend WithEvents cbCiudad As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblSuministro As Label
    Friend WithEvents txtSuministro As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtEmail As TextBox
End Class
