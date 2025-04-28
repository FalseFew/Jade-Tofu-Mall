Imports System.Runtime.CompilerServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Jade_Tofu_Mall.productManager

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        productData.InitializeProducts()


        ' Set initial properties for the TextBox
        TextBox1.AutoSize = False
        TextBox1.MinimumSize = New Size(100, 20) ' Set minimum size for the TextBox
        TextBox1.Text = "Username"

        TextBox2.AutoSize = False
        TextBox2.MinimumSize = New Size(100, 20) ' Set minimum size for the TextBox
        TextBox2.Text = "Password"
        TextBox2.UseSystemPasswordChar = True ' Mask the password input

        Button1.AutoSize = False
        Button1.MinimumSize = New Size(150, 20) ' Set minimum size for the Button
        Button1.Text = "Sign-in"

        Label1.AutoSize = False
        Label1.MinimumSize = New Size(200, 50) ' Set minimum size for the Label
        Label1.Text = "Jade Tofu Mall"


        CenterComponents()




    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        ' Re-center the TextBox when the form is resized
        CenterComponents()
    End Sub

    Private Sub CenterComponents()
        ' Center the TextBox in the form
        TextBox1.Left = (Me.ClientSize.Width - TextBox1.Width) \ 2
        TextBox1.Top = (Me.ClientSize.Height - TextBox1.Height) \ 2

        TextBox2.Left = (Me.ClientSize.Width - TextBox1.Width) \ 2
        TextBox2.Top = (Me.ClientSize.Height - TextBox1.Height) \ 2 + 30

        Button1.Left = (Me.ClientSize.Width - Button1.Width) \ 2
        Button1.Top = (Me.ClientSize.Height - Button1.Height) \ 2 + 60

        Label1.Left = (Me.ClientSize.Width - Label1.Width) \ 2
        Label1.Top = (Me.ClientSize.Height - Label1.Height) \ 2 - 50
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Define arrays of usernames and passwords
        Dim usernames As String() = {"admin", "tofu", "Ivy", "Username"}
        Dim passwords As String() = {"123", "Naija", "Thorn", "Password"}

        ' Check if the entered username and password match any pair in the arrays
        Dim isValid As Boolean = False
        For i As Integer = 0 To usernames.Length - 1
            If TextBox1.Text = usernames(i) AndAlso TextBox2.Text = passwords(i) Then
                isValid = True
                Exit For
            End If
        Next

        ' If valid, open Form2; otherwise, show an error message
        If isValid Then
            Dim form2 As New Mallfront()
            form2.Show()
            Me.Hide() ' Optionally hide the current form
        Else
            MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Item1.Show()
    End Sub


    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    ' Define the correct username and password
    'Dim correctUsername As String = "admin"
    'Dim correctPassword As String = "123"

    ' Check if the entered username and password match
    'If TextBox1.Text = correctUsername AndAlso TextBox2.Text = correctPassword Then
    ' Show an error message if the credentials are incorrect
    '     MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
    'End If
    'End Sub
    ' Open Form2 if the credentials are correct
    'Dim form2 As New Form2()
    '       form2.Show()
    'Me.Hide() ' Optionally hide the current form
    'Else
End Class


