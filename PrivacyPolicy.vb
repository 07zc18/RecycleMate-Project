Public Class PrivacyPolicy
    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click

        ' Check if the "Agree" radio button is selected
        If CBAgree.Checked = True Then
            MessageBox.Show("You have successfully agreed to the Privacy Policy!",
                            "Successfully agreed",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
            Me.Close()
        Else
            MessageBox.Show("Please read and agree to the Privacy Policy before continuing.",
                            "Agreement Required",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
        End If
    End Sub
End Class