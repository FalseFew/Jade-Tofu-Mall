Public Class Checkout1
    Private Sub StoreFront_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        ' Define the height of the top border
        Dim topBorderHeight As Integer = 50
        Dim bottomBorderHeight As Integer = 80

        ' Create a gray brush for the header
        Dim grayBrush As New SolidBrush(Color.Gray)

        ' Draw the top border
        e.Graphics.FillRectangle(grayBrush, 0, 0, Me.ClientSize.Width, topBorderHeight)
        e.Graphics.FillRectangle(grayBrush, 0, Me.ClientSize.Height - bottomBorderHeight, Me.ClientSize.Width, bottomBorderHeight)
    End Sub

    Private Sub StoreFront_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Create and configure the Store Label
        Dim label As New Label()
        label.Name = "CenteredLabel"
        label.Text = "Sole Purpose"
        label.Font = New Font("Arial", 20, FontStyle.Bold) ' Set font size and style
        label.ForeColor = Color.MediumSeaGreen
        label.BackColor = Color.Gray
        label.AutoSize = True ' Automatically adjust size based on text
        label.TextAlign = ContentAlignment.MiddleCenter

        ' Create and configure the Credit labels at the bottom
        Dim creditLabel1 As New Label()
        creditLabel1.Name = "creditLabel1"
        creditLabel1.Text = "Project manager Ivy Hiner"
        creditLabel1.Font = New Font("Arial", 10, FontStyle.Regular) ' Set font size and style
        creditLabel1.ForeColor = Color.White
        creditLabel1.BackColor = Color.Gray
        creditLabel1.AutoSize = True ' Automatically adjust size based on text
        creditLabel1.TextAlign = ContentAlignment.BottomLeft

        Dim creditLabel2 As New Label()
        creditLabel2.Name = "creditLabel2"
        creditLabel2.Text = "Freshman Industrial & Systems Engineer"
        creditLabel2.Font = New Font("Arial", 10, FontStyle.Regular) ' Set font size and style
        creditLabel2.ForeColor = Color.White
        creditLabel2.BackColor = Color.Gray
        creditLabel2.AutoSize = True ' Automatically adjust size based on text
        creditLabel2.TextAlign = ContentAlignment.BottomLeft

        Dim creditLabel3 As New Label()
        creditLabel3.Name = "creditLabel3"
        creditLabel3.Text = "Lead Developer Tofarati Adewuyi"
        creditLabel3.Font = New Font("Arial", 10, FontStyle.Regular) ' Set font size and style
        creditLabel3.ForeColor = Color.White
        creditLabel3.BackColor = Color.Gray
        creditLabel3.AutoSize = True ' Automatically adjust size based on text
        creditLabel3.TextAlign = ContentAlignment.BottomRight

        Dim creditLabel4 As New Label()
        creditLabel4.Name = "creditLabel4"
        creditLabel4.Text = "Freshman Industrial & Systems Engineer"
        creditLabel4.Font = New Font("Arial", 10, FontStyle.Regular) ' Set font size and style
        creditLabel4.ForeColor = Color.White
        creditLabel4.BackColor = Color.Gray
        creditLabel4.AutoSize = True ' Automatically adjust size based on text
        creditLabel4.TextAlign = ContentAlignment.BottomRight

        ' Add the Label to the form
        Me.Controls.Add(label)
        Me.Controls.Add(creditLabel1)
        Me.Controls.Add(creditLabel2)
        Me.Controls.Add(creditLabel3)
        Me.Controls.Add(creditLabel4)

        ' Run the Label organizers initially
        CenterLabel()
        bottomLeftlabel1()
        bottomLeftlabel2()
        bottomRightlabel1()
        bottomRightlabel2()
    End Sub




    Private Sub StoreFront_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        ' Re-center the Label when the form is resized
        CenterLabel()
        bottomLeftlabel1()
        bottomLeftlabel2()
        bottomRightlabel1()
        bottomRightlabel2()

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

    Private Sub bottomLeftlabel1()
        ' Find the Label by name.
        Dim creditLabel1 As Label = Me.Controls.OfType(Of Label)().FirstOrDefault(Function(lbl) lbl.Name = "creditLabel1")

        If creditLabel1 IsNot Nothing Then
            ' Align the Label to the bottom-left of the form.
            creditLabel1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
            creditLabel1.AutoSize = True ' Important: Adjust size to content

            ' Optional: Set a margin from the left and bottom edges.
            Dim leftMargin As Integer = 10 ' Adjust as needed
            Dim bottomMargin As Integer = 40 ' Adjust as needed

            creditLabel1.Location = New Point(leftMargin, Me.ClientSize.Height - creditLabel1.Height - bottomMargin)
        End If
    End Sub

    Private Sub bottomLeftlabel2()
        ' Find the Label by name.
        Dim creditLabel2 As Label = Me.Controls.OfType(Of Label)().FirstOrDefault(Function(lbl) lbl.Name = "creditLabel2")

        If creditLabel2 IsNot Nothing Then
            ' Align the Label to the bottom-left of the form.
            creditLabel2.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
            creditLabel2.AutoSize = True ' Important: Adjust size to content

            ' Optional: Set a margin from the left and bottom edges.
            Dim leftMargin As Integer = 10 ' Adjust as needed
            Dim bottomMargin As Integer = 20 ' Adjust as needed

            creditLabel2.Location = New Point(leftMargin, Me.ClientSize.Height - creditLabel2.Height - bottomMargin)
        End If
    End Sub

    '    Private Sub bottomRightlabel1()
    ' Find the Label by name.
    '   Dim creditlabel3 As Label = Me.Controls.OfType(Of Label)().FirstOrDefault(Function(lbl) lbl.Name = "creditlabel3")
    '
    ' If creditlabel3 IsNot Nothing Then
    '        ' Align the Label to the bottom-right of the form.
    '       creditlabel3.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
    '      creditlabel3.AutoSize = True ' Important: Adjust size to content
    '
    ' Optional: Set a margin from the right and bottom edges.
    'Dim rightMargin As Integer = 10 ' Adjust as needed
    'Dim bottomMargin As Integer = 20 ' Adjust as needed
    '
    '   creditlabel3.Location = New Point(Me.ClientSize.Width - creditlabel3.Width - rightMargin, Me.ClientSize.Height - creditlabel3.Height - bottomMargin)
    'End If
    'End Sub
    '
    Private Sub bottomRightlabel1()
        ' Find the Label by name.
        Dim creditLabel3 As Label = Me.Controls.OfType(Of Label)().FirstOrDefault(Function(lbl) lbl.Name = "creditLabel3")

        If creditLabel3 IsNot Nothing Then
            ' Align the Label to the bottom-left of the form.
            creditLabel3.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
            creditLabel3.AutoSize = True ' Important: Adjust size to content

            ' Optional: Set a margin from the left and bottom edges.
            Dim leftMargin As Integer = 280 ' Adjust as needed
            Dim bottomMargin As Integer = 40 ' Adjust as needed

            creditLabel3.Location = New Point(leftMargin, Me.ClientSize.Height - creditLabel3.Height - bottomMargin)
        End If
    End Sub

    Private Sub bottomRightlabel2()
        ' Find the Label by name.
        Dim creditLabel4 As Label = Me.Controls.OfType(Of Label)().FirstOrDefault(Function(lbl) lbl.Name = "creditLabel4")

        If creditLabel4 IsNot Nothing Then
            ' Align the Label to the bottom-left of the form.
            creditLabel4.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
            creditLabel4.AutoSize = True ' Important: Adjust size to content

            ' Optional: Set a margin from the left and bottom edges.
            Dim leftMargin As Integer = 280 ' Adjust as needed
            Dim bottomMargin As Integer = 20 ' Adjust as needed

            creditLabel4.Location = New Point(leftMargin, Me.ClientSize.Height - creditLabel4.Height - bottomMargin)
        End If
    End Sub

End Class