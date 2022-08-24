Public Class frmMenu
    Private Sub EvaluacionesPendientesAevaluar_Click(sender As Object, e As EventArgs) Handles EvaluacionesPendientesAevaluar.Click
        frmEvaluador.Show()
        Me.Close()

    End Sub

    Private Sub CambiarEstadoYObservaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CambiarEstadoYObservaciónToolStripMenuItem.Click
        frmCambioEyO.Show()
        Me.Close()
    End Sub

    Private Sub ModificarDatosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarDatosToolStripMenuItem.Click
        frmModificacionDatos.Show()
        Me.Close()
    End Sub

    Private Sub RevisarRegistrosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RevisarRegistrosToolStripMenuItem.Click
        frmRevisarRegistros.Show()
        Me.Close()
    End Sub

    Private Sub MarcarNNToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MarcarNNToolStripMenuItem.Click
        If idEjecutivoCalidad.ToString.ToUpper = 1 Then
            frmMarcarNN.Show()
            Me.Close()
        End If
    End Sub

    Private Sub CalidadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalidadToolStripMenuItem.Click

    End Sub
End Class