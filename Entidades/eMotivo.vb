Public Class eMotivo
    Private _IdMotivo As Integer
    Private _NombreMotivo As String
    Private _Activo As Boolean

    Public Sub New(idMotivo As Integer, nombreMotivo As String, activo As Boolean)
        Me.IdMotivo = idMotivo
        Me.NombreMotivo = nombreMotivo
        Me.Activo = activo
    End Sub

    Public Sub New()

        IdMotivo = 0
        NombreMotivo = ""
        Activo = False
    End Sub

    Public Property IdMotivo As Integer
        Get
            Return _IdMotivo
        End Get
        Set(value As Integer)
            _IdMotivo = value
        End Set
    End Property

    Public Property NombreMotivo As String
        Get
            Return _NombreMotivo
        End Get
        Set(value As String)
            _NombreMotivo = value
        End Set
    End Property

    Public Property Activo As Boolean
        Get
            Return _Activo
        End Get
        Set(value As Boolean)
            _Activo = value
        End Set
    End Property
End Class
