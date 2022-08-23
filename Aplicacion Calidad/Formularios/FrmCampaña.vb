Imports System.Data.SqlClient
Public Class FrmCampaña
    Dim bandera As Boolean

    Private Sub Actualiza_Cel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bandera = False
    End Sub

    'Private Sub BtCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtCerrar.Click
    '    bandera = True
    '    Close()
    'End Sub

    Private Sub Actualiza_Cel_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        If bandera = False Then
            e.Cancel = True
        Else
            e.Cancel = False
        End If
    End Sub

    Dim cnn As New SqlConnection("data source = 192.168.1.14; initial catalog = CALIDAD; User id= cp; password=Cordial.passs ")

    Private Sub FormCampaña_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListaCampañas(cmbEjecutivoCalidad)
    End Sub

    Private Sub ListaCampañas(ByVal combo As ComboBox)
        Dim miTabla As New DataTable
        Dim dA As SqlDataAdapter
        Dim cmd As New SqlCommand
        Dim sql As String = ""
        cmd.CommandType = CommandType.StoredProcedure
        Try
            sql = "[Entidad].[pa_ListaUsuario]"
            cmd.CommandText = sql
            cmd.Connection = cnn
            dA = New SqlDataAdapter(cmd)
            dA.Fill(miTabla)

            combo.DataSource = miTabla
            combo.DisplayMember = "NombreEjecutivo"
            combo.ValueMember = "IdEjecutivo"
            combo.SelectedIndex = -1

        Catch ex As Exception

            MsgBox("Error Listar Campañas" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")

        End Try


    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        If cmbEjecutivoCalidad.SelectedIndex < 0 Then
            MsgBox("Debe seleccionar ejecutivo", vbExclamation)
            Exit Sub
        End If
        If txtClave.Text = "" Then
            MsgBox("Debe ingresar Clave", vbExclamation)
            Exit Sub
        End If

        If validaUsuario(cmbEjecutivoCalidad.Text, txtClave.Text) = False Then
            lblClaveInvalida.Visible = True
        Else
            lblClaveInvalida.Visible = False
            idEjecutivoCalidad = cmbEjecutivoCalidad.SelectedValue



            frmMenu.ShowDialog()

            Me.WindowState = FormWindowState.Minimized

        End If


        'MsgBox("El CRM seleccionado es " & idCrm)
        'Me.Close()


    End Sub

    Private Function validaUsuario(ByVal usuario As String, ByVal clave As String) As Boolean
        Dim miTabla As New DataTable
        Dim dA As SqlDataAdapter
        Dim cmd As New SqlCommand
        Dim sql As String = ""
        cmd.CommandType = CommandType.StoredProcedure
        Try
            sql = "[Config].pa_validaUsuarioVentas"
            cmd.CommandText = sql
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@usuario", usuario)
            cmd.Parameters.AddWithValue("@clave", clave)
            dA = New SqlDataAdapter(cmd)
            dA.Fill(miTabla)

            If miTabla.Rows.Count = 0 Then
                validaUsuario = False
            Else
                validaUsuario = True
            End If

        Catch ex As Exception

            MsgBox("Error Validar Usuario" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")
            validaUsuario = False
        End Try


    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Me.Close()
        'Me.Hide()
        End
    End Sub

End Class