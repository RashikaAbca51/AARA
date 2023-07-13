Public Class mamaearth

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Me.Hide()
        Compact.Show()
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
        TextBoxPname.Text = "Glow- almond glow  "
        TextBoxPid.Text = "3312"
        TextBoxPrice.Text = "497"
        detail.Text = " oil control Compact with spf 30  "
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        TextBoxPname.Text = "Glow - nude glow "
        TextBoxPid.Text = "3127"
        TextBoxPrice.Text = "580"
        detail.Text = " oil control Compact with spf 30 "
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        TextBoxPname.Text = "Glow  loose powder with vit c "
        TextBoxPid.Text = "9437"
        TextBoxPrice.Text = "499"
        detail.Text = "mattifying- peanut shade"
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        TextBoxPname.Text = "Glow - ivory glow "
        TextBoxPid.Text = "3876"
        TextBoxPrice.Text = "540"
        detail.Text = "oil control Compact with spf 30"
    End Sub

    Private Sub mamaearth_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBoxPname.Text = "  "
        TextBoxPid.Text = "   "
        TextBoxPrice.Text = "    "
        detail.Text = "    "
        TextBox1.Text = "  "
    End Sub
End Class