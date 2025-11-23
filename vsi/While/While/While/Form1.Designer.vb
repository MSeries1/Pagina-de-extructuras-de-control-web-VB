<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Button1 = New Button()
        Label1 = New Label()
        txt_usuario = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        txt_contraseña = New TextBox()
        txt_estatus = New TextBox()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(302, 292)
        Button1.Name = "Button1"
        Button1.Size = New Size(162, 45)
        Button1.TabIndex = 0
        Button1.Text = "Ingresar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(336, 13)
        Label1.Name = "Label1"
        Label1.Size = New Size(118, 60)
        Label1.TabIndex = 1
        Label1.Text = "Bienvenido! " & vbCrLf & vbCrLf & "Crea una cuenta."
        ' 
        ' txt_usuario
        ' 
        txt_usuario.Location = New Point(293, 143)
        txt_usuario.Name = "txt_usuario"
        txt_usuario.Size = New Size(195, 27)
        txt_usuario.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(293, 110)
        Label2.Name = "Label2"
        Label2.Size = New Size(137, 20)
        Label2.TabIndex = 3
        Label2.Text = "Nombre de usuario"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(293, 201)
        Label3.Name = "Label3"
        Label3.Size = New Size(83, 20)
        Label3.TabIndex = 5
        Label3.Text = "Contraseña"
        ' 
        ' txt_contraseña
        ' 
        txt_contraseña.Location = New Point(293, 234)
        txt_contraseña.Name = "txt_contraseña"
        txt_contraseña.Size = New Size(195, 27)
        txt_contraseña.TabIndex = 4
        ' 
        ' txt_estatus
        ' 
        txt_estatus.Location = New Point(293, 394)
        txt_estatus.Name = "txt_estatus"
        txt_estatus.Size = New Size(195, 27)
        txt_estatus.TabIndex = 6
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(293, 362)
        Label4.Name = "Label4"
        Label4.Size = New Size(55, 20)
        Label4.TabIndex = 7
        Label4.Text = "Estatus"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label4)
        Controls.Add(txt_estatus)
        Controls.Add(Label3)
        Controls.Add(txt_contraseña)
        Controls.Add(Label2)
        Controls.Add(txt_usuario)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_usuario As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_contraseña As TextBox
    Friend WithEvents txt_estatus As TextBox
    Friend WithEvents Label4 As Label

End Class
