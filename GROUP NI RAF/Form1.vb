Imports System.Runtime.CompilerServices

Public Class Form1
    Dim pubPassWord As String
    Dim pubUser As String
    Function countForUCase(str As String) As Integer
        Dim uCount As Integer = 0
        For Each c As Char In str
            Dim charCode As Integer = AscW(c)
            If charCode >= 65 AndAlso charCode < 91 Then
                uCount += 1
            End If
        Next
        Return uCount
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Public Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim uName As String = TextBox1.Text
        Dim pWord As String = TextBox2.Text
        Dim hasUCase As Boolean = False
        Dim validPass As Boolean = False

        If countForUCase(pWord) >= 1 Then
            hasUCase = True
        Else
            hasUCase = False
        End If




        If (String.IsNullOrWhiteSpace(uName)) AndAlso String.IsNullOrWhiteSpace(pWord) Then
            MessageBox.Show("Please fill in the required information")
        Else
            If pWord.Length > 8 AndAlso hasUCase = True Then
                MessageBox.Show("Valid Password")
                validPass = True
            Else
                MessageBox.Show("Invalid Password")
            End If
            If validPass = True Then
                MessageBox.Show("Please Login")
                pubPassWord = pWord
                Form16.form1PWord = pubPassWord
                pubUser = uName
                Form16.form1UName = pubUser
                Form16.Show()
                Form14.uName = pubUser
                Me.Hide()
            End If
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class
