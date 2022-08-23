<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCambioEyO
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
        Me.cbEstado = New System.Windows.Forms.ComboBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbEstate = New System.Windows.Forms.ComboBox()
        Me.txtObs = New System.Windows.Forms.TextBox()
        Me.chkCambiarEstado = New System.Windows.Forms.CheckBox()
        Me.chkCambiarObs = New System.Windows.Forms.CheckBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbCRM = New System.Windows.Forms.ComboBox()
        Me.dtgEvaluaciones = New System.Windows.Forms.DataGridView()
        Me.NCRM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRIMERESTADO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRIMERAOBSERVACIONCALIDAD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SEGUNDOESTADO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SEGUNDAOBSERVACIONCALIDAD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ejecutivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnBuscar = New System.Windows.Forms.Button()
        CType(Me.dtgEvaluaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbEstado
        '
        Me.cbEstado.FormattingEnabled = True
        Me.cbEstado.Items.AddRange(New Object() {"[Seleccione]", "VENTAS PRIMER ESTADO", "VENTAS SEGUNDO ESTADO"})
        Me.cbEstado.Location = New System.Drawing.Point(126, 45)
        Me.cbEstado.Name = "cbEstado"
        Me.cbEstado.Size = New System.Drawing.Size(216, 21)
        Me.cbEstado.TabIndex = 0
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(569, 90)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(100, 20)
        Me.txtID.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(60, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Estado"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(503, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(254, 246)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Cambiar Estado"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(593, 246)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Cambiar Observacion"
        '
        'cbEstate
        '
        Me.cbEstate.FormattingEnabled = True
        Me.cbEstate.Items.AddRange(New Object() {"[Seleccione]", "S", "N"})
        Me.cbEstate.Location = New System.Drawing.Point(236, 272)
        Me.cbEstate.Name = "cbEstate"
        Me.cbEstate.Size = New System.Drawing.Size(121, 21)
        Me.cbEstate.TabIndex = 6
        '
        'txtObs
        '
        Me.txtObs.Location = New System.Drawing.Point(465, 272)
        Me.txtObs.Multiline = True
        Me.txtObs.Name = "txtObs"
        Me.txtObs.Size = New System.Drawing.Size(394, 85)
        Me.txtObs.TabIndex = 7
        '
        'chkCambiarEstado
        '
        Me.chkCambiarEstado.AutoSize = True
        Me.chkCambiarEstado.Location = New System.Drawing.Point(342, 246)
        Me.chkCambiarEstado.Name = "chkCambiarEstado"
        Me.chkCambiarEstado.Size = New System.Drawing.Size(15, 14)
        Me.chkCambiarEstado.TabIndex = 9
        Me.chkCambiarEstado.UseVisualStyleBackColor = True
        '
        'chkCambiarObs
        '
        Me.chkCambiarObs.AutoSize = True
        Me.chkCambiarObs.Location = New System.Drawing.Point(708, 246)
        Me.chkCambiarObs.Name = "chkCambiarObs"
        Me.chkCambiarObs.Size = New System.Drawing.Size(15, 14)
        Me.chkCambiarObs.TabIndex = 10
        Me.chkCambiarObs.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Image = Global.Aplicacion_Calidad.My.Resources.Resources._036_edit___copia
        Me.btnGuardar.Location = New System.Drawing.Point(427, 376)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(137, 50)
        Me.btnGuardar.TabIndex = 11
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(60, 92)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "CRM"
        '
        'cbCRM
        '
        Me.cbCRM.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbCRM.FormattingEnabled = True
        Me.cbCRM.Location = New System.Drawing.Point(126, 89)
        Me.cbCRM.Name = "cbCRM"
        Me.cbCRM.Size = New System.Drawing.Size(337, 21)
        Me.cbCRM.TabIndex = 13
        '
        'dtgEvaluaciones
        '
        Me.dtgEvaluaciones.AllowUserToAddRows = False
        Me.dtgEvaluaciones.AllowUserToDeleteRows = False
        Me.dtgEvaluaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgEvaluaciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NCRM, Me.PRIMERESTADO, Me.PRIMERAOBSERVACIONCALIDAD, Me.SEGUNDOESTADO, Me.SEGUNDAOBSERVACIONCALIDAD, Me.Telefono, Me.Ejecutivo})
        Me.dtgEvaluaciones.Location = New System.Drawing.Point(55, 129)
        Me.dtgEvaluaciones.Name = "dtgEvaluaciones"
        Me.dtgEvaluaciones.ReadOnly = True
        Me.dtgEvaluaciones.Size = New System.Drawing.Size(870, 99)
        Me.dtgEvaluaciones.TabIndex = 14
        '
        'NCRM
        '
        Me.NCRM.DataPropertyName = "CRM"
        Me.NCRM.HeaderText = "CRM"
        Me.NCRM.Name = "NCRM"
        Me.NCRM.ReadOnly = True
        '
        'PRIMERESTADO
        '
        Me.PRIMERESTADO.DataPropertyName = "PRIMERESTADO"
        Me.PRIMERESTADO.HeaderText = "Primer Estado"
        Me.PRIMERESTADO.Name = "PRIMERESTADO"
        Me.PRIMERESTADO.ReadOnly = True
        '
        'PRIMERAOBSERVACIONCALIDAD
        '
        Me.PRIMERAOBSERVACIONCALIDAD.DataPropertyName = "PRIMERAOBSERVACIONCALIDAD"
        Me.PRIMERAOBSERVACIONCALIDAD.HeaderText = "1° Observación"
        Me.PRIMERAOBSERVACIONCALIDAD.Name = "PRIMERAOBSERVACIONCALIDAD"
        Me.PRIMERAOBSERVACIONCALIDAD.ReadOnly = True
        Me.PRIMERAOBSERVACIONCALIDAD.Width = 150
        '
        'SEGUNDOESTADO
        '
        Me.SEGUNDOESTADO.DataPropertyName = "SEGUNDOESTADO"
        Me.SEGUNDOESTADO.HeaderText = "Segundo Estado"
        Me.SEGUNDOESTADO.Name = "SEGUNDOESTADO"
        Me.SEGUNDOESTADO.ReadOnly = True
        '
        'SEGUNDAOBSERVACIONCALIDAD
        '
        Me.SEGUNDAOBSERVACIONCALIDAD.DataPropertyName = "SEGUNDAOBSERVACIONCALIDAD"
        Me.SEGUNDAOBSERVACIONCALIDAD.HeaderText = "2° Observación"
        Me.SEGUNDAOBSERVACIONCALIDAD.Name = "SEGUNDAOBSERVACIONCALIDAD"
        Me.SEGUNDAOBSERVACIONCALIDAD.ReadOnly = True
        '
        'Telefono
        '
        Me.Telefono.DataPropertyName = "TELEFONO"
        Me.Telefono.HeaderText = "Telefono"
        Me.Telefono.Name = "Telefono"
        Me.Telefono.ReadOnly = True
        '
        'Ejecutivo
        '
        Me.Ejecutivo.DataPropertyName = "EJECUTIVO"
        Me.Ejecutivo.HeaderText = "Ejecutivo"
        Me.Ejecutivo.Name = "Ejecutivo"
        Me.Ejecutivo.ReadOnly = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Image = Global.Aplicacion_Calidad.My.Resources.Resources._039_search_Copia
        Me.btnBuscar.Location = New System.Drawing.Point(752, 61)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(118, 49)
        Me.btnBuscar.TabIndex = 8
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'frmCambioEyO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(954, 450)
        Me.Controls.Add(Me.dtgEvaluaciones)
        Me.Controls.Add(Me.cbCRM)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.chkCambiarObs)
        Me.Controls.Add(Me.chkCambiarEstado)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtObs)
        Me.Controls.Add(Me.cbEstate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.cbEstado)
        Me.Name = "frmCambioEyO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmCambioEyO"
        CType(Me.dtgEvaluaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbEstado As ComboBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cbEstate As ComboBox
    Friend WithEvents txtObs As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents chkCambiarEstado As CheckBox
    Friend WithEvents chkCambiarObs As CheckBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents cbCRM As ComboBox
    Friend WithEvents dtgEvaluaciones As DataGridView
    Friend WithEvents NCRM As DataGridViewTextBoxColumn
    Friend WithEvents PRIMERESTADO As DataGridViewTextBoxColumn
    Friend WithEvents PRIMERAOBSERVACIONCALIDAD As DataGridViewTextBoxColumn
    Friend WithEvents SEGUNDOESTADO As DataGridViewTextBoxColumn
    Friend WithEvents SEGUNDAOBSERVACIONCALIDAD As DataGridViewTextBoxColumn
    Friend WithEvents Telefono As DataGridViewTextBoxColumn
    Friend WithEvents Ejecutivo As DataGridViewTextBoxColumn
End Class
