Imports System.Data.SqlClient
Imports ET

Public Class frmModificarRegistro
    Dim NombreB As String
    Dim PaternoB As String
    Dim MaternoB As String
    Dim FechaNacimientoB As String
    Dim DireccionB As String
    Dim NumeroB As String
    Dim ReferenciaB As String
    Dim ComunaB As String
    Dim CiudadB As String
    Dim SuministroB As String
    Dim EmailB As String

    Dim cnn As New SqlConnection("data source = 192.168.1.14; initial catalog = CALIDAD; User id= cp; password=Cordial.passs")
    Dim cnn2 As New SqlConnection("data source = 192.168.1.14; initial catalog = BASE_GENERAL_CORDIAL; User id= cp; password=Cordial.passs ")
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        BuscaVentaPorID(IIf(txtC_ID.Text.Trim = "", "0", txtC_ID.Text.Trim), cbCRM.SelectedValue)

    End Sub



    Private Sub BuscaVentaPorID(id As Object, crm As Object)
        Dim tabla As New DataTable
        Dim da As SqlDataAdapter
        Dim cmd As New SqlCommand
        Dim Simbolo As String = ""
        Dim sql As String = ""




        If cbCRM.SelectedIndex < 0 Then
            MsgBox("Debe ingresar CRM de registro a modificar" & vbNewLine, MsgBoxStyle.Critical, "Error")
            cbCRM.Focus()
            Exit Sub
        End If

        If txtC_ID.Text = "" Then
            MsgBox("Debe ingresar Id de registro a modificar" & vbNewLine, MsgBoxStyle.Critical, "Error")
            txtC_ID.Focus()
            Exit Sub
        End If
        cmd.CommandType = CommandType.StoredProcedure

        Try
            sql = "Gestion.pa_BuscaVentasParaActualizar"

            cmd.Parameters.AddWithValue("@idCRM", crm)
            cmd.Parameters.AddWithValue("@C_id", id)
            cmd.CommandText = sql
            cmd.Connection = cnn
            da = New SqlDataAdapter(cmd)
            da.Fill(tabla)

            If tabla.Rows.Count <= 0 Then
                MsgBox("No existen datos de cliente para mostrar", vbInformation, "")
                btnActualizar.Enabled = False
                Exit Sub
            End If

            'dtgEvaluaciones.DataSource = tabla

            txtNombre.Text = tabla.Rows(0)("NOMBRE")
            txtPaterno.Text = tabla.Rows(0)("PATERNO")
            txtMaterno.Text = tabla.Rows(0)("MATERNO")
            dtFecNacimiento.Value = tabla.Rows(0)("FECNACIMIENTO")
            txtDireccion.Text = tabla.Rows(0)("CALLE")
            txtNum.Text = tabla.Rows(0)("NUM")
            txtRef.Text = tabla.Rows(0)("REFERENCIA")
            cbComuna.Text = tabla.Rows(0)("COMUNA")
            cbCiudad.Text = tabla.Rows(0)("CIUDAD")
            txtSuministro.Text = tabla.Rows(0)("SUMINISTRO")
            txtEmail.Text = tabla.Rows(0)("MAIL")

            NombreB = tabla.Rows(0)("NOMBRE")
            PaternoB = tabla.Rows(0)("PATERNO")
            MaternoB = tabla.Rows(0)("MATERNO")
            FechaNacimientoB = tabla.Rows(0)("FECNACIMIENTO")
            DireccionB = tabla.Rows(0)("CALLE")
            NumeroB = tabla.Rows(0)("NUM")
            ReferenciaB = tabla.Rows(0)("REFERENCIA")
            ComunaB = tabla.Rows(0)("COMUNA")
            CiudadB = tabla.Rows(0)("CIUDAD")
            SuministroB = tabla.Rows(0)("SUMINISTRO")
            EmailB = tabla.Rows(0)("MAIL")

            btnActualizar.Enabled = True


        Catch ex As Exception
            MsgBox("Error al buscar registro" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub frmModificarRegistro_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ListaCampañas(cbCRM)

        LimpiaFormulario()



        Dim daComuna As New EtComuna
        Dim daCiudad As New EtCiudad
        vgListComuna = daComuna.listarComuna()
        vgListCiudad = daCiudad.ListaCiudad()
        llenaComboBox(cbComuna, "nombreComuna", "idComuna", vgListComuna.ToArray)
        cbComuna.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cbComuna.AutoCompleteSource = AutoCompleteSource.ListItems
        TraeIds()

        idActualizacionRegistro = ""
        crmActualizarRegistro = 0

    End Sub

    Private Sub TraeIds()




        If idActualizacionRegistro <> "" And crmActualizarRegistro >= 0 Then

            txtC_ID.Text = idActualizacionRegistro
            cbCRM.SelectedValue = crmActualizarRegistro
            BuscaVentaPorID(idActualizacionRegistro, crmActualizarRegistro)
            txtC_ID.Enabled = False
            cbCRM.Enabled = False

        End If
    End Sub

    Private Sub ListaCampañas(combo As ComboBox)
        Dim miTabla As New DataTable
        Dim dA As SqlDataAdapter
        Dim cmd As New SqlCommand
        Dim sql As String = ""
        cmd.CommandType = CommandType.StoredProcedure

        Try
            sql = "dbo.ListaCampañasActivas"
            cmd.CommandText = sql
            cmd.Connection = cnn2
            dA = New SqlDataAdapter(cmd)
            dA.Fill(miTabla)

            combo.DataSource = miTabla
            combo.DisplayMember = "Nombre"
            combo.ValueMember = "CRM"
            combo.SelectedIndex = -1

        Catch ex As Exception

            MsgBox("Error Listar Campañas" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")

        End Try
    End Sub

    'Public Sub llenaComboBox(ByRef _drd As ComboBox, ByRef _strDisplay As String, ByRef _strValue As String, ByRef _origenDato As Array)
    '    _drd.DisplayMember = _strDisplay
    '    _drd.ValueMember = _strValue
    '    _drd.DataSource = _origenDato
    'End Sub

    Private Sub cbComuna_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbComuna.SelectedIndexChanged
        Dim lstCiudad As New List(Of EtCiudad)

        If cbComuna.ValueMember Is Nothing Or cbComuna.ValueMember = "" Then
            Exit Sub
        End If
        If cbComuna.SelectedValue Is Nothing Then
            Exit Sub
        End If

        'actualiza el combo box de ciudad
        Dim Ciudad As New EtCiudad
        Dim comuna As New EtComuna

        comuna = vgListComuna.Find(Function(tmpC As EtComuna) tmpC.idComuna = cbComuna.SelectedValue)
        ' Ciudad = biClsCiudad.BuscaCiudadPorIdCiudad(comuna.idCiudad)
        Ciudad = vgListCiudad.Find(Function(tmc As EtCiudad) tmc.idCiudad = comuna.idCiudad)
        lstCiudad.Add(Ciudad)
        llenaComboBox(cbCiudad, "nombreCiudad", "idCiudad", lstCiudad.ToArray)
    End Sub

    Private Sub LimpiaFormulario()
        btnActualizar.Enabled = False
        txtC_ID.Text = ""
        cbCRM.Text = ""
        txtNombre.Text = ""
        txtPaterno.Text = ""
        txtMaterno.Text = ""
        txtDireccion.Text = ""
        txtNum.Text = ""
        txtRef.Text = ""
        cbComuna.Text = ""
        cbCiudad.Text = ""
        txtSuministro.Text = ""
        txtEmail.Text = ""
        txtNombre.BackColor = Color.White
        txtPaterno.BackColor = Color.White
        txtMaterno.BackColor = Color.White
        txtDireccion.BackColor = Color.White
        txtNum.BackColor = Color.White
        txtRef.BackColor = Color.White
        cbComuna.BackColor = Color.White
        cbCiudad.BackColor = Color.White
        txtSuministro.BackColor = Color.White
        txtC_ID.Enabled = True
        cbCRM.Enabled = True
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Actualizar(cbCRM.SelectedValue, IIf(txtC_ID.Text.Trim = "", "0", txtC_ID.Text.Trim), txtNombre.Text, txtPaterno.Text, txtMaterno.Text, dtFecNacimiento.Value.ToString("yyyyMMdd"), txtDireccion.Text, txtNum.Text, txtRef.Text, cbComuna.Text, cbCiudad.Text, txtSuministro.Text, txtEmail.Text)

    End Sub

    Private Function ValidaDatos() As Boolean

        ValidaDatos = False
        If txtNombre.Text = "" Then
            MsgBox("Debe ingresar Nombre" & vbNewLine, MsgBoxStyle.Critical, "Error")
            txtNombre.Focus()
            Exit Function
        End If

        If txtPaterno.Text = "" Then
            MsgBox("Debe ingresar Apellido Paterno" & vbNewLine, MsgBoxStyle.Critical, "Error")
            txtPaterno.Focus()
            Exit Function
        End If

        If txtMaterno.Text = "" Then
            MsgBox("Debe ingresar Apellido Materno" & vbNewLine, MsgBoxStyle.Critical, "Error")
            txtMaterno.Focus()
            Exit Function
        End If

        If dtFecNacimiento.Value = Date.Today Then
            MsgBox("Debe ingresar Fecha Nacimiento válida" & vbNewLine, MsgBoxStyle.Critical, "Error")
            txtNombre.Focus()
            Exit Function
        End If

        If txtDireccion.Text = "" Then
            MsgBox("Debe ingresar una dirección válida" & vbNewLine, MsgBoxStyle.Critical, "Error")
            txtDireccion.Focus()
            Exit Function
        End If

        If txtNum.Text = "" Then
            MsgBox("Debe ingresar un número de dirección válido" & vbNewLine, MsgBoxStyle.Critical, "Error")
            txtNum.Focus()
            Exit Function
        End If


        If cbComuna.SelectedIndex <= 0 Then
            MsgBox("Debe seleccionar una Comuna" & vbNewLine, MsgBoxStyle.Critical, "Error")
            txtNombre.Focus()
            Exit Function
        End If

        If cbCiudad.Text = "" Then
            MsgBox("Debe ingresar una Ciudad" & vbNewLine, MsgBoxStyle.Critical, "Error")
            Exit Function

        End If



        ValidaDatos = True
    End Function
    Private Sub Actualizar(crm As Object, id As Object, nom As String, pat As String, mat As String, fec As String, direc As String, num As String, ref As String, comuna As Object, ciudad As Object, sum As String, mail As String)
        Dim miTabla As New DataTable
        Dim dA As SqlDataAdapter
        Dim cmd As New SqlCommand
        Dim sql As String = ""

        cmd.CommandType = CommandType.StoredProcedure

        If ValidaDatos() = False Then
            Exit Sub
        End If
        Try
            sql = "Gestion.pa_ActualizaDatos"
            cmd.Parameters.AddWithValue("@idCrm", crm)
            cmd.Parameters.AddWithValue("@IdRegistro", id)
            cmd.Parameters.AddWithValue("@NOMBRE", nom)
            cmd.Parameters.AddWithValue("@PATERNO", pat)
            cmd.Parameters.AddWithValue("@MATERNO", mat)
            cmd.Parameters.AddWithValue("@FECNACIMIENTO", fec)
            cmd.Parameters.AddWithValue("@CALLE", direc)
            cmd.Parameters.AddWithValue("@NUM", num)
            cmd.Parameters.AddWithValue("@REFERENCIA", ref)
            cmd.Parameters.AddWithValue("@COMUNA", comuna)
            cmd.Parameters.AddWithValue("@CIUDAD", ciudad)
            cmd.Parameters.AddWithValue("@SUMIN", sum)
            cmd.Parameters.AddWithValue("@MAIL", mail)

            cmd.CommandText = sql
            cmd.Connection = cnn
            dA = New SqlDataAdapter(cmd)
            dA.Fill(miTabla)


            MsgBox("Registro actualizado correctamente" & vbNewLine, MsgBoxStyle.Information, "Información")
            LimpiaFormulario()


        Catch ex As Exception

            MsgBox("Error al actualizar registro" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")
            Me.Cursor = Cursors.Default

        End Try

    End Sub

    Private Sub txtNombre_Leave(sender As Object, e As EventArgs) Handles txtNombre.Leave
        If txtNombre.Text.Trim <> NombreB Then
            txtNombre.BackColor = Color.Salmon
        Else
            txtNombre.BackColor = Color.White
        End If
    End Sub

    Private Sub txtPaterno_Leave(sender As Object, e As EventArgs) Handles txtPaterno.Leave
        If txtPaterno.Text.Trim <> PaternoB Then
            txtPaterno.BackColor = Color.Salmon
        Else
            txtPaterno.BackColor = Color.White
        End If
    End Sub

    Private Sub txtMaterno_Leave(sender As Object, e As EventArgs) Handles txtMaterno.Leave
        If txtMaterno.Text.Trim <> MaternoB Then
            txtMaterno.BackColor = Color.Salmon
        Else
            txtMaterno.BackColor = Color.White
        End If
    End Sub

    Private Sub dtFecNacimiento_Leave(sender As Object, e As EventArgs) Handles dtFecNacimiento.Leave
        If dtFecNacimiento.Value <> FechaNacimientoB Then
            dtFecNacimiento.BackColor = Color.Salmon
        Else
            dtFecNacimiento.BackColor = Color.White
        End If
    End Sub

    Private Sub txtDireccion_Leave(sender As Object, e As EventArgs) Handles txtDireccion.Leave
        If txtDireccion.Text.Trim <> MaternoB Then
            txtDireccion.BackColor = Color.Salmon
        Else
            txtDireccion.BackColor = Color.White
        End If
    End Sub

    Private Sub txtNum_Leave(sender As Object, e As EventArgs) Handles txtNum.Leave
        If txtNum.Text.Trim <> NumeroB Then
            txtNum.BackColor = Color.Salmon
        Else
            txtNum.BackColor = Color.White
        End If
    End Sub

    Private Sub txtRef_Leave(sender As Object, e As EventArgs) Handles txtRef.Leave
        If txtRef.Text.Trim <> ReferenciaB Then
            txtRef.BackColor = Color.Salmon
        Else
            txtRef.BackColor = Color.White
        End If
    End Sub

    Private Sub cbComuna_Leave(sender As Object, e As EventArgs) Handles cbComuna.Leave
        If cbComuna.Text <> ComunaB Then
            cbComuna.BackColor = Color.Salmon
        Else
            cbComuna.BackColor = Color.White
        End If
    End Sub

    Private Sub cbCiudad_Leave(sender As Object, e As EventArgs) Handles cbCiudad.Leave
        If cbCiudad.Text <> CiudadB Then
            cbCiudad.BackColor = Color.Salmon
        Else
            cbCiudad.BackColor = Color.White
        End If
    End Sub

    Private Sub txtSuministro_Leave(sender As Object, e As EventArgs) Handles txtSuministro.Leave
        If txtSuministro.Text <> CiudadB Then
            txtSuministro.BackColor = Color.Salmon
        Else
            txtSuministro.BackColor = Color.White
        End If
    End Sub

    Private Sub txtEmail_Leave(sender As Object, e As EventArgs) Handles txtEmail.Leave
        If txtEmail.Text <> CiudadB Then
            txtEmail.BackColor = Color.Salmon
        Else
            txtEmail.BackColor = Color.White
        End If
    End Sub
End Class