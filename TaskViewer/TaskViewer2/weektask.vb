Imports System.Data
Imports System.Data.SqlClient

Public Class weektask
    'Naming the variables
    Dim myconnection As SqlConnection

    Dim mycommand As SqlCommand

    Dim dr As SqlDataReader

    Dim dr1 As SqlDataReader

    Dim ra As Integer
    Private Sub WTBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles WTBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.WTBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)

    End Sub

    Private Sub weektask_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.WT' table. You can move, or remove it, as needed.
        Me.WTTableAdapter.Fill(Me.Database1DataSet.WT)

    End Sub

    Private Sub Guna2CircleButton1_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton1.Click
        'Empty textboxes error

        If TextBox1.Text.Length <= 0 Then
            MessageBox.Show("Please enter Time!")
        ElseIf TextBox2.Text.Length <= 0 Then
            MessageBox.Show("Please enter your Weekly Task Details!")
        ElseIf TextBox3.Text.Length <= 0 Then
            MessageBox.Show("Please enter your Day!")

        End If

        'Connection with databse
        myconnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\TaskViewer2\Database1.mdf;Integrated Security=True")

        myconnection.Open()

        'Insert query into database

        mycommand = New SqlCommand("insert into WT([Time],[Day],[TaskDetails]) values ('" & TextBox1.Text & "','" & TextBox3.Text & "', '" & TextBox2.Text & "')", myconnection)

        mycommand.ExecuteNonQuery()

        MessageBox.Show("Sucessfully Added" & ra)

        myconnection.Close()
    End Sub

    'Refresh button

    Private Sub Guna2CircleButton2_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton2.Click
        Timer1.Enabled = True


    End Sub

    Private Sub Guna2CircleButton3_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton3.Click
        Timer1.Enabled = False


    End Sub



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        WTDataGridView.Refresh()
    End Sub
End Class