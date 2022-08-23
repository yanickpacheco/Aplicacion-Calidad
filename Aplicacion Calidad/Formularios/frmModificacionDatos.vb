Imports System.Data.SqlClient
Imports ET

Public Class frmModificacionDatos

    Dim cnn As New SqlConnection("data source = 192.168.1.14; initial catalog = CALIDAD; User id= cp; password=Cordial.passs")
    Dim cnn2 As New SqlConnection("data source = 192.168.1.14; initial catalog = BASE_GENERAL_CORDIAL; User id= cp; password=Cordial.passs ")
    Dim idRowIndexAdicional As Integer
    Dim idRowIndexBeneficiario As Integer
    Dim idRowIndexPolizas As Integer


    Private Sub frmModificacionDatos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetEncuestas.Contactos' Puede moverla o quitarla según sea necesario.
        Dim general As New clsGeneral

        LimpiarTabs()
        cargaDatosBase()

        txtId.Text = ""
        cmbCRM.SelectedIndex = -1
        txtId.Enabled = True
        cmbCRM.Enabled = True

        If idActualizacionRegistro <> "" And crmActualizarRegistro >= 0 Then

            txtId.Text = idActualizacionRegistro
            cmbCRM.SelectedValue = crmActualizarRegistro
            buscarDatosCliente(cmbCRM.SelectedValue, txtId.Text)
            txtId.Enabled = False
            cmbCRM.Enabled = False

        End If


        ' general.ListaCampañas(cmbCRM)


    End Sub

    Private Sub cargaDatosBase()

        Dim daComuna As New EtComuna
        Dim daCiudad As New EtCiudad
        Dim daParentesco As New EtParentesco
        Dim campaña As New EtCampaña


        vgListCampañas = campaña.ListaCampañas()
        vgListComuna = daComuna.listarComuna()
        vgListCiudad = daCiudad.ListaCiudad()
        llenaComboBox(cmbCRM, "nombreCRM", "crm", vgListCampañas.ToArray)
        llenaComboBox(cmbComuna, "nombreComuna", "idComuna", vgListComuna.ToArray)
        llenaComboBox(cmbComunaPoliza, "nombreComuna", "idComuna", vgListComuna.ToArray)
        cmbComuna.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cmbComuna.AutoCompleteSource = AutoCompleteSource.ListItems
        cmbComunaPoliza.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cmbComunaPoliza.AutoCompleteSource = AutoCompleteSource.ListItems



        vgListParentescoAdicional = daParentesco.BuscaParentescoPorId(crm, 2)
        llenaComboBox(cmbTipoAdicional, "nombreParentesco", "idParentesco", vgListParentescoAdicional.ToArray)

        vgListParentescoBeneficiario = daParentesco.BuscaParentescoPorId(crm, 1)
        llenaComboBox(cmbTipoBeneficiario, "nombreParentesco", "idParentesco", vgListParentescoBeneficiario.ToArray)

    End Sub

    Private Sub LimpiarTabs()

        Dim i As Integer
        i = tbcDatos.TabCount - 1
        For i = i To 0 Step -1
            tbcDatos.TabPages.Item(i).Parent = Nothing
        Next i

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        If cmbCRM.SelectedIndex < 0 Then
            MsgBox("Debe ingresar CRM de registro a modificar" & vbNewLine, MsgBoxStyle.Critical, "Error")
            cmbCRM.Focus()
            Exit Sub
        End If

        If txtId.Text = "" Then
            MsgBox("Debe ingresar Id de registro a modificar" & vbNewLine, MsgBoxStyle.Critical, "Error")
            txtId.Focus()
            Exit Sub
        End If

        buscarDatosCliente(cmbCRM.SelectedValue, txtId.Text)


    End Sub

    Private Sub buscarDatosCliente(ByVal crm As String, ByVal id As String)

        Dim daParentesco As New EtParentesco

        vgListParentescoAdicional = daParentesco.BuscaParentescoPorId(crm, 2)
        llenaComboBox(cmbTipoAdicional, "nombreParentesco", "idParentesco", vgListParentescoAdicional.ToArray)

        vgListParentescoBeneficiario = daParentesco.BuscaParentescoPorId(crm, 1)
        llenaComboBox(cmbTipoBeneficiario, "nombreParentesco", "idParentesco", vgListParentescoBeneficiario.ToArray)

        Dim Datoscampaña As New EtCampaña
        Datoscampaña = vgListCampañas.Find(Function(tmpC As EtCampaña) tmpC.Crm = crm)

        LimpiarTabs()

        tbcDatos.TabPages.Add(tbpTitular)

        txtNombre.Text = ""
        txtPaterno.Text = ""
        txtMaterno.Text = ""
        txtRut.Text = ""
        txtDv.Text = ""
        txtDireccion.Text = ""
        txtNum.Text = ""
        txtRef.Text = ""
        txtEmail.Text = ""
        txtSuministro.Text = ""
        txtRutPagador.Text = ""
        txtDvPagador.Text = ""
        txtNombrePagador.Text = ""

        BuscaDatosTitular(crm, id)
        If vgListTitular.Count > 0 Then
            If Datoscampaña.ConAdicional = True Then

                BuscaDatosAdicional(crm, id)
                tbcDatos.TabPages.Add(tbpAdicional)

            End If

            If Datoscampaña.ConBeneficiario = True Then
                BuscaDatosBeneficiario(crm, id)
                tbcDatos.TabPages.Add(tbpBeneficiario)

            End If

            If Datoscampaña.ConPolizas = True Then
                BuscaDatosPoliza(crm, id)
                tbcDatos.TabPages.Add(tbpPolizas)
                gpbDatosPolizas.Visible = False
            End If

        Else
            MsgBox("No existen datos de cliente para mostrar", vbExclamation, "CALIDAD")
            LimpiarTabs()
        End If

    End Sub



