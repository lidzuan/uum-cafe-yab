<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewCu
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
        Dim Customer_IDLabel As System.Windows.Forms.Label
        Dim Cu_NameLabel As System.Windows.Forms.Label
        Dim Cu_UsernameLabel As System.Windows.Forms.Label
        Dim Cu_PasswordLabel As System.Windows.Forms.Label
        Dim Cu_EmailLabel As System.Windows.Forms.Label
        Dim Cu_HPLabel As System.Windows.Forms.Label
        Dim Reg_DateLabel As System.Windows.Forms.Label
        Dim Cu_StatusLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNewCu))
        Me.CustomerBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UUMCafeDatabase5DataSet = New UUMCafe2.UUMCafeDatabase5DataSet()
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
        Me.CustomerBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.cmdAddNew = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCuID = New System.Windows.Forms.TextBox()
        Me.txtCuName = New System.Windows.Forms.TextBox()
        Me.txtCuUsername = New System.Windows.Forms.TextBox()
        Me.txtCuPassword = New System.Windows.Forms.TextBox()
        Me.txtCuEmail = New System.Windows.Forms.TextBox()
        Me.txtCuHP = New System.Windows.Forms.TextBox()
        Me.txtCuRegistration = New System.Windows.Forms.DateTimePicker()
        Me.txtCuStatus = New System.Windows.Forms.ComboBox()
        Me.CustomerTableAdapter = New UUMCafe2.UUMCafeDatabase5DataSetTableAdapters.CustomerTableAdapter()
        Me.TableAdapterManager = New UUMCafe2.UUMCafeDatabase5DataSetTableAdapters.TableAdapterManager()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Customer_IDLabel = New System.Windows.Forms.Label()
        Cu_NameLabel = New System.Windows.Forms.Label()
        Cu_UsernameLabel = New System.Windows.Forms.Label()
        Cu_PasswordLabel = New System.Windows.Forms.Label()
        Cu_EmailLabel = New System.Windows.Forms.Label()
        Cu_HPLabel = New System.Windows.Forms.Label()
        Reg_DateLabel = New System.Windows.Forms.Label()
        Cu_StatusLabel = New System.Windows.Forms.Label()
        CType(Me.CustomerBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CustomerBindingNavigator.SuspendLayout()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UUMCafeDatabase5DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Customer_IDLabel
        '
        Customer_IDLabel.AutoSize = True
        Customer_IDLabel.BackColor = System.Drawing.Color.Transparent
        Customer_IDLabel.Font = New System.Drawing.Font("qtquickcontrols", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Customer_IDLabel.Location = New System.Drawing.Point(63, 86)
        Customer_IDLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Customer_IDLabel.Name = "Customer_IDLabel"
        Customer_IDLabel.Size = New System.Drawing.Size(96, 17)
        Customer_IDLabel.TabIndex = 1
        Customer_IDLabel.Text = "Customer ID:"
        '
        'Cu_NameLabel
        '
        Cu_NameLabel.AutoSize = True
        Cu_NameLabel.BackColor = System.Drawing.Color.Transparent
        Cu_NameLabel.Font = New System.Drawing.Font("qtquickcontrols", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cu_NameLabel.Location = New System.Drawing.Point(103, 116)
        Cu_NameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Cu_NameLabel.Name = "Cu_NameLabel"
        Cu_NameLabel.Size = New System.Drawing.Size(53, 17)
        Cu_NameLabel.TabIndex = 3
        Cu_NameLabel.Text = "Name:"
        '
        'Cu_UsernameLabel
        '
        Cu_UsernameLabel.AutoSize = True
        Cu_UsernameLabel.BackColor = System.Drawing.Color.Transparent
        Cu_UsernameLabel.Font = New System.Drawing.Font("qtquickcontrols", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cu_UsernameLabel.Location = New System.Drawing.Point(76, 145)
        Cu_UsernameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Cu_UsernameLabel.Name = "Cu_UsernameLabel"
        Cu_UsernameLabel.Size = New System.Drawing.Size(83, 17)
        Cu_UsernameLabel.TabIndex = 5
        Cu_UsernameLabel.Text = "Username:"
        '
        'Cu_PasswordLabel
        '
        Cu_PasswordLabel.AutoSize = True
        Cu_PasswordLabel.BackColor = System.Drawing.Color.Transparent
        Cu_PasswordLabel.Font = New System.Drawing.Font("qtquickcontrols", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cu_PasswordLabel.Location = New System.Drawing.Point(79, 174)
        Cu_PasswordLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Cu_PasswordLabel.Name = "Cu_PasswordLabel"
        Cu_PasswordLabel.Size = New System.Drawing.Size(80, 17)
        Cu_PasswordLabel.TabIndex = 7
        Cu_PasswordLabel.Text = "Password:"
        '
        'Cu_EmailLabel
        '
        Cu_EmailLabel.AutoSize = True
        Cu_EmailLabel.BackColor = System.Drawing.Color.Transparent
        Cu_EmailLabel.Font = New System.Drawing.Font("qtquickcontrols", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cu_EmailLabel.Location = New System.Drawing.Point(105, 203)
        Cu_EmailLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Cu_EmailLabel.Name = "Cu_EmailLabel"
        Cu_EmailLabel.Size = New System.Drawing.Size(51, 17)
        Cu_EmailLabel.TabIndex = 9
        Cu_EmailLabel.Text = "Email:"
        '
        'Cu_HPLabel
        '
        Cu_HPLabel.AutoSize = True
        Cu_HPLabel.BackColor = System.Drawing.Color.Transparent
        Cu_HPLabel.Font = New System.Drawing.Font("qtquickcontrols", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cu_HPLabel.Location = New System.Drawing.Point(117, 233)
        Cu_HPLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Cu_HPLabel.Name = "Cu_HPLabel"
        Cu_HPLabel.Size = New System.Drawing.Size(38, 17)
        Cu_HPLabel.TabIndex = 11
        Cu_HPLabel.Text = "H/P:"
        '
        'Reg_DateLabel
        '
        Reg_DateLabel.AutoSize = True
        Reg_DateLabel.BackColor = System.Drawing.Color.Transparent
        Reg_DateLabel.Font = New System.Drawing.Font("qtquickcontrols", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Reg_DateLabel.Location = New System.Drawing.Point(34, 263)
        Reg_DateLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Reg_DateLabel.Name = "Reg_DateLabel"
        Reg_DateLabel.Size = New System.Drawing.Size(133, 17)
        Reg_DateLabel.TabIndex = 26
        Reg_DateLabel.Text = "Registration Date:"
        '
        'Cu_StatusLabel
        '
        Cu_StatusLabel.AutoSize = True
        Cu_StatusLabel.BackColor = System.Drawing.Color.Transparent
        Cu_StatusLabel.Font = New System.Drawing.Font("qtquickcontrols", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cu_StatusLabel.Location = New System.Drawing.Point(39, 291)
        Cu_StatusLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Cu_StatusLabel.Name = "Cu_StatusLabel"
        Cu_StatusLabel.Size = New System.Drawing.Size(124, 17)
        Cu_StatusLabel.TabIndex = 28
        Cu_StatusLabel.Text = "Customer Status:"
        '
        'CustomerBindingNavigator
        '
        Me.CustomerBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CustomerBindingNavigator.BindingSource = Me.CustomerBindingSource
        Me.CustomerBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CustomerBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CustomerBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.CustomerBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CustomerBindingNavigatorSaveItem})
        Me.CustomerBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CustomerBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CustomerBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CustomerBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CustomerBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CustomerBindingNavigator.Name = "CustomerBindingNavigator"
        Me.CustomerBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CustomerBindingNavigator.Size = New System.Drawing.Size(600, 20)
        Me.CustomerBindingNavigator.TabIndex = 0
        Me.CustomerBindingNavigator.Text = "BindingNavigator1"
        Me.CustomerBindingNavigator.Visible = False
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
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataMember = "Customer"
        Me.CustomerBindingSource.DataSource = Me.UUMCafeDatabase5DataSet
        '
        'UUMCafeDatabase5DataSet
        '
        Me.UUMCafeDatabase5DataSet.DataSetName = "UUMCafeDatabase5DataSet"
        Me.UUMCafeDatabase5DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 17)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
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
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(39, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
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
        'CustomerBindingNavigatorSaveItem
        '
        Me.CustomerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CustomerBindingNavigatorSaveItem.Image = CType(resources.GetObject("CustomerBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CustomerBindingNavigatorSaveItem.Name = "CustomerBindingNavigatorSaveItem"
        Me.CustomerBindingNavigatorSaveItem.Size = New System.Drawing.Size(24, 17)
        Me.CustomerBindingNavigatorSaveItem.Text = "Save Data"
        '
        'cmdAddNew
        '
        Me.cmdAddNew.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.cmdAddNew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAddNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAddNew.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAddNew.Location = New System.Drawing.Point(159, 343)
        Me.cmdAddNew.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdAddNew.Name = "cmdAddNew"
        Me.cmdAddNew.Size = New System.Drawing.Size(133, 38)
        Me.cmdAddNew.TabIndex = 17
        Me.cmdAddNew.Text = "REGISTER"
        Me.cmdAddNew.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(89, 29)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(207, 26)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "NEW CUSTOMER"
        '
        'txtCuID
        '
        Me.txtCuID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuID.Location = New System.Drawing.Point(181, 83)
        Me.txtCuID.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtCuID.Name = "txtCuID"
        Me.txtCuID.Size = New System.Drawing.Size(135, 26)
        Me.txtCuID.TabIndex = 19
        '
        'txtCuName
        '
        Me.txtCuName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuName.Location = New System.Drawing.Point(181, 112)
        Me.txtCuName.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtCuName.Name = "txtCuName"
        Me.txtCuName.Size = New System.Drawing.Size(227, 26)
        Me.txtCuName.TabIndex = 20
        '
        'txtCuUsername
        '
        Me.txtCuUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuUsername.Location = New System.Drawing.Point(181, 142)
        Me.txtCuUsername.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtCuUsername.Name = "txtCuUsername"
        Me.txtCuUsername.Size = New System.Drawing.Size(135, 26)
        Me.txtCuUsername.TabIndex = 21
        '
        'txtCuPassword
        '
        Me.txtCuPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuPassword.Location = New System.Drawing.Point(181, 171)
        Me.txtCuPassword.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtCuPassword.Name = "txtCuPassword"
        Me.txtCuPassword.Size = New System.Drawing.Size(135, 26)
        Me.txtCuPassword.TabIndex = 22
        '
        'txtCuEmail
        '
        Me.txtCuEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuEmail.Location = New System.Drawing.Point(181, 200)
        Me.txtCuEmail.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtCuEmail.Name = "txtCuEmail"
        Me.txtCuEmail.Size = New System.Drawing.Size(227, 26)
        Me.txtCuEmail.TabIndex = 23
        '
        'txtCuHP
        '
        Me.txtCuHP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuHP.Location = New System.Drawing.Point(181, 229)
        Me.txtCuHP.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtCuHP.Name = "txtCuHP"
        Me.txtCuHP.Size = New System.Drawing.Size(135, 26)
        Me.txtCuHP.TabIndex = 24
        '
        'txtCuRegistration
        '
        Me.txtCuRegistration.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuRegistration.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtCuRegistration.Location = New System.Drawing.Point(181, 259)
        Me.txtCuRegistration.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtCuRegistration.Name = "txtCuRegistration"
        Me.txtCuRegistration.Size = New System.Drawing.Size(227, 26)
        Me.txtCuRegistration.TabIndex = 27
        '
        'txtCuStatus
        '
        Me.txtCuStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuStatus.FormattingEnabled = True
        Me.txtCuStatus.Items.AddRange(New Object() {"Normal", "Premium"})
        Me.txtCuStatus.Location = New System.Drawing.Point(181, 288)
        Me.txtCuStatus.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtCuStatus.Name = "txtCuStatus"
        Me.txtCuStatus.Size = New System.Drawing.Size(227, 28)
        Me.txtCuStatus.TabIndex = 28
        '
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CustomerAccountTableAdapter = Nothing
        Me.TableAdapterManager.CustomerOrderTableAdapter = Nothing
        Me.TableAdapterManager.CustomerTableAdapter = Me.CustomerTableAdapter
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
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.UUMCafe2.My.Resources.Resources.back
        Me.PictureBox1.Location = New System.Drawing.Point(27, 23)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(39, 35)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 29
        Me.PictureBox1.TabStop = False
        '
        'frmNewCu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.UUMCafe2.My.Resources.Resources.background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(456, 411)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Cu_StatusLabel)
        Me.Controls.Add(Me.txtCuStatus)
        Me.Controls.Add(Me.txtCuRegistration)
        Me.Controls.Add(Reg_DateLabel)
        Me.Controls.Add(Me.txtCuHP)
        Me.Controls.Add(Me.txtCuEmail)
        Me.Controls.Add(Me.txtCuPassword)
        Me.Controls.Add(Me.txtCuUsername)
        Me.Controls.Add(Me.txtCuName)
        Me.Controls.Add(Me.txtCuID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdAddNew)
        Me.Controls.Add(Cu_HPLabel)
        Me.Controls.Add(Cu_EmailLabel)
        Me.Controls.Add(Cu_PasswordLabel)
        Me.Controls.Add(Cu_UsernameLabel)
        Me.Controls.Add(Cu_NameLabel)
        Me.Controls.Add(Customer_IDLabel)
        Me.Controls.Add(Me.CustomerBindingNavigator)
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "frmNewCu"
        Me.Text = "New Customer Registration"
        CType(Me.CustomerBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CustomerBindingNavigator.ResumeLayout(False)
        Me.CustomerBindingNavigator.PerformLayout()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UUMCafeDatabase5DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UUMCafeDatabase5DataSet As UUMCafeDatabase5DataSet
    Friend WithEvents CustomerBindingSource As BindingSource
    Friend WithEvents CustomerTableAdapter As UUMCafeDatabase5DataSetTableAdapters.CustomerTableAdapter
    Friend WithEvents TableAdapterManager As UUMCafeDatabase5DataSetTableAdapters.TableAdapterManager
    Friend WithEvents CustomerBindingNavigator As BindingNavigator
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
    Friend WithEvents CustomerBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents cmdAddNew As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCuID As TextBox
    Friend WithEvents txtCuName As TextBox
    Friend WithEvents txtCuUsername As TextBox
    Friend WithEvents txtCuPassword As TextBox
    Friend WithEvents txtCuEmail As TextBox
    Friend WithEvents txtCuHP As TextBox
    Friend WithEvents txtCuRegistration As DateTimePicker
    Friend WithEvents txtCuStatus As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
