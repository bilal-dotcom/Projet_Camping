Public Class canot
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Visible = False
    End Sub

    Private Sub fraisCanot_Click(sender As Object, e As EventArgs) Handles fraisCanot.Click
        Dim s As Decimal
        If RadioButton1.Checked Then
            s = NumericUpDown1.Value * NumericUpDown2.Value * 22.35
        Else
            s = NumericUpDown1.Value * NumericUpDown2.Value * 29.55
        End If
        lblca.Text = s

    End Sub
End Class