Public Class history
    Private Sub history_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.WT' table. You can move, or remove it, as needed.
        Me.WTTableAdapter.Fill(Me.Database1DataSet.WT)
        'TODO: This line of code loads data into the 'Database1DataSet.DT' table. You can move, or remove it, as needed.
        Me.DTTableAdapter.Fill(Me.Database1DataSet.DT)


    End Sub

    Private Sub DTBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.DTBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)

    End Sub
End Class