Imports System.Data.OleDb
Public Class frmFeedback
    Dim pro As String
    Dim connstring As String
    Dim commmand As String
    Dim myconnection As OleDbConnection = New OleDbConnection

    Private Sub frmFeedback_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCustName.Text = "Hi! " & (frmLogin.txtCustomerName.Text)
        txtCustID.Text = frmLogin.txtCustomerID.Text
    End Sub

    Private Sub cmdSubmit_Click(sender As Object, e As EventArgs) Handles cmdSubmit.Click
        If (txtPaymentID.Text = String.Empty) Or (txtRate.Text = String.Empty) Then
            MsgBox("Please fill in the relevent Payment ID or Rate.", MessageBoxIcon.Information, "UUM Cafe YAB")
        End If

        If (txtComment.Text = String.Empty) Then
            txtComment.Text = "N/A"
        End If

        pro = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Access Database\UUMCafeDatabase5.accdb"
        connstring = pro
        myconnection.ConnectionString = connstring
        myconnection.Open()

        commmand = "insert into [Feedback] ([Payment_ID] , [Customer_ID] , [Fdb_Date] , [Cu_Rate] , [Cu_Comm]) values ('" & txtPaymentID.Text & "','" & txtCustID.Text & "','" & dateFdbDate.Value & "','" & txtRate.Text & "','" & txtComment.Text & "')"
        Dim custfeedback As OleDbCommand = New OleDbCommand(commmand, myconnection)
        custfeedback.Parameters.Add(New OleDbParameter("Payment_ID", CType(txtPaymentID.Text, String)))
        custfeedback.Parameters.Add(New OleDbParameter("Customer_ID", CType(txtCustID.Text, String)))
        custfeedback.Parameters.Add(New OleDbParameter("Fdb_Date", CType(dateFdbDate.Value = DateTime.Now, String)))
        custfeedback.Parameters.Add(New OleDbParameter("Cu_Rate", CType(txtRate.Text, String)))
        custfeedback.Parameters.Add(New OleDbParameter("Cu_Comm", CType(txtComment.Text, String)))

        custfeedback.ExecuteNonQuery()
        custfeedback.Dispose()
        myconnection.Close()

        txtPaymentID.Clear()
        txtRate.Text = String.Empty
        txtComment.Clear()
        dateFdbDate.Value = DateTime.Now

        MsgBox("Thanks for your response!", MessageBoxIcon.Information, "UUM Cafe YAB")
        Me.Hide()
        frmCustMainMenu.Show()

    End Sub

    Private Sub cmdBack_Click(sender As Object, e As EventArgs) Handles cmdBack.Click
        Me.Hide()
        frmCustMainMenu.Show()
    End Sub
End Class