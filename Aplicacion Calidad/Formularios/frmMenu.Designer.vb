<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CalidadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EvaluacionesPendientesAevaluar = New System.Windows.Forms.ToolStripMenuItem()
        Me.DetalleVentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CambiarEstadoYObservaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarDatosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RevisarRegistrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MarcarNNToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalidadToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CalidadToolStripMenuItem
        '
        Me.CalidadToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EvaluacionesPendientesAevaluar, Me.DetalleVentasToolStripMenuItem, Me.CambiarEstadoYObservaciónToolStripMenuItem, Me.ModificarDatosToolStripMenuItem, Me.RevisarRegistrosToolStripMenuItem, Me.MarcarNNToolStripMenuItem})
        Me.CalidadToolStripMenuItem.Name = "CalidadToolStripMenuItem"
        Me.CalidadToolStripMenuItem.Size = New System.Drawing.Size(87, 20)
        Me.CalidadToolStripMenuItem.Text = "Evaluaciones"
        '
        'EvaluacionesPendientesAevaluar
        '
        Me.EvaluacionesPendientesAevaluar.Name = "EvaluacionesPendientesAevaluar"
        Me.EvaluacionesPendientesAevaluar.Size = New System.Drawing.Size(253, 22)
        Me.EvaluacionesPendientesAevaluar.Text = "Evaluaciones pendientes a evaluar"
        '
        'DetalleVentasToolStripMenuItem
        '
        Me.DetalleVentasToolStripMenuItem.Name = "DetalleVentasToolStripMenuItem"
        Me.DetalleVentasToolStripMenuItem.Size = New System.Drawing.Size(253, 22)
        Me.DetalleVentasToolStripMenuItem.Text = "Detalle Ventas"
        '
        'CambiarEstadoYObservaciónToolStripMenuItem
        '
        Me.CambiarEstadoYObservaciónToolStripMenuItem.Name = "CambiarEstadoYObservaciónToolStripMenuItem"
        Me.CambiarEstadoYObservaciónToolStripMenuItem.Size = New System.Drawing.Size(253, 22)
        Me.CambiarEstadoYObservaciónToolStripMenuItem.Text = "Cambiar estado y observación"
        '
        'ModificarDatosToolStripMenuItem
        '
        Me.ModificarDatosToolStripMenuItem.Name = "ModificarDatosToolStripMenuItem"
        Me.ModificarDatosToolStripMenuItem.Size = New System.Drawing.Size(253, 22)
        Me.ModificarDatosToolStripMenuItem.Text = "Modificar Datos"
        '
        'RevisarRegistrosToolStripMenuItem
        '
        Me.RevisarRegistrosToolStripMenuItem.Name = "RevisarRegistrosToolStripMenuItem"
        Me.RevisarRegistrosToolStripMenuItem.Size = New System.Drawing.Size(253, 22)
        Me.RevisarRegistrosToolStripMenuItem.Text = "Revisar Registros"
        '
        'MarcarNNToolStripMenuItem
        '
        Me.MarcarNNToolStripMenuItem.Name = "MarcarNNToolStripMenuItem"
        Me.MarcarNNToolStripMenuItem.Size = New System.Drawing.Size(253, 22)
        Me.MarcarNNToolStripMenuItem.Text = "Marcar NN"
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMenu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CalidadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EvaluacionesPendientesAevaluar As ToolStripMenuItem
    Friend WithEvents DetalleVentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CambiarEstadoYObservaciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificarDatosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RevisarRegistrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MarcarNNToolStripMenuItem As ToolStripMenuItem
End Class
