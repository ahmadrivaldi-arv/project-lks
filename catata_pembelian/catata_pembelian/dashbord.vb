Public Class dashbord
    Private Sub dashbord_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Environment.Exit(1)
    End Sub

    Private Sub dashbord_Load(sender As Object, e As EventArgs) Handles Me.Load
        For Each col As DataGridViewColumn In Me.DataGridView1.Columns
            col.SortMode = DataGridViewColumnSortMode.NotSortable
        Next
        DataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect
        DataGridView1.DataSource = TampilkanData()
    End Sub

End Class