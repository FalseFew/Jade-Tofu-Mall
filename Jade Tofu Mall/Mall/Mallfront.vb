Public Class Mallfront
    Private Sub Mallfront_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        ' Define the height of the top border
        Dim borderHeight As Integer = 50

        ' Create a gray brush for the header
        Dim grayBrush As New SolidBrush(Color.Gray)

        ' Draw the top border
        e.Graphics.FillRectangle(grayBrush, 0, 0, Me.ClientSize.Width, borderHeight)

    End Sub

    Private Sub Mallfront_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Create and configure the Label
        Dim label As New Label()
        label.Name = "CenteredLabel"
        label.Text = "Jade Tofu Mall"
        label.Font = New Font("Arial", 20, FontStyle.Bold) ' Set font size and style
        label.ForeColor = Color.MediumSeaGreen
        label.BackColor = Color.Gray
        label.AutoSize = True ' Automatically adjust size based on text
        label.TextAlign = ContentAlignment.MiddleCenter

        ' Add the Label to the form
        Me.Controls.Add(label)

        ' Center the Label initially
        CenterLabel()
    End Sub

    Private Sub Mallfront_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        ' Re-center the Label when the form is resized
        CenterLabel()
    End Sub

    Private Sub CenterLabel()
        ' Find the Label by name
        Dim label As Label = Me.Controls.OfType(Of Label)().FirstOrDefault(Function(lbl) lbl.Name = "CenteredLabel")
        If label IsNot Nothing Then
            ' Center the Label horizontally at the top of the form
            label.Left = (Me.ClientSize.Width - label.Width) \ 2
            label.Top = 10 ' Set a fixed distance from the top of the form
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        StoreFront.Show()
        Me.Hide() ' Hide the current form
    End Sub
End Class
