Public Class equitation

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Visible = False
    End Sub

    Private Sub fraisEquitation_Click(sender As Object, e As EventArgs) Handles fraisEquitation.Click
        Dim price As Decimal

        If parcoursequitation.Value = 1 And btsemaine.Checked Then
            price = 15.25
        ElseIf parcoursequitation.Value = 1 And btconges.Checked Then
            price = 18.25
        ElseIf parcoursequitation.Value = 2 And btsemaine.Checked Then
            price = 22.75
        ElseIf parcoursequitation.Value = 2 And btconges.Checked Then
            price = 25
        ElseIf parcoursequitation.Value = 3 And btsemaine.Checked Then
            price = 25.25
        Else price = 27.75

        End If
        lbleq.Text = price * personneequitation.Value


    End Sub


End Class