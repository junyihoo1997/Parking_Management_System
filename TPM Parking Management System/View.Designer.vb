<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class View
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(View))
        Me.btnPayment = New System.Windows.Forms.Button()
        Me.btnParkingBay = New System.Windows.Forms.Button()
        Me.btnOwner = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnPayment
        '
        Me.btnPayment.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnPayment.BackgroundImage = CType(resources.GetObject("btnPayment.BackgroundImage"), System.Drawing.Image)
        Me.btnPayment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPayment.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnPayment.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPayment.Location = New System.Drawing.Point(572, 129)
        Me.btnPayment.Name = "btnPayment"
        Me.btnPayment.Size = New System.Drawing.Size(200, 114)
        Me.btnPayment.TabIndex = 39
        Me.btnPayment.UseVisualStyleBackColor = False
        '
        'btnParkingBay
        '
        Me.btnParkingBay.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnParkingBay.BackgroundImage = CType(resources.GetObject("btnParkingBay.BackgroundImage"), System.Drawing.Image)
        Me.btnParkingBay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnParkingBay.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnParkingBay.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnParkingBay.Location = New System.Drawing.Point(329, 129)
        Me.btnParkingBay.Name = "btnParkingBay"
        Me.btnParkingBay.Size = New System.Drawing.Size(200, 114)
        Me.btnParkingBay.TabIndex = 38
        Me.btnParkingBay.UseVisualStyleBackColor = False
        '
        'btnOwner
        '
        Me.btnOwner.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnOwner.BackgroundImage = CType(resources.GetObject("btnOwner.BackgroundImage"), System.Drawing.Image)
        Me.btnOwner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnOwner.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnOwner.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOwner.Location = New System.Drawing.Point(82, 129)
        Me.btnOwner.Name = "btnOwner"
        Me.btnOwner.Size = New System.Drawing.Size(200, 114)
        Me.btnOwner.TabIndex = 37
        Me.btnOwner.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnBack.BackgroundImage = CType(resources.GetObject("btnBack.BackgroundImage"), System.Drawing.Image)
        Me.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnBack.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(629, 285)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(143, 49)
        Me.btnBack.TabIndex = 289
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 36.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(374, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(113, 57)
        Me.Label6.TabIndex = 290
        Me.Label6.Text = "View"
        '
        'View
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(920, 435)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnPayment)
        Me.Controls.Add(Me.btnParkingBay)
        Me.Controls.Add(Me.btnOwner)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "View"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "View"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents btnPayment As Button
    Private WithEvents btnParkingBay As Button
    Friend WithEvents btnOwner As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents Label6 As Label
End Class
