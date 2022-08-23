Imports System.Data.SqlClient

Public Class EtComuna
    Dim cnn2 As New SqlConnection("data source = 192.168.1.14; initial catalog = BASE_GENERAL_CORDIAL; User id= cp; password=Cordial.passs ")


    Private _idComuna As Int32
    Private _nombreComuna As String
    Private _idCiudad As Int32
    Private _activo As Boolean

    Public Property idComuna() As Int32
        Get
            Return _idComuna
        End Get
        Set(ByVal value As Int32)
            _idComuna = value
        End Set
    End Property

    Public Property nombreComuna() As String
        Get
            Return _nombreComuna
        End Get
        Set(ByVal value As String)
            _nombreComuna = value
        End Set
    End Property

    Public Property idCiudad() As Int32
        Get
            Return _idCiudad
        End Get
        Set(ByVal value As Int32)
            _idCiudad = value
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


    Public Function listarComuna() As List(Of EtComuna)

        Dim cmd As New SqlCommand
        Dim sql As String
        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        cmd.CommandType = CommandType.StoredProcedure

        sql = "Entidad.pa_listarComunas"
        cmd.CommandText = sql
        cmd.Connection = cnn2
        da = New SqlDataAdapter(cmd)
        da.Fill(dt)

        Dim listComunas As New List(Of EtComuna)

        For x As Int16 = 0 To dt.Rows.Count - 1
            Dim row As New EtComuna

            row.idComuna = IIf(IsDBNull(dt.Rows(x)("idComuna")), Nothing, dt.Rows(x)("idComuna"))
            row.nombreComuna = IIf(IsDBNull(dt.Rows(x)("nombreComuna")), Nothing, dt.Rows(x)("nombreComuna"))
            row.idCiudad = IIf(IsDBNull(dt.Rows(x)("idCiudad")), Nothing, dt.Rows(x)("idCiudad"))
            listComunas.Add(row)
        Next

        Return listComunas

    End Function

End Class
