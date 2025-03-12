'Header

Option Strict On
Option Explicit On

Public Class WinFormExampleForm
    'Code Goes Here
    Sub SetDefaults()
        ThirdTextBox.Text = ""
        SecondTextBox.Text = ""
        AgeTextBox.Text = ""
        UpperRadioButton.Checked = True
        FirstLastRadioButton.Checked = True
        ReverseCheckBox.Checked = False
        WhiteSpaceCheckBox.Checked = False
        RandomCheckBox.Checked = False
        AgeTextBox.Focus()
    End Sub
    Sub addToList(thisString As String)
        DataListBox.Items.Add(thisString)
    End Sub
    Function Random(Max As Integer, min As Integer) As Integer
        Dim Placement As Single
        Randomize()
        Placement = Rnd()
        Placement *= Max + min
        Placement += min
        Return CInt(Placement)
    End Function

    Function Scramble(ThisString As String) As String
        Dim temp As String = ""
        Dim position As Integer
        Dim letters(Len(ThisString) - 1) As String
        Dim count As Integer = 0

        If RandomCheckBox.Checked Then

            For i = 0 To UBound(letters)
                letters(i) = ThisString(i)
            Next

            Do
                position = RandomNumberInRange(UBound(letters))
                If letters(position) <> "" Then
                    temp &= letters(position)
                    letters(position) = ""
                    count = count + 1
                End If
            Loop Until count >= Len(ThisString)
        Else
            temp = ThisString
        End If

        Return temp
    End Function

    Function RandomNumberInRange(Optional max% = 10%, Optional min% = 0%) As Integer
        Dim _max% = max - min
        If _max < 0 Then
            Throw New System.ArgumentException("Maximum number must be greater than minimum number")
        End If
        Randomize(DateTime.Now.Millisecond)
        Return CInt(System.Math.Floor(Rnd() * (_max + 1))) + min
    End Function

    Sub SetCase()
        If UpperRadioButton.Checked Then
            ThirdTextBox.Text = UCase(ThirdTextBox.Text)
            SecondTextBox.Text = UCase(SecondTextBox.Text)
        ElseIf LowerRadioButton.Checked Then
            ThirdTextBox.Text = LCase(ThirdTextBox.Text)
            SecondTextBox.Text = LCase(SecondTextBox.Text)
        Else
            MsgBox($"Oh No! Nothing Selected!")
        End If
    End Sub

    Sub SetFormat()
        If LastFirstRadioButton.Checked Then
            Me.Text = $"{SecondTextBox.Text},{ThirdTextBox.Text}"
        ElseIf FirstLastRadioButton.Checked Then
            Me.Text = ThirdTextBox.Text & " " & SecondTextBox.Text
        Else
            MsgBox($"Oh No! Nothing Selected!")
        End If
    End Sub

    Sub ReverseString()
        If ReverseCheckBox.Checked Then
            Me.Text = StrReverse(Me.Text)
        End If
    End Sub

    Function UserIputIsValid() As Boolean
        Dim Valid As Boolean = True
        Dim message As String
        If IsNumeric(AgeTextBox.Text) = False Then
            Valid = False
            AgeTextBox.Focus()
            message &= "Please enter a valid age." & vbNewLine
        End If
        If SecondTextBox.Text = "" Then
            Valid = False
            SecondTextBox.Focus()
            message &= "Please enter a valid lase name." & vbNewLine
        End If

        If ThirdTextBox.Text = "" Then
            Valid = False
            ThirdTextBox.Focus()
            message &= "Please enter a valid first name." & vbNewLine
        End If
        If Not Valid Then
            MsgBox(message, MsgBoxStyle.Exclamation, "User Input Fail!!!!")
        End If
        Return Valid
    End Function
    'Event Handlers ******************************************************************
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Sub RemoveWhiteSpace()
        If WhiteSpaceCheckBox.Checked Then
            Me.Text = Replace(Me.Text, " ", "")
        End If
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        If UserIputIsValid() Then
            ThirdTextBox.Text = Scramble(ThirdTextBox.Text)
            SecondTextBox.Text = Scramble(SecondTextBox.Text)
            SetCase()
            SetFormat()
            RemoveWhiteSpace()
            addToList(Me.Text)
            ReverseString()
            SetDefaults()
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
'tool tips
'accept and cancel button
'bad tab order
