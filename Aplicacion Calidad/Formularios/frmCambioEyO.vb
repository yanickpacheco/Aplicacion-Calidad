Imports System.Data.SqlClient

Public Class frmCambioEyO
    Dim cnn As New SqlConnection("data source = 192.168.1.14; initial catalog = CALIDAD; User id= cp; password=Cordial.passs ")
    Dim cnn2 As New SqlConnection("data source = 192.168.1.14; initial catalog = BASE_GENERAL_CORDIAL; User id= cp; password=Cordial.passs ")
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        If txtID.Text.Trim = "" Then
            MsgBox("Debe ingresar ID para buscar un registro" & vbNewLine, MsgBoxStyle.Critical, "Error")
            txtID.Focus()
            Exit Sub
        End If

        BuscarVentasPorID(cbEstado.SelectedIndex, cbCRM.SelectedValue, IIf(txtID.Text.Trim = "", "0", txtID.Text.Trim))
    End Sub

    Private Sub BuscarVentasPorID(instancia As Integer, crm As Object, id As Object)
        Dim tabla As New DataTable
        Dim da As SqlDataAdapter
        Dim cmd As New SqlCommand
        Dim Simbolo As String = ""
        Dim sql As String = ""



        cmd.CommandType = CommandType.StoredProcedure

        Try
            sql = "Gestion.pa_BuscarVentasPorID"
            cmd.Parameters.AddWithValue("@idInstancia", instancia)
            cmd.Parameters.AddWithValue("@idCRM", crm)
            cmd.Parameters.AddWithValue("@C_id", id)

            cmd.CommandText = sql
            cmd.Connection = cnn
            da = New SqlDataAdapter(cmd)
            da.Fill(tabla)

            If tabla.Rows.Count <= 0 Then
                MsgBox("No existen datos de cliente para mostrar", vbInformation, "")
                btnGuardar.Enabled = False
                Exit Sub
            End If

            dtgEvaluaciones.DataSource = tabla

            If instancia = 1 Then
                txtObs.Text = dtgEvaluaciones.Rows(0).Cells(7).Value
            ElseIf instancia = 2 Then
                txtObs.Text = dtgEvaluaciones.Rows(0).Cells(9).Value
            End If

            dtgEvaluaciones.DataSource = tabla
            dtgEvaluaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

            btnGuardar.Enabled = True

        Catch ex As Exception
            MsgBox("Error al buscar registro" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub frmCambioEyO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListaCampañas(cbCRM)
        LimpiaFormulario()

    End Sub

    Private Sub LimpiaFormulario()
        cbEstate.Visible = False
        chkCambiarEstado.Checked = False
        chkCambiarObs.Checked = False
        cbEstado.SelectedIndex = 0
        txtObs.Visible = False
        btnGuardar.Enabled = False
        dtgEvaluaciones.DataSource = Nothing
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

    Private Sub chkCambiarEstado_CheckedChanged(sender As Object, e As EventArgs) Handles chkCambiarEstado.CheckedChanged
        If chkCambiarEstado.Checked = True Then
            cbEstate.Visible = True
        Else
            cbEstate.Visible = False
        End If
    End Sub

    Private Sub chkCambiarObs_CheckedChanged(sender As Object, e As EventArgs) Handles chkCambiarObs.CheckedChanged
        If chkCambiarObs.Checked = True Then
            txtObs.Visible = True
        Else
            txtObs.Visible = False
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        GuardarCambios(cbEstado.SelectedIndex, cbCRM.SelectedValue, IIf(txtID.Text.Trim = "", "0", txtID.Text.Trim), cbEstate.Text, txtObs.Text)
        LimpiaFormulario()
    End Sub

    Private Sub GuardarCambios(inst As Integer, crm As Object, id As Object, estado As Object, obs As String)


        If chkCambiarEstado.Checked = False And chkCambiarObs.Checked = False Then
            MsgBox("Debe ingresar al menos una opción a modificar" & vbNewLine, MsgBoxStyle.Critical, "Error")
            chkCambiarEstado.Focus()
            Exit Sub
        End If


        If chkCambiarEstado.Checked = False And chkCambiarObs.Checked = True Then
            estado = ""
        End If

        If chkCambiarEstado.Checked = True And chkCambiarObs.Checked = False Then
            obs = ""
        End If


        If cbEstado.SelectedIndex <= 0 Then
            MsgBox("Debe ingresar al menos una instancia a modificar" & vbNewLine, MsgBoxStyle.Critical, "Error")
            cbEstado.Focus()
            Exit Sub
        End If

        If chkCambiarEstado.Checked = True And cbEstate.SelectedIndex <= 0 Then
            MsgBox("Debe ingresar un estado a modificar" & vbNewLine, MsgBoxStyle.Critical, "Error")
            cbEstate.Focus()
            Exit Sub
        End If

        If chkCambiarObs.Checked = True And txtObs.Text = "" Then
            MsgBox("Debe ingresar una observación" & vbNewLine, MsgBoxStyle.Critical, "Error")
            txtObs.Focus()
            Exit Sub
        End If




        Dim miTabla As New DataTable
                Dim dA As SqlDataAdapter
                Dim cmd As New SqlCommand
                Dim sql As String = ""
        cmd.CommandType = CommandType.StoredProcedure

        obs.Replace("'", " ")

        Try
                    sql = "Gestion.pa_ActualizaEstado"
                    cmd.Parameters.AddWithValue("@IdInstancia", inst)
                    cmd.Parameters.AddWithValue("@idCrm", crm)
                    cmd.Parameters.AddWithValue("@IdRegistro", id)
                    cmd.Parameters.AddWithValue("@EstadoCalidad", estado)
                    cmd.Parameters.AddWithValue("@Observaciones", obs)

                    cmd.CommandText = sql
                    cmd.Connection = cnn
                    dA = New SqlDataAdapter(cmd)
                    dA.Fill(miTabla)

            MsgBox("Registro actualizado correctamente" & vbNewLine & vbNewLine & "SE ACTUALIZARON " & miTabla.Rows(0)("TOTAL") & " REGISTRO", MsgBoxStyle.Information, "Información")
            LimpiaFormulario()


        Catch ex As Exception
                    MsgBox("Error al actualizar registro" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")
                    Me.Cursor = Cursors.Default
                End Try





    End Sub
End Class