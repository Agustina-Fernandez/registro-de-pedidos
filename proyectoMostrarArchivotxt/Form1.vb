Public Class Form1
    'Archivo local en que se guardaran los pedidos
    Dim archivo = My.Computer.FileSystem.SpecialDirectories.Desktop & "\pedidos.txt"

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        'Evaluamos que los campos no esten vacíos
        If TxtNombre.Text <> "" And TxtTel.Text <> "" And TxtDire.Text <> "" And TxtPedido.Text <> "" And CmbEntrega.SelectedIndex <> -1 And CmbPago.SelectedIndex <> -1 Then
            'Escribimos el pedido en el archivo local
            My.Computer.FileSystem.WriteAllText(archivo, vbCrLf & "Nombre: " & TxtNombre.Text & " Teléfono: " & TxtTel.Text & " Dirección: " & TxtDire.Text & " Pedido: " & TxtPedido.Text & " Horario de entrega: " & CmbEntrega.SelectedItem & " Medio de pago: " & CmbPago.SelectedItem & vbCrLf, True)
            MsgBox("Información guardada")
            'Limpiamos los campos 
            limpiarCampos()

            'Si los campos estan vacíos se solicitara que se completen todos
        Else
            MsgBox("Complete todos los campos")
        End If
    End Sub

    Private Sub BtnLeer_Click(sender As Object, e As EventArgs) Handles BtnLeer.Click
        'Se evalua que el archivo exista para mostrarse
        If My.Computer.FileSystem.FileExists(archivo) Then
            Dim fileReader As String
            fileReader = My.Computer.FileSystem.ReadAllText(archivo)
            MsgBox(fileReader)

            'Si no existe se informa que no hay pedidos realizados todavia
        Else
            MsgBox("Aun no hay ningun pedido registrado")
        End If
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        'Cerramos la aplicación
        Me.Close()
    End Sub

    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs) Handles BtnBorrar.Click
        'Limpiamos los campos
        limpiarCampos()
    End Sub

    'Funcion para limpiar los campos de texto y los combo box
    Public Sub limpiarCampos()
        TxtNombre.Clear()
        TxtTel.Clear()
        TxtDire.Clear()
        TxtPedido.Clear()
        CmbEntrega.SelectedIndex = -1
        CmbPago.SelectedIndex = -1
    End Sub
End Class
