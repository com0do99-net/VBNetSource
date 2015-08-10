<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IMain
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
        Me.components = New System.ComponentModel.Container()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.numericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.textBoxProcess = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.button1 = New System.Windows.Forms.Button()
        Me.timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(12, 43)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(119, 15)
        Me.label3.TabIndex = 11
        Me.label3.Text = "Interval Timer :"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(203, 43)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(56, 15)
        Me.label2.TabIndex = 10
        Me.label2.Text = "seconds"
        '
        'numericUpDown1
        '
        Me.numericUpDown1.Location = New System.Drawing.Point(135, 39)
        Me.numericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numericUpDown1.Name = "numericUpDown1"
        Me.numericUpDown1.Size = New System.Drawing.Size(68, 21)
        Me.numericUpDown1.TabIndex = 9
        Me.numericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'textBoxProcess
        '
        Me.textBoxProcess.Location = New System.Drawing.Point(106, 11)
        Me.textBoxProcess.Name = "textBoxProcess"
        Me.textBoxProcess.Size = New System.Drawing.Size(158, 21)
        Me.textBoxProcess.TabIndex = 8
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(12, 14)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(105, 15)
        Me.label1.TabIndex = 7
        Me.label1.Text = "Process Name :"
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(40, 66)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(243, 34)
        Me.button1.TabIndex = 6
        Me.button1.Text = "Start"
        Me.button1.UseVisualStyleBackColor = True
        '
        'timer1
        '
        Me.timer1.Interval = 1000
        '
        'IMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(306, 116)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.numericUpDown1)
        Me.Controls.Add(Me.textBoxProcess)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.button1)
        Me.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "IMain"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "com0do99 - src"
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents numericUpDown1 As System.Windows.Forms.NumericUpDown
    Private WithEvents textBoxProcess As System.Windows.Forms.TextBox
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents button1 As System.Windows.Forms.Button
    Private WithEvents timer1 As System.Windows.Forms.Timer

End Class
