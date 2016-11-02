<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.msCatalogo = New System.Windows.Forms.MenuStrip()
        Me.smiCatalogo = New System.Windows.Forms.ToolStripMenuItem()
        Me.msiAlta = New System.Windows.Forms.ToolStripMenuItem()
        Me.msiModificar = New System.Windows.Forms.ToolStripMenuItem()
        Me.msiConsultar = New System.Windows.Forms.ToolStripMenuItem()
        Me.msiRegresar = New System.Windows.Forms.ToolStripMenuItem()
        Me.msCatalogo.SuspendLayout()
        Me.SuspendLayout()
        '
        'msCatalogo
        '
        Me.msCatalogo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.smiCatalogo})
        Me.msCatalogo.Location = New System.Drawing.Point(0, 0)
        Me.msCatalogo.Name = "msCatalogo"
        Me.msCatalogo.Size = New System.Drawing.Size(626, 24)
        Me.msCatalogo.TabIndex = 0
        Me.msCatalogo.Text = "MenuStrip1"
        '
        'smiCatalogo
        '
        Me.smiCatalogo.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.msiAlta, Me.msiModificar, Me.msiConsultar, Me.msiRegresar})
        Me.smiCatalogo.Name = "smiCatalogo"
        Me.smiCatalogo.Size = New System.Drawing.Size(67, 20)
        Me.smiCatalogo.Text = "Catálogo"
        '
        'msiAlta
        '
        Me.msiAlta.Name = "msiAlta"
        Me.msiAlta.Size = New System.Drawing.Size(152, 22)
        Me.msiAlta.Text = "Alta"
        '
        'msiModificar
        '
        Me.msiModificar.Name = "msiModificar"
        Me.msiModificar.Size = New System.Drawing.Size(152, 22)
        Me.msiModificar.Text = "Modificar"
        '
        'msiConsultar
        '
        Me.msiConsultar.Name = "msiConsultar"
        Me.msiConsultar.Size = New System.Drawing.Size(152, 22)
        Me.msiConsultar.Text = "Consultar"
        '
        'msiRegresar
        '
        Me.msiRegresar.Name = "msiRegresar"
        Me.msiRegresar.Size = New System.Drawing.Size(152, 22)
        Me.msiRegresar.Text = "Regresar"
        Me.msiRegresar.ToolTipText = "Regresa al formulario principal"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(626, 391)
        Me.Controls.Add(Me.msCatalogo)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.msCatalogo
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form3"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Producto"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.msCatalogo.ResumeLayout(False)
        Me.msCatalogo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents msCatalogo As System.Windows.Forms.MenuStrip
    Friend WithEvents smiCatalogo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents msiAlta As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents msiModificar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents msiConsultar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents msiRegresar As System.Windows.Forms.ToolStripMenuItem
End Class
