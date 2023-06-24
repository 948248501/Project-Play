Public Class Form1
    Dim sr As StreamReader
    Dim sw As StreamWriter
    Dim len As Integer
    Dim dir As String
    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        dir = IO.Path.GetDirectoryName(Application.ExecutablePath)
        If IO.File.Exists(dir & "\ProjectPlay.plf") Then
            sr = New StreamReader(dir & "\ProjectPlay.plf")
            len = sr.BaseStream.Length

            If len > 0 Then
                Dim game As String = sr.ReadLine
                sr.Close()
                sw = New StreamWriter(dir & "\ProjectPlay.plf")
                sw.WriteLine(len & "#" & game)
                sw.Close()
                Process.Start(game)
            End If
        Else
            MsgBox("No game selected!")
        End If
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        Dim opD As New OpenFileDialog
        opD.Filter = "Applications|*.exe"

        If opD.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim game As String = opD.FileName
            sw = New StreamWriter(dir & "\ProjectPlay.plf")
            sw.WriteLine(len & "#" & game)
            sw.Close()
        End If
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Project Play"
    End Sub

End Class