#Region "BUSCA DATOS"
    Private Sub BuscaDatosTitular(ByVal CRM As String, ByVal Id As String)
        Dim comunaGes As New EtComuna
        Dim CiudadGes As New EtCiudad
        Dim actualizar As New clsActualizar

        vgListTitular = actualizar.buscarDatosTitularModificar(CRM, Id)
        'dtgEvaluaciones.DataSource = tabla

        If vgListTitular Is Nothing Or vgListTitular.Count = 0 Then

            MsgBox("No existen datos de cliente a mostrar", vbInformation, "CALIDAD")
            Exit Sub

        Else

            Dim daComuna As New EtComuna
            vgListComuna = daComuna.listarComuna()
            llenaComboBox(cmbComuna, "nombreComuna", "idComuna", vgListComuna.ToArray)

            txtRut.Text = vgListTitular(0).Rut
            txtDv.Text = vgListTitular(0).Dv
            txtNombre.Text = vgListTitular(0).Nombre
            txtPaterno.Text = vgListTitular(0).Paterno
            txtMaterno.Text = vgListTitular(0).Materno
            dtpFecNacimiento.Value = vgListTitular(0).FechaNacimiento
            txtDireccion.Text = vgListTitular(0).Calle
            txtNum.Text = vgListTitular(0).Numero
            txtRef.Text = vgListTitular(0).Referencia

            comunaGes = vgListComuna.Find(Function(tmpC As EtComuna) tmpC.nombreComuna = vgListTitular(0).Comuna)
            cmbComuna.SelectedValue = comunaGes.idComuna
            CiudadGes = CiudadGes.BuscaCiudadPorIdCiudad(comunaGes.idCiudad)
            vgListCiudad.Add(CiudadGes)
            llenaComboBox(cmbCiudad, "nombreCiudad", "idCiudad", vgListCiudad.ToArray)
            cmbCiudad.SelectedValue = CiudadGes.idCiudad


            txtSuministro.Text = vgListTitular(0).Suministro
            txtEmail.Text = vgListTitular(0).Email
            txtRutPagador.Text = vgListTitular(0).RutPagador
            txtDvPagador.Text = vgListTitular(0).DvPagador
            txtNombrePagador.Text = vgListTitular(0).NombrePagador

        End If


    End Sub


    Private Sub BuscaDatosAdicional(ByVal CRM As String, ByVal Id As String)

        Dim dt As New DataTable

        Dim actualizar As New clsActualizar

        dt = actualizar.buscarDatosAdicionalModificar(CRM, Id)
        'dtgEvaluaciones.DataSource = tabla

        If dt Is Nothing Then
            dtgAdicionales.DataSource = Nothing
        Else
            dtgAdicionales.DataSource = dt
            dtgAdicionales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        End If



        gpbAdicionalDatos.Visible = False
        gbpAdicionalOtros.Visible = False


    End Sub

    Private Sub BuscaDatosBeneficiario(ByVal CRM As String, ByVal Id As String)

        Dim dt As New DataTable

        Dim actualizar As New clsActualizar


        dt = actualizar.buscarDatosBeneficiarioModificar(CRM, Id)
        'dtgEvaluaciones.DataSource = tabla

        If dt Is Nothing Then
            dtgBeneficiario.DataSource = Nothing
        Else
            dtgBeneficiario.DataSource = dt
            dtgBeneficiario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        End If

        gpbBeneficiarioOtros.Visible = False

    End Sub


    Private Sub BuscaDatosPoliza(ByVal CRM As String, ByVal Id As String)

        Dim dt As New DataTable

        Dim actualizar As New clsActualizar

        dt = actualizar.buscarDatosPolizaModificar(CRM, Id)
        'dtgEvaluaciones.DataSource = tabla

        If dt Is Nothing Then
            dtgPolizas.DataSource = Nothing
        Else
            dtgPolizas.DataSource = dt
            dtgPolizas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        End If

        gpbDatosPolizas.Visible = False

    End Sub

#End Region

