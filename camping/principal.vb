Public Class principal

    Private Sub nom_TextChanged(sender As Object, e As EventArgs) Handles txtbox1.TextChanged
        facture.lblname.Text = txtbox1.Text

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        equitation.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        canot.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        escalade.Show()
    End Sub

    Private Sub tarif_Click(sender As Object, e As EventArgs) Handles tarif.Click
        facture.Show()

        'Calcul des frais pour le sejour
        Dim d1 As DateTime = date1.Value
        Dim d2 As DateTime = date2.Value
        Dim result As TimeSpan = d2 - d1
        Dim days As Integer = result.TotalDays
        Dim price As Decimal
        Dim total1 As Decimal
        If d1 >= "01/01" And d2 <= "31/05" Then
            price = 18.9
        ElseIf d1 >= "01/06" And d2 <= "31/08" Then
            price = 23.25
        Else
            price = 20.25
        End If
        total1 = days * price * NumericUpDown1.Value

        'Afficher les frais sejours dans la facture
        facture.lblfactsejour.Text = total1 & " $"

        'Afficher les frais d'equiation dans la facture
        Dim ttleq As Integer
        ttleq = equitation.lbleq.Text
        facture.lblequi.Text = equitation.lbleq.Text

        'Afficher les frais de canot dans la facture
        Dim ttlca As Double
        ttlca = canot.lblca.Text
        facture.lblcano.Text = canot.lblca.Text

        'Afficher les frais d'escalade dans la facture
        Dim ttlesc As Double
        ttlesc = escalade.lblesc.Text
        facture.lblesca.Text = escalade.lblesc.Text

        'Faire le total des frais pour le prix sans taxe
        Dim ttl0 As Decimal
        ttl0 = total1 + ttleq + ttlca + ttlesc

        facture.lbltotal0.Text = ttl0

        'Afficher le total des frais avec les taxes dans la facture
        Dim totalfinal As Decimal
        totalfinal = (ttl0 * 0.15) + ttl0
        facture.lbltotal.Text = totalfinal & " $ "

    End Sub

End Class
