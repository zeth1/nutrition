<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BMIStatus
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BMIStatus))
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.txtLRN = New System.Windows.Forms.TextBox()
        Me.txtBMI = New System.Windows.Forms.TextBox()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dateTaking = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'txtHeight
        '
        Me.txtHeight.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtHeight.Location = New System.Drawing.Point(128, 67)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(179, 13)
        Me.txtHeight.TabIndex = 3
        '
        'txtWeight
        '
        Me.txtWeight.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtWeight.Location = New System.Drawing.Point(128, 114)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(179, 13)
        Me.txtWeight.TabIndex = 4
        '
        'txtLRN
        '
        Me.txtLRN.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtLRN.Location = New System.Drawing.Point(127, 21)
        Me.txtLRN.Name = "txtLRN"
        Me.txtLRN.Size = New System.Drawing.Size(179, 13)
        Me.txtLRN.TabIndex = 6
        '
        'txtBMI
        '
        Me.txtBMI.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBMI.Location = New System.Drawing.Point(128, 162)
        Me.txtBMI.Name = "txtBMI"
        Me.txtBMI.Size = New System.Drawing.Size(179, 13)
        Me.txtBMI.TabIndex = 8
        '
        'txtStatus
        '
        Me.txtStatus.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtStatus.Location = New System.Drawing.Point(128, 208)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Size = New System.Drawing.Size(179, 13)
        Me.txtStatus.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Airbnb Cereal App Black", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(131, 285)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 17)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Programs"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Airbnb Cereal App Black", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(248, 285)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 17)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Exit"
        '
        'dateTaking
        '
        Me.dateTaking.Location = New System.Drawing.Point(127, 243)
        Me.dateTaking.Name = "dateTaking"
        Me.dateTaking.Size = New System.Drawing.Size(180, 20)
        Me.dateTaking.TabIndex = 14
        '
        'BMIStatus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(389, 323)
        Me.Controls.Add(Me.dateTaking)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtStatus)
        Me.Controls.Add(Me.txtBMI)
        Me.Controls.Add(Me.txtLRN)
        Me.Controls.Add(Me.txtWeight)
        Me.Controls.Add(Me.txtHeight)
        Me.Name = "BMIStatus"
        Me.Text = "BMI Status"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtHeight As System.Windows.Forms.TextBox
    Friend WithEvents txtWeight As System.Windows.Forms.TextBox
    Friend WithEvents txtLRN As System.Windows.Forms.TextBox
    Friend WithEvents txtBMI As System.Windows.Forms.TextBox
    Friend WithEvents txtStatus As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dateTaking As System.Windows.Forms.DateTimePicker
End Class
