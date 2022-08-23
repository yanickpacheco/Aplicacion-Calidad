Imports System.Data.SqlClient

Public Class EtParentesco

    Private _idParentesco As Integer
    Private _nombreParentesco As String

    Dim cnn As New SqlConnection("data source = 192.168.1.14; initial catalog = BASE_GENERAL_CORDIAL; User id= cp; password=Cordial.passs ")
    Public Sub New(idParentesco As Integer, nombreParentesco As String)
        _idParentesco = idParentesco
        _nombreParentesco = nombreParentesco
    End Sub

    Public Sub New()
        _idParentesco = 0
        _nombreParentesco = ""
    End Sub
    Public Property IdParentesco As Integer
        Get
            Return _idParentesco
        End Get
        Set(value As Integer)
            _idParentesco = value
        End Set
    End Property

    Public Property NombreParentesco As String
        Get
            Return _nombreParentesco
        End Get
        Set(value As String)
            _nombreParentesco = value
        End Set
    End Property

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="_idCRM">Campaña a Buscar Parentescos</param>
    ''' <param name="_tipoPersona">Tipo de Parentesco, 1 para Beneficiario, 2 para Adicional</param>
    ''' <returns></returns>
    Public Function BuscaParentescoPorId(ByVal _idCRM As Integer, ByVal _tipoPersona As Integer) As List(Of EtParentesco)


        Dim cmd As New SqlCommand
        Dim sql As String
        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        cmd.CommandType = CommandType.StoredProcedure

        sql = "[Gestion].[pa_ListaParentescoPorCRM]"
        cmd.Parameters.AddWithValue("@CRM", _idCRM)
        cmd.Parameters.AddWithValue("@tipoPersona", _tipoPersona)
        cmd.CommandText = sql
        cmd.Connection = cnn
        da = New SqlDataAdapter(cmd)
        da.Fill(dt)

        Dim listParentesco As New List(Of EtParentesco)

        Dim parentesco As New EtParentesco
        parentesco.IdParentesco = 0
        parentesco.NombreParentesco = "---No Ingresado---"
        listParentesco.Add(parentesco)

        For x As Int16 = 0 To dt.Rows.Count - 1
            Dim row As New EtParentesco
            row.IdParentesco = IIf(IsDBNull(dt.Rows(x)("idParentesco")), Nothing, dt.Rows(x)("idParentesco"))
            row.NombreParentesco = IIf(IsDBNull(dt.Rows(x)("nombreParentesco")), Nothing, dt.Rows(x)("nombreParentesco"))
            listParentesco.Add(row)
        Next

        Return listParentesco

    End Function
End Class
