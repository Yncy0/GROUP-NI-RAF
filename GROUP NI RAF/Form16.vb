Public Class Form16
    Public form1PWord As String
    Public form1UName As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim uName As String = TextBox1.Text
        Dim pWord As String = TextBox2.Text

        If checkUserName(uName) = True AndAlso checkPassword(pWord) = True Then
            MessageBox.Show("Welcome!")
            Form2.Show()
            Me.Hide()
        Else
            MessageBox.Show("Please try again")
        End If

    End Sub
    Function checkUserName(userString As String) As Boolean
        If String.Compare(form1UName, userString) = 0 Then
            MessageBox.Show("Correct Username")
            Return True
        Else
            MessageBox.Show("Incorrect Username")
            Return False
        End If
    End Function
    Function checkPassword(passString As String) As Boolean
        If String.Compare(form1PWord, passString) = 0 Then
            MessageBox.Show("Correct Password")
            Return True
        Else
            MessageBox.Show("Incorrect Password")
            Return False
        End If
    End Function
End Class