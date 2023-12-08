Imports System.Data.OleDb
Public Class frmRiderDuty
    Dim pro As String
    Dim connstring As String
    Dim commmand As String
    Dim myconnection As OleDbConnection = New OleDbConnection
    Dim con As New OleDbConnection

    Private Sub CustomerOrderBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CustomerOrderBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CustomerOrderBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.UUMCafeDatabase5DataSet)

    End Sub

    Private Sub frmRiderDuty2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'UUMCafeDatabase5DataSet.CustomerOrder' table. You can move, or remove it, as needed.
        Me.CustomerOrderTableAdapter.Fill(Me.UUMCafeDatabase5DataSet.CustomerOrder)

        txtRiderID.Text = frmLogin.txtRiderID.Text

    End Sub

    Private Sub cmdCheckMyDuty_Click(sender As Object, e As EventArgs) Handles cmdCheckMyDuty.Click
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Access Database\UUMCafeDatabase5.accdb"
        con.Open()

        Dim strsql As String
        strsql = "select [Payment_ID] , [Customer_ID] , [Cu_HP] , [Payment_Total] , [Payment_Type] , [Order_Status] , [Cu_Remark] , [Cu_Office_Inasis] , [Cu_Block_Room] from Payment where [Rider_ID] = '" & txtRiderID.Text & "'"
        Dim cmd As New OleDbCommand(strsql, con)
        Dim myreader As OleDbDataReader
        myreader = cmd.ExecuteReader
        myreader.Read()

        txtPaymentID.Text = myreader("Payment_ID")
        txtCustomerID.Text = myreader("Customer_ID")
        txtCustomerHP.Text = myreader("Cu_HP")
        txtTotalPrice.Text = Format(myreader("Payment_Total"), "0.00")
        txtPaymentType.Text = myreader("Payment_Type")
        txtOrderStatus.Text = myreader("Order_Status")
        txtCuRemark.Text = myreader("Cu_Remark")
        txtOfficeInasis.Text = myreader("Cu_Office_Inasis")
        txtBlockRoom.Text = myreader("Cu_Block_Room")

        CustomerOrderBindingSource.Filter = "Payment_ID LIKE '" & txtPaymentID.Text & "'"

        con.Close()

    End Sub


    Private Sub cmdDelivered_Click(sender As Object, e As EventArgs) Handles cmdDelivered.Click

        If txtPaymentID.Text = String.Empty Then
            MsgBox("Please check your duty first.", MessageBoxIcon.Information, "UUM Cafe YAB")

        Else
            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Access Database\UUMCafeDatabase5.accdb"
            con.Open()


            Dim strsql As String
            strsql = "SELECT [Delivered_Time] FROM Payment WHERE [Payment_ID] = '" & txtPaymentID.Text & "'"
            Dim cmd As New OleDbCommand(strsql, con)
            Dim myreader As OleDbDataReader
            myreader = cmd.ExecuteReader()
            myreader.Read()

            'dateDeliverTime.Value = myreader("Delivered_Time")

            If myreader IsNot DBNull.Value Then

                dateDeliverTime.Value = DateTime.Now

                pro = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Access Database\UUMCafeDatabase5.accdb"
                connstring = pro
                myconnection.ConnectionString = connstring
                myconnection.Open()

                commmand = "UPDATE Payment SET [Delivered_Time] = '" & dateDeliverTime.Value & "' where [Payment_ID] = '" & txtPaymentID.Text & "'"

                Dim command As OleDbCommand = New OleDbCommand(commmand, myconnection)

                command.ExecuteNonQuery()

                myreader.Close()
                myconnection.Close()
                con.Close()

                MsgBox("Done delivering and updated in the system. Contact the staff if you have accidentally pressed this button.", MessageBoxIcon.Information, "UUM Cafe YAB")

            Else

                MsgBox("You have deliviered this payment, contact the staff if error.", MessageBoxIcon.Error, "UUM Cafe YAB")
                myreader.Close()
                con.Close()

            End If

        End If

    End Sub

    Private Sub cmdLogout_Click(sender As Object, e As EventArgs) Handles cmdLogout.Click
        Dim user_respond As Integer
        user_respond = MessageBox.Show("Are you sure to log out?", "LOGOUT?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If user_respond = vbYes Then
            Me.Close()
            frmLogin.Show()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim user_respond As Integer
        user_respond = MessageBox.Show("Are you sure to exit the application?", "EXIT?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If user_respond = vbYes Then
            MessageBox.Show("Thank you for using our application." & vbNewLine & "We hope to see you again!", "BYE~")
            Application.Exit()
        End If
    End Sub
End Class