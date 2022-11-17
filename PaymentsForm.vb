Public Class PaymentsForm
    Private Sub PaymentsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AllPaymentsDataset.Payments' table. You can move, or remove it, as needed.
        Me.PaymentsTableAdapter.Fill(Me.AllPaymentsDataset.Payments)

    End Sub

    Private Sub PaymentsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PaymentsBindingNavigatorSaveItem.Click
        'tried using a update query to save changes could not figure it out 
        Dim Amount As Decimal = CDec(AmountTextBox.Text)
        Dim ID As Short = CShort(IDTextBox.Text)
        Me.PaymentsTableAdapter.UpdateQuery(Amount, ID)

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Hide()
        homepage.Visible = True

    End Sub


End Class