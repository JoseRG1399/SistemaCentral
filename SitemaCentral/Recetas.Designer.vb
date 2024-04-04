<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Recetas
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
        Me.dgRecetas = New System.Windows.Forms.DataGridView()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.txtDepartamento = New System.Windows.Forms.TextBox()
        Me.txtUnidad = New System.Windows.Forms.TextBox()
        Me.txtReceta = New System.Windows.Forms.TextBox()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnLlenar = New System.Windows.Forms.Button()
        Me.btnSubir = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dgRecetas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgRecetas
        '
        Me.dgRecetas.AllowUserToAddRows = False
        Me.dgRecetas.AllowUserToResizeColumns = False
        Me.dgRecetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgRecetas.Location = New System.Drawing.Point(12, 169)
        Me.dgRecetas.Name = "dgRecetas"
        Me.dgRecetas.RowHeadersVisible = False
        Me.dgRecetas.Size = New System.Drawing.Size(802, 390)
        Me.dgRecetas.TabIndex = 0
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Arial Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(12, 40)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(230, 34)
        Me.txtNombre.TabIndex = 1
        '
        'txtNumero
        '
        Me.txtNumero.Font = New System.Drawing.Font("Arial Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumero.Location = New System.Drawing.Point(550, 129)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(100, 34)
        Me.txtNumero.TabIndex = 2
        '
        'txtDepartamento
        '
        Me.txtDepartamento.Font = New System.Drawing.Font("Arial Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDepartamento.Location = New System.Drawing.Point(550, 45)
        Me.txtDepartamento.Name = "txtDepartamento"
        Me.txtDepartamento.Size = New System.Drawing.Size(177, 34)
        Me.txtDepartamento.TabIndex = 3
        '
        'txtUnidad
        '
        Me.txtUnidad.Font = New System.Drawing.Font("Arial Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnidad.Location = New System.Drawing.Point(268, 129)
        Me.txtUnidad.Name = "txtUnidad"
        Me.txtUnidad.Size = New System.Drawing.Size(223, 34)
        Me.txtUnidad.TabIndex = 4
        '
        'txtReceta
        '
        Me.txtReceta.Font = New System.Drawing.Font("Arial Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReceta.Location = New System.Drawing.Point(268, 45)
        Me.txtReceta.Name = "txtReceta"
        Me.txtReceta.Size = New System.Drawing.Size(223, 34)
        Me.txtReceta.TabIndex = 5
        '
        'txtCantidad
        '
        Me.txtCantidad.Font = New System.Drawing.Font("Arial Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidad.Location = New System.Drawing.Point(12, 129)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(96, 34)
        Me.txtCantidad.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 19)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 19)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Cantidad"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(265, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 19)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Receta"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(265, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 19)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Unidad"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(547, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 19)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Departamento"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(547, 93)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 19)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Numero"
        '
        'btnLlenar
        '
        Me.btnLlenar.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLlenar.Location = New System.Drawing.Point(850, 169)
        Me.btnLlenar.Name = "btnLlenar"
        Me.btnLlenar.Size = New System.Drawing.Size(169, 76)
        Me.btnLlenar.TabIndex = 13
        Me.btnLlenar.Text = "Agregar a receta"
        Me.btnLlenar.UseVisualStyleBackColor = True
        '
        'btnSubir
        '
        Me.btnSubir.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubir.Location = New System.Drawing.Point(850, 260)
        Me.btnSubir.Name = "btnSubir"
        Me.btnSubir.Size = New System.Drawing.Size(169, 76)
        Me.btnSubir.TabIndex = 14
        Me.btnSubir.Text = "Subir receta al servidor"
        Me.btnSubir.UseVisualStyleBackColor = True
        '
        'btnHome
        '
        Me.btnHome.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHome.Location = New System.Drawing.Point(850, 483)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(169, 76)
        Me.btnHome.TabIndex = 15
        Me.btnHome.Text = "Cerrar"
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(850, 373)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(169, 76)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Consultar recetas en servidor"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Recetas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1055, 571)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.btnSubir)
        Me.Controls.Add(Me.btnLlenar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.txtReceta)
        Me.Controls.Add(Me.txtUnidad)
        Me.Controls.Add(Me.txtDepartamento)
        Me.Controls.Add(Me.txtNumero)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.dgRecetas)
        Me.Name = "Recetas"
        Me.Text = "Recetas"
        CType(Me.dgRecetas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgRecetas As DataGridView
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtNumero As TextBox
    Friend WithEvents txtDepartamento As TextBox
    Friend WithEvents txtUnidad As TextBox
    Friend WithEvents txtReceta As TextBox
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnLlenar As Button
    Friend WithEvents btnSubir As Button
    Friend WithEvents btnHome As Button
    Friend WithEvents Button1 As Button
End Class
