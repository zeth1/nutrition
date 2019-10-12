<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddProgram
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddProgram))
        Me.btnExit = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Label()
        Me.btnEdit = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Label()
        Me.txtProgramID = New System.Windows.Forms.TextBox()
        Me.txtProgramName = New System.Windows.Forms.TextBox()
        Me.lvwProgram = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.AutoSize = True
        Me.btnExit.BackColor = System.Drawing.Color.Transparent
        Me.btnExit.Font = New System.Drawing.Font("Airbnb Cereal App Black", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Black
        Me.btnExit.Location = New System.Drawing.Point(282, 258)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(34, 17)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "Exit"
        '
        'btnClear
        '
        Me.btnClear.AutoSize = True
        Me.btnClear.BackColor = System.Drawing.Color.Transparent
        Me.btnClear.Font = New System.Drawing.Font("Airbnb Cereal App Black", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.Black
        Me.btnClear.Location = New System.Drawing.Point(185, 257)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(42, 17)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "Clear"
        '
        'btnDelete
        '
        Me.btnDelete.AutoSize = True
        Me.btnDelete.BackColor = System.Drawing.Color.Transparent
        Me.btnDelete.Font = New System.Drawing.Font("Airbnb Cereal App Black", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.Black
        Me.btnDelete.Location = New System.Drawing.Point(89, 258)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(52, 17)
        Me.btnDelete.TabIndex = 9
        Me.btnDelete.Text = "Delete"
        '
        'btnEdit
        '
        Me.btnEdit.AutoSize = True
        Me.btnEdit.BackColor = System.Drawing.Color.Transparent
        Me.btnEdit.Font = New System.Drawing.Font("Airbnb Cereal App Black", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.Black
        Me.btnEdit.Location = New System.Drawing.Point(279, 209)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(35, 17)
        Me.btnEdit.TabIndex = 8
        Me.btnEdit.Text = "Edit"
        '
        'btnSave
        '
        Me.btnSave.AutoSize = True
        Me.btnSave.BackColor = System.Drawing.Color.Transparent
        Me.btnSave.Font = New System.Drawing.Font("Airbnb Cereal App Black", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.Location = New System.Drawing.Point(186, 209)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(39, 17)
        Me.btnSave.TabIndex = 7
        Me.btnSave.Text = "Save"
        '
        'btnAdd
        '
        Me.btnAdd.AutoSize = True
        Me.btnAdd.BackColor = System.Drawing.Color.Transparent
        Me.btnAdd.Font = New System.Drawing.Font("Airbnb Cereal App Black", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.Black
        Me.btnAdd.Location = New System.Drawing.Point(94, 210)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(36, 17)
        Me.btnAdd.TabIndex = 6
        Me.btnAdd.Text = "Add"
        '
        'txtProgramID
        '
        Me.txtProgramID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtProgramID.Location = New System.Drawing.Point(268, 64)
        Me.txtProgramID.Name = "txtProgramID"
        Me.txtProgramID.Size = New System.Drawing.Size(194, 13)
        Me.txtProgramID.TabIndex = 12
        '
        'txtProgramName
        '
        Me.txtProgramName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtProgramName.Location = New System.Drawing.Point(268, 127)
        Me.txtProgramName.Name = "txtProgramName"
        Me.txtProgramName.Size = New System.Drawing.Size(194, 13)
        Me.txtProgramName.TabIndex = 13
        '
        'lvwProgram
        '
        Me.lvwProgram.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lvwProgram.Location = New System.Drawing.Point(51, 332)
        Me.lvwProgram.Name = "lvwProgram"
        Me.lvwProgram.Size = New System.Drawing.Size(433, 146)
        Me.lvwProgram.TabIndex = 14
        Me.lvwProgram.UseCompatibleStateImageBehavior = False
        Me.lvwProgram.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ProgramID"
        Me.ColumnHeader1.Width = 216
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "ProgramName"
        Me.ColumnHeader2.Width = 217
        '
        'AddProgram
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(534, 527)
        Me.Controls.Add(Me.lvwProgram)
        Me.Controls.Add(Me.txtProgramName)
        Me.Controls.Add(Me.txtProgramID)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnAdd)
        Me.Name = "AddProgram"
        Me.Text = "AddSponsor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Label
    Friend WithEvents btnDelete As System.Windows.Forms.Label
    Friend WithEvents btnEdit As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Label
    Friend WithEvents txtProgramID As System.Windows.Forms.TextBox
    Friend WithEvents txtProgramName As System.Windows.Forms.TextBox
    Friend WithEvents lvwProgram As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
End Class