#Region "EVENTO CLICK GRILLA"
    Private Sub dtgAdicionales_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgAdicionales.CellContentClick
        If e.ColumnIndex <> 0 Then Exit Sub
        Dim row As DataGridViewRow = dtgAdicionales.Rows(e.RowIndex)
        Dim parentesco As New EtParentesco


        If dtgAdicionales.Rows(e.RowIndex).Cells("seleccione").Value = True Then
            dtgAdicionales.Rows(e.RowIndex).Cells("seleccione").Value = False
        Else
            dtgAdicionales.Rows(e.RowIndex).Cells("seleccione").Value = True

            gpbAdicionalDatos.Visible = True
            gbpAdicionalOtros.Visible = True

            idRowIndexAdicional = e.RowIndex

            txtNroAdicional.Text = dtgAdicionales.Rows(e.RowIndex).Cells("Nro_Adicional").Value
            txtNombreAdicional.Text = dtgAdicionales.Rows(e.RowIndex).Cells("nombreAdicional").Value
            txtPaternoAdicional.Text = dtgAdicionales.Rows(e.RowIndex).Cells("paternoAdicional").Value
            txtMaternoAdicional.Text = dtgAdicionales.Rows(e.RowIndex).Cells("maternoAdicional").Value
            txtRutAdicional.Text = dtgAdicionales.Rows(e.RowIndex).Cells("rutAdicional").Value
            txtDvAdicional.Text = dtgAdicionales.Rows(e.RowIndex).Cells("dvAdicional").Value
            dtpFechaAdicional.Value = dtgAdicionales.Rows(e.RowIndex).Cells("fechaNacimientoAdicional").Value

            parentesco = vgListParentescoAdicional.Find(Function(tmpC As EtParentesco) tmpC.IdParentesco = dtgAdicionales.Rows(e.RowIndex).Cells("idParentescoAdicional").Value)
            cmbTipoAdicional.SelectedValue = parentesco.IdParentesco

            txtPesoAdicional.Text = dtgAdicionales.Rows(e.RowIndex).Cells("pesoAdicional").Value
            txtEstaturaAdicional.Text = dtgAdicionales.Rows(e.RowIndex).Cells("estaturaAdicional").Value
            cmbSistemaSaludAdicional.Text = dtgAdicionales.Rows(e.RowIndex).Cells("sistemaSaludAdicional").Value


            For i As Integer = 0 To dtgAdicionales.Rows.Count - 1
                If i <> e.RowIndex Then
                    dtgAdicionales.Rows(i).Cells("seleccione").Value = False
                End If
            Next

        End If
    End Sub



    Private Sub dtgBeneficiario_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgBeneficiario.CellContentClick
        If e.ColumnIndex <> 0 Then Exit Sub
        Dim row As DataGridViewRow = dtgBeneficiario.Rows(e.RowIndex)
        Dim parentesco As New EtParentesco


        If dtgBeneficiario.Rows(e.RowIndex).Cells("seleccioneBenef").Value = True Then
            dtgBeneficiario.Rows(e.RowIndex).Cells("seleccioneBenef").Value = False
            gpbBeneficiarioOtros.Visible = False
        Else
            dtgBeneficiario.Rows(e.RowIndex).Cells("seleccioneBenef").Value = True
            gpbBeneficiarioOtros.Visible = True

            idRowIndexBeneficiario = e.RowIndex

            txtNroBeneficiario.Text = dtgBeneficiario.Rows(e.RowIndex).Cells("nroBeneficario").Value
            txtNombreBenef.Text = dtgBeneficiario.Rows(e.RowIndex).Cells("nombreBeneficiario").Value
            txtPaternoBenef.Text = dtgBeneficiario.Rows(e.RowIndex).Cells("paternoBeneficiario").Value
            txtMaternoBenef.Text = dtgBeneficiario.Rows(e.RowIndex).Cells("maternoBeneficiario").Value
            txtRutBef.Text = dtgBeneficiario.Rows(e.RowIndex).Cells("rutBeneficiario").Value
            txtDvBenef.Text = dtgBeneficiario.Rows(e.RowIndex).Cells("dvBeneficiario").Value
            dtpFechaNacimientoBenef.Value = dtgBeneficiario.Rows(e.RowIndex).Cells("fechaNacimientoBeneficiario").Value

            parentesco = vgListParentescoBeneficiario.Find(Function(tmpC As EtParentesco) tmpC.IdParentesco = dtgBeneficiario.Rows(e.RowIndex).Cells("idParentescoBeneficiario").Value)
            cmbTipoBeneficiario.SelectedValue = parentesco.IdParentesco




            For i As Integer = 0 To dtgBeneficiario.Rows.Count - 1
                If i <> e.RowIndex Then
                    dtgBeneficiario.Rows(i).Cells("seleccioneBenef").Value = False
                End If
            Next

        End If
    End Sub

    Private Sub dtgPolizas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgPolizas.CellContentClick
        If e.ColumnIndex <> 0 Then Exit Sub
        Dim row As DataGridViewRow = dtgPolizas.Rows(e.RowIndex)
        Dim comunaGes As New EtComuna


        If dtgPolizas.Rows(e.RowIndex).Cells("seleccionePoliza").Value = True Then
            dtgPolizas.Rows(e.RowIndex).Cells("seleccionePoliza").Value = False
            gpbDatosPolizas.Visible = False
        Else
            dtgPolizas.Rows(e.RowIndex).Cells("seleccionePoliza").Value = True


            gpbDatosPolizas.Visible = True
            idRowIndexPolizas = e.RowIndex

            txtIdPoliza.Text = dtgPolizas.Rows(e.RowIndex).Cells("idPoliza").Value
            txtNombrePoliza.Text = dtgPolizas.Rows(e.RowIndex).Cells("nombrePoliza").Value
            txtPaternoPoliza.Text = dtgPolizas.Rows(e.RowIndex).Cells("paternoPoliza").Value
            txtMaternoPoliza.Text = dtgPolizas.Rows(e.RowIndex).Cells("maternoPoliza").Value
            txtRutPoliza.Text = dtgPolizas.Rows(e.RowIndex).Cells("rutPoliza").Value
            txtDvPoliza.Text = dtgPolizas.Rows(e.RowIndex).Cells("dvPoliza").Value
            dtpFechaNacimientoPoliza.Value = dtgPolizas.Rows(e.RowIndex).Cells("fechaNacimientoPoliza").Value
            txtEmailPoliza.Text = dtgPolizas.Rows(e.RowIndex).Cells("emailPoliza").Value
            txtPesoPoliza.Text = dtgPolizas.Rows(e.RowIndex).Cells("pesoPoliza").Value
            txtEstaturaPoliza.Text = dtgPolizas.Rows(e.RowIndex).Cells("estaturaPoliza").Value
            cmbSistemaSaludPoliza.Text = dtgPolizas.Rows(e.RowIndex).Cells("sistemaSaludPoliza").Value
            txtDireccionPoliza.Text = dtgPolizas.Rows(e.RowIndex).Cells("callePoliza").Value
            txtNroPoliza.Text = dtgPolizas.Rows(e.RowIndex).Cells("numeroPoliza").Value
            txtReferenciaPoliza.Text = dtgPolizas.Rows(e.RowIndex).Cells("referenciaPoliza").Value


            comunaGes = vgListComuna.Find(Function(tmpC As EtComuna) tmpC.nombreComuna = dtgPolizas.Rows(e.RowIndex).Cells("comunaPoliza").Value)
            cmbComunaPoliza.SelectedValue = comunaGes.idComuna

            For i As Integer = 0 To dtgPolizas.Rows.Count - 1
                If i <> e.RowIndex Then
                    dtgPolizas.Rows(i).Cells("seleccionePoliza").Value = False
                End If
            Next

        End If
    End Sub

