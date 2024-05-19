Public Class Form6
    Dim score As Integer = 0
    Dim pass As Boolean = False


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

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

        If score >= 5 Then
            TextBox1.Text = "YOU PASSED!"
            pass = True
        Else
            TextBox1.Text = "FAILED!"
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim showDialogOptions As DialogResult

        If pass = True Then
            showDialogOptions = MessageBox.Show("CONGRATS! You can access Level 2!\n Do you want to continue?", "Message", MessageBoxButtons.YesNo)
            If showDialogOptions = DialogResult.Yes Then
                Form7.Show()
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
            showDialogOptions = MessageBox.Show("YOU FAILED! You will be back to Level 1 again!\n Do you want to conitnue?", "Message", MessageBoxButtons.OK)
            If showDialogOptions = DialogResult.OK Then
                Form2.Show()
                Me.Hide()
            End If
        End If

        score = 0
        TextBox1.Text = ""
        TextBox2.Text = ""
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False
        RadioButton5.Checked = False
        RadioButton6.Checked = False
        RadioButton7.Checked = False
        RadioButton8.Checked = False
        RadioButton9.Checked = False
        RadioButton10.Checked = False
        RadioButton11.Checked = False
        RadioButton12.Checked = False
        RadioButton13.Checked = False
        RadioButton14.Checked = False
        RadioButton15.Checked = False
        RadioButton16.Checked = False
        RadioButton17.Checked = False
        RadioButton18.Checked = False
        RadioButton19.Checked = False
        RadioButton20.Checked = False

    End Sub
End Class