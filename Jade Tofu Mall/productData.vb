Imports Jade_Tofu_Mall.productManager

' In a Module or a Class that manages products



' In a Module that manages products
Public Module productData
    Public ProductDictionary As New Dictionary(Of Integer, Product)()

    Sub InitializeProducts()
        Dim product1 As New Product(1, "Retro Jordan 4", "This AJ 4, also known as ""Black Cement 4,"" comes with a black upper plus grey accents, white midsole plus black, white and grey accents, and a red sole.", 10, "Black", 120, 5)
        Dim product2 As New Product(205, "Jeans", "...", "32", "Indigo", 0, 4.5)
        ' Add the created objects to the dictionary
        ProductDictionary.Add(product1.ProductId, product1)
        ProductDictionary.Add(product2.ProductId, product2)
        ' ... add more products here
    End Sub

End Module

' To access a product by its ID:
' Dim myProduct As Product = ProductData.ProductDictionary.Item(101)
' If myProduct IsNot Nothing Then
'     Console.WriteLine(myProduct.ProductName)
' End If



















' To access a product by its ID:
' Dim myProduct As Product = ProductData.ProductDictionary.Item(101)
' If myProduct IsNot Nothing Then
'     Console.WriteLine(myProduct.ProductName)
' End If