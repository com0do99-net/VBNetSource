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
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtPortHost = New System.Windows.Forms.TextBox()
        Me.txtHost = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.groupBox5 = New System.Windows.Forms.GroupBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.groupBox1.SuspendLayout()
        Me.groupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.txtPortHost)
        Me.groupBox1.Controls.Add(Me.txtHost)
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Location = New System.Drawing.Point(8, 7)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(250, 42)
        Me.groupBox1.TabIndex = 125
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Server"
        '
        'txtPortHost
        '
        Me.txtPortHost.BackColor = System.Drawing.Color.White
        Me.txtPortHost.Location = New System.Drawing.Point(203, 15)
        Me.txtPortHost.MaxLength = 4
        Me.txtPortHost.Name = "txtPortHost"
        Me.txtPortHost.Size = New System.Drawing.Size(42, 21)
        Me.txtPortHost.TabIndex = 3
        '
        'txtHost
        '
        Me.txtHost.BackColor = System.Drawing.Color.White
        Me.txtHost.Location = New System.Drawing.Point(78, 15)
        Me.txtHost.Name = "txtHost"
        Me.txtHost.Size = New System.Drawing.Size(122, 21)
        Me.txtHost.TabIndex = 2
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.BackColor = System.Drawing.Color.Transparent
        Me.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.label1.Location = New System.Drawing.Point(3, 17)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(77, 15)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Host     :"
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(17, 125)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(229, 32)
        Me.btnStart.TabIndex = 127
        Me.btnStart.TabStop = False
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.White
        Me.txtPassword.Location = New System.Drawing.Point(78, 40)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(167, 21)
        Me.txtPassword.TabIndex = 6
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'txtusername
        '
        Me.txtusername.BackColor = System.Drawing.Color.White
        Me.txtusername.Location = New System.Drawing.Point(78, 16)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(167, 21)
        Me.txtusername.TabIndex = 5
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.BackColor = System.Drawing.Color.Transparent
        Me.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.label3.Location = New System.Drawing.Point(3, 19)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(77, 15)
        Me.label3.TabIndex = 100
        Me.label3.Text = "Username :"
        '
        'groupBox5
        '
        Me.groupBox5.Controls.Add(Me.txtPassword)
        Me.groupBox5.Controls.Add(Me.txtusername)
        Me.groupBox5.Controls.Add(Me.label4)
        Me.groupBox5.Controls.Add(Me.label3)
        Me.groupBox5.Location = New System.Drawing.Point(8, 52)
        Me.groupBox5.Name = "groupBox5"
        Me.groupBox5.Size = New System.Drawing.Size(250, 67)
        Me.groupBox5.TabIndex = 126
        Me.groupBox5.TabStop = False
        Me.groupBox5.Text = "Authentication"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.BackColor = System.Drawing.Color.Transparent
        Me.label4.Location = New System.Drawing.Point(3, 43)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(77, 15)
        Me.label4.TabIndex = 104
        Me.label4.Text = "Password :"
        '
        'IMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(266, 164)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.groupBox5)
        Me.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "IMain"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "com0do99.net - src"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.groupBox5.ResumeLayout(False)
        Me.groupBox5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents txtPortHost As System.Windows.Forms.TextBox
    Private WithEvents txtHost As System.Windows.Forms.TextBox
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents btnStart As System.Windows.Forms.Button
    Private WithEvents txtPassword As System.Windows.Forms.TextBox
    Private WithEvents txtusername As System.Windows.Forms.TextBox
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents groupBox5 As System.Windows.Forms.GroupBox
    Private WithEvents label4 As System.Windows.Forms.Label

End Class
