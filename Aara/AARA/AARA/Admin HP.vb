Imports System.Data.SqlClient
Imports System .Data 
Public Class Admin_HP

    Private Sub ButtonBack_Click(sender As Object, e As EventArgs) Handles ButtonBack.Click
        Me.Hide()
        Form4.Show()
    End Sub

    Private Sub ButtonMode_Click(sender As Object, e As EventArgs) Handles mode.Click
        Me.Hide()
        HomePage.Show()
        'AARADataSet.Admindetails ' table. You can move, or remove it, as needed.
        Me.AdmindetailsTableAdapter.Fill(Me.AARADataSet.Admindetails)
        prView1.Visible = False
        clView2.Visible = False
        psearch.Visible = False
        pinsert.Visible = False
        pdetail.Visible = False
        pupdate.Visible = False
        cinsert.Visible = False
        cdelet.Visible = False
        csearch.Visible = False
        cupdate.Visible = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles pd.Click
        prView1.Visible = True
        pinsert.Visible = True
        pdetail.Visible = True
        psearch.Visible = True
        pupdate.Visible = True
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cd.Click
        clView2.Visible = True
        ButtonBack.Visible = True
        cinsert.Visible = True
        cdelet.Visible = True
        csearch.Visible = True
        cupdate.Visible = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles pinsert.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        con.ConnectionString = "Data Source=LAPTOP-I953B1FJ;Initial Catalog=AARA;Integrated Security=True"
        con.Open()
        cmd = New SqlCommand("INSERT INTO prlist values('" & pname.Text & "','" & price.Text & "','" & pid.Text & "','" & detail.Text & "')", con)
        cmd.ExecuteNonQuery()
        MsgBox("Successfully added", MsgBoxStyle.Information, "Success")
        con.Close()
        BindDataProduct()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles cinsert.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        con.ConnectionString = "Data Source=LAPTOP-I953B1FJ;Initial Catalog=AARA;Integrated Security=True"
        con.Open()
        cmd = New SqlCommand("INSERT INTO Admindetails values('" & TextBoxCid.Text & "','" & TextBoxCName.Text & "','" & TextBoxCPhone.Text & "')", con)
        cmd.ExecuteNonQuery()
        MsgBox("Successfully added", MsgBoxStyle.Information, "Success")
        con.Close()
        BindDataCustomer()
    End Sub

    Private Sub BindDataProduct()
        Dim query As String = "SELECT * FROM  prlist"
        Dim conn As SqlConnection = New SqlConnection("Data Source=LAPTOP-I953B1FJ;Initial Catalog=AARA;Integrated Security=True")
        Dim cmd As SqlCommand = New SqlCommand(query, conn)
        Dim da As New SqlDataAdapter()
        da.SelectCommand = cmd
        Dim dt As New DataTable()
        da.Fill(dt)
        prView1.DataSource = dt

    End Sub

    Private Sub BindDataCustomer()
        Dim query As String = "Select * from  Admindetails"
        Using conn As SqlConnection = New SqlConnection("Data Source=LAPTOP-I953B1FJ;Initial Catalog=AARA;Integrated Security=True")
            Using cmd As SqlCommand = New SqlCommand(query, conn)
                Using da As New SqlDataAdapter()
                    da.SelectCommand = cmd
                    Using dt As New DataTable()
                        da.Fill(dt)
                        clView2.DataSource = dt
                    End Using
                End Using
            End Using
        End Using

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles cdelet.Click
        'Retrieve the connection string for the SQL Server database
        Dim connectionString As String = "Data Source=LAPTOP-I953B1FJ;Initial Catalog=AARA;Integrated Security=True"

        'Get the selected row from the DataGridView
        Dim selectedRow As DataGridViewRow = clView2.CurrentRow

        'Retrieve the TITLE of the selected row from the first column of the DataGridView
        Dim TITLE As String = selectedRow.Cells(0).Value.ToString()

        'Create a SqlConnection object using the connection string
        Using connection As New SqlConnection(connectionString)
            'Open the database connection
            connection.Open()

            'Create a SqlCommand object to execute the DELETE statement
            Dim command As New SqlCommand("DELETE FROM postediting WHERE TITLE = @TITLE", connection)

            'Add the TITLE parameter to the SqlCommand object
            command.Parameters.AddWithValue("@TITLE", TITLE)

            'Execute the DELETE statement
            command.ExecuteNonQuery()

            'Close the database connection
            connection.Close()
        End Using

        'Remove the selected row from the DataGridView
        clView2.Rows.Remove(selectedRow)

        'Display a message to the user
        MessageBox.Show("Record deleted successfully.")


    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles csearch.Click
        clView2.Refresh()
        If TextBoxCid.Text <> "" Then
            Dim query As String = "Select * from  Admindetails WHERE Id = @id"
            Using conn As SqlConnection = New SqlConnection("Data Source=LAPTOP-I953B1FJ;Initial Catalog=AARA;Integrated Security=True")
                Using cmd As SqlCommand = New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", TextBoxCid.Text)
                    Using da As New SqlDataAdapter()
                        da.SelectCommand = cmd
                        Using dt As New DataTable()
                            da.Fill(dt)
                            clView2.DataSource = dt
                        End Using
                    End Using
                End Using
            End Using

        Else
            BindDataCustomer()
        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles cupdate.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        con.ConnectionString = "Data Source=LAPTOP-I953B1FJ;Initial Catalog=AARA;Integrated Security=True"
        con.Open()
        cmd = New SqlCommand("UPDATE Admindetails SET Name = @name, Phone = @phone WHERE Id = @id", con)
        cmd.Parameters.AddWithValue("@name", TextBoxCName.Text)
        cmd.Parameters.AddWithValue("@phone", TextBoxCPhone.Text)
        cmd.Parameters.AddWithValue("@id", TextBoxCid.Text)

        cmd.ExecuteNonQuery()
        MsgBox("Successfully Updated", MsgBoxStyle.Information, "Success")
        con.Close()
        BindDataCustomer()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles pdetail.Click

    End Sub

    Private Sub Admin_HP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BindDataProduct()
        BindDataCustomer()
    End Sub

    Private Sub psearch_Click(sender As Object, e As EventArgs) Handles psearch.Click
        prView1.Refresh()
        If pid.Text <> "" Then
            Dim query As String = "SELECT * FROM  prlist WHERE ProductId = @id"
            Using conn As SqlConnection = New SqlConnection("Data Source=LAPTOP-I953B1FJ;Initial Catalog=AARA;Integrated Security=True")
                Using cmd As SqlCommand = New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", pid.Text)
                    Using da As New SqlDataAdapter()
                        da.SelectCommand = cmd
                        Using dt As New DataTable()
                            da.Fill(dt)
                            prView1.DataSource = dt
                        End Using
                    End Using
                End Using
            End Using

        Else
            BindDataProduct()
        End If
    End Sub

    Private Sub prView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles prView1.CellContentClick
        Dim dataRow As DataGridViewRow = prView1.Rows(e.RowIndex)
        pname.Text = dataRow.Cells(0).Value.ToString()
        price.Text = dataRow.Cells(1).Value.ToString()
        pid.Text = dataRow.Cells(2).Value.ToString()





















































        detail.Text = dataRow.Cells(3).Value.ToString()

    End Sub

    Private Sub pupdate_Click(sender As Object, e As EventArgs) Handles pupdate.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        con.ConnectionString = "Data Source=LAPTOP-I953B1FJ;Initial Catalog=AARA;Integrated Security=True"
        con.Open()
        cmd = New SqlCommand("UPDATE prlist SET ProductName = @pname, Price = @price, Description = @detail WHERE ProductId = @pid", con)
        cmd.Parameters.AddWithValue("@pname", pname.Text)
        cmd.Parameters.AddWithValue("@price", price.Text)
        cmd.Parameters.AddWithValue("@detail", detail.Text)
        cmd.Parameters.AddWithValue("@pid", pid.Text)

        cmd.ExecuteNonQuery()
        MsgBox("Successfully Updated", MsgBoxStyle.Information, "Success")
        con.Close()
        BindDataProduct()
    End Sub

    Private Sub clView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles clView2.CellContentClick
        Dim dataRow As DataGridViewRow = clView2.Rows(e.RowIndex)
        TextBoxCName.Text = dataRow.Cells(1).Value.ToString()
        TextBoxCid.Text = dataRow.Cells(0).Value.ToString()
        TextBoxCPhone.Text = dataRow.Cells(2).Value.ToString()
    End Sub

    Private Sub cno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxCPhone.KeyPress

        Dim num As String = "1234567890"
        If Not (Asc(e.KeyChar) = 8) Then
            If Not num.Contains(e.KeyChar.ToString) Then
                MessageBox.Show("please enter a number")
                e.KeyChar = ChrW(0)
                e.Handled = True

                If TextBoxCPhone.Text.Length >= 10 Then
                    If e.KeyChar <> ControlChars.Back Then
                        e.Handled = True
                        MessageBox.Show("Please enter a valid Phone Number!")

                    End If
                End If
            End If
        End If
    End Sub
End Class