Public Class escalade
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Visible = False
    End Sub

    Private Sub fraisEscalade_Click(sender As Object, e As EventArgs) Handles fraisEscalade.Click
        Dim p As String
        p = NumericUpDown1.Value * NumericUpDown2.Value * 10
        lblesc.Text = p
    End Sub


End Class