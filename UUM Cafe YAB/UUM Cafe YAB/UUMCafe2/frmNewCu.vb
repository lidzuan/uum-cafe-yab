Imports System.Data.OleDb

Public Class frmNewCu
    Dim pro As String
    Dim connstring As String
    Dim commmand As String
    Dim myconnection As OleDbConnection = New OleDbConnection

    Private Sub cmdAddNew_Click(sender As Object, e As EventArgs) Handles cmdAddNew.Click
        pro = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Access Database\UUMCafeDatabase5.accdb"
        connstring = pro
        myconnection.ConnectionString = connstring
        myconnection.Open()

        commmand = "insert into Customer ([Customer_ID] , [Cu_Name], [Cu_Email] , [Cu_HP] , [Reg_Date] , [Cu_Status]) values ('" & txtCuID.Text & "','" & txtCuName.Text & "','" & txtCuEmail.Text & "','" & txtCuHP.Text & "','" & txtCuRegistration.Value & "','" & txtCuStatus.Text & "')"
        Dim cmddetail As OleDbCommand = New OleDbCommand(commmand, myconnection)
        cmddetail.Parameters.Add(New OleDbParameter("Customer_ID", CType(txtCuID.Text, String)))
        cmddetail.Parameters.Add(New OleDbParameter("Cu_Name", CType(txtCuName.Text, String)))
        cmddetail.Parameters.Add(New OleDbParameter("Cu_Email", CType(txtCuEmail.Text, String)))
        cmddetail.Parameters.Add(New OleDbParameter("Cu_HP", CType(txtCuHP.Text, String)))
        cmddetail.Parameters.Add(New OleDbParameter("Reg_Date", CType(txtCuRegistration.Value, Date)))
        cmddetail.Parameters.Add(New OleDbParameter("Cu_Status", CType(txtCuStatus.Text, String)))

        cmddetail.ExecuteNonQuery()

        commmand = "insert into CustomerAccount ([Customer_ID] , [Cu_Name], [Cu_Username] , [Cu_Password]) values ('" & txtCuID.Text & "','" & txtCuName.Text & " ','" & txtCuUsername.Text & "','" & txtCuPassword.Text & "')"
        Dim cmdcuacc As OleDbCommand = New OleDbCommand(commmand, myconnection)
        cmdcuacc.Parameters.Add(New OleDbParameter("Customer_ID", CType(txtCuID.Text, String)))
        cmdcuacc.Parameters.Add(New OleDbParameter("Cu_Name", CType(txtCuName.Text, String)))
        cmdcuacc.Parameters.Add(New OleDbParameter("Cu_Username", CType(txtCuUsername.Text, String)))
        cmdcuacc.Parameters.Add(New OleDbParameter("Cu_Password", CType(txtCuPassword.Text, String)))

        MsgBox("Register Successful!")
        frmLogin.Show()

        Try
            cmdcuacc.ExecuteNonQuery()
            cmdcuacc.Dispose()

            myconnection.Close()
            txtCuID.Clear()
            txtCuName.Clear()
            txtCuUsername.Clear()
            txtCuPassword.Clear()
            txtCuEmail.Clear()
            txtCuHP.Clear()
            txtCuStatus.Text = String.Empty
            txtCuRegistration.Value = DateTime.Now


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
        frmLogin.Show()
    End Sub
End Class