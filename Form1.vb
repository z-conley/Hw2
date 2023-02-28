Public Class Form1
    Private Sub Btnexit_Click(sender As Object, e As EventArgs) Handles Btnexit.Click
        Close()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtGrosspay.Focus()
        Lblficatotal.Text = ""
        Lblstatetaxtot.Text = ""
        Lblfedtaxtot.Text = ""
        Lblnettotal.Text = ""

    End Sub

    Private Sub Btnclear_Click(sender As Object, e As EventArgs) Handles Btnclear.Click
        Lblficatotal.Text = ""
        Lblstatetaxtot.Text = ""
        Lblfedtaxtot.Text = ""
        Lblnettotal.Text = ""
        TxtGrosspay.Clear()
        TxtGrosspay.Focus()
    End Sub

    Private Sub BtnCompute_Click(sender As Object, e As EventArgs) Handles BtnCompute.Click
        Dim strIncome As String
        Dim decIncome As Decimal
        Dim decfica As Decimal
        Dim decFederal As Decimal
        Dim decState As Decimal
        Dim DecNet As Decimal

        Const cdecfica As Decimal = 0.0765D
        Const cdecFed As Decimal = 0.22D
        Const cdecState As Decimal = 0.04D

        decIncome = Convert.ToInt32(TxtGrosspay.Text)


        decfica = decIncome * cdecfica
        decFederal = decIncome * cdecFed
        decState = decIncome * cdecState

        decfica = Convert.ToInt32(decfica)


        DecNet = (decIncome - decfica - decFederal - decState)


        Lblficatotal.Text = decfica.ToString("C2")
        Lblfedtaxtot.Text = decFederal.ToString("C2")
        Lblstatetaxtot.Text = decState.ToString("C2")
        Lblnettotal.Text = DecNet.ToString("C2")


    End Sub
End Class
