﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Consultar_recetas
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
        Me.cbbxSelectRecetas = New System.Windows.Forms.ComboBox()
        Me.cbbxDepartamentos = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        CType(Me.dgRecetas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgRecetas
        '
        Me.dgRecetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgRecetas.Location = New System.Drawing.Point(21, 101)
        Me.dgRecetas.Name = "dgRecetas"
        Me.dgRecetas.Size = New System.Drawing.Size(1018, 442)
        Me.dgRecetas.TabIndex = 0
        '
        'cbbxSelectRecetas
        '
        Me.cbbxSelectRecetas.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbbxSelectRecetas.FormattingEnabled = True
        Me.cbbxSelectRecetas.Location = New System.Drawing.Point(283, 37)
        Me.cbbxSelectRecetas.Name = "cbbxSelectRecetas"
        Me.cbbxSelectRecetas.Size = New System.Drawing.Size(239, 32)
        Me.cbbxSelectRecetas.TabIndex = 164
        '
        'cbbxDepartamentos
        '
        Me.cbbxDepartamentos.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbbxDepartamentos.FormattingEnabled = True
        Me.cbbxDepartamentos.Location = New System.Drawing.Point(22, 37)
        Me.cbbxDepartamentos.Name = "cbbxDepartamentos"
        Me.cbbxDepartamentos.Size = New System.Drawing.Size(239, 32)
        Me.cbbxDepartamentos.TabIndex = 165
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 22)
        Me.Label1.TabIndex = 166
        Me.Label1.Text = "Departamento"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(279, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 22)
        Me.Label2.TabIndex = 167
        Me.Label2.Text = "Recetas"
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(736, 12)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(122, 64)
        Me.btnVolver.TabIndex = 168
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(549, 9)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(122, 64)
        Me.btnBuscar.TabIndex = 169
        Me.btnBuscar.Text = "Buscar receta"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'Consultar_recetas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1051, 555)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbbxDepartamentos)
        Me.Controls.Add(Me.cbbxSelectRecetas)
        Me.Controls.Add(Me.dgRecetas)
        Me.Name = "Consultar_recetas"
        Me.Text = "Consultar_recetas"
        CType(Me.dgRecetas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgRecetas As DataGridView
    Friend WithEvents cbbxSelectRecetas As ComboBox
    Friend WithEvents cbbxDepartamentos As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnVolver As Button
    Friend WithEvents btnBuscar As Button
End Class
