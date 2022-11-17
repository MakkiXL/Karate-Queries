Public Class homepage
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ListAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListAllToolStripMenuItem.Click
        Me.Hide()
        MembersForm.Visible = True
    End Sub

    Private Sub FindMemberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FindMemberToolStripMenuItem.Click
        Me.Hide()
        FindMemberForm.Visible = True
    End Sub

    Private Sub AllMembersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AllMembersToolStripMenuItem.Click
        Me.Hide()
        PaymentsForm.ShowDialog()


    End Sub

    Private Sub AllPaymentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AllPaymentsToolStripMenuItem.Click
        Me.Hide()
        PaymentHistory.Visible = True
    End Sub
End Class
