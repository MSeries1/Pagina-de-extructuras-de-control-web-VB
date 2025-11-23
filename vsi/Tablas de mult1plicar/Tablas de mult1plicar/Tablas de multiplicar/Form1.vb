Imports System.Text

Public Class Form1

    ' Constructor del formulario
    Public Sub New()
        ' Esta llamada es requerida por el diseñador
        InitializeComponent()

        ' Configuración inicial del estilo visual del formulario
        Me.ConfigurarEstiloVisual()
        ' Configurar controles adicionales
        Me.ConfigurarControlesAdicionales()
    End Sub

    ''' <summary>
    ''' Configura el estilo visual del formulario con colores blanco y morado
    ''' </summary>
    Private Sub ConfigurarEstiloVisual()
        ' Configuración del formulario principal
        Me.BackColor = Color.White
        Me.ForeColor = Color.FromArgb(102, 0, 153) ' Morado primario
        Me.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular)
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Text = "Generador de Tablas de Multiplicar"
        Me.Size = New Size(500, 450) ' Tamaño aumentado para acomodar nuevo contenido

        ' Configurar estilo para todos los controles del formulario
        Me.AplicarEstiloControles()
    End Sub

    ''' <summary>
    ''' Configura los controles adicionales de título e instrucciones
    ''' </summary>
    Private Sub ConfigurarControlesAdicionales()
        ' Configurar título principal
        ConfigurarTituloPrincipal()

        ' Configurar panel de instrucciones
        ConfigurarPanelInstrucciones()

        ' Configurar área de entrada
        ConfigurarAreaEntrada()
    End Sub

    ''' <summary>
    ''' Configura el título principal de la aplicación
    ''' </summary>
    Private Sub ConfigurarTituloPrincipal()
        ' Etiqueta del título principal
        Dim lblTitulo As New Label()
        lblTitulo.Text = "GENERADOR DE TABLAS DE MULTIPLICAR"
        lblTitulo.Font = New Font("Segoe UI", 16.0F, FontStyle.Bold)
        lblTitulo.ForeColor = Color.FromArgb(102, 0, 153) ' Morado primario
        lblTitulo.BackColor = Color.Transparent
        lblTitulo.Size = New Size(450, 40)
        lblTitulo.Location = New Point(25, 20)
        lblTitulo.TextAlign = ContentAlignment.MiddleCenter
        Me.Controls.Add(lblTitulo)

        ' Línea decorativa bajo el título
        Dim lineaSeparador As New Label()
        lineaSeparador.BackColor = Color.FromArgb(102, 0, 153) ' Morado primario
        lineaSeparador.Size = New Size(400, 2)
        lineaSeparador.Location = New Point(50, 65)
        Me.Controls.Add(lineaSeparador)
    End Sub

    ''' <summary>
    ''' Configura el panel de instrucciones con viñetas
    ''' </summary>
    Private Sub ConfigurarPanelInstrucciones()
        ' Panel contenedor de instrucciones
        Dim panelInstrucciones As New Panel()
        panelInstrucciones.BackColor = Color.FromArgb(245, 240, 255) ' Morado muy claro
        panelInstrucciones.Size = New Size(400, 120)
        panelInstrucciones.Location = New Point(50, 90)
        panelInstrucciones.BorderStyle = BorderStyle.FixedSingle
        Me.Controls.Add(panelInstrucciones)

        ' Título de instrucciones
        Dim lblInstruccionesTitulo As New Label()
        lblInstruccionesTitulo.Text = "📋 INSTRUCCIONES DE USO"
        lblInstruccionesTitulo.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblInstruccionesTitulo.ForeColor = Color.FromArgb(102, 0, 153)
        lblInstruccionesTitulo.Size = New Size(380, 25)
        lblInstruccionesTitulo.Location = New Point(10, 8)
        lblInstruccionesTitulo.TextAlign = ContentAlignment.MiddleLeft
        panelInstrucciones.Controls.Add(lblInstruccionesTitulo)

        ' Instrucción 1
        Dim lblInstruccion1 As New Label()
        lblInstruccion1.Text = "1. Ingresa un número entero en el campo de texto"
        lblInstruccion1.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular)
        lblInstruccion1.ForeColor = Color.FromArgb(80, 0, 120)
        lblInstruccion1.Size = New Size(380, 20)
        lblInstruccion1.Location = New Point(25, 35)
        lblInstruccion1.TextAlign = ContentAlignment.MiddleLeft
        panelInstrucciones.Controls.Add(lblInstruccion1)

        ' Instrucción 2
        Dim lblInstruccion2 As New Label()
        lblInstruccion2.Text = "2. Puedes usar números positivos o negativos"
        lblInstruccion2.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular)
        lblInstruccion2.ForeColor = Color.FromArgb(80, 0, 120)
        lblInstruccion2.Size = New Size(380, 20)
        lblInstruccion2.Location = New Point(25, 55)
        lblInstruccion2.TextAlign = ContentAlignment.MiddleLeft
        panelInstrucciones.Controls.Add(lblInstruccion2)

        ' Instrucción 3
        Dim lblInstruccion3 As New Label()
        lblInstruccion3.Text = "3. Haz clic en el botón 'Generar Tabla'"
        lblInstruccion3.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular)
        lblInstruccion3.ForeColor = Color.FromArgb(80, 0, 120)
        lblInstruccion3.Size = New Size(380, 20)
        lblInstruccion3.Location = New Point(25, 75)
        lblInstruccion3.TextAlign = ContentAlignment.MiddleLeft
        panelInstrucciones.Controls.Add(lblInstruccion3)

        ' Instrucción 4
        Dim lblInstruccion4 As New Label()
        lblInstruccion4.Text = "4. La tabla se mostrará en un cuadro de mensaje"
        lblInstruccion4.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular)
        lblInstruccion4.ForeColor = Color.FromArgb(80, 0, 120)
        lblInstruccion4.Size = New Size(380, 20)
        lblInstruccion4.Location = New Point(25, 95)
        lblInstruccion4.TextAlign = ContentAlignment.MiddleLeft
        panelInstrucciones.Controls.Add(lblInstruccion4)
    End Sub

    ''' <summary>
    ''' Configura el área de entrada de datos
    ''' </summary>
    Private Sub ConfigurarAreaEntrada()
        ' Etiqueta para el campo de entrada
        Dim lblNumero As New Label()
        lblNumero.Text = "Ingresa un número:"
        lblNumero.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblNumero.ForeColor = Color.FromArgb(102, 0, 153)
        lblNumero.Size = New Size(150, 25)
        lblNumero.Location = New Point(50, 230)
        lblNumero.TextAlign = ContentAlignment.MiddleLeft
        Me.Controls.Add(lblNumero)

        ' Reubicar el TextBox1 existente
        TextBox1.Location = New Point(200, 230)
        TextBox1.Size = New Size(100, 25)
        TextBox1.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular)
        TextBox1.TextAlign = HorizontalAlignment.Center

        ' Reubicar el Button1 existente
        Button1.Location = New Point(320, 230)
        Button1.Size = New Size(130, 28)
        Button1.Text = "Generar Tabla"

        ' Etiqueta de ejemplo
        Dim lblEjemplo As New Label()
        lblEjemplo.Text = "Ejemplo: 5, -3, 12, etc."
        lblEjemplo.Font = New Font("Segoe UI", 8.0F, FontStyle.Italic)
        lblEjemplo.ForeColor = Color.Gray
        lblEjemplo.Size = New Size(200, 20)
        lblEjemplo.Location = New Point(200, 255)
        lblEjemplo.TextAlign = ContentAlignment.MiddleLeft
        Me.Controls.Add(lblEjemplo)
    End Sub

    ''' <summary>
    ''' Aplica el estilo consistente a todos los controles del formulario
    ''' </summary>
    Private Sub AplicarEstiloControles()
        For Each control As Control In Me.Controls
            Select Case control.GetType()
                Case GetType(Button)
                    ConfigurarBoton(CType(control, Button))
                Case GetType(TextBox)
                    ConfigurarTextBox(CType(control, TextBox))
                Case GetType(Label)
                    ConfigurarLabel(CType(control, Label))
            End Select
        Next
    End Sub

    ''' <summary>
    ''' Configura el estilo visual de los botones
    ''' </summary>
    ''' <param name="boton">Instancia del botón a configurar</param>
    Private Sub ConfigurarBoton(boton As Button)
        boton.BackColor = Color.FromArgb(102, 0, 153) ' Morado primario
        boton.ForeColor = Color.White
        boton.FlatStyle = FlatStyle.Flat
        boton.FlatAppearance.BorderSize = 0
        boton.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        boton.Cursor = Cursors.Hand

        ' Efectos hover para mejor experiencia de usuario
        boton.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 0, 192) ' Morado secundario más claro
        boton.FlatAppearance.MouseDownBackColor = Color.FromArgb(76, 0, 115) ' Morado más oscuro
    End Sub

    ''' <summary>
    ''' Configura el estilo visual de los cuadros de texto
    ''' </summary>
    ''' <param name="textBox">Instancia del TextBox a configurar</param>
    Private Sub ConfigurarTextBox(textBox As TextBox)
        textBox.BackColor = Color.White
        textBox.ForeColor = Color.FromArgb(102, 0, 153) ' Morado primario
        textBox.BorderStyle = BorderStyle.FixedSingle
        textBox.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular)
    End Sub

    ''' <summary>
    ''' Configura el estilo visual de las etiquetas
    ''' ''' </summary>
    ''' <param name="label">Instancia de la Label a configurar</param>
    Private Sub ConfigurarLabel(label As Label)
        label.ForeColor = Color.FromArgb(102, 0, 153) ' Morado primario
        label.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        label.BackColor = Color.Transparent
    End Sub

    ''' <summary>
    ''' Maneja el evento Click del botón para generar la tabla de multiplicar
    ''' </summary>
    ''' <param name="sender">Objeto que generó el evento</param>
    ''' <param name="e">Argumentos del evento</param>
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Declaración de variables locales
        Dim numeroIngresado As Integer
        Dim tablaMultiplicar As New StringBuilder()

        ' Validar que el dato ingresado sea un número entero válido
        If Not Integer.TryParse(TextBox1.Text, numeroIngresado) Then
            MostrarMensajeError("Por favor, ingrese un número entero válido.")
            Exit Sub
        End If

        ' Validar rango razonable para evitar números muy grandes
        If numeroIngresado < -1000 OrElse numeroIngresado > 1000 Then
            MostrarMensajeError("Por favor, ingrese un número entre -1000 y 1000.")
            Exit Sub
        End If

        ' Generar la tabla de multiplicar usando StringBuilder para mejor rendimiento
        GenerarTablaMultiplicar(numeroIngresado, tablaMultiplicar)

        ' Mostrar el resultado al usuario
        MostrarResultado(tablaMultiplicar.ToString(), numeroIngresado)
    End Sub

    ''' <summary>
    ''' Genera la tabla de multiplicar para el número especificado
    ''' </summary>
    ''' <param name="numero">Número base para la tabla de multiplicar</param>
    ''' <param name="tabla">StringBuilder donde se almacenará el resultado</param>
    Private Sub GenerarTablaMultiplicar(numero As Integer, ByRef tabla As StringBuilder)
        ' Encabezado de la tabla
        tabla.AppendLine($"TABLA DE MULTIPLICAR DEL {numero}")
        tabla.AppendLine(New String("=", 30))

        ' Generar las 10 operaciones de multiplicación
        For contador As Integer = 1 To 10
            Dim resultado As Integer = numero * contador
            tabla.AppendLine($"{numero,4} × {contador,2} = {resultado,6}")
        Next

        ' Pie de la tabla
        tabla.AppendLine(New String("=", 30))
    End Sub

    ''' <summary>
    ''' Muestra un mensaje de error al usuario
    ''' </summary>
    ''' <param name="mensaje">Texto del mensaje de error</param>
    Private Sub MostrarMensajeError(mensaje As String)
        MessageBox.Show(mensaje,
                       "Error de Validación",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error)

        ' Restablecer el foco al cuadro de texto para corrección rápida
        TextBox1.Focus()
        TextBox1.SelectAll()
    End Sub

    ''' <summary>
    ''' Muestra el resultado de la tabla de multiplicar generada
    ''' </summary>
    ''' <param name="tabla">Texto de la tabla generada</param>
    ''' <param name="numero">Número base utilizado</param>
    Private Sub MostrarResultado(tabla As String, numero As Integer)
        MessageBox.Show(tabla,
                       $"Tabla del {numero}",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information)
    End Sub

    ''' <summary>
    ''' Maneja el evento KeyPress del TextBox para permitir solo números y signo negativo
    ''' </summary>
    ''' <param name="sender">Objeto que generó el evento</param>
    ''' <param name="e">Argumentos del evento KeyPress</param>
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        ' Permitir solo dígitos, control de retroceso y signo negativo al inicio
        If Not Char.IsDigit(e.KeyChar) AndAlso
           e.KeyChar <> ControlChars.Back AndAlso
           Not (e.KeyChar = "-"c AndAlso TextBox1.SelectionStart = 0 AndAlso Not TextBox1.Text.Contains("-")) Then
            e.Handled = True
        End If
    End Sub

    ''' <summary>
    ''' Maneja el evento Enter del TextBox para mejorar la experiencia de usuario
    ''' </summary>
    ''' <param name="sender">Objeto que generó el evento</param>
    ''' <param name="e">Argumentos del evento</param>
    Private Sub TextBox1_Enter(sender As Object, e As EventArgs) Handles TextBox1.Enter
        ' Resaltar el TextBox cuando recibe el foco
        Dim txtBox As TextBox = CType(sender, TextBox)
        txtBox.BackColor = Color.FromArgb(240, 230, 255) ' Morado muy claro
        txtBox.SelectAll()
    End Sub

    ''' <summary>
    ''' Maneja el evento Leave del TextBox para restaurar el color original
    ''' </summary>
    ''' <param name="sender">Objeto que generó el evento</param>
    ''' <param name="e">Argumentos del evento</param>
    Private Sub TextBox1_Leave(sender As Object, e As EventArgs) Handles TextBox1.Leave
        ' Restaurar el color original del TextBox cuando pierde el foco
        Dim txtBox As TextBox = CType(sender, TextBox)
        txtBox.BackColor = Color.White
    End Sub

End Class