Public Class eEjecutivo
    Private _IdEjecutivo As Integer
    Private _NombreEjecutivo As String
    Private _Activo As Boolean

    Public Sub New(idEjecutivo As Integer, nombreEjecutivo As String, activo As Boolean)
        Me.IdEjecutivo = idEjecutivo
        Me.NombreEjecutivo = nombreEjecutivo
        Me.Activo = activo
    End Sub

    Public Property IdEjecutivo As Integer
        Get
            Return _IdEjecutivo
        End Get
        Set(value As Integer)
            _IdEjecutivo = value
        End Set
    End Property

    Public Property NombreEjecutivo As String
        Get
            Return _NombreEjecutivo
        End Get
        Set(value As String)
            _NombreEjecutivo = value
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
