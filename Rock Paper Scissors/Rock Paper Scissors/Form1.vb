Public Class Form1

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        Randomize()

        Dim num As Integer ' variable to hold random number (computer choice)
        Const ROCK = 1
        Const PAPER = 2
        Const SCISSORS = 3

        num = CInt((3 * Rnd())) ' generate random numbers 1-3
        Dim winCount As Integer = 0
        Dim matchCount As Integer = 0
        Dim compCount As Integer = 0

        If rbRock.Checked And num = ROCK Then
            lblResult.Text = "Computer chose Rock also. Tie!"
        ElseIf rbRock.Checked And num = PAPER Then
            lblResult.Text = "Computer chose paper. You Lose!"

        ElseIf rbRock.Checked And num = SCISSORS Then
            lblResult.Text = "Computer chose. You Win!"

        ElseIf rbPaper.Checked And num = ROCK Then
            lblResult.Text = "Computer chose Rock. You Win!"

        ElseIf rbPaper.Checked And num = PAPER Then
            lblResult.Text = "Computer chose paper also. Tie!"
        ElseIf rbPaper.Checked And num = SCISSORS Then
            lblResult.Text = "Computer chose scissors. You Lose!"

        ElseIf rbScissors.Checked And num = ROCK Then
            lblResult.Text = "Computer chose Rock. You Lose!"

        ElseIf rbScissors.Checked And num = PAPER Then
            lblResult.Text = "Computer chose paper. You Win!"

        ElseIf rbScissors.Checked And num = SCISSORS Then
            lblResult.Text = "Computer chose scissors also. Tie!"
        End If

        
    End Sub
End Class
