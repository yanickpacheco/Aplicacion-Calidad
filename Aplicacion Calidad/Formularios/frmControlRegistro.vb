Imports System.Data.SqlClient
Imports System.IO
Imports ET
Imports WMPLib


Public Class frmControlRegistro

    Dim cnn2 As New SqlConnection("data source = 192.168.1.14; initial catalog = CALIDAD; User Id= cp; Password=Cordial.passs")



    Public Structure tUsuario
        Dim Computer As String
        Dim UserName As String
        Dim Fullname As String
        Dim Domain As String
        Dim PDC As String
        Dim IP As String
    End Structure


    Dim usuario_actual As New tUsuario

    Public Sub ListarDatosCliente(ByVal id As Integer, ByVal idInstancia As Integer)
        Dim tabla As New DataTable
        Dim da As SqlDataAdapter
        Dim cnn As New SqlConnection("data source = 192.168.1.14; initial catalog = BDD_" + Microsoft.VisualBasic.Right("00" + idCRMBase, 3) + "; User Id= cp; Password=Cordial.passs")
        Dim cmd As New SqlCommand
        Dim Simbolo As String = ""
        Dim sql As String = ""

        cmd.CommandType = CommandType.StoredProcedure
        Try
            sql = "Calidad.pa_BuscaDatosCliente"
            cmd.Parameters.AddWithValue("@c_id", id)
            cmd.Parameters.AddWithValue("@IdInstancia", idInstancia)

            crmActualizarRegistro = idCRMBase
            idActualizacionRegistro = id

            cmd.CommandText = sql
            cmd.Connection = cnn
            da = New SqlDataAdapter(cmd)
            da.Fill(tabla)



            If tabla.Rows.Count <= 0 Then
                MsgBox("No existen datos de cliente para mostrar", vbInformation, "")
                Me.Close()
                Exit Sub
            End If

            dtgDatosCliente.DataSource = tabla

            rut = tabla.Rows(0)("Rut")

            NombreGrabacion = tabla.Rows(0)("NombreGrabacion")

            lblID.Text = tabla.Rows(0)("Id")
            lblEjecutivo.Text = tabla.Rows(0)("Ejecutivo")
            lblFecha.Text = tabla.Rows(0)("Fecha")
            fechaGrabacion = tabla.Rows(0)("Fecha_Grabacion")
            lblIdLlamada.Text = tabla.Rows(0)("IdLLamada")
            nombreEjecutivo = tabla.Rows(0)("EJECUTIVO")
            fec = tabla.Rows(0)("Fecha")
            ejec = tabla.Rows(0)("Ejecutivo")


        Catch ex As Exception
            MsgBox("Error Listar Registros" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")
            Me.Cursor = Cursors.Default
        End Try
    End Sub


    Private Sub ListarBeneficiarios(ByVal id As Integer)
        Dim cnn As New SqlConnection("data source = 192.168.1.14; initial catalog = BDD_" + Microsoft.VisualBasic.Right("00" + idCRMBase, 3) + "; User Id= cp; Password=Cordial.passs")
        Dim tabla As New DataTable
        Dim da As SqlDataAdapter
        Dim cmd As New SqlCommand
        Dim Simbolo As String = ""
        Dim sql As String = ""

        cmd.CommandType = CommandType.StoredProcedure
        Try
            sql = "Calidad.pa_BuscaBeneficiarios"
            cmd.Parameters.AddWithValue("@c_id", id)

            cmd.CommandText = sql
            cmd.Connection = cnn
            da = New SqlDataAdapter(cmd)
            da.Fill(tabla)

            If tabla.Rows.Count > 0 Then
                dtgBeneficiarios.DataSource = tabla
            End If

        Catch ex As Exception
            MsgBox("Error Listar Beneficiarios" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    'Private Sub ListarRegistro()
    '    Dim cnn As New SqlConnection("data source = 192.168.1.14; initial catalog = BDD_" + Microsoft.VisualBasic.Right("00" + idCRMBase, 3) + "; User Id= cp; Password=Cordial.passs")
    '    Dim tabla As New DataTable
    '    Dim da As SqlDataAdapter
    '    Dim cmd As New SqlCommand
    '    Dim Simbolo As String = ""
    '    Dim sql As String = ""

    '    cmd.CommandType = CommandType.StoredProcedure
    '    Try
    '        sql = "Calidad.pa_BuscaVentasCalidad"
    '        ''cmd.Parameters.Add("@fecha", SqlDbType.Date)

    '        cmd.CommandText = sql
    '        cmd.Connection = cnn
    '        da = New SqlDataAdapter(cmd)
    '        da.Fill(tabla)

    '        If tabla.Rows.Count <= 0 Then
    '            MsgBox("No existen registros para mostrar", vbInformation, "")
    '        End If

    '        '' dtgGrabaciones.DataSource = tabla

    '        '' For i As Integer = 0 To tabla.Rows.Count - 1


    '        lblID.Text = tabla.Rows(0)("ID")
    '        lblEjecutivo.Text = tabla.Rows(0)("EJECUTIVO")
    '        lblFecha.Text = tabla.Rows(0)("FECHA")
    '        lblIdLlamada.Text = tabla.Rows(0)("ID_LLAMADA")

    '        idRegistro = tabla.Rows(0)("ID")
    '        ''buscarGrabacion(nombregrabacion, nombreCRM, mesGrabacion)
    '        fec = tabla.Rows(0)("FECHA").ToString("yyyyMMdd")
    '        ejec = tabla.Rows(0)("EJECUTIVO")

    '        ''  Next

    '        MsgBox("Registro Buscado", vbInformation)



    '    Catch ex As Exception
    '        MsgBox("Error Listar Registros" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")
    '        Me.Cursor = Cursors.Default
    '    End Try

    'End Sub

    Private Sub frmControlRegistro_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim lstMoti = New List(Of EtMotivo)

        lstMoti = llenaMotivos(idInst)


        cbMotivo.DataSource = lstMoti
        cbMotivo.DisplayMember = "NombreMotivo"
        cbMotivo.ValueMember = "IdMotivo"
        configuraUsuarioActual()

        gpbMotivos.Visible = False
        cbMotivo.SelectedIndex = 0
        txtObservaciones.Text = ""


        ListarBeneficiarios(idRegistro)
        ListarAdicionales(idRegistro)
        ListarDatosCliente(idRegistro, idInst)

    End Sub

    Private Sub ListarAdicionales(ByVal id As Integer)
        Dim cnn As New SqlConnection("data source = 192.168.1.14; initial catalog = BDD_" + Microsoft.VisualBasic.Right("00" + idCRMBase, 3) + "; User Id= cp; Password=Cordial.passs")
        Dim tabla As New DataTable
        Dim da As SqlDataAdapter
        Dim cmd As New SqlCommand
        Dim Simbolo As String = ""
        Dim sql As String = ""

        cmd.CommandType = CommandType.StoredProcedure
        Try
            sql = "Gestion.pa_ListaAdicionales"
            cmd.Parameters.AddWithValue("@C_ID", id)

            cmd.CommandText = sql
            cmd.Connection = cnn
            da = New SqlDataAdapter(cmd)
            da.Fill(tabla)

            If tabla.Rows.Count > 0 Then
                dtgAdicionales.DataSource = tabla
            End If

        Catch ex As Exception
            MsgBox("Error Listar Adicionales" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    'Private Sub ValidaUsuario(ByVal us As String)
    '    Dim sql As String
    '    Dim da As SqlDataAdapter
    '    Dim dt As DataTable
    '    Dim cmd As New SqlCommand

    '    cmd.CommandType = CommandType.StoredProcedure

    '    sql = "Entidad.pa_ExisteUsuario"
    '    cmd.Parameters.AddWithValue("@nom", us)
    '    cmd.CommandText = sql
    '    cmd.Connection = cnn2

    '    da = New SqlDataAdapter(cmd)

    '    dt = New DataTable()
    '    da.Fill(dt)

    '    If dt.Rows.Count = 0 Then
    '        MsgBox("Error: No se encuentra usuario")
    '    Else
    '        idUser = dt.Rows(0)("IdEjecutivo")
    '    End If




    'End Sub

    Private Sub configuraUsuarioActual()
        With usuario_actual
            'My.User.Name
            'My.Computer.Name 
            'My.Application.Info.

            .Computer = UCase(My.Computer.Name)
            .UserName = UCase(Environment.UserName)
            .Domain = UCase(Environment.UserDomainName)
            .PDC = UCase(My.Computer.Name) 'UCase(sysInfo.PDC)
        End With

        usuario_actual.Fullname = usuario_actual.UserName
        user = usuario_actual.Fullname

        ' WS_IDUSUARIO = "YANICK.PACHECO"

    End Sub

    ''' <summary>
    ''' Trae los motivos de calidad
    ''' </summary>
    ''' <returns></returns>
    Private Function llenaMotivos(ByVal instancia As Integer) As List(Of EtMotivo)

        Dim sql As String
        Dim da As SqlDataAdapter
        Dim dt As DataTable
        Dim cmd As New SqlCommand
        Dim lstMotivos = New List(Of EtMotivo)

        cmd.CommandType = CommandType.StoredProcedure

        sql = "Entidad.pa_ListarMotivo"
        cmd.Parameters.AddWithValue("@instancia", instancia)
        cmd.CommandText = sql
        cmd.Connection = cnn2
        da = New SqlDataAdapter(cmd)



        dt = New DataTable()
        da.Fill(dt)

        Dim moti As New EtMotivo
        moti.IdMotivo = 0
        moti.NombreMotivo = "---Seleccione---"
        lstMotivos.Add(moti)

        For x As Integer = 0 To dt.Rows.Count - 1
            Dim row As New EtMotivo

            row.IdMotivo = IIf(IsDBNull(dt.Rows(x)("IdMotivo")), Nothing, dt.Rows(x)("IdMotivo"))
            row.NombreMotivo = IIf(IsDBNull(dt.Rows(x)("NombreMotivo")), Nothing, dt.Rows(x)("NombreMotivo"))
            lstMotivos.Add(row)
        Next




        Return lstMotivos



    End Function

    Private Sub cbMotivo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbMotivo.SelectedIndexChanged


        Dim lstSubMoti = New List(Of EtSubMotivo)

        If cbMotivo.ValueMember Is Nothing Or cbMotivo.ValueMember = "" Then
            Exit Sub
        End If
        If cbMotivo.SelectedValue Is Nothing Then
            Exit Sub
        End If

        If cbMotivo.SelectedIndex < 0 Then
            Exit Sub
        Else
            lstSubMoti = llenaSubmotivo(cbMotivo.SelectedValue)
            cbSubMotivo.DataSource = lstSubMoti
            cbSubMotivo.DisplayMember = "NombreSubMotivo"
            cbSubMotivo.ValueMember = "IdSubMotivo"
        End If

    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="id"></param>
    Private Function llenaSubmotivo(id As Integer)
        Dim sql As String
        Dim da As SqlDataAdapter
        Dim dt As DataTable
        Dim cmd As New SqlCommand
        Dim lstSubMotivo = New List(Of EtSubMotivo)


        cmd.CommandType = CommandType.StoredProcedure

        sql = "Entidad.pa_ListarSubMotivos"
        cmd.Parameters.AddWithValue("@id", id)
        cmd.CommandText = sql
        cmd.Connection = cnn2

        da = New SqlDataAdapter(cmd)

        dt = New DataTable()
        da.Fill(dt)

        Dim submoti As New EtSubMotivo
        submoti.IdSubMotivo = 0
        submoti.NombreSubMotivo = "---Seleccione---"
        lstSubMotivo.Add(submoti)

        For x As Integer = 0 To dt.Rows.Count - 1
            Dim row As New EtSubMotivo

            row.IdSubMotivo = IIf(IsDBNull(dt.Rows(x)("IdSubMotivo")), Nothing, dt.Rows(x)("IdSubMotivo"))
            row.NombreSubMotivo = IIf(IsDBNull(dt.Rows(x)("NombreSubMotivo")), Nothing, dt.Rows(x)("NombreSubMotivo"))
            lstSubMotivo.Add(row)
        Next

        ''dt = New DataTable()
        ''da.Fill(dt)

        Return lstSubMotivo


    End Function



    Private Sub EscucharGrabacion(ByVal idCrm As Integer, ByVal fecha As String, ByVal nombreGrab As String, ByVal _idLlamada As String)
        Dim tabla As New DataTable
        Dim cmd As New SqlCommand
        Dim sql As String = ""
        Dim dia As String
        Dim Mes As String
        Dim anio As String
        Dim rutaOrigen As String

        dia = Mid(fecha, 7, 2)
        Mes = Mid(fecha, 5, 2)
        anio = Mid(fecha, 1, 4)

        Dim nomFinalcrm As String = ""
        nomFinalcrm = Microsoft.VisualBasic.Right("00" + idCRMBase.ToString, 3).ToString

        ''Se obtienen las rutas en donde estén depositadas las grabaciones
        Dim cantidad As Int16 = 0
        Dim tablaGrabaciones As New DataTable
        Dim grabaciones As New clsGrabaciones
        tablaGrabaciones = grabaciones.obtieneRutasGrabaciones()

        Dim grabacion As String = ""
        For Each row As DataRow In tablaGrabaciones.Rows
            Try
                rutaOrigen = row("rutaGrabaciones")
                rutaOrigen = rutaOrigen.Replace("[crm]", nomFinalcrm)
                rutaOrigen = rutaOrigen.Replace("[anio]", anio)
                rutaOrigen = rutaOrigen.Replace("[mes]", Mes)
                rutaOrigen = rutaOrigen.Replace("[dia]", dia)

                Dim di As New IO.DirectoryInfo(rutaOrigen)
                Dim idLlamadaAux As Int64 = Mid(_idLlamada, 2, _idLlamada.Length)
                Dim aryFi As IO.FileInfo() = di.GetFiles("*" + idLlamadaAux.ToString + "*")
                rutaOrigen = rutaOrigen + "\" + aryFi(0).ToString()
                cantidad = 0

                If File.Exists(rutaOrigen) Then
                    grabacion = rutaOrigen
                End If

                crm = nomFinalcrm

                Process.Start(grabacion)
                Exit For

            Catch ex As Exception
                cantidad += 1
                If cantidad = tablaGrabaciones.Rows.Count Then
                    MsgBox("No existe grabacion para este registro.", vbExclamation, "CALIDAD")
                End If
            End Try
        Next

    End Sub

    Private Sub btnEscuchar_Click_1(sender As Object, e As EventArgs) Handles btnEscuchar.Click
        EscucharGrabacion(idCRMBase, fechaGrabacion, NombreGrabacion, lblIdLlamada.Text)


    End Sub


    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If cbEstado.Text = "N" Then
            If cbSubMotivo.SelectedValue <= 0 Then
                MsgBox("Debe seleccionar un subMotivo")
                cbSubMotivo.Focus()
                Exit Sub
            End If

            If cbMotivo.SelectedValue <= 0 Then
                MsgBox("Debe seleccionar un Motivo")
                cbSubMotivo.Focus()
                Exit Sub
            End If
        End If

        subMoti = cbSubMotivo.SelectedValue
        ecalidad = cbEstado.SelectedIndex
        obs = Replace(Replace(txtObservaciones.Text, "'", ""), "´", "")
        GuardarCalidad(idUser, subMoti, idInst, idCRMBase, idRegistro, rut, fec, idEjecutivoCalidad, ecalidad, obs)
        idActualizacionRegistro = ""
        frmEvaluador.listarVentasAEvaluar(frmEvaluador.cmbInstancia.SelectedIndex, frmEvaluador.cmbCampana.SelectedValue, IIf(frmEvaluador.chkConFecha.Checked = True, 1, 0), frmEvaluador.dtpFecha.Value.ToString("yyyyMMdd"), IIf(frmEvaluador.txtID.Text.Trim = "", "0", frmEvaluador.txtID.Text.Trim), frmEvaluador.txtTelefono.Text.Trim)
        Me.Close()

    End Sub

    Private Sub GuardarCalidad(user As String, subMoti As Integer, IdInstancia As Integer, crm As Integer, idRegistro As Integer, rut As Integer, fec As String, ejec As String, ecalidad As String, obs As String)
        Dim tabla As New DataTable
        Dim da As SqlDataAdapter
        Dim cmd As New SqlCommand

        If obs = "" Then
            obs = ""
        Else
            obs.Replace("'", " ")
        End If

        cmd.CommandType = CommandType.StoredProcedure
        Try
            cmd.CommandText = "Entidad.pa_InsertarAsigCalidad"
            cmd.Parameters.AddWithValue("@IdEjecutivo", idEjecutivoCalidad)
            cmd.Parameters.AddWithValue("@IdsubMotivo", subMoti)
            cmd.Parameters.AddWithValue("@IdInstancia", IdInstancia)
            cmd.Parameters.AddWithValue("@CRM", crm)
            cmd.Parameters.AddWithValue("@IdRegistro", idRegistro)
            cmd.Parameters.AddWithValue("@Rut", rut)
            cmd.Parameters.AddWithValue("@FechaVenta", fec)
            cmd.Parameters.AddWithValue("@EjecutivoVendedor", ejec)
            cmd.Parameters.AddWithValue("@EstadoCalidad", ecalidad)
            cmd.Parameters.AddWithValue("@Observaciones", obs)

            cmd.Connection = cnn2
            da = New SqlDataAdapter(cmd)
            da.Fill(tabla)
            MsgBox("Registro guardado correctamente", vbInformation, "")
        Catch ex As Exception
            MsgBox("Error al Guardar datos" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub cbEstado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbEstado.SelectedIndexChanged
        If cbEstado.Text = "N" Then
            gpbMotivos.Visible = True
        Else
            gpbMotivos.Visible = False
        End If
    End Sub

    Private Sub btnOtrasGrabaciones_Click(sender As Object, e As EventArgs) Handles btnOtrasGrabaciones.Click
        frmAsociarGrabacion.ShowDialog()
    End Sub

    Private Sub ActualizarDatosCliente_Click(sender As Object, e As EventArgs) Handles ActualizarDatosCliente.Click

        frmModificacionDatos.ShowDialog()

        ListarDatosCliente(idRegistro, idInst)

    End Sub

    Private Sub ActualizarDatosCliente_MouseEnter(sender As Object, e As EventArgs) Handles ActualizarDatosCliente.MouseEnter
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub ActualizarDatosCliente_MouseLeave(sender As Object, e As EventArgs) Handles ActualizarDatosCliente.MouseLeave
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub frmControlRegistro_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        idActualizacionRegistro = ""
    End Sub


End Class
