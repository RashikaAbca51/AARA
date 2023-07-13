Public Class Sugar

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        price = TextBoxPrice.Text
        pid = TextBoxPid.Text
        pname = TextBoxPname.Text
        totalPrice = TextBox1.Text
        Me.Hide()
        Lipstick.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        TextBoxPname.Text = "Smudge me not"
        TextBoxPid.Text = "1324"
        TextBoxPrice.Text = "425"
        detail.Text = "Hot Red Matte lip tint"
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        TextBoxPname.Text = "Matte Attack"
        TextBoxPid.Text = "1273"
        TextBoxPrice.Text = "729"
        detail.Text = "Nude Brown Liquid color"
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        TextBoxPname.Text = "Matte as Hell Crayon"
        TextBoxPid.Text = "7642"
        TextBoxPrice.Text = "850"
        detail.Text = "Rosy Pink 9-5 Crayon"
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        TextBoxPname.Text = "Mettle- Satin collection"
        TextBoxPid.Text = "8352"
        TextBoxPrice.Text = "989"
        detail.Text = "Cherry Blossom Glosy"
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
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBoxPname.Text = "  "
        TextBoxPid.Text = "   "
        TextBoxPrice.Text = "  "
        detail.Text = "  "
        TextBox1.Text = "  "
        TextBox2.Text = " "
    End Sub

    Private Sub Sugar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBoxPname.Text = "  "
        TextBoxPid.Text = "   "
        TextBoxPrice.Text = "    "
        detail.Text = "    "
        TextBox1.Text = "  "
    End Sub
End Class