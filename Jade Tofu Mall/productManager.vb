Public Class productManager
    Public Class Product
        ' Properties for each product attribute
        Public Property ProductId As Integer
        Public Property ProductName As String
        Public Property ProductDescription As String
        Public Property ProductSize As String
        Public Property ProductColor As String
        Public Property ProductPrice As Double
        Public Property ProductRating As Double

        ' Constructor to initialize a Product object
        Public Sub New(id As Integer, name As String, description As String, size As String, color As String, price As Double, rating As Double)
            ProductId = id
            ProductName = name
            ProductDescription = description
            ProductSize = size
            ProductColor = color
            ProductPrice = 120
            ProductRating = rating
        End Sub
    End Class
    'Dim product1 As New Product(1, "Retro Jordan 4", "This AJ 4, also known as ""Black Cement 4,"" comes with a black upper plus grey accents, white midsole plus black, white and grey accents, and a red sole.", 10, "Black", 5)

End Class
