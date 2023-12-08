Public Class frmCustMainMenu
    Private Sub cmdOrder_Click(sender As Object, e As EventArgs) Handles cmdOrder.Click
        Me.Hide()
        frmOrder.Show()
    End Sub

    Private Sub cmdTracking_Click(sender As Object, e As EventArgs) Handles cmdTracking.Click
        Me.Hide()
        frmTracking.Show()
    End Sub

    Private Sub cmdFeedback_Click(sender As Object, e As EventArgs) Handles cmdFeedback.Click
        Me.Hide()
        frmFeedback.Show()
    End Sub

    Private Sub cmdLogout_Click(sender As Object, e As EventArgs) Handles cmdLogout.Click
        Dim user_respond As Integer
        user_respond = MessageBox.Show("Are you sure to log out?", "LOGOUT?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If user_respond = vbYes Then
            Me.Hide()
            frmLogin.Show()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim user_respond As Integer
        user_respond = MessageBox.Show("Are you sure to exit the application?", "EXIT?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If user_respond = vbYes Then
            MessageBox.Show("Thank you for using our application." & vbNewLine & "We hope to see you again!", "BYE~")
            Application.Exit()
        End If
    End Sub
End Class