#End Region


    Private Sub cbComuna_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbComuna.SelectedIndexChanged
        Dim lstCiudad As New List(Of EtCiudad)

        If cmbComuna.ValueMember Is Nothing Or cmbComuna.ValueMember = "" Then
            Exit Sub
        End If
        If cmbComuna.SelectedValue Is Nothing Then
            Exit Sub
        End If

        'actualiza el combo box de ciudad
        Dim Ciudad As New EtCiudad
        Dim comuna As New EtComuna

        comuna = vgListComuna.Find(Function(tmpC As EtComuna) tmpC.idComuna = cmbComuna.SelectedValue)
        ' Ciudad = biClsCiudad.BuscaCiudadPorIdCiudad(comuna.idCiudad)
        Ciudad = vgListCiudad.Find(Function(tmc As EtCiudad) tmc.idCiudad = comuna.idCiudad)
        lstCiudad.Add(Ciudad)
        llenaComboBox(cmbCiudad, "nombreCiudad", "idCiudad", lstCiudad.ToArray)

    End Sub

#Region "EVENTOS BOTON ACTUALIZAR"

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizarT.Click

        Dim dt As New DataTable
        Dim resultado As Boolean

        Dim actualizar As New clsActualizar

        resultado = actualizar.ActualizarDatosTitular(cmbCRM.SelectedValue, txtId.Text, txtRut.Text, txtNombre.Text, txtPaterno.Text, txtMaterno.Text, dtpFecNacimiento.Value.ToString("yyyyMMdd"), txtDireccion.Text, txtNum.Text, txtRef.Text, cmbComuna.Text, cmbCiudad.Text, txtEmail.Text, txtSuministro.Text, txtRutPagador.Text, txtNombrePagador.Text)
        'dtgEvaluaciones.DataSource = tabla
        If resultado = True Then
            MsgBox("Se han actualizado correctamente los datos del titular", vbInformation, "CALIDAD")
        Else
            MsgBox("No se han podido actualizar los datos", vbInformation, "CALIDAD")
        End If

        BuscaDatosTitular(cmbCRM.SelectedValue, txtId.Text)
        limpiarColoresTitular()

    End Sub

    Private Sub btnActualizaA_Click(sender As Object, e As EventArgs) Handles btnActualizaA.Click

        If gpbAdicionalDatos.Visible = False Then
            MsgBox("Debe seleccionar que adicional modificara", vbExclamation, "Calidad")
            Exit Sub
        End If

        Dim dt As New DataTable
        Dim resultado As Boolean

        Dim actualizar As New clsActualizar

        resultado = actualizar.ActualizarDatosAdicional(cmbCRM.SelectedValue, txtId.Text, txtNroAdicional.Text, txtRutAdicional.Text, txtNombreAdicional.Text, txtPaternoAdicional.Text, txtMaternoAdicional.Text, dtpFechaAdicional.Value.ToString("yyyyMMdd"), cmbTipoAdicional.SelectedValue, txtPesoAdicional.Text, txtEstaturaAdicional.Text)
        'dtgEvaluaciones.DataSource = tabla
        If resultado = True Then
            MsgBox("Se han actualizado correctamente los datos del Adicional", vbInformation, "CALIDAD")
        Else
            MsgBox("No se han podido actualizar los datos del adicional", vbInformation, "CALIDAD")
        End If

        BuscaDatosAdicional(cmbCRM.SelectedValue, txtId.Text)
        limpiarColoresAdicional()

    End Sub


    Private Sub btnActualizarB_Click(sender As Object, e As EventArgs) Handles btnActualizarB.Click

        If gpbBeneficiarioOtros.Visible = False Then
            MsgBox("Debe seleccionar que Beneficiario modificara", vbExclamation, "Calidad")
            Exit Sub
        End If

        Dim dt As New DataTable
        Dim resultado As Boolean

        Dim actualizar As New clsActualizar

        resultado = actualizar.ActualizarDatosBeneficiario(cmbCRM.SelectedValue, txtId.Text, txtNroBeneficiario.Text, txtRutBef.Text, txtNombreBenef.Text, txtPaternoBenef.Text, txtMaternoBenef.Text, dtpFechaNacimientoBenef.Value.ToString("yyyyMMdd"), cmbTipoBeneficiario.SelectedValue)
        'dtgEvaluaciones.DataSource = tabla
        If resultado = True Then
            MsgBox("Se han actualizado correctamente los datos del Beneficiario", vbInformation, "CALIDAD")
        Else
            MsgBox("No se han podido actualizar los datos del Beneficiario", vbInformation, "CALIDAD")
        End If

        BuscaDatosBeneficiario(cmbCRM.SelectedValue, txtId.Text)
        limpiarColoresBeneficiario()

    End Sub

    Private Sub btnActualizarP_Click(sender As Object, e As EventArgs) Handles btnActualizarP.Click


        If gpbDatosPolizas.Visible = False Then
            MsgBox("Debe seleccionar que Poliza modificara", vbExclamation, "Calidad")
            Exit Sub
        End If

        Dim dt As New DataTable
        Dim resultado As Boolean

        Dim actualizar As New clsActualizar

        resultado = actualizar.ActualizarDatoPolizas(cmbCRM.SelectedValue, txtId.Text, txtIdPoliza.Text, txtRutPoliza.Text, txtNombrePoliza.Text, txtPaternoPoliza.Text, txtMaternoPoliza.Text, dtpFechaNacimientoPoliza.Value.ToString("yyyyMMdd"), txtDireccionPoliza.Text, txtNroPoliza.Text, txtReferenciaPoliza.Text, cmbComunaPoliza.Text, txtEmailPoliza.Text, txtPesoPoliza.Text, txtEstaturaPoliza.Text)
        'dtgEvaluaciones.DataSource = tabla
        If resultado = True Then
            MsgBox("Se han actualizado correctamente los datos de la polizas", vbInformation, "CALIDAD")
        Else
            MsgBox("No se han podido actualizar los datos de la poliza", vbInformation, "CALIDAD")
        End If

        BuscaDatosPoliza(cmbCRM.SelectedValue, txtId.Text)
        limpiarColoresPolizas()

    End Sub

