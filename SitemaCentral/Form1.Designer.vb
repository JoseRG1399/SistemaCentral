<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnRecetas = New FontAwesome.Sharp.IconButton()
        Me.btnVerificarProductos = New FontAwesome.Sharp.IconButton()
        Me.btnExit = New FontAwesome.Sharp.IconButton()
        Me.IconButton4 = New FontAwesome.Sharp.IconButton()
        Me.btnDrivers = New FontAwesome.Sharp.IconButton()
        Me.btnAddSeller = New FontAwesome.Sharp.IconButton()
        Me.btnNewProducts = New FontAwesome.Sharp.IconButton()
        Me.btnConnect = New FontAwesome.Sharp.IconButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(292, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(252, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bienvenido al sistema central"
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(231, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(369, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Comercializadora Saron Shekina S.A de C.V"
        '
        'btnRecetas
        '
        Me.btnRecetas.Font = New System.Drawing.Font("Arial", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecetas.IconChar = FontAwesome.Sharp.IconChar.BreadSlice
        Me.btnRecetas.IconColor = System.Drawing.Color.Black
        Me.btnRecetas.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnRecetas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRecetas.Location = New System.Drawing.Point(394, 276)
        Me.btnRecetas.Name = "btnRecetas"
        Me.btnRecetas.Size = New System.Drawing.Size(206, 56)
        Me.btnRecetas.TabIndex = 14
        Me.btnRecetas.Text = "Recetas almacen"
        Me.btnRecetas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRecetas.UseVisualStyleBackColor = True
        '
        'btnVerificarProductos
        '
        Me.btnVerificarProductos.Font = New System.Drawing.Font("Arial", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerificarProductos.IconChar = FontAwesome.Sharp.IconChar.Certificate
        Me.btnVerificarProductos.IconColor = System.Drawing.Color.Black
        Me.btnVerificarProductos.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnVerificarProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVerificarProductos.Location = New System.Drawing.Point(628, 214)
        Me.btnVerificarProductos.Name = "btnVerificarProductos"
        Me.btnVerificarProductos.Size = New System.Drawing.Size(191, 56)
        Me.btnVerificarProductos.TabIndex = 13
        Me.btnVerificarProductos.Text = "Verificacion de productos"
        Me.btnVerificarProductos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnVerificarProductos.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Arial", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.IconChar = FontAwesome.Sharp.IconChar.DoorOpen
        Me.btnExit.IconColor = System.Drawing.Color.Black
        Me.btnExit.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.Location = New System.Drawing.Point(654, 382)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(191, 56)
        Me.btnExit.TabIndex = 12
        Me.btnExit.Text = "Salir"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'IconButton4
        '
        Me.IconButton4.Font = New System.Drawing.Font("Arial", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton4.IconChar = FontAwesome.Sharp.IconChar.Certificate
        Me.IconButton4.IconColor = System.Drawing.Color.Black
        Me.IconButton4.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton4.Location = New System.Drawing.Point(628, 152)
        Me.IconButton4.Name = "IconButton4"
        Me.IconButton4.Size = New System.Drawing.Size(191, 56)
        Me.IconButton4.TabIndex = 11
        Me.IconButton4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IconButton4.UseVisualStyleBackColor = True
        '
        'btnDrivers
        '
        Me.btnDrivers.Font = New System.Drawing.Font("Arial", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDrivers.IconChar = FontAwesome.Sharp.IconChar.Globe
        Me.btnDrivers.IconColor = System.Drawing.Color.Black
        Me.btnDrivers.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnDrivers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDrivers.Location = New System.Drawing.Point(628, 90)
        Me.btnDrivers.Name = "btnDrivers"
        Me.btnDrivers.Size = New System.Drawing.Size(191, 56)
        Me.btnDrivers.TabIndex = 10
        Me.btnDrivers.Text = "Choferes"
        Me.btnDrivers.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDrivers.UseVisualStyleBackColor = True
        '
        'btnAddSeller
        '
        Me.btnAddSeller.Font = New System.Drawing.Font("Arial", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddSeller.IconChar = FontAwesome.Sharp.IconChar.UserAlt
        Me.btnAddSeller.IconColor = System.Drawing.Color.Black
        Me.btnAddSeller.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnAddSeller.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddSeller.Location = New System.Drawing.Point(394, 214)
        Me.btnAddSeller.Name = "btnAddSeller"
        Me.btnAddSeller.Size = New System.Drawing.Size(206, 56)
        Me.btnAddSeller.TabIndex = 9
        Me.btnAddSeller.Text = "Agregar vendedoras"
        Me.btnAddSeller.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAddSeller.UseVisualStyleBackColor = True
        '
        'btnNewProducts
        '
        Me.btnNewProducts.Font = New System.Drawing.Font("Arial", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewProducts.IconChar = FontAwesome.Sharp.IconChar.BoxOpen
        Me.btnNewProducts.IconColor = System.Drawing.Color.Black
        Me.btnNewProducts.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnNewProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNewProducts.Location = New System.Drawing.Point(394, 152)
        Me.btnNewProducts.Name = "btnNewProducts"
        Me.btnNewProducts.Size = New System.Drawing.Size(206, 56)
        Me.btnNewProducts.TabIndex = 8
        Me.btnNewProducts.Text = "Productos Nuevos"
        Me.btnNewProducts.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNewProducts.UseVisualStyleBackColor = True
        '
        'btnConnect
        '
        Me.btnConnect.Font = New System.Drawing.Font("Arial", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConnect.IconChar = FontAwesome.Sharp.IconChar.CircleNodes
        Me.btnConnect.IconColor = System.Drawing.Color.Black
        Me.btnConnect.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnConnect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConnect.Location = New System.Drawing.Point(394, 90)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(206, 56)
        Me.btnConnect.TabIndex = 7
        Me.btnConnect.Text = "Verificar conexion"
        Me.btnConnect.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SitemaCentral.My.Resources.Resources.iconoPixels
        Me.PictureBox1.Location = New System.Drawing.Point(12, 90)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(344, 332)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(857, 450)
        Me.Controls.Add(Me.btnRecetas)
        Me.Controls.Add(Me.btnVerificarProductos)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.IconButton4)
        Me.Controls.Add(Me.btnDrivers)
        Me.Controls.Add(Me.btnAddSeller)
        Me.Controls.Add(Me.btnNewProducts)
        Me.Controls.Add(Me.btnConnect)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema Central"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnConnect As FontAwesome.Sharp.IconButton
    Friend WithEvents btnNewProducts As FontAwesome.Sharp.IconButton
    Friend WithEvents btnAddSeller As FontAwesome.Sharp.IconButton
    Friend WithEvents btnExit As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton4 As FontAwesome.Sharp.IconButton
    Friend WithEvents btnDrivers As FontAwesome.Sharp.IconButton
    Friend WithEvents btnVerificarProductos As FontAwesome.Sharp.IconButton
    Friend WithEvents btnRecetas As FontAwesome.Sharp.IconButton
End Class
