Public Class Fit_me

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Me.Hide()
        Cream.Show()
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
        TextBoxPname.Text = "Liquid Foundation "
        TextBoxPid.Text = "7642"
        TextBoxPrice.Text = "692"
        detail.Text = "Aqua base Walnut SH"
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        TextBoxPname.Text = "Matte primer "
        TextBoxPid.Text = "8674"
        TextBoxPrice.Text = "499"
        detail.Text = "Pore Eraser with Vit C"
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        TextBoxPname.Text = "Tinted moisturizer "
        TextBoxPid.Text = "3097"
        TextBoxPrice.Text = "799"
        detail.Text = "Beidge Tint Nourshing Creme"
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        TextBoxPname.Text = "Cc cream"
        TextBoxPid.Text = "7632"
        TextBoxPrice.Text = "490"
        detail.Text = "Daily-wear color-changing "
    End Sub

    Private Sub Fit_me_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class