Public Class Lakme
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        price = TextBoxPrice.Text
        pid = TextBoxPid.Text
        pname = TextBoxPname.Text
        totalPrice = TextBox1.Text
        Me.Hide()
        Lipstick.Show()
    End Sub

   
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        TextBoxPname.Text = "Cushion Matte"
        TextBoxPid.Text = "5673"
        TextBoxPrice.Text = "560"
        detail.Text = "Cherry Blossom Glosy"
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        TextBoxPname.Text = "Primer + Matte"
        TextBoxPid.Text = "7640"
        TextBoxPrice.Text = "780"
        detail.Text = "Walnut Haze Tint"
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        TextBoxPname.Text = "Forever Matte"
        TextBoxPid.Text = "4762"
        TextBoxPrice.Text = "800"
        detail.Text = "Brick Red Liquid Matte"
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        TextBoxPname.Text = "Absolute plush matte crayon"
        TextBoxPid.Text = "9864"
        TextBoxPrice.Text = "999"
        detail.Text = "Nude Pink Crayon"
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

    Private Sub Lakme_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBoxPname.Text = "  "
        TextBoxPid.Text = "   "
        TextBoxPrice.Text = "    "
        detail.Text = "    "
        TextBox1.Text = "  "
    End Sub
End Class