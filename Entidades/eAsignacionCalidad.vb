Public Class eAsignacionCalidad
    Private _IdAsignacionCalidad As Integer
    Private _CRM As String
    Private _IdRegistro As String
    Private _Rut As String
    Private _FechaVenta As String
    Private _EjecutivoVendedor As String
    Private _EjecutivoCalidad As String
    Private _EstadoCalidad As String

    Public Sub New(idAsignacionCalidad As Integer, cRM As String, idRegistro As String, rut As String, fechaVenta As String, ejecutivoVendedor As String, ejecutivoCalidad As String, estadoCalidad As String)
        Me.IdAsignacionCalidad = idAsignacionCalidad
        Me.CRM = cRM
        Me.IdRegistro = idRegistro
        Me.Rut = rut
        Me.FechaVenta = fechaVenta
        Me.EjecutivoVendedor = ejecutivoVendedor
        Me.EjecutivoCalidad = ejecutivoCalidad
        Me.EstadoCalidad = estadoCalidad
    End Sub

    Public Property IdAsignacionCalidad As Integer
        Get
            Return _IdAsignacionCalidad
        End Get
        Set(value As Integer)
            _IdAsignacionCalidad = value
        End Set
    End Property

    Public Property CRM As String
        Get
            Return _CRM
        End Get
        Set(value As String)
            _CRM = value
        End Set
    End Property

    Public Property IdRegistro As String
        Get
            Return _IdRegistro
        End Get
        Set(value As String)
            _IdRegistro = value
        End Set
    End Property

    Public Property Rut As String
        Get
            Return _Rut
        End Get
        Set(value As String)
            _Rut = value
        End Set
    End Property

    Public Property FechaVenta As String
        Get
            Return _FechaVenta
        End Get
        Set(value As String)
            _FechaVenta = value
        End Set
    End Property

    Public Property EjecutivoVendedor As String
        Get
            Return _EjecutivoVendedor
        End Get
        Set(value As String)
            _EjecutivoVendedor = value
        End Set
    End Property

    Public Property EjecutivoCalidad As String
        Get
            Return _EjecutivoCalidad
        End Get
        Set(value As String)
            _EjecutivoCalidad = value
        End Set
    End Property

    Public Property EstadoCalidad As String
        Get
            Return _EstadoCalidad
        End Get
        Set(value As String)
            _EstadoCalidad = value
        End Set
    End Property
End Class
