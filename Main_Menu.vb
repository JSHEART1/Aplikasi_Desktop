Public Class Main_Menu
    Private Sub MainMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MainMenuToolStripMenuItem.Click
        Monitoring.MdiParent = Me
        Monitoring.Show()
    End Sub
    Private Sub ReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportToolStripMenuItem.Click
        Report.MdiParent = Me
        Report.Show()
    End Sub
End Class