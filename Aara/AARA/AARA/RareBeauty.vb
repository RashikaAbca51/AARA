Public Class RareBeauty

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Me.Hide()
        Compact.Show()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        TextBoxPname.Text = "Shell compact pd"
        TextBoxPid.Text = "4311"
        TextBoxPrice.Text = "3150"
        detail.Text = "Dusk Compact SH-897"

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Integer
        a = Val(TextBoxPrice.Text) * Val(TextBox2.Text)
        TextBox1.Text = a
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        TextBoxPname.Text = "Coral compact pd"
        TextBoxPid.Text = "4312"
        TextBoxPrice.Text = "2950"
        detail.Text = "Wheatish Shade Compact SH-898"
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        TextBoxPname.Text = "Pearl compact pd"
        TextBoxPid.Text = "4321"
        TextBoxPrice.Text = "2845"
        detail.Text = "White Shade Compact SH-897"
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        TextBoxPname.Text = "Coco compact pd"
        TextBoxPid.Text = "4421"
        TextBoxPrice.Text = "3015"
        detail.Text = "Choco Shade Compact SH-897"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        price = TextBoxPrice.Text
        pid = TextBoxPid.Text
        pname = TextBoxPname.Text
        totalPrice = TextBox1.Text
        Me.Hide()
        Payment.Show()
    End Sub

    Private Sub RareBeauty_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBoxPname.Text = "  "
        TextBoxPid.Text = "   "
        TextBoxPrice.Text = "    "
        detail.Text = "    "
        TextBox1.Text = "  "
    End Sub

End Class