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
        Me.AgeTextBox = New System.Windows.Forms.TextBox()
        Me.SecondTextBox = New System.Windows.Forms.TextBox()
        Me.SecondLabel = New System.Windows.Forms.Label()
        Me.ThirdTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.UpperRadioButton = New System.Windows.Forms.RadioButton()
        Me.LowerRadioButton = New System.Windows.Forms.RadioButton()
        Me.FirstLastRadioButton = New System.Windows.Forms.RadioButton()
        Me.LastFirstRadioButton = New System.Windows.Forms.RadioButton()
        Me.CaseGroupBox = New System.Windows.Forms.GroupBox()
        Me.FormatGroupBox = New System.Windows.Forms.GroupBox()
        Me.ReverseCheckBox = New System.Windows.Forms.CheckBox()
        Me.WhiteSpaceCheckBox = New System.Windows.Forms.CheckBox()
        Me.RandomCheckBox = New System.Windows.Forms.CheckBox()
        Me.DataListBox = New System.Windows.Forms.ListBox()
        Me.RemoveButton = New System.Windows.Forms.Button()
        Me.CaseGroupBox.SuspendLayout()
        Me.FormatGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'UpdateButton
        '
        Me.UpdateButton.Location = New System.Drawing.Point(666, 379)
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
        Me.ExitButton.Location = New System.Drawing.Point(12, 379)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(126, 59)
        Me.ExitButton.TabIndex = 5
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'ChangeButton
        '
        Me.ChangeButton.Location = New System.Drawing.Point(666, 319)
        Me.ChangeButton.Name = "ChangeButton"
        Me.ChangeButton.Size = New System.Drawing.Size(122, 52)
        Me.ChangeButton.TabIndex = 4
        Me.ChangeButton.Text = "Change"
        Me.ChangeButton.UseVisualStyleBackColor = True
        '
        'ThirdLabel
        '
        Me.ThirdLabel.AutoSize = True
        Me.ThirdLabel.Location = New System.Drawing.Point(227, 117)
        Me.ThirdLabel.Name = "ThirdLabel"
        Me.ThirdLabel.Size = New System.Drawing.Size(26, 13)
        Me.ThirdLabel.TabIndex = 3
        Me.ThirdLabel.Text = "Age"
        '
        'AgeTextBox
        '
        Me.AgeTextBox.Location = New System.Drawing.Point(261, 114)
        Me.AgeTextBox.Name = "AgeTextBox"
        Me.AgeTextBox.Size = New System.Drawing.Size(149, 20)
        Me.AgeTextBox.TabIndex = 2
        '
        'SecondTextBox
        '
        Me.SecondTextBox.Location = New System.Drawing.Point(261, 93)
        Me.SecondTextBox.Name = "SecondTextBox"
        Me.SecondTextBox.Size = New System.Drawing.Size(149, 20)
        Me.SecondTextBox.TabIndex = 1
        '
        'SecondLabel
        '
        Me.SecondLabel.AutoSize = True
        Me.SecondLabel.Location = New System.Drawing.Point(198, 96)
        Me.SecondLabel.Name = "SecondLabel"
        Me.SecondLabel.Size = New System.Drawing.Size(55, 13)
        Me.SecondLabel.TabIndex = 5
        Me.SecondLabel.Text = "LastName"
        '
        'ThirdTextBox
        '
        Me.ThirdTextBox.Location = New System.Drawing.Point(261, 71)
        Me.ThirdTextBox.Name = "ThirdTextBox"
        Me.ThirdTextBox.Size = New System.Drawing.Size(149, 20)
        Me.ThirdTextBox.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(198, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "First Name"
        '
        'UpperRadioButton
        '
        Me.UpperRadioButton.AutoSize = True
        Me.UpperRadioButton.Location = New System.Drawing.Point(6, 19)
        Me.UpperRadioButton.Name = "UpperRadioButton"
        Me.UpperRadioButton.Size = New System.Drawing.Size(81, 17)
        Me.UpperRadioButton.TabIndex = 8
        Me.UpperRadioButton.TabStop = True
        Me.UpperRadioButton.Text = "Upper Case"
        Me.UpperRadioButton.UseVisualStyleBackColor = True
        '
        'LowerRadioButton
        '
        Me.LowerRadioButton.AutoSize = True
        Me.LowerRadioButton.Location = New System.Drawing.Point(6, 41)
        Me.LowerRadioButton.Name = "LowerRadioButton"
        Me.LowerRadioButton.Size = New System.Drawing.Size(81, 17)
        Me.LowerRadioButton.TabIndex = 9
        Me.LowerRadioButton.TabStop = True
        Me.LowerRadioButton.Text = "Lower Case"
        Me.LowerRadioButton.UseVisualStyleBackColor = True
        '
        'FirstLastRadioButton
        '
        Me.FirstLastRadioButton.AutoSize = True
        Me.FirstLastRadioButton.Location = New System.Drawing.Point(6, 24)
        Me.FirstLastRadioButton.Name = "FirstLastRadioButton"
        Me.FirstLastRadioButton.Size = New System.Drawing.Size(64, 17)
        Me.FirstLastRadioButton.TabIndex = 10
        Me.FirstLastRadioButton.TabStop = True
        Me.FirstLastRadioButton.Text = "FirstLast"
        Me.FirstLastRadioButton.UseVisualStyleBackColor = True
        '
        'LastFirstRadioButton
        '
        Me.LastFirstRadioButton.AutoSize = True
        Me.LastFirstRadioButton.Location = New System.Drawing.Point(6, 46)
        Me.LastFirstRadioButton.Name = "LastFirstRadioButton"
        Me.LastFirstRadioButton.Size = New System.Drawing.Size(64, 17)
        Me.LastFirstRadioButton.TabIndex = 11
        Me.LastFirstRadioButton.TabStop = True
        Me.LastFirstRadioButton.Text = "LastFirst"
        Me.LastFirstRadioButton.UseVisualStyleBackColor = True
        '
        'CaseGroupBox
        '
        Me.CaseGroupBox.Controls.Add(Me.UpperRadioButton)
        Me.CaseGroupBox.Controls.Add(Me.LowerRadioButton)
        Me.CaseGroupBox.Location = New System.Drawing.Point(261, 175)
        Me.CaseGroupBox.Name = "CaseGroupBox"
        Me.CaseGroupBox.Size = New System.Drawing.Size(93, 67)
        Me.CaseGroupBox.TabIndex = 12
        Me.CaseGroupBox.TabStop = False
        Me.CaseGroupBox.Text = "Case"
        '
        'FormatGroupBox
        '
        Me.FormatGroupBox.Controls.Add(Me.FirstLastRadioButton)
        Me.FormatGroupBox.Controls.Add(Me.LastFirstRadioButton)
        Me.FormatGroupBox.Location = New System.Drawing.Point(360, 175)
        Me.FormatGroupBox.Name = "FormatGroupBox"
        Me.FormatGroupBox.Size = New System.Drawing.Size(76, 67)
        Me.FormatGroupBox.TabIndex = 13
        Me.FormatGroupBox.TabStop = False
        Me.FormatGroupBox.Text = "Format"
        '
        'ReverseCheckBox
        '
        Me.ReverseCheckBox.AutoSize = True
        Me.ReverseCheckBox.Location = New System.Drawing.Point(261, 248)
        Me.ReverseCheckBox.Name = "ReverseCheckBox"
        Me.ReverseCheckBox.Size = New System.Drawing.Size(66, 17)
        Me.ReverseCheckBox.TabIndex = 14
        Me.ReverseCheckBox.Text = "Reverse"
        Me.ReverseCheckBox.UseVisualStyleBackColor = True
        '
        'WhiteSpaceCheckBox
        '
        Me.WhiteSpaceCheckBox.AutoSize = True
        Me.WhiteSpaceCheckBox.Location = New System.Drawing.Point(261, 272)
        Me.WhiteSpaceCheckBox.Name = "WhiteSpaceCheckBox"
        Me.WhiteSpaceCheckBox.Size = New System.Drawing.Size(88, 17)
        Me.WhiteSpaceCheckBox.TabIndex = 15
        Me.WhiteSpaceCheckBox.Text = "White Space"
        Me.WhiteSpaceCheckBox.UseVisualStyleBackColor = True
        '
        'RandomCheckBox
        '
        Me.RandomCheckBox.AutoSize = True
        Me.RandomCheckBox.Location = New System.Drawing.Point(261, 296)
        Me.RandomCheckBox.Name = "RandomCheckBox"
        Me.RandomCheckBox.Size = New System.Drawing.Size(66, 17)
        Me.RandomCheckBox.TabIndex = 16
        Me.RandomCheckBox.Text = "Random"
        Me.RandomCheckBox.UseVisualStyleBackColor = True
        '
        'DataListBox
        '
        Me.DataListBox.FormattingEnabled = True
        Me.DataListBox.Location = New System.Drawing.Point(501, 68)
        Me.DataListBox.Name = "DataListBox"
        Me.DataListBox.Size = New System.Drawing.Size(271, 225)
        Me.DataListBox.TabIndex = 17
        '
        'RemoveButton
        '
        Me.RemoveButton.Location = New System.Drawing.Point(534, 379)
        Me.RemoveButton.Name = "RemoveButton"
        Me.RemoveButton.Size = New System.Drawing.Size(126, 59)
        Me.RemoveButton.TabIndex = 18
        Me.RemoveButton.Text = "Remove"
        Me.RemoveButton.UseVisualStyleBackColor = True
        '
        'WinFormExampleForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.RemoveButton)
        Me.Controls.Add(Me.DataListBox)
        Me.Controls.Add(Me.RandomCheckBox)
        Me.Controls.Add(Me.WhiteSpaceCheckBox)
        Me.Controls.Add(Me.ReverseCheckBox)
        Me.Controls.Add(Me.FormatGroupBox)
        Me.Controls.Add(Me.CaseGroupBox)
        Me.Controls.Add(Me.ThirdTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.SecondTextBox)
        Me.Controls.Add(Me.SecondLabel)
        Me.Controls.Add(Me.AgeTextBox)
        Me.Controls.Add(Me.ThirdLabel)
        Me.Controls.Add(Me.ChangeButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.UpdateButton)
        Me.Name = "WinFormExampleForm"
        Me.Text = "WinFormExample"
        Me.CaseGroupBox.ResumeLayout(False)
        Me.CaseGroupBox.PerformLayout()
        Me.FormatGroupBox.ResumeLayout(False)
        Me.FormatGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UpdateButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents ChangeButton As Button
    Friend WithEvents ThirdLabel As Label
    Friend WithEvents AgeTextBox As TextBox
    Friend WithEvents SecondTextBox As TextBox
    Friend WithEvents SecondLabel As Label
    Friend WithEvents ThirdTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents UpperRadioButton As RadioButton
    Friend WithEvents LowerRadioButton As RadioButton
    Friend WithEvents FirstLastRadioButton As RadioButton
    Friend WithEvents LastFirstRadioButton As RadioButton
    Friend WithEvents CaseGroupBox As GroupBox
    Friend WithEvents FormatGroupBox As GroupBox
    Friend WithEvents ReverseCheckBox As CheckBox
    Friend WithEvents WhiteSpaceCheckBox As CheckBox
    Friend WithEvents RandomCheckBox As CheckBox
    Friend WithEvents DataListBox As ListBox
    Friend WithEvents RemoveButton As Button
End Class
