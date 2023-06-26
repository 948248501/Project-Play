Public Class MainForm
    Dim p1 As Player
    Dim p2 As Player
    Dim tM As Integer
    Dim turn As Integer
    Dim Win As Integer


    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Initialization
        p1 = New Player("Player1")
        p2 = New Player("Player2")
        tM = 6
        turn = 0
        Win = 0

        'Setting Players
        lblPlayer1.Text = p1.name
        lblPlayer2.Text = p2.name

        'Setting Month
        p1.Round = tM
        lblPlayer1Round.Text = tM.ToString
        p2.Round = tM
        lblPlayer2Round.Text = tM.ToString

    End Sub

    'Roll Button
    Private Sub btnRoll_Click(sender As Object, e As EventArgs) Handles btnRoll.Click
        If turn = 1 Then
            p1.Round = p1.Round - 1
            lblPlayer1Round.Text = p1.Round.ToString
            If p1.Round > 0 Then
                Dim r As Integer = CInt(Math.Ceiling(Rnd() * 6))
                lblRoll.Text = r.ToString
                p1.Score = p1.Score + r
            Else
                lblRoll.Text = "-"
            End If
            lblPlayer1Score.Text = p1.Score.ToString
            turn = 0
            lblTurn.Text = p2.name
        Else
            p2.Round = p2.Round - 1
            lblPlayer2Round.Text = p2.Round.ToString

            If p2.Round > 0 Then
                Dim r As Integer = CInt(Math.Ceiling(Rnd() * 6))
                lblRoll.Text = r.ToString
                p2.Score = p2.Score + r
            Else
                lblRoll.Text = "-"
            End If
            lblPlayer2Score.Text = p2.Score.ToString
            turn = 1
            lblTurn.Text = p1.name
        End If

        'Check Winner
        If p1.Round = 0 And p2.Round = 0 Then
            If p1.Score > p2.Score Then
                Win = 1
            ElseIf p2.Score > p1.Score Then
                Win = 2
            Else
                Win = 0
            End If
            MessageBox.Show("Player " & Win & " Win!" & vbCrLf & p1.name & " Score : " & p1.Score & vbCrLf & p2.name & " Score : " & p2.Score, "Game Over")
        End If

    End Sub

    'Show Score Button
    Private Sub btmScore_Click(sender As Object, e As EventArgs) Handles btmScore.Click
        MessageBox.Show("Player1 Score : " & p1.Score & vbCrLf & "Player2 Score : " & p2.Score, "Score")
    End Sub

    'Reset Button
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        p1.Round = tM
        lblPlayer1Round.Text = tM.ToString
        lblPlayer1Score.Text = "0"
        p1.Score = 0
        p2.Round = tM
        lblPlayer2Round.Text = tM.ToString
        lblPlayer2Score.Text = "0"
        p2.Score = 0
        turn = 0
        lblTurn.Text = p1.name
        lblRoll.Text = "-"
        Win = 0
    End Sub
End Class

Public Class Player
    Public name As String
    Public Round As Integer
    Public Score As Integer
    Public Sub New(ByVal n As String)
        Me.name = n
        Me.Round = 0
        Me.Score = 0
    End Sub
End Class