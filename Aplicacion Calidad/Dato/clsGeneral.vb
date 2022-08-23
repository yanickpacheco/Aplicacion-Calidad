Imports System.Data.SqlClient

Public Class clsGeneral


    Dim cnn2 As New SqlConnection("data source = 192.168.1.14; initial catalog = BASE_GENERAL_CORDIAL; User id= cp; password=Cordial.passs ")

    Public Sub ListaCampañas(combo As ComboBox)
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

End Class
