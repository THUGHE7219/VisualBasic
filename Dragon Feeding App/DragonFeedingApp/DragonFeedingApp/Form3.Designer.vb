<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.pbDragon = New System.Windows.Forms.PictureBox()
        Me.bExit = New System.Windows.Forms.Button()
        Me.bFoodDrinks = New System.Windows.Forms.Button()
        Me.pbFlameOn = New System.Windows.Forms.Button()
        Me.pbFlame = New System.Windows.Forms.PictureBox()
        Me.pbFlameOff = New System.Windows.Forms.Button()
        Me.lbTemperature = New System.Windows.Forms.Label()
        Me.lbDegrees = New System.Windows.Forms.Label()
        Me.tmTime = New System.Windows.Forms.Timer(Me.components)
        Me.tmTemperature = New System.Windows.Forms.Timer(Me.components)
        Me.lbTime = New System.Windows.Forms.Label()
        Me.lbTimer = New System.Windows.Forms.Label()
        CType(Me.pbDragon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbFlame, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbDragon
        '
        Me.pbDragon.BackColor = System.Drawing.Color.Transparent
        Me.pbDragon.Image = CType(resources.GetObject("pbDragon.Image"), System.Drawing.Image)
        Me.pbDragon.Location = New System.Drawing.Point(315, 192)
        Me.pbDragon.Name = "pbDragon"
        Me.pbDragon.Size = New System.Drawing.Size(59, 52)
        Me.pbDragon.TabIndex = 0
        Me.pbDragon.TabStop = False
        '
        'bExit
        '
        Me.bExit.BackColor = System.Drawing.Color.Maroon
        Me.bExit.ForeColor = System.Drawing.Color.White
        Me.bExit.Location = New System.Drawing.Point(586, 12)
        Me.bExit.Name = "bExit"
        Me.bExit.Size = New System.Drawing.Size(58, 23)
        Me.bExit.TabIndex = 1
        Me.bExit.Text = "X"
        Me.bExit.UseVisualStyleBackColor = False
        '
        'bFoodDrinks
        '
        Me.bFoodDrinks.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.bFoodDrinks.ForeColor = System.Drawing.Color.White
        Me.bFoodDrinks.Location = New System.Drawing.Point(12, 300)
        Me.bFoodDrinks.Name = "bFoodDrinks"
        Me.bFoodDrinks.Size = New System.Drawing.Size(122, 23)
        Me.bFoodDrinks.TabIndex = 2
        Me.bFoodDrinks.Text = "Food / Drinks"
        Me.bFoodDrinks.UseVisualStyleBackColor = False
        '
        'pbFlameOn
        '
        Me.pbFlameOn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pbFlameOn.ForeColor = System.Drawing.Color.White
        Me.pbFlameOn.Image = CType(resources.GetObject("pbFlameOn.Image"), System.Drawing.Image)
        Me.pbFlameOn.Location = New System.Drawing.Point(561, 271)
        Me.pbFlameOn.Name = "pbFlameOn"
        Me.pbFlameOn.Size = New System.Drawing.Size(83, 52)
        Me.pbFlameOn.TabIndex = 3
        Me.pbFlameOn.Text = "On"
        Me.pbFlameOn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.pbFlameOn.UseVisualStyleBackColor = False
        '
        'pbFlame
        '
        Me.pbFlame.BackColor = System.Drawing.Color.Transparent
        Me.pbFlame.Image = CType(resources.GetObject("pbFlame.Image"), System.Drawing.Image)
        Me.pbFlame.Location = New System.Drawing.Point(326, 250)
        Me.pbFlame.Name = "pbFlame"
        Me.pbFlame.Size = New System.Drawing.Size(33, 52)
        Me.pbFlame.TabIndex = 4
        Me.pbFlame.TabStop = False
        '
        'pbFlameOff
        '
        Me.pbFlameOff.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pbFlameOff.ForeColor = System.Drawing.Color.White
        Me.pbFlameOff.Image = CType(resources.GetObject("pbFlameOff.Image"), System.Drawing.Image)
        Me.pbFlameOff.Location = New System.Drawing.Point(561, 271)
        Me.pbFlameOff.Name = "pbFlameOff"
        Me.pbFlameOff.Size = New System.Drawing.Size(83, 52)
        Me.pbFlameOff.TabIndex = 5
        Me.pbFlameOff.Text = "Off"
        Me.pbFlameOff.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.pbFlameOff.UseVisualStyleBackColor = False
        '
        'lbTemperature
        '
        Me.lbTemperature.BackColor = System.Drawing.Color.Black
        Me.lbTemperature.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.lbTemperature.ForeColor = System.Drawing.Color.White
        Me.lbTemperature.Location = New System.Drawing.Point(12, 12)
        Me.lbTemperature.Name = "lbTemperature"
        Me.lbTemperature.Size = New System.Drawing.Size(175, 23)
        Me.lbTemperature.TabIndex = 6
        Me.lbTemperature.Text = "Temperature of Egg"
        '
        'lbDegrees
        '
        Me.lbDegrees.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.lbDegrees.ForeColor = System.Drawing.Color.Yellow
        Me.lbDegrees.Location = New System.Drawing.Point(193, 12)
        Me.lbDegrees.Name = "lbDegrees"
        Me.lbDegrees.Size = New System.Drawing.Size(47, 23)
        Me.lbDegrees.TabIndex = 7
        Me.lbDegrees.Text = "50"
        '
        'tmTime
        '
        Me.tmTime.Interval = 1000
        '
        'tmTemperature
        '
        Me.tmTemperature.Interval = 600
        '
        'lbTime
        '
        Me.lbTime.BackColor = System.Drawing.Color.Black
        Me.lbTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.lbTime.ForeColor = System.Drawing.Color.White
        Me.lbTime.Location = New System.Drawing.Point(322, 12)
        Me.lbTime.Name = "lbTime"
        Me.lbTime.Size = New System.Drawing.Size(122, 23)
        Me.lbTime.TabIndex = 8
        Me.lbTime.Text = "Time"
        '
        'lbTimer
        '
        Me.lbTimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.lbTimer.ForeColor = System.Drawing.Color.Yellow
        Me.lbTimer.Location = New System.Drawing.Point(450, 12)
        Me.lbTimer.Name = "lbTimer"
        Me.lbTimer.Size = New System.Drawing.Size(117, 23)
        Me.lbTimer.TabIndex = 9
        Me.lbTimer.Text = "0"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(656, 335)
        Me.ControlBox = False
        Me.Controls.Add(Me.lbTimer)
        Me.Controls.Add(Me.lbTime)
        Me.Controls.Add(Me.lbDegrees)
        Me.Controls.Add(Me.lbTemperature)
        Me.Controls.Add(Me.pbFlameOff)
        Me.Controls.Add(Me.pbFlame)
        Me.Controls.Add(Me.pbFlameOn)
        Me.Controls.Add(Me.bFoodDrinks)
        Me.Controls.Add(Me.bExit)
        Me.Controls.Add(Me.pbDragon)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form3"
        Me.Text = "Game"
        CType(Me.pbDragon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbFlame, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pbDragon As PictureBox
    Friend WithEvents bExit As Button
    Friend WithEvents bFoodDrinks As Button
    Friend WithEvents pbFlameOn As Button
    Friend WithEvents pbFlame As PictureBox
    Friend WithEvents pbFlameOff As Button
    Friend WithEvents lbTemperature As Label
    Friend WithEvents lbDegrees As Label
    Friend WithEvents tmTime As Timer
    Friend WithEvents tmTemperature As Timer
    Friend WithEvents lbTime As Label
    Friend WithEvents lbTimer As Label
End Class
