<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BooksTableForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.LoadDataButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LoadDataButton
        '
        Me.LoadDataButton.Location = New System.Drawing.Point(368, 270)
        Me.LoadDataButton.Name = "LoadDataButton"
        Me.LoadDataButton.Size = New System.Drawing.Size(75, 23)
        Me.LoadDataButton.TabIndex = 0
        Me.LoadDataButton.Text = "Load Data"
        Me.LoadDataButton.UseVisualStyleBackColor = True
        '
        'BooksTableForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LoadDataButton)
        Me.Name = "BooksTableForm"
        Me.Text = "Books Table"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LoadDataButton As Button
End Class
