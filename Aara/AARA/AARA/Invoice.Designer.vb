<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Invoice
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Invoice))
        Me.bill = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cname = New System.Windows.Forms.TextBox()
        Me.addr = New System.Windows.Forms.TextBox()
        Me.city = New System.Windows.Forms.TextBox()
        Me.phno = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'bill
        '
        Me.bill.Location = New System.Drawing.Point(889, 183)
        Me.bill.Multiline = True
        Me.bill.Name = "bill"
        Me.bill.Size = New System.Drawing.Size(741, 527)
        Me.bill.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Mongolian Baiti", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(78, 153)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Customer name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Mongolian Baiti", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(49, 249)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(168, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Delivery Address"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Mongolian Baiti", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(78, 420)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 21)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Phone number"
        '
        'cname
        '
        Me.cname.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.cname.Font = New System.Drawing.Font("Mongolian Baiti", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cname.Location = New System.Drawing.Point(482, 153)
        Me.cname.Name = "cname"
        Me.cname.Size = New System.Drawing.Size(242, 31)
        Me.cname.TabIndex = 4
        '
        'addr
        '
        Me.addr.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.addr.Font = New System.Drawing.Font("Mongolian Baiti", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addr.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.addr.Location = New System.Drawing.Point(482, 250)
        Me.addr.Name = "addr"
        Me.addr.Size = New System.Drawing.Size(242, 31)
        Me.addr.TabIndex = 5
        '
        'city
        '
        Me.city.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.city.Font = New System.Drawing.Font("Mongolian Baiti", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.city.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.city.Location = New System.Drawing.Point(482, 339)
        Me.city.MaxLength = 300
        Me.city.Name = "city"
        Me.city.Size = New System.Drawing.Size(242, 31)
        Me.city.TabIndex = 6
        '
        'phno
        '
        Me.phno.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.phno.Font = New System.Drawing.Font("Mongolian Baiti", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.phno.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.phno.Location = New System.Drawing.Point(482, 410)
        Me.phno.MaxLength = 10
        Me.phno.Name = "phno"
        Me.phno.Size = New System.Drawing.Size(242, 31)
        Me.phno.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Myanmar Text", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(283, 249)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 32)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Flat no, name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Myanmar Text", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(283, 338)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 32)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "City, Pin no"
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Black
        Me.Button3.Font = New System.Drawing.Font("Myanmar Text", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button3.Location = New System.Drawing.Point(194, 560)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(156, 39)
        Me.Button3.TabIndex = 24
        Me.Button3.Text = "Generate"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.Font = New System.Drawing.Font("Myanmar Text", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(597, 560)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(156, 39)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "Print"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Invoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1656, 828)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.phno)
        Me.Controls.Add(Me.city)
        Me.Controls.Add(Me.addr)
        Me.Controls.Add(Me.cname)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bill)
        Me.DoubleBuffered = True
        Me.Name = "Invoice"
        Me.Text = "Invoice"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bill As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cname As System.Windows.Forms.TextBox
    Friend WithEvents addr As System.Windows.Forms.TextBox
    Friend WithEvents city As System.Windows.Forms.TextBox
    Friend WithEvents phno As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
