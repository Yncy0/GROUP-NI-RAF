Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class Form5
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim showDialogOptions As DialogResult = MessageBox.Show("The test will contain 10 Items" + vbCrLf + "you have only 20 mins" + vbCrLf + "Do you want to proceed?", "WARNING!", MessageBoxButtons.YesNo)
        If showDialogOptions = DialogResult.Yes Then
            Form6.Show()
            Me.Hide()
            Form6.RadioButton1.Enabled = True
            Form6.RadioButton2.Enabled = True
            Form6.RadioButton3.Enabled = True
            Form6.RadioButton4.Enabled = True
            Form6.RadioButton5.Enabled = True
            Form6.RadioButton6.Enabled = True
            Form6.RadioButton7.Enabled = True
            Form6.RadioButton8.Enabled = True
            Form6.RadioButton9.Enabled = True
            Form6.RadioButton10.Enabled = True
            Form6.RadioButton11.Enabled = True
            Form6.RadioButton12.Enabled = True
            Form6.RadioButton13.Enabled = True
            Form6.RadioButton14.Enabled = True
            Form6.RadioButton15.Enabled = True
            Form6.RadioButton16.Enabled = True
            Form6.RadioButton17.Enabled = True
            Form6.RadioButton18.Enabled = True
            Form6.RadioButton19.Enabled = True
            Form6.RadioButton20.Enabled = True
        ElseIf showDialogOptions = DialogResult.No Then
            Return
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form4.Show()
        Me.Hide()
    End Sub
End Class