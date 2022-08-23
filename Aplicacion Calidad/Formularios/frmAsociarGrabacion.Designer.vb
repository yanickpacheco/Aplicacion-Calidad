<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAsociarGrabacion
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
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAsociarGrabacion))
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.dtgGrabaciones = New System.Windows.Forms.DataGridView()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.asociarGrabacion = New System.Windows.Forms.DataGridViewImageColumn()
        Me.idLLamada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ejecutivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaLlamada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.horaInicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.horaTermino = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fonoContacto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.duracion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.dtgGrabaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Id:"
        '
        'txtId
        '
        Me.txtId.Enabled = False
        Me.txtId.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId.Location = New System.Drawing.Point(70, 34)
        Me.txtId.Name = "txtId"
        Me.txtId.ReadOnly = True
        Me.txtId.Size = New System.Drawing.Size(100, 23)
        Me.txtId.TabIndex = 1
        '
        'dtgGrabaciones
        '
        Me.dtgGrabaciones.AllowUserToAddRows = False
        Me.dtgGrabaciones.AllowUserToDeleteRows = False
        Me.dtgGrabaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgGrabaciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.asociarGrabacion, Me.idLLamada, Me.ejecutivo, Me.fechaLlamada, Me.horaInicio, Me.horaTermino, Me.fonoContacto, Me.duracion, Me.idVenta})
        Me.dtgGrabaciones.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtgGrabaciones.Location = New System.Drawing.Point(12, 92)
        Me.dtgGrabaciones.Name = "dtgGrabaciones"
        Me.dtgGrabaciones.ReadOnly = True
        Me.dtgGrabaciones.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.dtgGrabaciones.RowHeadersVisible = False
        Me.dtgGrabaciones.RowHeadersWidth = 55
        Me.dtgGrabaciones.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dtgGrabaciones.Size = New System.Drawing.Size(757, 218)
        Me.dtgGrabaciones.TabIndex = 2
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(322, 353)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(112, 37)
        Me.btnVolver.TabIndex = 3
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'DataGridViewImageColumn1
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.NullValue = CType(resources.GetObject("DataGridViewCellStyle9.NullValue"), Object)
        DataGridViewCellStyle9.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.DataGridViewImageColumn1.DefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridViewImageColumn1.HeaderText = "Asociar Grabacion"
        Me.DataGridViewImageColumn1.Image = Global.Aplicacion_Calidad.My.Resources.Resources.iconfinder_20_blue_mic_record_microphone_4488780
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.ReadOnly = True
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'asociarGrabacion
        '
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.NullValue = CType(resources.GetObject("DataGridViewCellStyle10.NullValue"), Object)
        DataGridViewCellStyle10.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.asociarGrabacion.DefaultCellStyle = DataGridViewCellStyle10
        Me.asociarGrabacion.HeaderText = "Asociar Grabacion"
        Me.asociarGrabacion.Image = Global.Aplicacion_Calidad.My.Resources.Resources.iconfinder_20_blue_mic_record_microphone_44887801
        Me.asociarGrabacion.Name = "asociarGrabacion"
        Me.asociarGrabacion.ReadOnly = True
        Me.asociarGrabacion.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.asociarGrabacion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'idLLamada
        '
        Me.idLLamada.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.idLLamada.DataPropertyName = "Id_Llamada"
        Me.idLLamada.HeaderText = "Id Llamada"
        Me.idLLamada.Name = "idLLamada"
        Me.idLLamada.ReadOnly = True
        Me.idLLamada.Width = 78
        '
        'ejecutivo
        '
        Me.ejecutivo.DataPropertyName = "Ejecutivo"
        Me.ejecutivo.HeaderText = "Ejecutivo"
        Me.ejecutivo.Name = "ejecutivo"
        Me.ejecutivo.ReadOnly = True
        '
        'fechaLlamada
        '
        Me.fechaLlamada.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.fechaLlamada.DataPropertyName = "Fecha"
        Me.fechaLlamada.HeaderText = "Fecha Llamada"
        Me.fechaLlamada.Name = "fechaLlamada"
        Me.fechaLlamada.ReadOnly = True
        Me.fechaLlamada.Width = 96
        '
        'horaInicio
        '
        Me.horaInicio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.horaInicio.DataPropertyName = "Hora_Inicio"
        Me.horaInicio.HeaderText = "Hora Inicio"
        Me.horaInicio.Name = "horaInicio"
        Me.horaInicio.ReadOnly = True
        Me.horaInicio.Width = 77
        '
        'horaTermino
        '
        Me.horaTermino.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.horaTermino.DataPropertyName = "Hora_Termino"
        Me.horaTermino.HeaderText = "Hora Termino"
        Me.horaTermino.Name = "horaTermino"
        Me.horaTermino.ReadOnly = True
        Me.horaTermino.Width = 88
        '
        'fonoContacto
        '
        Me.fonoContacto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.fonoContacto.DataPropertyName = "Fono_Contacto"
        Me.fonoContacto.HeaderText = "Fono Contacto"
        Me.fonoContacto.Name = "fonoContacto"
        Me.fonoContacto.ReadOnly = True
        Me.fonoContacto.Width = 94
        '
        'duracion
        '
        Me.duracion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.duracion.DataPropertyName = "duracion"
        Me.duracion.HeaderText = "Duracion LLamada"
        Me.duracion.Name = "duracion"
        Me.duracion.ReadOnly = True
        Me.duracion.Width = 112
        '
        'idVenta
        '
        Me.idVenta.DataPropertyName = "Id_Venta"
        Me.idVenta.HeaderText = "ID Venta"
        Me.idVenta.Name = "idVenta"
        Me.idVenta.ReadOnly = True
        Me.idVenta.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Green
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(522, 63)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(47, 23)
        Me.TextBox1.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Indigo
        Me.Label2.Location = New System.Drawing.Point(575, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "(*) Grabacion de Venta"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(12, 313)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(585, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "(**) Para asociar audio de Venta, debe hacer doble Click en el icono de Asociar G" &
    "rabacion"
        '
        'frmAsociarGrabacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(785, 418)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.dtgGrabaciones)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmAsociarGrabacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Grabaciones Registros"
        CType(Me.dtgGrabaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents btnVolver As Button
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Public WithEvents dtgGrabaciones As DataGridView
    Friend WithEvents asociarGrabacion As DataGridViewImageColumn
    Friend WithEvents idLLamada As DataGridViewTextBoxColumn
    Friend WithEvents ejecutivo As DataGridViewTextBoxColumn
    Friend WithEvents fechaLlamada As DataGridViewTextBoxColumn
    Friend WithEvents horaInicio As DataGridViewTextBoxColumn
    Friend WithEvents horaTermino As DataGridViewTextBoxColumn
    Friend WithEvents fonoContacto As DataGridViewTextBoxColumn
    Friend WithEvents duracion As DataGridViewTextBoxColumn
    Friend WithEvents idVenta As DataGridViewTextBoxColumn
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
