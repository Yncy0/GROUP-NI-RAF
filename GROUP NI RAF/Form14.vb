Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class Form14
    Dim score As Integer = 0
    Dim pass As Boolean = False
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text Then
            score += 1
        End If
        If TextBox2.Text Then
            score += 1
        End If
        If TextBox3.Text Then
            score += 1
        End If
        If TextBox4.Text Then
            score += 1
        End If
        If TextBox5.Text Then
            score += 1
        End If
        If TextBox6.Text Then
            score += 1
        End If
        If TextBox7.Text Then
            score += 1
        End If
        If TextBox8.Text Then
            score += 1
        End If
        If TextBox9.Text Then
            score += 1
        End If
        If TextBox10.Text Then
            score += 1
        End If
        If TextBox11.Text Then
            score += 1
        End If
        If TextBox12.Text Then
            score += 1
        End If
        If TextBox13.Text Then
            score += 1
        End If
        If TextBox14.Text Then
            score += 1
        End If
        If TextBox15.Text Then
            score += 1
        End If

        TextBox16.Text = score.ToString
        If score >= 5 Then
            TextBox17.Text = "YOU PASSED!"
            pass = True
        Else
            TextBox17.Text = "FAILED!"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim showDialogOptions As DialogResult

        If pass = True Then
            showDialogOptions = MessageBox.Show("CONGRATS! You can access finished all levels!" + vbCrLf + "Do you want to continue?", "Message", MessageBoxButtons.YesNo)
            If showDialogOptions = DialogResult.Yes Then
                Form11.Show()
                Me.Hide()
            Else
                Dim newDialog As DialogResult = MessageBox.Show("Do you want to go back to Level 1?", "Message", MessageBoxButtons.YesNo)
                If newDialog.Yes Then
                    Form2.Show()
                    Me.Hide()
                Else
                    Return
                End If

            End If
        Else
            showDialogOptions = MessageBox.Show("YOU FAILED! You will be back to Level 1 again!" + vbCrLf + "Do you want to conitnue?", "Message", MessageBoxButtons.OK)
            If showDialogOptions = DialogResult.OK Then
                Form2.Show()
                Me.Hide()
            End If
        End If

        score = 0
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub
End Class