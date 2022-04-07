<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDate))
        Me.mtbEnterDate = New System.Windows.Forms.MaskedTextBox()
        Me.lblEnterDate = New System.Windows.Forms.Label()
        Me.grpOutputDate = New System.Windows.Forms.GroupBox()
        Me.lblDesicion = New System.Windows.Forms.Label()
        Me.lblReset = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.picWeekDay = New System.Windows.Forms.PictureBox()
        Me.picWeekend = New System.Windows.Forms.PictureBox()
        Me.lblDayOfWeek = New System.Windows.Forms.Label()
        Me.txtDayOfWeek = New System.Windows.Forms.TextBox()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.grpLogin = New System.Windows.Forms.GroupBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.grpEnterDate = New System.Windows.Forms.GroupBox()
        Me.grpOutputDate.SuspendLayout()
        CType(Me.picWeekDay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picWeekend, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLogin.SuspendLayout()
        Me.grpEnterDate.SuspendLayout()
        Me.SuspendLayout()
        '
        'mtbEnterDate
        '
        Me.mtbEnterDate.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtbEnterDate.Location = New System.Drawing.Point(137, 19)
        Me.mtbEnterDate.Mask = "00/00/0000"
        Me.mtbEnterDate.Name = "mtbEnterDate"
        Me.mtbEnterDate.Size = New System.Drawing.Size(100, 27)
        Me.mtbEnterDate.TabIndex = 0
        Me.mtbEnterDate.ValidatingType = GetType(Date)
        '
        'lblEnterDate
        '
        Me.lblEnterDate.AutoSize = True
        Me.lblEnterDate.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnterDate.Location = New System.Drawing.Point(6, 20)
        Me.lblEnterDate.Name = "lblEnterDate"
        Me.lblEnterDate.Size = New System.Drawing.Size(127, 19)
        Me.lblEnterDate.TabIndex = 1
        Me.lblEnterDate.Text = "Please enter date:"
        '
        'grpOutputDate
        '
        Me.grpOutputDate.BackColor = System.Drawing.Color.PaleGreen
        Me.grpOutputDate.Controls.Add(Me.lblDesicion)
        Me.grpOutputDate.Controls.Add(Me.lblReset)
        Me.grpOutputDate.Controls.Add(Me.btnReset)
        Me.grpOutputDate.Controls.Add(Me.btnExit)
        Me.grpOutputDate.Controls.Add(Me.picWeekDay)
        Me.grpOutputDate.Controls.Add(Me.picWeekend)
        Me.grpOutputDate.Controls.Add(Me.lblDayOfWeek)
        Me.grpOutputDate.Controls.Add(Me.txtDayOfWeek)
        Me.grpOutputDate.Location = New System.Drawing.Point(15, 77)
        Me.grpOutputDate.Name = "grpOutputDate"
        Me.grpOutputDate.Size = New System.Drawing.Size(418, 272)
        Me.grpOutputDate.TabIndex = 2
        Me.grpOutputDate.TabStop = False
        Me.grpOutputDate.Text = "Date Result"
        Me.grpOutputDate.Visible = False
        '
        'lblDesicion
        '
        Me.lblDesicion.AutoSize = True
        Me.lblDesicion.Font = New System.Drawing.Font("Harlow Solid Italic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesicion.Location = New System.Drawing.Point(6, 205)
        Me.lblDesicion.Name = "lblDesicion"
        Me.lblDesicion.Size = New System.Drawing.Size(37, 20)
        Me.lblDesicion.TabIndex = 8
        Me.lblDesicion.Text = "null"
        '
        'lblReset
        '
        Me.lblReset.AutoSize = True
        Me.lblReset.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReset.Location = New System.Drawing.Point(33, 242)
        Me.lblReset.Name = "lblReset"
        Me.lblReset.Size = New System.Drawing.Size(167, 19)
        Me.lblReset.TabIndex = 7
        Me.lblReset.Text = "I want to try it again! -->"
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.LightPink
        Me.btnReset.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.Color.DarkViolet
        Me.btnReset.Location = New System.Drawing.Point(206, 230)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 36)
        Me.btnReset.TabIndex = 6
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.LightPink
        Me.btnExit.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.DarkViolet
        Me.btnExit.Location = New System.Drawing.Point(337, 19)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 28)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'picWeekDay
        '
        Me.picWeekDay.Image = CType(resources.GetObject("picWeekDay.Image"), System.Drawing.Image)
        Me.picWeekDay.Location = New System.Drawing.Point(10, 64)
        Me.picWeekDay.Name = "picWeekDay"
        Me.picWeekDay.Size = New System.Drawing.Size(149, 138)
        Me.picWeekDay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picWeekDay.TabIndex = 5
        Me.picWeekDay.TabStop = False
        Me.picWeekDay.Visible = False
        '
        'picWeekend
        '
        Me.picWeekend.Image = CType(resources.GetObject("picWeekend.Image"), System.Drawing.Image)
        Me.picWeekend.Location = New System.Drawing.Point(9, 64)
        Me.picWeekend.Name = "picWeekend"
        Me.picWeekend.Size = New System.Drawing.Size(149, 138)
        Me.picWeekend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picWeekend.TabIndex = 3
        Me.picWeekend.TabStop = False
        Me.picWeekend.Visible = False
        '
        'lblDayOfWeek
        '
        Me.lblDayOfWeek.AutoSize = True
        Me.lblDayOfWeek.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDayOfWeek.Location = New System.Drawing.Point(6, 28)
        Me.lblDayOfWeek.Name = "lblDayOfWeek"
        Me.lblDayOfWeek.Size = New System.Drawing.Size(118, 19)
        Me.lblDayOfWeek.TabIndex = 4
        Me.lblDayOfWeek.Text = "Day of the week:"
        '
        'txtDayOfWeek
        '
        Me.txtDayOfWeek.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDayOfWeek.Location = New System.Drawing.Point(130, 28)
        Me.txtDayOfWeek.Name = "txtDayOfWeek"
        Me.txtDayOfWeek.ReadOnly = True
        Me.txtDayOfWeek.Size = New System.Drawing.Size(100, 27)
        Me.txtDayOfWeek.TabIndex = 3
        '
        'btnEnter
        '
        Me.btnEnter.BackColor = System.Drawing.Color.Khaki
        Me.btnEnter.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnter.ForeColor = System.Drawing.Color.MediumPurple
        Me.btnEnter.Location = New System.Drawing.Point(243, 16)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(75, 36)
        Me.btnEnter.TabIndex = 3
        Me.btnEnter.Text = "Enter"
        Me.btnEnter.UseVisualStyleBackColor = False
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.Violet
        Me.btnLogin.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.Khaki
        Me.btnLogin.Location = New System.Drawing.Point(100, 123)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(75, 31)
        Me.btnLogin.TabIndex = 4
        Me.btnLogin.Text = "LOG IN"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(4, 57)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(79, 19)
        Me.lblUsername.TabIndex = 5
        Me.lblUsername.Text = "Username:"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(6, 87)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(75, 19)
        Me.lblPassword.TabIndex = 6
        Me.lblPassword.Text = "Password:"
        '
        'grpLogin
        '
        Me.grpLogin.BackColor = System.Drawing.Color.PaleTurquoise
        Me.grpLogin.Controls.Add(Me.txtPassword)
        Me.grpLogin.Controls.Add(Me.txtUsername)
        Me.grpLogin.Controls.Add(Me.btnLogin)
        Me.grpLogin.Controls.Add(Me.lblUsername)
        Me.grpLogin.Controls.Add(Me.lblPassword)
        Me.grpLogin.Location = New System.Drawing.Point(468, 77)
        Me.grpLogin.Name = "grpLogin"
        Me.grpLogin.Size = New System.Drawing.Size(253, 272)
        Me.grpLogin.TabIndex = 7
        Me.grpLogin.TabStop = False
        Me.grpLogin.Text = "Login"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(87, 87)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(102, 20)
        Me.txtPassword.TabIndex = 8
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(87, 56)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(100, 20)
        Me.txtUsername.TabIndex = 7
        '
        'grpEnterDate
        '
        Me.grpEnterDate.BackColor = System.Drawing.Color.Thistle
        Me.grpEnterDate.Controls.Add(Me.btnEnter)
        Me.grpEnterDate.Controls.Add(Me.mtbEnterDate)
        Me.grpEnterDate.Controls.Add(Me.lblEnterDate)
        Me.grpEnterDate.Location = New System.Drawing.Point(15, 12)
        Me.grpEnterDate.Name = "grpEnterDate"
        Me.grpEnterDate.Size = New System.Drawing.Size(418, 59)
        Me.grpEnterDate.TabIndex = 8
        Me.grpEnterDate.TabStop = False
        Me.grpEnterDate.Text = "Date"
        Me.grpEnterDate.Visible = False
        '
        'frmDate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.grpEnterDate)
        Me.Controls.Add(Me.grpLogin)
        Me.Controls.Add(Me.grpOutputDate)
        Me.Name = "frmDate"
        Me.Text = "MyDate"
        Me.grpOutputDate.ResumeLayout(False)
        Me.grpOutputDate.PerformLayout()
        CType(Me.picWeekDay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picWeekend, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpLogin.ResumeLayout(False)
        Me.grpLogin.PerformLayout()
        Me.grpEnterDate.ResumeLayout(False)
        Me.grpEnterDate.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents mtbEnterDate As MaskedTextBox
    Friend WithEvents lblEnterDate As Label
    Friend WithEvents grpOutputDate As GroupBox
    Friend WithEvents lblReset As Label
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents picWeekDay As PictureBox
    Friend WithEvents picWeekend As PictureBox
    Friend WithEvents lblDayOfWeek As Label
    Friend WithEvents txtDayOfWeek As TextBox
    Friend WithEvents btnEnter As Button
    Friend WithEvents lblDesicion As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents grpLogin As GroupBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents grpEnterDate As GroupBox
End Class
