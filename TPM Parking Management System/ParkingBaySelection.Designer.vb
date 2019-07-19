<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ParkingBaySelection
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ParkingBaySelection))
        Me.DirectoryEntry1 = New System.DirectoryServices.DirectoryEntry()
        Me.btnLevel1 = New System.Windows.Forms.Button()
        Me.btnLevel2 = New System.Windows.Forms.Button()
        Me.btnLevel3 = New System.Windows.Forms.Button()
        Me.btnLevel4 = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnLevel1
        '
        Me.btnLevel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnLevel1.BackgroundImage = CType(resources.GetObject("btnLevel1.BackgroundImage"), System.Drawing.Image)
        Me.btnLevel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLevel1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnLevel1.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLevel1.Location = New System.Drawing.Point(52, 112)
        Me.btnLevel1.Name = "btnLevel1"
        Me.btnLevel1.Size = New System.Drawing.Size(200, 114)
        Me.btnLevel1.TabIndex = 34
        Me.btnLevel1.UseVisualStyleBackColor = False
        '
        'btnLevel2
        '
        Me.btnLevel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnLevel2.BackgroundImage = CType(resources.GetObject("btnLevel2.BackgroundImage"), System.Drawing.Image)
        Me.btnLevel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLevel2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnLevel2.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLevel2.Location = New System.Drawing.Point(299, 112)
        Me.btnLevel2.Name = "btnLevel2"
        Me.btnLevel2.Size = New System.Drawing.Size(200, 114)
        Me.btnLevel2.TabIndex = 35
        Me.btnLevel2.UseVisualStyleBackColor = False
        '
        'btnLevel3
        '
        Me.btnLevel3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnLevel3.BackgroundImage = CType(resources.GetObject("btnLevel3.BackgroundImage"), System.Drawing.Image)
        Me.btnLevel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLevel3.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnLevel3.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLevel3.Location = New System.Drawing.Point(542, 112)
        Me.btnLevel3.Name = "btnLevel3"
        Me.btnLevel3.Size = New System.Drawing.Size(200, 114)
        Me.btnLevel3.TabIndex = 36
        Me.btnLevel3.UseVisualStyleBackColor = False
        '
        'btnLevel4
        '
        Me.btnLevel4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnLevel4.BackgroundImage = CType(resources.GetObject("btnLevel4.BackgroundImage"), System.Drawing.Image)
        Me.btnLevel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLevel4.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnLevel4.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLevel4.Location = New System.Drawing.Point(784, 112)
        Me.btnLevel4.Name = "btnLevel4"
        Me.btnLevel4.Size = New System.Drawing.Size(200, 114)
        Me.btnLevel4.TabIndex = 37
        Me.btnLevel4.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnBack.BackgroundImage = CType(resources.GetObject("btnBack.BackgroundImage"), System.Drawing.Image)
        Me.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnBack.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(861, 411)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(170, 55)
        Me.btnBack.TabIndex = 261
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 30.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(433, 38)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(206, 48)
        Me.Label6.TabIndex = 262
        Me.Label6.Text = "Parking Bay"
        '
        'ParkingBaySelection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1123, 576)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnLevel4)
        Me.Controls.Add(Me.btnLevel3)
        Me.Controls.Add(Me.btnLevel2)
        Me.Controls.Add(Me.btnLevel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ParkingBaySelection"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ParkingBaySelection"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DirectoryEntry1 As DirectoryServices.DirectoryEntry
    Friend WithEvents btnLevel1 As Button
    Private WithEvents btnLevel2 As Button
    Private WithEvents btnLevel3 As Button
    Private WithEvents btnLevel4 As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents Label6 As Label
End Class
