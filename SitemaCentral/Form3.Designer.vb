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
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.btnHome = New FontAwesome.Sharp.IconButton()
        Me.txtUpdate = New System.Windows.Forms.TextBox()
        Me.cbbBrandsOffice = New System.Windows.Forms.ComboBox()
        Me.btnUpdate = New FontAwesome.Sharp.IconButton()
        Me.cbbProducts = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(796, 219)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 1
        '
        'btnHome
        '
        Me.btnHome.IconChar = FontAwesome.Sharp.IconChar.HomeLg
        Me.btnHome.IconColor = System.Drawing.Color.Black
        Me.btnHome.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.btnHome.Location = New System.Drawing.Point(737, 12)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(51, 48)
        Me.btnHome.TabIndex = 3
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'txtUpdate
        '
        Me.txtUpdate.Location = New System.Drawing.Point(381, 102)
        Me.txtUpdate.Name = "txtUpdate"
        Me.txtUpdate.Size = New System.Drawing.Size(188, 20)
        Me.txtUpdate.TabIndex = 4
        '
        'cbbBrandsOffice
        '
        Me.cbbBrandsOffice.FormattingEnabled = True
        Me.cbbBrandsOffice.Location = New System.Drawing.Point(374, 24)
        Me.cbbBrandsOffice.Name = "cbbBrandsOffice"
        Me.cbbBrandsOffice.Size = New System.Drawing.Size(215, 21)
        Me.cbbBrandsOffice.TabIndex = 5
        '
        'btnUpdate
        '
        Me.btnUpdate.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btnUpdate.IconColor = System.Drawing.Color.Black
        Me.btnUpdate.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnUpdate.Location = New System.Drawing.Point(402, 173)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(209, 65)
        Me.btnUpdate.TabIndex = 6
        Me.btnUpdate.Text = "Actualizar nombre"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'cbbProducts
        '
        Me.cbbProducts.FormattingEnabled = True
        Me.cbbProducts.Location = New System.Drawing.Point(106, 27)
        Me.cbbProducts.Name = "cbbProducts"
        Me.cbbProducts.Size = New System.Drawing.Size(215, 21)
        Me.cbbProducts.TabIndex = 7
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cbbProducts)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.cbbBrandsOffice)
        Me.Controls.Add(Me.txtUpdate)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar productos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents btnHome As FontAwesome.Sharp.IconButton
    Friend WithEvents txtUpdate As TextBox
    Friend WithEvents cbbBrandsOffice As ComboBox
    Friend WithEvents btnUpdate As FontAwesome.Sharp.IconButton
    Friend WithEvents cbbProducts As ComboBox
End Class
