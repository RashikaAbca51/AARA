Public Class Dior

    
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Me.Hide()
        EyeMakeUp.Show()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Integer
        a = Val(TextBoxPrice.Text) * Val(TextBox2.Text)
        TextBox1.Text = a
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        price = TextBoxPrice.Text
        pid = TextBoxPid.Text
        pname = TextBoxPname.Text
        totalPrice = TextBox1.Text
        Me.Hide()
        Payment.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        TextBoxPname.Text = "Dior Bckstage "
        TextBoxPid.Text = "7648"
        TextBoxPrice.Text = "7089"
        detail.Text = "Dramatic Coal Kohl "
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        TextBoxPname.Text = "Dior couture"
        TextBoxPid.Text = "4876"
        TextBoxPrice.Text = "1120"
        detail.Text = "Gel Eye-liner Blue "
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        TextBoxPname.Text = "Dior eyshadow Pallete "
        TextBoxPid.Text = "4632"
        TextBoxPrice.Text = "1347"
        detail.Text = "Patel 12 shades eyeshadow"
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        TextBoxPname.Text = "Dior Ecrin couture "
        TextBoxPid.Text = "627"
        TextBoxPrice.Text = "1347"
        detail.Text = "Bright Blue Kohl "
    End Sub
End Class