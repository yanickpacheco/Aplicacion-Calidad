Public Class EtBeneficiario

    Dim _rut As String
    Dim _dv As String
    Dim _nombre As String
    Dim _paterno As String
    Dim _materno As String
    Dim _fechaNacimiento As String
    Dim _tipoBeneficiario As Integer
    Dim _nombreBeneficiario As String

    Public Sub New(rut As String, dv As String, nombre As String, paterno As String, materno As String, fechaNacimiento As String, tipoBeneficiario As Integer, nombreBeneficiario As String)
        _rut = rut
        _dv = dv
        _nombre = nombre
        _paterno = paterno
        _materno = materno
        _fechaNacimiento = fechaNacimiento
        _tipoBeneficiario = tipoBeneficiario
        _nombreBeneficiario = nombreBeneficiario
    End Sub

    Public Sub New()
        _rut = ""
        _dv = ""
        _nombre = ""
        _paterno = ""
        _materno = ""
        _fechaNacimiento = ""
        _tipoBeneficiario = 0
        _nombreBeneficiario = ""
    End Sub
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

    Public Property TipoBeneficiario As Integer
        Get
            Return _tipoBeneficiario
        End Get
        Set(value As Integer)
            _tipoBeneficiario = value
        End Set
    End Property

    Public Property NombreBeneficiario As String
        Get
            Return _nombreBeneficiario
        End Get
        Set(value As String)
            _nombreBeneficiario = value
        End Set
    End Property
End Class
