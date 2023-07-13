Imports System.Data.SqlClient
Imports System.Data


Public Class Form5

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form4.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If email.Text.Contains("@") And email.Text.Contains(".") Then
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            con.ConnectionString = "Data Source=LAPTOP-I953B1FJ;Initial Catalog=AARA;Integrated Security=True"
            con.Open()
            cmd = New SqlCommand("INSERT INTO sinup VALUES('" & fname.Text & "','" & lname.Text & "','" & email.Text & "','" & Username.Text & "','" & Password.Text & "')", con)
            cmd.ExecuteNonQuery()
            MsgBox("Successfully Registered", MsgBoxStyle.Information, "Success")
            Me.Hide()
            Form4.Show()
        Else
            MessageBox.Show("Enter valid e-mail ID")
        End If
    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Password.UseSystemPasswordChar = False
        Else
            Password.UseSystemPasswordChar = True

        End If
    End Sub
End Class