Public Class EtAdicional

    Dim _nro As Integer
    Dim _rut As String
    Dim _dv As String
    Dim _nombre As String
    Dim _paterno As String
    Dim _materno As String
    Dim _fechaNacimiento As String
    Dim _tipoAdicional As Integer
    Dim _nombreTipoAdicional As String
    Dim _Peso As String
    Dim _Estatura As String
    Dim _SistemaSalud As String

    Public Sub New(nro As Integer, rut As String, dv As String, nombre As String, paterno As String, materno As String, fechaNacimiento As String, tipoAdicional As Integer, nombreTipoAdicional As String, peso As String, estatura As String, Sistema_Salud As String)
        _nro = nro
        _rut = rut
        _dv = dv
        _nombre = nombre
        _paterno = paterno
        _materno = materno
        _fechaNacimiento = fechaNacimiento
        _tipoAdicional = tipoAdicional
        _nombreTipoAdicional = nombreTipoAdicional
        _Peso = peso
        _Estatura = estatura
        _SistemaSalud = SistemaSalud
    End Sub

    Public Sub New()
        _nro = 0
        _rut = ""
        _dv = ""
        _nombre = ""
        _paterno = ""
        _materno = ""
        _fechaNacimiento = ""
        _tipoAdicional = 0
        _nombreTipoAdicional = ""
        _Peso = ""
        _Estatura = ""
        _SistemaSalud = ""
    End Sub

    Public Property Nro As Integer
        Get
            Return _nro
        End Get
        Set(value As Integer)
            _nro = value
        End Set
    End Property

    Public Property Rut As String
        Get
            Return _rut
        End Get
        Set(value As String)
            _rut = value
        End Set
    End Property

    Public Property Dv As String
        Get
            Return _dv
        End Get
        Set(value As String)
            _dv = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property Paterno As String
        Get
            Return _paterno
        End Get
        Set(value As String)
            _paterno = value
        End Set
    End Property

    Public Property Materno As String
        Get
            Return _materno
        End Get
        Set(value As String)
            _materno = value
        End Set
    End Property

    Public Property FechaNacimiento As String
        Get
            Return _fechaNacimiento
        End Get
        Set(value As String)
            _fechaNacimiento = value
        End Set
    End Property

    Public Property TipoAdicional As Integer
        Get
            Return _tipoAdicional
        End Get
        Set(value As Integer)
            _tipoAdicional = value
        End Set
    End Property

    Public Property NombreTipoAdicional As String
        Get
            Return _nombreTipoAdicional
        End Get
        Set(value As String)
            _nombreTipoAdicional = value
        End Set
    End Property

    Public Property Peso As String
        Get
            Return _Peso
        End Get
        Set(value As String)
            _Peso = value
        End Set
    End Property

    Public Property Estatura As String
        Get
            Return _Estatura
        End Get
        Set(value As String)
            _Estatura = value
        End Set
    End Property

    Public Property SistemaSalud As String
        Get
            Return _SistemaSalud
        End Get
        Set(value As String)
            _SistemaSalud = value
        End Set
    End Property
End Class
