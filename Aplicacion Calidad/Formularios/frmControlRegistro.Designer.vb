<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmControlRegistro
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.tpDatosCliente = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dtgDatosCliente = New System.Windows.Forms.DataGridView()
        Me.tpBeneficiarios = New System.Windows.Forms.TabPage()
        Me.dtgBeneficiarios = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dtgAdicionales = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblLabel09 = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblEjecutivo = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblIdLlamada = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbMotivo = New System.Windows.Forms.ComboBox()
        Me.cbEstado = New System.Windows.Forms.ComboBox()
        Me.lblMotivo = New System.Windows.Forms.Label()
        Me.cbSubMotivo = New System.Windows.Forms.ComboBox()
        Me.lblSubMotivo = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.gpbMotivos = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.btnOtrasGrabaciones = New System.Windows.Forms.Button()
        Me.wbGrabacion = New System.Windows.Forms.WebBrowser()
        Me.btnEscuchar = New System.Windows.Forms.Button()
        Me.ActualizarDatosCliente = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.tpDatosCliente.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dtgDatosCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpBeneficiarios.SuspendLayout()
        CType(Me.dtgBeneficiarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dtgAdicionales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbMotivos.SuspendLayout()
        Me.SuspendLayout()
        '
        'tpDatosCliente
        '
        Me.tpDatosCliente.Controls.Add(Me.TabPage1)
        Me.tpDatosCliente.Controls.Add(Me.tpBeneficiarios)
        Me.tpDatosCliente.Controls.Add(Me.TabPage2)
        Me.tpDatosCliente.Location = New System.Drawing.Point(16, 181)
        Me.tpDatosCliente.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tpDatosCliente.Name = "tpDatosCliente"
        Me.tpDatosCliente.SelectedIndex = 0
        Me.tpDatosCliente.Size = New System.Drawing.Size(1368, 298)
        Me.tpDatosCliente.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dtgDatosCliente)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPage1.Size = New System.Drawing.Size(1360, 269)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Datos Cliente"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dtgDatosCliente
        '
        Me.dtgDatosCliente.AllowUserToAddRows = False
        Me.dtgDatosCliente.AllowUserToDeleteRows = False
        Me.dtgDatosCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtgDatosCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgDatosCliente.Location = New System.Drawing.Point(4, 4)
        Me.dtgDatosCliente.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtgDatosCliente.Name = "dtgDatosCliente"
        Me.dtgDatosCliente.ReadOnly = True
        Me.dtgDatosCliente.RowHeadersWidth = 51
        Me.dtgDatosCliente.Size = New System.Drawing.Size(1345, 208)
        Me.dtgDatosCliente.TabIndex = 15
        '
        'tpBeneficiarios
        '
        Me.tpBeneficiarios.Controls.Add(Me.dtgBeneficiarios)
        Me.tpBeneficiarios.Location = New System.Drawing.Point(4, 25)
        Me.tpBeneficiarios.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tpBeneficiarios.Name = "tpBeneficiarios"
        Me.tpBeneficiarios.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tpBeneficiarios.Size = New System.Drawing.Size(1360, 269)
        Me.tpBeneficiarios.TabIndex = 1
        Me.tpBeneficiarios.Text = "Datos Beneficiarios"
        Me.tpBeneficiarios.UseVisualStyleBackColor = True
        '
        'dtgBeneficiarios
        '
        Me.dtgBeneficiarios.AllowUserToAddRows = False
        Me.dtgBeneficiarios.AllowUserToDeleteRows = False
        Me.dtgBeneficiarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtgBeneficiarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgBeneficiarios.Location = New System.Drawing.Point(8, 7)
        Me.dtgBeneficiarios.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtgBeneficiarios.Name = "dtgBeneficiarios"
        Me.dtgBeneficiarios.ReadOnly = True
        Me.dtgBeneficiarios.RowHeadersWidth = 51
        Me.dtgBeneficiarios.Size = New System.Drawing.Size(1341, 199)
        Me.dtgBeneficiarios.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dtgAdicionales)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPage2.Size = New System.Drawing.Size(1360, 269)
        Me.TabPage2.TabIndex = 2
        Me.TabPage2.Text = "Datos Adicionales"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dtgAdicionales
        '
        Me.dtgAdicionales.AllowUserToAddRows = False
        Me.dtgAdicionales.AllowUserToDeleteRows = False
        Me.dtgAdicionales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtgAdicionales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgAdicionales.Location = New System.Drawing.Point(8, 7)
        Me.dtgAdicionales.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtgAdicionales.Name = "dtgAdicionales"
        Me.dtgAdicionales.ReadOnly = True
        Me.dtgAdicionales.RowHeadersWidth = 51
        Me.dtgAdicionales.Size = New System.Drawing.Size(1341, 199)
        Me.dtgAdicionales.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(127, 71)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 23)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Id:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(55, 101)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 23)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Ejecutivo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 135)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(154, 23)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Fecha y Hora:"
        '
        'lblLabel09
        '
        Me.lblLabel09.AutoSize = True
        Me.lblLabel09.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLabel09.Location = New System.Drawing.Point(977, 151)
        Me.lblLabel09.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLabel09.Name = "lblLabel09"
        Me.lblLabel09.Size = New System.Drawing.Size(86, 19)
        Me.lblLabel09.TabIndex = 7
        Me.lblLabel09.Text = "Id Llamada:"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(173, 73)
        Me.lblID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(72, 23)
        Me.lblID.TabIndex = 8
        Me.lblID.Text = "Label5"
        '
        'lblEjecutivo
        '
        Me.lblEjecutivo.AutoSize = True
        Me.lblEjecutivo.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEjecutivo.Location = New System.Drawing.Point(173, 105)
        Me.lblEjecutivo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEjecutivo.Name = "lblEjecutivo"
        Me.lblEjecutivo.Size = New System.Drawing.Size(72, 23)
        Me.lblEjecutivo.TabIndex = 9
        Me.lblEjecutivo.Text = "Label6"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.Location = New System.Drawing.Point(173, 135)
        Me.lblFecha.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(72, 23)
        Me.lblFecha.TabIndex = 10
        Me.lblFecha.Text = "Label7"
        '
        'lblIdLlamada
        '
        Me.lblIdLlamada.AutoSize = True
        Me.lblIdLlamada.Location = New System.Drawing.Point(1092, 153)
        Me.lblIdLlamada.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIdLlamada.Name = "lblIdLlamada"
        Me.lblIdLlamada.Size = New System.Drawing.Size(51, 17)
        Me.lblIdLlamada.TabIndex = 11
        Me.lblIdLlamada.Text = "Label8"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(1027, 105)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 21)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Escuchar"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 506)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 21)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Estado Calidad"
        '
        'cbMotivo
        '
        Me.cbMotivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMotivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMotivo.FormattingEnabled = True
        Me.cbMotivo.Location = New System.Drawing.Point(77, 23)
        Me.cbMotivo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbMotivo.Name = "cbMotivo"
        Me.cbMotivo.Size = New System.Drawing.Size(232, 28)
        Me.cbMotivo.TabIndex = 16
        '
        'cbEstado
        '
        Me.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEstado.FormattingEnabled = True
        Me.cbEstado.Items.AddRange(New Object() {"Seleccione", "S", "N", "P"})
        Me.cbEstado.Location = New System.Drawing.Point(157, 504)
        Me.cbEstado.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbEstado.Name = "cbEstado"
        Me.cbEstado.Size = New System.Drawing.Size(129, 28)
        Me.cbEstado.TabIndex = 17
        '
        'lblMotivo
        '
        Me.lblMotivo.AutoSize = True
        Me.lblMotivo.Font = New System.Drawing.Font("Century", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMotivo.Location = New System.Drawing.Point(9, 25)
        Me.lblMotivo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMotivo.Name = "lblMotivo"
        Me.lblMotivo.Size = New System.Drawing.Size(65, 21)
        Me.lblMotivo.TabIndex = 18
        Me.lblMotivo.Text = "Motivo"
        '
        'cbSubMotivo
        '
        Me.cbSubMotivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSubMotivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSubMotivo.FormattingEnabled = True
        Me.cbSubMotivo.Location = New System.Drawing.Point(427, 23)
        Me.cbSubMotivo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbSubMotivo.Name = "cbSubMotivo"
        Me.cbSubMotivo.Size = New System.Drawing.Size(485, 28)
        Me.cbSubMotivo.TabIndex = 19
        '
        'lblSubMotivo
        '
        Me.lblSubMotivo.AutoSize = True
        Me.lblSubMotivo.Font = New System.Drawing.Font("Century", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubMotivo.Location = New System.Drawing.Point(320, 25)
        Me.lblSubMotivo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSubMotivo.Name = "lblSubMotivo"
        Me.lblSubMotivo.Size = New System.Drawing.Size(95, 21)
        Me.lblSubMotivo.TabIndex = 20
        Me.lblSubMotivo.Text = "SubMotivo"
        '
        'gpbMotivos
        '
        Me.gpbMotivos.Controls.Add(Me.cbMotivo)
        Me.gpbMotivos.Controls.Add(Me.lblMotivo)
        Me.gpbMotivos.Controls.Add(Me.cbSubMotivo)
        Me.gpbMotivos.Controls.Add(Me.lblSubMotivo)
        Me.gpbMotivos.Location = New System.Drawing.Point(305, 481)
        Me.gpbMotivos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gpbMotivos.Name = "gpbMotivos"
        Me.gpbMotivos.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gpbMotivos.Size = New System.Drawing.Size(920, 63)
        Me.gpbMotivos.TabIndex = 24
        Me.gpbMotivos.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(22, 572)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(129, 21)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Observaciones:"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Location = New System.Drawing.Point(170, 571)
        Me.txtObservaciones.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(984, 77)
        Me.txtObservaciones.TabIndex = 27
        '
        'btnOtrasGrabaciones
        '
        Me.btnOtrasGrabaciones.Location = New System.Drawing.Point(1185, 50)
        Me.btnOtrasGrabaciones.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnOtrasGrabaciones.Name = "btnOtrasGrabaciones"
        Me.btnOtrasGrabaciones.Size = New System.Drawing.Size(151, 26)
        Me.btnOtrasGrabaciones.TabIndex = 28
        Me.btnOtrasGrabaciones.Text = "Otras Grabaciones"
        Me.btnOtrasGrabaciones.UseVisualStyleBackColor = True
        '
        'wbGrabacion
        '
        Me.wbGrabacion.Location = New System.Drawing.Point(1096, 50)
        Me.wbGrabacion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.wbGrabacion.MinimumSize = New System.Drawing.Size(27, 25)
        Me.wbGrabacion.Name = "wbGrabacion"
        Me.wbGrabacion.Size = New System.Drawing.Size(27, 25)
        Me.wbGrabacion.TabIndex = 30
        '
        'btnEscuchar
        '
        Me.btnEscuchar.BackgroundImage = Global.Aplicacion_Calidad.My.Resources.Resources.playBTn
        Me.btnEscuchar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEscuchar.Location = New System.Drawing.Point(1028, 31)
        Me.btnEscuchar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnEscuchar.Name = "btnEscuchar"
        Me.btnEscuchar.Size = New System.Drawing.Size(100, 65)
        Me.btnEscuchar.TabIndex = 23
        Me.btnEscuchar.UseVisualStyleBackColor = True
        '
        'ActualizarDatosCliente
        '
        Me.ActualizarDatosCliente.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ActualizarDatosCliente.Image = Global.Aplicacion_Calidad.My.Resources.Resources._044_memo___copia
        Me.ActualizarDatosCliente.Location = New System.Drawing.Point(587, 49)
        Me.ActualizarDatosCliente.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ActualizarDatosCliente.Name = "ActualizarDatosCliente"
        Me.ActualizarDatosCliente.Size = New System.Drawing.Size(243, 62)
        Me.ActualizarDatosCliente.TabIndex = 29
        Me.ActualizarDatosCliente.Text = "Actualizar Datos Cliente"
        Me.ActualizarDatosCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ActualizarDatosCliente.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.BackgroundImage = Global.Aplicacion_Calidad.My.Resources.Resources._16703
        Me.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGuardar.Location = New System.Drawing.Point(1248, 565)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(100, 84)
        Me.btnGuardar.TabIndex = 22
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'frmControlRegistro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1391, 678)
        Me.Controls.Add(Me.btnEscuchar)
        Me.Controls.Add(Me.wbGrabacion)
        Me.Controls.Add(Me.ActualizarDatosCliente)
        Me.Controls.Add(Me.btnOtrasGrabaciones)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.gpbMotivos)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.cbEstado)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblIdLlamada)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.lblEjecutivo)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.lblLabel09)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tpDatosCliente)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmControlRegistro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Evaluacion de Registros"
        Me.tpDatosCliente.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dtgDatosCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpBeneficiarios.ResumeLayout(False)
        CType(Me.dtgBeneficiarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dtgAdicionales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbMotivos.ResumeLayout(False)
        Me.gpbMotivos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tpDatosCliente As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents tpBeneficiarios As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblLabel09 As Label
    Friend WithEvents lblID As Label
    Friend WithEvents lblEjecutivo As Label
    Friend WithEvents lblFecha As Label
    Friend WithEvents lblIdLlamada As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents dtgDatosCliente As DataGridView
    Friend WithEvents dtgBeneficiarios As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents cbMotivo As ComboBox
    Friend WithEvents cbEstado As ComboBox
    Friend WithEvents lblMotivo As Label
    Friend WithEvents cbSubMotivo As ComboBox
    Friend WithEvents lblSubMotivo As Label
    Friend WithEvents btnGuardar As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnEscuchar As Button
    Friend WithEvents gpbMotivos As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtObservaciones As TextBox
    Friend WithEvents btnOtrasGrabaciones As Button
    Friend WithEvents ActualizarDatosCliente As Button
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents dtgAdicionales As DataGridView
    Friend WithEvents wbGrabacion As WebBrowser
End Class
