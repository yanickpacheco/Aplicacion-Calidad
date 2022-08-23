Public Class eSubMotivo
    Private _IdSubMotivo As Integer
    Private _NombreSubMotivo As String
    Private _Activo As Boolean

    Public Sub New(idSubMotivo As Integer, nombreSubMotivo As String, activo As Boolean)
        Me.IdSubMotivo = idSubMotivo
        Me.NombreSubMotivo = nombreSubMotivo
        Me.Activo = activo
    End Sub

    Public Sub New()
        IdSubMotivo = 0
        NombreSubMotivo = ""
        Activo = False
    End Sub

    Public Property IdSubMotivo As Integer
        Get
            Return _IdSubMotivo
        End Get
        Set(value As Integer)
            _IdSubMotivo = value
        End Set
    End Property

    Public Property NombreSubMotivo As String
        Get
            Return _NombreSubMotivo
        End Get
        Set(value As String)
            _NombreSubMotivo = value
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
