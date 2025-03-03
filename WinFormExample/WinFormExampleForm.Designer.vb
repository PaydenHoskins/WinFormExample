<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WinFormExampleForm
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
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.ChangeButton = New System.Windows.Forms.Button()
        Me.ThirdLabel = New System.Windows.Forms.Label()
        Me.FirstTextBox = New System.Windows.Forms.TextBox()
        Me.SecondTextBox = New System.Windows.Forms.TextBox()
        Me.SecondLabel = New System.Windows.Forms.Label()
        Me.ThirdTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'UpdateButton
        '
        Me.UpdateButton.Location = New System.Drawing.Point(395, 179)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(122, 59)
        Me.UpdateButton.TabIndex = 3
        Me.UpdateButton.Text = "&Update"
        Me.UpdateButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.Color.Firebrick
        Me.ExitButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ExitButton.Location = New System.Drawing.Point(263, 179)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(126, 59)
        Me.ExitButton.TabIndex = 5
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'ChangeButton
        '
        Me.ChangeButton.Location = New System.Drawing.Point(337, 244)
        Me.ChangeButton.Name = "ChangeButton"
        Me.ChangeButton.Size = New System.Drawing.Size(108, 53)
        Me.ChangeButton.TabIndex = 4
        Me.ChangeButton.Text = "Change"
        Me.ChangeButton.UseVisualStyleBackColor = True
        '
        'ThirdLabel
        '
        Me.ThirdLabel.AutoSize = True
        Me.ThirdLabel.Location = New System.Drawing.Point(316, 120)
        Me.ThirdLabel.Name = "ThirdLabel"
        Me.ThirdLabel.Size = New System.Drawing.Size(26, 13)
        Me.ThirdLabel.TabIndex = 3
        Me.ThirdLabel.Text = "Age"
        '
        'FirstTextBox
        '
        Me.FirstTextBox.Location = New System.Drawing.Point(319, 136)
        Me.FirstTextBox.Name = "FirstTextBox"
        Me.FirstTextBox.Size = New System.Drawing.Size(149, 20)
        Me.FirstTextBox.TabIndex = 2
        '
        'SecondTextBox
        '
        Me.SecondTextBox.Location = New System.Drawing.Point(319, 97)
        Me.SecondTextBox.Name = "SecondTextBox"
        Me.SecondTextBox.Size = New System.Drawing.Size(149, 20)
        Me.SecondTextBox.TabIndex = 1
        '
        'SecondLabel
        '
        Me.SecondLabel.AutoSize = True
        Me.SecondLabel.Location = New System.Drawing.Point(316, 81)
        Me.SecondLabel.Name = "SecondLabel"
        Me.SecondLabel.Size = New System.Drawing.Size(55, 13)
        Me.SecondLabel.TabIndex = 5
        Me.SecondLabel.Text = "LastName"
        '
        'ThirdTextBox
        '
        Me.ThirdTextBox.Location = New System.Drawing.Point(319, 58)
        Me.ThirdTextBox.Name = "ThirdTextBox"
        Me.ThirdTextBox.Size = New System.Drawing.Size(149, 20)
        Me.ThirdTextBox.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(316, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "First Name"
        '
        'WinFormExampleForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ThirdTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.SecondTextBox)
        Me.Controls.Add(Me.SecondLabel)
        Me.Controls.Add(Me.FirstTextBox)
        Me.Controls.Add(Me.ThirdLabel)
        Me.Controls.Add(Me.ChangeButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.UpdateButton)
        Me.Name = "WinFormExampleForm"
        Me.Text = "WinFormExample"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UpdateButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents ChangeButton As Button
    Friend WithEvents ThirdLabel As Label
    Friend WithEvents FirstTextBox As TextBox
    Friend WithEvents SecondTextBox As TextBox
    Friend WithEvents SecondLabel As Label
    Friend WithEvents ThirdTextBox As TextBox
    Friend WithEvents Label2 As Label
End Class
