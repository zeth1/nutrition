<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentAdd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StudentAdd))
        Me.txtLRN = New System.Windows.Forms.TextBox()
        Me.txtLastname = New System.Windows.Forms.TextBox()
        Me.txtFirstname = New System.Windows.Forms.TextBox()
        Me.txtMiddlename = New System.Windows.Forms.TextBox()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtGrade = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Label()
        Me.btnEdit = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Label()
        Me.txtGuardian = New System.Windows.Forms.TextBox()
        Me.lvwStudent = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtMid = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtLRN
        '
        Me.txtLRN.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtLRN.Location = New System.Drawing.Point(96, 113)
        Me.txtLRN.Multiline = True
        Me.txtLRN.Name = "txtLRN"
        Me.txtLRN.Size = New System.Drawing.Size(191, 18)
        Me.txtLRN.TabIndex = 0
        '
        'txtLastname
        '
        Me.txtLastname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtLastname.Location = New System.Drawing.Point(97, 217)
        Me.txtLastname.Multiline = True
        Me.txtLastname.Name = "txtLastname"
        Me.txtLastname.Size = New System.Drawing.Size(191, 17)
        Me.txtLastname.TabIndex = 1
        '
        'txtFirstname
        '
        Me.txtFirstname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFirstname.Location = New System.Drawing.Point(96, 147)
        Me.txtFirstname.Multiline = True
        Me.txtFirstname.Name = "txtFirstname"
        Me.txtFirstname.Size = New System.Drawing.Size(191, 16)
        Me.txtFirstname.TabIndex = 2
        '
        'txtMiddlename
        '
        Me.txtMiddlename.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMiddlename.Location = New System.Drawing.Point(113, 253)
        Me.txtMiddlename.Name = "txtMiddlename"
        Me.txtMiddlename.Size = New System.Drawing.Size(150, 13)
        Me.txtMiddlename.TabIndex = 3
        '
        'txtAge
        '
        Me.txtAge.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAge.Location = New System.Drawing.Point(96, 253)
        Me.txtAge.Multiline = True
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(192, 13)
        Me.txtAge.TabIndex = 5
        '
        'txtAddress
        '
        Me.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAddress.Location = New System.Drawing.Point(97, 285)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(190, 16)
        Me.txtAddress.TabIndex = 6
        '
        'txtGrade
        '
        Me.txtGrade.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtGrade.Location = New System.Drawing.Point(96, 357)
        Me.txtGrade.Multiline = True
        Me.txtGrade.Name = "txtGrade"
        Me.txtGrade.Size = New System.Drawing.Size(191, 15)
        Me.txtGrade.TabIndex = 7
        '
        'btnCancel
        '
        Me.btnCancel.AutoSize = True
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.Font = New System.Drawing.Font("Airbnb Cereal App Black", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(205, 491)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(45, 14)
        Me.btnCancel.TabIndex = 10
        Me.btnCancel.Text = "Cancel"
        '
        'btnClear
        '
        Me.btnClear.AutoSize = True
        Me.btnClear.BackColor = System.Drawing.Color.Transparent
        Me.btnClear.Font = New System.Drawing.Font("Airbnb Cereal App Black", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(132, 492)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(36, 14)
        Me.btnClear.TabIndex = 11
        Me.btnClear.Text = "Clear"
        '
        'btnDelete
        '
        Me.btnDelete.AutoSize = True
        Me.btnDelete.BackColor = System.Drawing.Color.Transparent
        Me.btnDelete.Font = New System.Drawing.Font("Airbnb Cereal App Black", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(51, 493)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(45, 14)
        Me.btnDelete.TabIndex = 13
        Me.btnDelete.Text = "Delete"
        '
        'btnEdit
        '
        Me.btnEdit.AutoSize = True
        Me.btnEdit.BackColor = System.Drawing.Color.Transparent
        Me.btnEdit.Font = New System.Drawing.Font("Airbnb Cereal App Black", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Location = New System.Drawing.Point(212, 451)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(28, 14)
        Me.btnEdit.TabIndex = 14
        Me.btnEdit.Text = "Edit"
        '
        'btnSave
        '
        Me.btnSave.AutoSize = True
        Me.btnSave.BackColor = System.Drawing.Color.Transparent
        Me.btnSave.Font = New System.Drawing.Font("Airbnb Cereal App Black", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(132, 451)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(33, 14)
        Me.btnSave.TabIndex = 15
        Me.btnSave.Text = "Save"
        '
        'btnAdd
        '
        Me.btnAdd.AutoSize = True
        Me.btnAdd.BackColor = System.Drawing.Color.Transparent
        Me.btnAdd.Font = New System.Drawing.Font("Airbnb Cereal App Black", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(58, 453)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(30, 14)
        Me.btnAdd.TabIndex = 21
        Me.btnAdd.Text = "Add"
        '
        'txtGuardian
        '
        Me.txtGuardian.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtGuardian.Location = New System.Drawing.Point(97, 318)
        Me.txtGuardian.Multiline = True
        Me.txtGuardian.Name = "txtGuardian"
        Me.txtGuardian.Size = New System.Drawing.Size(190, 15)
        Me.txtGuardian.TabIndex = 20
        '
        'lvwStudent
        '
        Me.lvwStudent.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader10, Me.ColumnHeader8, Me.ColumnHeader5})
        Me.lvwStudent.Location = New System.Drawing.Point(321, 78)
        Me.lvwStudent.Name = "lvwStudent"
        Me.lvwStudent.Size = New System.Drawing.Size(397, 437)
        Me.lvwStudent.TabIndex = 30
        Me.lvwStudent.UseCompatibleStateImageBehavior = False
        Me.lvwStudent.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "LRN"
        Me.ColumnHeader1.Width = 37
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Lastname"
        Me.ColumnHeader2.Width = 67
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Firstname"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "MiddleName"
        Me.ColumnHeader4.Width = 74
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Age"
        Me.ColumnHeader6.Width = 34
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Address"
        Me.ColumnHeader7.Width = 56
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "GuardianID"
        Me.ColumnHeader10.Width = 69
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Grade"
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "ContactNumber"
        '
        'txtMid
        '
        Me.txtMid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMid.Location = New System.Drawing.Point(110, 183)
        Me.txtMid.Multiline = True
        Me.txtMid.Name = "txtMid"
        Me.txtMid.Size = New System.Drawing.Size(180, 16)
        Me.txtMid.TabIndex = 31
        '
        'StudentAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(761, 569)
        Me.Controls.Add(Me.txtMid)
        Me.Controls.Add(Me.lvwStudent)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtGuardian)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.txtGrade)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.txtMiddlename)
        Me.Controls.Add(Me.txtFirstname)
        Me.Controls.Add(Me.txtLastname)
        Me.Controls.Add(Me.txtLRN)
        Me.Name = "StudentAdd"
        Me.Text = "StudentAdd"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtLRN As System.Windows.Forms.TextBox
    Friend WithEvents txtLastname As System.Windows.Forms.TextBox
    Friend WithEvents txtFirstname As System.Windows.Forms.TextBox
    Friend WithEvents txtMiddlename As System.Windows.Forms.TextBox
    Friend WithEvents txtAge As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtGrade As System.Windows.Forms.TextBox
    Friend WithEvents btnCancel As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Label
    Friend WithEvents btnDelete As System.Windows.Forms.Label
    Friend WithEvents btnEdit As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Label
    Friend WithEvents txtGuardian As System.Windows.Forms.TextBox
    Friend WithEvents lvwStudent As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtMid As System.Windows.Forms.TextBox
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
End Class
