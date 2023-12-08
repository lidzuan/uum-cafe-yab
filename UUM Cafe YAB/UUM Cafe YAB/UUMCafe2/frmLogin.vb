Imports System.Data.OleDb
Public Class frmLogin
    Dim con As New OleDbConnection
    Dim mouse_click As Integer

    'Login
    Private Sub cmdLogin_Click(sender As Object, e As EventArgs) Handles cmdLogin.Click

        mouse_click = mouse_click + 1

        If mouse_click <= 3 Then
            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Access Database\UUMCafeDatabase5.accdb"
            con.Open()

            If txtComboBox.Text = "Customer" Then
                Dim strsql As String
                strsql = "select Customer_ID, Cu_Name , Cu_HP from Customer'"
                Dim cmd As New OleDbCommand(strsql, con)
                Dim myreader As OleDbDataReader
                myreader = cmd.ExecuteReader
                myreader.Read()

                txtCustomerID.Text = myreader("Customer_ID")
                txtCustomerName.Text = myreader("Cu_Name")
                txtCuHP.Text = myreader("Cu_HP")


                Dim logincmd As OleDbCommand = New OleDbCommand("Select Cu_Username, Cu_Password from CustomerAccount Where [Cu_Username]='" & txtLogin.Text & "'and[Cu_Password]='" & txtPassword.Text & "'", con)
                Dim loginID As OleDbDataReader = logincmd.ExecuteReader
                If (loginID.Read() = True) Then

                    Me.Hide()
                    MsgBox("Login Succeeded!", MessageBoxIcon.Information, "UUM Cafe YAB")
                    frmCustMainMenu.Show()
                Else
                    MsgBox("Login Fails!", MessageBoxIcon.Exclamation, "UUM Cafe YAB")
                End If

            End If

            If txtComboBox.Text = "Staff" Then
                Dim strsql As String
                strsql = "select Staff_ID, Staff_Name from StaffAccount Where [Staff_Username]='" & txtLogin.Text & "'and[Staff_Password]='" & txtPassword.Text & "'"
                Dim cmd As New OleDbCommand(strsql, con)
                Dim myreader As OleDbDataReader
                myreader = cmd.ExecuteReader
                myreader.Read()

                txtStaffID.Text = myreader("Staff_ID")
                txtStaffName.Text = myreader("Staff_Name")


                Dim logincmd As OleDbCommand = New OleDbCommand("Select Staff_Username, Staff_Password from StaffAccount Where [Staff_Username]='" & txtLogin.Text & "'and[Staff_Password]='" & txtPassword.Text & "'", con)
                Dim loginID As OleDbDataReader = logincmd.ExecuteReader
                If (loginID.Read() = True) Then
                    Me.Hide()
                    MsgBox("Login Succeeded!", MessageBoxIcon.Information, "UUM Cafe YAB")
                    frmStaff.Show()
                Else
                    MsgBox("Login Fails!", MessageBoxIcon.Exclamation, "UUM Cafe YAB")
                End If

            End If

            If txtComboBox.Text = "Rider" Then
                Dim strsql As String
                strsql = "select Rider_ID from RiderAccount Where [Rider_Username]='" & txtLogin.Text & "'and[Rider_Password]='" & txtPassword.Text & "'"
                Dim cmd As New OleDbCommand(strsql, con)
                Dim myreader As OleDbDataReader
                myreader = cmd.ExecuteReader
                myreader.Read()

                txtRiderID.Text = myreader("Rider_ID")

                Dim logincmd As OleDbCommand = New OleDbCommand("Select Rider_Username, Rider_Password from RiderAccount Where [Rider_Username]='" & txtLogin.Text & "'and[Rider_Password]='" & txtPassword.Text & "'", con)
                Dim loginID As OleDbDataReader = logincmd.ExecuteReader
                If (loginID.Read() = True) Then
                    Me.Hide()
                    MsgBox("Login Succeeded!", MessageBoxIcon.Information, "UUM Cafe YAB")
                    frmRiderDuty.Show()
                Else
                    MsgBox("Login Fails!", MessageBoxIcon.Exclamation, "UUM Cafe YAB")
                End If

            End If
            con.Close()

        Else
            MsgBox("You have typed wrong 3 times, please contact us. 011-12459638. System is closing now.", MessageBoxIcon.Exclamation, "UUM Cafe YAB")
            Me.Close()
        End If


    End Sub

    'New Customer
    Private Sub cmdNewCu_Click(sender As Object, e As EventArgs) Handles cmdNewCu.Click
        Me.Hide()
        frmNewCu.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        frmWelcome.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If txtPassword.UseSystemPasswordChar = True Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
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
