<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRevisarRegistros
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
        Me.cbCRM = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.cbEstado = New System.Windows.Forms.ComboBox()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.dtpDesde = New System.Windows.Forms.DateTimePicker()
        Me.dtpHasta = New System.Windows.Forms.DateTimePicker()
        Me.dtgRegistros = New System.Windows.Forms.DataGridView()
        Me.chkRangoFechas = New System.Windows.Forms.CheckBox()
        Me.chkId = New System.Windows.Forms.CheckBox()
        Me.chkRut = New System.Windows.Forms.CheckBox()
        Me.txtRut = New System.Windows.Forms.TextBox()
        CType(Me.dtgRegistros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbCRM
        '
        Me.cbCRM.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbCRM.FormattingEnabled = True
        Me.cbCRM.Location = New System.Drawing.Point(133, 26)
        Me.cbCRM.Margin = New System.Windows.Forms.Padding(4)
        Me.cbCRM.Name = "cbCRM"
        Me.cbCRM.Size = New System.Drawing.Size(405, 24)
        Me.cbCRM.TabIndex = 28
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(45, 29)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 17)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "CRM"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 72)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 17)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Estado"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(649, 27)
        Me.txtID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(132, 22)
        Me.txtID.TabIndex = 16
        '
        'cbEstado
        '
        Me.cbEstado.FormattingEnabled = True
        Me.cbEstado.Items.AddRange(New Object() {"[Todos]", "VENTAS PRIMER ESTADO", "VENTAS SEGUNDO ESTADO"})
        Me.cbEstado.Location = New System.Drawing.Point(133, 68)
        Me.cbEstado.Margin = New System.Windows.Forms.Padding(4)
        Me.cbEstado.Name = "cbEstado"
        Me.cbEstado.Size = New System.Drawing.Size(287, 24)
        Me.cbEstado.TabIndex = 15
        '
        'btnCerrar
        '
        Me.btnCerrar.Image = Global.Aplicacion_Calidad.My.Resources.Resources.Volver
        Me.btnCerrar.Location = New System.Drawing.Point(529, 451)
        Me.btnCerrar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(183, 62)
        Me.btnCerrar.TabIndex = 26
        Me.btnCerrar.Text = "Volver"
        Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Image = Global.Aplicacion_Calidad.My.Resources.Resources._039_search_Copia
        Me.btnBuscar.Location = New System.Drawing.Point(1017, 47)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(157, 60)
        Me.btnBuscar.TabIndex = 23
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'dtpDesde
        '
        Me.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDesde.Location = New System.Drawing.Point(739, 69)
        Me.dtpDesde.Name = "dtpDesde"
        Me.dtpDesde.Size = New System.Drawing.Size(109, 22)
        Me.dtpDesde.TabIndex = 30
        '
        'dtpHasta
        '
        Me.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpHasta.Location = New System.Drawing.Point(877, 69)
        Me.dtpHasta.Name = "dtpHasta"
        Me.dtpHasta.Size = New System.Drawing.Size(109, 22)
        Me.dtpHasta.TabIndex = 31
        '
        'dtgRegistros
        '
        Me.dtgRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgRegistros.Location = New System.Drawing.Point(43, 179)
        Me.dtgRegistros.Name = "dtgRegistros"
        Me.dtgRegistros.RowHeadersWidth = 51
        Me.dtgRegistros.RowTemplate.Height = 24
        Me.dtgRegistros.Size = New System.Drawing.Size(1140, 252)
        Me.dtgRegistros.TabIndex = 33
        '
        'chkRangoFechas
        '
        Me.chkRangoFechas.AutoSize = True
        Me.chkRangoFechas.Location = New System.Drawing.Point(580, 69)
        Me.chkRangoFechas.Name = "chkRangoFechas"
        Me.chkRangoFechas.Size = New System.Drawing.Size(135, 21)
        Me.chkRangoFechas.TabIndex = 34
        Me.chkRangoFechas.Text = "Rango de Fecha"
        Me.chkRangoFechas.UseVisualStyleBackColor = True
        '
        'chkId
        '
        Me.chkId.AutoSize = True
        Me.chkId.Location = New System.Drawing.Point(580, 29)
        Me.chkId.Name = "chkId"
        Me.chkId.Size = New System.Drawing.Size(43, 21)
        Me.chkId.TabIndex = 35
        Me.chkId.Text = "ID"
        Me.chkId.UseVisualStyleBackColor = True
        '
        'chkRut
        '
        Me.chkRut.AutoSize = True
        Me.chkRut.Location = New System.Drawing.Point(580, 107)
        Me.chkRut.Name = "chkRut"
        Me.chkRut.Size = New System.Drawing.Size(52, 21)
        Me.chkRut.TabIndex = 37
        Me.chkRut.Text = "Rut"
        Me.chkRut.UseVisualStyleBackColor = True
        '
        'txtRut
        '
        Me.txtRut.Location = New System.Drawing.Point(649, 105)
        Me.txtRut.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRut.Name = "txtRut"
        Me.txtRut.Size = New System.Drawing.Size(132, 22)
        Me.txtRut.TabIndex = 36
        '
        'frmRevisarRegistros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1227, 557)
        Me.Controls.Add(Me.chkRut)
        Me.Controls.Add(Me.txtRut)
        Me.Controls.Add(Me.chkId)
        Me.Controls.Add(Me.chkRangoFechas)
        Me.Controls.Add(Me.dtgRegistros)
        Me.Controls.Add(Me.dtpHasta)
        Me.Controls.Add(Me.dtpDesde)
        Me.Controls.Add(Me.cbCRM)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.cbEstado)
        Me.Name = "frmRevisarRegistros"
        Me.Text = "frmRevisarRegistros"
        CType(Me.dtgRegistros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbCRM As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnCerrar As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents cbEstado As ComboBox
    Friend WithEvents dtpDesde As DateTimePicker
    Friend WithEvents dtpHasta As DateTimePicker
    Friend WithEvents dtgRegistros As DataGridView
    Friend WithEvents chkRangoFechas As CheckBox
    Friend WithEvents chkId As CheckBox
    Friend WithEvents chkRut As CheckBox
    Friend WithEvents txtRut As TextBox
End Class
