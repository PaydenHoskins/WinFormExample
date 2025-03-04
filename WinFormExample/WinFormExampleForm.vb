'Header

Option Strict On
Option Explicit On

Public Class WinFormExampleForm
    'Code Goes Here
    Sub SetDefaults()
        ThirdTextBox.Text = ""
        SecondTextBox.Text = ""
        FirstTextBox.Text = ""
        UpperRadioButton.Checked = True
    End Sub
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        'Me.Text = StrReverse(Me.Text)
        If UpperRadioButton.Checked Then
            Me.Text = UCase(ThirdTextBox.Text & " " & SecondTextBox.Text)
        ElseIf UpperRadioButton.Checked = False Then
            Me.Text = LCase(ThirdTextBox.Text & " " & SecondTextBox.Text)
        Else
            MsgBox($"Oh No! Nothing Selected!")
        End If
    End Sub

    Private Sub ChangeButton_Click(sender As Object, e As EventArgs) Handles ChangeButton.Click
        Me.Text = ThirdTextBox.Text & " " & SecondTextBox.Text
        SetDefaults()
    End Sub

    Private Sub WinFormExampleForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        SetDefaults()
    End Sub

End Class
