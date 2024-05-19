Public Class Form9
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim showDialogOptions As DialogResult = MessageBox.Show("The test will contain 10 Items " + vbCrLf + "you have only 25 mins" + vbCrLf + "Do you want to proceed?", "WARNING!", MessageBoxButtons.YesNo)
        If showDialogOptions = DialogResult.Yes Then
            Form10.Show()
        ElseIf showDialogOptions = DialogResult.No Then
            Return
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form8.Show()
        Me.Hide()
    End Sub
End Class