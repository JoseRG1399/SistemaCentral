<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionProductos
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbbxCategoria = New System.Windows.Forms.ComboBox()
        Me.cbbxClasificacion = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbbxProducto = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(52, 195)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Categoria"
        '
        'cbbxCategoria
        '
        Me.cbbxCategoria.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbbxCategoria.FormattingEnabled = True
        Me.cbbxCategoria.Items.AddRange(New Object() {"Bebidas", "Comida rápida", "Externo", "Galletas", "Gelatinas", "Mezcla café", "Navidad", "Pan", "Pasteles", "Postres", "Reyes", "Roscas y panqués", "Velas"})
        Me.cbbxCategoria.Location = New System.Drawing.Point(194, 211)
        Me.cbbxCategoria.Name = "cbbxCategoria"
        Me.cbbxCategoria.Size = New System.Drawing.Size(230, 31)
        Me.cbbxCategoria.TabIndex = 1
        '
        'cbbxClasificacion
        '
        Me.cbbxClasificacion.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbbxClasificacion.FormattingEnabled = True
        Me.cbbxClasificacion.Items.AddRange(New Object() {"1/4 P", "Arroz", "Bebidas", "Clásico", "Clásico esp.", "Comida rápida", "Danés", "Donas", "Externo", "Feité", "Fino", "Flan ind.", "Galletas", "Gel. Gde.", "Gel. Ind.", "Gel. Med.", "Hojaldras", "Integral", "Merengues", "Mezcla café", "Migajón", "Minipasteles", "Navidad", "P. barra", "P. ind.", "Pastel 18", "Pastel 25", "Pastel I", "Pay gde.", "Pay ind.", "Pays", "Reyes", "Roscas", "Royal", "Tartas fam.", "Tartas ind.", "Trufas", "Velas"})
        Me.cbbxClasificacion.Location = New System.Drawing.Point(194, 277)
        Me.cbbxClasificacion.Name = "cbbxClasificacion"
        Me.cbbxClasificacion.Size = New System.Drawing.Size(230, 31)
        Me.cbbxClasificacion.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(52, 282)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Clasificacion"
        '
        'cbbxProducto
        '
        Me.cbbxProducto.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbbxProducto.FormattingEnabled = True
        Me.cbbxProducto.Location = New System.Drawing.Point(194, 121)
        Me.cbbxProducto.Name = "cbbxProducto"
        Me.cbbxProducto.Size = New System.Drawing.Size(230, 31)
        Me.cbbxProducto.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(52, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 23)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Producto"
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(534, 167)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(172, 75)
        Me.btnUpdate.TabIndex = 6
        Me.btnUpdate.Text = "Actualizar informacion del producto"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'GestionProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1114, 634)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.cbbxProducto)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbbxClasificacion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbbxCategoria)
        Me.Controls.Add(Me.Label1)
        Me.Name = "GestionProductos"
        Me.Text = "GestionProductos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cbbxCategoria As ComboBox
    Friend WithEvents cbbxClasificacion As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cbbxProducto As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnUpdate As Button
End Class
