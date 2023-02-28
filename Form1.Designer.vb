<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Lblheading = New System.Windows.Forms.Label()
        Me.LblCalculation = New System.Windows.Forms.Label()
        Me.LblGrosspay = New System.Windows.Forms.Label()
        Me.TxtGrosspay = New System.Windows.Forms.TextBox()
        Me.BtnCompute = New System.Windows.Forms.Button()
        Me.Btnclear = New System.Windows.Forms.Button()
        Me.Btnexit = New System.Windows.Forms.Button()
        Me.Lblfica = New System.Windows.Forms.Label()
        Me.Lblfedtax = New System.Windows.Forms.Label()
        Me.LblStatetax = New System.Windows.Forms.Label()
        Me.Lblficatotal = New System.Windows.Forms.Label()
        Me.Lblfedtaxtot = New System.Windows.Forms.Label()
        Me.Lblstatetaxtot = New System.Windows.Forms.Label()
        Me.Lblnetincome = New System.Windows.Forms.Label()
        Me.Lblnettotal = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Hw2.My.Resources.Resources.payroll
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(343, 225)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Lblheading
        '
        Me.Lblheading.AutoSize = True
        Me.Lblheading.Font = New System.Drawing.Font("Elephant", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblheading.Location = New System.Drawing.Point(386, 20)
        Me.Lblheading.Name = "Lblheading"
        Me.Lblheading.Size = New System.Drawing.Size(361, 45)
        Me.Lblheading.TabIndex = 1
        Me.Lblheading.Text = "Payroll Calculator"
        '
        'LblCalculation
        '
        Me.LblCalculation.Font = New System.Drawing.Font("Elephant", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCalculation.Location = New System.Drawing.Point(479, 85)
        Me.LblCalculation.Name = "LblCalculation"
        Me.LblCalculation.Size = New System.Drawing.Size(169, 70)
        Me.LblCalculation.TabIndex = 2
        Me.LblCalculation.Text = "Paycheck Calculation"
        '
        'LblGrosspay
        '
        Me.LblGrosspay.AutoSize = True
        Me.LblGrosspay.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblGrosspay.Location = New System.Drawing.Point(221, 246)
        Me.LblGrosspay.Name = "LblGrosspay"
        Me.LblGrosspay.Size = New System.Drawing.Size(166, 24)
        Me.LblGrosspay.TabIndex = 3
        Me.LblGrosspay.Text = "Enter Gross Pay:"
        '
        'TxtGrosspay
        '
        Me.TxtGrosspay.Location = New System.Drawing.Point(432, 250)
        Me.TxtGrosspay.Name = "TxtGrosspay"
        Me.TxtGrosspay.Size = New System.Drawing.Size(100, 20)
        Me.TxtGrosspay.TabIndex = 4
        '
        'BtnCompute
        '
        Me.BtnCompute.BackColor = System.Drawing.Color.SkyBlue
        Me.BtnCompute.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCompute.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnCompute.Location = New System.Drawing.Point(127, 307)
        Me.BtnCompute.Name = "BtnCompute"
        Me.BtnCompute.Size = New System.Drawing.Size(98, 44)
        Me.BtnCompute.TabIndex = 5
        Me.BtnCompute.Text = "Compute taxes"
        Me.BtnCompute.UseVisualStyleBackColor = False
        '
        'Btnclear
        '
        Me.Btnclear.BackColor = System.Drawing.Color.SkyBlue
        Me.Btnclear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnclear.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btnclear.Location = New System.Drawing.Point(350, 307)
        Me.Btnclear.Name = "Btnclear"
        Me.Btnclear.Size = New System.Drawing.Size(98, 44)
        Me.Btnclear.TabIndex = 6
        Me.Btnclear.Text = "Clear"
        Me.Btnclear.UseVisualStyleBackColor = False
        '
        'Btnexit
        '
        Me.Btnexit.BackColor = System.Drawing.Color.SkyBlue
        Me.Btnexit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnexit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btnexit.Location = New System.Drawing.Point(572, 307)
        Me.Btnexit.Name = "Btnexit"
        Me.Btnexit.Size = New System.Drawing.Size(98, 44)
        Me.Btnexit.TabIndex = 7
        Me.Btnexit.Text = "Exit"
        Me.Btnexit.UseVisualStyleBackColor = False
        '
        'Lblfica
        '
        Me.Lblfica.AutoSize = True
        Me.Lblfica.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblfica.Location = New System.Drawing.Point(132, 370)
        Me.Lblfica.Name = "Lblfica"
        Me.Lblfica.Size = New System.Drawing.Size(40, 15)
        Me.Lblfica.TabIndex = 8
        Me.Lblfica.Text = "FICA:"
        '
        'Lblfedtax
        '
        Me.Lblfedtax.AutoSize = True
        Me.Lblfedtax.BackColor = System.Drawing.SystemColors.Control
        Me.Lblfedtax.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblfedtax.Location = New System.Drawing.Point(336, 370)
        Me.Lblfedtax.Name = "Lblfedtax"
        Me.Lblfedtax.Size = New System.Drawing.Size(87, 15)
        Me.Lblfedtax.TabIndex = 9
        Me.Lblfedtax.Text = "Federal Tax:"
        '
        'LblStatetax
        '
        Me.LblStatetax.AutoSize = True
        Me.LblStatetax.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStatetax.Location = New System.Drawing.Point(540, 370)
        Me.LblStatetax.Name = "LblStatetax"
        Me.LblStatetax.Size = New System.Drawing.Size(71, 15)
        Me.LblStatetax.TabIndex = 10
        Me.LblStatetax.Text = "State Tax:"
        '
        'Lblficatotal
        '
        Me.Lblficatotal.AutoSize = True
        Me.Lblficatotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblficatotal.Location = New System.Drawing.Point(178, 372)
        Me.Lblficatotal.Name = "Lblficatotal"
        Me.Lblficatotal.Size = New System.Drawing.Size(31, 15)
        Me.Lblficatotal.TabIndex = 11
        Me.Lblficatotal.Text = "123"
        '
        'Lblfedtaxtot
        '
        Me.Lblfedtaxtot.AutoSize = True
        Me.Lblfedtaxtot.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblfedtaxtot.Location = New System.Drawing.Point(429, 372)
        Me.Lblfedtaxtot.Name = "Lblfedtaxtot"
        Me.Lblfedtaxtot.Size = New System.Drawing.Size(31, 15)
        Me.Lblfedtaxtot.TabIndex = 12
        Me.Lblfedtaxtot.Text = "456"
        '
        'Lblstatetaxtot
        '
        Me.Lblstatetaxtot.AutoSize = True
        Me.Lblstatetaxtot.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblstatetaxtot.Location = New System.Drawing.Point(631, 372)
        Me.Lblstatetaxtot.Name = "Lblstatetaxtot"
        Me.Lblstatetaxtot.Size = New System.Drawing.Size(31, 15)
        Me.Lblstatetaxtot.TabIndex = 13
        Me.Lblstatetaxtot.Text = "789"
        '
        'Lblnetincome
        '
        Me.Lblnetincome.AutoSize = True
        Me.Lblnetincome.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblnetincome.Location = New System.Drawing.Point(191, 425)
        Me.Lblnetincome.Name = "Lblnetincome"
        Me.Lblnetincome.Size = New System.Drawing.Size(162, 16)
        Me.Lblnetincome.TabIndex = 14
        Me.Lblnetincome.Text = "Net Paycheck Income:"
        '
        'Lblnettotal
        '
        Me.Lblnettotal.AutoSize = True
        Me.Lblnettotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblnettotal.Location = New System.Drawing.Point(445, 428)
        Me.Lblnettotal.Name = "Lblnettotal"
        Me.Lblnettotal.Size = New System.Drawing.Size(76, 16)
        Me.Lblnettotal.TabIndex = 15
        Me.Lblnettotal.Text = "$12345.67"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Lblnettotal)
        Me.Controls.Add(Me.Lblnetincome)
        Me.Controls.Add(Me.Lblstatetaxtot)
        Me.Controls.Add(Me.Lblfedtaxtot)
        Me.Controls.Add(Me.Lblficatotal)
        Me.Controls.Add(Me.LblStatetax)
        Me.Controls.Add(Me.Lblfedtax)
        Me.Controls.Add(Me.Lblfica)
        Me.Controls.Add(Me.Btnexit)
        Me.Controls.Add(Me.Btnclear)
        Me.Controls.Add(Me.BtnCompute)
        Me.Controls.Add(Me.TxtGrosspay)
        Me.Controls.Add(Me.LblGrosspay)
        Me.Controls.Add(Me.LblCalculation)
        Me.Controls.Add(Me.Lblheading)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Lblheading As Label
    Friend WithEvents LblCalculation As Label
    Friend WithEvents LblGrosspay As Label
    Friend WithEvents TxtGrosspay As TextBox
    Friend WithEvents BtnCompute As Button
    Friend WithEvents Btnclear As Button
    Friend WithEvents Btnexit As Button
    Friend WithEvents Lblfica As Label
    Friend WithEvents Lblfedtax As Label
    Friend WithEvents LblStatetax As Label
    Friend WithEvents Lblficatotal As Label
    Friend WithEvents Lblfedtaxtot As Label
    Friend WithEvents Lblstatetaxtot As Label
    Friend WithEvents Lblnetincome As Label
    Friend WithEvents Lblnettotal As Label
End Class
