Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class Form14
    Dim score As Integer = 0
    Dim pass As Boolean = False
    Public uName As String
    Dim ss, tt, vv As Integer
    Dim showDialogOptions As DialogResult

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label3.Text = Format(ss, "00:") & Format(tt, "00:") & Format(vv, "00")
        vv += 1
        If vv > 59 Then
            vv = 0
            tt += 1
        End If
        If tt = 30 Then
            vv = 0
            tt = 0
            Label3.Text = "00:00:00"
            Timer1.Enabled = False
            showDialogOptions = MessageBox.Show("TIMES UP! You failed this tes!" + vbCrLf + "You will restart to Level 1", "Message", MessageBoxButtons.OK)
            If showDialogOptions.Yes Then
                Form2.Show()
                Me.Hide()
            End If
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "for" Then
            score += 1
        End If
        If TextBox2.Text = "while" Then
            score += 1
        End If
        If TextBox3.Text = "do-while" Then
            score += 1
        End If
        If TextBox4.Text = "infinite" Then
            score += 1
        End If
        If TextBox5.Text = "for-each" Then
            score += 1
        End If
        If TextBox6.Text = "break" Then
            score += 1
        End If
        If TextBox7.Text = "continue" Then
            score += 1
        End If
        If TextBox8.Text = "nested" Then
            score += 1
        End If
        If TextBox9.Text = "loop" Then
            score += 1
        End If
        If TextBox10.Text = "method" Then
            score += 1
        End If
        If TextBox11.Text = "once" Then
            score += 1
        End If
        If TextBox12.Text = "condition" Then
            score += 1
        End If
        If TextBox13.Text = "increment" Or TextBox13.Text = "decrement" Then
            score += 1
        End If
        If TextBox14.Text = "for" Then
            score += 1
        End If
        If TextBox15.Text = "while" Then
            score += 1
        End If

        TextBox16.Text = score.ToString
        If score >= 5 Then
            TextBox17.Text = "YOU PASSED!"
            pass = True
        Else
            TextBox17.Text = "FAILED!"
        End If

        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = False
        TextBox5.Enabled = False
        TextBox6.Enabled = False
        TextBox7.Enabled = False
        TextBox8.Enabled = False
        TextBox9.Enabled = False
        TextBox10.Enabled = False
        TextBox11.Enabled = False
        TextBox12.Enabled = False
        TextBox13.Enabled = False
        TextBox14.Enabled = False
        TextBox15.Enabled = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


        If pass = True Then
            showDialogOptions = MessageBox.Show("CONGRATS! You can access finished all levels!" + vbCrLf + "Do you want to continue?", "Message", MessageBoxButtons.YesNo)
            If showDialogOptions = DialogResult.Yes Then
                Form15.Label1.Text = uName
                Form15.Show()
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
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
        TextBox11.Text = ""
        TextBox12.Text = ""
        TextBox13.Text = ""
        TextBox14.Text = ""
        TextBox15.Text = ""
    End Sub


End Class