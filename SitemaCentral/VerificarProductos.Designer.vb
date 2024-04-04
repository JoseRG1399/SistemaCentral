<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VerificarProductos
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dgBuzones = New System.Windows.Forms.DataGridView()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.dgVentaAlfredo = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblContadorTablaCaptura = New System.Windows.Forms.Label()
        Me.lblContadorVentaAlfredo = New System.Windows.Forms.Label()
        Me.cbbxSelectProducto = New System.Windows.Forms.ComboBox()
        CType(Me.dgBuzones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgVentaAlfredo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(862, 31)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(196, 50)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Limpiar celdas"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dgBuzones
        '
        Me.dgBuzones.AllowDrop = True
        Me.dgBuzones.AllowUserToAddRows = False
        Me.dgBuzones.AllowUserToOrderColumns = True
        Me.dgBuzones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgBuzones.Location = New System.Drawing.Point(40, 195)
        Me.dgBuzones.Name = "dgBuzones"
        Me.dgBuzones.ReadOnly = True
        Me.dgBuzones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgBuzones.Size = New System.Drawing.Size(623, 385)
        Me.dgBuzones.TabIndex = 13
        '
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.Location = New System.Drawing.Point(447, 31)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(216, 50)
        Me.btnBuscar.TabIndex = 12
        Me.btnBuscar.Text = "Verificar producto"
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'dgVentaAlfredo
        '
        Me.dgVentaAlfredo.AllowDrop = True
        Me.dgVentaAlfredo.AllowUserToAddRows = False
        Me.dgVentaAlfredo.AllowUserToOrderColumns = True
        Me.dgVentaAlfredo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgVentaAlfredo.Location = New System.Drawing.Point(708, 195)
        Me.dgVentaAlfredo.Name = "dgVentaAlfredo"
        Me.dgVentaAlfredo.ReadOnly = True
        Me.dgVentaAlfredo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgVentaAlfredo.Size = New System.Drawing.Size(350, 385)
        Me.dgVentaAlfredo.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(704, 113)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 19)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Venta alfredo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(36, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 19)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Tabla captura"
        '
        'lblContadorTablaCaptura
        '
        Me.lblContadorTablaCaptura.AutoSize = True
        Me.lblContadorTablaCaptura.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContadorTablaCaptura.Location = New System.Drawing.Point(36, 152)
        Me.lblContadorTablaCaptura.Name = "lblContadorTablaCaptura"
        Me.lblContadorTablaCaptura.Size = New System.Drawing.Size(112, 19)
        Me.lblContadorTablaCaptura.TabIndex = 19
        Me.lblContadorTablaCaptura.Text = "Tabla captura"
        '
        'lblContadorVentaAlfredo
        '
        Me.lblContadorVentaAlfredo.AutoSize = True
        Me.lblContadorVentaAlfredo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContadorVentaAlfredo.Location = New System.Drawing.Point(704, 152)
        Me.lblContadorVentaAlfredo.Name = "lblContadorVentaAlfredo"
        Me.lblContadorVentaAlfredo.Size = New System.Drawing.Size(109, 19)
        Me.lblContadorVentaAlfredo.TabIndex = 20
        Me.lblContadorVentaAlfredo.Text = "Venta alfredo"
        '
        'cbbxSelectProducto
        '
        Me.cbbxSelectProducto.BackColor = System.Drawing.Color.White
        Me.cbbxSelectProducto.Font = New System.Drawing.Font("Arial Narrow", 26.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbbxSelectProducto.ForeColor = System.Drawing.Color.Black
        Me.cbbxSelectProducto.FormattingEnabled = True
        Me.cbbxSelectProducto.Location = New System.Drawing.Point(12, 31)
        Me.cbbxSelectProducto.Name = "cbbxSelectProducto"
        Me.cbbxSelectProducto.Size = New System.Drawing.Size(393, 50)
        Me.cbbxSelectProducto.TabIndex = 231
        '
        'VerificarProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1098, 647)
        Me.Controls.Add(Me.cbbxSelectProducto)
        Me.Controls.Add(Me.lblContadorVentaAlfredo)
        Me.Controls.Add(Me.lblContadorTablaCaptura)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgVentaAlfredo)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dgBuzones)
        Me.Controls.Add(Me.btnBuscar)
        Me.Name = "VerificarProductos"
        Me.Text = "VerificarProductos"
        CType(Me.dgBuzones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgVentaAlfredo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents dgBuzones As DataGridView
    Friend WithEvents btnBuscar As Button
    Friend WithEvents dgVentaAlfredo As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblContadorTablaCaptura As Label
    Friend WithEvents lblContadorVentaAlfredo As Label
    Friend WithEvents cbbxSelectProducto As ComboBox
End Class
