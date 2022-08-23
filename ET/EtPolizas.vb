Public Class EtPolizas

    Dim _rut As String
    Dim _dv As String
    Dim _nombre As String
    Dim _paterno As String
    Dim _materno As String
    Dim _fechaNacimiento As String
    Dim _Calle As String
    Dim _Numero As String
    Dim _Referencia As String
    Dim _Comuna As String
    Dim _Email As String
    Dim _Peso As String
    Dim _Estatura As String
    Dim _Isapre As String

    Public Sub New(rut As String, dv As String, nombre As String, paterno As String, materno As String, fechaNacimiento As String, calle As String, numero As String, referencia As String, comuna As String, email As String, peso As String, estatura As String, isapre As String)
        _rut = rut
        _dv = dv
        _nombre = nombre
        _paterno = paterno
        _materno = materno
        _fechaNacimiento = fechaNacimiento
        _Calle = calle
        _Numero = numero
        _Referencia = referencia
        _Comuna = comuna
        _Email = email
        _Peso = peso
        _Estatura = estatura
        _Isapre = isapre
    End Sub

    Public Sub New()
        _rut = ""
        _dv = ""
        _nombre = ""
        _paterno = ""
        _materno = ""
        _fechaNacimiento = ""
        _Calle = ""
        _Numero = ""
        _Referencia = ""
        _Comuna = ""
        _Email = ""
        _Peso = ""
        _Estatura = ""
        _Isapre = ""
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

    Public Property Calle As String
        Get
            Return _Calle
        End Get
        Set(value As String)
            _Calle = value
        End Set
    End Property

    Public Property Numero As String
        Get
            Return _Numero
        End Get
        Set(value As String)
            _Numero = value
        End Set
    End Property

    Public Property Referencia As String
        Get
            Return _Referencia
        End Get
        Set(value As String)
            _Referencia = value
        End Set
    End Property

    Public Property Comuna As String
        Get
            Return _Comuna
        End Get
        Set(value As String)
            _Comuna = value
        End Set
    End Property

    Public Property Email As String
        Get
            Return _Email
        End Get
        Set(value As String)
            _Email = value
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

    Public Property Isapre As String
        Get
            Return _Isapre
        End Get
        Set(value As String)
            _Isapre = value
        End Set
    End Property
End Class
