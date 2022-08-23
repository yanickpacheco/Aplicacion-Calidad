Imports System.Data.SqlClient

Public Class frmMarcarNN
    Dim cnn As New SqlConnection("data source = 192.168.1.14; initial catalog = CALIDAD; User id= cp; password=Cordial.passs ")
    Dim cnn2 As New SqlConnection("data source = 192.168.1.14; initial catalog = BASE_GENERAL_CORDIAL; User id= cp; password=Cordial.passs ")
    Dim tabla As New DataTable
    Dim miTabla As New DataTable

    Private Sub frmMarcarNN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListaCampañas(cbCRM)
        LimpiaFormulario()
    End Sub

    Private Sub ListaCampañas(combo As ComboBox)
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

    Private Sub BuscarVentasPorID(crm As Object, id As Object, rut As String, desde As String, hasta As String)
        Dim da As SqlDataAdapter
        Dim cmd As New SqlCommand

        Try
            tabla.Clear()
            dtgRegistros.DataSource = Nothing
            dtgRegistros.Rows.Clear()
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "Gestion.pa_BuscarRegistros"
            cmd.Parameters.AddWithValue("@idCRM", crm)
            cmd.Parameters.AddWithValue("@idInstancia", 2)
            cmd.Parameters.AddWithValue("@C_id", id)
            cmd.Parameters.AddWithValue("@rut", rut)
            cmd.Parameters.AddWithValue("@Desde", desde)
            cmd.Parameters.AddWithValue("@Hasta", hasta)
            cmd.Parameters.AddWithValue("@NN", "N")
            cmd.Connection = cnn

            da = New SqlDataAdapter(cmd)
            da.Fill(tabla)

            If tabla.Rows.Count <= 0 Then
                MsgBox("No existen datos de cliente para mostrar", vbInformation, "")
                dtgRegistros.DataSource = Nothing
                lblCantidadRegistros.Text = "Cantidad: 0"
                Exit Sub
            End If

            dtgRegistros.DataSource = tabla
            dtgRegistros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            lblCantidadRegistros.Text = "Cantidad: " + dtgRegistros.Rows.Count.ToString
        Catch ex As Exception
            MsgBox("Error al buscar registro" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub LimpiaFormulario()
        chkId.Checked = False
        chkRangoFechas.Checked = False
        chkRut.Checked = False
        dtgRegistros.DataSource = Nothing
        txtID.Enabled = chkId.Checked
        txtRut.Enabled = chkRut.Checked
        dtpDesde.Enabled = chkRangoFechas.Checked
        dtpHasta.Enabled = chkRangoFechas.Checked
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

        BuscarVentasPorID(cbCRM.SelectedValue, id, rut, desde, hasta)
    End Sub

    Private Sub check_CheckedChanged(sender As Object, e As EventArgs) Handles chkId.CheckedChanged, chkRut.CheckedChanged, chkRangoFechas.CheckedChanged
        txtID.Enabled = chkId.Checked
        txtRut.Enabled = chkRut.Checked
        dtpDesde.Enabled = chkRangoFechas.Checked
        dtpHasta.Enabled = chkRangoFechas.Checked
    End Sub

    Private Sub dtgRegistros_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgRegistros.CellContentDoubleClick
        If e.RowIndex < 0 Then
            Exit Sub
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtObs.Text = "" Then
            MsgBox("Debe agregar una observación.", MsgBoxStyle.Information, "Advertencia")
            Exit Sub
        End If

        Try
            Dim lista As New DataTable
            lista.Columns.Add("id", GetType(Integer))

            Dim id, i As Integer
            Dim idList(dtgRegistros.Rows.Count - 1)
            For Each selectedItem As DataGridViewRow In dtgRegistros.Rows
                'show ids of multiple selected rows
                If selectedItem.Cells("ID").Value > 0 Then
                    id = selectedItem.Cells("ID").Value
                    idList(i) = id
                    lista.Rows.Add(id)
                    i += 1
                End If
            Next selectedItem

            MacarRegistros(lista)
        Catch ex As Exception
            MsgBox("Error al buscar registro" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Public Sub MacarRegistros(ByVal _lista As DataTable)
        Dim cnn As SqlConnection = New SqlConnection()
        cnn.ConnectionString = "data source = 192.168.1.14; initial catalog = CALIDAD; User id= cp; password=Cordial.passs "
        Dim Sql = New SqlCommand("[Gestion].pa_MarcaEstadoNN", cnn)
        Sql.CommandType = CommandType.StoredProcedure

        tabla = _lista
        Sql.Parameters.AddWithValue("@idCRM", cbCRM.SelectedValue)
        Sql.Parameters.AddWithValue("@Observaciones", txtObs.Text)
        Sql.Parameters.AddWithValue("@Desiste", IIf(chkDesiste.Visible, chkDesiste.Checked, False))
        Sql.Parameters.AddWithValue("@listaID", tabla)

        cnn.Open()
        Dim customerTable As New DataTable("Customer")
        If cnn.State = ConnectionState.Open Then
            Using dataReader As SqlDataReader = Sql.ExecuteReader()
                customerTable.Load(dataReader)
            End Using
            cnn.Close()
            MsgBox("Se marcaron " + customerTable.Rows.Count.ToString + " registros")
        End If
    End Sub

    Private Sub cbCRM_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCRM.SelectedIndexChanged
        Try
            For Each row As DataRow In miTabla.Rows
                If row("crm") = cbCRM.SelectedValue Then
                    If row("clinica") = True Then
                        chkDesiste.Visible = True
                        Exit Sub
                    Else
                        chkDesiste.Visible = False
                        Exit Sub
                    End If
                End If
            Next
        Catch ex As Exception

        End Try
    End Sub

End Class