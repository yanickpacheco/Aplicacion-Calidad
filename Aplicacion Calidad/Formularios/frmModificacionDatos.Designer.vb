<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModificacionDatos
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
        Me.components = New System.ComponentModel.Container()
        Me.tbcDatos = New System.Windows.Forms.TabControl()
        Me.tbpTitular = New System.Windows.Forms.TabPage()
        Me.gpbTitularDatos = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDv = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtRut = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPaterno = New System.Windows.Forms.TextBox()
        Me.cmbCiudad = New System.Windows.Forms.ComboBox()
        Me.txtMaterno = New System.Windows.Forms.TextBox()
        Me.cmbComuna = New System.Windows.Forms.ComboBox()
        Me.txtNum = New System.Windows.Forms.TextBox()
        Me.txtRef = New System.Windows.Forms.TextBox()
        Me.dtpFecNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.gpbTitularOtros = New System.Windows.Forms.GroupBox()
        Me.txtNombrePagador = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtDvPagador = New System.Windows.Forms.TextBox()
        Me.txtRutPagador = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSuministro = New System.Windows.Forms.TextBox()
        Me.lblSuministro = New System.Windows.Forms.Label()
        Me.btnActualizarT = New System.Windows.Forms.Button()
        Me.tbpAdicional = New System.Windows.Forms.TabPage()
        Me.btnActualizaA = New System.Windows.Forms.Button()
        Me.dtgAdicionales = New System.Windows.Forms.DataGridView()
        Me.seleccione = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Nro_Adicional = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rutAdicional = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dvAdicional = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombreAdicional = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.paternoAdicional = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.maternoAdicional = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaNacimientoAdicional = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idParentescoAdicional = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombreParentesco = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pesoAdicional = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estaturaAdicional = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sistemaSaludAdicional = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gbpAdicionalOtros = New System.Windows.Forms.GroupBox()
        Me.cmbSistemaSaludAdicional = New System.Windows.Forms.ComboBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtPesoAdicional = New System.Windows.Forms.TextBox()
        Me.txtEstaturaAdicional = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.gpbAdicionalDatos = New System.Windows.Forms.GroupBox()
        Me.txtNroAdicional = New System.Windows.Forms.TextBox()
        Me.cmbTipoAdicional = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtDvAdicional = New System.Windows.Forms.TextBox()
        Me.txtRutAdicional = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dtpFechaAdicional = New System.Windows.Forms.DateTimePicker()
        Me.txtMaternoAdicional = New System.Windows.Forms.TextBox()
        Me.txtPaternoAdicional = New System.Windows.Forms.TextBox()
        Me.txtNombreAdicional = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.tbpBeneficiario = New System.Windows.Forms.TabPage()
        Me.dtgBeneficiario = New System.Windows.Forms.DataGridView()
        Me.seleccioneBenef = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.nroBeneficario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rutBeneficiario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dvBeneficiario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombreBeneficiario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.paternoBeneficiario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.maternoBeneficiario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaNacimientoBeneficiario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idParentescoBeneficiario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.parentescoBeneficiario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pesoBeneficiario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estaturaBeneficiario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sistemaSaludBeneficiario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gpbBeneficiarioOtros = New System.Windows.Forms.GroupBox()
        Me.txtNroBeneficiario = New System.Windows.Forms.TextBox()
        Me.cmbTipoBeneficiario = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtDvBenef = New System.Windows.Forms.TextBox()
        Me.txtRutBef = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.dtpFechaNacimientoBenef = New System.Windows.Forms.DateTimePicker()
        Me.txtMaternoBenef = New System.Windows.Forms.TextBox()
        Me.txtPaternoBenef = New System.Windows.Forms.TextBox()
        Me.txtNombreBenef = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.btnActualizarB = New System.Windows.Forms.Button()
        Me.tbpPolizas = New System.Windows.Forms.TabPage()
        Me.btnActualizarP = New System.Windows.Forms.Button()
        Me.gpbDatosPolizas = New System.Windows.Forms.GroupBox()
        Me.txtIdPoliza = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.cmbSistemaSaludPoliza = New System.Windows.Forms.ComboBox()
        Me.txtEstaturaPoliza = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txtPesoPoliza = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtDvPoliza = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtRutPoliza = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtNombrePoliza = New System.Windows.Forms.TextBox()
        Me.txtEmailPoliza = New System.Windows.Forms.TextBox()
        Me.txtDireccionPoliza = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtPaternoPoliza = New System.Windows.Forms.TextBox()
        Me.txtMaternoPoliza = New System.Windows.Forms.TextBox()
        Me.cmbComunaPoliza = New System.Windows.Forms.ComboBox()
        Me.txtNroPoliza = New System.Windows.Forms.TextBox()
        Me.txtReferenciaPoliza = New System.Windows.Forms.TextBox()
        Me.dtpFechaNacimientoPoliza = New System.Windows.Forms.DateTimePicker()
        Me.dtgPolizas = New System.Windows.Forms.DataGridView()
        Me.seleccionePoliza = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.idPoliza = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rutPoliza = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dvPoliza = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombrePoliza = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.paternoPoliza = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.maternoPoliza = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaNacimientoPoliza = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.emailPoliza = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sistemaSaludPoliza = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pesoPoliza = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estaturaPoliza = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.callePoliza = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numeroPoliza = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.referenciaPoliza = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.comunaPoliza = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetEncuestas = New Aplicacion_Calidad.DataSetEncuestas()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbCRM = New System.Windows.Forms.ComboBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.ContactosTableAdapter = New Aplicacion_Calidad.DataSetEncuestasTableAdapters.ContactosTableAdapter()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.tbcDatos.SuspendLayout()
        Me.tbpTitular.SuspendLayout()
        Me.gpbTitularDatos.SuspendLayout()
        Me.gpbTitularOtros.SuspendLayout()
        Me.tbpAdicional.SuspendLayout()
        CType(Me.dtgAdicionales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbpAdicionalOtros.SuspendLayout()
        Me.gpbAdicionalDatos.SuspendLayout()
        Me.tbpBeneficiario.SuspendLayout()
        CType(Me.dtgBeneficiario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbBeneficiarioOtros.SuspendLayout()
        Me.tbpPolizas.SuspendLayout()
        Me.gpbDatosPolizas.SuspendLayout()
        CType(Me.dtgPolizas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContactosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetEncuestas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbcDatos
        '
        Me.tbcDatos.Controls.Add(Me.tbpTitular)
        Me.tbcDatos.Controls.Add(Me.tbpAdicional)
        Me.tbcDatos.Controls.Add(Me.tbpBeneficiario)
        Me.tbcDatos.Controls.Add(Me.tbpPolizas)
        Me.tbcDatos.Location = New System.Drawing.Point(12, 96)
        Me.tbcDatos.Name = "tbcDatos"
        Me.tbcDatos.SelectedIndex = 0
        Me.tbcDatos.Size = New System.Drawing.Size(845, 504)
        Me.tbcDatos.TabIndex = 4
        '
        'tbpTitular
        '
        Me.tbpTitular.Controls.Add(Me.gpbTitularDatos)
        Me.tbpTitular.Controls.Add(Me.gpbTitularOtros)
        Me.tbpTitular.Controls.Add(Me.btnActualizarT)
        Me.tbpTitular.Location = New System.Drawing.Point(4, 22)
        Me.tbpTitular.Name = "tbpTitular"
        Me.tbpTitular.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpTitular.Size = New System.Drawing.Size(837, 478)
        Me.tbpTitular.TabIndex = 0
        Me.tbpTitular.Text = "Titular"
        Me.tbpTitular.UseVisualStyleBackColor = True
        '
        'gpbTitularDatos
        '
        Me.gpbTitularDatos.Controls.Add(Me.Label2)
        Me.gpbTitularDatos.Controls.Add(Me.Label3)
        Me.gpbTitularDatos.Controls.Add(Me.txtDv)
        Me.gpbTitularDatos.Controls.Add(Me.Label4)
        Me.gpbTitularDatos.Controls.Add(Me.txtRut)
        Me.gpbTitularDatos.Controls.Add(Me.Label5)
        Me.gpbTitularDatos.Controls.Add(Me.Label1)
        Me.gpbTitularDatos.Controls.Add(Me.txtNombre)
        Me.gpbTitularDatos.Controls.Add(Me.txtEmail)
        Me.gpbTitularDatos.Controls.Add(Me.txtDireccion)
        Me.gpbTitularDatos.Controls.Add(Me.Label9)
        Me.gpbTitularDatos.Controls.Add(Me.txtPaterno)
        Me.gpbTitularDatos.Controls.Add(Me.cmbCiudad)
        Me.gpbTitularDatos.Controls.Add(Me.txtMaterno)
        Me.gpbTitularDatos.Controls.Add(Me.cmbComuna)
        Me.gpbTitularDatos.Controls.Add(Me.txtNum)
        Me.gpbTitularDatos.Controls.Add(Me.txtRef)
        Me.gpbTitularDatos.Controls.Add(Me.dtpFecNacimiento)
        Me.gpbTitularDatos.Location = New System.Drawing.Point(16, 6)
        Me.gpbTitularDatos.Name = "gpbTitularDatos"
        Me.gpbTitularDatos.Size = New System.Drawing.Size(801, 256)
        Me.gpbTitularDatos.TabIndex = 52
        Me.gpbTitularDatos.TabStop = False
        Me.gpbTitularDatos.Text = "Datos Venta Titular"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(64, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 17)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 17)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Fecha Nacimiento"
        '
        'txtDv
        '
        Me.txtDv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDv.Location = New System.Drawing.Point(227, 53)
        Me.txtDv.Name = "txtDv"
        Me.txtDv.ReadOnly = True
        Me.txtDv.Size = New System.Drawing.Size(22, 23)
        Me.txtDv.TabIndex = 50
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(55, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 17)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Direccion"
        '
        'txtRut
        '
        Me.txtRut.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRut.Location = New System.Drawing.Point(135, 53)
        Me.txtRut.Name = "txtRut"
        Me.txtRut.Size = New System.Drawing.Size(86, 23)
        Me.txtRut.TabIndex = 49
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(62, 166)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 17)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Comuna"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(94, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 17)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Rut"
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(135, 19)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(245, 23)
        Me.txtNombre.TabIndex = 32
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(135, 202)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(270, 23)
        Me.txtEmail.TabIndex = 47
        '
        'txtDireccion
        '
        Me.txtDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.Location = New System.Drawing.Point(135, 126)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(229, 23)
        Me.txtDireccion.TabIndex = 33
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(80, 205)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 17)
        Me.Label9.TabIndex = 46
        Me.Label9.Text = "Email"
        '
        'txtPaterno
        '
        Me.txtPaterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPaterno.Location = New System.Drawing.Point(386, 19)
        Me.txtPaterno.Name = "txtPaterno"
        Me.txtPaterno.Size = New System.Drawing.Size(151, 23)
        Me.txtPaterno.TabIndex = 34
        '
        'cmbCiudad
        '
        Me.cmbCiudad.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCiudad.FormattingEnabled = True
        Me.cmbCiudad.Location = New System.Drawing.Point(284, 163)
        Me.cmbCiudad.Name = "cmbCiudad"
        Me.cmbCiudad.Size = New System.Drawing.Size(121, 24)
        Me.cmbCiudad.TabIndex = 41
        '
        'txtMaterno
        '
        Me.txtMaterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaterno.Location = New System.Drawing.Point(543, 19)
        Me.txtMaterno.Name = "txtMaterno"
        Me.txtMaterno.Size = New System.Drawing.Size(137, 23)
        Me.txtMaterno.TabIndex = 35
        '
        'cmbComuna
        '
        Me.cmbComuna.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbComuna.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbComuna.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbComuna.Location = New System.Drawing.Point(135, 163)
        Me.cmbComuna.Name = "cmbComuna"
        Me.cmbComuna.Size = New System.Drawing.Size(121, 24)
        Me.cmbComuna.TabIndex = 40
        '
        'txtNum
        '
        Me.txtNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNum.Location = New System.Drawing.Point(373, 126)
        Me.txtNum.Name = "txtNum"
        Me.txtNum.Size = New System.Drawing.Size(50, 23)
        Me.txtNum.TabIndex = 36
        '
        'txtRef
        '
        Me.txtRef.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRef.Location = New System.Drawing.Point(435, 126)
        Me.txtRef.Name = "txtRef"
        Me.txtRef.Size = New System.Drawing.Size(245, 23)
        Me.txtRef.TabIndex = 37
        '
        'dtpFecNacimiento
        '
        Me.dtpFecNacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecNacimiento.Location = New System.Drawing.Point(135, 86)
        Me.dtpFecNacimiento.Name = "dtpFecNacimiento"
        Me.dtpFecNacimiento.Size = New System.Drawing.Size(114, 23)
        Me.dtpFecNacimiento.TabIndex = 38
        '
        'gpbTitularOtros
        '
        Me.gpbTitularOtros.Controls.Add(Me.txtNombrePagador)
        Me.gpbTitularOtros.Controls.Add(Me.Label10)
        Me.gpbTitularOtros.Controls.Add(Me.txtDvPagador)
        Me.gpbTitularOtros.Controls.Add(Me.txtRutPagador)
        Me.gpbTitularOtros.Controls.Add(Me.Label6)
        Me.gpbTitularOtros.Controls.Add(Me.txtSuministro)
        Me.gpbTitularOtros.Controls.Add(Me.lblSuministro)
        Me.gpbTitularOtros.Location = New System.Drawing.Point(16, 268)
        Me.gpbTitularOtros.Name = "gpbTitularOtros"
        Me.gpbTitularOtros.Size = New System.Drawing.Size(801, 141)
        Me.gpbTitularOtros.TabIndex = 51
        Me.gpbTitularOtros.TabStop = False
        Me.gpbTitularOtros.Text = "Otros Datos"
        '
        'txtNombrePagador
        '
        Me.txtNombrePagador.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombrePagador.Location = New System.Drawing.Point(410, 70)
        Me.txtNombrePagador.Name = "txtNombrePagador"
        Me.txtNombrePagador.Size = New System.Drawing.Size(214, 23)
        Me.txtNombrePagador.TabIndex = 53
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(288, 73)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(116, 17)
        Me.Label10.TabIndex = 52
        Me.Label10.Text = "Nombre Pagador"
        '
        'txtDvPagador
        '
        Me.txtDvPagador.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDvPagador.Location = New System.Drawing.Point(228, 70)
        Me.txtDvPagador.Name = "txtDvPagador"
        Me.txtDvPagador.ReadOnly = True
        Me.txtDvPagador.Size = New System.Drawing.Size(22, 23)
        Me.txtDvPagador.TabIndex = 51
        '
        'txtRutPagador
        '
        Me.txtRutPagador.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRutPagador.Location = New System.Drawing.Point(119, 70)
        Me.txtRutPagador.Name = "txtRutPagador"
        Me.txtRutPagador.Size = New System.Drawing.Size(105, 23)
        Me.txtRutPagador.TabIndex = 47
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 73)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 17)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "Rut Pagador"
        '
        'txtSuministro
        '
        Me.txtSuministro.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSuministro.Location = New System.Drawing.Point(119, 31)
        Me.txtSuministro.Name = "txtSuministro"
        Me.txtSuministro.Size = New System.Drawing.Size(131, 23)
        Me.txtSuministro.TabIndex = 45
        '
        'lblSuministro
        '
        Me.lblSuministro.AutoSize = True
        Me.lblSuministro.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSuministro.Location = New System.Drawing.Point(12, 34)
        Me.lblSuministro.Name = "lblSuministro"
        Me.lblSuministro.Size = New System.Drawing.Size(94, 17)
        Me.lblSuministro.TabIndex = 44
        Me.lblSuministro.Text = "N° Suministro"
        '
        'btnActualizarT
        '
        Me.btnActualizarT.Font = New System.Drawing.Font("Consolas", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizarT.Image = Global.Aplicacion_Calidad.My.Resources.Resources._036_edit___copia
        Me.btnActualizarT.Location = New System.Drawing.Point(332, 415)
        Me.btnActualizarT.Name = "btnActualizarT"
        Me.btnActualizarT.Size = New System.Drawing.Size(151, 53)
        Me.btnActualizarT.TabIndex = 39
        Me.btnActualizarT.Text = "Actualizar"
        Me.btnActualizarT.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnActualizarT.UseVisualStyleBackColor = True
        '
        'tbpAdicional
        '
        Me.tbpAdicional.Controls.Add(Me.btnActualizaA)
        Me.tbpAdicional.Controls.Add(Me.dtgAdicionales)
        Me.tbpAdicional.Controls.Add(Me.gbpAdicionalOtros)
        Me.tbpAdicional.Controls.Add(Me.gpbAdicionalDatos)
        Me.tbpAdicional.Location = New System.Drawing.Point(4, 22)
        Me.tbpAdicional.Name = "tbpAdicional"
        Me.tbpAdicional.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpAdicional.Size = New System.Drawing.Size(837, 478)
        Me.tbpAdicional.TabIndex = 1
        Me.tbpAdicional.Text = "Adicional"
        Me.tbpAdicional.UseVisualStyleBackColor = True
        '
        'btnActualizaA
        '
        Me.btnActualizaA.Font = New System.Drawing.Font("Consolas", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizaA.Image = Global.Aplicacion_Calidad.My.Resources.Resources._036_edit___copia
        Me.btnActualizaA.Location = New System.Drawing.Point(334, 415)
        Me.btnActualizaA.Name = "btnActualizaA"
        Me.btnActualizaA.Size = New System.Drawing.Size(151, 53)
        Me.btnActualizaA.TabIndex = 66
        Me.btnActualizaA.Text = "Actualizar"
        Me.btnActualizaA.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnActualizaA.UseVisualStyleBackColor = True
        '
        'dtgAdicionales
        '
        Me.dtgAdicionales.AllowUserToAddRows = False
        Me.dtgAdicionales.AllowUserToDeleteRows = False
        Me.dtgAdicionales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgAdicionales.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.seleccione, Me.Nro_Adicional, Me.rutAdicional, Me.dvAdicional, Me.nombreAdicional, Me.paternoAdicional, Me.maternoAdicional, Me.fechaNacimientoAdicional, Me.idParentescoAdicional, Me.nombreParentesco, Me.pesoAdicional, Me.estaturaAdicional, Me.sistemaSaludAdicional})
        Me.dtgAdicionales.Location = New System.Drawing.Point(16, 6)
        Me.dtgAdicionales.Name = "dtgAdicionales"
        Me.dtgAdicionales.RowHeadersVisible = False
        Me.dtgAdicionales.Size = New System.Drawing.Size(791, 128)
        Me.dtgAdicionales.TabIndex = 65
        '
        'seleccione
        '
        Me.seleccione.HeaderText = "Seleccione"
        Me.seleccione.Name = "seleccione"
        Me.seleccione.ReadOnly = True
        '
        'Nro_Adicional
        '
        Me.Nro_Adicional.DataPropertyName = "A_NRO"
        Me.Nro_Adicional.HeaderText = "Nro"
        Me.Nro_Adicional.Name = "Nro_Adicional"
        Me.Nro_Adicional.ReadOnly = True
        Me.Nro_Adicional.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Nro_Adicional.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'rutAdicional
        '
        Me.rutAdicional.DataPropertyName = "RUT_ADICIONAL"
        Me.rutAdicional.HeaderText = "Rut Adicional"
        Me.rutAdicional.Name = "rutAdicional"
        Me.rutAdicional.ReadOnly = True
        '
        'dvAdicional
        '
        Me.dvAdicional.DataPropertyName = "DV_ADICIONAL"
        Me.dvAdicional.HeaderText = "Dv Adicional"
        Me.dvAdicional.Name = "dvAdicional"
        Me.dvAdicional.ReadOnly = True
        '
        'nombreAdicional
        '
        Me.nombreAdicional.DataPropertyName = "NOMBRE_ADICIONAL"
        Me.nombreAdicional.HeaderText = "Nombre"
        Me.nombreAdicional.Name = "nombreAdicional"
        Me.nombreAdicional.ReadOnly = True
        '
        'paternoAdicional
        '
        Me.paternoAdicional.DataPropertyName = "PATERNO_ADICIONAL"
        Me.paternoAdicional.HeaderText = "Paterno"
        Me.paternoAdicional.Name = "paternoAdicional"
        Me.paternoAdicional.ReadOnly = True
        '
        'maternoAdicional
        '
        Me.maternoAdicional.DataPropertyName = "MATERNO_ADICIONAL"
        Me.maternoAdicional.HeaderText = "Materno"
        Me.maternoAdicional.Name = "maternoAdicional"
        Me.maternoAdicional.ReadOnly = True
        '
        'fechaNacimientoAdicional
        '
        Me.fechaNacimientoAdicional.DataPropertyName = "FECHANACIMIENTO_ADICIONAL"
        Me.fechaNacimientoAdicional.HeaderText = "Fecha Nacimiento"
        Me.fechaNacimientoAdicional.Name = "fechaNacimientoAdicional"
        Me.fechaNacimientoAdicional.ReadOnly = True
        '
        'idParentescoAdicional
        '
        Me.idParentescoAdicional.DataPropertyName = "IDPARENTESCO"
        Me.idParentescoAdicional.HeaderText = "Id Parentesco"
        Me.idParentescoAdicional.Name = "idParentescoAdicional"
        Me.idParentescoAdicional.ReadOnly = True
        '
        'nombreParentesco
        '
        Me.nombreParentesco.DataPropertyName = "NOMBRE_PARENTESCO"
        Me.nombreParentesco.HeaderText = "Parentesco"
        Me.nombreParentesco.Name = "nombreParentesco"
        Me.nombreParentesco.ReadOnly = True
        '
        'pesoAdicional
        '
        Me.pesoAdicional.DataPropertyName = "PESO_ADICIONAL"
        Me.pesoAdicional.HeaderText = "Peso"
        Me.pesoAdicional.Name = "pesoAdicional"
        Me.pesoAdicional.ReadOnly = True
        '
        'estaturaAdicional
        '
        Me.estaturaAdicional.DataPropertyName = "ESTATURA_ADICIONAL"
        Me.estaturaAdicional.HeaderText = "Estatura"
        Me.estaturaAdicional.Name = "estaturaAdicional"
        Me.estaturaAdicional.ReadOnly = True
        '
        'sistemaSaludAdicional
        '
        Me.sistemaSaludAdicional.DataPropertyName = "SISTEMA_SALUD_ADICIONAL"
        Me.sistemaSaludAdicional.HeaderText = "Sistema Salud"
        Me.sistemaSaludAdicional.Name = "sistemaSaludAdicional"
        Me.sistemaSaludAdicional.ReadOnly = True
        '
        'gbpAdicionalOtros
        '
        Me.gbpAdicionalOtros.Controls.Add(Me.cmbSistemaSaludAdicional)
        Me.gbpAdicionalOtros.Controls.Add(Me.Label23)
        Me.gbpAdicionalOtros.Controls.Add(Me.txtPesoAdicional)
        Me.gbpAdicionalOtros.Controls.Add(Me.txtEstaturaAdicional)
        Me.gbpAdicionalOtros.Controls.Add(Me.Label14)
        Me.gbpAdicionalOtros.Controls.Add(Me.Label15)
        Me.gbpAdicionalOtros.Location = New System.Drawing.Point(16, 296)
        Me.gbpAdicionalOtros.Name = "gbpAdicionalOtros"
        Me.gbpAdicionalOtros.Size = New System.Drawing.Size(791, 113)
        Me.gbpAdicionalOtros.TabIndex = 64
        Me.gbpAdicionalOtros.TabStop = False
        Me.gbpAdicionalOtros.Text = "Otros Datos"
        '
        'cmbSistemaSaludAdicional
        '
        Me.cmbSistemaSaludAdicional.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSistemaSaludAdicional.FormattingEnabled = True
        Me.cmbSistemaSaludAdicional.Location = New System.Drawing.Point(144, 77)
        Me.cmbSistemaSaludAdicional.Name = "cmbSistemaSaludAdicional"
        Me.cmbSistemaSaludAdicional.Size = New System.Drawing.Size(188, 24)
        Me.cmbSistemaSaludAdicional.TabIndex = 65
        Me.cmbSistemaSaludAdicional.Visible = False
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(35, 80)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(98, 17)
        Me.Label23.TabIndex = 64
        Me.Label23.Text = "Sistema Salud"
        Me.Label23.Visible = False
        '
        'txtPesoAdicional
        '
        Me.txtPesoAdicional.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPesoAdicional.Location = New System.Drawing.Point(144, 19)
        Me.txtPesoAdicional.Name = "txtPesoAdicional"
        Me.txtPesoAdicional.Size = New System.Drawing.Size(114, 23)
        Me.txtPesoAdicional.TabIndex = 61
        '
        'txtEstaturaAdicional
        '
        Me.txtEstaturaAdicional.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEstaturaAdicional.Location = New System.Drawing.Point(144, 48)
        Me.txtEstaturaAdicional.Name = "txtEstaturaAdicional"
        Me.txtEstaturaAdicional.Size = New System.Drawing.Size(114, 23)
        Me.txtEstaturaAdicional.TabIndex = 63
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(93, 22)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(40, 17)
        Me.Label14.TabIndex = 60
        Me.Label14.Text = "Peso"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(72, 51)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(61, 17)
        Me.Label15.TabIndex = 62
        Me.Label15.Text = "Estatura"
        '
        'gpbAdicionalDatos
        '
        Me.gpbAdicionalDatos.Controls.Add(Me.txtNroAdicional)
        Me.gpbAdicionalDatos.Controls.Add(Me.cmbTipoAdicional)
        Me.gpbAdicionalDatos.Controls.Add(Me.Label22)
        Me.gpbAdicionalDatos.Controls.Add(Me.txtDvAdicional)
        Me.gpbAdicionalDatos.Controls.Add(Me.txtRutAdicional)
        Me.gpbAdicionalDatos.Controls.Add(Me.Label11)
        Me.gpbAdicionalDatos.Controls.Add(Me.dtpFechaAdicional)
        Me.gpbAdicionalDatos.Controls.Add(Me.txtMaternoAdicional)
        Me.gpbAdicionalDatos.Controls.Add(Me.txtPaternoAdicional)
        Me.gpbAdicionalDatos.Controls.Add(Me.txtNombreAdicional)
        Me.gpbAdicionalDatos.Controls.Add(Me.Label12)
        Me.gpbAdicionalDatos.Controls.Add(Me.Label13)
        Me.gpbAdicionalDatos.Location = New System.Drawing.Point(16, 140)
        Me.gpbAdicionalDatos.Name = "gpbAdicionalDatos"
        Me.gpbAdicionalDatos.Size = New System.Drawing.Size(791, 150)
        Me.gpbAdicionalDatos.TabIndex = 0
        Me.gpbAdicionalDatos.TabStop = False
        Me.gpbAdicionalDatos.Text = "Datos Adicionales"
        '
        'txtNroAdicional
        '
        Me.txtNroAdicional.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroAdicional.Location = New System.Drawing.Point(747, 115)
        Me.txtNroAdicional.Name = "txtNroAdicional"
        Me.txtNroAdicional.Size = New System.Drawing.Size(26, 23)
        Me.txtNroAdicional.TabIndex = 64
        Me.txtNroAdicional.Visible = False
        '
        'cmbTipoAdicional
        '
        Me.cmbTipoAdicional.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoAdicional.FormattingEnabled = True
        Me.cmbTipoAdicional.Location = New System.Drawing.Point(144, 115)
        Me.cmbTipoAdicional.Name = "cmbTipoAdicional"
        Me.cmbTipoAdicional.Size = New System.Drawing.Size(188, 24)
        Me.cmbTipoAdicional.TabIndex = 63
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(36, 118)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(97, 17)
        Me.Label22.TabIndex = 62
        Me.Label22.Text = "Tipo Adicional"
        '
        'txtDvAdicional
        '
        Me.txtDvAdicional.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDvAdicional.Location = New System.Drawing.Point(236, 53)
        Me.txtDvAdicional.Name = "txtDvAdicional"
        Me.txtDvAdicional.ReadOnly = True
        Me.txtDvAdicional.Size = New System.Drawing.Size(22, 23)
        Me.txtDvAdicional.TabIndex = 59
        '
        'txtRutAdicional
        '
        Me.txtRutAdicional.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRutAdicional.Location = New System.Drawing.Point(144, 53)
        Me.txtRutAdicional.Name = "txtRutAdicional"
        Me.txtRutAdicional.Size = New System.Drawing.Size(86, 23)
        Me.txtRutAdicional.TabIndex = 58
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(103, 53)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(30, 17)
        Me.Label11.TabIndex = 57
        Me.Label11.Text = "Rut"
        '
        'dtpFechaAdicional
        '
        Me.dtpFechaAdicional.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaAdicional.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaAdicional.Location = New System.Drawing.Point(144, 86)
        Me.dtpFechaAdicional.Name = "dtpFechaAdicional"
        Me.dtpFechaAdicional.Size = New System.Drawing.Size(114, 23)
        Me.dtpFechaAdicional.TabIndex = 56
        '
        'txtMaternoAdicional
        '
        Me.txtMaternoAdicional.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaternoAdicional.Location = New System.Drawing.Point(556, 19)
        Me.txtMaternoAdicional.Name = "txtMaternoAdicional"
        Me.txtMaternoAdicional.Size = New System.Drawing.Size(137, 23)
        Me.txtMaternoAdicional.TabIndex = 55
        '
        'txtPaternoAdicional
        '
        Me.txtPaternoAdicional.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPaternoAdicional.Location = New System.Drawing.Point(399, 19)
        Me.txtPaternoAdicional.Name = "txtPaternoAdicional"
        Me.txtPaternoAdicional.Size = New System.Drawing.Size(151, 23)
        Me.txtPaternoAdicional.TabIndex = 54
        '
        'txtNombreAdicional
        '
        Me.txtNombreAdicional.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreAdicional.Location = New System.Drawing.Point(144, 19)
        Me.txtNombreAdicional.Name = "txtNombreAdicional"
        Me.txtNombreAdicional.Size = New System.Drawing.Size(249, 23)
        Me.txtNombreAdicional.TabIndex = 53
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(12, 88)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(121, 17)
        Me.Label12.TabIndex = 52
        Me.Label12.Text = "Fecha Nacimiento"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(75, 19)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(58, 17)
        Me.Label13.TabIndex = 51
        Me.Label13.Text = "Nombre"
        '
        'tbpBeneficiario
        '
        Me.tbpBeneficiario.Controls.Add(Me.dtgBeneficiario)
        Me.tbpBeneficiario.Controls.Add(Me.gpbBeneficiarioOtros)
        Me.tbpBeneficiario.Controls.Add(Me.btnActualizarB)
        Me.tbpBeneficiario.Location = New System.Drawing.Point(4, 22)
        Me.tbpBeneficiario.Name = "tbpBeneficiario"
        Me.tbpBeneficiario.Size = New System.Drawing.Size(837, 478)
        Me.tbpBeneficiario.TabIndex = 2
        Me.tbpBeneficiario.Text = "Beneficiario"
        Me.tbpBeneficiario.UseVisualStyleBackColor = True
        '
        'dtgBeneficiario
        '
        Me.dtgBeneficiario.AllowUserToAddRows = False
        Me.dtgBeneficiario.AllowUserToDeleteRows = False
        Me.dtgBeneficiario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgBeneficiario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.seleccioneBenef, Me.nroBeneficario, Me.rutBeneficiario, Me.dvBeneficiario, Me.nombreBeneficiario, Me.paternoBeneficiario, Me.maternoBeneficiario, Me.fechaNacimientoBeneficiario, Me.idParentescoBeneficiario, Me.parentescoBeneficiario, Me.pesoBeneficiario, Me.estaturaBeneficiario, Me.sistemaSaludBeneficiario})
        Me.dtgBeneficiario.Location = New System.Drawing.Point(17, 9)
        Me.dtgBeneficiario.Name = "dtgBeneficiario"
        Me.dtgBeneficiario.ReadOnly = True
        Me.dtgBeneficiario.RowHeadersVisible = False
        Me.dtgBeneficiario.Size = New System.Drawing.Size(791, 128)
        Me.dtgBeneficiario.TabIndex = 68
        '
        'seleccioneBenef
        '
        Me.seleccioneBenef.HeaderText = "Seleccione"
        Me.seleccioneBenef.Name = "seleccioneBenef"
        Me.seleccioneBenef.ReadOnly = True
        '
        'nroBeneficario
        '
        Me.nroBeneficario.DataPropertyName = "A_NRO"
        Me.nroBeneficario.HeaderText = "Nro"
        Me.nroBeneficario.Name = "nroBeneficario"
        Me.nroBeneficario.ReadOnly = True
        Me.nroBeneficario.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.nroBeneficario.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'rutBeneficiario
        '
        Me.rutBeneficiario.DataPropertyName = "RUT_BENEFICIARIO"
        Me.rutBeneficiario.HeaderText = "Rut Beneficiario"
        Me.rutBeneficiario.Name = "rutBeneficiario"
        Me.rutBeneficiario.ReadOnly = True
        '
        'dvBeneficiario
        '
        Me.dvBeneficiario.DataPropertyName = "DV_BENEFICIARIO"
        Me.dvBeneficiario.HeaderText = "Dv Adicional"
        Me.dvBeneficiario.Name = "dvBeneficiario"
        Me.dvBeneficiario.ReadOnly = True
        '
        'nombreBeneficiario
        '
        Me.nombreBeneficiario.DataPropertyName = "NOMBRE_BENEFICIARIO"
        Me.nombreBeneficiario.HeaderText = "Nombre"
        Me.nombreBeneficiario.Name = "nombreBeneficiario"
        Me.nombreBeneficiario.ReadOnly = True
        '
        'paternoBeneficiario
        '
        Me.paternoBeneficiario.DataPropertyName = "PATERNO_BENEFICIARIO"
        Me.paternoBeneficiario.HeaderText = "Paterno"
        Me.paternoBeneficiario.Name = "paternoBeneficiario"
        Me.paternoBeneficiario.ReadOnly = True
        '
        'maternoBeneficiario
        '
        Me.maternoBeneficiario.DataPropertyName = "MATERNO_BENEFICIARIO"
        Me.maternoBeneficiario.HeaderText = "Materno"
        Me.maternoBeneficiario.Name = "maternoBeneficiario"
        Me.maternoBeneficiario.ReadOnly = True
        '
        'fechaNacimientoBeneficiario
        '
        Me.fechaNacimientoBeneficiario.DataPropertyName = "FECHANACIMIENTO_BENEFICIARIO"
        Me.fechaNacimientoBeneficiario.HeaderText = "Fecha Nacimiento"
        Me.fechaNacimientoBeneficiario.Name = "fechaNacimientoBeneficiario"
        Me.fechaNacimientoBeneficiario.ReadOnly = True
        '
        'idParentescoBeneficiario
        '
        Me.idParentescoBeneficiario.DataPropertyName = "IDPARENTESCO_BENEFICIARIO"
        Me.idParentescoBeneficiario.HeaderText = "Id Parentesco"
        Me.idParentescoBeneficiario.Name = "idParentescoBeneficiario"
        Me.idParentescoBeneficiario.ReadOnly = True
        '
        'parentescoBeneficiario
        '
        Me.parentescoBeneficiario.DataPropertyName = "NOMBRE_PARENTESCO_BENEFICIARIO"
        Me.parentescoBeneficiario.HeaderText = "Parentesco"
        Me.parentescoBeneficiario.Name = "parentescoBeneficiario"
        Me.parentescoBeneficiario.ReadOnly = True
        '
        'pesoBeneficiario
        '
        Me.pesoBeneficiario.DataPropertyName = "PESO_BENEFICIARIO"
        Me.pesoBeneficiario.HeaderText = "Peso"
        Me.pesoBeneficiario.Name = "pesoBeneficiario"
        Me.pesoBeneficiario.ReadOnly = True
        '
        'estaturaBeneficiario
        '
        Me.estaturaBeneficiario.DataPropertyName = "ESTATURA_BENEFICIARIO"
        Me.estaturaBeneficiario.HeaderText = "Estatura"
        Me.estaturaBeneficiario.Name = "estaturaBeneficiario"
        Me.estaturaBeneficiario.ReadOnly = True
        '
        'sistemaSaludBeneficiario
        '
        Me.sistemaSaludBeneficiario.DataPropertyName = "SISTEMA_SALUD_BENEFICIARIO"
        Me.sistemaSaludBeneficiario.HeaderText = "Sistema Salud"
        Me.sistemaSaludBeneficiario.Name = "sistemaSaludBeneficiario"
        Me.sistemaSaludBeneficiario.ReadOnly = True
        '
        'gpbBeneficiarioOtros
        '
        Me.gpbBeneficiarioOtros.Controls.Add(Me.txtNroBeneficiario)
        Me.gpbBeneficiarioOtros.Controls.Add(Me.cmbTipoBeneficiario)
        Me.gpbBeneficiarioOtros.Controls.Add(Me.Label21)
        Me.gpbBeneficiarioOtros.Controls.Add(Me.txtDvBenef)
        Me.gpbBeneficiarioOtros.Controls.Add(Me.txtRutBef)
        Me.gpbBeneficiarioOtros.Controls.Add(Me.Label18)
        Me.gpbBeneficiarioOtros.Controls.Add(Me.dtpFechaNacimientoBenef)
        Me.gpbBeneficiarioOtros.Controls.Add(Me.txtMaternoBenef)
        Me.gpbBeneficiarioOtros.Controls.Add(Me.txtPaternoBenef)
        Me.gpbBeneficiarioOtros.Controls.Add(Me.txtNombreBenef)
        Me.gpbBeneficiarioOtros.Controls.Add(Me.Label19)
        Me.gpbBeneficiarioOtros.Controls.Add(Me.Label20)
        Me.gpbBeneficiarioOtros.Location = New System.Drawing.Point(17, 143)
        Me.gpbBeneficiarioOtros.Name = "gpbBeneficiarioOtros"
        Me.gpbBeneficiarioOtros.Size = New System.Drawing.Size(791, 177)
        Me.gpbBeneficiarioOtros.TabIndex = 1
        Me.gpbBeneficiarioOtros.TabStop = False
        Me.gpbBeneficiarioOtros.Text = "Datos Beneficiarios"
        '
        'txtNroBeneficiario
        '
        Me.txtNroBeneficiario.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroBeneficiario.Location = New System.Drawing.Point(729, 148)
        Me.txtNroBeneficiario.Name = "txtNroBeneficiario"
        Me.txtNroBeneficiario.Size = New System.Drawing.Size(35, 23)
        Me.txtNroBeneficiario.TabIndex = 62
        Me.txtNroBeneficiario.Visible = False
        '
        'cmbTipoBeneficiario
        '
        Me.cmbTipoBeneficiario.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoBeneficiario.FormattingEnabled = True
        Me.cmbTipoBeneficiario.Location = New System.Drawing.Point(144, 132)
        Me.cmbTipoBeneficiario.Name = "cmbTipoBeneficiario"
        Me.cmbTipoBeneficiario.Size = New System.Drawing.Size(188, 24)
        Me.cmbTipoBeneficiario.TabIndex = 61
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(51, 135)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(82, 17)
        Me.Label21.TabIndex = 60
        Me.Label21.Text = "Beneficiario"
        '
        'txtDvBenef
        '
        Me.txtDvBenef.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDvBenef.Location = New System.Drawing.Point(236, 53)
        Me.txtDvBenef.Name = "txtDvBenef"
        Me.txtDvBenef.ReadOnly = True
        Me.txtDvBenef.Size = New System.Drawing.Size(22, 23)
        Me.txtDvBenef.TabIndex = 59
        '
        'txtRutBef
        '
        Me.txtRutBef.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRutBef.Location = New System.Drawing.Point(144, 53)
        Me.txtRutBef.Name = "txtRutBef"
        Me.txtRutBef.Size = New System.Drawing.Size(86, 23)
        Me.txtRutBef.TabIndex = 58
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(100, 56)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(30, 17)
        Me.Label18.TabIndex = 57
        Me.Label18.Text = "Rut"
        '
        'dtpFechaNacimientoBenef
        '
        Me.dtpFechaNacimientoBenef.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaNacimientoBenef.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaNacimientoBenef.Location = New System.Drawing.Point(144, 91)
        Me.dtpFechaNacimientoBenef.Name = "dtpFechaNacimientoBenef"
        Me.dtpFechaNacimientoBenef.Size = New System.Drawing.Size(114, 23)
        Me.dtpFechaNacimientoBenef.TabIndex = 56
        '
        'txtMaternoBenef
        '
        Me.txtMaternoBenef.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaternoBenef.Location = New System.Drawing.Point(575, 19)
        Me.txtMaternoBenef.Name = "txtMaternoBenef"
        Me.txtMaternoBenef.Size = New System.Drawing.Size(137, 23)
        Me.txtMaternoBenef.TabIndex = 55
        '
        'txtPaternoBenef
        '
        Me.txtPaternoBenef.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPaternoBenef.Location = New System.Drawing.Point(418, 19)
        Me.txtPaternoBenef.Name = "txtPaternoBenef"
        Me.txtPaternoBenef.Size = New System.Drawing.Size(151, 23)
        Me.txtPaternoBenef.TabIndex = 54
        '
        'txtNombreBenef
        '
        Me.txtNombreBenef.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreBenef.Location = New System.Drawing.Point(144, 19)
        Me.txtNombreBenef.Name = "txtNombreBenef"
        Me.txtNombreBenef.Size = New System.Drawing.Size(268, 23)
        Me.txtNombreBenef.TabIndex = 53
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(12, 93)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(121, 17)
        Me.Label19.TabIndex = 52
        Me.Label19.Text = "Fecha Nacimiento"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(75, 22)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(58, 17)
        Me.Label20.TabIndex = 51
        Me.Label20.Text = "Nombre"
        '
        'btnActualizarB
        '
        Me.btnActualizarB.Font = New System.Drawing.Font("Consolas", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizarB.Image = Global.Aplicacion_Calidad.My.Resources.Resources._036_edit___copia
        Me.btnActualizarB.Location = New System.Drawing.Point(332, 415)
        Me.btnActualizarB.Name = "btnActualizarB"
        Me.btnActualizarB.Size = New System.Drawing.Size(151, 53)
        Me.btnActualizarB.TabIndex = 67
        Me.btnActualizarB.Text = "Actualizar"
        Me.btnActualizarB.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnActualizarB.UseVisualStyleBackColor = True
        '
        'tbpPolizas
        '
        Me.tbpPolizas.Controls.Add(Me.btnActualizarP)
        Me.tbpPolizas.Controls.Add(Me.gpbDatosPolizas)
        Me.tbpPolizas.Controls.Add(Me.dtgPolizas)
        Me.tbpPolizas.Location = New System.Drawing.Point(4, 22)
        Me.tbpPolizas.Name = "tbpPolizas"
        Me.tbpPolizas.Size = New System.Drawing.Size(837, 478)
        Me.tbpPolizas.TabIndex = 3
        Me.tbpPolizas.Text = "Polizas"
        Me.tbpPolizas.UseVisualStyleBackColor = True
        '
        'btnActualizarP
        '
        Me.btnActualizarP.Font = New System.Drawing.Font("Consolas", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizarP.Image = Global.Aplicacion_Calidad.My.Resources.Resources._036_edit___copia
        Me.btnActualizarP.Location = New System.Drawing.Point(332, 417)
        Me.btnActualizarP.Name = "btnActualizarP"
        Me.btnActualizarP.Size = New System.Drawing.Size(151, 53)
        Me.btnActualizarP.TabIndex = 69
        Me.btnActualizarP.Text = "Actualizar"
        Me.btnActualizarP.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnActualizarP.UseVisualStyleBackColor = True
        '
        'gpbDatosPolizas
        '
        Me.gpbDatosPolizas.Controls.Add(Me.txtIdPoliza)
        Me.gpbDatosPolizas.Controls.Add(Me.Label30)
        Me.gpbDatosPolizas.Controls.Add(Me.cmbSistemaSaludPoliza)
        Me.gpbDatosPolizas.Controls.Add(Me.txtEstaturaPoliza)
        Me.gpbDatosPolizas.Controls.Add(Me.Label29)
        Me.gpbDatosPolizas.Controls.Add(Me.txtPesoPoliza)
        Me.gpbDatosPolizas.Controls.Add(Me.Label28)
        Me.gpbDatosPolizas.Controls.Add(Me.Label16)
        Me.gpbDatosPolizas.Controls.Add(Me.Label17)
        Me.gpbDatosPolizas.Controls.Add(Me.txtDvPoliza)
        Me.gpbDatosPolizas.Controls.Add(Me.Label24)
        Me.gpbDatosPolizas.Controls.Add(Me.txtRutPoliza)
        Me.gpbDatosPolizas.Controls.Add(Me.Label25)
        Me.gpbDatosPolizas.Controls.Add(Me.Label26)
        Me.gpbDatosPolizas.Controls.Add(Me.txtNombrePoliza)
        Me.gpbDatosPolizas.Controls.Add(Me.txtEmailPoliza)
        Me.gpbDatosPolizas.Controls.Add(Me.txtDireccionPoliza)
        Me.gpbDatosPolizas.Controls.Add(Me.Label27)
        Me.gpbDatosPolizas.Controls.Add(Me.txtPaternoPoliza)
        Me.gpbDatosPolizas.Controls.Add(Me.txtMaternoPoliza)
        Me.gpbDatosPolizas.Controls.Add(Me.cmbComunaPoliza)
        Me.gpbDatosPolizas.Controls.Add(Me.txtNroPoliza)
        Me.gpbDatosPolizas.Controls.Add(Me.txtReferenciaPoliza)
        Me.gpbDatosPolizas.Controls.Add(Me.dtpFechaNacimientoPoliza)
        Me.gpbDatosPolizas.Location = New System.Drawing.Point(14, 164)
        Me.gpbDatosPolizas.Name = "gpbDatosPolizas"
        Me.gpbDatosPolizas.Size = New System.Drawing.Size(801, 247)
        Me.gpbDatosPolizas.TabIndex = 68
        Me.gpbDatosPolizas.TabStop = False
        Me.gpbDatosPolizas.Text = "Datos Venta Titular"
        '
        'txtIdPoliza
        '
        Me.txtIdPoliza.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdPoliza.Location = New System.Drawing.Point(760, 210)
        Me.txtIdPoliza.Name = "txtIdPoliza"
        Me.txtIdPoliza.Size = New System.Drawing.Size(35, 23)
        Me.txtIdPoliza.TabIndex = 63
        Me.txtIdPoliza.Visible = False
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(425, 209)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(47, 17)
        Me.Label30.TabIndex = 55
        Me.Label30.Text = "Isapre"
        Me.Label30.Visible = False
        '
        'cmbSistemaSaludPoliza
        '
        Me.cmbSistemaSaludPoliza.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSistemaSaludPoliza.FormattingEnabled = True
        Me.cmbSistemaSaludPoliza.Location = New System.Drawing.Point(489, 206)
        Me.cmbSistemaSaludPoliza.Name = "cmbSistemaSaludPoliza"
        Me.cmbSistemaSaludPoliza.Size = New System.Drawing.Size(146, 24)
        Me.cmbSistemaSaludPoliza.TabIndex = 56
        Me.cmbSistemaSaludPoliza.Visible = False
        '
        'txtEstaturaPoliza
        '
        Me.txtEstaturaPoliza.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEstaturaPoliza.Location = New System.Drawing.Point(316, 207)
        Me.txtEstaturaPoliza.Name = "txtEstaturaPoliza"
        Me.txtEstaturaPoliza.Size = New System.Drawing.Size(75, 23)
        Me.txtEstaturaPoliza.TabIndex = 54
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(249, 210)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(61, 17)
        Me.Label29.TabIndex = 53
        Me.Label29.Text = "Estatura"
        '
        'txtPesoPoliza
        '
        Me.txtPesoPoliza.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPesoPoliza.Location = New System.Drawing.Point(135, 207)
        Me.txtPesoPoliza.Name = "txtPesoPoliza"
        Me.txtPesoPoliza.Size = New System.Drawing.Size(75, 23)
        Me.txtPesoPoliza.TabIndex = 52
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(80, 210)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(40, 17)
        Me.Label28.TabIndex = 51
        Me.Label28.Text = "Peso"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(64, 22)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(58, 17)
        Me.Label16.TabIndex = 28
        Me.Label16.Text = "Nombre"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(3, 88)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(121, 17)
        Me.Label17.TabIndex = 29
        Me.Label17.Text = "Fecha Nacimiento"
        '
        'txtDvPoliza
        '
        Me.txtDvPoliza.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDvPoliza.Location = New System.Drawing.Point(227, 53)
        Me.txtDvPoliza.Name = "txtDvPoliza"
        Me.txtDvPoliza.ReadOnly = True
        Me.txtDvPoliza.Size = New System.Drawing.Size(22, 23)
        Me.txtDvPoliza.TabIndex = 50
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(55, 122)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(67, 17)
        Me.Label24.TabIndex = 30
        Me.Label24.Text = "Direccion"
        '
        'txtRutPoliza
        '
        Me.txtRutPoliza.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRutPoliza.Location = New System.Drawing.Point(135, 53)
        Me.txtRutPoliza.Name = "txtRutPoliza"
        Me.txtRutPoliza.Size = New System.Drawing.Size(86, 23)
        Me.txtRutPoliza.TabIndex = 49
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(62, 151)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(60, 17)
        Me.Label25.TabIndex = 31
        Me.Label25.Text = "Comuna"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(94, 53)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(30, 17)
        Me.Label26.TabIndex = 48
        Me.Label26.Text = "Rut"
        '
        'txtNombrePoliza
        '
        Me.txtNombrePoliza.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombrePoliza.Location = New System.Drawing.Point(135, 19)
        Me.txtNombrePoliza.Name = "txtNombrePoliza"
        Me.txtNombrePoliza.Size = New System.Drawing.Size(267, 23)
        Me.txtNombrePoliza.TabIndex = 32
        '
        'txtEmailPoliza
        '
        Me.txtEmailPoliza.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmailPoliza.Location = New System.Drawing.Point(135, 178)
        Me.txtEmailPoliza.Name = "txtEmailPoliza"
        Me.txtEmailPoliza.Size = New System.Drawing.Size(270, 23)
        Me.txtEmailPoliza.TabIndex = 47
        '
        'txtDireccionPoliza
        '
        Me.txtDireccionPoliza.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccionPoliza.Location = New System.Drawing.Point(135, 119)
        Me.txtDireccionPoliza.Name = "txtDireccionPoliza"
        Me.txtDireccionPoliza.Size = New System.Drawing.Size(229, 23)
        Me.txtDireccionPoliza.TabIndex = 33
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(80, 181)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(42, 17)
        Me.Label27.TabIndex = 46
        Me.Label27.Text = "Email"
        '
        'txtPaternoPoliza
        '
        Me.txtPaternoPoliza.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPaternoPoliza.Location = New System.Drawing.Point(408, 19)
        Me.txtPaternoPoliza.Name = "txtPaternoPoliza"
        Me.txtPaternoPoliza.Size = New System.Drawing.Size(151, 23)
        Me.txtPaternoPoliza.TabIndex = 34
        '
        'txtMaternoPoliza
        '
        Me.txtMaternoPoliza.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaternoPoliza.Location = New System.Drawing.Point(565, 19)
        Me.txtMaternoPoliza.Name = "txtMaternoPoliza"
        Me.txtMaternoPoliza.Size = New System.Drawing.Size(137, 23)
        Me.txtMaternoPoliza.TabIndex = 35
        '
        'cmbComunaPoliza
        '
        Me.cmbComunaPoliza.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbComunaPoliza.FormattingEnabled = True
        Me.cmbComunaPoliza.Location = New System.Drawing.Point(135, 148)
        Me.cmbComunaPoliza.Name = "cmbComunaPoliza"
        Me.cmbComunaPoliza.Size = New System.Drawing.Size(143, 24)
        Me.cmbComunaPoliza.TabIndex = 40
        '
        'txtNroPoliza
        '
        Me.txtNroPoliza.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroPoliza.Location = New System.Drawing.Point(373, 119)
        Me.txtNroPoliza.Name = "txtNroPoliza"
        Me.txtNroPoliza.Size = New System.Drawing.Size(50, 23)
        Me.txtNroPoliza.TabIndex = 36
        '
        'txtReferenciaPoliza
        '
        Me.txtReferenciaPoliza.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReferenciaPoliza.Location = New System.Drawing.Point(435, 119)
        Me.txtReferenciaPoliza.Name = "txtReferenciaPoliza"
        Me.txtReferenciaPoliza.Size = New System.Drawing.Size(245, 23)
        Me.txtReferenciaPoliza.TabIndex = 37
        '
        'dtpFechaNacimientoPoliza
        '
        Me.dtpFechaNacimientoPoliza.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaNacimientoPoliza.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaNacimientoPoliza.Location = New System.Drawing.Point(135, 86)
        Me.dtpFechaNacimientoPoliza.Name = "dtpFechaNacimientoPoliza"
        Me.dtpFechaNacimientoPoliza.Size = New System.Drawing.Size(114, 23)
        Me.dtpFechaNacimientoPoliza.TabIndex = 38
        '
        'dtgPolizas
        '
        Me.dtgPolizas.AllowUserToAddRows = False
        Me.dtgPolizas.AllowUserToDeleteRows = False
        Me.dtgPolizas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgPolizas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.seleccionePoliza, Me.idPoliza, Me.rutPoliza, Me.dvPoliza, Me.nombrePoliza, Me.paternoPoliza, Me.maternoPoliza, Me.fechaNacimientoPoliza, Me.emailPoliza, Me.sistemaSaludPoliza, Me.pesoPoliza, Me.estaturaPoliza, Me.callePoliza, Me.numeroPoliza, Me.referenciaPoliza, Me.comunaPoliza})
        Me.dtgPolizas.Location = New System.Drawing.Point(16, 14)
        Me.dtgPolizas.Name = "dtgPolizas"
        Me.dtgPolizas.ReadOnly = True
        Me.dtgPolizas.RowHeadersVisible = False
        Me.dtgPolizas.Size = New System.Drawing.Size(801, 144)
        Me.dtgPolizas.TabIndex = 67
        '
        'seleccionePoliza
        '
        Me.seleccionePoliza.HeaderText = "Seleccione"
        Me.seleccionePoliza.Name = "seleccionePoliza"
        Me.seleccionePoliza.ReadOnly = True
        '
        'idPoliza
        '
        Me.idPoliza.DataPropertyName = "ID_POLIZA"
        Me.idPoliza.HeaderText = "Id Poliza"
        Me.idPoliza.Name = "idPoliza"
        Me.idPoliza.ReadOnly = True
        '
        'rutPoliza
        '
        Me.rutPoliza.DataPropertyName = "RUT_POLIZA"
        Me.rutPoliza.HeaderText = "Rut"
        Me.rutPoliza.Name = "rutPoliza"
        Me.rutPoliza.ReadOnly = True
        '
        'dvPoliza
        '
        Me.dvPoliza.DataPropertyName = "DV_POLIZA"
        Me.dvPoliza.HeaderText = "Dv"
        Me.dvPoliza.Name = "dvPoliza"
        Me.dvPoliza.ReadOnly = True
        '
        'nombrePoliza
        '
        Me.nombrePoliza.DataPropertyName = "NOMBRE_POLIZA"
        Me.nombrePoliza.HeaderText = "Nombre"
        Me.nombrePoliza.Name = "nombrePoliza"
        Me.nombrePoliza.ReadOnly = True
        '
        'paternoPoliza
        '
        Me.paternoPoliza.DataPropertyName = "PATERNO_POLIZA"
        Me.paternoPoliza.HeaderText = "Paterno"
        Me.paternoPoliza.Name = "paternoPoliza"
        Me.paternoPoliza.ReadOnly = True
        '
        'maternoPoliza
        '
        Me.maternoPoliza.DataPropertyName = "MATERNO_POLIZA"
        Me.maternoPoliza.HeaderText = "Materno"
        Me.maternoPoliza.Name = "maternoPoliza"
        Me.maternoPoliza.ReadOnly = True
        '
        'fechaNacimientoPoliza
        '
        Me.fechaNacimientoPoliza.DataPropertyName = "FECHANACIMIENTO_POLIZA"
        Me.fechaNacimientoPoliza.HeaderText = "Fecha Nacimiento"
        Me.fechaNacimientoPoliza.Name = "fechaNacimientoPoliza"
        Me.fechaNacimientoPoliza.ReadOnly = True
        '
        'emailPoliza
        '
        Me.emailPoliza.DataPropertyName = "EMAIL_POLIZA"
        Me.emailPoliza.HeaderText = "Email"
        Me.emailPoliza.Name = "emailPoliza"
        Me.emailPoliza.ReadOnly = True
        '
        'sistemaSaludPoliza
        '
        Me.sistemaSaludPoliza.DataPropertyName = "SISTEMA_SALUD_POLIZA"
        Me.sistemaSaludPoliza.HeaderText = "Sistema Salud"
        Me.sistemaSaludPoliza.Name = "sistemaSaludPoliza"
        Me.sistemaSaludPoliza.ReadOnly = True
        '
        'pesoPoliza
        '
        Me.pesoPoliza.DataPropertyName = "PESO_POLIZA"
        Me.pesoPoliza.HeaderText = "Peso"
        Me.pesoPoliza.Name = "pesoPoliza"
        Me.pesoPoliza.ReadOnly = True
        '
        'estaturaPoliza
        '
        Me.estaturaPoliza.DataPropertyName = "ESTATURA_POLIZA"
        Me.estaturaPoliza.HeaderText = "Estatura"
        Me.estaturaPoliza.Name = "estaturaPoliza"
        Me.estaturaPoliza.ReadOnly = True
        '
        'callePoliza
        '
        Me.callePoliza.DataPropertyName = "CALLE_POLIZA"
        Me.callePoliza.HeaderText = "Calle"
        Me.callePoliza.Name = "callePoliza"
        Me.callePoliza.ReadOnly = True
        '
        'numeroPoliza
        '
        Me.numeroPoliza.DataPropertyName = "NUMERO_POLIZA"
        Me.numeroPoliza.HeaderText = "Numero"
        Me.numeroPoliza.Name = "numeroPoliza"
        Me.numeroPoliza.ReadOnly = True
        '
        'referenciaPoliza
        '
        Me.referenciaPoliza.DataPropertyName = "REFERENCIA_POLIZA"
        Me.referenciaPoliza.HeaderText = "Referencia"
        Me.referenciaPoliza.Name = "referenciaPoliza"
        Me.referenciaPoliza.ReadOnly = True
        '
        'comunaPoliza
        '
        Me.comunaPoliza.DataPropertyName = "COMUNA_POLIZA"
        Me.comunaPoliza.HeaderText = "Comuna"
        Me.comunaPoliza.Name = "comunaPoliza"
        Me.comunaPoliza.ReadOnly = True
        '
        'ContactosBindingSource
        '
        Me.ContactosBindingSource.DataMember = "Contactos"
        Me.ContactosBindingSource.DataSource = Me.DataSetEncuestas
        '
        'DataSetEncuestas
        '
        Me.DataSetEncuestas.DataSetName = "DataSetEncuestas"
        Me.DataSetEncuestas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(9, 69)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(15, 24)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "!"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(27, 73)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(272, 16)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "Los campos a modificar se destacan en rojo"
        '
        'cmbCRM
        '
        Me.cmbCRM.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCRM.FormattingEnabled = True
        Me.cmbCRM.Location = New System.Drawing.Point(91, 28)
        Me.cmbCRM.Name = "cmbCRM"
        Me.cmbCRM.Size = New System.Drawing.Size(281, 24)
        Me.cmbCRM.TabIndex = 44
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(27, 31)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(38, 17)
        Me.Label31.TabIndex = 57
        Me.Label31.Text = "CRM"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(455, 31)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(21, 17)
        Me.Label32.TabIndex = 58
        Me.Label32.Text = "ID"
        '
        'txtId
        '
        Me.txtId.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId.Location = New System.Drawing.Point(503, 28)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(86, 23)
        Me.txtId.TabIndex = 59
        '
        'ContactosTableAdapter
        '
        Me.ContactosTableAdapter.ClearBeforeFill = True
        '
        'btnVolver
        '
        Me.btnVolver.Font = New System.Drawing.Font("Consolas", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.Image = Global.Aplicacion_Calidad.My.Resources.Resources.Volver
        Me.btnVolver.Location = New System.Drawing.Point(369, 606)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(107, 45)
        Me.btnVolver.TabIndex = 71
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Consolas", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Image = Global.Aplicacion_Calidad.My.Resources.Resources._039_search_Copia
        Me.btnBuscar.Location = New System.Drawing.Point(641, 28)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(115, 50)
        Me.btnBuscar.TabIndex = 70
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'frmModificacionDatos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(869, 659)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.cmbCRM)
        Me.Controls.Add(Me.tbcDatos)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Name = "frmModificacionDatos"
        Me.Text = "Modificacion Datos"
        Me.tbcDatos.ResumeLayout(False)
        Me.tbpTitular.ResumeLayout(False)
        Me.gpbTitularDatos.ResumeLayout(False)
        Me.gpbTitularDatos.PerformLayout()
        Me.gpbTitularOtros.ResumeLayout(False)
        Me.gpbTitularOtros.PerformLayout()
        Me.tbpAdicional.ResumeLayout(False)
        CType(Me.dtgAdicionales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbpAdicionalOtros.ResumeLayout(False)
        Me.gbpAdicionalOtros.PerformLayout()
        Me.gpbAdicionalDatos.ResumeLayout(False)
        Me.gpbAdicionalDatos.PerformLayout()
        Me.tbpBeneficiario.ResumeLayout(False)
        CType(Me.dtgBeneficiario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbBeneficiarioOtros.ResumeLayout(False)
        Me.gpbBeneficiarioOtros.PerformLayout()
        Me.tbpPolizas.ResumeLayout(False)
        Me.gpbDatosPolizas.ResumeLayout(False)
        Me.gpbDatosPolizas.PerformLayout()
        CType(Me.dtgPolizas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContactosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetEncuestas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbcDatos As TabControl
    Friend WithEvents tbpTitular As TabPage
    Friend WithEvents tbpAdicional As TabPage
    Friend WithEvents tbpBeneficiario As TabPage
    Friend WithEvents tbpPolizas As TabPage
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtSuministro As TextBox
    Friend WithEvents lblSuministro As Label
    Friend WithEvents cmbCiudad As ComboBox
    Friend WithEvents cmbComuna As ComboBox
    Friend WithEvents btnActualizarT As Button
    Friend WithEvents dtpFecNacimiento As DateTimePicker
    Friend WithEvents txtRef As TextBox
    Friend WithEvents txtNum As TextBox
    Friend WithEvents txtMaterno As TextBox
    Friend WithEvents txtPaterno As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents gpbTitularOtros As GroupBox
    Friend WithEvents txtNombrePagador As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtDvPagador As TextBox
    Friend WithEvents txtRutPagador As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtDv As TextBox
    Friend WithEvents txtRut As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents gpbTitularDatos As GroupBox
    Friend WithEvents dtgAdicionales As DataGridView
    Friend WithEvents gbpAdicionalOtros As GroupBox
    Friend WithEvents cmbSistemaSaludAdicional As ComboBox
    Friend WithEvents Label23 As Label
    Friend WithEvents txtPesoAdicional As TextBox
    Friend WithEvents txtEstaturaAdicional As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents gpbAdicionalDatos As GroupBox
    Friend WithEvents cmbTipoAdicional As ComboBox
    Friend WithEvents Label22 As Label
    Friend WithEvents txtDvAdicional As TextBox
    Friend WithEvents txtRutAdicional As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents dtpFechaAdicional As DateTimePicker
    Friend WithEvents txtMaternoAdicional As TextBox
    Friend WithEvents txtPaternoAdicional As TextBox
    Friend WithEvents txtNombreAdicional As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents gpbBeneficiarioOtros As GroupBox
    Friend WithEvents cmbTipoBeneficiario As ComboBox
    Friend WithEvents Label21 As Label
    Friend WithEvents txtDvBenef As TextBox
    Friend WithEvents txtRutBef As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents dtpFechaNacimientoBenef As DateTimePicker
    Friend WithEvents txtMaternoBenef As TextBox
    Friend WithEvents txtPaternoBenef As TextBox
    Friend WithEvents txtNombreBenef As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents gpbDatosPolizas As GroupBox
    Friend WithEvents Label30 As Label
    Friend WithEvents cmbSistemaSaludPoliza As ComboBox
    Friend WithEvents txtEstaturaPoliza As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents txtPesoPoliza As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents txtDvPoliza As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents txtRutPoliza As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents txtNombrePoliza As TextBox
    Friend WithEvents txtEmailPoliza As TextBox
    Friend WithEvents txtDireccionPoliza As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents txtPaternoPoliza As TextBox
    Friend WithEvents txtMaternoPoliza As TextBox
    Friend WithEvents cmbComunaPoliza As ComboBox
    Friend WithEvents txtNroPoliza As TextBox
    Friend WithEvents txtReferenciaPoliza As TextBox
    Friend WithEvents dtpFechaNacimientoPoliza As DateTimePicker
    Friend WithEvents dtgPolizas As DataGridView
    Friend WithEvents btnActualizaA As Button
    Friend WithEvents btnActualizarB As Button
    Friend WithEvents btnActualizarP As Button
    Friend WithEvents cmbCRM As ComboBox
    Friend WithEvents Label31 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents dtgBeneficiario As DataGridView
    Friend WithEvents btnBuscar As Button
    Friend WithEvents DataSetEncuestas As DataSetEncuestas
    Friend WithEvents ContactosBindingSource As BindingSource
    Friend WithEvents ContactosTableAdapter As DataSetEncuestasTableAdapters.ContactosTableAdapter
    Friend WithEvents seleccione As DataGridViewCheckBoxColumn
    Friend WithEvents Nro_Adicional As DataGridViewTextBoxColumn
    Friend WithEvents rutAdicional As DataGridViewTextBoxColumn
    Friend WithEvents dvAdicional As DataGridViewTextBoxColumn
    Friend WithEvents nombreAdicional As DataGridViewTextBoxColumn
    Friend WithEvents paternoAdicional As DataGridViewTextBoxColumn
    Friend WithEvents maternoAdicional As DataGridViewTextBoxColumn
    Friend WithEvents fechaNacimientoAdicional As DataGridViewTextBoxColumn
    Friend WithEvents idParentescoAdicional As DataGridViewTextBoxColumn
    Friend WithEvents nombreParentesco As DataGridViewTextBoxColumn
    Friend WithEvents pesoAdicional As DataGridViewTextBoxColumn
    Friend WithEvents estaturaAdicional As DataGridViewTextBoxColumn
    Friend WithEvents sistemaSaludAdicional As DataGridViewTextBoxColumn
    Friend WithEvents txtNroAdicional As TextBox
    Friend WithEvents txtNroBeneficiario As TextBox
    Friend WithEvents txtIdPoliza As TextBox
    Friend WithEvents seleccionePoliza As DataGridViewCheckBoxColumn
    Friend WithEvents idPoliza As DataGridViewTextBoxColumn
    Friend WithEvents rutPoliza As DataGridViewTextBoxColumn
    Friend WithEvents dvPoliza As DataGridViewTextBoxColumn
    Friend WithEvents nombrePoliza As DataGridViewTextBoxColumn
    Friend WithEvents paternoPoliza As DataGridViewTextBoxColumn
    Friend WithEvents maternoPoliza As DataGridViewTextBoxColumn
    Friend WithEvents fechaNacimientoPoliza As DataGridViewTextBoxColumn
    Friend WithEvents emailPoliza As DataGridViewTextBoxColumn
    Friend WithEvents sistemaSaludPoliza As DataGridViewTextBoxColumn
    Friend WithEvents pesoPoliza As DataGridViewTextBoxColumn
    Friend WithEvents estaturaPoliza As DataGridViewTextBoxColumn
    Friend WithEvents callePoliza As DataGridViewTextBoxColumn
    Friend WithEvents numeroPoliza As DataGridViewTextBoxColumn
    Friend WithEvents referenciaPoliza As DataGridViewTextBoxColumn
    Friend WithEvents comunaPoliza As DataGridViewTextBoxColumn
    Friend WithEvents seleccioneBenef As DataGridViewCheckBoxColumn
    Friend WithEvents nroBeneficario As DataGridViewTextBoxColumn
    Friend WithEvents rutBeneficiario As DataGridViewTextBoxColumn
    Friend WithEvents dvBeneficiario As DataGridViewTextBoxColumn
    Friend WithEvents nombreBeneficiario As DataGridViewTextBoxColumn
    Friend WithEvents paternoBeneficiario As DataGridViewTextBoxColumn
    Friend WithEvents maternoBeneficiario As DataGridViewTextBoxColumn
    Friend WithEvents fechaNacimientoBeneficiario As DataGridViewTextBoxColumn
    Friend WithEvents idParentescoBeneficiario As DataGridViewTextBoxColumn
    Friend WithEvents parentescoBeneficiario As DataGridViewTextBoxColumn
    Friend WithEvents pesoBeneficiario As DataGridViewTextBoxColumn
    Friend WithEvents estaturaBeneficiario As DataGridViewTextBoxColumn
    Friend WithEvents sistemaSaludBeneficiario As DataGridViewTextBoxColumn
    Friend WithEvents btnVolver As Button
End Class
