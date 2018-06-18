<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class about
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
        Me.pib_about = New System.Windows.Forms.PictureBox()
        CType(Me.pib_about, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pib_about
        '
        Me.pib_about.Location = New System.Drawing.Point(88, 12)
        Me.pib_about.Name = "pib_about"
        Me.pib_about.Size = New System.Drawing.Size(100, 50)
        Me.pib_about.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pib_about.TabIndex = 0
        Me.pib_about.TabStop = False
        '
        'about
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.pib_about)
        Me.Name = "about"
        Me.Text = "about"
        CType(Me.pib_about, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pib_about As System.Windows.Forms.PictureBox
End Class
