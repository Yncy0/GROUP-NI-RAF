Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form13
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim showDialogOptions As DialogResult = MessageBox.Show("The test will contain 15 Items" + vbCrLf + "you have only 30 mins" + vbCrLf + "Do you want to proceed?", "WARNING!", MessageBoxButtons.YesNo)
        If showDialogOptions = DialogResult.Yes Then
            Form14.Timer1.Enabled = True
            Form14.Label3.Text = "00:00:00"
            Form14.Show()
            Me.Hide()
            Form14.TextBox1.Enabled = True
            Form14.TextBox2.Enabled = True
            Form14.TextBox3.Enabled = True
            Form14.TextBox4.Enabled = True
            Form14.TextBox5.Enabled = True
            Form14.TextBox6.Enabled = True
            Form14.TextBox7.Enabled = True
            Form14.TextBox8.Enabled = True
            Form14.TextBox9.Enabled = True
            Form14.TextBox10.Enabled = True
            Form14.TextBox11.Enabled = True
            Form14.TextBox12.Enabled = True
            Form14.TextBox13.Enabled = True
            Form14.TextBox14.Enabled = True
            Form14.TextBox15.Enabled = True
        ElseIf showDialogOptions = DialogResult.No Then
            Return
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form12.Show()
        Me.Hide()
    End Sub


End Class