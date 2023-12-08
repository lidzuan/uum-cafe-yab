Imports System.Data.OleDb
Public Class frmPayment
    Dim pro As String
    Dim connstring As String
    Dim commmand As String
    Dim myconnection As OleDbConnection = New OleDbConnection


    Private Sub frmPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstPlaceOrderCheck.DataSource = (frmOrder.lstPlaceOrderCheck.Items)
        txtCustomerID.Text = frmOrder.txtCustomerID.Text
        txtPaymentID.Text = frmOrder.txtPaymentID.Text
        txtCuHp.Text = frmLogin.txtCuHP.Text
        txtSubTotal.Text = Val(frmOrder.txtTotalPrice.Text)
        dateOrderDate.Value = DateTime.Now
        dateOrderTime.Value = DateTime.Now
    End Sub

    Private Sub cmdPromoCodeActivation_Click(sender As Object, e As EventArgs) Handles cmdPromoCodeActivation.Click
        If txtOrderType.Text = "Delivery" Then
            txtDeliveryFee.Text = Val(1.0)
        Else
            txtDeliveryFee.Text = Val(0.00)
        End If

        Dim SubTotalPrice As Single
        SubTotalPrice = Val(txtSubTotal.Text)

        Dim DeliveryFee As Single
        DeliveryFee = Val(txtDeliveryFee.Text)

        Dim TotalPrice As Single
        TotalPrice = Val(txtTotalPrice.Text)

        TotalPrice = Format(SubTotalPrice + DeliveryFee, "0.00")

        If txtPromoCode.Text = "NEWREG" Then
            TotalPrice = TotalPrice * 0.5
        End If

        If txtPromoCode.Text = "NEWYEAR" Then
            TotalPrice = TotalPrice * 0.65
        End If

        If txtPromoCode.Text = "EATINGDEALS" Then
            TotalPrice = TotalPrice * 0.8
        End If

        If txtPromoCode.Text = "HAPPYMEAL" Then
            TotalPrice = TotalPrice * 0.85
        End If

        If txtPromoCode.Text = "HAPPYMEAL" Then
            TotalPrice = TotalPrice * 0.85
        End If

        If txtPromoCode.Text = "PICKUP" Then
            TotalPrice = TotalPrice * 0.9
        End If

        txtFinalPrice1.Text = ("Promo Code: " & txtPromoCode.Text)
        txtFinalPrice2.Text = ("Your final price is: RM" & TotalPrice)
        txtTotalPrice.Text = TotalPrice
    End Sub

    Private Sub cmdConfirmPayment_Click(sender As Object, e As EventArgs) Handles cmdConfirmPayment.Click

        If txtOrderType.SelectedIndex = -1 Then
            MsgBox("Are you prefer to dine in, take away, or delivering?", MessageBoxIcon.Question, "UUM Cafe YAB")

        ElseIf txtPaymentType.SelectedIndex = -1 Then
            MsgBox("Please choose your payment type.", MessageBoxIcon.Question, "UUM Cafe YAB")



        Else
            If txtPromoCode.Text = String.Empty Then
                txtPromoCode.Text = "N/A"
            Else
                txtPromoCode.Text = txtPromoCode.Text
            End If

            If txtCuRemark.Text = String.Empty Then
                txtCuRemark.Text = "N/A"
            Else
                txtCuRemark.Text = txtCuRemark.Text
            End If

            If txtOfficeInasis.Text = String.Empty Then
                txtOfficeInasis.Text = "N/A"
            Else
                txtOfficeInasis.Text = txtOfficeInasis.Text
            End If

            If txtBlockRoom.Text = String.Empty Then
                txtBlockRoom.Text = "N/A"
            Else
                txtBlockRoom.Text = txtBlockRoom.Text
            End If

            txtOrderStatus.Text = "Kitchen preparing"

            Dim SubTotalPrice As Single
            SubTotalPrice = Val(txtSubTotal.Text)

            Dim DeliveryFee As Single
            DeliveryFee = Val(txtDeliveryFee.Text)

            If txtDeliveryFee.Text = String.Empty Then
                txtDeliveryFee.Text = 0
            End If

            Dim TotalPrice As Single
            TotalPrice = Val(txtTotalPrice.Text)

            TotalPrice = Format(SubTotalPrice + DeliveryFee, "0.00")
            txtTotalPrice.Text = TotalPrice

            pro = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Access Database\UUMCafeDatabase5.accdb"
            connstring = pro
            myconnection.ConnectionString = connstring
            myconnection.Open()

            commmand = "UPDATE Payment SET [Customer_ID] = '" & txtCustomerID.Text & "' , [Cu_HP] = '" & txtCuHp.Text & "' , [Promo_Code] = '" & txtPromoCode.Text & "' , [Order_Type] = '" & txtOrderType.Text & "' , [Payment_SubTotal] = '" & Val(txtSubTotal.Text) & "' , [Delivery_Fee] = '" & Val(txtDeliveryFee.Text) & "' , [Payment_Total] = '" & Val(txtTotalPrice.Text) & "' , [Payment_Type] = '" & txtPaymentType.Text & "' , [Payment_Date] = '" & dateOrderDate.Value & "' , [Payment_Time] = '" & dateOrderTime.Value & "' , [Cu_Remark] = '" & txtCuRemark.Text & "' , [Cu_Office_Inasis] = '" & txtOfficeInasis.Text & "' , [Cu_Block_Room] = '" & txtBlockRoom.Text & "' , [Order_Status] = '" & txtOrderType.Text & "' where [Payment_ID] = '" & txtPaymentID.Text & "'"

            Dim cmd As OleDbCommand = New OleDbCommand(commmand, myconnection)

            cmd.ExecuteNonQuery()
            cmd.Dispose()

            myconnection.Close()

            txtCustomerID.Text = ""
            txtPromoCode.Clear()
            txtOrderType.Text = String.Empty
            txtSubTotal.Clear()
            txtDeliveryFee.Clear()
            txtTotalPrice.Clear()
            txtDeliveryFee.Clear()
            txtPaymentType.Text = String.Empty
            dateOrderDate.Value = DateTime.Now
            dateOrderTime.Value = DateTime.Now
            txtCuRemark.Clear()

            MsgBox("Thank you! Your payment code is " & txtPaymentID.Text & ". Take note as you reference later.", MessageBoxIcon.Information, "UUM Cafe YAB")

            Me.Hide()
            frmCustMainMenu.Show()

        End If

    End Sub

    'Cancel order
    Private Sub cmdBack_Click(sender As Object, e As EventArgs) Handles cmdBack.Click
        Dim confirm_cancel As Integer =
            MessageBox.Show("Are you sure you want to cancel this order?", "UUM Cafe YAB", MessageBoxButtons.YesNo)
        If confirm_cancel = DialogResult.Yes Then
            pro = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Access Database\UUMCafeDatabase5.accdb"
            connstring = pro
            myconnection.ConnectionString = connstring
            myconnection.Open()

            commmand = "DELETE FROM Payment where [Payment_ID] = '" & txtPaymentID.Text & "'"

            Dim cmd As OleDbCommand = New OleDbCommand(commmand, myconnection)

            cmd.ExecuteNonQuery()
            cmd.Dispose()

            myconnection.Close()

            MsgBox("Your order: " & txtPaymentID.Text & " has been deleted.", MessageBoxIcon.Information, "UUM Cafe YAB")
            Me.Hide()
            frmCustMainMenu.Show()

        End If
    End Sub
End Class