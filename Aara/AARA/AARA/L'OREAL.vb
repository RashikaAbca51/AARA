Public Class LOREAL

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Me.Hide()
        Cream.Show()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        TextBoxPname.Text = "Skin perfect "
        TextBoxPid.Text = "8764"
        TextBoxPrice.Text = "585"
        detail.Text = "Spot Correction Cream"
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        TextBoxPname.Text = "Revitalift"
        TextBoxPid.Text = "7530"
        TextBoxPrice.Text = "750"
        detail.Text = "Daily wear BB cream"
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        TextBoxPname.Text = "Glowing cream night "
        TextBoxPid.Text = "9853"
        TextBoxPrice.Text = "695"
        detail.Text = "Anti-Aging Night Cream"
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        TextBoxPname.Text = "Loreal midnight cream "
        TextBoxPid.Text = "4075"
        TextBoxPrice.Text = "2275"
        detail.Text = "Under-eye radiance cream"
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
End Class