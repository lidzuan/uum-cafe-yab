<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtLogin = New System.Windows.Forms.TextBox()
        Me.cmdLogin = New System.Windows.Forms.Button()
        Me.cmdNewCu = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtComboBox = New System.Windows.Forms.ComboBox()
        Me.txtCustomerID = New System.Windows.Forms.TextBox()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.txtCuHP = New System.Windows.Forms.TextBox()
        Me.txtRiderID = New System.Windows.Forms.TextBox()
        Me.txtStaffName = New System.Windows.Forms.TextBox()
        Me.txtStaffID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(130, 188)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "I'm a: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(76, 259)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Username:"
        '
        'txtLogin
        '
        Me.txtLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLogin.Location = New System.Drawing.Point(210, 254)
        Me.txtLogin.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtLogin.Name = "txtLogin"
        Me.txtLogin.Size = New System.Drawing.Size(309, 35)
        Me.txtLogin.TabIndex = 3
        '
        'cmdLogin
        '
        Me.cmdLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLogin.Location = New System.Drawing.Point(260, 405)
        Me.cmdLogin.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdLogin.Name = "cmdLogin"
        Me.cmdLogin.Size = New System.Drawing.Size(150, 56)
        Me.cmdLogin.TabIndex = 4
        Me.cmdLogin.Text = "LOGIN"
        Me.cmdLogin.UseVisualStyleBackColor = False
        '
        'cmdNewCu
        '
        Me.cmdNewCu.BackColor = System.Drawing.Color.Transparent
        Me.cmdNewCu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmdNewCu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdNewCu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNewCu.Location = New System.Drawing.Point(252, 500)
        Me.cmdNewCu.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdNewCu.Name = "cmdNewCu"
        Me.cmdNewCu.Size = New System.Drawing.Size(164, 40)
        Me.cmdNewCu.TabIndex = 5
        Me.cmdNewCu.Text = "New Customer?"
        Me.cmdNewCu.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(86, 332)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 29)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Password:"
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(210, 328)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(309, 35)
        Me.txtPassword.TabIndex = 7
        '
        'txtComboBox
        '
        Me.txtComboBox.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComboBox.FormattingEnabled = True
        Me.txtComboBox.Items.AddRange(New Object() {"Customer", "Staff", "Rider"})
        Me.txtComboBox.Location = New System.Drawing.Point(210, 184)
        Me.txtComboBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtComboBox.Name = "txtComboBox"
        Me.txtComboBox.Size = New System.Drawing.Size(200, 37)
        Me.txtComboBox.TabIndex = 8
        '
        'txtCustomerID
        '
        Me.txtCustomerID.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerID.Location = New System.Drawing.Point(658, 14)
        Me.txtCustomerID.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCustomerID.Name = "txtCustomerID"
        Me.txtCustomerID.Size = New System.Drawing.Size(178, 39)
        Me.txtCustomerID.TabIndex = 9
        Me.txtCustomerID.Visible = False
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerName.Location = New System.Drawing.Point(658, 84)
        Me.txtCustomerName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(178, 39)
        Me.txtCustomerName.TabIndex = 10
        Me.txtCustomerName.Visible = False
        '
        'txtCuHP
        '
        Me.txtCuHP.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuHP.Location = New System.Drawing.Point(658, 154)
        Me.txtCuHP.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCuHP.Name = "txtCuHP"
        Me.txtCuHP.Size = New System.Drawing.Size(178, 39)
        Me.txtCuHP.TabIndex = 11
        Me.txtCuHP.Visible = False
        '
        'txtRiderID
        '
        Me.txtRiderID.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRiderID.Location = New System.Drawing.Point(658, 224)
        Me.txtRiderID.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtRiderID.Name = "txtRiderID"
        Me.txtRiderID.Size = New System.Drawing.Size(178, 39)
        Me.txtRiderID.TabIndex = 12
        '
        'txtStaffName
        '
        Me.txtStaffName.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStaffName.Location = New System.Drawing.Point(658, 364)
        Me.txtStaffName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtStaffName.Name = "txtStaffName"
        Me.txtStaffName.Size = New System.Drawing.Size(178, 39)
        Me.txtStaffName.TabIndex = 13
        '
        'txtStaffID
        '
        Me.txtStaffID.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStaffID.Location = New System.Drawing.Point(658, 294)
        Me.txtStaffID.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtStaffID.Name = "txtStaffID"
        Me.txtStaffID.Size = New System.Drawing.Size(178, 39)
        Me.txtStaffID.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Georgia", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(137, 561)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(402, 81)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Feel free to contact us for any enquiries:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "UUM Cafe YAB" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "011-12459638"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(124, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(486, 58)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Select your account category," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "then enter your username and password."
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.UUMCafe2.My.Resources.Resources.back
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Transparent
        Me.Button1.Location = New System.Drawing.Point(40, 28)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(47, 46)
        Me.Button1.TabIndex = 17
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Button2.BackgroundImage = Global.UUMCafe2.My.Resources.Resources.eye
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(539, 331)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(35, 35)
        Me.Button2.TabIndex = 18
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.BackgroundImage = Global.UUMCafe2.My.Resources.Resources._exit
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.Lavender
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(555, 19)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(68, 64)
        Me.Button3.TabIndex = 19
        Me.Button3.UseVisualStyleBackColor = False
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.UUMCafe2.My.Resources.Resources.food
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(647, 682)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtStaffID)
        Me.Controls.Add(Me.txtStaffName)
        Me.Controls.Add(Me.txtRiderID)
        Me.Controls.Add(Me.txtCuHP)
        Me.Controls.Add(Me.txtCustomerName)
        Me.Controls.Add(Me.txtCustomerID)
        Me.Controls.Add(Me.txtComboBox)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmdNewCu)
        Me.Controls.Add(Me.cmdLogin)
        Me.Controls.Add(Me.txtLogin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmLogin"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtLogin As TextBox
    Friend WithEvents cmdLogin As Button
    Friend WithEvents cmdNewCu As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtComboBox As ComboBox
    Friend WithEvents txtCustomerID As TextBox
    Friend WithEvents txtCustomerName As TextBox
    Friend WithEvents txtCuHP As TextBox
    Friend WithEvents txtRiderID As TextBox
    Friend WithEvents txtStaffName As TextBox
    Friend WithEvents txtStaffID As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
