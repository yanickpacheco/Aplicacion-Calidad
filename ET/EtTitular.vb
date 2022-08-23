Public Class EtTitular

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
    Dim _suministro As String
    Dim _rutPagador As String
    Dim _dvPagador As String
    Dim _nombrePagador As String

    Public Sub New(rut As String, dv As String, nombre As String, paterno As String, materno As String, fechaNacimiento As String, calle As String, numero As String, referencia As String, comuna As String, email As String, suministro As String, rutPagador As String, dvPagador As String, nombrePagador As String)
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
        _suministro = suministro
        _rutPagador = rutPagador
        _dvPagador = dvPagador
        _nombrePagador = nombrePagador
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
        _suministro = ""
        _rutPagador = ""
        _dvPagador = ""
        _nombrePagador = ""
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

    Public Property Suministro As String
        Get
            Return _suministro
        End Get
        Set(value As String)
            _suministro = value
        End Set
    End Property

    Public Property RutPagador As String
        Get
            Return _rutPagador
        End Get
        Set(value As String)
            _rutPagador = value
        End Set
    End Property

    Public Property DvPagador As String
        Get
            Return _dvPagador
        End Get
        Set(value As String)
            _dvPagador = value
        End Set
    End Property

    Public Property NombrePagador As String
        Get
            Return _nombrePagador
        End Get
        Set(value As String)
            _nombrePagador = value
        End Set
    End Property
End Class
