Public Class MAC

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        TextBoxPname.Text = "mini m.a.c lipstick- WHORL"
        TextBoxPid.Text = "6743"
        TextBoxPrice.Text = "1250"
        detail.Text = "Sunset Pink Stick"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        price = TextBoxPrice.Text
        pid = TextBoxPid.Text
        pname = TextBoxPname.Text
        totalPrice = TextBox1.Text
        Me.Hide()
        Lipstick.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        TextBoxPname.Text = "mini m.a.c lipstick- DOUBLE FUDGE"
        TextBoxPid.Text = "9542"
        TextBoxPrice.Text = "1950"
        detail.Text = "Belgium Choco Tint"
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        TextBoxPname.Text = "mini m.a.c lipstick- DIVA"
        TextBoxPid.Text = "1123"
        TextBoxPrice.Text = "1780"
        detail.Text = "Hot Red Matte lip tint"
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        TextBoxPname.Text = "mini m.a.c lipstick- MEHR"
        TextBoxPid.Text = "7649"
        TextBoxPrice.Text = "1980"
        detail.Text = "Rusty hue Tint"
    End Sub

    Private Sub MAC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBoxPname.Text = "  "
        TextBoxPid.Text = "   "
        TextBoxPrice.Text = "    "
        detail.Text = "    "
        TextBox1.Text = "  "
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
End Class