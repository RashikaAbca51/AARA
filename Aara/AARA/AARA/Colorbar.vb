Public Class Colorbar

    Private Sub Button9_Click(sender As Object, e As EventArgs)
        Me.Hide()
        EyeMakeUp.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        price = TextBoxPrice.Text
        pid = TextBoxPid.Text
        pname = TextBoxPname.Text
        totalPrice = TextBox1.Text
        Me.Hide()
        Payment.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Integer
        a = Val(TextBoxPrice.Text) * Val(TextBox2.Text)
        TextBox1.Text = a
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        TextBoxPname.Text = "Hook me up "
        TextBoxPid.Text = "7659"
        TextBoxPrice.Text = "528"
        detail.Text = "Raven Black Kajal"
    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click
        TextBoxPname.Text = "Bewitchin"
        TextBoxPid.Text = "6590"
        TextBoxPrice.Text = "876"
        detail.Text = "Exotic Blues Kajal"
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        TextBoxPname.Text = "COLOR BAR X Jacquelline "
        TextBoxPid.Text = "5490"
        TextBoxPrice.Text = "905"
        detail.Text = "Long stay Mascara"
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        TextBoxPname.Text = "12 nude eyeshadow  "
        TextBoxPid.Text = "2890"
        TextBoxPrice.Text = "1739"
        detail.Text = "Patel Eye shadow Pallet"
    End Sub

    Private Sub Button9_Click_1(sender As Object, e As EventArgs) Handles Button9.Click
        Me.Hide()
        EyeMakeUp.Show()
    End Sub
End Class