#End Region


#Region "VALIDACIONES CONVERSION DV RUT"
    Private Sub txtRut_Leave(sender As Object, e As EventArgs) Handles txtRut.Leave
        If txtRut.Text = "" Then Exit Sub

        txtDv.Text = ValidaRut(txtRut.Text)
    End Sub

    Private Sub txtRutPagador_Leave(sender As Object, e As EventArgs) Handles txtRutPagador.Leave
        If txtRutPagador.Text = "" Then Exit Sub

        txtDvPagador.Text = ValidaRut(txtRutPagador.Text)
    End Sub

    Private Sub txtRutAdicional_Leave(sender As Object, e As EventArgs) Handles txtRutAdicional.Leave
        If txtRutAdicional.Text = "" Then Exit Sub

        txtDvAdicional.Text = ValidaRut(txtRutAdicional.Text)
    End Sub

    Private Sub txtRutBeneficiario_Leave(sender As Object, e As EventArgs) Handles txtRutBef.Leave
        If txtRutBef.Text = "" Then Exit Sub

        txtDvBenef.Text = ValidaRut(txtRutBef.Text)
    End Sub

    Private Sub txtRutPolizas_Leave(sender As Object, e As EventArgs) Handles txtRutPoliza.Leave
        If txtRutPoliza.Text = "" Then Exit Sub

        txtDvPoliza.Text = ValidaRut(txtRutPoliza.Text)
    End Sub

#End Region

