<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustMainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCustMainMenu))
        Me.cmdOrder = New System.Windows.Forms.Button()
        Me.cmdTracking = New System.Windows.Forms.Button()
        Me.cmdFeedback = New System.Windows.Forms.Button()
        Me.cmdLogout = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdOrder
        '
        Me.cmdOrder.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdOrder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdOrder.Font = New System.Drawing.Font("Ink Free", 22.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOrder.Location = New System.Drawing.Point(44, 380)
        Me.cmdOrder.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdOrder.Name = "cmdOrder"
        Me.cmdOrder.Size = New System.Drawing.Size(246, 145)
        Me.cmdOrder.TabIndex = 0
        Me.cmdOrder.Text = "Order"
        Me.cmdOrder.UseVisualStyleBackColor = False
        '
        'cmdTracking
        '
        Me.cmdTracking.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdTracking.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdTracking.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdTracking.Font = New System.Drawing.Font("Ink Free", 22.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdTracking.Location = New System.Drawing.Point(344, 380)
        Me.cmdTracking.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdTracking.Name = "cmdTracking"
        Me.cmdTracking.Size = New System.Drawing.Size(246, 145)
        Me.cmdTracking.TabIndex = 1
        Me.cmdTracking.Text = "Tracking"
        Me.cmdTracking.UseVisualStyleBackColor = False
        '
        'cmdFeedback
        '
        Me.cmdFeedback.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdFeedback.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdFeedback.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdFeedback.Font = New System.Drawing.Font("Ink Free", 22.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFeedback.Location = New System.Drawing.Point(644, 380)
        Me.cmdFeedback.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdFeedback.Name = "cmdFeedback"
        Me.cmdFeedback.Size = New System.Drawing.Size(246, 145)
        Me.cmdFeedback.TabIndex = 2
        Me.cmdFeedback.Text = "Feedback"
        Me.cmdFeedback.UseVisualStyleBackColor = False
        '
        'cmdLogout
        '
        Me.cmdLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLogout.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdLogout.Location = New System.Drawing.Point(985, 41)
        Me.cmdLogout.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdLogout.Name = "cmdLogout"
        Me.cmdLogout.Size = New System.Drawing.Size(115, 54)
        Me.cmdLogout.TabIndex = 4
        Me.cmdLogout.Text = "Logout"
        Me.cmdLogout.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Location = New System.Drawing.Point(964, 125)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(225, 10)
        Me.Panel1.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Rage Italic", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label6.Location = New System.Drawing.Point(920, 152)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(313, 55)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "UUM Cafe YAB"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.UUMCafe2.My.Resources.Resources.Restaurant
        Me.PictureBox2.Location = New System.Drawing.Point(937, 210)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(286, 315)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.UUMCafe2.My.Resources.Resources.exiticon
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(1116, 41)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(51, 54)
        Me.Button1.TabIndex = 6
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(44, 41)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(846, 304)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'frmCustMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Linen
        Me.BackgroundImage = Global.UUMCafe2.My.Resources.Resources.background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1262, 562)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cmdLogout)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cmdFeedback)
        Me.Controls.Add(Me.cmdTracking)
        Me.Controls.Add(Me.cmdOrder)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmCustMainMenu"
        Me.Text = "Welcome, Customer!"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdOrder As Button
    Friend WithEvents cmdTracking As Button
    Friend WithEvents cmdFeedback As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cmdLogout As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label6 As Label
End Class
