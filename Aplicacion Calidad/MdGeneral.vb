Imports ET

Module MdGeneral
    Public user As String
    Public idUser As Integer
    Public subMoti As Integer
    Public crm As Integer
    Public rut As String
    Public fec As String
    Public fechaGrabacion As String
    Public ejec As String
    Public ecalidad As String
    Public obs As String
    Public NombreGrabacion As String = ""
    Public idCRMBase As String
    Public idRegistro As String
    Public idInst As Integer
    Public idLLamadaVenta As Integer
    Public nombreEjecutivo As String
    Public idEjecutivoCalidad As Integer
    Public vgListCampañas As New List(Of EtCampaña)
    Public vgListCiudad As New List(Of EtCiudad)
    Public vgListComuna As New List(Of EtComuna)
    Public vgListParentescoAdicional As New List(Of EtParentesco)
    Public vgListParentescoBeneficiario As New List(Of EtParentesco)
    Public idActualizacionRegistro As String
    Public crmActualizarRegistro As Integer

    Public vgListTitular As New List(Of EtTitular)
    Public vgListAdicional As New List(Of EtAdicional)
    Public vgListBeneficiario As New List(Of EtBeneficiario)
    Public vgListPolizas As New List(Of EtPolizas)

    Public idControlRegistroModificar As String
    Public crmControlRegistroModificar As String

    Public Sub llenaComboBox(ByRef _drd As ComboBox, ByRef _strDisplay As String, ByRef _strValue As String, ByRef _origenDato As Array)
        _drd.DisplayMember = _strDisplay
        _drd.ValueMember = _strValue
        _drd.DataSource = _origenDato
    End Sub


    Public Function ValidaRut(ByRef rut As String) As String
        Dim numRut, auxRut As Object
        Dim acumula As Double
        Dim correlativo, largoR, genera As Object
        Dim VER As Short
        Dim digVal As String

        largoR = Len((rut))

        numRut = rut
        digVal = ""
        auxRut = numRut
        acumula = 0

        genera = 2
        For correlativo = largoR To 1 Step -1
            acumula = (Val(Mid(auxRut, correlativo, 1)) * genera) + acumula
            If genera = 7 Then
                genera = 2
            Else
                genera = genera + 1
            End If
        Next correlativo
        VER = 11 - (acumula Mod 11)
        If VER = 10 Then
            digVal = "K"
        ElseIf VER = 11 Then
            digVal = "0"
        ElseIf VER < 10 Then
            digVal = Trim(Str(VER))
        End If
        Return digVal

    End Function

End Module
