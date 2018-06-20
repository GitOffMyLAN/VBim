<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class options
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
        Me.FontOptions = New System.Windows.Forms.FontDialog()
        Me.FontDialogOpen = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'FontDialogOpen
        '
        Me.FontDialogOpen.Location = New System.Drawing.Point(13, 12)
        Me.FontDialogOpen.Name = "FontDialogOpen"
        Me.FontDialogOpen.Size = New System.Drawing.Size(259, 24)
        Me.FontDialogOpen.TabIndex = 0
        Me.FontDialogOpen.Text = "Font Options"
        Me.FontDialogOpen.UseVisualStyleBackColor = True
        '
        'options
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.FontDialogOpen)
        Me.Name = "options"
        Me.Text = "options"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FontOptions As System.Windows.Forms.FontDialog
    Friend WithEvents FontDialogOpen As System.Windows.Forms.Button
End Class
