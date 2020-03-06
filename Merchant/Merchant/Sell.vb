Public Class Sell
    Private type As String = ""
    Private qty As Integer
    Private price As Integer
    Private totalprice As Integer
    Public Sub New(ByVal type As String)
        Me.type = type
    End Sub
    Public Sub setPrice(ByVal price As Integer)
        Me.price = price
    End Sub

    Public Sub setQty(ByVal qty As Integer)
        Me.qty = qty
    End Sub

    Public Sub compute()
        Me.totalprice = Me.price * Me.qty
    End Sub

    Public Sub Submit()
        Me.totalprice = Me.price * Me.qty
    End Sub
    Public Function getType1() As String
        Return type
    End Function
    Public Function getPrice() As Integer
        Return Me.price
    End Function

    Public Function getQty() As Integer
        Return Me.qty
    End Function

    Public Function getTotalPrice() As Integer
        Return Me.totalprice
    End Function
End Class
