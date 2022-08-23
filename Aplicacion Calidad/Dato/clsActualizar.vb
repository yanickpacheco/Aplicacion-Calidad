Imports System.Data.SqlClient
Imports ET

Public Class clsActualizar

    Dim cnn As New SqlConnection("data source = 192.168.1.14; initial catalog = CALIDAD; User id= cp; password=Cordial.passs")
    Dim cnn2 As New SqlConnection("data source = 192.168.1.14; initial catalog = BASE_GENERAL_CORDIAL; User id= cp; password=Cordial.passs ")


    Public Function buscarDatosTitularModificar(ByVal campaña As String, ByVal id As String) As List(Of EtTitular)
        Dim sql As String
        Dim da As SqlDataAdapter
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        Dim listaTitular As New List(Of EtTitular)

        Try

            cmd.CommandType = CommandType.StoredProcedure
            sql = "Config.pa_BuscaDatosTitularModificar"

            cmd.Parameters.AddWithValue("@idCRM", campaña)
            cmd.Parameters.AddWithValue("@C_id", id)
            cmd.CommandText = sql
            cmd.Connection = cnn
            da = New SqlDataAdapter(cmd)
            da.Fill(dt)

            If dt.Rows.Count <= 0 Then
                Return listaTitular
            Else


                Dim titular As New EtTitular

                titular.Rut = dt.Rows(0)("RUT")
                titular.Dv = dt.Rows(0)("DV")
                titular.Nombre = dt.Rows(0)("NOMBRE")
                titular.Paterno = dt.Rows(0)("PATERNO")
                titular.Materno = dt.Rows(0)("MATERNO")
                titular.FechaNacimiento = dt.Rows(0)("FECHANACIMIENTO")
                titular.Calle = dt.Rows(0)("CALLE")
                titular.Numero = dt.Rows(0)("NUMERO")
                titular.Referencia = dt.Rows(0)("REFERENCIA")
                titular.Comuna = dt.Rows(0)("COMUNA")
                titular.Email = dt.Rows(0)("EMAIL")
                titular.Suministro = dt.Rows(0)("SUMINISTRO")
                titular.RutPagador = dt.Rows(0)("RUT_PAGADOR")
                titular.DvPagador = dt.Rows(0)("DV_PAGADOR")
                titular.NombrePagador = dt.Rows(0)("NOMBRE_PAGADOR")

                listaTitular.Add(titular)

                Return listaTitular

            End If

        Catch ex As Exception
            MsgBox("Error al buscar registro" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")
            Return Nothing
        End Try


    End Function


    Public Function buscarDatosAdicionalModificar(ByVal campaña As String, ByVal id As String) As DataTable
        Dim sql As String
        Dim da As SqlDataAdapter
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        Dim listaAdicional As New List(Of EtAdicional)

        Try

            cmd.CommandType = CommandType.StoredProcedure
            sql = "Config.pa_BuscaDatosAdicionalModificar"

            cmd.Parameters.AddWithValue("@idCRM", campaña)
            cmd.Parameters.AddWithValue("@C_id", id)
            cmd.CommandText = sql
            cmd.Connection = cnn
            da = New SqlDataAdapter(cmd)
            da.Fill(dt)

            If dt.Rows.Count <= 0 Then
                Return Nothing
            Else

                Return dt

            End If

        Catch ex As Exception
            MsgBox("Error al buscar adicional" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")
            Return Nothing
        End Try


    End Function

    Public Function buscarDatosBeneficiarioModificar(ByVal campaña As String, ByVal id As String) As DataTable
        Dim sql As String
        Dim da As SqlDataAdapter
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        Try

            cmd.CommandType = CommandType.StoredProcedure
            sql = "Config.pa_BuscaDatosBeneficiarioModificar"

            cmd.Parameters.AddWithValue("@idCRM", campaña)
            cmd.Parameters.AddWithValue("@C_id", id)
            cmd.CommandText = sql
            cmd.Connection = cnn
            da = New SqlDataAdapter(cmd)
            da.Fill(dt)

            If dt.Rows.Count <= 0 Then
                Return Nothing
            Else

                Return dt

            End If

        Catch ex As Exception
            MsgBox("Error al buscar Beneficiario" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")
            Return Nothing
        End Try


    End Function



    Public Function buscarDatosPolizaModificar(ByVal campaña As String, ByVal id As String) As DataTable
        Dim sql As String
        Dim da As SqlDataAdapter
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        Try

            cmd.CommandType = CommandType.StoredProcedure
            sql = "Config.pa_BuscaDatosPolizaModificar"

            cmd.Parameters.AddWithValue("@idCRM", campaña)
            cmd.Parameters.AddWithValue("@C_id", id)
            cmd.CommandText = sql
            cmd.Connection = cnn
            da = New SqlDataAdapter(cmd)
            da.Fill(dt)

            If dt.Rows.Count <= 0 Then
                Return Nothing
            Else

                Return dt

            End If

        Catch ex As Exception
            MsgBox("Error al buscar Polizas" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")
            Return Nothing
        End Try


    End Function



    Public Function ActualizarDatosTitular(ByVal campaña As String, ByVal id As String, ByVal rut As String, ByVal nombre As String, ByVal paterno As String, ByVal materno As String, ByVal fechaNacimiento As String, ByVal calle As String, ByVal Nro As String, ByVal referencia As String, ByVal comuna As String, ByVal ciudad As String, ByVal email As String, ByVal suministro As String, ByVal rutPagador As String, ByVal nombrePagador As String) As Boolean
        Dim sql As String
        Dim da As SqlDataAdapter
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        Dim listaTitular As New List(Of EtTitular)

        Try

            cmd.CommandType = CommandType.StoredProcedure
            sql = "Config.pa_ActualizaDatosTitular"

            cmd.Parameters.AddWithValue("@idCRM", campaña)
            cmd.Parameters.AddWithValue("@C_id", id)
            cmd.Parameters.AddWithValue("@rut", rut)
            cmd.Parameters.AddWithValue("@nombre", nombre)
            cmd.Parameters.AddWithValue("@paterno", paterno)
            cmd.Parameters.AddWithValue("@materno", materno)
            cmd.Parameters.AddWithValue("@fechaNacimiento", fechaNacimiento)
            cmd.Parameters.AddWithValue("@calle", calle)
            cmd.Parameters.AddWithValue("@numero", Nro)
            cmd.Parameters.AddWithValue("@referencia", referencia)
            cmd.Parameters.AddWithValue("@comuna", comuna)
            cmd.Parameters.AddWithValue("@ciudad", ciudad)
            cmd.Parameters.AddWithValue("@email", email)
            cmd.Parameters.AddWithValue("@suministro", suministro)
            cmd.Parameters.AddWithValue("@rutPagador", rutPagador)
            cmd.Parameters.AddWithValue("@nombrePagador", nombrePagador)
            cmd.CommandText = sql
            cmd.Connection = cnn
            da = New SqlDataAdapter(cmd)
            da.Fill(dt)

            Return True

        Catch ex As Exception
            MsgBox("Error al actualizar Titular" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try


    End Function


    Public Function ActualizarDatosAdicional(ByVal campaña As String, ByVal id As String, ByVal idAdicional As String, ByVal rut As String, ByVal nombre As String, ByVal paterno As String, ByVal materno As String, ByVal fechaNacimiento As String, ByVal tipoAdicional As Integer, ByVal peso As String, ByVal estatura As String) As Boolean
        Dim sql As String
        Dim da As SqlDataAdapter
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        Dim listaTitular As New List(Of EtTitular)

        Try

            cmd.CommandType = CommandType.StoredProcedure
            sql = "Config.pa_ActualizaDatosAdicional"

            cmd.Parameters.AddWithValue("@idCRM", campaña)
            cmd.Parameters.AddWithValue("@C_id", id)
            cmd.Parameters.AddWithValue("@idAdicional", idAdicional)
            cmd.Parameters.AddWithValue("@rut", rut)
            cmd.Parameters.AddWithValue("@nombre", nombre)
            cmd.Parameters.AddWithValue("@paterno", paterno)
            cmd.Parameters.AddWithValue("@materno", materno)
            cmd.Parameters.AddWithValue("@fechaNacimiento", fechaNacimiento)
            cmd.Parameters.AddWithValue("@tipoAdicional", tipoAdicional)
            cmd.Parameters.AddWithValue("@peso", peso)
            cmd.Parameters.AddWithValue("@estatura", estatura)
            cmd.CommandText = sql
            cmd.Connection = cnn
            da = New SqlDataAdapter(cmd)
            da.Fill(dt)

            Return True

        Catch ex As Exception
            MsgBox("Error al actualizar Adicional" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try


    End Function

    Public Function ActualizarDatosBeneficiario(ByVal campaña As String, ByVal id As String, ByVal idBeneficiario As String, ByVal rut As String, ByVal nombre As String, ByVal paterno As String, ByVal materno As String, ByVal fechaNacimiento As String, ByVal tipoBeneficiario As Integer) As Boolean
        Dim sql As String
        Dim da As SqlDataAdapter
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        Dim listaTitular As New List(Of EtTitular)

        Try

            cmd.CommandType = CommandType.StoredProcedure
            sql = "Config.pa_ActualizaDatosBeneficiario"

            cmd.Parameters.AddWithValue("@idCRM", campaña)
            cmd.Parameters.AddWithValue("@C_id", id)
            cmd.Parameters.AddWithValue("@idBeneficiario", idBeneficiario)
            cmd.Parameters.AddWithValue("@rut", rut)
            cmd.Parameters.AddWithValue("@nombre", nombre)
            cmd.Parameters.AddWithValue("@paterno", paterno)
            cmd.Parameters.AddWithValue("@materno", materno)
            cmd.Parameters.AddWithValue("@fechaNacimiento", fechaNacimiento)
            cmd.Parameters.AddWithValue("@tipoBeneficiario", tipoBeneficiario)
            cmd.CommandText = sql
            cmd.Connection = cnn
            da = New SqlDataAdapter(cmd)
            da.Fill(dt)

            Return True

        Catch ex As Exception
            MsgBox("Error al actualizar Beneficiario" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try


    End Function

    Public Function ActualizarDatoPolizas(ByVal campaña As String, ByVal id As String, ByVal idPoliza As String, ByVal rut As String, ByVal nombre As String, ByVal paterno As String, ByVal materno As String, ByVal fechaNacimiento As String, ByVal calle As String, ByVal Nro As String, ByVal referencia As String, ByVal comuna As String, ByVal email As String, ByVal Peso As String, ByVal estatura As String) As Boolean
        Dim sql As String
        Dim da As SqlDataAdapter
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        Try

            cmd.CommandType = CommandType.StoredProcedure
            sql = "Config.pa_ActualizaDatosPolizas"

            cmd.Parameters.AddWithValue("@idCRM", campaña)
            cmd.Parameters.AddWithValue("@C_id", id)
            cmd.Parameters.AddWithValue("@idPoliza", idPoliza)
            cmd.Parameters.AddWithValue("@rut", rut)
            cmd.Parameters.AddWithValue("@nombre", nombre)
            cmd.Parameters.AddWithValue("@paterno", paterno)
            cmd.Parameters.AddWithValue("@materno", materno)
            cmd.Parameters.AddWithValue("@fechaNacimiento", fechaNacimiento)
            cmd.Parameters.AddWithValue("@calle", calle)
            cmd.Parameters.AddWithValue("@numero", Nro)
            cmd.Parameters.AddWithValue("@referencia", referencia)
            cmd.Parameters.AddWithValue("@comuna", comuna)
            cmd.Parameters.AddWithValue("@email", email)
            cmd.Parameters.AddWithValue("@peso", Peso)
            cmd.Parameters.AddWithValue("@estatura", estatura)
            cmd.CommandText = sql
            cmd.Connection = cnn
            da = New SqlDataAdapter(cmd)
            da.Fill(dt)

            Return True

        Catch ex As Exception
            MsgBox("Error al actualizar Polizas" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try


    End Function

End Class
