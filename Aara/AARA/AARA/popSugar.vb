Public Class popSugar

    Private Sub Button9_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Compact.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Payment.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Integer
        a = Val(TextBoxPrice.Text) * Val(TextBox2.Text)
        TextBox1.Text = a
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        TextBoxPname.Text = "Sugar longwear compact "
        TextBoxPid.Text = "5097"
        TextBoxPrice.Text = "249"
        detail.Text = "Daily-wear coral SH"
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        TextBoxPname.Text = "Sugar Banana powder "
        TextBoxPid.Text = "5479"
        TextBoxPrice.Text = "492"
        detail.Text = "Pearly white SH"
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        TextBoxPname.Text = "Sugar mattifying powder chocochino "
        TextBoxPid.Text = "4328"
        TextBoxPrice.Text = "560"
        detail.Text = "Caramel SH "
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        TextBoxPname.Text = "Sugar set the tone powder capaccino "
        TextBoxPid.Text = "5096"
        TextBoxPrice.Text = "549"
        detail.Text = "Caffine Bliss SH"
    End Sub

    Private Sub Button9_Click_1(sender As Object, e As EventArgs) Handles Button9.Click
        Me.Hide()
        Compact.Show()
    End Sub

    Private Sub popSugar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBoxPname.Text = "  "
        TextBoxPid.Text = "   "
        TextBoxPrice.Text = "    "
        detail.Text = "    "
        TextBox1.Text = "  "
    End Sub
End Class