<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStaff
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStaff))
        Me.pnlStaffMenu = New System.Windows.Forms.Panel()
        Me.PictureBox23 = New System.Windows.Forms.PictureBox()
        Me.pnlOnPosition = New System.Windows.Forms.Panel()
        Me.cmdRiderDuty = New System.Windows.Forms.Button()
        Me.cmdCustomerOrder = New System.Windows.Forms.Button()
        Me.pnlCustomerOrder = New System.Windows.Forms.Panel()
        Me.txtItemMenu = New System.Windows.Forms.TextBox()
        Me.CustomerOrderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UUMCafeDatabase5DataSet = New UUMCafe2.UUMCafeDatabase5DataSet()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.txtCustomerID = New System.Windows.Forms.TextBox()
        Me.txtOrderNum = New System.Windows.Forms.TextBox()
        Me.cmdFilterItemMenu = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmdFilterCustomerName = New System.Windows.Forms.Button()
        Me.cmdFilterCustomerID = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmdFilterOrderNum = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmdDelete1 = New System.Windows.Forms.Button()
        Me.cmdEdit1 = New System.Windows.Forms.Button()
        Me.cmdAdd1 = New System.Windows.Forms.Button()
        Me.cmdMoveLast1 = New System.Windows.Forms.Button()
        Me.cmdMoveNext1 = New System.Windows.Forms.Button()
        Me.cmdMovePrevious1 = New System.Windows.Forms.Button()
        Me.cmdMoveFirst1 = New System.Windows.Forms.Button()
        Me.cmdClearFilter = New System.Windows.Forms.Button()
        Me.cmdFilterPaymentID = New System.Windows.Forms.Button()
        Me.CustomerOrderDataGridView = New System.Windows.Forms.DataGridView()
        Me.Order_Num = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlRiderDuty = New System.Windows.Forms.Panel()
        Me.txtRiderID = New System.Windows.Forms.TextBox()
        Me.txtPaymentID2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmdClearDeliveryFilter = New System.Windows.Forms.Button()
        Me.cmdDeliveryFilter = New System.Windows.Forms.Button()
        Me.txtDelivery = New System.Windows.Forms.TextBox()
        Me.cmdUpdate = New System.Windows.Forms.Button()
        Me.PaymentDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaymentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtStaffNameID = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CustomerOrderBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CustomerOrderBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CustomerOrderTableAdapter = New UUMCafe2.UUMCafeDatabase5DataSetTableAdapters.CustomerOrderTableAdapter()
        Me.TableAdapterManager = New UUMCafe2.UUMCafeDatabase5DataSetTableAdapters.TableAdapterManager()
        Me.PaymentTableAdapter = New UUMCafe2.UUMCafeDatabase5DataSetTableAdapters.PaymentTableAdapter()
        Me.cmdLogout = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtPaymentID = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.pnlStaffMenu.SuspendLayout()
        CType(Me.PictureBox23, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCustomerOrder.SuspendLayout()
        CType(Me.CustomerOrderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UUMCafeDatabase5DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerOrderDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlRiderDuty.SuspendLayout()
        CType(Me.PaymentDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PaymentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerOrderBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CustomerOrderBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlStaffMenu
        '
        Me.pnlStaffMenu.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.pnlStaffMenu.Controls.Add(Me.PictureBox23)
        Me.pnlStaffMenu.Controls.Add(Me.pnlOnPosition)
        Me.pnlStaffMenu.Controls.Add(Me.cmdRiderDuty)
        Me.pnlStaffMenu.Controls.Add(Me.cmdCustomerOrder)
        Me.pnlStaffMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlStaffMenu.Location = New System.Drawing.Point(0, -1)
        Me.pnlStaffMenu.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.pnlStaffMenu.Name = "pnlStaffMenu"
        Me.pnlStaffMenu.Size = New System.Drawing.Size(153, 566)
        Me.pnlStaffMenu.TabIndex = 0
        '
        'PictureBox23
        '
        Me.PictureBox23.Image = Global.UUMCafe2.My.Resources.Resources.Restaurant
        Me.PictureBox23.Location = New System.Drawing.Point(8, 341)
        Me.PictureBox23.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.PictureBox23.Name = "PictureBox23"
        Me.PictureBox23.Size = New System.Drawing.Size(139, 143)
        Me.PictureBox23.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox23.TabIndex = 33
        Me.PictureBox23.TabStop = False
        '
        'pnlOnPosition
        '
        Me.pnlOnPosition.BackColor = System.Drawing.Color.Yellow
        Me.pnlOnPosition.Location = New System.Drawing.Point(0, 88)
        Me.pnlOnPosition.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.pnlOnPosition.Name = "pnlOnPosition"
        Me.pnlOnPosition.Size = New System.Drawing.Size(7, 39)
        Me.pnlOnPosition.TabIndex = 1
        '
        'cmdRiderDuty
        '
        Me.cmdRiderDuty.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdRiderDuty.FlatAppearance.BorderSize = 0
        Me.cmdRiderDuty.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdRiderDuty.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRiderDuty.ForeColor = System.Drawing.Color.White
        Me.cmdRiderDuty.Location = New System.Drawing.Point(9, 163)
        Me.cmdRiderDuty.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdRiderDuty.Name = "cmdRiderDuty"
        Me.cmdRiderDuty.Size = New System.Drawing.Size(140, 39)
        Me.cmdRiderDuty.TabIndex = 2
        Me.cmdRiderDuty.Text = "Rider Duty"
        Me.cmdRiderDuty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdRiderDuty.UseVisualStyleBackColor = True
        '
        'cmdCustomerOrder
        '
        Me.cmdCustomerOrder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdCustomerOrder.FlatAppearance.BorderSize = 0
        Me.cmdCustomerOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCustomerOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCustomerOrder.ForeColor = System.Drawing.Color.White
        Me.cmdCustomerOrder.Location = New System.Drawing.Point(9, 88)
        Me.cmdCustomerOrder.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdCustomerOrder.Name = "cmdCustomerOrder"
        Me.cmdCustomerOrder.Size = New System.Drawing.Size(144, 39)
        Me.cmdCustomerOrder.TabIndex = 1
        Me.cmdCustomerOrder.Text = "Customer Order"
        Me.cmdCustomerOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdCustomerOrder.UseVisualStyleBackColor = True
        '
        'pnlCustomerOrder
        '
        Me.pnlCustomerOrder.Controls.Add(Me.txtPaymentID)
        Me.pnlCustomerOrder.Controls.Add(Me.txtItemMenu)
        Me.pnlCustomerOrder.Controls.Add(Me.txtCustomerName)
        Me.pnlCustomerOrder.Controls.Add(Me.txtCustomerID)
        Me.pnlCustomerOrder.Controls.Add(Me.txtOrderNum)
        Me.pnlCustomerOrder.Controls.Add(Me.cmdFilterItemMenu)
        Me.pnlCustomerOrder.Controls.Add(Me.Label8)
        Me.pnlCustomerOrder.Controls.Add(Me.cmdFilterCustomerName)
        Me.pnlCustomerOrder.Controls.Add(Me.cmdFilterCustomerID)
        Me.pnlCustomerOrder.Controls.Add(Me.Label7)
        Me.pnlCustomerOrder.Controls.Add(Me.Label6)
        Me.pnlCustomerOrder.Controls.Add(Me.cmdFilterOrderNum)
        Me.pnlCustomerOrder.Controls.Add(Me.Label5)
        Me.pnlCustomerOrder.Controls.Add(Me.Label4)
        Me.pnlCustomerOrder.Controls.Add(Me.cmdDelete1)
        Me.pnlCustomerOrder.Controls.Add(Me.cmdEdit1)
        Me.pnlCustomerOrder.Controls.Add(Me.cmdAdd1)
        Me.pnlCustomerOrder.Controls.Add(Me.cmdMoveLast1)
        Me.pnlCustomerOrder.Controls.Add(Me.cmdMoveNext1)
        Me.pnlCustomerOrder.Controls.Add(Me.cmdMovePrevious1)
        Me.pnlCustomerOrder.Controls.Add(Me.cmdMoveFirst1)
        Me.pnlCustomerOrder.Controls.Add(Me.cmdClearFilter)
        Me.pnlCustomerOrder.Controls.Add(Me.cmdFilterPaymentID)
        Me.pnlCustomerOrder.Controls.Add(Me.CustomerOrderDataGridView)
        Me.pnlCustomerOrder.Location = New System.Drawing.Point(168, 79)
        Me.pnlCustomerOrder.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.pnlCustomerOrder.Name = "pnlCustomerOrder"
        Me.pnlCustomerOrder.Size = New System.Drawing.Size(679, 405)
        Me.pnlCustomerOrder.TabIndex = 1
        '
        'txtItemMenu
        '
        Me.txtItemMenu.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerOrderBindingSource, "Item_Menu", True))
        Me.txtItemMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemMenu.Location = New System.Drawing.Point(134, 362)
        Me.txtItemMenu.Margin = New System.Windows.Forms.Padding(2)
        Me.txtItemMenu.Name = "txtItemMenu"
        Me.txtItemMenu.Size = New System.Drawing.Size(162, 23)
        Me.txtItemMenu.TabIndex = 26
        '
        'CustomerOrderBindingSource
        '
        Me.CustomerOrderBindingSource.DataMember = "CustomerOrder"
        Me.CustomerOrderBindingSource.DataSource = Me.UUMCafeDatabase5DataSet
        '
        'UUMCafeDatabase5DataSet
        '
        Me.UUMCafeDatabase5DataSet.DataSetName = "UUMCafeDatabase5DataSet"
        Me.UUMCafeDatabase5DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtCustomerName
        '
        Me.txtCustomerName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerOrderBindingSource, "Customer_Name", True))
        Me.txtCustomerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerName.Location = New System.Drawing.Point(134, 337)
        Me.txtCustomerName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(162, 23)
        Me.txtCustomerName.TabIndex = 24
        '
        'txtCustomerID
        '
        Me.txtCustomerID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerOrderBindingSource, "Customer_ID", True))
        Me.txtCustomerID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerID.Location = New System.Drawing.Point(134, 312)
        Me.txtCustomerID.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCustomerID.Name = "txtCustomerID"
        Me.txtCustomerID.Size = New System.Drawing.Size(162, 23)
        Me.txtCustomerID.TabIndex = 22
        '
        'txtOrderNum
        '
        Me.txtOrderNum.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerOrderBindingSource, "Order_Num", True))
        Me.txtOrderNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrderNum.Location = New System.Drawing.Point(134, 287)
        Me.txtOrderNum.Margin = New System.Windows.Forms.Padding(2)
        Me.txtOrderNum.Name = "txtOrderNum"
        Me.txtOrderNum.Size = New System.Drawing.Size(162, 23)
        Me.txtOrderNum.TabIndex = 21
        '
        'cmdFilterItemMenu
        '
        Me.cmdFilterItemMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdFilterItemMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdFilterItemMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdFilterItemMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFilterItemMenu.Location = New System.Drawing.Point(308, 362)
        Me.cmdFilterItemMenu.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdFilterItemMenu.Name = "cmdFilterItemMenu"
        Me.cmdFilterItemMenu.Size = New System.Drawing.Size(71, 23)
        Me.cmdFilterItemMenu.TabIndex = 19
        Me.cmdFilterItemMenu.Text = "FILTER"
        Me.cmdFilterItemMenu.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(61, 365)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 15)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Item Menu:"
        '
        'cmdFilterCustomerName
        '
        Me.cmdFilterCustomerName.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdFilterCustomerName.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdFilterCustomerName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdFilterCustomerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFilterCustomerName.Location = New System.Drawing.Point(308, 337)
        Me.cmdFilterCustomerName.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdFilterCustomerName.Name = "cmdFilterCustomerName"
        Me.cmdFilterCustomerName.Size = New System.Drawing.Size(71, 23)
        Me.cmdFilterCustomerName.TabIndex = 17
        Me.cmdFilterCustomerName.Text = "FILTER"
        Me.cmdFilterCustomerName.UseVisualStyleBackColor = False
        '
        'cmdFilterCustomerID
        '
        Me.cmdFilterCustomerID.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdFilterCustomerID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdFilterCustomerID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdFilterCustomerID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFilterCustomerID.Location = New System.Drawing.Point(308, 312)
        Me.cmdFilterCustomerID.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdFilterCustomerID.Name = "cmdFilterCustomerID"
        Me.cmdFilterCustomerID.Size = New System.Drawing.Size(71, 23)
        Me.cmdFilterCustomerID.TabIndex = 16
        Me.cmdFilterCustomerID.Text = "FILTER"
        Me.cmdFilterCustomerID.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(30, 341)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 15)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Customer Name:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(52, 315)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 15)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Customer ID:"
        '
        'cmdFilterOrderNum
        '
        Me.cmdFilterOrderNum.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdFilterOrderNum.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdFilterOrderNum.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdFilterOrderNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFilterOrderNum.Location = New System.Drawing.Point(308, 287)
        Me.cmdFilterOrderNum.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdFilterOrderNum.Name = "cmdFilterOrderNum"
        Me.cmdFilterOrderNum.Size = New System.Drawing.Size(71, 23)
        Me.cmdFilterOrderNum.TabIndex = 13
        Me.cmdFilterOrderNum.Text = "FILTER"
        Me.cmdFilterOrderNum.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(41, 290)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 15)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Order Number:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(57, 265)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 15)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Payment ID:"
        '
        'cmdDelete1
        '
        Me.cmdDelete1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdDelete1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdDelete1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdDelete1.Location = New System.Drawing.Point(521, 201)
        Me.cmdDelete1.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdDelete1.Name = "cmdDelete1"
        Me.cmdDelete1.Size = New System.Drawing.Size(80, 33)
        Me.cmdDelete1.TabIndex = 10
        Me.cmdDelete1.Text = "DELETE"
        Me.cmdDelete1.UseVisualStyleBackColor = False
        '
        'cmdEdit1
        '
        Me.cmdEdit1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdEdit1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdEdit1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdEdit1.Location = New System.Drawing.Point(428, 201)
        Me.cmdEdit1.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdEdit1.Name = "cmdEdit1"
        Me.cmdEdit1.Size = New System.Drawing.Size(80, 33)
        Me.cmdEdit1.TabIndex = 9
        Me.cmdEdit1.Text = "EDIT"
        Me.cmdEdit1.UseVisualStyleBackColor = False
        '
        'cmdAdd1
        '
        Me.cmdAdd1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdAdd1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdAdd1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAdd1.Location = New System.Drawing.Point(335, 201)
        Me.cmdAdd1.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdAdd1.Name = "cmdAdd1"
        Me.cmdAdd1.Size = New System.Drawing.Size(80, 33)
        Me.cmdAdd1.TabIndex = 8
        Me.cmdAdd1.Text = "ADD"
        Me.cmdAdd1.UseVisualStyleBackColor = False
        '
        'cmdMoveLast1
        '
        Me.cmdMoveLast1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdMoveLast1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdMoveLast1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdMoveLast1.Location = New System.Drawing.Point(225, 201)
        Me.cmdMoveLast1.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdMoveLast1.Name = "cmdMoveLast1"
        Me.cmdMoveLast1.Size = New System.Drawing.Size(39, 33)
        Me.cmdMoveLast1.TabIndex = 7
        Me.cmdMoveLast1.Text = ">>"
        Me.cmdMoveLast1.UseVisualStyleBackColor = False
        '
        'cmdMoveNext1
        '
        Me.cmdMoveNext1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdMoveNext1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdMoveNext1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdMoveNext1.Location = New System.Drawing.Point(169, 201)
        Me.cmdMoveNext1.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdMoveNext1.Name = "cmdMoveNext1"
        Me.cmdMoveNext1.Size = New System.Drawing.Size(39, 33)
        Me.cmdMoveNext1.TabIndex = 6
        Me.cmdMoveNext1.Text = ">"
        Me.cmdMoveNext1.UseVisualStyleBackColor = False
        '
        'cmdMovePrevious1
        '
        Me.cmdMovePrevious1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdMovePrevious1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdMovePrevious1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdMovePrevious1.Location = New System.Drawing.Point(115, 201)
        Me.cmdMovePrevious1.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdMovePrevious1.Name = "cmdMovePrevious1"
        Me.cmdMovePrevious1.Size = New System.Drawing.Size(39, 33)
        Me.cmdMovePrevious1.TabIndex = 5
        Me.cmdMovePrevious1.Text = "<"
        Me.cmdMovePrevious1.UseVisualStyleBackColor = False
        '
        'cmdMoveFirst1
        '
        Me.cmdMoveFirst1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdMoveFirst1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdMoveFirst1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdMoveFirst1.Location = New System.Drawing.Point(61, 201)
        Me.cmdMoveFirst1.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdMoveFirst1.Name = "cmdMoveFirst1"
        Me.cmdMoveFirst1.Size = New System.Drawing.Size(39, 33)
        Me.cmdMoveFirst1.TabIndex = 4
        Me.cmdMoveFirst1.Text = "<<"
        Me.cmdMoveFirst1.UseVisualStyleBackColor = False
        '
        'cmdClearFilter
        '
        Me.cmdClearFilter.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdClearFilter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdClearFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdClearFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClearFilter.Location = New System.Drawing.Point(411, 261)
        Me.cmdClearFilter.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdClearFilter.Name = "cmdClearFilter"
        Me.cmdClearFilter.Size = New System.Drawing.Size(74, 44)
        Me.cmdClearFilter.TabIndex = 3
        Me.cmdClearFilter.Text = "RESET FILTER"
        Me.cmdClearFilter.UseVisualStyleBackColor = False
        '
        'cmdFilterPaymentID
        '
        Me.cmdFilterPaymentID.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdFilterPaymentID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdFilterPaymentID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdFilterPaymentID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFilterPaymentID.Location = New System.Drawing.Point(308, 261)
        Me.cmdFilterPaymentID.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdFilterPaymentID.Name = "cmdFilterPaymentID"
        Me.cmdFilterPaymentID.Size = New System.Drawing.Size(71, 24)
        Me.cmdFilterPaymentID.TabIndex = 2
        Me.cmdFilterPaymentID.Text = "FILTER"
        Me.cmdFilterPaymentID.UseVisualStyleBackColor = False
        '
        'CustomerOrderDataGridView
        '
        Me.CustomerOrderDataGridView.AutoGenerateColumns = False
        Me.CustomerOrderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CustomerOrderDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Order_Num, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.CustomerOrderDataGridView.DataSource = Me.CustomerOrderBindingSource
        Me.CustomerOrderDataGridView.Location = New System.Drawing.Point(17, 14)
        Me.CustomerOrderDataGridView.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.CustomerOrderDataGridView.Name = "CustomerOrderDataGridView"
        Me.CustomerOrderDataGridView.RowHeadersWidth = 51
        Me.CustomerOrderDataGridView.RowTemplate.Height = 24
        Me.CustomerOrderDataGridView.Size = New System.Drawing.Size(632, 168)
        Me.CustomerOrderDataGridView.TabIndex = 0
        '
        'Order_Num
        '
        Me.Order_Num.DataPropertyName = "Order_Num"
        Me.Order_Num.HeaderText = "Order_Num"
        Me.Order_Num.MinimumWidth = 8
        Me.Order_Num.Name = "Order_Num"
        Me.Order_Num.Width = 150
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Customer_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Customer_ID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Customer_Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Customer_Name"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Item_Menu"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Item_Menu"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Item_Price"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Item_Price"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Item_Quantity"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Item_Quantity"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 125
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Payment_ID"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Payment_ID"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 125
        '
        'pnlRiderDuty
        '
        Me.pnlRiderDuty.Controls.Add(Me.Label10)
        Me.pnlRiderDuty.Controls.Add(Me.Label9)
        Me.pnlRiderDuty.Controls.Add(Me.Panel2)
        Me.pnlRiderDuty.Controls.Add(Me.txtRiderID)
        Me.pnlRiderDuty.Controls.Add(Me.txtPaymentID2)
        Me.pnlRiderDuty.Controls.Add(Me.Label2)
        Me.pnlRiderDuty.Controls.Add(Me.Label3)
        Me.pnlRiderDuty.Controls.Add(Me.cmdClearDeliveryFilter)
        Me.pnlRiderDuty.Controls.Add(Me.cmdDeliveryFilter)
        Me.pnlRiderDuty.Controls.Add(Me.txtDelivery)
        Me.pnlRiderDuty.Controls.Add(Me.cmdUpdate)
        Me.pnlRiderDuty.Controls.Add(Me.PaymentDataGridView)
        Me.pnlRiderDuty.Location = New System.Drawing.Point(168, 79)
        Me.pnlRiderDuty.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.pnlRiderDuty.Name = "pnlRiderDuty"
        Me.pnlRiderDuty.Size = New System.Drawing.Size(679, 402)
        Me.pnlRiderDuty.TabIndex = 2
        '
        'txtRiderID
        '
        Me.txtRiderID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRiderID.Location = New System.Drawing.Point(521, 278)
        Me.txtRiderID.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtRiderID.Name = "txtRiderID"
        Me.txtRiderID.Size = New System.Drawing.Size(126, 26)
        Me.txtRiderID.TabIndex = 5
        '
        'txtPaymentID2
        '
        Me.txtPaymentID2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPaymentID2.Location = New System.Drawing.Point(363, 278)
        Me.txtPaymentID2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtPaymentID2.Name = "txtPaymentID2"
        Me.txtPaymentID2.Size = New System.Drawing.Size(129, 26)
        Me.txtPaymentID2.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(524, 253)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Assign a rider ID:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(360, 253)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 18)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Which payment ID:"
        '
        'cmdClearDeliveryFilter
        '
        Me.cmdClearDeliveryFilter.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdClearDeliveryFilter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdClearDeliveryFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdClearDeliveryFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClearDeliveryFilter.Location = New System.Drawing.Point(76, 308)
        Me.cmdClearDeliveryFilter.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdClearDeliveryFilter.Name = "cmdClearDeliveryFilter"
        Me.cmdClearDeliveryFilter.Size = New System.Drawing.Size(160, 62)
        Me.cmdClearDeliveryFilter.TabIndex = 3
        Me.cmdClearDeliveryFilter.Text = "CLEAR DELIVERY FILTER"
        Me.cmdClearDeliveryFilter.UseVisualStyleBackColor = False
        '
        'cmdDeliveryFilter
        '
        Me.cmdDeliveryFilter.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdDeliveryFilter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdDeliveryFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdDeliveryFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDeliveryFilter.Location = New System.Drawing.Point(76, 253)
        Me.cmdDeliveryFilter.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdDeliveryFilter.Name = "cmdDeliveryFilter"
        Me.cmdDeliveryFilter.Size = New System.Drawing.Size(160, 49)
        Me.cmdDeliveryFilter.TabIndex = 2
        Me.cmdDeliveryFilter.Text = "FILTER DELIVERY"
        Me.cmdDeliveryFilter.UseVisualStyleBackColor = False
        '
        'txtDelivery
        '
        Me.txtDelivery.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDelivery.Location = New System.Drawing.Point(2, 373)
        Me.txtDelivery.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtDelivery.Name = "txtDelivery"
        Me.txtDelivery.Size = New System.Drawing.Size(147, 26)
        Me.txtDelivery.TabIndex = 1
        Me.txtDelivery.Text = "Delivery"
        Me.txtDelivery.Visible = False
        '
        'cmdUpdate
        '
        Me.cmdUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUpdate.Location = New System.Drawing.Point(449, 321)
        Me.cmdUpdate.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(114, 49)
        Me.cmdUpdate.TabIndex = 8
        Me.cmdUpdate.Text = "UPDATE"
        Me.cmdUpdate.UseVisualStyleBackColor = False
        '
        'PaymentDataGridView
        '
        Me.PaymentDataGridView.AutoGenerateColumns = False
        Me.PaymentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PaymentDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23})
        Me.PaymentDataGridView.DataSource = Me.PaymentBindingSource
        Me.PaymentDataGridView.Location = New System.Drawing.Point(17, 14)
        Me.PaymentDataGridView.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PaymentDataGridView.Name = "PaymentDataGridView"
        Me.PaymentDataGridView.RowHeadersWidth = 51
        Me.PaymentDataGridView.RowTemplate.Height = 24
        Me.PaymentDataGridView.Size = New System.Drawing.Size(632, 168)
        Me.PaymentDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Payment_ID"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Payment_ID"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 125
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Promo_Code"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Promo_Code"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 125
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Order_Type"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Order_Type"
        Me.DataGridViewTextBoxColumn9.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 125
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Payment_SubTotal"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Payment_SubTotal"
        Me.DataGridViewTextBoxColumn10.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Width = 125
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Delivery_Fee"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Delivery_Fee"
        Me.DataGridViewTextBoxColumn11.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Width = 125
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Payment_Total"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Payment_Total"
        Me.DataGridViewTextBoxColumn12.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Width = 125
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Payment_Type"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Payment_Type"
        Me.DataGridViewTextBoxColumn13.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.Width = 125
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Payment_Date"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Payment_Date"
        Me.DataGridViewTextBoxColumn14.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.Width = 125
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Payment_Time"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Payment_Time"
        Me.DataGridViewTextBoxColumn15.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.Width = 125
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "Order_Status"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Order_Status"
        Me.DataGridViewTextBoxColumn16.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.Width = 125
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "Cu_Remark"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Cu_Remark"
        Me.DataGridViewTextBoxColumn17.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.Width = 125
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "Rider_ID"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Rider_ID"
        Me.DataGridViewTextBoxColumn18.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.Width = 125
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "Customer_ID"
        Me.DataGridViewTextBoxColumn19.HeaderText = "Customer_ID"
        Me.DataGridViewTextBoxColumn19.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.Width = 125
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "Cu_HP"
        Me.DataGridViewTextBoxColumn20.HeaderText = "Cu_HP"
        Me.DataGridViewTextBoxColumn20.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.Width = 125
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "Cu_Office_Inasis"
        Me.DataGridViewTextBoxColumn21.HeaderText = "Cu_Office_Inasis"
        Me.DataGridViewTextBoxColumn21.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.Width = 125
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "Cu_Block_Room"
        Me.DataGridViewTextBoxColumn22.HeaderText = "Cu_Block_Room"
        Me.DataGridViewTextBoxColumn22.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.Width = 125
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "Delivered_Time"
        Me.DataGridViewTextBoxColumn23.HeaderText = "Delivered_Time"
        Me.DataGridViewTextBoxColumn23.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.Width = 125
        '
        'PaymentBindingSource
        '
        Me.PaymentBindingSource.DataMember = "Payment"
        Me.PaymentBindingSource.DataSource = Me.UUMCafeDatabase5DataSet
        '
        'txtStaffNameID
        '
        Me.txtStaffNameID.AutoSize = True
        Me.txtStaffNameID.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStaffNameID.ForeColor = System.Drawing.Color.Green
        Me.txtStaffNameID.Location = New System.Drawing.Point(321, 21)
        Me.txtStaffNameID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.txtStaffNameID.Name = "txtStaffNameID"
        Me.txtStaffNameID.Size = New System.Drawing.Size(147, 24)
        Me.txtStaffNameID.TabIndex = 3
        Me.txtStaffNameID.Text = "(txtStaffName,ID)"
        Me.txtStaffNameID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Viner Hand ITC", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(164, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 31)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Welcome back!"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.CustomerOrderBindingNavigator.Size = New System.Drawing.Size(1091, 25)
        Me.CustomerOrderBindingNavigator.TabIndex = 5
        Me.CustomerOrderBindingNavigator.Text = "BindingNavigator1"
        Me.CustomerOrderBindingNavigator.Visible = False
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(24, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(24, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(24, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(24, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(39, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(24, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(24, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'CustomerOrderBindingNavigatorSaveItem
        '
        Me.CustomerOrderBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CustomerOrderBindingNavigatorSaveItem.Image = CType(resources.GetObject("CustomerOrderBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CustomerOrderBindingNavigatorSaveItem.Name = "CustomerOrderBindingNavigatorSaveItem"
        Me.CustomerOrderBindingNavigatorSaveItem.Size = New System.Drawing.Size(24, 22)
        Me.CustomerOrderBindingNavigatorSaveItem.Text = "Save Data"
        '
        'CustomerOrderTableAdapter
        '
        Me.CustomerOrderTableAdapter.ClearBeforeFill = True
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
        'PaymentTableAdapter
        '
        Me.PaymentTableAdapter.ClearBeforeFill = True
        '
        'cmdLogout
        '
        Me.cmdLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLogout.Location = New System.Drawing.Point(859, 40)
        Me.cmdLogout.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdLogout.Name = "cmdLogout"
        Me.cmdLogout.Size = New System.Drawing.Size(71, 42)
        Me.cmdLogout.TabIndex = 6
        Me.cmdLogout.Text = "Logout"
        Me.cmdLogout.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Location = New System.Drawing.Point(168, 58)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(649, 6)
        Me.Panel1.TabIndex = 7
        '
        'cmdExit
        '
        Me.cmdExit.BackColor = System.Drawing.Color.Transparent
        Me.cmdExit.BackgroundImage = Global.UUMCafe2.My.Resources.Resources._exit
        Me.cmdExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdExit.FlatAppearance.BorderColor = System.Drawing.Color.Lavender
        Me.cmdExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdExit.Location = New System.Drawing.Point(871, 94)
        Me.cmdExit.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(51, 49)
        Me.cmdExit.TabIndex = 7
        Me.cmdExit.UseVisualStyleBackColor = False
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Rage Italic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label24.Location = New System.Drawing.Point(646, 19)
        Me.Label24.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(176, 30)
        Me.Label24.TabIndex = 32
        Me.Label24.Text = "UUM Cafe YAB"
        '
        'txtPaymentID
        '
        Me.txtPaymentID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerOrderBindingSource, "Payment_ID", True))
        Me.txtPaymentID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPaymentID.Location = New System.Drawing.Point(134, 262)
        Me.txtPaymentID.Name = "txtPaymentID"
        Me.txtPaymentID.Size = New System.Drawing.Size(162, 23)
        Me.txtPaymentID.TabIndex = 27
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Panel2.Location = New System.Drawing.Point(320, 213)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(10, 161)
        Me.Panel2.TabIndex = 28
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(30, 213)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(260, 18)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Check for DELIVERY Type Order:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(360, 213)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(198, 18)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "Assign a RIDER to order:"
        '
        'frmStaff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(954, 483)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cmdLogout)
        Me.Controls.Add(Me.CustomerOrderBindingNavigator)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtStaffNameID)
        Me.Controls.Add(Me.pnlCustomerOrder)
        Me.Controls.Add(Me.pnlRiderDuty)
        Me.Controls.Add(Me.pnlStaffMenu)
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "frmStaff"
        Me.Text = "Staff"
        Me.pnlStaffMenu.ResumeLayout(False)
        CType(Me.PictureBox23, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCustomerOrder.ResumeLayout(False)
        Me.pnlCustomerOrder.PerformLayout()
        CType(Me.CustomerOrderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UUMCafeDatabase5DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerOrderDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlRiderDuty.ResumeLayout(False)
        Me.pnlRiderDuty.PerformLayout()
        CType(Me.PaymentDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PaymentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerOrderBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CustomerOrderBindingNavigator.ResumeLayout(False)
        Me.CustomerOrderBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlStaffMenu As Panel
    Friend WithEvents pnlOnPosition As Panel
    Friend WithEvents cmdCustomerOrder As Button
    Friend WithEvents pnlCustomerOrder As Panel
    Friend WithEvents pnlRiderDuty As Panel
    Friend WithEvents txtStaffNameID As Label
    Friend WithEvents cmdRiderDuty As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents UUMCafeDatabase5DataSet As UUMCafeDatabase5DataSet
    Friend WithEvents CustomerOrderBindingSource As BindingSource
    Friend WithEvents CustomerOrderTableAdapter As UUMCafeDatabase5DataSetTableAdapters.CustomerOrderTableAdapter
    Friend WithEvents TableAdapterManager As UUMCafeDatabase5DataSetTableAdapters.TableAdapterManager
    Friend WithEvents CustomerOrderBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents CustomerOrderBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents CustomerOrderDataGridView As DataGridView
    Friend WithEvents cmdFilterPaymentID As Button
    Friend WithEvents cmdClearFilter As Button
    Friend WithEvents PaymentBindingSource As BindingSource
    Friend WithEvents PaymentTableAdapter As UUMCafeDatabase5DataSetTableAdapters.PaymentTableAdapter
    Friend WithEvents PaymentDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
    Friend WithEvents cmdClearDeliveryFilter As Button
    Friend WithEvents cmdDeliveryFilter As Button
    Friend WithEvents txtDelivery As TextBox
    Friend WithEvents txtPaymentID2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmdUpdate As Button
    Friend WithEvents cmdLogout As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cmdExit As Button
    Friend WithEvents Label24 As Label
    Friend WithEvents PictureBox23 As PictureBox
    Friend WithEvents txtRiderID As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmdDelete1 As Button
    Friend WithEvents cmdEdit1 As Button
    Friend WithEvents cmdAdd1 As Button
    Friend WithEvents cmdMoveLast1 As Button
    Friend WithEvents cmdMoveNext1 As Button
    Friend WithEvents cmdMovePrevious1 As Button
    Friend WithEvents cmdMoveFirst1 As Button
    Friend WithEvents Order_Num As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents txtItemMenu As TextBox
    Friend WithEvents txtCustomerName As TextBox
    Friend WithEvents txtCustomerID As TextBox
    Friend WithEvents txtOrderNum As TextBox
    Friend WithEvents cmdFilterItemMenu As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents cmdFilterCustomerName As Button
    Friend WithEvents cmdFilterCustomerID As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cmdFilterOrderNum As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPaymentID As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
End Class