#Region "VALIDACION DATOS TITULAR"

    Private Sub txtPaterno_TextChanged(sender As Object, e As EventArgs) Handles txtPaterno.TextChanged
        If txtPaterno.Text <> vgListTitular(0).Paterno Then
            txtPaterno.ForeColor = Color.Red
        Else
            txtPaterno.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtMaterno_TextChanged(sender As Object, e As EventArgs) Handles txtMaterno.TextChanged
        If txtMaterno.Text <> vgListTitular(0).Materno Then
            txtMaterno.ForeColor = Color.Red
        Else
            txtMaterno.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged
        If txtNombre.Text <> vgListTitular(0).Nombre Then
            txtNombre.ForeColor = Color.Red
        Else
            txtNombre.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtRut_TextChanged(sender As Object, e As EventArgs) Handles txtRut.TextChanged
        If txtRut.Text <> vgListTitular(0).Rut Then
            txtRut.ForeColor = Color.Red
        Else
            txtRut.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtDireccion_TextChanged(sender As Object, e As EventArgs) Handles txtDireccion.TextChanged
        If txtDireccion.Text <> vgListTitular(0).Calle Then
            txtDireccion.ForeColor = Color.Red
        Else
            txtDireccion.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtNum_TextChanged(sender As Object, e As EventArgs) Handles txtNum.TextChanged
        If txtNum.Text <> vgListTitular(0).Numero Then
            txtNum.ForeColor = Color.Red
        Else
            txtNum.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtRef_TextChanged(sender As Object, e As EventArgs) Handles txtRef.TextChanged
        If txtRef.Text <> vgListTitular(0).Referencia Then
            txtRef.ForeColor = Color.Red
        Else
            txtRef.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged
        If txtEmail.Text <> vgListTitular(0).Email Then
            txtEmail.ForeColor = Color.Red
        Else
            txtEmail.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtSuministro_TextChanged(sender As Object, e As EventArgs) Handles txtSuministro.TextChanged
        If txtSuministro.Text <> vgListTitular(0).Suministro Then
            txtSuministro.ForeColor = Color.Red
        Else
            txtSuministro.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtRutPagador_TextChanged(sender As Object, e As EventArgs) Handles txtRutPagador.TextChanged
        If txtRutPagador.Text <> vgListTitular(0).RutPagador Then
            txtRutPagador.ForeColor = Color.Red
        Else
            txtRutPagador.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtNombrePagador_TextChanged(sender As Object, e As EventArgs) Handles txtNombrePagador.TextChanged
        If txtNombrePagador.Text <> vgListTitular(0).NombrePagador Then
            txtNombrePagador.ForeColor = Color.Red
        Else
            txtNombrePagador.ForeColor = Color.Black
        End If
    End Sub

    Private Sub cmbComuna_TextChanged(sender As Object, e As EventArgs) Handles cmbComuna.TextChanged
        If cmbComuna.Text <> vgListTitular(0).Comuna Then
            cmbComuna.ForeColor = Color.Red
        Else
            cmbComuna.ForeColor = Color.Black
        End If
    End Sub

#End Region

#Region "VALIDACION DATOS ADICIONAL"

    Private Sub txtNombreAdicional_TextChanged(sender As Object, e As EventArgs) Handles txtNombreAdicional.TextChanged
        If txtNombreAdicional.Text <> dtgAdicionales.Rows(idRowIndexAdicional).Cells("nombreAdicional").Value Then
            txtNombreAdicional.ForeColor = Color.Red
        Else
            txtNombreAdicional.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtPaternoAdicional_TextChanged(sender As Object, e As EventArgs) Handles txtPaternoAdicional.TextChanged
        If txtPaternoAdicional.Text <> dtgAdicionales.Rows(idRowIndexAdicional).Cells("paternoAdicional").Value Then
            txtPaternoAdicional.ForeColor = Color.Red
        Else
            txtPaternoAdicional.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtMaternoAdicional_TextChanged(sender As Object, e As EventArgs) Handles txtMaternoAdicional.TextChanged
        If txtMaternoAdicional.Text <> dtgAdicionales.Rows(idRowIndexAdicional).Cells("maternoAdicional").Value Then
            txtMaternoAdicional.ForeColor = Color.Red
        Else
            txtMaternoAdicional.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtRutAdicional_TextChanged(sender As Object, e As EventArgs) Handles txtRutAdicional.TextChanged
        If txtRutAdicional.Text <> dtgAdicionales.Rows(idRowIndexAdicional).Cells("rutAdicional").Value Then
            txtRutAdicional.ForeColor = Color.Red
        Else
            txtRutAdicional.ForeColor = Color.Black
        End If
    End Sub

    Private Sub cmbTipoAdicional_TextChanged(sender As Object, e As EventArgs) Handles cmbTipoAdicional.TextChanged
        If dtgAdicionales.Rows.Count = 0 Then
            Exit Sub
        End If
        If cmbTipoAdicional.Text <> dtgAdicionales.Rows(idRowIndexAdicional).Cells("nombreParentesco").Value Then
            cmbTipoAdicional.ForeColor = Color.Red
        Else
            cmbTipoAdicional.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtPesoAdicional_TextChanged(sender As Object, e As EventArgs) Handles txtPesoAdicional.TextChanged
        If txtPesoAdicional.Text <> dtgAdicionales.Rows(idRowIndexAdicional).Cells("pesoAdicional").Value Then
            txtPesoAdicional.ForeColor = Color.Red
        Else
            txtPesoAdicional.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtEstaturaAdicional_TextChanged(sender As Object, e As EventArgs) Handles txtEstaturaAdicional.TextChanged
        If txtEstaturaAdicional.Text <> dtgAdicionales.Rows(idRowIndexAdicional).Cells("estaturaAdicional").Value Then
            txtEstaturaAdicional.ForeColor = Color.Red
        Else
            txtEstaturaAdicional.ForeColor = Color.Black
        End If
    End Sub

    Private Sub cmbSistemaSaludAdicional_TextChanged(sender As Object, e As EventArgs) Handles cmbSistemaSaludAdicional.TextChanged
        If cmbSistemaSaludAdicional.Text <> dtgAdicionales.Rows(idRowIndexAdicional).Cells("sistemaSaludAdicional").Value Then
            cmbSistemaSaludAdicional.ForeColor = Color.Red
        Else
            cmbSistemaSaludAdicional.ForeColor = Color.Black
        End If
    End Sub
