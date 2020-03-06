Public Class Form1
    Public sell As Sell

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        Me.sell = New Sell((type.Text))
        Me.sell.setPrice(price.Text)
        Me.sell.setQty(qty.Text)
        Me.sell.compute()
    End Sub

    Private Sub show_Click(sender As Object, e As EventArgs) Handles show.Click
        MsgBox("Type: " & Me.sell.getType1 & vbNewLine &
               "Quantity: " & Me.sell.getQty & vbNewLine &
               "Price: " & Me.sell.getPrice & vbNewLine &
               "Total Price: " & Me.sell.getTotalPrice)
    End Sub
End Class
