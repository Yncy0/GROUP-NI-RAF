Public Class Form10
    Dim score As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If RadioButton2.Checked Then
            score += 1
        End If
        If RadioButton6.Checked Then
            score += 1
        End If
        If RadioButton10.Checked Then
            score += 1
        End If
        If RadioButton13.Checked Then
            score += 1
        End If
        If RadioButton18.Checked Then
            score += 1
        End If
        If RadioButton22.Checked Then
            score += 1
        End If
        If RadioButton27.Checked Then
            score += 1
        End If
        If RadioButton31.Checked Then
            score += 1
        End If
        If RadioButton36.Checked Then
            score += 1
        End If
        If RadioButton37.Checked Then
            score += 1
        End If

        TextBox2.Text = score.ToString
        If score >= 5 Then
            TextBox1.Text = "YOU PASSED!"
        Else
            TextBox1.Text = "FAILED!"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
End Class