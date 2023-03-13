Public Class Form1
    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim decStartMeasure As Decimal
        Dim decConvertedMeasure As Decimal
        Dim strConvertMsg As String = ""

        If IsNumeric(txtMeasurement.Text) Then
            decStartMeasure = Convert.ToDecimal(txtMeasurement.Text)

            If decStartMeasure >= 0 Then

                If radInToM.Checked Then

                    decConvertedMeasure = decStartMeasure * 0.0254
                    strConvertMsg = decStartMeasure.ToString() & " inches is " & decConvertedMeasure.ToString("F3") & " meters."

                ElseIf radMToIn.Checked Then

                    decConvertedMeasure = decStartMeasure / 0.0254
                    strConvertMsg = decStartMeasure.ToString() & " meters is " & decConvertedMeasure.ToString("F3") & " inches."

                End If

                lblConverted.Text = strConvertMsg

            Else

                MsgBox("Error - Input must be non-negative", , "Invalid Number Error")

            End If

        Else

            MsgBox("Error - Input must be a number", , "Invalid Entry Error")

        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblConverted.Text = ""
        txtMeasurement.Clear()
        txtMeasurement.Focus()
        radInToM.Checked = True
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class
