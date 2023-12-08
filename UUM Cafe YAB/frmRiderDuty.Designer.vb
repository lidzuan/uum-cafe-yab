<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRiderDuty
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRiderDuty))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtOfficeInasis = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBlockRoom = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPaymentType = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPaymentID = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dateDeliverTime = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmdCheckMyDuty = New System.Windows.Forms.Button()
        Me.cmdDelivered = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.UUMCafeDatabase5DataSet = New UUMCafe2.UUMCafeDatabase5DataSet()
        Me.CustomerOrderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerOrderTableAdapter = New UUMCafe2.UUMCafeDatabase5DataSetTableAdapters.CustomerOrderTableAdapter()
        Me.txtOrderStatus = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtCustomerHP = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCustomerID = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtTotalPrice = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtCuRemark = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtRiderID = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PaymentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PaymentTableAdapter = New UUMCafe2.UUMCafeDatabase5DataSetTableAdapters.PaymentTableAdapter()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.CustomerOrderBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CustomerOrderBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.TableAdapterManager = New UUMCafe2.UUMCafeDatabase5DataSetTableAdapters.TableAdapterManager()
        Me.CustomerOrderDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmdLogout = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.PictureBox23 = New System.Windows.Forms.PictureBox()
        CType(Me.UUMCafeDatabase5DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerOrderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PaymentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerOrderBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CustomerOrderBindingNavigator.SuspendLayout()
        CType(Me.CustomerOrderDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox23, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(154, 63)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Rider ID:"
        '
        'txtOfficeInasis
        '
        Me.txtOfficeInasis.Enabled = False
        Me.txtOfficeInasis.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOfficeInasis.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtOfficeInasis.Location = New System.Drawing.Point(154, 307)
        Me.txtOfficeInasis.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtOfficeInasis.Name = "txtOfficeInasis"
        Me.txtOfficeInasis.ReadOnly = True
        Me.txtOfficeInasis.Size = New System.Drawing.Size(215, 26)
        Me.txtOfficeInasis.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(42, 309)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Office / Inasis:"
        '
        'txtBlockRoom
        '
        Me.txtBlockRoom.Enabled = False
        Me.txtBlockRoom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBlockRoom.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtBlockRoom.Location = New System.Drawing.Point(154, 335)
        Me.txtBlockRoom.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtBlockRoom.Name = "txtBlockRoom"
        Me.txtBlockRoom.ReadOnly = True
        Me.txtBlockRoom.Size = New System.Drawing.Size(215, 26)
        Me.txtBlockRoom.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(42, 336)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Block / Room:"
        '
        'txtPaymentType
        '
        Me.txtPaymentType.Enabled = False
        Me.txtPaymentType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPaymentType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPaymentType.Location = New System.Drawing.Point(154, 391)
        Me.txtPaymentType.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtPaymentType.Name = "txtPaymentType"
        Me.txtPaymentType.ReadOnly = True
        Me.txtPaymentType.Size = New System.Drawing.Size(126, 26)
        Me.txtPaymentType.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(91, 392)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Pay by:"
        '
        'txtPaymentID
        '
        Me.txtPaymentID.Enabled = False
        Me.txtPaymentID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPaymentID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPaymentID.Location = New System.Drawing.Point(154, 223)
        Me.txtPaymentID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtPaymentID.Name = "txtPaymentID"
        Me.txtPaymentID.ReadOnly = True
        Me.txtPaymentID.Size = New System.Drawing.Size(126, 26)
        Me.txtPaymentID.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(57, 225)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 20)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Payment ID:"
        '
        'dateDeliverTime
        '
        Me.dateDeliverTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateDeliverTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dateDeliverTime.Location = New System.Drawing.Point(591, 405)
        Me.dateDeliverTime.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dateDeliverTime.Name = "dateDeliverTime"
        Me.dateDeliverTime.Size = New System.Drawing.Size(215, 28)
        Me.dateDeliverTime.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(465, 409)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(121, 24)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Deliver Time:"
        '
        'cmdCheckMyDuty
        '
        Me.cmdCheckMyDuty.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdCheckMyDuty.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdCheckMyDuty.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCheckMyDuty.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCheckMyDuty.Location = New System.Drawing.Point(183, 124)
        Me.cmdCheckMyDuty.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmdCheckMyDuty.Name = "cmdCheckMyDuty"
        Me.cmdCheckMyDuty.Size = New System.Drawing.Size(184, 57)
        Me.cmdCheckMyDuty.TabIndex = 19
        Me.cmdCheckMyDuty.Text = "CHECK MY DUTY"
        Me.cmdCheckMyDuty.UseVisualStyleBackColor = False
        '
        'cmdDelivered
        '
        Me.cmdDelivered.BackColor = System.Drawing.Color.Lime
        Me.cmdDelivered.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdDelivered.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdDelivered.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDelivered.Location = New System.Drawing.Point(635, 517)
        Me.cmdDelivered.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmdDelivered.Name = "cmdDelivered"
        Me.cmdDelivered.Size = New System.Drawing.Size(142, 45)
        Me.cmdDelivered.TabIndex = 20
        Me.cmdDelivered.Text = "DELIVERED"
        Me.cmdDelivered.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(465, 478)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(454, 24)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "After you have done delivering, then press Delivered."
        '
        'UUMCafeDatabase5DataSet
        '
        Me.UUMCafeDatabase5DataSet.DataSetName = "UUMCafeDatabase5DataSet"
        Me.UUMCafeDatabase5DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomerOrderBindingSource
        '
        Me.CustomerOrderBindingSource.DataMember = "CustomerOrder"
        Me.CustomerOrderBindingSource.DataSource = Me.UUMCafeDatabase5DataSet
        '
        'CustomerOrderTableAdapter
        '
        Me.CustomerOrderTableAdapter.ClearBeforeFill = True
        '
        'txtOrderStatus
        '
        Me.txtOrderStatus.Enabled = False
        Me.txtOrderStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrderStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtOrderStatus.Location = New System.Drawing.Point(154, 418)
        Me.txtOrderStatus.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtOrderStatus.Name = "txtOrderStatus"
        Me.txtOrderStatus.ReadOnly = True
        Me.txtOrderStatus.Size = New System.Drawing.Size(215, 26)
        Me.txtOrderStatus.TabIndex = 24
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(48, 421)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(104, 20)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Order Status:"
        '
        'txtCustomerHP
        '
        Me.txtCustomerHP.Enabled = False
        Me.txtCustomerHP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerHP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCustomerHP.Location = New System.Drawing.Point(154, 279)
        Me.txtCustomerHP.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtCustomerHP.Name = "txtCustomerHP"
        Me.txtCustomerHP.ReadOnly = True
        Me.txtCustomerHP.Size = New System.Drawing.Size(166, 26)
        Me.txtCustomerHP.TabIndex = 26
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(43, 281)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 20)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Customer HP:"
        '
        'txtCustomerID
        '
        Me.txtCustomerID.Enabled = False
        Me.txtCustomerID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCustomerID.Location = New System.Drawing.Point(154, 251)
        Me.txtCustomerID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtCustomerID.Name = "txtCustomerID"
        Me.txtCustomerID.ReadOnly = True
        Me.txtCustomerID.Size = New System.Drawing.Size(126, 26)
        Me.txtCustomerID.TabIndex = 28
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(50, 253)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(103, 20)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "Customer ID:"
        '
        'txtTotalPrice
        '
        Me.txtTotalPrice.Enabled = False
        Me.txtTotalPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalPrice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTotalPrice.Location = New System.Drawing.Point(154, 362)
        Me.txtTotalPrice.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTotalPrice.Name = "txtTotalPrice"
        Me.txtTotalPrice.ReadOnly = True
        Me.txtTotalPrice.Size = New System.Drawing.Size(126, 26)
        Me.txtTotalPrice.TabIndex = 30
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(22, 365)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(125, 20)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "Total price (RM):"
        '
        'txtCuRemark
        '
        Me.txtCuRemark.Enabled = False
        Me.txtCuRemark.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuRemark.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCuRemark.Location = New System.Drawing.Point(154, 447)
        Me.txtCuRemark.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtCuRemark.Multiline = True
        Me.txtCuRemark.Name = "txtCuRemark"
        Me.txtCuRemark.ReadOnly = True
        Me.txtCuRemark.Size = New System.Drawing.Size(253, 94)
        Me.txtCuRemark.TabIndex = 32
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(9, 448)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(142, 20)
        Me.Label14.TabIndex = 31
        Me.Label14.Text = "Customer Remark:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.Location = New System.Drawing.Point(8, 194)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(376, 6)
        Me.Panel1.TabIndex = 33
        '
        'txtRiderID
        '
        Me.txtRiderID.AutoSize = True
        Me.txtRiderID.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRiderID.Location = New System.Drawing.Point(178, 86)
        Me.txtRiderID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.txtRiderID.Name = "txtRiderID"
        Me.txtRiderID.Size = New System.Drawing.Size(117, 29)
        Me.txtRiderID.TabIndex = 34
        Me.txtRiderID.Text = "(Rider ID)"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(429, 392)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(7, 169)
        Me.Panel2.TabIndex = 37
        '
        'PaymentBindingSource
        '
        Me.PaymentBindingSource.DataMember = "Payment"
        Me.PaymentBindingSource.DataSource = Me.UUMCafeDatabase5DataSet
        '
        'PaymentTableAdapter
        '
        Me.PaymentTableAdapter.ClearBeforeFill = True
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(24, 17)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(24, 17)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 20)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(38, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 17)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 20)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(24, 17)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(24, 17)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 20)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(24, 17)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(24, 17)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'CustomerOrderBindingNavigatorSaveItem
        '
        Me.CustomerOrderBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CustomerOrderBindingNavigatorSaveItem.Image = CType(resources.GetObject("CustomerOrderBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CustomerOrderBindingNavigatorSaveItem.Name = "CustomerOrderBindingNavigatorSaveItem"
        Me.CustomerOrderBindingNavigatorSaveItem.Size = New System.Drawing.Size(24, 17)
        Me.CustomerOrderBindingNavigatorSaveItem.Text = "Save Data"
        '
        'CustomerOrderBindingNavigator
        '
        Me.CustomerOrderBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CustomerOrderBindingNavigator.BindingSource = Me.CustomerOrderBindingSource
        Me.CustomerOrderBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CustomerOrderBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CustomerOrderBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.CustomerOrderBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CustomerOrderBindingNavigatorSaveItem})
        Me.CustomerOrderBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CustomerOrderBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CustomerOrderBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CustomerOrderBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CustomerOrderBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CustomerOrderBindingNavigator.Name = "CustomerOrderBindingNavigator"
        Me.CustomerOrderBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CustomerOrderBindingNavigator.Size = New System.Drawing.Size(1172, 20)
        Me.CustomerOrderBindingNavigator.TabIndex = 22
        Me.CustomerOrderBindingNavigator.Text = "BindingNavigator1"
        Me.CustomerOrderBindingNavigator.Visible = False
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CustomerAccountTableAdapter = Nothing
        Me.TableAdapterManager.CustomerOrderTableAdapter = Me.CustomerOrderTableAdapter
        Me.TableAdapterManager.CustomerTableAdapter = Nothing
        Me.TableAdapterManager.FeedbackTableAdapter = Nothing
        Me.TableAdapterManager.PaymentTableAdapter = Nothing
        Me.TableAdapterManager.PromoListTableAdapter = Nothing
        Me.TableAdapterManager.PromoPaymentTableAdapter = Nothing
        Me.TableAdapterManager.RiderAccountTableAdapter = Nothing
        Me.TableAdapterManager.RiderTableAdapter = Nothing
        Me.TableAdapterManager.StaffAccountTableAdapter = Nothing
        Me.TableAdapterManager.StaffTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = UUMCafe2.UUMCafeDatabase5DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CustomerOrderDataGridView
        '
        Me.CustomerOrderDataGridView.AllowUserToAddRows = False
        Me.CustomerOrderDataGridView.AllowUserToDeleteRows = False
        Me.CustomerOrderDataGridView.AutoGenerateColumns = False
        Me.CustomerOrderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CustomerOrderDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.CustomerOrderDataGridView.DataSource = Me.CustomerOrderBindingSource
        Me.CustomerOrderDataGridView.Location = New System.Drawing.Point(407, 49)
        Me.CustomerOrderDataGridView.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CustomerOrderDataGridView.Name = "CustomerOrderDataGridView"
        Me.CustomerOrderDataGridView.ReadOnly = True
        Me.CustomerOrderDataGridView.RowHeadersWidth = 51
        Me.CustomerOrderDataGridView.RowTemplate.Height = 24
        Me.CustomerOrderDataGridView.Size = New System.Drawing.Size(534, 332)
        Me.CustomerOrderDataGridView.TabIndex = 37
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Customer_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Customer_ID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Customer_Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Customer_Name"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Item_Menu"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Item_Menu"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Item_Price"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Item_Price"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Item_Quantity"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Item_Quantity"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 125
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Payment_ID"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Payment_ID"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 125
        '
        'cmdLogout
        '
        Me.cmdLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLogout.Location = New System.Drawing.Point(970, 60)
        Me.cmdLogout.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmdLogout.Name = "cmdLogout"
        Me.cmdLogout.Size = New System.Drawing.Size(81, 34)
        Me.cmdLogout.TabIndex = 38
        Me.cmdLogout.Text = "Logout"
        Me.cmdLogout.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Rockwell", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(28, 24)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(308, 27)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Hello RIDER  :)  Drive safe!"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.BackgroundImage = Global.UUMCafe2.My.Resources.Resources._exit
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.Lavender
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(991, 105)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(45, 41)
        Me.Button3.TabIndex = 40
        Me.Button3.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.UUMCafe2.My.Resources.Resources.rider
        Me.PictureBox1.Location = New System.Drawing.Point(866, 346)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(211, 234)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 41
        Me.PictureBox1.TabStop = False
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Rage Italic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label24.Location = New System.Drawing.Point(886, 14)
        Me.Label24.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(176, 30)
        Me.Label24.TabIndex = 42
        Me.Label24.Text = "UUM Cafe YAB"
        '
        'PictureBox23
        '
        Me.PictureBox23.Image = Global.UUMCafe2.My.Resources.Resources.Restaurant
        Me.PictureBox23.Location = New System.Drawing.Point(8, 63)
        Me.PictureBox23.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox23.Name = "PictureBox23"
        Me.PictureBox23.Size = New System.Drawing.Size(140, 128)
        Me.PictureBox23.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox23.TabIndex = 43
        Me.PictureBox23.TabStop = False
        '
        'frmRiderDuty
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Honeydew
        Me.ClientSize = New System.Drawing.Size(1077, 578)
        Me.Controls.Add(Me.PictureBox23)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmdLogout)
        Me.Controls.Add(Me.CustomerOrderDataGridView)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.txtRiderID)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtCuRemark)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtTotalPrice)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtCustomerID)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtCustomerHP)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtOrderStatus)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.CustomerOrderBindingNavigator)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cmdDelivered)
        Me.Controls.Add(Me.cmdCheckMyDuty)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dateDeliverTime)
        Me.Controls.Add(Me.txtPaymentID)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtPaymentType)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtBlockRoom)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtOfficeInasis)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmRiderDuty"
        Me.Text = "Rider Duty"
        CType(Me.UUMCafeDatabase5DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerOrderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PaymentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerOrderBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CustomerOrderBindingNavigator.ResumeLayout(False)
        Me.CustomerOrderBindingNavigator.PerformLayout()
        CType(Me.CustomerOrderDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox23, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents txtOfficeInasis As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtBlockRoom As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPaymentType As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPaymentID As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents dateDeliverTime As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents cmdCheckMyDuty As Button
    Friend WithEvents cmdDelivered As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents UUMCafeDatabase5DataSet As UUMCafeDatabase5DataSet
    Friend WithEvents CustomerOrderBindingSource As BindingSource
    Friend WithEvents CustomerOrderTableAdapter As UUMCafeDatabase5DataSetTableAdapters.CustomerOrderTableAdapter
    Friend WithEvents txtOrderStatus As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtCustomerHP As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCustomerID As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtTotalPrice As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtCuRemark As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtRiderID As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PaymentBindingSource As BindingSource
    Friend WithEvents PaymentTableAdapter As UUMCafeDatabase5DataSetTableAdapters.PaymentTableAdapter
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents CustomerOrderBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents CustomerOrderBindingNavigator As BindingNavigator
    Friend WithEvents TableAdapterManager As UUMCafeDatabase5DataSetTableAdapters.TableAdapterManager
    Friend WithEvents CustomerOrderDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents cmdLogout As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label24 As Label
    Friend WithEvents PictureBox23 As PictureBox
End Class
