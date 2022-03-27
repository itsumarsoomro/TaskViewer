Imports System.Data.SqlClient

Public Class Alogin
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Empty error for textbox
        If TextBox1.Text.Length <= 0 Then
            MessageBox.Show("Please enter Username!")
        ElseIf TextBox2.Text.Length <= 0 Then
            MessageBox.Show("Please enter Password!")
        End If

        'Connection with database
        Dim str As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\TaskViewer2\Database1.mdf;Integrated Security=True"
        Dim sql As String = "select count(*) from Admin where Username=@Username and Password=@Password"

        Using Conn As New SqlConnection(str)
            Using cmd As New SqlCommand(sql, Conn)
                Conn.Open()
                cmd.Parameters.AddWithValue("@Username", TextBox1.Text)
                cmd.Parameters.AddWithValue("@Password", TextBox2.Text)
                Dim value = cmd.ExecuteScalar()
                If (value > 0) Then
                    MessageBox.Show("Login sucessfully!")
                    Adash.Show()
                    Me.Hide()

                Else

                    MessageBox.Show("Login Failed")



                End If
            End Using
        End Using
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Home.Show()
        Me.Hide()

    End Sub
End Class