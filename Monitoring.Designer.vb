<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Monitoring
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Monitoring))
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Customer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Divisi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Month = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AWB = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Penerima = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TglPenerima = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.txtDivisi = New System.Windows.Forms.TextBox()
        Me.txtCustomer = New System.Windows.Forms.TextBox()
        Me.dtpTglPenerima = New System.Windows.Forms.DateTimePicker()
        Me.txtMonth = New System.Windows.Forms.TextBox()
        Me.txtAWB = New System.Windows.Forms.TextBox()
        Me.txtPenerima = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtTransID = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtTRNo = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnAddNew = New System.Windows.Forms.ToolStripButton()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.btnReport = New System.Windows.Forms.ToolStripButton()
        Me.btnClose = New System.Windows.Forms.ToolStripButton()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(230, -48)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(32, 37)
        Me.btnBrowse.TabIndex = 61
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(-29, -48)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "TR No :"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Customer, Me.Divisi, Me.Month, Me.AWB, Me.Status, Me.Penerima, Me.TglPenerima})
        Me.DataGridView1.Location = New System.Drawing.Point(-4, 298)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(956, 341)
        Me.DataGridView1.TabIndex = 64
        '
        'ID
        '
        Me.ID.DataPropertyName = "TransID"
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        '
        'Customer
        '
        Me.Customer.DataPropertyName = "Customer"
        Me.Customer.HeaderText = "Costumer"
        Me.Customer.Name = "Customer"
        '
        'Divisi
        '
        Me.Divisi.DataPropertyName = "Divisi"
        Me.Divisi.HeaderText = "Divisi"
        Me.Divisi.Name = "Divisi"
        '
        'Month
        '
        Me.Month.DataPropertyName = "Month"
        Me.Month.HeaderText = "Month"
        Me.Month.Name = "Month"
        '
        'AWB
        '
        Me.AWB.DataPropertyName = "AWB"
        Me.AWB.HeaderText = "AWB"
        Me.AWB.Name = "AWB"
        '
        'Status
        '
        Me.Status.DataPropertyName = "Status"
        Me.Status.HeaderText = "Status"
        Me.Status.Name = "Status"
        '
        'Penerima
        '
        Me.Penerima.DataPropertyName = "Penerima"
        Me.Penerima.HeaderText = "Penerima"
        Me.Penerima.Name = "Penerima"
        '
        'TglPenerima
        '
        Me.TglPenerima.HeaderText = "TglPenerima"
        Me.TglPenerima.Name = "TglPenerima"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.txtStatus)
        Me.GroupBox2.Controls.Add(Me.txtDivisi)
        Me.GroupBox2.Controls.Add(Me.txtCustomer)
        Me.GroupBox2.Controls.Add(Me.dtpTglPenerima)
        Me.GroupBox2.Controls.Add(Me.txtMonth)
        Me.GroupBox2.Controls.Add(Me.txtAWB)
        Me.GroupBox2.Controls.Add(Me.txtPenerima)
        Me.GroupBox2.Controls.Add(Me.btnAdd)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(30, 81)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(344, 211)
        Me.GroupBox2.TabIndex = 63
        Me.GroupBox2.TabStop = False
        '
        'txtStatus
        '
        Me.txtStatus.Location = New System.Drawing.Point(103, 134)
        Me.txtStatus.Margin = New System.Windows.Forms.Padding(2)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Size = New System.Drawing.Size(207, 20)
        Me.txtStatus.TabIndex = 67
        '
        'txtDivisi
        '
        Me.txtDivisi.Location = New System.Drawing.Point(103, 41)
        Me.txtDivisi.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDivisi.Name = "txtDivisi"
        Me.txtDivisi.Size = New System.Drawing.Size(207, 20)
        Me.txtDivisi.TabIndex = 67
        '
        'txtCustomer
        '
        Me.txtCustomer.Location = New System.Drawing.Point(103, 18)
        Me.txtCustomer.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCustomer.Name = "txtCustomer"
        Me.txtCustomer.Size = New System.Drawing.Size(207, 20)
        Me.txtCustomer.TabIndex = 68
        '
        'dtpTglPenerima
        '
        Me.dtpTglPenerima.CustomFormat = "yyyy/MM/dd HH:mm"
        Me.dtpTglPenerima.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTglPenerima.Location = New System.Drawing.Point(103, 157)
        Me.dtpTglPenerima.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpTglPenerima.Name = "dtpTglPenerima"
        Me.dtpTglPenerima.Size = New System.Drawing.Size(151, 20)
        Me.dtpTglPenerima.TabIndex = 66
        '
        'txtMonth
        '
        Me.txtMonth.Location = New System.Drawing.Point(103, 64)
        Me.txtMonth.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMonth.Name = "txtMonth"
        Me.txtMonth.Size = New System.Drawing.Size(207, 20)
        Me.txtMonth.TabIndex = 62
        '
        'txtAWB
        '
        Me.txtAWB.Location = New System.Drawing.Point(103, 110)
        Me.txtAWB.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAWB.Name = "txtAWB"
        Me.txtAWB.Size = New System.Drawing.Size(207, 20)
        Me.txtAWB.TabIndex = 61
        '
        'txtPenerima
        '
        Me.txtPenerima.Location = New System.Drawing.Point(103, 87)
        Me.txtPenerima.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPenerima.Name = "txtPenerima"
        Me.txtPenerima.Size = New System.Drawing.Size(207, 20)
        Me.txtPenerima.TabIndex = 60
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(103, 182)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(86, 19)
        Me.btnAdd.TabIndex = 58
        Me.btnAdd.Text = "Add Details"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(58, 44)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Divisi :"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(38, 19)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(57, 13)
        Me.Label16.TabIndex = 22
        Me.Label16.Text = "Customer :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(25, 161)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(75, 13)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Tgl Penerima :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(56, 137)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Status :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(60, 113)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "AWB :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(40, 90)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Penerima :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(54, 67)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Month :"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.txtTransID)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtTRNo)
        Me.GroupBox1.Location = New System.Drawing.Point(30, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(309, 63)
        Me.GroupBox1.TabIndex = 65
        Me.GroupBox1.TabStop = False
        '
        'txtTransID
        '
        Me.txtTransID.Enabled = False
        Me.txtTransID.Location = New System.Drawing.Point(60, 40)
        Me.txtTransID.Name = "txtTransID"
        Me.txtTransID.ShortcutsEnabled = False
        Me.txtTransID.Size = New System.Drawing.Size(207, 20)
        Me.txtTransID.TabIndex = 67
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(272, 18)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(32, 37)
        Me.Button1.TabIndex = 28
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 18)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "TR No :"
        '
        'txtTRNo
        '
        Me.txtTRNo.Enabled = False
        Me.txtTRNo.Location = New System.Drawing.Point(60, 15)
        Me.txtTRNo.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTRNo.Name = "txtTRNo"
        Me.txtTRNo.Size = New System.Drawing.Size(207, 20)
        Me.txtTRNo.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.White
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAddNew, Me.btnSave, Me.btnReport, Me.btnClose})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 460)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(839, 71)
        Me.ToolStrip1.TabIndex = 66
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnAddNew
        '
        Me.btnAddNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnAddNew.Image = CType(resources.GetObject("btnAddNew.Image"), System.Drawing.Image)
        Me.btnAddNew.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnAddNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(47, 68)
        Me.btnAddNew.Text = "New Transaction"
        '
        'btnSave
        '
        Me.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(46, 68)
        Me.btnSave.Text = "Save"
        '
        'btnReport
        '
        Me.btnReport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnReport.Image = CType(resources.GetObject("btnReport.Image"), System.Drawing.Image)
        Me.btnReport.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnReport.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(39, 68)
        Me.btnReport.Text = "Report"
        '
        'btnClose
        '
        Me.btnClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(38, 68)
        Me.btnClose.Text = "Close"
        '
        'Monitoring
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(839, 531)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "Monitoring"
        Me.Text = "Monitoring"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBrowse As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpTglTraining As DateTimePicker
    Friend WithEvents Label16 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cbJenis As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtDurasi As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNamaTraining As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txtPenerima As TextBox
    Friend WithEvents txtAWB As TextBox
    Friend WithEvents dtpTglPenerima As DateTimePicker
    Friend WithEvents txtMonth As TextBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnAddNew As ToolStripButton
    Friend WithEvents btnSave As ToolStripButton
    Friend WithEvents btnReport As ToolStripButton
    Friend WithEvents btnClose As ToolStripButton
    Friend WithEvents txtTransID As TextBox
    Friend WithEvents txtTRNo As TextBox
    Friend WithEvents txtStatus As TextBox
    Friend WithEvents txtDivisi As TextBox
    Friend WithEvents txtCustomer As TextBox
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Customer As DataGridViewTextBoxColumn
    Friend WithEvents Divisi As DataGridViewTextBoxColumn
    Friend WithEvents Month As DataGridViewTextBoxColumn
    Friend WithEvents AWB As DataGridViewTextBoxColumn
    Friend WithEvents Status As DataGridViewTextBoxColumn
    Friend WithEvents Penerima As DataGridViewTextBoxColumn
    Friend WithEvents TglPenerima As DataGridViewTextBoxColumn
End Class
