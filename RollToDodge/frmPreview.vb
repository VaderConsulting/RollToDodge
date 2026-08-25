Public Class frmPreview

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnSelectAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectAll.Click
        rtbPreview.Focus()
        rtbPreview.SelectAll()
    End Sub

    Private Sub btnCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopy.Click
        If rtbPreview.SelectedText.Length > 0 Then
            My.Computer.Clipboard.SetText(rtbPreview.SelectedText)
        End If
    End Sub

    Private Sub btnAddEndRollText_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddEndRollText.Click
        rtbPreview.Text &= My.Settings.EndRoll
    End Sub
End Class