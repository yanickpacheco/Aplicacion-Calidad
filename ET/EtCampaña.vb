Imports System.Data.SqlClient

Public Class EtCampaña

    Dim cnn2 As New SqlConnection("data source = 192.168.1.14; initial catalog = BASE_GENERAL_CORDIAL; User id= cp; password=Cordial.passs ")

    Dim _crm As Integer
    Dim _nombreCRM As String
    Dim _conAdicional As Boolean
    Dim _conBeneficiario As Boolean
    Dim _conPolizas As Boolean

    Public Sub New(crm As Integer, nombreCRM As String, conAdicional As Boolean, conBeneficiario As Boolean, conPolizas As Boolean)
        _crm = crm
        _nombreCRM = nombreCRM
        _conAdicional = conAdicional
        _conBeneficiario = conBeneficiario
        _conPolizas = conPolizas
    End Sub

    Public Sub New()
        _crm = 0
        _nombreCRM = ""
        _conAdicional = False
        _conBeneficiario = False
        _conPolizas = False
    End Sub

    Public Property Crm As Integer
        Get
            Return _crm
        End Get
        Set(value As Integer)
            _crm = value
        End Set
    End Property

    Public Property NombreCRM As String
        Get
            Return _nombreCRM
        End Get
        Set(value As String)
            _nombreCRM = value
        End Set
    End Property

    Public Property ConAdicional As Boolean
        Get
            Return _conAdicional
        End Get
        Set(value As Boolean)
            _conAdicional = value
        End Set
    End Property

    Public Property ConBeneficiario As Boolean
        Get
            Return _conBeneficiario
        End Get
        Set(value As Boolean)
            _conBeneficiario = value
        End Set
    End Property

    Public Property ConPolizas As Boolean
        Get
            Return _conPolizas
        End Get
        Set(value As Boolean)
            _conPolizas = value
        End Set
    End Property


    Public Function ListaCampañas() As List(Of EtCampaña)
        Dim dt As New DataTable
        Dim dA As SqlDataAdapter
        Dim cmd As New SqlCommand
        Dim sql As String = ""
        Dim listCampañas As New List(Of EtCampaña)
        cmd.CommandType = CommandType.StoredProcedure

        Try
            sql = "Config.ListaDatosCampañas"
            cmd.CommandText = sql
            cmd.Connection = cnn2
            dA = New SqlDataAdapter(cmd)
            dA.Fill(dt)



            For x As Int16 = 0 To dt.Rows.Count - 1
                Dim row As New EtCampaña

                row.Crm = IIf(IsDBNull(dt.Rows(x)("crm")), Nothing, dt.Rows(x)("crm"))
                row.NombreCRM = IIf(IsDBNull(dt.Rows(x)("nombreCRM")), Nothing, dt.Rows(x)("nombreCRM"))
                row.ConAdicional = IIf(IsDBNull(dt.Rows(x)("conAdicional")), Nothing, dt.Rows(x)("conAdicional"))
                row.ConBeneficiario = IIf(IsDBNull(dt.Rows(x)("conBeneficiario")), Nothing, dt.Rows(x)("conBeneficiario"))
                row.ConPolizas = IIf(IsDBNull(dt.Rows(x)("ConPolizas")), Nothing, dt.Rows(x)("ConPolizas"))
                listCampañas.Add(row)
            Next


        Catch ex As Exception

            MsgBox("Error Listar Campañas" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")

        End Try

        Return listCampañas

    End Function


End Class