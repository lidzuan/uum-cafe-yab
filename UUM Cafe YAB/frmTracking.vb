Imports System.Data.OleDb
Public Class frmTracking
    Dim pro As String
    Dim connstring As String
    Dim myconnection As OleDbConnection = New OleDbConnection
    Dim con As New OleDbConnection

    Private Sub CustomerOrderBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CustomerOrderBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CustomerOrderBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.UUMCafeDatabase5DataSet)

    End Sub

    Private Sub frmTracking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'UUMCafeDatabase5DataSet.CustomerOrder' table. You can move, or remove it, as needed.
        Me.CustomerOrderTableAdapter.Fill(Me.UUMCafeDatabase5DataSet.CustomerOrder)

    End Sub

    Private Sub cmdCheckTracking_Click(sender As Object, e As EventArgs) Handles cmdCheckTracking.Click

        If txtPaymentID.Text = String.Empty Then
            MsgBox("Please fill in your payment ID.", MessageBoxIcon.Information, "UUM Cafe YAB")

        Else

            txtOrderStatus.Text = ""
            txtTotalPrice.Text = ""
            txtPaymentType.Text = ""
            txtCuRemark.Text = ""
            txtOfficeInasis.Text = ""
            txtBlockRoom.Text = ""
            txtRiderID.Text = ""
            txtRiderName.Text = ""
            txtRiderHP.Text = ""

            CustomerOrderBindingSource.Filter = "Payment_ID LIKE '" & txtPaymentID.Text & "'"
            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Access Database\UUMCafeDatabase5.accdb"
            con.Open()

            Dim strsqlnorider As String
            strsqlnorider = "select [Order_Status] , [Payment_Total] , [Payment_Type] , [Cu_Remark] , [Cu_Office_Inasis] , [Cu_Block_Room] , [Rider_ID] from Payment where [Payment_ID] = '" & txtPaymentID.Text & "'"
            Dim cmdnorider As New OleDbCommand(strsqlnorider, con)
            Dim myreadernorider As OleDbDataReader
            myreadernorider = cmdnorider.ExecuteReader
            myreadernorider.Read()


            txtOrderStatus.Text = myreadernorider("Order_Status")
            txtTotalPrice.Text = Format(myreadernorider("Payment_Total"), "0.00")
            txtPaymentType.Text = myreadernorider("Payment_Type")
            txtCuRemark.Text = myreadernorider("Cu_Remark")
            txtOfficeInasis.Text = myreadernorider("Cu_Office_Inasis")
            txtBlockRoom.Text = myreadernorider("Cu_Block_Room")

            Dim strsqlorderrider As String
            strsqlorderrider = "select [Rider_ID] from Payment where [Payment_ID] = '" & txtPaymentID.Text & "'"
            Dim cmdorderrider As New OleDbCommand(strsqlorderrider, con)
            Dim myreaderorderrider As OleDbDataReader
            myreaderorderrider = cmdorderrider.ExecuteReader
            myreaderorderrider.Read()

            txtRiderID.Text = myreaderorderrider("Rider_ID").ToString

            If myreaderorderrider.IsDBNull(0) Then
                MsgBox("We are assigning rider for you, thanks for waiting.", MessageBoxIcon.Information, "UUM Cafe YAB")
                myreaderorderrider.Close()
                con.Close()

            Else

                Dim strsql As String
                strsql = "select [Order_Status] , [Payment_Total] , [Payment_Type] , [Cu_Remark] , [Cu_Office_Inasis] , [Cu_Block_Room] , [Rider_ID] from Payment where [Payment_ID] = '" & txtPaymentID.Text & "'"
                Dim cmd As New OleDbCommand(strsql, con)
                Dim myreader As OleDbDataReader
                myreader = cmd.ExecuteReader
                myreader.Read()

                txtOrderStatus.Text = myreader("Order_Status")
                txtTotalPrice.Text = Format(myreader("Payment_Total"), "0.00")
                txtPaymentType.Text = myreader("Payment_Type")
                txtCuRemark.Text = myreader("Cu_Remark")
                txtOfficeInasis.Text = myreader("Cu_Office_Inasis")
                txtBlockRoom.Text = myreader("Cu_Block_Room")
                txtRiderID.Text = myreader("Rider_ID")

                If txtOfficeInasis.Text = "N/A" Then
                    txtPaymentID.Text = ""
                    txtOrderStatus.Text = ""
                    txtTotalPrice.Text = ""
                    txtPaymentType.Text = ""
                    txtCuRemark.Text = ""
                    txtOfficeInasis.Text = ""
                    txtBlockRoom.Text = ""
                    MsgBox("Please check again of your Payment ID, only delivery order can be tracked.", MessageBoxIcon.Information, "UUM Cafe YAB")
                    txtPaymentID.Focus()
                    myreader.Close()
                    con.Close()

                Else

                    'Check Rider
                    Dim strsqlrider As String
                    strsqlrider = "select [Rider_Name] , [Rider_HP] from Rider where [Rider_ID] = '" & txtRiderID.Text & "'"
                    Dim cmdrider As New OleDbCommand(strsqlrider, con)
                    Dim myreaderrider As OleDbDataReader
                    myreaderrider = cmdrider.ExecuteReader
                    myreaderrider.Read()

                    txtRiderName.Text = myreaderrider("Rider_Name")
                    txtRiderHP.Text = myreaderrider("Rider_HP")
                    myreaderrider.Close()
                    con.Close()

                End If

            End If

        End If
    End Sub

    Private Sub cmdBack_Click(sender As Object, e As EventArgs) Handles cmdBack.Click
        Me.Hide()
        frmCustMainMenu.Show()
    End Sub
End Class