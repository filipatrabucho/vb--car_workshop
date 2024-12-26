Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim DataAluguer As Date
        Dim DataFinal As Date
        Dim KmInicial As Integer
        Dim KmFinal As Integer
        Dim Ndias As Integer
        Dim Kms As Integer
        Dim TotalDias As Integer
        Dim TotalKms As Single
        Dim ValorTotal As Integer
        Label6.Visible = True
        Label7.Visible = True
        Label8.Visible = True

        'Calculo de Datas e valor total a pagar
        DataAluguer = CDate(txtinicio.Text)
        DataFinal = CDate(txtentrega.Text)
        Ndias = DateDiff(DateInterval.Day, DataAluguer, DataFinal)
        lbldias.Text = CStr(Ndias)
        TotalDias = Ndias * 35
        lblpagamento.Text = Format(TotalDias, "Currency")

        'Calculo de Kms
        KmInicial = Val(txtkminicio.Text)
        KmFinal = Val(txtkmfim.Text)
        Kms = KmFinal - KmInicial
        lblkm.Text = CStr(Kms)
        TotalKms = Kms * 0.1
        lblPagKms.Text = Format(TotalKms, "Currency")

        ValorTotal = TotalKms + TotalDias
        lbltotal.Text = Format(ValorTotal, "Currency")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtentrega.Text = ""
        txtinicio.Text = ""
        txtkmfim.Text = ""
        txtkminicio.Text = ""
        lbldias.Text = ""
        lblkm.Text = ""
        lblpagamento.Text = ""
        lblPagKms.Text = ""
        lbltotal.Text = ""
        Label6.Visible = False
        Label7.Visible = False
        Label8.Visible = False

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label6.Visible = False
        Label7.Visible = False
        Label8.Visible = False


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class
