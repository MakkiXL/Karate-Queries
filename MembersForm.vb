Public Class MembersForm
    Private Sub FillToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.MembersTableAdapter.Fill(Me.KarateDataSet.Members)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub mainform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'KarateDataSet.Members' table. You can move, or remove it, as needed.
        Me.MembersTableAdapter.Fill(Me.KarateDataSet.Members)

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Dim day As Date = DateTimePicker1.Value
        day = day.AddDays(-1)
        DataGridView1.DataSource = MembersBindingSource
        Me.MembersTableAdapter.DateJoinedBefore(Me.KarateDataSet.Members, day)

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Dim day As Date = DateTimePicker1.Value
        day = day.AddDays(-1)
        DataGridView1.DataSource = MembersBindingSource1
        Me.MembersTableAdapter.DateJoinedAfter(Me.KarateDataSet.Members, day)

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Hide()
        homepage.Visible = True
    End Sub
End Class