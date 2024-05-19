Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username As String = TextBox1.Text
        Dim password As String = TextBox2.Text
        Dim fullName As String = TextBox3.Text


        If String.IsNullOrWhiteSpace(username) OrElse String.IsNullOrWhiteSpace(password) Then
            MessageBox.Show("Please enter your username and password!")
            Return
        End If




        If Not IsPasswordStrong(password) Then
            MessageBox.Show("Password must be at least 8 characters with 1 uppercase")
        End If

        Dim registrationSuccessful As Boolean = PerformRegistration(username, password)

        If registrationSuccessful Then
            Dim form2 As New Form2()
            form2.Show()
            Me.Hide()

        Else
            MessageBox.Show("Registration failed. Please try again.")
            TextBox1.Clear()
            TextBox2.Clear()
        End If
    End Sub

    Private Function IsPasswordStrong(password As String) As Boolean
        If password.Length < 8 Then
            Return False
        End If
        Dim hasUpperCase As Boolean = False
        For Each c As Char In password
            If Char.IsUpper(c) Then
                hasUpperCase = True
                Exit For
            End If
        Next
        Return hasUpperCase
    End Function

    Private Function PerformRegistration(username As String, password As String) As Boolean
        If username.ToLower() = "admin" Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub
End Class
