Public Class Invoice


    Private Sub Invoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim validPrefixes() As String = {"9", "8", "7", "6"}
        Dim startsWithValidPrefix As Boolean = False

        For Each prefix As String In validPrefixes
            If phno.Text.Trim().StartsWith(prefix) Then
                startsWithValidPrefix = True
                Exit For
            End If
        Next

        If Not startsWithValidPrefix Then
            MessageBox.Show("Please enter a valid mobile number .", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If phno.Text.Trim().Replace("0", "") = "" Then
            MessageBox.Show("Please enter a valid mobile number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        bill.Clear()

        bill.Text += "*******************************************************************" + vbNewLine

        bill.Text += "******************             YOUR BILL            ****************" + vbNewLine

        bill.Text += "*******************************************************************" + vbNewLine



        bill.Text += "          Date : " + DateTime.Now + vbNewLine

        bill.Text += "          Name : " + cname.Text + vbNewLine

        bill.Text += "          Phone no : " + phno.Text + vbNewLine



        bill.Text += "          Product : " + pname + vbNewLine

        bill.Text += "          Price : " + price + vbNewLine

        bill.Text += "          Total Amount : " + totalPrice + vbNewLine
        bill.Text += "Received, Thank you!.Do shop more, thanks!Thanks a lot." + vbNewLine
        bill.Text += "####################################"
        bill.Text += "####################################"


    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString(bill.Text, New Font("Times New Roman", 15, FontStyle.Bold), Brushes.Black, New Point(10, 10))
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PrintPreviewDialog1.Document = PrintDocument1

        PrintPreviewDialog1.ShowDialog()
    End Sub
  
End Class