<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main_Menu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main_Menu))
        Me.AddMember = New System.Windows.Forms.Button()
        Me.EditMemberDetails = New System.Windows.Forms.Button()
        Me.MembStats = New System.Windows.Forms.Button()
        Me.SeeAllMembs = New System.Windows.Forms.Button()
        Me.ExitBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'AddMember
        '
        Me.AddMember.BackColor = System.Drawing.Color.Transparent
        Me.AddMember.Font = New System.Drawing.Font("Lucida Handwriting", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddMember.Location = New System.Drawing.Point(6, 59)
        Me.AddMember.Name = "AddMember"
        Me.AddMember.Size = New System.Drawing.Size(285, 31)
        Me.AddMember.TabIndex = 0
        Me.AddMember.Text = "Add New Member"
        Me.AddMember.UseVisualStyleBackColor = False
        '
        'EditMemberDetails
        '
        Me.EditMemberDetails.Font = New System.Drawing.Font("Lucida Handwriting", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditMemberDetails.Location = New System.Drawing.Point(309, 59)
        Me.EditMemberDetails.Name = "EditMemberDetails"
        Me.EditMemberDetails.Size = New System.Drawing.Size(285, 31)
        Me.EditMemberDetails.TabIndex = 1
        Me.EditMemberDetails.Text = "Change Member Details"
        Me.EditMemberDetails.UseVisualStyleBackColor = True
        '
        'MembStats
        '
        Me.MembStats.Enabled = False
        Me.MembStats.Font = New System.Drawing.Font("Lucida Handwriting", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MembStats.Location = New System.Drawing.Point(12, 122)
        Me.MembStats.Name = "MembStats"
        Me.MembStats.Size = New System.Drawing.Size(285, 31)
        Me.MembStats.TabIndex = 3
        Me.MembStats.Text = "Member Statistics"
        Me.MembStats.UseVisualStyleBackColor = True
        '
        'SeeAllMembs
        '
        Me.SeeAllMembs.Font = New System.Drawing.Font("Lucida Handwriting", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SeeAllMembs.Location = New System.Drawing.Point(309, 122)
        Me.SeeAllMembs.Name = "SeeAllMembs"
        Me.SeeAllMembs.Size = New System.Drawing.Size(285, 31)
        Me.SeeAllMembs.TabIndex = 2
        Me.SeeAllMembs.Text = "View All Members"
        Me.SeeAllMembs.UseVisualStyleBackColor = True
        '
        'ExitBtn
        '
        Me.ExitBtn.Font = New System.Drawing.Font("Lucida Handwriting", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitBtn.Location = New System.Drawing.Point(160, 178)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.Size = New System.Drawing.Size(285, 31)
        Me.ExitBtn.TabIndex = 5
        Me.ExitBtn.Text = "Exit"
        Me.ExitBtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 21.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(194, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(212, 42)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Main Menu"
        '
        'Main_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(606, 261)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ExitBtn)
        Me.Controls.Add(Me.MembStats)
        Me.Controls.Add(Me.SeeAllMembs)
        Me.Controls.Add(Me.EditMemberDetails)
        Me.Controls.Add(Me.AddMember)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Main_Menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ACK ST. PAULS MUKUYU-INI MAIN MENU"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AddMember As System.Windows.Forms.Button
    Friend WithEvents EditMemberDetails As System.Windows.Forms.Button
    Friend WithEvents MembStats As System.Windows.Forms.Button
    Friend WithEvents SeeAllMembs As System.Windows.Forms.Button
    Friend WithEvents ExitBtn As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
