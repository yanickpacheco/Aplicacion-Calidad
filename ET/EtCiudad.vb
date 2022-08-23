Imports System.Data.SqlClient

Public Class EtCiudad
    Dim cnn2 As New SqlConnection("data source = 192.168.1.14; initial catalog = BASE_GENERAL_CORDIAL; User id= cp; password=Cordial.passs ")

    Private _idCiudad As Int32
    Private _idRegion As Int32
    Private _nombreCiudad As String
    Private _activo As Boolean

    Public Property idCiudad() As Int32
        Get
            Return _idCiudad
        End Get
        Set(ByVal value As Int32)
            _idCiudad = value
        End Set
    End Property

    Public Property idRegion() As Int32
        Get
            Return _idRegion
        End Get
        Set(ByVal value As Int32)
            _idRegion = value
        End Set
    End Property

    Public Property nombreCiudad() As String
        Get
            Return _nombreCiudad
        End Get
        Set(ByVal value As String)
            _nombreCiudad = value
        End Set
    End Property

    Public Property activo() As Boolean
        Get
            Return _activo
        End Get
        Set(ByVal value As Boolean)
            _activo = value
        End Set
    End Property




    Public Function BuscaCiudadPorIdCiudad(ByVal _idCiudad As Int32) As EtCiudad
        Dim cmd As New SqlCommand
        Dim sql As String
        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        cmd.CommandType = CommandType.StoredProcedure

        sql = "[Entidad].[pa_buscarCiudadPorId]"
        cmd.CommandText = sql
        cmd.Parameters.AddWithValue("@idCiudad", _idCiudad)
        cmd.Connection = cnn2
        da = New SqlDataAdapter(cmd)
        da.Fill(dt)

        Dim row As New EtCiudad

        For x As Int16 = 0 To dt.Rows.Count - 1
            row.idCiudad = IIf(IsDBNull(dt.Rows(x)("idCiudad")), Nothing, dt.Rows(x)("idCiudad"))
            row.idRegion = IIf(IsDBNull(dt.Rows(x)("idRegion")), Nothing, dt.Rows(x)("idRegion"))
            row.nombreCiudad = IIf(IsDBNull(dt.Rows(x)("nombreCiudad")), Nothing, dt.Rows(x)("nombreCiudad"))
        Next

        Return row

    End Function

    Public Function ListaCiudad() As List(Of EtCiudad)

        Dim cmd As New SqlCommand
        Dim sql As String
        Dim dt As New DataTable
        Dim da As SqlDataAdapter


        cmd.CommandType = CommandType.StoredProcedure

        sql = "[Entidad].[pa_listarCiudad]"
        cmd.CommandText = sql
        cmd.Connection = cnn2
        da = New SqlDataAdapter(cmd)
        da.Fill(dt)

        Dim list As New List(Of EtCiudad)
        Dim row As New EtCiudad
        row.idCiudad = 0
        row.nombreCiudad = "--- Sin selección ---"
        list.Add(row)

        For x As Int16 = 0 To dt.Rows.Count - 1
            row = New EtCiudad
            row.idCiudad = IIf(IsDBNull(dt.Rows(x)("idCiudad")), Nothing, dt.Rows(x)("idCiudad"))
            row.idRegion = IIf(IsDBNull(dt.Rows(x)("idRegion")), Nothing, dt.Rows(x)("idRegion"))
            row.nombreCiudad = IIf(IsDBNull(dt.Rows(x)("nombreCiudad")), Nothing, dt.Rows(x)("nombreCiudad"))
            list.Add(row)
        Next

        Return list
    End Function

End Class
