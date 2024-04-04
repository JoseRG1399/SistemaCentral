<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Choferes
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
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnSearchById = New FontAwesome.Sharp.IconButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtUpdatePassword = New System.Windows.Forms.TextBox()
        Me.txtUpdateName = New System.Windows.Forms.TextBox()
        Me.btnUpdateSellerInfo = New FontAwesome.Sharp.IconButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNegativeDriver = New System.Windows.Forms.TextBox()
        Me.btnDelete = New FontAwesome.Sharp.IconButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbbxSucursal = New System.Windows.Forms.ComboBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.btnAddOnlyOne = New FontAwesome.Sharp.IconButton()
        Me.btnAdd = New FontAwesome.Sharp.IconButton()
        Me.btnHome = New FontAwesome.Sharp.IconButton()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(125, 353)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(132, 18)
        Me.Label9.TabIndex = 51
        Me.Label9.Text = "Search by Name"
        '
        'btnSearchById
        '
        Me.btnSearchById.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchById.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass
        Me.btnSearchById.IconColor = System.Drawing.Color.Black
        Me.btnSearchById.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnSearchById.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearchById.Location = New System.Drawing.Point(35, 479)
        Me.btnSearchById.Name = "btnSearchById"
        Me.btnSearchById.Size = New System.Drawing.Size(116, 51)
        Me.btnSearchById.TabIndex = 50
        Me.btnSearchById.Text = "Search"
        Me.btnSearchById.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSearchById.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 151)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 18)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(32, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 18)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(32, 431)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 18)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "Password"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(32, 392)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 18)
        Me.Label8.TabIndex = 44
        Me.Label8.Text = "Name"
        '
        'txtUpdatePassword
        '
        Me.txtUpdatePassword.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUpdatePassword.Location = New System.Drawing.Point(128, 423)
        Me.txtUpdatePassword.Name = "txtUpdatePassword"
        Me.txtUpdatePassword.Size = New System.Drawing.Size(175, 26)
        Me.txtUpdatePassword.TabIndex = 43
        '
        'txtUpdateName
        '
        Me.txtUpdateName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUpdateName.Location = New System.Drawing.Point(128, 384)
        Me.txtUpdateName.Name = "txtUpdateName"
        Me.txtUpdateName.Size = New System.Drawing.Size(175, 26)
        Me.txtUpdateName.TabIndex = 41
        '
        'btnUpdateSellerInfo
        '
        Me.btnUpdateSellerInfo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateSellerInfo.IconChar = FontAwesome.Sharp.IconChar.PenToSquare
        Me.btnUpdateSellerInfo.IconColor = System.Drawing.Color.Black
        Me.btnUpdateSellerInfo.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnUpdateSellerInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdateSellerInfo.Location = New System.Drawing.Point(161, 480)
        Me.btnUpdateSellerInfo.Name = "btnUpdateSellerInfo"
        Me.btnUpdateSellerInfo.Size = New System.Drawing.Size(142, 51)
        Me.btnUpdateSellerInfo.TabIndex = 40
        Me.btnUpdateSellerInfo.Text = "Update information"
        Me.btnUpdateSellerInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnUpdateSellerInfo.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(363, 391)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(189, 18)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Remove driver by Name"
        '
        'txtNegativeDriver
        '
        Me.txtNegativeDriver.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNegativeDriver.Location = New System.Drawing.Point(366, 422)
        Me.txtNegativeDriver.Name = "txtNegativeDriver"
        Me.txtNegativeDriver.Size = New System.Drawing.Size(153, 26)
        Me.txtNegativeDriver.TabIndex = 38
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.IconChar = FontAwesome.Sharp.IconChar.UserXmark
        Me.btnDelete.IconColor = System.Drawing.Color.Black
        Me.btnDelete.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.Location = New System.Drawing.Point(366, 479)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(153, 50)
        Me.btnDelete.TabIndex = 37
        Me.btnDelete.Text = "Delete Seller"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(375, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(138, 18)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Choose a branch"
        '
        'cbbxSucursal
        '
        Me.cbbxSucursal.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbbxSucursal.FormattingEnabled = True
        Me.cbbxSucursal.Items.AddRange(New Object() {"Acropolis", "Adolfo", "Aeropuerto", "Alfredo", "Calimaya", "Carranza", "Colon", "Deportiva", "Fabela", "Lerma", "Metepec", "Mexicaltzingo", "Moderna", "Ocoyoacac", "Santin", "Pino Suarez", "Tecnologico", "Torres", "Xonacatlan", "Fogon"})
        Me.cbbxSucursal.Location = New System.Drawing.Point(366, 150)
        Me.cbbxSucursal.Name = "cbbxSucursal"
        Me.cbbxSucursal.Size = New System.Drawing.Size(153, 26)
        Me.cbbxSucursal.TabIndex = 35
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(128, 146)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(175, 26)
        Me.txtPassword.TabIndex = 34
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(128, 109)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(175, 26)
        Me.txtNombre.TabIndex = 32
        '
        'btnAddOnlyOne
        '
        Me.btnAddOnlyOne.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddOnlyOne.IconChar = FontAwesome.Sharp.IconChar.Store
        Me.btnAddOnlyOne.IconColor = System.Drawing.Color.Black
        Me.btnAddOnlyOne.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnAddOnlyOne.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddOnlyOne.Location = New System.Drawing.Point(366, 192)
        Me.btnAddOnlyOne.Name = "btnAddOnlyOne"
        Me.btnAddOnlyOne.Size = New System.Drawing.Size(160, 64)
        Me.btnAddOnlyOne.TabIndex = 31
        Me.btnAddOnlyOne.Text = "Add only in one store"
        Me.btnAddOnlyOne.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAddOnlyOne.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.IconChar = FontAwesome.Sharp.IconChar.UserPlus
        Me.btnAdd.IconColor = System.Drawing.Color.Black
        Me.btnAdd.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdd.Location = New System.Drawing.Point(94, 205)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(209, 51)
        Me.btnAdd.TabIndex = 30
        Me.btnAdd.Text = "Add to all branches"
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnHome
        '
        Me.btnHome.IconChar = FontAwesome.Sharp.IconChar.HomeLg
        Me.btnHome.IconColor = System.Drawing.Color.Black
        Me.btnHome.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.btnHome.Location = New System.Drawing.Point(468, 21)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(51, 48)
        Me.btnHome.TabIndex = 29
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'Choferes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(560, 570)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnSearchById)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtUpdatePassword)
        Me.Controls.Add(Me.txtUpdateName)
        Me.Controls.Add(Me.btnUpdateSellerInfo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtNegativeDriver)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbbxSucursal)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.btnAddOnlyOne)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnHome)
        Me.Name = "Choferes"
        Me.Text = "Choferes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label9 As Label
    Friend WithEvents btnSearchById As FontAwesome.Sharp.IconButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtUpdatePassword As TextBox
    Friend WithEvents txtUpdateName As TextBox
    Friend WithEvents btnUpdateSellerInfo As FontAwesome.Sharp.IconButton
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNegativeDriver As TextBox
    Friend WithEvents btnDelete As FontAwesome.Sharp.IconButton
    Friend WithEvents Label4 As Label
    Friend WithEvents cbbxSucursal As ComboBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents btnAddOnlyOne As FontAwesome.Sharp.IconButton
    Friend WithEvents btnAdd As FontAwesome.Sharp.IconButton
    Friend WithEvents btnHome As FontAwesome.Sharp.IconButton
End Class
