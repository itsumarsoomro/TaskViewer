Imports System.Data
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class Registration
    'Naming the variables
    Dim myconnection As SqlConnection

    Dim mycommand As SqlCommand

    Dim dr As SqlDataReader

    Dim dr1 As SqlDataReader

    Dim ra As Integer
    Private Sub Guna2CustomGradientPanel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        Panel1.BackColor = Color.FromArgb(100, 255, 192, 128)
    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click

        'Dim email As String = TextBox4.Text
        'If Len(email) = 0 Then
        '    MessageBox.Show("INVALID Email")
        'Else
        '    Dim pattern As String = "^[a-zA-Z0-9]+@[a-zA-Z0-9]+\.[a-zA-Z0-9]+$"
        '    Dim emailAddressMatch As Match = Regex.Match(email, pattern)
        '    If emailAddressMatch.ToString = email Then
        '        MessageBox.Show("VALID Email")
        '    Else
        '        MessageBox.Show("INVALID Email")
        '    End If
        'End If

        'Empty textbox error

        If TextBox1.Text.Length <= 0 Then
            MessageBox.Show("Please enter your Full Name!")
        ElseIf TextBox2.Text.Length <= 0 Then
            MessageBox.Show("Please enter your User Name!")
        ElseIf TextBox4.Text.Length <= 0 Then
            MessageBox.Show("Please enter your Email!")
        ElseIf TextBox3.Text.Length <= 0 Then
            MessageBox.Show("Please enter your Password!")
        End If

        'Connection with databse
        myconnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\TaskViewer2\Database1.mdf;Integrated Security=True")

        myconnection.Open()

        'Insert query
        mycommand = New SqlCommand("insert into Register([Username],[Fullname],[Email],[Password]) values ('" & TextBox2.Text & "','" & TextBox1.Text & "','" & TextBox4.Text & "','" & TextBox3.Text & "')", myconnection)

        mycommand.ExecuteNonQuery()

        MessageBox.Show("Sucessfully Registered" & ra)

        myconnection.Close()

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        'Back Button
        Home.Show()
        Me.Hide()

    End Sub
End Class