Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Opacity = 0.95
        CenterToParent()
    End Sub

    Private Function FV(pv As Single, i As Single, n As Integer) As Double
        FV = pv * (1 + i / 100) ^ n
    End Function

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub BtnCal_Click(sender As Object, e As EventArgs) Handles BtnCal.Click
        Dim FutureVal As Single
        Dim PresentVal As Single
        Dim interest As Single
        Dim period As Integer
        PresentVal = txtPV.Text
        interest = txtIR.Text
        period = txtN.Text
        FutureVal = FV(PresentVal, interest, period)
        txtFV.Text = Format(FutureVal, "$#,##0.00")
    End Sub
End Class
