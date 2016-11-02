<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Me.msCompras = New System.Windows.Forms.MenuStrip()
        Me.smiCompra = New System.Windows.Forms.ToolStripMenuItem()
        Me.smiAltasCompra = New System.Windows.Forms.ToolStripMenuItem()
        Me.smiConsultaCompra = New System.Windows.Forms.ToolStripMenuItem()
        Me.msCompras.SuspendLayout()
        Me.SuspendLayout()
        '
        'msCompras
        '
        Me.msCompras.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.smiCompra})
        Me.msCompras.Location = New System.Drawing.Point(0, 0)
        Me.msCompras.Name = "msCompras"
        Me.msCompras.Size = New System.Drawing.Size(765, 24)
        Me.msCompras.TabIndex = 1
        Me.msCompras.Text = "MenuStrip1"
        '
        'smiCompra
        '
        Me.smiCompra.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.smiAltasCompra, Me.smiConsultaCompra})
        Me.smiCompra.Name = "smiCompra"
        Me.smiCompra.Size = New System.Drawing.Size(67, 20)
        Me.smiCompra.Text = "Compras"
        '
        'smiAltasCompra
        '
        Me.smiAltasCompra.Name = "smiAltasCompra"
        Me.smiAltasCompra.Size = New System.Drawing.Size(152, 22)
        Me.smiAltasCompra.Text = "Altas"
        '
        'smiConsultaCompra
        '
        Me.smiConsultaCompra.Name = "smiConsultaCompra"
        Me.smiConsultaCompra.Size = New System.Drawing.Size(152, 22)
        Me.smiConsultaCompra.Text = "Consulta"
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(765, 456)
        Me.Controls.Add(Me.msCompras)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.msCompras
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form5"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Compras"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.msCompras.ResumeLayout(False)
        Me.msCompras.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents msCompras As System.Windows.Forms.MenuStrip
    Friend WithEvents smiCompra As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents smiAltasCompra As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents smiConsultaCompra As System.Windows.Forms.ToolStripMenuItem
End Class
