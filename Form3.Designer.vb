<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.quit = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.heart2 = New System.Windows.Forms.Label()
        Me.heart3 = New System.Windows.Forms.Label()
        Me.heart1 = New System.Windows.Forms.Label()
        Me.PictureBox14 = New System.Windows.Forms.PictureBox()
        Me.ball10 = New System.Windows.Forms.PictureBox()
        Me.ball09 = New System.Windows.Forms.PictureBox()
        Me.ball01 = New System.Windows.Forms.PictureBox()
        Me.ball06 = New System.Windows.Forms.PictureBox()
        Me.ball03 = New System.Windows.Forms.PictureBox()
        Me.ball07 = New System.Windows.Forms.PictureBox()
        Me.ball08 = New System.Windows.Forms.PictureBox()
        Me.ball02 = New System.Windows.Forms.PictureBox()
        Me.man = New System.Windows.Forms.PictureBox()
        Me.ball04 = New System.Windows.Forms.PictureBox()
        Me.ball05 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.greybg = New System.Windows.Forms.PictureBox()
        Me.shin = New System.Windows.Forms.PictureBox()
        Me.title = New System.Windows.Forms.Label()
        Me.pnlTitleBar = New System.Windows.Forms.Panel()
        CType(Me.quit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ball10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ball09, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ball01, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ball06, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ball03, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ball07, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ball08, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ball02, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.man, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ball04, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ball05, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.greybg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.shin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTitleBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 10
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("華康娃娃體W7", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(276, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 21)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "0.0"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("華康娃娃體W7", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.Location = New System.Drawing.Point(354, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 30)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "生命數:"
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 3000
        '
        'Timer3
        '
        Me.Timer3.Enabled = True
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        '
        'quit
        '
        Me.quit.BackColor = System.Drawing.Color.Transparent
        Me.quit.Image = Global.足球測試.My.Resources.Resources.qb
        Me.quit.Location = New System.Drawing.Point(669, 52)
        Me.quit.Name = "quit"
        Me.quit.Size = New System.Drawing.Size(78, 45)
        Me.quit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.quit.TabIndex = 30
        Me.quit.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.足球測試.My.Resources.Resources.shin
        Me.PictureBox2.Location = New System.Drawing.Point(410, 494)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(64, 71)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 29
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.Image = Global.足球測試.My.Resources.Resources.mute
        Me.PictureBox5.Location = New System.Drawing.Point(608, 57)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(36, 40)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 26
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Image = Global.足球測試.My.Resources.Resources.kindpng_46179
        Me.PictureBox4.Location = New System.Drawing.Point(608, 57)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(36, 40)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 25
        Me.PictureBox4.TabStop = False
        '
        'heart2
        '
        Me.heart2.BackColor = System.Drawing.Color.Transparent
        Me.heart2.Image = Global.足球測試.My.Resources.Resources.Love2
        Me.heart2.Location = New System.Drawing.Point(506, 57)
        Me.heart2.Name = "heart2"
        Me.heart2.Size = New System.Drawing.Size(33, 35)
        Me.heart2.TabIndex = 24
        '
        'heart3
        '
        Me.heart3.BackColor = System.Drawing.Color.Transparent
        Me.heart3.Image = Global.足球測試.My.Resources.Resources.Love2
        Me.heart3.Location = New System.Drawing.Point(545, 57)
        Me.heart3.Name = "heart3"
        Me.heart3.Size = New System.Drawing.Size(33, 35)
        Me.heart3.TabIndex = 23
        '
        'heart1
        '
        Me.heart1.BackColor = System.Drawing.Color.Transparent
        Me.heart1.Image = Global.足球測試.My.Resources.Resources.Love2
        Me.heart1.Location = New System.Drawing.Point(467, 57)
        Me.heart1.Name = "heart1"
        Me.heart1.Size = New System.Drawing.Size(33, 35)
        Me.heart1.TabIndex = 20
        '
        'PictureBox14
        '
        Me.PictureBox14.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox14.Image = Global.足球測試.My.Resources.Resources.timer
        Me.PictureBox14.Location = New System.Drawing.Point(222, 55)
        Me.PictureBox14.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox14.Name = "PictureBox14"
        Me.PictureBox14.Size = New System.Drawing.Size(40, 35)
        Me.PictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox14.TabIndex = 19
        Me.PictureBox14.TabStop = False
        Me.PictureBox14.UseWaitCursor = True
        '
        'ball10
        '
        Me.ball10.BackColor = System.Drawing.Color.Transparent
        Me.ball10.Image = Global.足球測試.My.Resources.Resources.ezgif1
        Me.ball10.Location = New System.Drawing.Point(-12, 373)
        Me.ball10.Name = "ball10"
        Me.ball10.Size = New System.Drawing.Size(60, 60)
        Me.ball10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ball10.TabIndex = 7
        Me.ball10.TabStop = False
        Me.ball10.Visible = False
        '
        'ball09
        '
        Me.ball09.BackColor = System.Drawing.Color.Transparent
        Me.ball09.Image = Global.足球測試.My.Resources.Resources.tumblr_nyuryoFbYi1uccnfoo3_250
        Me.ball09.Location = New System.Drawing.Point(803, 373)
        Me.ball09.Name = "ball09"
        Me.ball09.Size = New System.Drawing.Size(80, 80)
        Me.ball09.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ball09.TabIndex = 14
        Me.ball09.TabStop = False
        Me.ball09.Visible = False
        '
        'ball01
        '
        Me.ball01.BackColor = System.Drawing.Color.Transparent
        Me.ball01.Image = Global.足球測試.My.Resources.Resources.ezgif_com_crop__3_
        Me.ball01.Location = New System.Drawing.Point(-12, 306)
        Me.ball01.Name = "ball01"
        Me.ball01.Size = New System.Drawing.Size(160, 160)
        Me.ball01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ball01.TabIndex = 12
        Me.ball01.TabStop = False
        '
        'ball06
        '
        Me.ball06.BackColor = System.Drawing.Color.Transparent
        Me.ball06.Image = Global.足球測試.My.Resources.Resources.earth
        Me.ball06.Location = New System.Drawing.Point(762, 123)
        Me.ball06.Name = "ball06"
        Me.ball06.Size = New System.Drawing.Size(160, 160)
        Me.ball06.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ball06.TabIndex = 10
        Me.ball06.TabStop = False
        Me.ball06.Visible = False
        '
        'ball03
        '
        Me.ball03.BackColor = System.Drawing.Color.Transparent
        Me.ball03.Image = Global.足球測試.My.Resources.Resources.golf2
        Me.ball03.Location = New System.Drawing.Point(-3, 137)
        Me.ball03.Name = "ball03"
        Me.ball03.Size = New System.Drawing.Size(80, 80)
        Me.ball03.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ball03.TabIndex = 9
        Me.ball03.TabStop = False
        Me.ball03.Visible = False
        '
        'ball07
        '
        Me.ball07.BackColor = System.Drawing.Color.Transparent
        Me.ball07.Image = Global.足球測試.My.Resources.Resources.moon
        Me.ball07.Location = New System.Drawing.Point(723, 223)
        Me.ball07.Name = "ball07"
        Me.ball07.Size = New System.Drawing.Size(160, 160)
        Me.ball07.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ball07.TabIndex = 8
        Me.ball07.TabStop = False
        Me.ball07.Visible = False
        '
        'ball08
        '
        Me.ball08.BackColor = System.Drawing.Color.Transparent
        Me.ball08.Image = Global.足球測試.My.Resources.Resources.ezgif3
        Me.ball08.Location = New System.Drawing.Point(-3, 223)
        Me.ball08.Name = "ball08"
        Me.ball08.Size = New System.Drawing.Size(60, 60)
        Me.ball08.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ball08.TabIndex = 6
        Me.ball08.TabStop = False
        Me.ball08.Visible = False
        '
        'ball02
        '
        Me.ball02.BackColor = System.Drawing.Color.Transparent
        Me.ball02.Image = Global.足球測試.My.Resources.Resources.baseball2
        Me.ball02.Location = New System.Drawing.Point(-12, 74)
        Me.ball02.Name = "ball02"
        Me.ball02.Size = New System.Drawing.Size(60, 60)
        Me.ball02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ball02.TabIndex = 5
        Me.ball02.TabStop = False
        Me.ball02.Visible = False
        '
        'man
        '
        Me.man.BackColor = System.Drawing.Color.Transparent
        Me.man.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.man.Cursor = System.Windows.Forms.Cursors.Default
        Me.man.Image = Global.足球測試.My.Resources.Resources.penman
        Me.man.Location = New System.Drawing.Point(403, 492)
        Me.man.Name = "man"
        Me.man.Size = New System.Drawing.Size(71, 71)
        Me.man.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.man.TabIndex = 4
        Me.man.TabStop = False
        '
        'ball04
        '
        Me.ball04.BackColor = System.Drawing.Color.White
        Me.ball04.Image = Global.足球測試.My.Resources.Resources.ezgif_com_crop__1_
        Me.ball04.Location = New System.Drawing.Point(834, 36)
        Me.ball04.Name = "ball04"
        Me.ball04.Size = New System.Drawing.Size(60, 60)
        Me.ball04.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ball04.TabIndex = 2
        Me.ball04.TabStop = False
        Me.ball04.Visible = False
        '
        'ball05
        '
        Me.ball05.BackColor = System.Drawing.Color.Transparent
        Me.ball05.Image = Global.足球測試.My.Resources.Resources.greenss
        Me.ball05.Location = New System.Drawing.Point(803, 74)
        Me.ball05.Name = "ball05"
        Me.ball05.Size = New System.Drawing.Size(80, 80)
        Me.ball05.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ball05.TabIndex = 1
        Me.ball05.TabStop = False
        Me.ball05.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(-3, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(886, 565)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 31
        Me.PictureBox1.TabStop = False
        '
        'greybg
        '
        Me.greybg.BackColor = System.Drawing.Color.Transparent
        Me.greybg.Image = Global.足球測試.My.Resources.Resources._001__1__grey
        Me.greybg.Location = New System.Drawing.Point(-3, 0)
        Me.greybg.Name = "greybg"
        Me.greybg.Size = New System.Drawing.Size(886, 563)
        Me.greybg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.greybg.TabIndex = 28
        Me.greybg.TabStop = False
        '
        'shin
        '
        Me.shin.Image = Global.足球測試.My.Resources.Resources.s1
        Me.shin.Location = New System.Drawing.Point(409, 2)
        Me.shin.Name = "shin"
        Me.shin.Size = New System.Drawing.Size(20, 20)
        Me.shin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.shin.TabIndex = 0
        Me.shin.TabStop = False
        '
        'title
        '
        Me.title.AutoSize = True
        Me.title.Font = New System.Drawing.Font("華康娃娃體W7", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.title.ForeColor = System.Drawing.Color.Black
        Me.title.Location = New System.Drawing.Point(435, 4)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(72, 16)
        Me.title.TabIndex = 1
        Me.title.Text = "一般模式"
        '
        'pnlTitleBar
        '
        Me.pnlTitleBar.BackColor = System.Drawing.Color.Gainsboro
        Me.pnlTitleBar.Controls.Add(Me.shin)
        Me.pnlTitleBar.Controls.Add(Me.title)
        Me.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTitleBar.Location = New System.Drawing.Point(0, 0)
        Me.pnlTitleBar.Name = "pnlTitleBar"
        Me.pnlTitleBar.Size = New System.Drawing.Size(873, 23)
        Me.pnlTitleBar.TabIndex = 32
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(873, 559)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlTitleBar)
        Me.Controls.Add(Me.quit)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.heart2)
        Me.Controls.Add(Me.heart3)
        Me.Controls.Add(Me.heart1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox14)
        Me.Controls.Add(Me.ball10)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ball09)
        Me.Controls.Add(Me.ball01)
        Me.Controls.Add(Me.ball06)
        Me.Controls.Add(Me.ball03)
        Me.Controls.Add(Me.ball07)
        Me.Controls.Add(Me.ball08)
        Me.Controls.Add(Me.ball02)
        Me.Controls.Add(Me.man)
        Me.Controls.Add(Me.ball04)
        Me.Controls.Add(Me.ball05)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.greybg)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "一般模式"
        CType(Me.quit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ball10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ball09, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ball01, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ball06, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ball03, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ball07, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ball08, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ball02, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.man, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ball04, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ball05, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.greybg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.shin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTitleBar.ResumeLayout(False)
        Me.pnlTitleBar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents ball05 As PictureBox
    Friend WithEvents ball04 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents man As PictureBox
    Friend WithEvents ball02 As PictureBox
    Friend WithEvents ball08 As PictureBox
    Friend WithEvents ball10 As PictureBox
    Friend WithEvents ball07 As PictureBox
    Friend WithEvents ball03 As PictureBox
    Friend WithEvents ball06 As PictureBox
    Friend WithEvents ball09 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer3 As Timer
    Friend WithEvents PictureBox14 As PictureBox
    Friend WithEvents heart1 As Label
    Friend WithEvents heart3 As Label
    Friend WithEvents heart2 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents greybg As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents quit As PictureBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ball01 As PictureBox
    Friend WithEvents shin As PictureBox
    Friend WithEvents title As Label
    Friend WithEvents pnlTitleBar As Panel
End Class
