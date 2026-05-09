<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TestApplication
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.StatusLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'StatusLabel
        '
        Me.StatusLabel.Location = New System.Drawing.Point(12, 12)
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(194, 13)
        Me.StatusLabel.TabIndex = 0
        Me.StatusLabel.Text = "This is a test application."
        Me.StatusLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TestApplication
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(218, 38)
        Me.Controls.Add(Me.StatusLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TestApplication"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GitHub Updater Test Application"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents StatusLabel As Label
End Class
