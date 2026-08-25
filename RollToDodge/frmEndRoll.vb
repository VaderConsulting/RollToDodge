Public Class frmEndRoll

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnSelectAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectAll.Click
        txtEndRoll.Focus()
        txtEndRoll.SelectAll()
    End Sub

    Private Sub btnCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopy.Click
        If txtEndRoll.SelectedText.Length > 0 Then
            My.Computer.Clipboard.SetText(txtEndRoll.SelectedText)
        End If
    End Sub

    Private Sub frmEndRoll_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        My.Settings.EndRoll = txtEndRoll.Text
        My.Settings.Save()
    End Sub

    Private Sub frmEndRoll_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        My.Settings.Reload()
        txtEndRoll.Text = My.Settings.EndRoll
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtEndRoll.Clear()
    End Sub
End Class