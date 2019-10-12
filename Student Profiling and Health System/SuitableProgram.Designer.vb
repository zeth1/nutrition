<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SuitableProgram
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SuitableProgram))
        Me.txtAddProgram = New System.Windows.Forms.Label()
        Me.cbPrograms = New System.Windows.Forms.ComboBox()
        Me.cbSponsore = New System.Windows.Forms.ComboBox()
        Me.txtLRN = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtAddProgram
        '
        Me.txtAddProgram.AutoSize = True
        Me.txtAddProgram.BackColor = System.Drawing.Color.Transparent
        Me.txtAddProgram.Font = New System.Drawing.Font("Airbnb Cereal App Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtAddProgram.ForeColor = System.Drawing.Color.White
        Me.txtAddProgram.Location = New System.Drawing.Point(432, 152)
        Me.txtAddProgram.Name = "txtAddProgram"
        Me.txtAddProgram.Size = New System.Drawing.Size(114, 21)
        Me.txtAddProgram.TabIndex = 0
        Me.txtAddProgram.Text = "Add Program"
        '
        'cbPrograms
        '
        Me.cbPrograms.FormattingEnabled = True
        Me.cbPrograms.Location = New System.Drawing.Point(73, 152)
        Me.cbPrograms.Name = "cbPrograms"
        Me.cbPrograms.Size = New System.Drawing.Size(304, 21)
        Me.cbPrograms.TabIndex = 2
        Me.cbPrograms.Text = "Select"
        '
        'cbSponsore
        '
        Me.cbSponsore.FormattingEnabled = True
        Me.cbSponsore.Location = New System.Drawing.Point(217, 262)
        Me.cbSponsore.Name = "cbSponsore"
        Me.cbSponsore.Size = New System.Drawing.Size(232, 21)
        Me.cbSponsore.TabIndex = 3
        Me.cbSponsore.Text = "Select"
        '
        'txtLRN
        '
        Me.txtLRN.Location = New System.Drawing.Point(124, 37)
        Me.txtLRN.Name = "txtLRN"
        Me.txtLRN.Size = New System.Drawing.Size(253, 20)
        Me.txtLRN.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Airbnb Cereal App Black", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(500, 264)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Confirm"
        '
        'SuitableProgram
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(611, 326)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtLRN)
        Me.Controls.Add(Me.cbSponsore)
        Me.Controls.Add(Me.cbPrograms)
        Me.Controls.Add(Me.txtAddProgram)
        Me.Name = "SuitableProgram"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtAddProgram As System.Windows.Forms.Label
    Friend WithEvents cbPrograms As System.Windows.Forms.ComboBox
    Friend WithEvents cbSponsore As System.Windows.Forms.ComboBox
    Friend WithEvents txtLRN As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
