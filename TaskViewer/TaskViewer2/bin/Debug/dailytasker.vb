Imports System.Data
Imports System.Data.SqlClient

Public Class dailytasker
    Dim myconnection As SqlConnection

    Dim mycommand As SqlCommand

    Dim dr As SqlDataReader

    Dim dr1 As SqlDataReader

    Dim ra As Integer
    Private Sub DTBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.DT' table. You can move, or remove it, as needed.
        Me.DTTableAdapter.Fill(Me.Database1DataSet.DT)


    End Sub

    Private Sub DTBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles DTBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.DTBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)

    End Sub

    Private Sub Guna2CircleButton1_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton1.Click
        If TextBox1.Text.Length <= 0 Then
            MessageBox.Show("Please enter Time!")
        ElseIf TextBox2.Text.Length <= 0 Then
            MessageBox.Show("Please enter your Daily Task Details!")

        End If

        myconnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\TaskViewer2\Database1.mdf;Integrated Security=True")

        myconnection.Open()

        mycommand = New SqlCommand("insert into DT([Time],[TaskDetails]) values ('" & TextBox1.Text & "','" & TextBox2.Text & "')", myconnection)

        mycommand.ExecuteNonQuery()

        MessageBox.Show("Sucessfully Added" & ra)

        myconnection.Close()
    End Sub
End Class