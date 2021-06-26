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
        Me.BooksTextField = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'LoadDataButton
        '
        Me.LoadDataButton.Location = New System.Drawing.Point(364, 317)
        Me.LoadDataButton.Name = "LoadDataButton"
        Me.LoadDataButton.Size = New System.Drawing.Size(75, 23)
        Me.LoadDataButton.TabIndex = 0
        Me.LoadDataButton.Text = "Load Data"
        Me.LoadDataButton.UseVisualStyleBackColor = True
        '
        'BooksTextField
        '
        Me.BooksTextField.Location = New System.Drawing.Point(37, 27)
        Me.BooksTextField.Name = "BooksTextField"
        Me.BooksTextField.Size = New System.Drawing.Size(723, 224)
        Me.BooksTextField.TabIndex = 1
        Me.BooksTextField.Text = ""
        '
        'BooksTableForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BooksTextField)
        Me.Controls.Add(Me.LoadDataButton)
        Me.Name = "BooksTableForm"
        Me.Text = "Books Table"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LoadDataButton As Button
    Friend WithEvents BooksTextField As RichTextBox
End Class
