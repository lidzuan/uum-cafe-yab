<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTracking
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTracking))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPaymentID = New System.Windows.Forms.TextBox()
        Me.UUMCafeDatabase5DataSet = New UUMCafe2.UUMCafeDatabase5DataSet()
        Me.CustomerOrderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerOrderTableAdapter = New UUMCafe2.UUMCafeDatabase5DataSetTableAdapters.CustomerOrderTableAdapter()
        Me.TableAdapterManager = New UUMCafe2.UUMCafeDatabase5DataSetTableAdapters.TableAdapterManager()
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
        Me.CustomerOrderDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCuRemark = New System.Windows.Forms.TextBox()
        Me.txtTotalPrice = New System.Windows.Forms.TextBox()
        Me.txtOrderStatus = New System.Windows.Forms.TextBox()
        Me.txtOfficeInasis = New System.Windows.Forms.TextBox()
        Me.txtBlockRoom = New System.Windows.Forms.TextBox()
        Me.txtRiderName = New System.Windows.Forms.TextBox()
        Me.txtRiderHP = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtPaymentType = New System.Windows.Forms.TextBox()
        Me.cmdCheckTracking = New System.Windows.Forms.Button()
        Me.txtRiderID = New System.Windows.Forms.TextBox()
        Me.cmdBack = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.UUMCafeDatabase5DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerOrderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerOrderBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CustomerOrderBindingNavigator.SuspendLayout()
        CType(Me.CustomerOrderDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("qtquickcontrols", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 25)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(237, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "To track your order," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "please insert your payment ID:"
        '
        'txtPaymentID
        '
        Me.txtPaymentID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPaymentID.Location = New System.Drawing.Point(22, 77)
        Me.txtPaymentID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtPaymentID.Name = "txtPaymentID"
        Me.txtPaymentID.Size = New System.Drawing.Size(140, 26)
        Me.txtPaymentID.TabIndex = 1
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
        Me.CustomerOrderBindingNavigator.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.CustomerOrderBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CustomerOrderBindingNavigator.Size = New System.Drawing.Size(896, 27)
        Me.CustomerOrderBindingNavigator.TabIndex = 2
        Me.CustomerOrderBindingNavigator.Text = "BindingNavigator1"
        Me.CustomerOrderBindingNavigator.Visible = False
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 24)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
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
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'CustomerOrderBindingNavigatorSaveItem
        '
        Me.CustomerOrderBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CustomerOrderBindingNavigatorSaveItem.Image = CType(resources.GetObject("CustomerOrderBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CustomerOrderBindingNavigatorSaveItem.Name = "CustomerOrderBindingNavigatorSaveItem"
        Me.CustomerOrderBindingNavigatorSaveItem.Size = New System.Drawing.Size(24, 24)
        Me.CustomerOrderBindingNavigatorSaveItem.Text = "Save Data"
        '
        'CustomerOrderDataGridView
        '
        Me.CustomerOrderDataGridView.AllowUserToAddRows = False
        Me.CustomerOrderDataGridView.AllowUserToDeleteRows = False
        Me.CustomerOrderDataGridView.AutoGenerateColumns = False
        Me.CustomerOrderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CustomerOrderDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.CustomerOrderDataGridView.DataSource = Me.CustomerOrderBindingSource
        Me.CustomerOrderDataGridView.Location = New System.Drawing.Point(346, 24)
        Me.CustomerOrderDataGridView.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CustomerOrderDataGridView.Name = "CustomerOrderDataGridView"
        Me.CustomerOrderDataGridView.ReadOnly = True
        Me.CustomerOrderDataGridView.RowHeadersWidth = 51
        Me.CustomerOrderDataGridView.RowTemplate.Height = 24
        Me.CustomerOrderDataGridView.Size = New System.Drawing.Size(530, 179)
        Me.CustomerOrderDataGridView.TabIndex = 3
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
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Order_Num"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Order_Num"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 125
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 144)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(228, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Here are your order details:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(407, 226)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(418, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Here are the details of the RIDER assigned to you:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(56, 179)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Order status:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(22, 120)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(296, 8)
        Me.Panel1.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(27, 206)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Total price (RM):"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(41, 233)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(113, 20)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Payment Type:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(20, 259)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(135, 20)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Customer remark:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(47, 311)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(109, 20)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Office / Inasis:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(47, 338)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(107, 20)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Block / Room:"
        '
        'txtCuRemark
        '
        Me.txtCuRemark.Enabled = False
        Me.txtCuRemark.Font = New System.Drawing.Font("qtquickcontrols", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuRemark.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCuRemark.Location = New System.Drawing.Point(160, 257)
        Me.txtCuRemark.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtCuRemark.Multiline = True
        Me.txtCuRemark.Name = "txtCuRemark"
        Me.txtCuRemark.ReadOnly = True
        Me.txtCuRemark.Size = New System.Drawing.Size(206, 49)
        Me.txtCuRemark.TabIndex = 13
        '
        'txtTotalPrice
        '
        Me.txtTotalPrice.Enabled = False
        Me.txtTotalPrice.Font = New System.Drawing.Font("qtquickcontrols", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalPrice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTotalPrice.Location = New System.Drawing.Point(160, 204)
        Me.txtTotalPrice.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTotalPrice.Name = "txtTotalPrice"
        Me.txtTotalPrice.ReadOnly = True
        Me.txtTotalPrice.Size = New System.Drawing.Size(83, 25)
        Me.txtTotalPrice.TabIndex = 15
        '
        'txtOrderStatus
        '
        Me.txtOrderStatus.Enabled = False
        Me.txtOrderStatus.Font = New System.Drawing.Font("qtquickcontrols", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrderStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtOrderStatus.Location = New System.Drawing.Point(160, 177)
        Me.txtOrderStatus.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtOrderStatus.Name = "txtOrderStatus"
        Me.txtOrderStatus.ReadOnly = True
        Me.txtOrderStatus.Size = New System.Drawing.Size(140, 25)
        Me.txtOrderStatus.TabIndex = 16
        '
        'txtOfficeInasis
        '
        Me.txtOfficeInasis.Enabled = False
        Me.txtOfficeInasis.Font = New System.Drawing.Font("qtquickcontrols", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOfficeInasis.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtOfficeInasis.Location = New System.Drawing.Point(160, 309)
        Me.txtOfficeInasis.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtOfficeInasis.Name = "txtOfficeInasis"
        Me.txtOfficeInasis.ReadOnly = True
        Me.txtOfficeInasis.Size = New System.Drawing.Size(140, 25)
        Me.txtOfficeInasis.TabIndex = 17
        '
        'txtBlockRoom
        '
        Me.txtBlockRoom.Enabled = False
        Me.txtBlockRoom.Font = New System.Drawing.Font("qtquickcontrols", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBlockRoom.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtBlockRoom.Location = New System.Drawing.Point(160, 336)
        Me.txtBlockRoom.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtBlockRoom.Name = "txtBlockRoom"
        Me.txtBlockRoom.ReadOnly = True
        Me.txtBlockRoom.Size = New System.Drawing.Size(140, 25)
        Me.txtBlockRoom.TabIndex = 18
        '
        'txtRiderName
        '
        Me.txtRiderName.Enabled = False
        Me.txtRiderName.Font = New System.Drawing.Font("qtquickcontrols", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRiderName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtRiderName.Location = New System.Drawing.Point(550, 259)
        Me.txtRiderName.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtRiderName.Name = "txtRiderName"
        Me.txtRiderName.ReadOnly = True
        Me.txtRiderName.Size = New System.Drawing.Size(200, 25)
        Me.txtRiderName.TabIndex = 22
        '
        'txtRiderHP
        '
        Me.txtRiderHP.Enabled = False
        Me.txtRiderHP.Font = New System.Drawing.Font("qtquickcontrols", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRiderHP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtRiderHP.Location = New System.Drawing.Point(550, 286)
        Me.txtRiderHP.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtRiderHP.Name = "txtRiderHP"
        Me.txtRiderHP.ReadOnly = True
        Me.txtRiderHP.Size = New System.Drawing.Size(200, 25)
        Me.txtRiderHP.TabIndex = 21
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(468, 288)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 20)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Rider HP:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(450, 261)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(95, 20)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Rider name:"
        '
        'txtPaymentType
        '
        Me.txtPaymentType.Enabled = False
        Me.txtPaymentType.Font = New System.Drawing.Font("qtquickcontrols", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPaymentType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPaymentType.Location = New System.Drawing.Point(160, 231)
        Me.txtPaymentType.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtPaymentType.Name = "txtPaymentType"
        Me.txtPaymentType.ReadOnly = True
        Me.txtPaymentType.Size = New System.Drawing.Size(140, 25)
        Me.txtPaymentType.TabIndex = 23
        '
        'cmdCheckTracking
        '
        Me.cmdCheckTracking.BackColor = System.Drawing.Color.Yellow
        Me.cmdCheckTracking.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdCheckTracking.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCheckTracking.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCheckTracking.Location = New System.Drawing.Point(196, 71)
        Me.cmdCheckTracking.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmdCheckTracking.Name = "cmdCheckTracking"
        Me.cmdCheckTracking.Size = New System.Drawing.Size(122, 33)
        Me.cmdCheckTracking.TabIndex = 24
        Me.cmdCheckTracking.Text = "CHECK"
        Me.cmdCheckTracking.UseVisualStyleBackColor = False
        '
        'txtRiderID
        '
        Me.txtRiderID.Enabled = False
        Me.txtRiderID.Font = New System.Drawing.Font("qtquickcontrols", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRiderID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtRiderID.Location = New System.Drawing.Point(391, 326)
        Me.txtRiderID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtRiderID.Name = "txtRiderID"
        Me.txtRiderID.ReadOnly = True
        Me.txtRiderID.Size = New System.Drawing.Size(200, 25)
        Me.txtRiderID.TabIndex = 27
        Me.txtRiderID.Visible = False
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
        Me.cmdBack.ForeColor = System.Drawing.Color.Transparent
        Me.cmdBack.Location = New System.Drawing.Point(809, 293)
        Me.cmdBack.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmdBack.Name = "cmdBack"
        Me.cmdBack.Size = New System.Drawing.Size(67, 65)
        Me.cmdBack.TabIndex = 28
        Me.cmdBack.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.UUMCafe2.My.Resources.Resources.rider
        Me.PictureBox2.Location = New System.Drawing.Point(471, 207)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(177, 168)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 31
        Me.PictureBox2.TabStop = False
        '
        'frmTracking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.UUMCafe2.My.Resources.Resources.tracking
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(907, 375)
        Me.Controls.Add(Me.txtRiderName)
        Me.Controls.Add(Me.txtRiderHP)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmdBack)
        Me.Controls.Add(Me.txtRiderID)
        Me.Controls.Add(Me.cmdCheckTracking)
        Me.Controls.Add(Me.txtPaymentType)
        Me.Controls.Add(Me.txtBlockRoom)
        Me.Controls.Add(Me.txtOfficeInasis)
        Me.Controls.Add(Me.txtOrderStatus)
        Me.Controls.Add(Me.txtTotalPrice)
        Me.Controls.Add(Me.txtCuRemark)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CustomerOrderDataGridView)
        Me.Controls.Add(Me.txtPaymentID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.CustomerOrderBindingNavigator)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmTracking"
        Me.Text = "Track my order!"
        CType(Me.UUMCafeDatabase5DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerOrderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerOrderBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CustomerOrderBindingNavigator.ResumeLayout(False)
        Me.CustomerOrderBindingNavigator.PerformLayout()
        CType(Me.CustomerOrderDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtPaymentID As TextBox
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
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtCuRemark As TextBox
    Friend WithEvents txtTotalPrice As TextBox
    Friend WithEvents txtOrderStatus As TextBox
    Friend WithEvents txtOfficeInasis As TextBox
    Friend WithEvents txtBlockRoom As TextBox
    Friend WithEvents txtRiderName As TextBox
    Friend WithEvents txtRiderHP As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtPaymentType As TextBox
    Friend WithEvents cmdCheckTracking As Button
    Friend WithEvents txtRiderID As TextBox
    Friend WithEvents cmdBack As Button
    Friend WithEvents PictureBox2 As PictureBox
End Class
