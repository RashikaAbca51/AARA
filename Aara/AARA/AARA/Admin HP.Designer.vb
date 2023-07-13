<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin_HP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Admin_HP))
        Me.ButtonBack = New System.Windows.Forms.Button()
        Me.mode = New System.Windows.Forms.Button()
        Me.pd = New System.Windows.Forms.Button()
        Me.cd = New System.Windows.Forms.Button()
        Me.prView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrlistBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AARADataSet1 = New AARA.AARADataSet1()
        Me.clView2 = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdmindetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AARADataSet = New AARA.AARADataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.price = New System.Windows.Forms.TextBox()
        Me.pid = New System.Windows.Forms.TextBox()
        Me.detail = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBoxCName = New System.Windows.Forms.TextBox()
        Me.TextBoxCid = New System.Windows.Forms.TextBox()
        Me.TextBoxCPhone = New System.Windows.Forms.TextBox()
        Me.pinsert = New System.Windows.Forms.Button()
        Me.pdetail = New System.Windows.Forms.Button()
        Me.psearch = New System.Windows.Forms.Button()
        Me.pupdate = New System.Windows.Forms.Button()
        Me.cinsert = New System.Windows.Forms.Button()
        Me.cdelet = New System.Windows.Forms.Button()
        Me.csearch = New System.Windows.Forms.Button()
        Me.cupdate = New System.Windows.Forms.Button()
        Me.AdmindetailsTableAdapter = New AARA.AARADataSetTableAdapters.AdmindetailsTableAdapter()
        Me.PrlistTableAdapter = New AARA.AARADataSet1TableAdapters.prlistTableAdapter()
        CType(Me.prView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrlistBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AARADataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.clView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdmindetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AARADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonBack
        '
        Me.ButtonBack.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonBack.Location = New System.Drawing.Point(3, 903)
        Me.ButtonBack.Name = "ButtonBack"
        Me.ButtonBack.Size = New System.Drawing.Size(116, 43)
        Me.ButtonBack.TabIndex = 8
        Me.ButtonBack.Text = "Back"
        Me.ButtonBack.UseVisualStyleBackColor = False
        '
        'mode
        '
        Me.mode.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.mode.Font = New System.Drawing.Font("MV Boli", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mode.Location = New System.Drawing.Point(1243, 874)
        Me.mode.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.mode.Name = "mode"
        Me.mode.Size = New System.Drawing.Size(188, 51)
        Me.mode.TabIndex = 13
        Me.mode.Text = "Customer Mode"
        Me.mode.UseVisualStyleBackColor = False
        '
        'pd
        '
        Me.pd.BackColor = System.Drawing.Color.Black
        Me.pd.Font = New System.Drawing.Font("Myanmar Text", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.pd.Location = New System.Drawing.Point(12, 12)
        Me.pd.Name = "pd"
        Me.pd.Size = New System.Drawing.Size(202, 55)
        Me.pd.TabIndex = 25
        Me.pd.Text = "Product Details"
        Me.pd.UseVisualStyleBackColor = False
        '
        'cd
        '
        Me.cd.BackColor = System.Drawing.Color.Black
        Me.cd.Font = New System.Drawing.Font("Myanmar Text", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cd.Location = New System.Drawing.Point(952, 12)
        Me.cd.Name = "cd"
        Me.cd.Size = New System.Drawing.Size(198, 55)
        Me.cd.TabIndex = 26
        Me.cd.Text = "Client Details"
        Me.cd.UseVisualStyleBackColor = False
        '
        'prView1
        '
        Me.prView1.AutoGenerateColumns = False
        Me.prView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.prView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.prView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.ProductId, Me.Description})
        Me.prView1.DataSource = Me.PrlistBindingSource
        Me.prView1.Location = New System.Drawing.Point(12, 319)
        Me.prView1.Name = "prView1"
        Me.prView1.RowTemplate.Height = 28
        Me.prView1.Size = New System.Drawing.Size(907, 527)
        Me.prView1.TabIndex = 27
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Price"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Price"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'ProductId
        '
        Me.ProductId.DataPropertyName = "ProductId"
        Me.ProductId.HeaderText = "Product Id"
        Me.ProductId.Name = "ProductId"
        '
        'Description
        '
        Me.Description.DataPropertyName = "Description"
        Me.Description.HeaderText = "Product Details"
        Me.Description.Name = "Description"
        '
        'PrlistBindingSource
        '
        Me.PrlistBindingSource.DataMember = "prlist"
        Me.PrlistBindingSource.DataSource = Me.AARADataSet1
        '
        'AARADataSet1
        '
        Me.AARADataSet1.DataSetName = "AARADataSet1"
        Me.AARADataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'clView2
        '
        Me.clView2.AutoGenerateColumns = False
        Me.clView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.clView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.PhoneDataGridViewTextBoxColumn})
        Me.clView2.DataSource = Me.AdmindetailsBindingSource
        Me.clView2.Location = New System.Drawing.Point(952, 319)
        Me.clView2.Name = "clView2"
        Me.clView2.RowTemplate.Height = 28
        Me.clView2.Size = New System.Drawing.Size(780, 527)
        Me.clView2.TabIndex = 28
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        '
        'PhoneDataGridViewTextBoxColumn
        '
        Me.PhoneDataGridViewTextBoxColumn.DataPropertyName = "Phone"
        Me.PhoneDataGridViewTextBoxColumn.HeaderText = "Phone"
        Me.PhoneDataGridViewTextBoxColumn.Name = "PhoneDataGridViewTextBoxColumn"
        '
        'AdmindetailsBindingSource
        '
        Me.AdmindetailsBindingSource.DataMember = "Admindetails"
        Me.AdmindetailsBindingSource.DataSource = Me.AARADataSet
        '
        'AARADataSet
        '
        Me.AARADataSet.DataSetName = "AARADataSet"
        Me.AARADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 11.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 26)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Product Name"
        '
        'pname
        '
        Me.pname.BackColor = System.Drawing.SystemColors.HighlightText
        Me.pname.Font = New System.Drawing.Font("Mongolian Baiti", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pname.ForeColor = System.Drawing.Color.Black
        Me.pname.Location = New System.Drawing.Point(12, 140)
        Me.pname.Name = "pname"
        Me.pname.Size = New System.Drawing.Size(180, 31)
        Me.pname.TabIndex = 47
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 11.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(423, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 26)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Product ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Monotype Corsiva", 11.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(234, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 26)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Price"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Monotype Corsiva", 11.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(589, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 26)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "Description"
        '
        'price
        '
        Me.price.BackColor = System.Drawing.SystemColors.HighlightText
        Me.price.Font = New System.Drawing.Font("Mongolian Baiti", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.price.ForeColor = System.Drawing.Color.Black
        Me.price.Location = New System.Drawing.Point(202, 140)
        Me.price.Name = "price"
        Me.price.Size = New System.Drawing.Size(208, 31)
        Me.price.TabIndex = 51
        '
        'pid
        '
        Me.pid.BackColor = System.Drawing.SystemColors.HighlightText
        Me.pid.Font = New System.Drawing.Font("Mongolian Baiti", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pid.ForeColor = System.Drawing.Color.Black
        Me.pid.Location = New System.Drawing.Point(428, 140)
        Me.pid.Name = "pid"
        Me.pid.Size = New System.Drawing.Size(120, 31)
        Me.pid.TabIndex = 52
        '
        'detail
        '
        Me.detail.BackColor = System.Drawing.SystemColors.HighlightText
        Me.detail.Font = New System.Drawing.Font("Mongolian Baiti", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.detail.ForeColor = System.Drawing.Color.Black
        Me.detail.Location = New System.Drawing.Point(594, 140)
        Me.detail.Name = "detail"
        Me.detail.Size = New System.Drawing.Size(272, 31)
        Me.detail.TabIndex = 53
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Monotype Corsiva", 11.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(1213, 97)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 26)
        Me.Label5.TabIndex = 54
        Me.Label5.Text = "Client Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Monotype Corsiva", 11.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(947, 97)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 26)
        Me.Label6.TabIndex = 55
        Me.Label6.Text = "Client ID"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Monotype Corsiva", 11.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(1386, 97)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 26)
        Me.Label7.TabIndex = 56
        Me.Label7.Text = "PH. No."
        '
        'TextBoxCName
        '
        Me.TextBoxCName.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TextBoxCName.Font = New System.Drawing.Font("Mongolian Baiti", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCName.ForeColor = System.Drawing.Color.Black
        Me.TextBoxCName.Location = New System.Drawing.Point(1218, 140)
        Me.TextBoxCName.Name = "TextBoxCName"
        Me.TextBoxCName.Size = New System.Drawing.Size(161, 31)
        Me.TextBoxCName.TabIndex = 57
        '
        'TextBoxCid
        '
        Me.TextBoxCid.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TextBoxCid.Font = New System.Drawing.Font("Mongolian Baiti", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCid.ForeColor = System.Drawing.Color.Black
        Me.TextBoxCid.Location = New System.Drawing.Point(952, 140)
        Me.TextBoxCid.Name = "TextBoxCid"
        Me.TextBoxCid.Size = New System.Drawing.Size(230, 31)
        Me.TextBoxCid.TabIndex = 58
        '
        'TextBoxCPhone
        '
        Me.TextBoxCPhone.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TextBoxCPhone.Font = New System.Drawing.Font("Mongolian Baiti", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCPhone.ForeColor = System.Drawing.Color.Black
        Me.TextBoxCPhone.Location = New System.Drawing.Point(1391, 140)
        Me.TextBoxCPhone.MaxLength = 10
        Me.TextBoxCPhone.Name = "TextBoxCPhone"
        Me.TextBoxCPhone.Size = New System.Drawing.Size(272, 31)
        Me.TextBoxCPhone.TabIndex = 59
        '
        'pinsert
        '
        Me.pinsert.BackColor = System.Drawing.Color.White
        Me.pinsert.Font = New System.Drawing.Font("MV Boli", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pinsert.Location = New System.Drawing.Point(12, 191)
        Me.pinsert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pinsert.Name = "pinsert"
        Me.pinsert.Size = New System.Drawing.Size(149, 40)
        Me.pinsert.TabIndex = 60
        Me.pinsert.Text = "Insert"
        Me.pinsert.UseVisualStyleBackColor = False
        '
        'pdetail
        '
        Me.pdetail.BackColor = System.Drawing.Color.White
        Me.pdetail.Font = New System.Drawing.Font("MV Boli", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pdetail.Location = New System.Drawing.Point(215, 191)
        Me.pdetail.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pdetail.Name = "pdetail"
        Me.pdetail.Size = New System.Drawing.Size(149, 40)
        Me.pdetail.TabIndex = 61
        Me.pdetail.Text = "Delete"
        Me.pdetail.UseVisualStyleBackColor = False
        '
        'psearch
        '
        Me.psearch.BackColor = System.Drawing.Color.White
        Me.psearch.Font = New System.Drawing.Font("MV Boli", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.psearch.Location = New System.Drawing.Point(438, 191)
        Me.psearch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.psearch.Name = "psearch"
        Me.psearch.Size = New System.Drawing.Size(149, 40)
        Me.psearch.TabIndex = 62
        Me.psearch.Text = "Search"
        Me.psearch.UseVisualStyleBackColor = False
        '
        'pupdate
        '
        Me.pupdate.BackColor = System.Drawing.Color.White
        Me.pupdate.Font = New System.Drawing.Font("MV Boli", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pupdate.Location = New System.Drawing.Point(679, 191)
        Me.pupdate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pupdate.Name = "pupdate"
        Me.pupdate.Size = New System.Drawing.Size(149, 40)
        Me.pupdate.TabIndex = 63
        Me.pupdate.Text = "Update"
        Me.pupdate.UseVisualStyleBackColor = False
        '
        'cinsert
        '
        Me.cinsert.BackColor = System.Drawing.Color.White
        Me.cinsert.Font = New System.Drawing.Font("MV Boli", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cinsert.Location = New System.Drawing.Point(952, 191)
        Me.cinsert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cinsert.Name = "cinsert"
        Me.cinsert.Size = New System.Drawing.Size(149, 40)
        Me.cinsert.TabIndex = 64
        Me.cinsert.Text = "Insert"
        Me.cinsert.UseVisualStyleBackColor = False
        '
        'cdelet
        '
        Me.cdelet.BackColor = System.Drawing.Color.White
        Me.cdelet.Font = New System.Drawing.Font("MV Boli", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cdelet.Location = New System.Drawing.Point(1145, 191)
        Me.cdelet.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cdelet.Name = "cdelet"
        Me.cdelet.Size = New System.Drawing.Size(149, 40)
        Me.cdelet.TabIndex = 65
        Me.cdelet.Text = "Delete"
        Me.cdelet.UseVisualStyleBackColor = False
        '
        'csearch
        '
        Me.csearch.BackColor = System.Drawing.Color.White
        Me.csearch.Font = New System.Drawing.Font("MV Boli", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.csearch.Location = New System.Drawing.Point(1354, 191)
        Me.csearch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.csearch.Name = "csearch"
        Me.csearch.Size = New System.Drawing.Size(149, 40)
        Me.csearch.TabIndex = 66
        Me.csearch.Text = "Search"
        Me.csearch.UseVisualStyleBackColor = False
        '
        'cupdate
        '
        Me.cupdate.BackColor = System.Drawing.Color.White
        Me.cupdate.Font = New System.Drawing.Font("MV Boli", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cupdate.Location = New System.Drawing.Point(1552, 191)
        Me.cupdate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cupdate.Name = "cupdate"
        Me.cupdate.Size = New System.Drawing.Size(149, 40)
        Me.cupdate.TabIndex = 67
        Me.cupdate.Text = "Update"
        Me.cupdate.UseVisualStyleBackColor = False
        '
        'AdmindetailsTableAdapter
        '
        Me.AdmindetailsTableAdapter.ClearBeforeFill = True
        '
        'PrlistTableAdapter
        '
        Me.PrlistTableAdapter.ClearBeforeFill = True
        '
        'Admin_HP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1772, 974)
        Me.Controls.Add(Me.cupdate)
        Me.Controls.Add(Me.csearch)
        Me.Controls.Add(Me.cdelet)
        Me.Controls.Add(Me.cinsert)
        Me.Controls.Add(Me.pupdate)
        Me.Controls.Add(Me.psearch)
        Me.Controls.Add(Me.pdetail)
        Me.Controls.Add(Me.pinsert)
        Me.Controls.Add(Me.TextBoxCPhone)
        Me.Controls.Add(Me.TextBoxCid)
        Me.Controls.Add(Me.TextBoxCName)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.detail)
        Me.Controls.Add(Me.pid)
        Me.Controls.Add(Me.price)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.pname)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.clView2)
        Me.Controls.Add(Me.prView1)
        Me.Controls.Add(Me.cd)
        Me.Controls.Add(Me.pd)
        Me.Controls.Add(Me.mode)
        Me.Controls.Add(Me.ButtonBack)
        Me.DoubleBuffered = True
        Me.Name = "Admin_HP"
        Me.Text = "Admin_HP"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.prView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrlistBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AARADataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.clView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdmindetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AARADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonBack As System.Windows.Forms.Button
    Friend WithEvents mode As System.Windows.Forms.Button
    Friend WithEvents pd As System.Windows.Forms.Button
    Friend WithEvents cd As System.Windows.Forms.Button
    Friend WithEvents prView1 As System.Windows.Forms.DataGridView
    Friend WithEvents clView2 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pname As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents price As System.Windows.Forms.TextBox
    Friend WithEvents pid As System.Windows.Forms.TextBox
    Friend WithEvents detail As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBoxCName As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxCid As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxCPhone As System.Windows.Forms.TextBox
    Friend WithEvents pinsert As System.Windows.Forms.Button
    Friend WithEvents pdetail As System.Windows.Forms.Button
    Friend WithEvents psearch As System.Windows.Forms.Button
    Friend WithEvents pupdate As System.Windows.Forms.Button
    Friend WithEvents cinsert As System.Windows.Forms.Button
    Friend WithEvents cdelet As System.Windows.Forms.Button
    Friend WithEvents csearch As System.Windows.Forms.Button
    Friend WithEvents cupdate As System.Windows.Forms.Button
    Friend WithEvents AARADataSet As AARA.AARADataSet
    Friend WithEvents AdmindetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AdmindetailsTableAdapter As AARA.AARADataSetTableAdapters.AdmindetailsTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PhoneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AARADataSet1 As AARA.AARADataSet1
    Friend WithEvents PrlistBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PrlistTableAdapter As AARA.AARADataSet1TableAdapters.prlistTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProductId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Description As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
