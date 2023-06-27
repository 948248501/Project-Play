Public Class Form1

Dim flag As Boolean = False

Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

End Sub

Private Sub startbtn_Click(sender As Object, e As EventArgs) Handles startbtn.Click

flag = True

End Sub

Private Sub pausebtn_Click(sender As Object, e As EventArgs) Handles pausebtn.Click

flag = False

End Sub

Private Sub stopbtn_Click(sender As Object, e As EventArgs) Handles stopbtn.Click

flag = False

End Sub

Private Sub playbtn_Click(sender As Object, e As EventArgs) Handles playbtn.Click

If flag = True Then 

End If

End Sub

Private Sub rewindbtn_Click(sender As Object, e As EventArgs) Handles rewindbtn.Click

flag = False 

End Sub

Private Sub fastforwardbtn_Click(sender As Object, e As EventArgs) Handles fastforwardbtn.Click

flag = False

End Sub

Private Sub backwardbtn_Click(sender As Object, e As EventArgs) Handles backwardbtn.Click

flag = False

End Sub

Private Sub forwardbtn_Click(sender As Object, e As EventArgs) Handles forwardbtn.Click

flag = False

End Sub

Private Sub openbtn_Click(sender As Object, e As EventArgs) Handles openbtn.Click

flag = False

End Sub

Private Sub savebtn_Click(sender As Object, e As EventArgs) Handles savebtn.Click

flag = False

End Sub

Private Sub quitbtn_Click(sender As Object, e As EventArgs) Handles quitbtn.Click

flag = False

End Sub

Private Sub volumebtn_Click(sender As Object, e As EventArgs) Handles volumebtn.Click

flag = False

End Sub

Private Sub speedbtn_Click(sender As Object, e As EventArgs) Handles speedbtn.Click

flag = False

End Sub

Private Sub mutebtn_Click(sender As Object, e As EventArgs) Handles mutebtn.Click

flag = False

End Sub

Private Sub ejectbtn_Click(sender As Object, e As EventArgs) Handles ejectbtn.Click

flag = False

End Sub

Private Sub toolstripbtn_Click(sender As Object, e As EventArgs) Handles toolstripbtn.Click

flag = False

End Sub

End Class