<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEvaluador
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
        Me.dtgVentasEvaluar = New System.Windows.Forms.DataGridView()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.cmbInstancia = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbCampana = New System.Windows.Forms.ComboBox()
        Me.chkConFecha = New System.Windows.Forms.CheckBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.chkCRM = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.chkID = New System.Windows.Forms.CheckBox()
        Me.chkTel = New System.Windows.Forms.CheckBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.lblRegistrosAuditar = New System.Windows.Forms.Label()
        Me.idCRM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombreCRM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha_Venta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ejecutivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idInstancia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pais = New System.Windows.Forms.DataGridViewImageColumn()
        Me.PaisVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dtgVentasEvaluar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtgVentasEvaluar
        '
        Me.dtgVentasEvaluar.AllowUserToAddRows = False
        Me.dtgVentasEvaluar.AllowUserToDeleteRows = False
        Me.dtgVentasEvaluar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtgVentasEvaluar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dtgVentasEvaluar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgVentasEvaluar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idCRM, Me.nombreCRM, Me.Id, Me.Fecha_Venta, Me.Ejecutivo, Me.idInstancia, Me.Pais, Me.PaisVenta})
        Me.dtgVentasEvaluar.Location = New System.Drawing.Point(12, 224)
        Me.dtgVentasEvaluar.Name = "dtgVentasEvaluar"
        Me.dtgVentasEvaluar.ReadOnly = True
        Me.dtgVentasEvaluar.RowHeadersVisible = False
        Me.dtgVentasEvaluar.Size = New System.Drawing.Size(868, 291)
        Me.dtgVentasEvaluar.TabIndex = 0
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(635, 65)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(89, 49)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'cmbInstancia
        '
        Me.cmbInstancia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbInstancia.FormattingEnabled = True
        Me.cmbInstancia.Items.AddRange(New Object() {"[Seleccione]", "VENTAS PRIMER ESTADO", "VENTAS SEGUNDO ESTADO"})
        Me.cmbInstancia.Location = New System.Drawing.Point(151, 28)
        Me.cmbInstancia.Name = "cmbInstancia"
        Me.cmbInstancia.Size = New System.Drawing.Size(249, 21)
        Me.cmbInstancia.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Instancia a Evaluar: "
        '
        'cmbCampana
        '
        Me.cmbCampana.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCampana.FormattingEnabled = True
        Me.cmbCampana.Items.AddRange(New Object() {"[Seleccione]", "VENTAS PRIMER ESTADO", "VENTAS SEGUNDO ESTADO"})
        Me.cmbCampana.Location = New System.Drawing.Point(151, 65)
        Me.cmbCampana.Name = "cmbCampana"
        Me.cmbCampana.Size = New System.Drawing.Size(249, 21)
        Me.cmbCampana.TabIndex = 5
        '
        'chkConFecha
        '
        Me.chkConFecha.AutoSize = True
        Me.chkConFecha.Location = New System.Drawing.Point(12, 111)
        Me.chkConFecha.Name = "chkConFecha"
        Me.chkConFecha.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkConFecha.Size = New System.Drawing.Size(133, 17)
        Me.chkConFecha.TabIndex = 7
        Me.chkConFecha.Text = "Filtrar por Fecha Venta"
        Me.chkConFecha.UseVisualStyleBackColor = True
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(151, 108)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(99, 20)
        Me.dtpFecha.TabIndex = 8
        '
        'chkCRM
        '
        Me.chkCRM.AutoSize = True
        Me.chkCRM.Location = New System.Drawing.Point(12, 69)
        Me.chkCRM.Name = "chkCRM"
        Me.chkCRM.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkCRM.Size = New System.Drawing.Size(96, 17)
        Me.chkCRM.TabIndex = 9
        Me.chkCRM.Text = "Filtrar por CRM"
        Me.chkCRM.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 146)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Filtrar por ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 179)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Filtrar por Teléfono"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(115, 143)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(100, 20)
        Me.txtID.TabIndex = 12
        '
        'chkID
        '
        Me.chkID.AutoSize = True
        Me.chkID.Location = New System.Drawing.Point(84, 146)
        Me.chkID.Name = "chkID"
        Me.chkID.Size = New System.Drawing.Size(15, 14)
        Me.chkID.TabIndex = 13
        Me.chkID.UseVisualStyleBackColor = True
        '
        'chkTel
        '
        Me.chkTel.AutoSize = True
        Me.chkTel.Location = New System.Drawing.Point(115, 179)
        Me.chkTel.Name = "chkTel"
        Me.chkTel.Size = New System.Drawing.Size(15, 14)
        Me.chkTel.TabIndex = 14
        Me.chkTel.UseVisualStyleBackColor = True
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(150, 176)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(100, 20)
        Me.txtTelefono.TabIndex = 15
        '
        'lblRegistrosAuditar
        '
        Me.lblRegistrosAuditar.AutoSize = True
        Me.lblRegistrosAuditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegistrosAuditar.ForeColor = System.Drawing.Color.Indigo
        Me.lblRegistrosAuditar.Location = New System.Drawing.Point(482, 190)
        Me.lblRegistrosAuditar.Name = "lblRegistrosAuditar"
        Me.lblRegistrosAuditar.Size = New System.Drawing.Size(174, 20)
        Me.lblRegistrosAuditar.TabIndex = 16
        Me.lblRegistrosAuditar.Text = "Registros a Auditar: "
        '
        'idCRM
        '
        Me.idCRM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.idCRM.DataPropertyName = "idCRM"
        Me.idCRM.HeaderText = "idCRM"
        Me.idCRM.Name = "idCRM"
        Me.idCRM.ReadOnly = True
        Me.idCRM.Visible = False
        Me.idCRM.Width = 45
        '
        'nombreCRM
        '
        Me.nombreCRM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.nombreCRM.DataPropertyName = "nombreCRM"
        Me.nombreCRM.HeaderText = "Nombre CRM"
        Me.nombreCRM.Name = "nombreCRM"
        Me.nombreCRM.ReadOnly = True
        Me.nombreCRM.Width = 250
        '
        'Id
        '
        Me.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Id.DataPropertyName = "ID"
        Me.Id.HeaderText = "ID"
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        Me.Id.Width = 53
        '
        'Fecha_Venta
        '
        Me.Fecha_Venta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Fecha_Venta.DataPropertyName = "FechaVenta"
        Me.Fecha_Venta.HeaderText = "Fecha Venta"
        Me.Fecha_Venta.Name = "Fecha_Venta"
        Me.Fecha_Venta.ReadOnly = True
        Me.Fecha_Venta.Width = 93
        '
        'Ejecutivo
        '
        Me.Ejecutivo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Ejecutivo.DataPropertyName = "Ejecutivo"
        Me.Ejecutivo.HeaderText = "Ejecutivo"
        Me.Ejecutivo.Name = "Ejecutivo"
        Me.Ejecutivo.ReadOnly = True
        Me.Ejecutivo.Width = 150
        '
        'idInstancia
        '
        Me.idInstancia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.idInstancia.DataPropertyName = "idInstancia"
        Me.idInstancia.HeaderText = "Instancia"
        Me.idInstancia.Name = "idInstancia"
        Me.idInstancia.ReadOnly = True
        Me.idInstancia.Visible = False
        Me.idInstancia.Width = 75
        '
        'Pais
        '
        Me.Pais.HeaderText = "Pais"
        Me.Pais.Name = "Pais"
        Me.Pais.ReadOnly = True
        Me.Pais.Width = 33
        '
        'PaisVenta
        '
        Me.PaisVenta.DataPropertyName = "Pais"
        Me.PaisVenta.HeaderText = "PaisVenta"
        Me.PaisVenta.Name = "PaisVenta"
        Me.PaisVenta.ReadOnly = True
        Me.PaisVenta.Visible = False
        Me.PaisVenta.Width = 80
        '
        'frmEvaluador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(892, 527)
        Me.Controls.Add(Me.lblRegistrosAuditar)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.chkTel)
        Me.Controls.Add(Me.chkID)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chkCRM)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.chkConFecha)
        Me.Controls.Add(Me.cmbCampana)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbInstancia)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.dtgVentasEvaluar)
        Me.Name = "frmEvaluador"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ventas Pendientes por Evaluacion"
        CType(Me.dtgVentasEvaluar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtgVentasEvaluar As DataGridView
    Friend WithEvents btnBuscar As Button
    Friend WithEvents cmbInstancia As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbCampana As ComboBox
    Friend WithEvents chkConFecha As CheckBox
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents chkCRM As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents chkID As CheckBox
    Friend WithEvents chkTel As CheckBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents lblRegistrosAuditar As Label
    Friend WithEvents idCRM As DataGridViewTextBoxColumn
    Friend WithEvents nombreCRM As DataGridViewTextBoxColumn
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents Fecha_Venta As DataGridViewTextBoxColumn
    Friend WithEvents Ejecutivo As DataGridViewTextBoxColumn
    Friend WithEvents idInstancia As DataGridViewTextBoxColumn
    Friend WithEvents Pais As DataGridViewImageColumn
    Friend WithEvents PaisVenta As DataGridViewTextBoxColumn
End Class
