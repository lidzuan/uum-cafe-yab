<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPayment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPayment))
        Me.dateOrderDate = New System.Windows.Forms.DateTimePicker()
        Me.dateOrderTime = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPromoCode = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtOrderType = New System.Windows.Forms.ComboBox()
        Me.txtSubTotal = New System.Windows.Forms.TextBox()
        Me.txtDeliveryFee = New System.Windows.Forms.TextBox()
        Me.txtTotalPrice = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPaymentType = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmdConfirmPayment = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCuRemark = New System.Windows.Forms.TextBox()
        Me.txtCustomerID = New System.Windows.Forms.Label()
        Me.lstPlaceOrderCheck = New System.Windows.Forms.ListBox()
        Me.txtPaymentID = New System.Windows.Forms.Label()
        Me.cmdPromoCodeActivation = New System.Windows.Forms.Button()
        Me.txtFinalPrice2 = New System.Windows.Forms.Label()
        Me.txtFinalPrice1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtOfficeInasis = New System.Windows.Forms.TextBox()
        Me.txtBlockRoom = New System.Windows.Forms.TextBox()
        Me.txtCuHp = New System.Windows.Forms.Label()
        Me.txtOrderStatus = New System.Windows.Forms.Label()
        Me.cmdBack = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dateOrderDate
        '
        Me.dateOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateOrderDate.Location = New System.Drawing.Point(43, 552)
        Me.dateOrderDate.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.dateOrderDate.Name = "dateOrderDate"
        Me.dateOrderDate.Size = New System.Drawing.Size(99, 20)
        Me.dateOrderDate.TabIndex = 2
        Me.dateOrderDate.Visible = False
        '
        'dateOrderTime
        '
        Me.dateOrderTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dateOrderTime.Location = New System.Drawing.Point(43, 575)
        Me.dateOrderTime.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.dateOrderTime.Name = "dateOrderTime"
        Me.dateOrderTime.Size = New System.Drawing.Size(99, 20)
        Me.dateOrderTime.TabIndex = 3
        Me.dateOrderTime.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("qtquickcontrols", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(42, 45)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Promo Code:"
        '
        'txtPromoCode
        '
        Me.txtPromoCode.Font = New System.Drawing.Font("qtquickcontrols", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPromoCode.Location = New System.Drawing.Point(133, 41)
        Me.txtPromoCode.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtPromoCode.Name = "txtPromoCode"
        Me.txtPromoCode.Size = New System.Drawing.Size(147, 25)
        Me.txtPromoCode.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("qtquickcontrols", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(62, 17)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Prefer To:"
        '
        'txtOrderType
        '
        Me.txtOrderType.Font = New System.Drawing.Font("qtquickcontrols", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrderType.FormattingEnabled = True
        Me.txtOrderType.Items.AddRange(New Object() {"Dine In", "Take Away", "Delivery"})
        Me.txtOrderType.Location = New System.Drawing.Point(133, 14)
        Me.txtOrderType.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtOrderType.Name = "txtOrderType"
        Me.txtOrderType.Size = New System.Drawing.Size(147, 25)
        Me.txtOrderType.TabIndex = 8
        '
        'txtSubTotal
        '
        Me.txtSubTotal.Location = New System.Drawing.Point(23, 401)
        Me.txtSubTotal.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.Size = New System.Drawing.Size(54, 20)
        Me.txtSubTotal.TabIndex = 9
        Me.txtSubTotal.Visible = False
        '
        'txtDeliveryFee
        '
        Me.txtDeliveryFee.Location = New System.Drawing.Point(23, 417)
        Me.txtDeliveryFee.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtDeliveryFee.Name = "txtDeliveryFee"
        Me.txtDeliveryFee.Size = New System.Drawing.Size(54, 20)
        Me.txtDeliveryFee.TabIndex = 10
        Me.txtDeliveryFee.Visible = False
        '
        'txtTotalPrice
        '
        Me.txtTotalPrice.Location = New System.Drawing.Point(23, 429)
        Me.txtTotalPrice.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtTotalPrice.Name = "txtTotalPrice"
        Me.txtTotalPrice.Size = New System.Drawing.Size(54, 20)
        Me.txtTotalPrice.TabIndex = 11
        Me.txtTotalPrice.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("qtquickcontrols", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(30, 71)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 17)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Payment Type:"
        '
        'txtPaymentType
        '
        Me.txtPaymentType.Font = New System.Drawing.Font("qtquickcontrols", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPaymentType.FormattingEnabled = True
        Me.txtPaymentType.Items.AddRange(New Object() {"Cash", "Online Banking", "DuitNow QR"})
        Me.txtPaymentType.Location = New System.Drawing.Point(133, 68)
        Me.txtPaymentType.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtPaymentType.Name = "txtPaymentType"
        Me.txtPaymentType.Size = New System.Drawing.Size(147, 25)
        Me.txtPaymentType.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(609, 278)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 80)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Online Banking:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1124 5612 7485" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Maybank" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "UUM Cafe YAB"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmdConfirmPayment
        '
        Me.cmdConfirmPayment.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdConfirmPayment.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdConfirmPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdConfirmPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdConfirmPayment.Location = New System.Drawing.Point(674, 482)
        Me.cmdConfirmPayment.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdConfirmPayment.Name = "cmdConfirmPayment"
        Me.cmdConfirmPayment.Size = New System.Drawing.Size(131, 67)
        Me.cmdConfirmPayment.TabIndex = 15
        Me.cmdConfirmPayment.Text = "CONFIRM"
        Me.cmdConfirmPayment.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("qtquickcontrols", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(10, 98)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 17)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Customer Remark:"
        '
        'txtCuRemark
        '
        Me.txtCuRemark.Font = New System.Drawing.Font("qtquickcontrols", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuRemark.Location = New System.Drawing.Point(133, 95)
        Me.txtCuRemark.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtCuRemark.Multiline = True
        Me.txtCuRemark.Name = "txtCuRemark"
        Me.txtCuRemark.Size = New System.Drawing.Size(241, 81)
        Me.txtCuRemark.TabIndex = 17
        '
        'txtCustomerID
        '
        Me.txtCustomerID.AutoSize = True
        Me.txtCustomerID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerID.Location = New System.Drawing.Point(20, 463)
        Me.txtCustomerID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.txtCustomerID.Name = "txtCustomerID"
        Me.txtCustomerID.Size = New System.Drawing.Size(72, 15)
        Me.txtCustomerID.TabIndex = 18
        Me.txtCustomerID.Text = "CustomerID"
        Me.txtCustomerID.Visible = False
        '
        'lstPlaceOrderCheck
        '
        Me.lstPlaceOrderCheck.FormattingEnabled = True
        Me.lstPlaceOrderCheck.Location = New System.Drawing.Point(191, 375)
        Me.lstPlaceOrderCheck.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.lstPlaceOrderCheck.Name = "lstPlaceOrderCheck"
        Me.lstPlaceOrderCheck.Size = New System.Drawing.Size(325, 225)
        Me.lstPlaceOrderCheck.TabIndex = 19
        '
        'txtPaymentID
        '
        Me.txtPaymentID.AutoSize = True
        Me.txtPaymentID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPaymentID.Location = New System.Drawing.Point(20, 448)
        Me.txtPaymentID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.txtPaymentID.Name = "txtPaymentID"
        Me.txtPaymentID.Size = New System.Drawing.Size(67, 15)
        Me.txtPaymentID.TabIndex = 20
        Me.txtPaymentID.Text = "PaymentID"
        Me.txtPaymentID.Visible = False
        '
        'cmdPromoCodeActivation
        '
        Me.cmdPromoCodeActivation.BackColor = System.Drawing.Color.DarkSalmon
        Me.cmdPromoCodeActivation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdPromoCodeActivation.Font = New System.Drawing.Font("qtquickcontrols", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPromoCodeActivation.Location = New System.Drawing.Point(293, 40)
        Me.cmdPromoCodeActivation.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdPromoCodeActivation.Name = "cmdPromoCodeActivation"
        Me.cmdPromoCodeActivation.Size = New System.Drawing.Size(160, 27)
        Me.cmdPromoCodeActivation.TabIndex = 21
        Me.cmdPromoCodeActivation.Text = "Apply Promo Code"
        Me.cmdPromoCodeActivation.UseVisualStyleBackColor = False
        '
        'txtFinalPrice2
        '
        Me.txtFinalPrice2.AutoSize = True
        Me.txtFinalPrice2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtFinalPrice2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFinalPrice2.Location = New System.Drawing.Point(574, 427)
        Me.txtFinalPrice2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.txtFinalPrice2.Name = "txtFinalPrice2"
        Me.txtFinalPrice2.Size = New System.Drawing.Size(0, 20)
        Me.txtFinalPrice2.TabIndex = 22
        '
        'txtFinalPrice1
        '
        Me.txtFinalPrice1.AutoSize = True
        Me.txtFinalPrice1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtFinalPrice1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFinalPrice1.Location = New System.Drawing.Point(574, 401)
        Me.txtFinalPrice1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.txtFinalPrice1.Name = "txtFinalPrice1"
        Me.txtFinalPrice1.Size = New System.Drawing.Size(0, 20)
        Me.txtFinalPrice1.TabIndex = 23
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(69, 265)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 20)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "If Delivery:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Font = New System.Drawing.Font("qtquickcontrols", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(37, 264)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 17)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Block / Room:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label8.Font = New System.Drawing.Font("qtquickcontrols", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(38, 236)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 17)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Office / Inasis:"
        '
        'txtOfficeInasis
        '
        Me.txtOfficeInasis.Font = New System.Drawing.Font("qtquickcontrols", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOfficeInasis.Location = New System.Drawing.Point(132, 233)
        Me.txtOfficeInasis.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtOfficeInasis.Name = "txtOfficeInasis"
        Me.txtOfficeInasis.Size = New System.Drawing.Size(147, 25)
        Me.txtOfficeInasis.TabIndex = 27
        '
        'txtBlockRoom
        '
        Me.txtBlockRoom.Font = New System.Drawing.Font("qtquickcontrols", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBlockRoom.Location = New System.Drawing.Point(133, 261)
        Me.txtBlockRoom.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtBlockRoom.Name = "txtBlockRoom"
        Me.txtBlockRoom.Size = New System.Drawing.Size(147, 25)
        Me.txtBlockRoom.TabIndex = 28
        '
        'txtCuHp
        '
        Me.txtCuHp.AutoSize = True
        Me.txtCuHp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuHp.Location = New System.Drawing.Point(20, 477)
        Me.txtCuHp.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.txtCuHp.Name = "txtCuHp"
        Me.txtCuHp.Size = New System.Drawing.Size(39, 15)
        Me.txtCuHp.TabIndex = 29
        Me.txtCuHp.Text = "CuHP"
        Me.txtCuHp.Visible = False
        '
        'txtOrderStatus
        '
        Me.txtOrderStatus.AutoSize = True
        Me.txtOrderStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrderStatus.Location = New System.Drawing.Point(17, 491)
        Me.txtOrderStatus.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.txtOrderStatus.Name = "txtOrderStatus"
        Me.txtOrderStatus.Size = New System.Drawing.Size(84, 15)
        Me.txtOrderStatus.TabIndex = 30
        Me.txtOrderStatus.Text = "txtOrderStatus"
        Me.txtOrderStatus.Visible = False
        '
        'cmdBack
        '
        Me.cmdBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBack.Location = New System.Drawing.Point(674, 563)
        Me.cmdBack.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdBack.Name = "cmdBack"
        Me.cmdBack.Size = New System.Drawing.Size(131, 35)
        Me.cmdBack.TabIndex = 31
        Me.cmdBack.Text = "Cancel order"
        Me.cmdBack.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("qtquickcontrols", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(43, 30)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(441, 23)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "We have received your order! Now to payment..."
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(545, 30)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(251, 233)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.UUMCafe2.My.Resources.Resources.payment
        Me.PictureBox2.Location = New System.Drawing.Point(519, 265)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(307, 330)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 33
        Me.PictureBox2.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Snow
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.txtBlockRoom)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txtOfficeInasis)
        Me.Panel1.Controls.Add(Me.cmdPromoCodeActivation)
        Me.Panel1.Controls.Add(Me.txtCuRemark)
        Me.Panel1.Controls.Add(Me.txtPromoCode)
        Me.Panel1.Controls.Add(Me.txtOrderType)
        Me.Panel1.Controls.Add(Me.txtPaymentType)
        Me.Panel1.Location = New System.Drawing.Point(47, 62)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(468, 298)
        Me.Panel1.TabIndex = 34
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("qtquickcontrols", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(39, 375)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(148, 23)
        Me.Label10.TabIndex = 35
        Me.Label10.Text = "YOUR ORDER:"
        '
        'frmPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OldLace
        Me.BackgroundImage = Global.UUMCafe2.My.Resources.Resources.background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(825, 631)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cmdBack)
        Me.Controls.Add(Me.txtOrderStatus)
        Me.Controls.Add(Me.txtCuHp)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtFinalPrice1)
        Me.Controls.Add(Me.txtFinalPrice2)
        Me.Controls.Add(Me.txtPaymentID)
        Me.Controls.Add(Me.lstPlaceOrderCheck)
        Me.Controls.Add(Me.txtCustomerID)
        Me.Controls.Add(Me.cmdConfirmPayment)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTotalPrice)
        Me.Controls.Add(Me.txtDeliveryFee)
        Me.Controls.Add(Me.txtSubTotal)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.dateOrderTime)
        Me.Controls.Add(Me.dateOrderDate)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "frmPayment"
        Me.Text = "Payment"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dateOrderDate As DateTimePicker
    Friend WithEvents dateOrderTime As DateTimePicker
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPromoCode As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtOrderType As ComboBox
    Friend WithEvents txtSubTotal As TextBox
    Friend WithEvents txtDeliveryFee As TextBox
    Friend WithEvents txtTotalPrice As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPaymentType As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmdConfirmPayment As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCuRemark As TextBox
    Friend WithEvents txtCustomerID As Label
    Friend WithEvents lstPlaceOrderCheck As ListBox
    Friend WithEvents txtPaymentID As Label
    Friend WithEvents cmdPromoCodeActivation As Button
    Friend WithEvents txtFinalPrice2 As Label
    Friend WithEvents txtFinalPrice1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtOfficeInasis As TextBox
    Friend WithEvents txtBlockRoom As TextBox
    Friend WithEvents txtCuHp As Label
    Friend WithEvents txtOrderStatus As Label
    Friend WithEvents cmdBack As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label10 As Label
End Class
