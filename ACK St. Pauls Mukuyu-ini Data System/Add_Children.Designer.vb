<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_Children
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Add_Children))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Gender = New System.Windows.Forms.ComboBox()
        Me.dcnksn = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Child_Confirmed = New System.Windows.Forms.ComboBox()
        Me.Child_Baptized = New System.Windows.Forms.ComboBox()
        Me.Child_DOB = New System.Windows.Forms.MaskedTextBox()
        Me.ChildName = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Names = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ig = New System.Windows.Forms.TextBox()
        Me.Mother_Member_Number = New System.Windows.Forms.TextBox()
        Me.Contacts_of_Mother = New System.Windows.Forms.TextBox()
        Me.Names_of_Mother = New System.Windows.Forms.TextBox()
        Me.Father_Member_Number = New System.Windows.Forms.TextBox()
        Me.Contacts_of_Father = New System.Windows.Forms.TextBox()
        Me.Fathers_Names = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.ValidateRecords = New System.Windows.Forms.Button()
        Me.SaveRecords = New System.Windows.Forms.Button()
        Me.chfeed = New System.Windows.Forms.Label()
        Me.noChildren = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.hvtoi = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(145, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Member Number:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(422, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(143, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Mother's Names:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Gender)
        Me.GroupBox1.Controls.Add(Me.dcnksn)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Child_Confirmed)
        Me.GroupBox1.Controls.Add(Me.Child_Baptized)
        Me.GroupBox1.Controls.Add(Me.Child_DOB)
        Me.GroupBox1.Controls.Add(Me.ChildName)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.Names)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 179)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(611, 210)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Enter the Child's Details"
        '
        'Gender
        '
        Me.Gender.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gender.FormattingEnabled = True
        Me.Gender.Location = New System.Drawing.Point(149, 93)
        Me.Gender.Name = "Gender"
        Me.Gender.Size = New System.Drawing.Size(121, 32)
        Me.Gender.TabIndex = 16
        '
        'dcnksn
        '
        Me.dcnksn.AutoSize = True
        Me.dcnksn.Font = New System.Drawing.Font("News701 BT", 14.25!, System.Drawing.FontStyle.Bold)
        Me.dcnksn.Location = New System.Drawing.Point(57, 96)
        Me.dcnksn.Name = "dcnksn"
        Me.dcnksn.Size = New System.Drawing.Size(84, 23)
        Me.dcnksn.TabIndex = 19
        Me.dcnksn.Text = "Gender"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("News701 BT", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(275, 66)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(150, 23)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "DD/MM/YYYY"
        '
        'Child_Confirmed
        '
        Me.Child_Confirmed.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Child_Confirmed.FormattingEnabled = True
        Me.Child_Confirmed.Location = New System.Drawing.Point(148, 163)
        Me.Child_Confirmed.Name = "Child_Confirmed"
        Me.Child_Confirmed.Size = New System.Drawing.Size(121, 32)
        Me.Child_Confirmed.TabIndex = 18
        '
        'Child_Baptized
        '
        Me.Child_Baptized.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Child_Baptized.FormattingEnabled = True
        Me.Child_Baptized.Location = New System.Drawing.Point(148, 128)
        Me.Child_Baptized.Name = "Child_Baptized"
        Me.Child_Baptized.Size = New System.Drawing.Size(121, 32)
        Me.Child_Baptized.TabIndex = 17
        '
        'Child_DOB
        '
        Me.Child_DOB.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Child_DOB.Location = New System.Drawing.Point(148, 62)
        Me.Child_DOB.Mask = "00/00/0000"
        Me.Child_DOB.Name = "Child_DOB"
        Me.Child_DOB.Size = New System.Drawing.Size(121, 29)
        Me.Child_DOB.TabIndex = 15
        Me.Child_DOB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Child_DOB.ValidatingType = GetType(Date)
        '
        'ChildName
        '
        Me.ChildName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChildName.Location = New System.Drawing.Point(148, 30)
        Me.ChildName.Name = "ChildName"
        Me.ChildName.Size = New System.Drawing.Size(313, 29)
        Me.ChildName.TabIndex = 14
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("News701 BT", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label23.Location = New System.Drawing.Point(26, 166)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(115, 23)
        Me.Label23.TabIndex = 13
        Me.Label23.Text = "Confirmed"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("News701 BT", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label22.Location = New System.Drawing.Point(43, 131)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(98, 23)
        Me.Label22.TabIndex = 12
        Me.Label22.Text = "Baptized"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("News701 BT", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label20.Location = New System.Drawing.Point(4, 65)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(137, 23)
        Me.Label20.TabIndex = 10
        Me.Label20.Text = "Date of Birth"
        '
        'Names
        '
        Me.Names.AutoSize = True
        Me.Names.Font = New System.Drawing.Font("News701 BT", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Names.Location = New System.Drawing.Point(64, 33)
        Me.Names.Name = "Names"
        Me.Names.Size = New System.Drawing.Size(77, 23)
        Me.Names.TabIndex = 9
        Me.Names.Text = "Names"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(18, 26)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(140, 20)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Father's Names:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(6, 55)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(157, 20)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "Father's Contacts:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(407, 56)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(160, 20)
        Me.Label18.TabIndex = 5
        Me.Label18.Text = "Mother's Contacts:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ig)
        Me.GroupBox2.Controls.Add(Me.Mother_Member_Number)
        Me.GroupBox2.Controls.Add(Me.Contacts_of_Mother)
        Me.GroupBox2.Controls.Add(Me.Names_of_Mother)
        Me.GroupBox2.Controls.Add(Me.Father_Member_Number)
        Me.GroupBox2.Controls.Add(Me.Contacts_of_Father)
        Me.GroupBox2.Controls.Add(Me.Fathers_Names)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(834, 122)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Parent(s) Details"
        '
        'ig
        '
        Me.ig.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ig.Location = New System.Drawing.Point(275, 85)
        Me.ig.Multiline = True
        Me.ig.Name = "ig"
        Me.ig.ReadOnly = True
        Me.ig.Size = New System.Drawing.Size(19, 20)
        Me.ig.TabIndex = 0
        Me.ig.Visible = False
        '
        'Mother_Member_Number
        '
        Me.Mother_Member_Number.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Mother_Member_Number.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mother_Member_Number.Location = New System.Drawing.Point(573, 81)
        Me.Mother_Member_Number.Name = "Mother_Member_Number"
        Me.Mother_Member_Number.ReadOnly = True
        Me.Mother_Member_Number.Size = New System.Drawing.Size(105, 26)
        Me.Mother_Member_Number.TabIndex = 19
        Me.Mother_Member_Number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Contacts_of_Mother
        '
        Me.Contacts_of_Mother.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Contacts_of_Mother.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Contacts_of_Mother.Location = New System.Drawing.Point(573, 53)
        Me.Contacts_of_Mother.Name = "Contacts_of_Mother"
        Me.Contacts_of_Mother.ReadOnly = True
        Me.Contacts_of_Mother.Size = New System.Drawing.Size(193, 26)
        Me.Contacts_of_Mother.TabIndex = 18
        Me.Contacts_of_Mother.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Names_of_Mother
        '
        Me.Names_of_Mother.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Names_of_Mother.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Names_of_Mother.Location = New System.Drawing.Point(573, 22)
        Me.Names_of_Mother.Name = "Names_of_Mother"
        Me.Names_of_Mother.ReadOnly = True
        Me.Names_of_Mother.Size = New System.Drawing.Size(252, 26)
        Me.Names_of_Mother.TabIndex = 17
        Me.Names_of_Mother.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Father_Member_Number
        '
        Me.Father_Member_Number.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Father_Member_Number.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Father_Member_Number.Location = New System.Drawing.Point(164, 82)
        Me.Father_Member_Number.Name = "Father_Member_Number"
        Me.Father_Member_Number.ReadOnly = True
        Me.Father_Member_Number.Size = New System.Drawing.Size(105, 26)
        Me.Father_Member_Number.TabIndex = 16
        Me.Father_Member_Number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Contacts_of_Father
        '
        Me.Contacts_of_Father.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Contacts_of_Father.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Contacts_of_Father.Location = New System.Drawing.Point(164, 53)
        Me.Contacts_of_Father.Name = "Contacts_of_Father"
        Me.Contacts_of_Father.ReadOnly = True
        Me.Contacts_of_Father.Size = New System.Drawing.Size(193, 26)
        Me.Contacts_of_Father.TabIndex = 15
        Me.Contacts_of_Father.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Fathers_Names
        '
        Me.Fathers_Names.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Fathers_Names.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fathers_Names.Location = New System.Drawing.Point(164, 23)
        Me.Fathers_Names.Name = "Fathers_Names"
        Me.Fathers_Names.ReadOnly = True
        Me.Fathers_Names.Size = New System.Drawing.Size(252, 26)
        Me.Fathers_Names.TabIndex = 14
        Me.Fathers_Names.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(420, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 20)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Member Number:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(237, 9)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(0, 20)
        Me.Label21.TabIndex = 11
        '
        'ValidateRecords
        '
        Me.ValidateRecords.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ValidateRecords.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ValidateRecords.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ValidateRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ValidateRecords.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ValidateRecords.Location = New System.Drawing.Point(653, 256)
        Me.ValidateRecords.Name = "ValidateRecords"
        Me.ValidateRecords.Size = New System.Drawing.Size(119, 32)
        Me.ValidateRecords.TabIndex = 2
        Me.ValidateRecords.Text = "Validate"
        Me.ValidateRecords.UseVisualStyleBackColor = False
        '
        'SaveRecords
        '
        Me.SaveRecords.BackColor = System.Drawing.SystemColors.ControlLight
        Me.SaveRecords.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SaveRecords.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.SaveRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveRecords.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveRecords.Location = New System.Drawing.Point(653, 294)
        Me.SaveRecords.Name = "SaveRecords"
        Me.SaveRecords.Size = New System.Drawing.Size(119, 32)
        Me.SaveRecords.TabIndex = 3
        Me.SaveRecords.Text = "Save"
        Me.SaveRecords.UseVisualStyleBackColor = False
        '
        'chfeed
        '
        Me.chfeed.AutoSize = True
        Me.chfeed.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.chfeed.Location = New System.Drawing.Point(424, 147)
        Me.chfeed.Name = "chfeed"
        Me.chfeed.Size = New System.Drawing.Size(149, 20)
        Me.chfeed.TabIndex = 22
        Me.chfeed.Text = " Children Entered"
        '
        'noChildren
        '
        Me.noChildren.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.noChildren.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.noChildren.Location = New System.Drawing.Point(299, 144)
        Me.noChildren.Name = "noChildren"
        Me.noChildren.ReadOnly = True
        Me.noChildren.Size = New System.Drawing.Size(56, 26)
        Me.noChildren.TabIndex = 21
        Me.noChildren.Text = "0"
        Me.noChildren.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(127, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(166, 20)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Number Of Children"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(397, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(19, 20)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "0"
        '
        'hvtoi
        '
        Me.hvtoi.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.hvtoi.Location = New System.Drawing.Point(372, 146)
        Me.hvtoi.Multiline = True
        Me.hvtoi.Name = "hvtoi"
        Me.hvtoi.ReadOnly = True
        Me.hvtoi.Size = New System.Drawing.Size(19, 20)
        Me.hvtoi.TabIndex = 23
        Me.hvtoi.Visible = False
        '
        'Add_Children
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClientSize = New System.Drawing.Size(858, 391)
        Me.Controls.Add(Me.hvtoi)
        Me.Controls.Add(Me.chfeed)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.SaveRecords)
        Me.Controls.Add(Me.noChildren)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ValidateRecords)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Add_Children"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ACK ST. PAULS MUKUYU-INI"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Names As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Child_Confirmed As System.Windows.Forms.ComboBox
    Friend WithEvents Child_Baptized As System.Windows.Forms.ComboBox
    Friend WithEvents Child_DOB As System.Windows.Forms.MaskedTextBox
    Friend WithEvents ChildName As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents SaveRecords As System.Windows.Forms.Button
    Friend WithEvents ValidateRecords As System.Windows.Forms.Button
    Friend WithEvents Mother_Member_Number As System.Windows.Forms.TextBox
    Friend WithEvents Contacts_of_Mother As System.Windows.Forms.TextBox
    Friend WithEvents Names_of_Mother As System.Windows.Forms.TextBox
    Friend WithEvents Father_Member_Number As System.Windows.Forms.TextBox
    Friend WithEvents Contacts_of_Father As System.Windows.Forms.TextBox
    Friend WithEvents Fathers_Names As System.Windows.Forms.TextBox
    Friend WithEvents ig As System.Windows.Forms.TextBox
    Friend WithEvents Gender As System.Windows.Forms.ComboBox
    Friend WithEvents dcnksn As System.Windows.Forms.Label
    Friend WithEvents chfeed As System.Windows.Forms.Label
    Friend WithEvents noChildren As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents hvtoi As System.Windows.Forms.TextBox
End Class
