Public Class Form6



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim score As Integer = 0
        'Glory to Kyle Centeno

        If RadioButton2.Checked Then
            score += 1
        End If
        If RadioButton3.Checked Then
            score += 1
        End If
        If RadioButton5.Checked Then
            score += 1
        End If
        If RadioButton8.Checked Then
            score += 1
        End If
        If RadioButton11.Checked Then
            score += 1
        End If
        If RadioButton9.Checked Then
            score += 1
        End If
        If RadioButton13.Checked Then
            score += 1
        End If
        If RadioButton15.Checked Then
            score += 1
        End If
        If RadioButton17.Checked Then
            score += 1
        End If
        If RadioButton19.Checked Then
            score += 1
        End If



        TextBox2.Text = score.ToString

    End Sub


End Class