<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bStart = New System.Windows.Forms.Button()
        Me.bHowToPlay = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.bExit = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Lime
        Me.Label1.Location = New System.Drawing.Point(190, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(385, 63)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Feed a Dragon"
        '
        'bStart
        '
        Me.bStart.ForeColor = System.Drawing.SystemColors.WindowText
        Me.bStart.Location = New System.Drawing.Point(271, 309)
        Me.bStart.Name = "bStart"
        Me.bStart.Size = New System.Drawing.Size(215, 50)
        Me.bStart.TabIndex = 1
        Me.bStart.Text = "Start"
        Me.bStart.UseVisualStyleBackColor = True
        '
        'bHowToPlay
        '
        Me.bHowToPlay.Location = New System.Drawing.Point(271, 385)
        Me.bHowToPlay.Name = "bHowToPlay"
        Me.bHowToPlay.Size = New System.Drawing.Size(215, 50)
        Me.bHowToPlay.TabIndex = 2
        Me.bHowToPlay.Text = "How to Play"
        Me.bHowToPlay.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(284, 111)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(186, 148)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'bExit
        '
        Me.bExit.BackColor = System.Drawing.Color.Maroon
        Me.bExit.ForeColor = System.Drawing.Color.White
        Me.bExit.Location = New System.Drawing.Point(652, 12)
        Me.bExit.Name = "bExit"
        Me.bExit.Size = New System.Drawing.Size(75, 23)
        Me.bExit.TabIndex = 4
        Me.bExit.Text = "X"
        Me.bExit.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(739, 479)
        Me.ControlBox = False
        Me.Controls.Add(Me.bExit)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.bHowToPlay)
        Me.Controls.Add(Me.bStart)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Start"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents bStart As Button
    Friend WithEvents bHowToPlay As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents bExit As Button
End Class
