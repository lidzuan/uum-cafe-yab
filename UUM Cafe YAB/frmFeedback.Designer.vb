<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFeedback
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtCustName = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCustID = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPaymentID = New System.Windows.Forms.TextBox()
        Me.txtComment = New System.Windows.Forms.TextBox()
        Me.txtRate = New System.Windows.Forms.ComboBox()
        Me.cmdSubmit = New System.Windows.Forms.Button()
        Me.dateFdbDate = New System.Windows.Forms.DateTimePicker()
        Me.cmdBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtCustName
        '
        Me.txtCustName.AutoSize = True
        Me.txtCustName.BackColor = System.Drawing.Color.Transparent
        Me.txtCustName.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustName.ForeColor = System.Drawing.Color.Navy
        Me.txtCustName.Location = New System.Drawing.Point(29, 32)
        Me.txtCustName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.txtCustName.Name = "txtCustName"
        Me.txtCustName.Size = New System.Drawing.Size(128, 24)
        Me.txtCustName.TabIndex = 0
        Me.txtCustName.Text = "(txtCustName)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 65)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(412, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Is there anything we can help you?"
        '
        'txtCustID
        '
        Me.txtCustID.AutoSize = True
        Me.txtCustID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustID.Location = New System.Drawing.Point(480, 312)
        Me.txtCustID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.txtCustID.Name = "txtCustID"
        Me.txtCustID.Size = New System.Drawing.Size(86, 20)
        Me.txtCustID.TabIndex = 2
        Me.txtCustID.Text = "(txtCustID)"
        Me.txtCustID.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(34, 131)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Your payment ID:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(112, 157)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Rate:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(47, 185)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Your comment:"
        '
        'txtPaymentID
        '
        Me.txtPaymentID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPaymentID.Location = New System.Drawing.Point(164, 128)
        Me.txtPaymentID.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtPaymentID.Name = "txtPaymentID"
        Me.txtPaymentID.Size = New System.Drawing.Size(159, 22)
        Me.txtPaymentID.TabIndex = 6
        '
        'txtComment
        '
        Me.txtComment.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComment.Location = New System.Drawing.Point(164, 182)
        Me.txtComment.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtComment.Multiline = True
        Me.txtComment.Name = "txtComment"
        Me.txtComment.Size = New System.Drawing.Size(331, 108)
        Me.txtComment.TabIndex = 7
        '
        'txtRate
        '
        Me.txtRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRate.FormattingEnabled = True
        Me.txtRate.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.txtRate.Location = New System.Drawing.Point(164, 154)
        Me.txtRate.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Size = New System.Drawing.Size(159, 24)
        Me.txtRate.TabIndex = 8
        '
        'cmdSubmit
        '
        Me.cmdSubmit.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSubmit.Location = New System.Drawing.Point(164, 320)
        Me.cmdSubmit.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdSubmit.Name = "cmdSubmit"
        Me.cmdSubmit.Size = New System.Drawing.Size(118, 50)
        Me.cmdSubmit.TabIndex = 9
        Me.cmdSubmit.Text = "SUBMIT"
        Me.cmdSubmit.UseVisualStyleBackColor = False
        '
        'dateFdbDate
        '
        Me.dateFdbDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateFdbDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateFdbDate.Location = New System.Drawing.Point(413, 344)
        Me.dateFdbDate.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.dateFdbDate.Name = "dateFdbDate"
        Me.dateFdbDate.Size = New System.Drawing.Size(151, 26)
        Me.dateFdbDate.TabIndex = 10
        Me.dateFdbDate.Visible = False
        '
        'cmdBack
        '
        Me.cmdBack.BackColor = System.Drawing.Color.Transparent
        Me.cmdBack.BackgroundImage = Global.UUMCafe2.My.Resources.Resources.homeicon
        Me.cmdBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdBack.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmdBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBack.Location = New System.Drawing.Point(511, 25)
        Me.cmdBack.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdBack.Name = "cmdBack"
        Me.cmdBack.Size = New System.Drawing.Size(53, 49)
        Me.cmdBack.TabIndex = 11
        Me.cmdBack.UseVisualStyleBackColor = False
        '
        'frmFeedback
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.UUMCafe2.My.Resources.Resources.background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(600, 398)
        Me.Controls.Add(Me.cmdBack)
        Me.Controls.Add(Me.dateFdbDate)
        Me.Controls.Add(Me.cmdSubmit)
        Me.Controls.Add(Me.txtRate)
        Me.Controls.Add(Me.txtComment)
        Me.Controls.Add(Me.txtPaymentID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCustID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCustName)
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "frmFeedback"
        Me.Text = "Feedback"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCustName As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCustID As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPaymentID As TextBox
    Friend WithEvents txtComment As TextBox
    Friend WithEvents txtRate As ComboBox
    Friend WithEvents cmdSubmit As Button
    Friend WithEvents dateFdbDate As DateTimePicker
    Friend WithEvents cmdBack As Button
End Class
