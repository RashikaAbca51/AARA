Imports System.Data.SqlClient
Imports System.Data

Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Username.Text.Length <= 0 Then
            MessageBox.Show("Please enter USERNAME!")
        ElseIf Password.Text.Length <= 0 Then
            MessageBox.Show("Please enter PASSWORD!")
        End If
        If (Username.Text = "Rashika" And Password.Text = "21bcac51") Then
            MessageBox.Show("You have logged in as Admin")
            Me.Hide()
            Admin_HP.Show()

        ElseIf (Username.Text = "Amrutha" And Password.Text = "21bcac10") Then
            MessageBox.Show("You have logged in as Admin")
            Me.Hide()
            Admin_HP.Show()

        Else
            Dim str As String = "Data Source=LAPTOP-I953B1FJ;Initial Catalog=AARA;Integrated Security=True"
            Dim sql As String = "select count(*) from sinup where username=@Username and password=@Password"
            Using Conn As New SqlConnection(str)
                Using cmd As New SqlCommand(sql, Conn)
                    Conn.Open()
                    cmd.Parameters.AddWithValue("@Username", Username.Text)
                    cmd.Parameters.AddWithValue("@Password", Password.Text)
                    Dim value = cmd.ExecuteScalar()
                    If value > 0 Then
                        MessageBox.Show("Login sucessfully!")

                        HomePage.Show()
                        Me.Hide()
                    Else
                        MessageBox.Show("Invalid login please check")
                        Username.Clear()
                        Password.Clear()

                    End If

                End Using

            End Using
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Password.UseSystemPasswordChar = False
        Else
            Password.UseSystemPasswordChar = True

        End If
    End Sub

    Private Sub Register_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Register.LinkClicked
        Me.Hide()
        Form5.Show()
    End Sub
End Class