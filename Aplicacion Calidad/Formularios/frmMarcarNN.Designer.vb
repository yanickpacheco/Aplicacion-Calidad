<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMarcarNN
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
        Me.chkRut = New System.Windows.Forms.CheckBox()
        Me.txtRut = New System.Windows.Forms.TextBox()
        Me.chkId = New System.Windows.Forms.CheckBox()
        Me.chkRangoFechas = New System.Windows.Forms.CheckBox()
        Me.dtgRegistros = New System.Windows.Forms.DataGridView()
        Me.dtpHasta = New System.Windows.Forms.DateTimePicker()
        Me.dtpDesde = New System.Windows.Forms.DateTimePicker()
        Me.cbCRM = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.txtObs = New System.Windows.Forms.TextBox()
        Me.lblCantidadRegistros = New System.Windows.Forms.Label()
        Me.chkDesiste = New System.Windows.Forms.CheckBox()
        CType(Me.dtgRegistros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkRut
        '
        Me.chkRut.AutoSize = True
        Me.chkRut.Location = New System.Drawing.Point(655, 139)
        Me.chkRut.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chkRut.Name = "chkRut"
        Me.chkRut.Size = New System.Drawing.Size(61, 24)
        Me.chkRut.TabIndex = 50
        Me.chkRut.Text = "Rut"
        Me.chkRut.UseVisualStyleBackColor = True
        '
        'txtRut
        '
        Me.txtRut.Location = New System.Drawing.Point(732, 136)
        Me.txtRut.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtRut.Name = "txtRut"
        Me.txtRut.Size = New System.Drawing.Size(148, 26)
        Me.txtRut.TabIndex = 49
        '
        'chkId
        '
        Me.chkId.AutoSize = True
        Me.chkId.Location = New System.Drawing.Point(655, 44)
        Me.chkId.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chkId.Name = "chkId"
        Me.chkId.Size = New System.Drawing.Size(52, 24)
        Me.chkId.TabIndex = 48
        Me.chkId.Text = "ID"
        Me.chkId.UseVisualStyleBackColor = True
        '
        'chkRangoFechas
        '
        Me.chkRangoFechas.AutoSize = True
        Me.chkRangoFechas.Location = New System.Drawing.Point(655, 92)
        Me.chkRangoFechas.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chkRangoFechas.Name = "chkRangoFechas"
        Me.chkRangoFechas.Size = New System.Drawing.Size(154, 24)
        Me.chkRangoFechas.TabIndex = 47
        Me.chkRangoFechas.Text = "Rango de Fecha"
        Me.chkRangoFechas.UseVisualStyleBackColor = True
        '
        'dtgRegistros
        '
        Me.dtgRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgRegistros.Location = New System.Drawing.Point(56, 176)
        Me.dtgRegistros.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtgRegistros.Name = "dtgRegistros"
        Me.dtgRegistros.RowHeadersWidth = 51
        Me.dtgRegistros.RowTemplate.Height = 24
        Me.dtgRegistros.Size = New System.Drawing.Size(1282, 309)
        Me.dtgRegistros.TabIndex = 46
        '
        'dtpHasta
        '
        Me.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpHasta.Location = New System.Drawing.Point(989, 92)
        Me.dtpHasta.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtpHasta.Name = "dtpHasta"
        Me.dtpHasta.Size = New System.Drawing.Size(122, 26)
        Me.dtpHasta.TabIndex = 45
        '
        'dtpDesde
        '
        Me.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDesde.Location = New System.Drawing.Point(834, 92)
        Me.dtpDesde.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtpDesde.Name = "dtpDesde"
        Me.dtpDesde.Size = New System.Drawing.Size(122, 26)
        Me.dtpDesde.TabIndex = 44
        '
        'cbCRM
        '
        Me.cbCRM.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbCRM.FormattingEnabled = True
        Me.cbCRM.Location = New System.Drawing.Point(152, 41)
        Me.cbCRM.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbCRM.Name = "cbCRM"
        Me.cbCRM.Size = New System.Drawing.Size(455, 28)
        Me.cbCRM.TabIndex = 43
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(53, 45)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 20)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "CRM"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(732, 42)
        Me.txtID.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(148, 26)
        Me.txtID.TabIndex = 39
        '
        'btnBuscar
        '
        Me.btnBuscar.Image = Global.Aplicacion_Calidad.My.Resources.Resources._039_search_Copia
        Me.btnBuscar.Location = New System.Drawing.Point(1146, 68)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(177, 75)
        Me.btnBuscar.TabIndex = 41
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Image = Global.Aplicacion_Calidad.My.Resources.Resources._036_edit___copia
        Me.btnGuardar.Location = New System.Drawing.Point(515, 650)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(206, 78)
        Me.btnGuardar.TabIndex = 57
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'txtObs
        '
        Me.txtObs.Location = New System.Drawing.Point(420, 515)
        Me.txtObs.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtObs.Multiline = True
        Me.txtObs.Name = "txtObs"
        Me.txtObs.Size = New System.Drawing.Size(408, 106)
        Me.txtObs.TabIndex = 54
        '
        'lblCantidadRegistros
        '
        Me.lblCantidadRegistros.AutoSize = True
        Me.lblCantidadRegistros.Location = New System.Drawing.Point(53, 139)
        Me.lblCantidadRegistros.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCantidadRegistros.Name = "lblCantidadRegistros"
        Me.lblCantidadRegistros.Size = New System.Drawing.Size(90, 20)
        Me.lblCantidadRegistros.TabIndex = 58
        Me.lblCantidadRegistros.Text = "Cantidad: 0"
        '
        'chkDesiste
        '
        Me.chkDesiste.AutoSize = True
        Me.chkDesiste.Location = New System.Drawing.Point(882, 565)
        Me.chkDesiste.Name = "chkDesiste"
        Me.chkDesiste.Size = New System.Drawing.Size(89, 24)
        Me.chkDesiste.TabIndex = 59
        Me.chkDesiste.Text = "Desiste"
        Me.chkDesiste.UseVisualStyleBackColor = True
        Me.chkDesiste.Visible = False
        '
        'frmMarcarNN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1401, 761)
        Me.Controls.Add(Me.chkDesiste)
        Me.Controls.Add(Me.lblCantidadRegistros)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.txtObs)
        Me.Controls.Add(Me.chkRut)
        Me.Controls.Add(Me.txtRut)
        Me.Controls.Add(Me.chkId)
        Me.Controls.Add(Me.chkRangoFechas)
        Me.Controls.Add(Me.dtgRegistros)
        Me.Controls.Add(Me.dtpHasta)
        Me.Controls.Add(Me.dtpDesde)
        Me.Controls.Add(Me.cbCRM)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtID)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmMarcarNN"
        Me.Text = "frmMarcarNN"
        CType(Me.dtgRegistros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chkRut As CheckBox
    Friend WithEvents txtRut As TextBox
    Friend WithEvents chkId As CheckBox
    Friend WithEvents chkRangoFechas As CheckBox
    Friend WithEvents dtgRegistros As DataGridView
    Friend WithEvents dtpHasta As DateTimePicker
    Friend WithEvents dtpDesde As DateTimePicker
    Friend WithEvents cbCRM As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtID As TextBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents txtObs As TextBox
    Friend WithEvents lblCantidadRegistros As Label
    Friend WithEvents chkDesiste As CheckBox
End Class
