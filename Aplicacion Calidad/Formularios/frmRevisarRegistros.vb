Imports System.Data.SqlClient

Public Class frmRevisarRegistros
    Dim cnn As New SqlConnection("data source = 192.168.1.14; initial catalog = CALIDAD; User id= cp; password=Cordial.passs ")
    Dim cnn2 As New SqlConnection("data source = 192.168.1.14; initial catalog = BASE_GENERAL_CORDIAL; User id= cp; password=Cordial.passs ")
    Dim tabla As New DataTable

    Private Sub frmRevisarRegistros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListaCampañas(cbCRM)
        LimpiaFormulario()
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

    Private Sub BuscarVentasPorID(instancia As Integer, crm As Object, id As Object, rut As String, desde As String, hasta As String)
        Dim da As SqlDataAdapter
        Dim cmd As New SqlCommand

        Try
            tabla.Clear()
            dtgRegistros.DataSource = Nothing
            dtgRegistros.Rows.Clear()
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "Gestion.pa_BuscarRegistros"
            cmd.Parameters.AddWithValue("@idInstancia", instancia)
            cmd.Parameters.AddWithValue("@idCRM", crm)
            cmd.Parameters.AddWithValue("@C_id", id)
            cmd.Parameters.AddWithValue("@rut", rut)
            cmd.Parameters.AddWithValue("@Desde", desde)
            cmd.Parameters.AddWithValue("@Hasta", hasta)
            cmd.Connection = cnn

            da = New SqlDataAdapter(cmd)
            da.Fill(tabla)

            If tabla.Rows.Count <= 0 Then
                MsgBox("No existen datos de cliente para mostrar", vbInformation, "")
                dtgRegistros.DataSource = Nothing
                Exit Sub
            End If

            dtgRegistros.DataSource = tabla
            dtgRegistros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        Catch ex As Exception
            MsgBox("Error al buscar registro" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub LimpiaFormulario()
        chkId.Checked = False
        chkRangoFechas.Checked = False
        chkRut.Checked = False
        cbEstado.SelectedIndex = 0
        dtgRegistros.DataSource = Nothing
        txtID.Enabled = chkId.Checked
        txtRut.Enabled = chkRut.Checked
        dtpDesde.Enabled = chkRangoFechas.Checked
        dtpHasta.Enabled = chkRangoFechas.Checked
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        If cbCRM.SelectedIndex < 0 Then
            MsgBox("Debe seleccionar una campaña." & vbNewLine, MsgBoxStyle.Critical, "Error")
            cbCRM.Focus()
            Exit Sub
        End If

        Dim id As String = "0"
        Dim rut As String = "0"
        Dim desde As String = dtpDesde.Value.ToString("yyyyMMdd")
        Dim hasta As String = dtpHasta.Value.ToString("yyyyMMdd")

        If chkRut.Checked Then
            If txtRut.Text = "" Then
                MsgBox("Debe ingresar Rut para buscar un registro." & vbNewLine, MsgBoxStyle.Critical, "Error")
                txtRut.Focus()
                Exit Sub
            Else
                rut = txtRut.Text
            End If
        End If

        If chkId.Checked Then
            If txtID.Text = "" Then
                MsgBox("Debe ingresar ID para buscar un registro." & vbNewLine, MsgBoxStyle.Critical, "Error")
                txtID.Focus()
                Exit Sub
            Else
                id = txtID.Text
            End If
        End If

        If Not chkRangoFechas.Checked Then
            desde = ""
            hasta = ""
        End If

        BuscarVentasPorID(cbEstado.SelectedIndex, cbCRM.SelectedValue, id, rut, desde, hasta)
    End Sub

    Private Sub check_CheckedChanged(sender As Object, e As EventArgs) Handles chkId.CheckedChanged, chkRut.CheckedChanged, chkRangoFechas.CheckedChanged
        txtID.Enabled = chkId.Checked
        txtRut.Enabled = chkRut.Checked
        dtpDesde.Enabled = chkRangoFechas.Checked
        dtpHasta.Enabled = chkRangoFechas.Checked
    End Sub

    Private Sub dtgRegistros_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgRegistros.CellContentDoubleClick
        If cbEstado.SelectedIndex = 0 Then
            MsgBox("Para escuchar los audios debe seleccionar un estado." & vbNewLine, MsgBoxStyle.Critical, "Error")
            cbEstado.Focus()
            Exit Sub
        End If

        If e.RowIndex < 0 Then
            Exit Sub
        End If

        idRegistro = tabla.Rows(e.RowIndex)("ID")
        idCRMBase = cbCRM.SelectedValue
        nombreEjecutivo = tabla.Rows(e.RowIndex)("EJECUTIVO")
        idInst = cbEstado.SelectedIndex

        frmAsociarGrabacion.ShowDialog()
    End Sub

End Class