#End Region

#Region "VALIDACION DATOS BENEFICIARIO"

    Private Sub txtNombreBenef_TextChanged(sender As Object, e As EventArgs) Handles txtNombreBenef.TextChanged
        If txtNombreBenef.Text <> dtgBeneficiario.Rows(idRowIndexBeneficiario).Cells("nombreBeneficiario").Value Then
            txtNombreBenef.ForeColor = Color.Red
        Else
            txtNombreBenef.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtPaternoBenef_TextChanged(sender As Object, e As EventArgs) Handles txtPaternoBenef.TextChanged
        If txtPaternoBenef.Text <> dtgBeneficiario.Rows(idRowIndexBeneficiario).Cells("paternoBeneficiario").Value Then
            txtPaternoBenef.ForeColor = Color.Red
        Else
            txtPaternoBenef.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtMaternoBenef_TextChanged(sender As Object, e As EventArgs) Handles txtMaternoBenef.TextChanged
        If txtMaternoBenef.Text <> dtgBeneficiario.Rows(idRowIndexBeneficiario).Cells("MaternoBeneficiario").Value Then
            txtMaternoBenef.ForeColor = Color.Red
        Else
            txtMaternoBenef.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtRutBef_TextChanged(sender As Object, e As EventArgs) Handles txtRutBef.TextChanged
        If txtRutBef.Text <> dtgBeneficiario.Rows(idRowIndexBeneficiario).Cells("rutBeneficiario").Value Then
            txtRutBef.ForeColor = Color.Red
        Else
            txtRutBef.ForeColor = Color.Black
        End If
    End Sub

    Private Sub cmbTipoBeneficiario_TextChanged(sender As Object, e As EventArgs) Handles cmbTipoBeneficiario.TextChanged
        If cmbTipoBeneficiario.Text <> dtgBeneficiario.Rows(idRowIndexBeneficiario).Cells("parentescoBeneficiario").Value Then
            cmbTipoBeneficiario.ForeColor = Color.Red
        Else
            cmbTipoBeneficiario.ForeColor = Color.Black
        End If
    End Sub

#End Region

