Imports System.Data.OleDb
Public Class frmStaff
    Dim pro As String
    Dim connstring As String
    Dim commmand As String
    Dim myconnection As OleDbConnection = New OleDbConnection

    Private Sub cmdStaffRecord_Click(sender As Object, e As EventArgs) Handles cmdCustomerOrder.Click
        pnlOnPosition.Height = cmdCustomerOrder.Height
        pnlOnPosition.Top = cmdCustomerOrder.Top
        pnlCustomerOrder.Visible = True
        pnlRiderDuty.Visible = False
    End Sub

    Private Sub cmdRiderDuty_Click(sender As Object, e As EventArgs) Handles cmdRiderDuty.Click
        pnlOnPosition.Height = cmdRiderDuty.Height
        pnlOnPosition.Top = cmdRiderDuty.Top
        pnlCustomerOrder.Visible = False
        pnlRiderDuty.Visible = True
    End Sub

    Private Sub frmStaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'UUMCafeDatabase5DataSet.Payment' table. You can move, or remove it, as needed.
        Me.PaymentTableAdapter.Fill(Me.UUMCafeDatabase5DataSet.Payment)
        'TODO: This line of code loads data into the 'UUMCafeDatabase5DataSet.CustomerOrder' table. You can move, or remove it, as needed.
        Me.CustomerOrderTableAdapter.Fill(Me.UUMCafeDatabase5DataSet.CustomerOrder)

        txtStaffNameID.Text = (frmLogin.txtStaffName.Text) & ", " & (frmLogin.txtStaffID.Text)
    End Sub

    Private Sub CustomerOrderBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CustomerOrderBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CustomerOrderBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.UUMCafeDatabase5DataSet)

    End Sub

    'Customer Order
    Private Sub cmdFilterPaymentID_Click(sender As Object, e As EventArgs) Handles cmdFilterPaymentID.Click
        CustomerOrderBindingSource.Filter = "Payment_ID LIKE'" & txtPaymentID.Text & "'"
    End Sub

    Private Sub cmdFilterOrderNum_Click(sender As Object, e As EventArgs) Handles cmdFilterOrderNum.Click
        CustomerOrderBindingSource.Filter = "[Order_Num] ='" & txtOrderNum.Text & "'"
    End Sub

    Private Sub cmdFilterCustomerID_Click(sender As Object, e As EventArgs) Handles cmdFilterCustomerID.Click
        CustomerOrderBindingSource.Filter = "[Customer_ID] ='" & txtCustomerID.Text & "'"
    End Sub

    Private Sub cmdFilterCustomerName_Click(sender As Object, e As EventArgs) Handles cmdFilterCustomerName.Click
        CustomerOrderBindingSource.Filter = "[Customer_Name] ='" & txtCustomerName.Text & "'"
    End Sub

    Private Sub cmdFilterItemMenu_Click(sender As Object, e As EventArgs) Handles cmdFilterItemMenu.Click
        CustomerOrderBindingSource.Filter = "[Item_Menu] ='" & txtItemMenu.Text & "'"
    End Sub

    Private Sub cmdClearFilter_Click(sender As Object, e As EventArgs) Handles cmdClearFilter.Click
        CustomerOrderBindingSource.RemoveFilter()
    End Sub

    Private Sub cmdMoveFirst1_Click(sender As Object, e As EventArgs) Handles cmdMoveFirst1.Click
        CustomerOrderBindingSource.MoveFirst()
    End Sub

    Private Sub cmdMovePrevious1_Click(sender As Object, e As EventArgs) Handles cmdMovePrevious1.Click
        CustomerOrderBindingSource.MovePrevious()
    End Sub

    Private Sub cmdMoveNext1_Click(sender As Object, e As EventArgs) Handles cmdMoveNext1.Click
        CustomerOrderBindingSource.MoveNext()
    End Sub

    Private Sub cmdMoveLast1_Click(sender As Object, e As EventArgs) Handles cmdMoveLast1.Click
        CustomerOrderBindingSource.MoveLast()
    End Sub

    Private Sub cmdAdd1_Click(sender As Object, e As EventArgs) Handles cmdAdd1.Click
        If cmdAdd1.Text = "ADD" Then
            cmdMoveFirst1.Hide()
            cmdMovePrevious1.Hide()
            cmdMoveNext1.Hide()
            cmdMoveLast1.Hide()
            cmdEdit1.Hide()
            cmdDelete1.Hide()
            cmdClearFilter.Hide()
            cmdFilterPaymentID.Hide()
            cmdFilterOrderNum.Hide()
            cmdFilterCustomerID.Hide()
            cmdFilterCustomerName.Hide()
            cmdFilterItemMenu.Hide()
            cmdRiderDuty.Hide()
            CustomerOrderBindingSource.AddNew()
            cmdAdd1.Text = "SAVE NEW"
        Else
            CustomerOrderBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(UUMCafeDatabase5DataSet)
            CustomerOrderBindingSource.MoveFirst()
            cmdAdd1.Text = "ADD"
            cmdMoveFirst1.Show()
            cmdMovePrevious1.Show()
            cmdMoveNext1.Show()
            cmdMoveLast1.Show()
            cmdEdit1.Show()
            cmdDelete1.Show()
            cmdClearFilter.Show()
            cmdFilterPaymentID.Show()
            cmdFilterOrderNum.Show()
            cmdFilterCustomerID.Show()
            cmdFilterCustomerName.Show()
            cmdFilterItemMenu.Show()
            cmdRiderDuty.Show()
        End If
    End Sub

    Private Sub cmdEdit1_Click(sender As Object, e As EventArgs) Handles cmdEdit1.Click
        If cmdEdit1.Text = "EDIT" Then
            cmdMoveFirst1.Hide()
            cmdMovePrevious1.Hide()
            cmdMoveNext1.Hide()
            cmdMoveLast1.Hide()
            cmdAdd1.Hide()
            cmdDelete1.Hide()
            cmdClearFilter.Hide()
            cmdFilterPaymentID.Hide()
            cmdFilterOrderNum.Hide()
            cmdFilterCustomerID.Hide()
            cmdFilterCustomerName.Hide()
            cmdFilterItemMenu.Hide()
            cmdRiderDuty.Hide()
            cmdEdit1.Text = "SAVE"
        Else
            CustomerOrderBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(UUMCafeDatabase5DataSet)
            CustomerOrderBindingSource.MoveFirst()
            cmdEdit1.Text = "EDIT"
            cmdMoveFirst1.Show()
            cmdMovePrevious1.Show()
            cmdMoveNext1.Show()
            cmdMoveLast1.Show()
            cmdAdd1.Show()
            cmdDelete1.Show()
            cmdClearFilter.Show()
            cmdFilterPaymentID.Show()
            cmdFilterOrderNum.Show()
            cmdFilterCustomerID.Show()
            cmdFilterCustomerName.Show()
            cmdFilterItemMenu.Show()
            cmdRiderDuty.Show()
        End If
    End Sub

    Private Sub cmdDelete1_Click(sender As Object, e As EventArgs) Handles cmdDelete1.Click
        Dim user_respond As Integer

        user_respond = MessageBox.Show("Are you sure to delete this order? Reminder that this cannot be undone once deleted.", "DELETE?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If user_respond = vbYes Then
            CustomerOrderBindingSource.RemoveCurrent()
            TableAdapterManager.UpdateAll(UUMCafeDatabase5DataSet)
        End If
    End Sub

    'Rider Duty
    Private Sub cmdDeliveryFilter_Click(sender As Object, e As EventArgs) Handles cmdDeliveryFilter.Click
        PaymentBindingSource.Filter = "Order_Type LIKE '" & txtDelivery.Text & "'"
    End Sub

    Private Sub cmdClearDeliveryFilter_Click(sender As Object, e As EventArgs) Handles cmdClearDeliveryFilter.Click
        PaymentBindingSource.RemoveFilter()
    End Sub

    Private Sub cmdUpdate_Click(sender As Object, e As EventArgs) Handles cmdUpdate.Click
        If txtPaymentID2.Text = String.Empty Then
            MsgBox("Please choose a payment ID for rider to be assigned.", MessageBoxIcon.Information, "UUM Cafe YAB")

        Else

            pro = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Access Database\UUMCafeDatabase5.accdb"
            connstring = pro
            myconnection.ConnectionString = connstring
            myconnection.Open()

            commmand = "UPDATE Payment SET [Rider_ID] = '" & txtRiderID.Text & "' where [Payment_ID] = '" & txtPaymentID2.Text & "'"

            Dim cmd As OleDbCommand = New OleDbCommand(commmand, myconnection)

            cmd.ExecuteNonQuery()
                cmd.Dispose()

                MsgBox("Done assign.", MessageBoxIcon.Information, "UUM Cafe YAB")

                myconnection.Close()
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

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Dim user_respond As Integer
        user_respond = MessageBox.Show("Are you sure to exit the application?", "EXIT?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If user_respond = vbYes Then
            Application.Exit()
        End If
    End Sub
End Class