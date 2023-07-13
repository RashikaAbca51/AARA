Public Class Revlon

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Me.Hide()
        Cream.Show()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        TextBoxPname.Text = "Revlon Touch and glow "
        TextBoxPid.Text = "6539"
        TextBoxPrice.Text = "553"
        detail.Text = ""
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

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        TextBoxPname.Text = "Revlon Colorstay whipped "
        TextBoxPid.Text = "9759"
        TextBoxPrice.Text = "386"
        detail.Text = ""
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        TextBoxPname.Text = "Revlon Touch and glow Adv "
        TextBoxPid.Text = "2076"
        TextBoxPrice.Text = "386"
        detail.Text = "Moisturizing powder"
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        TextBoxPname.Text = "Revlon  Age defying "
        TextBoxPid.Text = "9872"
        TextBoxPrice.Text = ""
        detail.Text = "1789"
    End Sub

    Private Sub Revlon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBoxPname.Text = "  "
        TextBoxPid.Text = "   "
        TextBoxPrice.Text = "    "
        detail.Text = "    "
        TextBox1.Text = "  "
    End Sub
End Class