#Region "VALIDACION DATOS POLIZAS"

    Private Sub txtNombrePoliza_TextChanged(sender As Object, e As EventArgs) Handles txtNombrePoliza.TextChanged
        If txtNombrePoliza.Text <> dtgPolizas.Rows(idRowIndexPolizas).Cells("nombrePoliza").Value Then
            txtNombrePoliza.ForeColor = Color.Red
        Else
            txtNombrePoliza.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtPaternoPoliza_TextChanged(sender As Object, e As EventArgs) Handles txtPaternoPoliza.TextChanged
        If txtPaternoPoliza.Text <> dtgPolizas.Rows(idRowIndexPolizas).Cells("paternoPoliza").Value Then
            txtPaternoPoliza.ForeColor = Color.Red
        Else
            txtPaternoPoliza.ForeColor = Color.Black
        End If
    End Sub


    Private Sub txtMaternoPoliza_TextChanged(sender As Object, e As EventArgs) Handles txtMaternoPoliza.TextChanged
        If txtMaternoPoliza.Text <> dtgPolizas.Rows(idRowIndexPolizas).Cells("maternoPoliza").Value Then
            txtMaternoPoliza.ForeColor = Color.Red
        Else
            txtMaternoPoliza.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtRutPoliza_TextChanged(sender As Object, e As EventArgs) Handles txtRutPoliza.TextChanged
        If txtRutPoliza.Text <> dtgPolizas.Rows(idRowIndexPolizas).Cells("rutPoliza").Value Then
            txtRutPoliza.ForeColor = Color.Red
        Else
            txtRutPoliza.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtEmailPoliza_TextChanged(sender As Object, e As EventArgs) Handles txtEmailPoliza.TextChanged
        If txtEmailPoliza.Text <> dtgPolizas.Rows(idRowIndexPolizas).Cells("emailPoliza").Value Then
            txtEmailPoliza.ForeColor = Color.Red
        Else
            txtEmailPoliza.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtPesoPoliza_TextChanged(sender As Object, e As EventArgs) Handles txtPesoPoliza.TextChanged
        If txtPesoPoliza.Text <> dtgPolizas.Rows(idRowIndexPolizas).Cells("pesoPoliza").Value Then
            txtPesoPoliza.ForeColor = Color.Red
        Else
            txtPesoPoliza.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtEstaturaPoliza_TextChanged(sender As Object, e As EventArgs) Handles txtEstaturaPoliza.TextChanged
        If txtEstaturaPoliza.Text <> dtgPolizas.Rows(idRowIndexPolizas).Cells("estaturaPoliza").Value Then
            txtEstaturaPoliza.ForeColor = Color.Red
        Else
            txtEstaturaPoliza.ForeColor = Color.Black
        End If
    End Sub

    Private Sub cmbSistemaSaludPoliza_TextChanged(sender As Object, e As EventArgs) Handles cmbSistemaSaludPoliza.TextChanged
        If cmbSistemaSaludPoliza.Text <> dtgPolizas.Rows(idRowIndexPolizas).Cells("sistemaSaludPoliza").Value Then
            cmbSistemaSaludPoliza.ForeColor = Color.Red
        Else
            cmbSistemaSaludPoliza.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtDireccionPoliza_TextChanged(sender As Object, e As EventArgs) Handles txtDireccionPoliza.TextChanged
        If txtDireccionPoliza.Text <> dtgPolizas.Rows(idRowIndexPolizas).Cells("callePoliza").Value Then
            txtDireccionPoliza.ForeColor = Color.Red
        Else
            txtDireccionPoliza.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtNroPoliza_TextChanged(sender As Object, e As EventArgs) Handles txtNroPoliza.TextChanged
        If txtNroPoliza.Text <> dtgPolizas.Rows(idRowIndexPolizas).Cells("numeroPoliza").Value Then
            txtNroPoliza.ForeColor = Color.Red
        Else
            txtNroPoliza.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtReferenciaPoliza_TextChanged(sender As Object, e As EventArgs) Handles txtReferenciaPoliza.TextChanged
        If txtReferenciaPoliza.Text <> dtgPolizas.Rows(idRowIndexPolizas).Cells("referenciaPoliza").Value Then
            txtReferenciaPoliza.ForeColor = Color.Red
        Else
            txtReferenciaPoliza.ForeColor = Color.Black
        End If
    End Sub



#End Region

#Region "LIMPIAR COLORES"

    Private Sub limpiarColoresTitular()
        txtPaterno.ForeColor = Color.Black
        txtMaterno.ForeColor = Color.Black
        txtNombre.ForeColor = Color.Black
        txtRut.ForeColor = Color.Black
        txtDireccion.ForeColor = Color.Black
        txtNum.ForeColor = Color.Black
        txtRef.ForeColor = Color.Black
        txtEmail.ForeColor = Color.Black
        txtSuministro.ForeColor = Color.Black
        txtRutPagador.ForeColor = Color.Black
        txtNombrePagador.ForeColor = Color.Black
        cmbComuna.ForeColor = Color.Black
    End Sub

    Private Sub limpiarColoresAdicional()
        txtNombreAdicional.ForeColor = Color.Black
        txtPaternoAdicional.ForeColor = Color.Black
        txtMaternoAdicional.ForeColor = Color.Black
        txtRutAdicional.ForeColor = Color.Black
        cmbTipoAdicional.ForeColor = Color.Black
        txtPesoAdicional.ForeColor = Color.Black
        txtEstaturaAdicional.ForeColor = Color.Black
        cmbSistemaSaludAdicional.ForeColor = Color.Black
    End Sub

    Private Sub limpiarColoresBeneficiario()
        txtNombreBenef.ForeColor = Color.Black
        txtPaternoBenef.ForeColor = Color.Black
        txtMaternoBenef.ForeColor = Color.Black
        txtRutBef.ForeColor = Color.Black
        cmbTipoBeneficiario.ForeColor = Color.Black
    End Sub

    Private Sub limpiarColoresPolizas()

        txtNombrePoliza.ForeColor = Color.Black
        txtPaternoPoliza.ForeColor = Color.Black
        txtMaternoPoliza.ForeColor = Color.Black
        txtRutPoliza.ForeColor = Color.Black
        txtEmailPoliza.ForeColor = Color.Black
        txtPesoPoliza.ForeColor = Color.Black
        txtEstaturaPoliza.ForeColor = Color.Black
        cmbSistemaSaludPoliza.ForeColor = Color.Black
        txtDireccionPoliza.ForeColor = Color.Black
        txtNroPoliza.ForeColor = Color.Black
        txtReferenciaPoliza.ForeColor = Color.Black

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Close()
        LimpiarTabs()
        cargaDatosBase()

        txtId.Text = ""
        cmbCRM.SelectedIndex = -1
        txtId.Enabled = True
        cmbCRM.Enabled = True

    End Sub

#End Region



End Class