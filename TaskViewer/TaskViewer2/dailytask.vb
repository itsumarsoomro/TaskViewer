Public Class dailytask
    Private Sub DTBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)



    End Sub

    Private Sub dailytask_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.DT' table. You can move, or remove it, as needed.
        Me.DTTableAdapter.Fill(Me.Database1DataSet.DT)


    End Sub

    Private Sub DTBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles DTBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.DTBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)

    End Sub
End Class