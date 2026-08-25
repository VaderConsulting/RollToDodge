<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPreview
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.rtbPreview = New System.Windows.Forms.RichTextBox()
        Me.btnSelectAll = New System.Windows.Forms.Button()
        Me.btnCopy = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnAddEndRollText = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'rtbPreview
        '
        Me.rtbPreview.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtbPreview.Location = New System.Drawing.Point(12, 32)
        Me.rtbPreview.Name = "rtbPreview"
        Me.rtbPreview.Size = New System.Drawing.Size(465, 522)
        Me.rtbPreview.TabIndex = 0
        Me.rtbPreview.Text = ""
        '
        'btnSelectAll
        '
        Me.btnSelectAll.Location = New System.Drawing.Point(12, 3)
        Me.btnSelectAll.Name = "btnSelectAll"
        Me.btnSelectAll.Size = New System.Drawing.Size(75, 23)
        Me.btnSelectAll.TabIndex = 1
        Me.btnSelectAll.Text = "Select All"
        Me.btnSelectAll.UseVisualStyleBackColor = True
        '
        'btnCopy
        '
        Me.btnCopy.Location = New System.Drawing.Point(93, 3)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(75, 23)
        Me.btnCopy.TabIndex = 2
        Me.btnCopy.Text = "Copy"
        Me.btnCopy.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Location = New System.Drawing.Point(174, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnAddEndRollText
        '
        Me.btnAddEndRollText.Location = New System.Drawing.Point(255, 3)
        Me.btnAddEndRollText.Name = "btnAddEndRollText"
        Me.btnAddEndRollText.Size = New System.Drawing.Size(156, 23)
        Me.btnAddEndRollText.TabIndex = 4
        Me.btnAddEndRollText.Text = "Add End roll text"
        Me.btnAddEndRollText.UseVisualStyleBackColor = True
        '
        'frmPreview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(489, 566)
        Me.Controls.Add(Me.btnAddEndRollText)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnCopy)
        Me.Controls.Add(Me.btnSelectAll)
        Me.Controls.Add(Me.rtbPreview)
        Me.Name = "frmPreview"
        Me.Text = "Preview"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rtbPreview As System.Windows.Forms.RichTextBox
    Friend WithEvents btnSelectAll As System.Windows.Forms.Button
    Friend WithEvents btnCopy As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnAddEndRollText As System.Windows.Forms.Button
End Class
