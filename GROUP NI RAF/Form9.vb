Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class Form9
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim showDialogOptions As DialogResult = MessageBox.Show("The test will contain 10 Items " + vbCrLf + "you have only 25 mins" + vbCrLf + "Do you want to proceed?", "WARNING!", MessageBoxButtons.YesNo)
        If showDialogOptions = DialogResult.Yes Then
            Form10.Show()
            Form10.RadioButton1.Enabled = False
            Form10.RadioButton2.Enabled = False
            Form10.RadioButton3.Enabled = False
            Form10.RadioButton4.Enabled = False
            Form10.RadioButton5.Enabled = False
            Form10.RadioButton6.Enabled = False
            Form10.RadioButton7.Enabled = False
            Form10.RadioButton8.Enabled = False
            Form10.RadioButton9.Enabled = False
            Form10.RadioButton10.Enabled = False
            Form10.RadioButton11.Enabled = False
            Form10.RadioButton12.Enabled = False
            Form10.RadioButton13.Enabled = False
            Form10.RadioButton14.Enabled = False
            Form10.RadioButton15.Enabled = False
            Form10.RadioButton16.Enabled = False
            Form10.RadioButton17.Enabled = False
            Form10.RadioButton18.Enabled = False
            Form10.RadioButton19.Enabled = False
            Form10.RadioButton20.Enabled = False
            Form10.RadioButton21.Enabled = False
            Form10.RadioButton22.Enabled = False
            Form10.RadioButton23.Enabled = False
            Form10.RadioButton24.Enabled = False
            Form10.RadioButton25.Enabled = False
            Form10.RadioButton26.Enabled = False
            Form10.RadioButton27.Enabled = False
            Form10.RadioButton28.Enabled = False
            Form10.RadioButton29.Enabled = False
            Form10.RadioButton30.Enabled = False
            Form10.RadioButton31.Enabled = False
            Form10.RadioButton32.Enabled = False
            Form10.RadioButton33.Enabled = False
            Form10.RadioButton34.Enabled = False
            Form10.RadioButton35.Enabled = False
            Form10.RadioButton36.Enabled = False
            Form10.RadioButton37.Enabled = False
            Form10.RadioButton38.Enabled = False
            Form10.RadioButton39.Enabled = False
            Form10.RadioButton40.Enabled = False
        ElseIf showDialogOptions = DialogResult.No Then
            Return
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form8.Show()
        Me.Hide()
    End Sub
End Class