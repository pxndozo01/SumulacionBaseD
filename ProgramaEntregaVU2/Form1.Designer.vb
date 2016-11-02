<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Me.msMenu = New System.Windows.Forms.MenuStrip()
        Me.smiArchivo = New System.Windows.Forms.ToolStripMenuItem()
        Me.smiAcerca = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.smiSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.smiCatalogos = New System.Windows.Forms.ToolStripMenuItem()
        Me.smiProductos = New System.Windows.Forms.ToolStripMenuItem()
        Me.smiOperaciones = New System.Windows.Forms.ToolStripMenuItem()
        Me.smiCompras = New System.Windows.Forms.ToolStripMenuItem()
        Me.smiVentas = New System.Windows.Forms.ToolStripMenuItem()
        Me.smiReportes = New System.Windows.Forms.ToolStripMenuItem()
        Me.smiReporteProducto = New System.Windows.Forms.ToolStripMenuItem()
        Me.smiReporteCompra = New System.Windows.Forms.ToolStripMenuItem()
        Me.smiReporteVenta = New System.Windows.Forms.ToolStripMenuItem()
        Me.msMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'msMenu
        '
        Me.msMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.smiArchivo, Me.smiCatalogos, Me.smiOperaciones, Me.smiReportes})
        Me.msMenu.Location = New System.Drawing.Point(0, 0)
        Me.msMenu.Name = "msMenu"
        Me.msMenu.Size = New System.Drawing.Size(702, 24)
        Me.msMenu.TabIndex = 1
        '
        'smiArchivo
        '
        Me.smiArchivo.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.smiAcerca, Me.ToolStripSeparator1, Me.smiSalir})
        Me.smiArchivo.Name = "smiArchivo"
        Me.smiArchivo.ShortcutKeyDisplayString = ""
        Me.smiArchivo.Size = New System.Drawing.Size(60, 20)
        Me.smiArchivo.Text = "&Archivo"
        '
        'smiAcerca
        '
        Me.smiAcerca.Name = "smiAcerca"
        Me.smiAcerca.ShortcutKeyDisplayString = ""
        Me.smiAcerca.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.smiAcerca.Size = New System.Drawing.Size(168, 22)
        Me.smiAcerca.Text = "Acerca &de"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(165, 6)
        '
        'smiSalir
        '
        Me.smiSalir.Name = "smiSalir"
        Me.smiSalir.Size = New System.Drawing.Size(168, 22)
        Me.smiSalir.Text = "&Salir"
        '
        'smiCatalogos
        '
        Me.smiCatalogos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.smiProductos})
        Me.smiCatalogos.Name = "smiCatalogos"
        Me.smiCatalogos.Size = New System.Drawing.Size(72, 20)
        Me.smiCatalogos.Text = "&Catálogos"
        '
        'smiProductos
        '
        Me.smiProductos.Name = "smiProductos"
        Me.smiProductos.Size = New System.Drawing.Size(128, 22)
        Me.smiProductos.Text = "&Productos"
        '
        'smiOperaciones
        '
        Me.smiOperaciones.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.smiCompras, Me.smiVentas})
        Me.smiOperaciones.Name = "smiOperaciones"
        Me.smiOperaciones.Size = New System.Drawing.Size(85, 20)
        Me.smiOperaciones.Text = "&Operaciones"
        '
        'smiCompras
        '
        Me.smiCompras.Name = "smiCompras"
        Me.smiCompras.Size = New System.Drawing.Size(152, 22)
        Me.smiCompras.Text = "C&ompras"
        '
        'smiVentas
        '
        Me.smiVentas.Name = "smiVentas"
        Me.smiVentas.Size = New System.Drawing.Size(152, 22)
        Me.smiVentas.Text = "&Ventas"
        '
        'smiReportes
        '
        Me.smiReportes.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.smiReporteProducto, Me.smiReporteCompra, Me.smiReporteVenta})
        Me.smiReportes.Name = "smiReportes"
        Me.smiReportes.Size = New System.Drawing.Size(65, 20)
        Me.smiReportes.Text = "&Reportes"
        '
        'smiReporteProducto
        '
        Me.smiReporteProducto.Name = "smiReporteProducto"
        Me.smiReporteProducto.Size = New System.Drawing.Size(128, 22)
        Me.smiReporteProducto.Text = "Prod&uctos"
        '
        'smiReporteCompra
        '
        Me.smiReporteCompra.Name = "smiReporteCompra"
        Me.smiReporteCompra.Size = New System.Drawing.Size(128, 22)
        Me.smiReporteCompra.Text = "Co&mpras"
        '
        'smiReporteVenta
        '
        Me.smiReporteVenta.Name = "smiReporteVenta"
        Me.smiReporteVenta.Size = New System.Drawing.Size(128, 22)
        Me.smiReporteVenta.Text = "V&entas"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(702, 385)
        Me.Controls.Add(Me.msMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.msMenu
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sucursal ""CHANGARRIUX"""
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.msMenu.ResumeLayout(False)
        Me.msMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents msMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents smiArchivo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents smiAcerca As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents smiSalir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents smiCatalogos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents smiProductos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents smiOperaciones As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents smiCompras As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents smiVentas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents smiReportes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents smiReporteProducto As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents smiReporteCompra As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents smiReporteVenta As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator

End Class
