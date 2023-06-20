Public Class PlayProject

'Initialise Play Project Form
Sub PlayProject_Activate()
  ControlBox = False
  MaximizeBox = False
End Sub

'Function to Calculate Score
Function CalculateScore(numCorrect As Integer, numIncorrect As Integer)
  Dim score As Integer
  score = numCorrect * 5 - numIncorrect * 2
  CalculateScore = score
End Function

'Function to Generate Random Numbers
Function GenerateRandomNos(maxVal As Integer)
  Randomize
  Dim rndVal As Integer
  rndVal = Int(Rnd() * (maxVal + 1))
  GenerateRandomNos = rndVal
End Function

'Function to Display Welcome Message
Sub WelcomeMsg()
  MsgBox("Welcome to Project Play!" & Chr(10) & "Let's start the game!")
End Sub

'Function to Generate Question
Function GenerateQuestion()
  Dim rndVal1 As Integer, rndVal2 As Integer
  rndVal1 = GenerateRandomNos(10)
  rndVal2 = GenerateRandomNos(10)
  GenerateQuestion = rndVal1 & "+" & rndVal2
End Function

'Function to Collect Answers
Function GetAnswer(question As String)
  Dim userAnswer As Integer
  userAnswer = InputBox("Please answer the following question:" & Chr(10) &
  question)
  GetAnswer = userAnswer
End Function

'Function to Validate Answer
Function ValidateAnswer(num1 As Integer, num2 As Integer, userAns As Integer)
  Dim result As Boolean
  result = (num1 + num2 = userAns)
  ValidateAnswer = result
End Function

'Function to Update Scores
Sub UpdateScore(ByRef numCorrect As Integer, ByRef numIncorrect As Integer,
validAnswer As Boolean)
  If validAnswer = True Then
    numCorrect = numCorrect + 1
  Else
    numIncorrect = numIncorrect + 1
  End If

End Sub

'Function to Display Score
Sub DisplayScore(numCorrect As Integer, numIncorrect As Integer)
  Dim score As Integer
  score = CalculateScore(numCorrect, numIncorrect)
  MsgBox ("Score: " & score)
End Sub

'Function to Play Game
Sub PlayGame()
  Dim numCorrect As Integer, numIncorrect As Integer
  numCorrect = 0
  numIncorrect = 0
  Dim answer As Integer, validAnswer As Boolean
  Randomize
  WelcomeMsg
  Do
    Dim question As String
    question = GenerateQuestion
    answer = GetAnswer(question)
    validAnswer = ValidateAnswer(Val(Left(question, 1)), Val(Right(question, 1)),
    answer)
    UpdateScore numCorrect, numIncorrect, validAnswer
    Loop Until MsgBox("Do you wish to continue?", vbYesNo) = vbNo
  DisplayScore numCorrect, numIncorrect
End Sub

'Function to Exit Game
Sub ExitGame()
  MsgBox("Thanks for playing!")
  End
End Sub

'Function to Trigger On Click
Sub btnPlay_Click()
  PlayGame
End Sub

'Function to Exit On Click
Sub btnExit_Click()
  ExitGame
End Sub

End Class