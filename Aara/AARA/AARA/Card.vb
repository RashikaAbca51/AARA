
Public Class Card

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Payment.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not IsNumeric(cno.Text) Or cno.Text.Length <> 16 Then
            MessageBox.Show("cno shoud be 16 number")
            Exit Sub
        End If
        Me.Hide()
        Invoice.Show()
    End Sub

    Private Sub Card_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cno.KeyPress


        Dim num As String = "1234567890"
        If Not (Asc(e.KeyChar) = 8) Then
            If Not num.Contains(e.KeyChar.ToString) Then
                MessageBox.Show("please enter a number")
                e.KeyChar = ChrW(0)
                e.Handled = True

                If cno.Text.Length >= 10 Then
                    If e.KeyChar <> ControlChars.Back Then
                        e.Handled = True
                        MessageBox.Show("Please enter a valid Phone Number!")

                    End If
                End If
            End If
        End If
    End Sub


    Private Sub cno_TextChanged(sender As Object, e As EventArgs) Handles cno.TextChanged

    End Sub
    Private Sub cvv_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cvv.KeyPress

        Dim num As String = "1234567890"
        If Not (Asc(e.KeyChar) = 8) Then
            If Not num.Contains(e.KeyChar.ToString) Then
                MessageBox.Show("please enter a number")
                e.KeyChar = ChrW(0)
                e.Handled = True

                If cvv.Text.Length = 3 Then
                    If e.KeyChar <> ControlChars.Back Then
                        e.Handled = True
                        MessageBox.Show("Please enter a valid Number!")

                    End If
                End If
            End If
        End If
    End Sub
End Class