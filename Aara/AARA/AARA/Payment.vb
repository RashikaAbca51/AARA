Public Class Payment

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        HomePage.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        MessageBox.Show("Transaction Sucessful")
        Invoice.Show()
    End Sub

    
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label1.Visible = True
        Upi.Visible = True
        Button4.Visible = True
    End Sub

    Private Sub Payment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Visible = False
        Upi.Visible = False
        Button4.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Card.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Upi.Text.Contains("@") Then
            MessageBox.Show(" Approve Payment from UPI to genarate invoice")
            Me.Hide()
            Invoice.Show()
        Else
            MessageBox.Show("Enter valid Upi ID")
            Upi.Text = "   "
        End If
    End Sub
End Class