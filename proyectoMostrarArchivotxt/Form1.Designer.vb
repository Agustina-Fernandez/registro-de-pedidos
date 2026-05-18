<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtTel = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtDire = New System.Windows.Forms.TextBox()
        Me.TxtPedido = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CmbEntrega = New System.Windows.Forms.ComboBox()
        Me.CmbPago = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BtnBorrar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnLeer = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Sans Serif Collection", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(277, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(226, 56)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pedidos YA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(118, 138)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre:"
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(218, 138)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(387, 22)
        Me.TxtNombre.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(118, 195)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 22)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Teléfono:"
        '
        'TxtTel
        '
        Me.TxtTel.Location = New System.Drawing.Point(218, 195)
        Me.TxtTel.Name = "TxtTel"
        Me.TxtTel.Size = New System.Drawing.Size(387, 22)
        Me.TxtTel.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(118, 241)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 22)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Dirección:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(119, 289)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 22)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Pedido:"
        '
        'TxtDire
        '
        Me.TxtDire.Location = New System.Drawing.Point(218, 243)
        Me.TxtDire.Name = "TxtDire"
        Me.TxtDire.Size = New System.Drawing.Size(387, 22)
        Me.TxtDire.TabIndex = 7
        '
        'TxtPedido
        '
        Me.TxtPedido.Location = New System.Drawing.Point(218, 289)
        Me.TxtPedido.Name = "TxtPedido"
        Me.TxtPedido.Size = New System.Drawing.Size(387, 22)
        Me.TxtPedido.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(103, 386)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 22)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Entrega:"
        '
        'CmbEntrega
        '
        Me.CmbEntrega.FormattingEnabled = True
        Me.CmbEntrega.Items.AddRange(New Object() {"9 a 11", "15 a 17", "19 a 21"})
        Me.CmbEntrega.Location = New System.Drawing.Point(198, 384)
        Me.CmbEntrega.Name = "CmbEntrega"
        Me.CmbEntrega.Size = New System.Drawing.Size(121, 24)
        Me.CmbEntrega.TabIndex = 10
        '
        'CmbPago
        '
        Me.CmbPago.FormattingEnabled = True
        Me.CmbPago.Items.AddRange(New Object() {"Efectivo", "Crédito", "Débito", "Transferencia"})
        Me.CmbPago.Location = New System.Drawing.Point(565, 388)
        Me.CmbPago.Name = "CmbPago"
        Me.CmbPago.Size = New System.Drawing.Size(121, 24)
        Me.CmbPago.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(415, 390)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(133, 22)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Medio de pago:"
        '
        'BtnBorrar
        '
        Me.BtnBorrar.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BtnBorrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnBorrar.Location = New System.Drawing.Point(343, 467)
        Me.BtnBorrar.Name = "BtnBorrar"
        Me.BtnBorrar.Size = New System.Drawing.Size(125, 30)
        Me.BtnBorrar.TabIndex = 13
        Me.BtnBorrar.Text = "Borrar Pedido"
        Me.BtnBorrar.UseVisualStyleBackColor = False
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BtnGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnGuardar.Location = New System.Drawing.Point(343, 520)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(125, 30)
        Me.BtnGuardar.TabIndex = 14
        Me.BtnGuardar.Text = "Guardar Pedido"
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'BtnLeer
        '
        Me.BtnLeer.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BtnLeer.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnLeer.Location = New System.Drawing.Point(343, 576)
        Me.BtnLeer.Name = "BtnLeer"
        Me.BtnLeer.Size = New System.Drawing.Size(125, 30)
        Me.BtnLeer.TabIndex = 15
        Me.BtnLeer.Text = "Leer"
        Me.BtnLeer.UseVisualStyleBackColor = False
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnSalir.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnSalir.Location = New System.Drawing.Point(343, 684)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(125, 30)
        Me.BtnSalir.TabIndex = 16
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 772)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnLeer)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnBorrar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.CmbPago)
        Me.Controls.Add(Me.CmbEntrega)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtPedido)
        Me.Controls.Add(Me.TxtDire)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtTel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Pedidos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtTel As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtDire As TextBox
    Friend WithEvents TxtPedido As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents CmbEntrega As ComboBox
    Friend WithEvents CmbPago As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents BtnBorrar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnLeer As Button
    Friend WithEvents BtnSalir As Button
End Class
