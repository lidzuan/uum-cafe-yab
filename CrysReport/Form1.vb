Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ds As New UUMCafeDatabase5DataSet
        Dim da As New UUMCafeDatabase5DataSetTableAdapters.PaymentTableAdapter
        da.Fill(ds.Payment)
        Dim rpt As New CrystalReport1
        rpt.SetDataSource(ds)
        CrystalReportViewer1.ReportSource = rpt

    End Sub
End Class
