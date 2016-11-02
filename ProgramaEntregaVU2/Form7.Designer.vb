<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Me.msVentas = New System.Windows.Forms.MenuStrip()
        Me.smiVentas = New System.Windows.Forms.ToolStripMenuItem()
        Me.smiAltasVentas = New System.Windows.Forms.ToolStripMenuItem()
        Me.smiConsultaVentas = New System.Windows.Forms.ToolStripMenuItem()
        Me.msVentas.SuspendLayout()
        Me.SuspendLayout()
        '
        'msVentas
        '
        Me.msVentas.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.smiVentas})
        Me.msVentas.Location = New System.Drawing.Point(0, 0)
        Me.msVentas.Name = "msVentas"
        Me.msVentas.Size = New System.Drawing.Size(763, 24)
        Me.msVentas.TabIndex = 0
        Me.msVentas.Text = "MenuStrip1"
        '
        'smiVentas
        '
        Me.smiVentas.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.smiAltasVentas, Me.smiConsultaVentas})
        Me.smiVentas.Name = "smiVentas"
        Me.smiVentas.Size = New System.Drawing.Size(53, 20)
        Me.smiVentas.Text = "Ventas"
        '
        'smiAltasVentas
        '
        Me.smiAltasVentas.Name = "smiAltasVentas"
        Me.smiAltasVentas.Size = New System.Drawing.Size(152, 22)
        Me.smiAltasVentas.Text = "Altas"
        '
        'smiConsultaVentas
        '
        Me.smiConsultaVentas.Name = "smiConsultaVentas"
        Me.smiConsultaVentas.Size = New System.Drawing.Size(152, 22)
        Me.smiConsultaVentas.Text = "Consulta"
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(763, 475)
        Me.Controls.Add(Me.msVentas)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.msVentas
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form7"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Ventas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.msVentas.ResumeLayout(False)
        Me.msVentas.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents msVentas As System.Windows.Forms.MenuStrip
    Friend WithEvents smiVentas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents smiAltasVentas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents smiConsultaVentas As System.Windows.Forms.ToolStripMenuItem
End Class
