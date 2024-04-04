<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtMatricula = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.cbbxSucursal = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNegativeMatricula = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnUpdateSellerInfo = New FontAwesome.Sharp.IconButton()
        Me.btnDelete = New FontAwesome.Sharp.IconButton()
        Me.btnAddOnlyOne = New FontAwesome.Sharp.IconButton()
        Me.btnAdd = New FontAwesome.Sharp.IconButton()
        Me.btnHome = New FontAwesome.Sharp.IconButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtUpdatePassword = New System.Windows.Forms.TextBox()
        Me.txtSearchById = New System.Windows.Forms.TextBox()
        Me.txtUpdateName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSearchById = New FontAwesome.Sharp.IconButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(137, 47)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(175, 26)
        Me.txtNombre.TabIndex = 6
        '
        'txtMatricula
        '
        Me.txtMatricula.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMatricula.Location = New System.Drawing.Point(137, 84)
        Me.txtMatricula.Name = "txtMatricula"
        Me.txtMatricula.Size = New System.Drawing.Size(175, 26)
        Me.txtMatricula.TabIndex = 7
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(137, 127)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(175, 26)
        Me.txtPassword.TabIndex = 8
        '
        'cbbxSucursal
        '
        Me.cbbxSucursal.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbbxSucursal.FormattingEnabled = True
        Me.cbbxSucursal.Items.AddRange(New Object() {"Acropolis", "Adolfo", "Aeropuerto", "Alfredo", "Calimaya", "Carranza", "Colon", "Deportiva", "Fabela", "Lerma", "Metepec", "Mexicaltzingo", "Moderna", "Ocoyoacac", "Santin", "Pino Suarez", "Tecnologico", "Torres", "Xonacatlan", "Fogon"})
        Me.cbbxSucursal.Location = New System.Drawing.Point(375, 131)
        Me.cbbxSucursal.Name = "cbbxSucursal"
        Me.cbbxSucursal.Size = New System.Drawing.Size(153, 26)
        Me.cbbxSucursal.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(384, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(138, 18)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Choose a branch"
        '
        'txtNegativeMatricula
        '
        Me.txtNegativeMatricula.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNegativeMatricula.Location = New System.Drawing.Point(375, 403)
        Me.txtNegativeMatricula.Name = "txtNegativeMatricula"
        Me.txtNegativeMatricula.Size = New System.Drawing.Size(153, 26)
        Me.txtNegativeMatricula.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(372, 372)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(160, 18)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Remove seller by ID"
        '
        'btnUpdateSellerInfo
        '
        Me.btnUpdateSellerInfo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateSellerInfo.IconChar = FontAwesome.Sharp.IconChar.PenToSquare
        Me.btnUpdateSellerInfo.IconColor = System.Drawing.Color.Black
        Me.btnUpdateSellerInfo.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnUpdateSellerInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdateSellerInfo.Location = New System.Drawing.Point(170, 461)
        Me.btnUpdateSellerInfo.Name = "btnUpdateSellerInfo"
        Me.btnUpdateSellerInfo.Size = New System.Drawing.Size(142, 51)
        Me.btnUpdateSellerInfo.TabIndex = 17
        Me.btnUpdateSellerInfo.Text = "Update information"
        Me.btnUpdateSellerInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnUpdateSellerInfo.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.IconChar = FontAwesome.Sharp.IconChar.UserXmark
        Me.btnDelete.IconColor = System.Drawing.Color.Black
        Me.btnDelete.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.Location = New System.Drawing.Point(375, 460)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(153, 50)
        Me.btnDelete.TabIndex = 14
        Me.btnDelete.Text = "Delete Seller"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnAddOnlyOne
        '
        Me.btnAddOnlyOne.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddOnlyOne.IconChar = FontAwesome.Sharp.IconChar.Store
        Me.btnAddOnlyOne.IconColor = System.Drawing.Color.Black
        Me.btnAddOnlyOne.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnAddOnlyOne.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddOnlyOne.Location = New System.Drawing.Point(375, 173)
        Me.btnAddOnlyOne.Name = "btnAddOnlyOne"
        Me.btnAddOnlyOne.Size = New System.Drawing.Size(160, 64)
        Me.btnAddOnlyOne.TabIndex = 5
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
        Me.btnAdd.Location = New System.Drawing.Point(103, 186)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(209, 51)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "Add to all branches"
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnHome
        '
        Me.btnHome.IconChar = FontAwesome.Sharp.IconChar.HomeLg
        Me.btnHome.IconColor = System.Drawing.Color.Black
        Me.btnHome.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.btnHome.Location = New System.Drawing.Point(477, 12)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(51, 48)
        Me.btnHome.TabIndex = 3
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(41, 412)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 18)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Password"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(41, 341)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(25, 18)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "ID"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(41, 373)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 18)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Name"
        '
        'txtUpdatePassword
        '
        Me.txtUpdatePassword.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUpdatePassword.Location = New System.Drawing.Point(137, 404)
        Me.txtUpdatePassword.Name = "txtUpdatePassword"
        Me.txtUpdatePassword.Size = New System.Drawing.Size(175, 26)
        Me.txtUpdatePassword.TabIndex = 20
        '
        'txtSearchById
        '
        Me.txtSearchById.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchById.Location = New System.Drawing.Point(137, 333)
        Me.txtSearchById.Name = "txtSearchById"
        Me.txtSearchById.Size = New System.Drawing.Size(175, 26)
        Me.txtSearchById.TabIndex = 19
        '
        'txtUpdateName
        '
        Me.txtUpdateName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUpdateName.Location = New System.Drawing.Point(137, 365)
        Me.txtUpdateName.Name = "txtUpdateName"
        Me.txtUpdateName.Size = New System.Drawing.Size(175, 26)
        Me.txtUpdateName.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(41, 132)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 18)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(41, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 18)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(41, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 18)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Name"
        '
        'btnSearchById
        '
        Me.btnSearchById.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchById.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass
        Me.btnSearchById.IconColor = System.Drawing.Color.Black
        Me.btnSearchById.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnSearchById.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearchById.Location = New System.Drawing.Point(44, 460)
        Me.btnSearchById.Name = "btnSearchById"
        Me.btnSearchById.Size = New System.Drawing.Size(116, 51)
        Me.btnSearchById.TabIndex = 27
        Me.btnSearchById.Text = "Search"
        Me.btnSearchById.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSearchById.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(134, 296)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(101, 18)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Search by id"
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(560, 543)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnSearchById)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtUpdatePassword)
        Me.Controls.Add(Me.txtSearchById)
        Me.Controls.Add(Me.txtUpdateName)
        Me.Controls.Add(Me.btnUpdateSellerInfo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtNegativeMatricula)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbbxSucursal)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtMatricula)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.btnAddOnlyOne)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnHome)
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnHome As FontAwesome.Sharp.IconButton
    Friend WithEvents btnAdd As FontAwesome.Sharp.IconButton
    Friend WithEvents btnAddOnlyOne As FontAwesome.Sharp.IconButton
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtMatricula As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents cbbxSucursal As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnDelete As FontAwesome.Sharp.IconButton
    Friend WithEvents txtNegativeMatricula As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnUpdateSellerInfo As FontAwesome.Sharp.IconButton
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtUpdatePassword As TextBox
    Friend WithEvents txtSearchById As TextBox
    Friend WithEvents txtUpdateName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnSearchById As FontAwesome.Sharp.IconButton
    Friend WithEvents Label9 As Label
End Class
