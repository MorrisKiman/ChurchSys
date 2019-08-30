<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Statistics
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Statistics))
        Me.All = New System.Windows.Forms.Button()
        Me.Estates = New System.Windows.Forms.Button()
        Me.Children = New System.Windows.Forms.Button()
        Me.ChrGroups = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'All
        '
        Me.All.Font = New System.Drawing.Font("Swis721 Hv BT", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.All.Location = New System.Drawing.Point(104, 59)
        Me.All.Name = "All"
        Me.All.Size = New System.Drawing.Size(193, 33)
        Me.All.TabIndex = 0
        Me.All.Text = "All Members"
        Me.All.UseVisualStyleBackColor = True
        '
        'Estates
        '
        Me.Estates.Font = New System.Drawing.Font("Swis721 Hv BT", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Estates.Location = New System.Drawing.Point(303, 199)
        Me.Estates.Name = "Estates"
        Me.Estates.Size = New System.Drawing.Size(193, 33)
        Me.Estates.TabIndex = 1
        Me.Estates.Text = "Estates"
        Me.Estates.UseVisualStyleBackColor = True
        '
        'Children
        '
        Me.Children.Font = New System.Drawing.Font("Swis721 Hv BT", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Children.Location = New System.Drawing.Point(111, 151)
        Me.Children.Name = "Children"
        Me.Children.Size = New System.Drawing.Size(193, 33)
        Me.Children.TabIndex = 2
        Me.Children.Text = "Children"
        Me.Children.UseVisualStyleBackColor = True
        '
        'ChrGroups
        '
        Me.ChrGroups.Font = New System.Drawing.Font("Swis721 Hv BT", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChrGroups.Location = New System.Drawing.Point(297, 105)
        Me.ChrGroups.Name = "ChrGroups"
        Me.ChrGroups.Size = New System.Drawing.Size(193, 33)
        Me.ChrGroups.TabIndex = 3
        Me.ChrGroups.Text = "Church Groups"
        Me.ChrGroups.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Stencil", 15.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(182, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(215, 25)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Member Statistics"
        '
        'Statistics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(606, 261)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ChrGroups)
        Me.Controls.Add(Me.Children)
        Me.Controls.Add(Me.Estates)
        Me.Controls.Add(Me.All)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(622, 300)
        Me.MinimizeBox = False
        Me.Name = "Statistics"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ACK ST. PAULS MUKUYU-INI - Statistics"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents All As System.Windows.Forms.Button
    Friend WithEvents Estates As System.Windows.Forms.Button
    Friend WithEvents Children As System.Windows.Forms.Button
    Friend WithEvents ChrGroups As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
