Public Class Adash
    Private Sub AdminBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Adash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.Register' table. You can move, or remove it, as needed.
        Me.RegisterTableAdapter.Fill(Me.Database1DataSet.Register)

    End Sub

    Private Sub RegisterBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles RegisterBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.RegisterBindingSource.EndEdit()
        Me.TableAdapterManager1.UpdateAll(Me.Database1DataSet)

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Home.Show()
        Me.Hide()

    End Sub
End Class