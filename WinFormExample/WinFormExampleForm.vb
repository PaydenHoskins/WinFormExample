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

    Function Random(Max As Integer, min As Integer) As Integer
        Dim Placement As Single
        Randomize()
        Placement = Rnd()
        Placement *= Max + min
        Placement += min
        Return CInt(Placement)
    End Function

    Function Track(CurrentNumber As Integer) As Boolean()
        'Tracks the drawn Cards
        Static DrawnCard(100) As Boolean
        DrawnCard(CurrentNumber) = True
        Return DrawnCard
    End Function
    Sub Scrable()
        Dim DiscardPile() As Boolean = Track(0)
        Dim Temp As String = ThirdTextBox.Text
        Dim Spot As Integer
        Console.WriteLine($"The third letter is: {Temp(2)}")

        Do
            For i = 0 To Len(Temp)
                Spot = Random(Len(Temp), 0)
                Track(CInt(Spot))
                i = Spot
                Spot = i
            Next
        Loop Until DiscardPile(CInt(Spot)) = False
        Console.WriteLine($"{Temp(Spot)}")
        'For i = 0 To Len(Temp) - 1
        '    Console.WriteLine($"The {i + 1} letter is: {Temp(i)}")
        'Next
    End Sub

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
            Scrable()
            SetCase()
            SetFormat()
            RemoveWhiteSpace()
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
