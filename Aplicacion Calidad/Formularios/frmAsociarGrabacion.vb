Imports System.Data.SqlClient
Imports System.IO

Public Class frmAsociarGrabacion
    Private Sub frmAsociarGrabacion_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtId.Text = idRegistro
        listarAudiosAsociados(idRegistro, idCRMBase, nombreEjecutivo, idInst)
    End Sub

    Private Sub listarAudiosAsociados(ByVal id As Integer, ByVal crm As String, ByVal ejecutivo As String, ByVal instancia As Integer)
        Dim tabla As New DataTable
        Dim da As SqlDataAdapter
        Dim cnn As New SqlConnection("data source = 192.168.1.14; initial catalog = BASE_GENERAL_CORDIAL; User Id= cp; Password=Cordial.passs")
        Dim cmd As New SqlCommand
        Dim Simbolo As String = ""
        Dim sql As String = ""

        '    dtgGrabaciones.DataSource = ""
        'dtgGrabaciones.Rows.Clear()

        cmd.CommandType = CommandType.StoredProcedure
        Try
            sql = "Gestion.pa_ListaGrabacionesPorId"
            cmd.Parameters.AddWithValue("@C_ID", id)
            cmd.Parameters.AddWithValue("@idCRm", crm)
            cmd.Parameters.AddWithValue("@ejecutivo", ejecutivo)
            cmd.Parameters.AddWithValue("@idInstancia", instancia)

            cmd.CommandText = sql
            cmd.Connection = cnn
            da = New SqlDataAdapter(cmd)
            da.Fill(tabla)

            If tabla.Rows.Count <= 0 Then
                MsgBox("No existen datos de grabaciones para mostrar", vbInformation, "")
            End If

            dtgGrabaciones.DataSource = tabla
            dtgGrabaciones.RowHeadersWidth = 60

            For i As Integer = 0 To dtgGrabaciones.Rows.Count - 1
                If dtgGrabaciones.Rows(i).Cells(8).Value = 1 Then
                    dtgGrabaciones.Rows(i).DefaultCellStyle.BackColor = Color.Green
                    dtgGrabaciones.Rows(i).DefaultCellStyle.ForeColor = Color.White
                End If
            Next

        Catch ex As Exception
            MsgBox("Error Listar Grabaciones Por Id" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        frmControlRegistro.ListarDatosCliente(idRegistro, idInst)
        Me.Close()
    End Sub

    Private Sub dtgGrabaciones_CellMouseMove(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dtgGrabaciones.CellMouseMove
        If e.ColumnIndex = 0 Then
            Me.Cursor = Cursors.Hand
        Else
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub dtgGrabaciones_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgGrabaciones.CellContentDoubleClick
        If e.ColumnIndex = 0 Then
            If (MsgBox("¿Desea asociar este audio como el audio de Venta?", vbYesNo, "Asociar Grabacion")) = vbYes Then
                actualizarGrabacion(idRegistro, dtgGrabaciones.Rows(e.RowIndex).Cells(1).Value, idCRMBase, idInst)
            End If
        Else
            EscucharGrabacion(dtgGrabaciones.Rows(e.RowIndex).Cells(3).Value, dtgGrabaciones.Rows(e.RowIndex).Cells(1).Value)
        End If
    End Sub

    Private Sub actualizarGrabacion(ByVal id As Integer, ByVal idLlamada As String, ByVal idCRM As String, ByVal instancia As Integer)
        Dim tabla As New DataTable
        Dim da As SqlDataAdapter
        Dim cnn As New SqlConnection("data source = 192.168.1.14; initial catalog = BASE_GENERAL_CORDIAL; User Id= cp; Password=Cordial.passs")
        Dim cmd As New SqlCommand
        Dim Simbolo As String = ""
        Dim sql As String = ""



        cmd.CommandType = CommandType.StoredProcedure
        Try
            sql = "Gestion.pa_AsociarGrabacion"
            cmd.Parameters.AddWithValue("@C_ID", id)
            cmd.Parameters.AddWithValue("@IdLlamada", idLlamada)
            cmd.Parameters.AddWithValue("@idCRM", idCRM)
            cmd.Parameters.AddWithValue("@idInstancia", instancia)

            cmd.CommandText = sql
            cmd.Connection = cnn
            da = New SqlDataAdapter(cmd)
            da.Fill(tabla)

            MsgBox("Grabacion asociada correctamente", vbInformation, "Actualización Correcta")
            listarAudiosAsociados(idRegistro, idCRMBase, nombreEjecutivo, idInst)

        Catch ex As Exception
            MsgBox("Error Asociar Grabacion" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub EscucharGrabacion(ByVal fecha As String, ByVal _idLlamada As String)
        Dim dia As String
        Dim Mes As String
        Dim anio As String
        Dim rutaOrigen As String

        dia = Mid(fecha, 1, 2)
        Mes = Mid(fecha, 4, 2)
        anio = Mid(fecha, 7, 4)

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
                    MsgBox("No existe grabacion para este llamado.", vbExclamation, "CALIDAD")
                End If
            End Try
        Next
    End Sub

End Class