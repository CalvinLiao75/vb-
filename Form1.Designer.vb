<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.pnlTitleBar = New System.Windows.Forms.Panel()
        Me.shin = New System.Windows.Forms.PictureBox()
        Me.closing = New System.Windows.Forms.PictureBox()
        Me.min = New System.Windows.Forms.PictureBox()
        Me.title = New System.Windows.Forms.Label()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTitleBar.SuspendLayout()
        CType(Me.shin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.closing, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.min, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = Global.足球測試.My.Resources.Resources.info2
        Me.PictureBox3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox3.Location = New System.Drawing.Point(608, 251)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(158, 50)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 6
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.足球測試.My.Resources.Resources.diam
        Me.PictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox2.Location = New System.Drawing.Point(436, 251)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(158, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.足球測試.My.Resources.Resources.nomr
        Me.PictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox1.Location = New System.Drawing.Point(263, 251)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(158, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Image = Global.足球測試.My.Resources.Resources.redmute1
        Me.PictureBox4.Location = New System.Drawing.Point(680, 139)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(59, 57)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 7
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.Image = Global.足球測試.My.Resources.Resources.muttt
        Me.PictureBox5.Location = New System.Drawing.Point(680, 139)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(59, 57)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 8
        Me.PictureBox5.TabStop = False
        Me.PictureBox5.Visible = False
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "閃球大作戰"
        Me.NotifyIcon1.Visible = True
        '
        'pnlTitleBar
        '
        Me.pnlTitleBar.BackColor = System.Drawing.Color.Gainsboro
        Me.pnlTitleBar.Controls.Add(Me.shin)
        Me.pnlTitleBar.Controls.Add(Me.closing)
        Me.pnlTitleBar.Controls.Add(Me.min)
        Me.pnlTitleBar.Controls.Add(Me.title)
        Me.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTitleBar.Location = New System.Drawing.Point(0, 0)
        Me.pnlTitleBar.Name = "pnlTitleBar"
        Me.pnlTitleBar.Size = New System.Drawing.Size(800, 23)
        Me.pnlTitleBar.TabIndex = 9
        '
        'shin
        '
        Me.shin.Image = Global.足球測試.My.Resources.Resources.s1
        Me.shin.Location = New System.Drawing.Point(376, 2)
        Me.shin.Name = "shin"
        Me.shin.Size = New System.Drawing.Size(20, 20)
        Me.shin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.shin.TabIndex = 0
        Me.shin.TabStop = False
        '
        'closing
        '
        Me.closing.BackColor = System.Drawing.Color.Transparent
        Me.closing.Image = Global.足球測試.My.Resources.Resources.close
        Me.closing.Location = New System.Drawing.Point(6, 4)
        Me.closing.Name = "closing"
        Me.closing.Size = New System.Drawing.Size(15, 15)
        Me.closing.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.closing.TabIndex = 11
        Me.closing.TabStop = False
        '
        'min
        '
        Me.min.BackColor = System.Drawing.Color.Transparent
        Me.min.Image = Global.足球測試.My.Resources.Resources.min
        Me.min.Location = New System.Drawing.Point(25, 4)
        Me.min.Name = "min"
        Me.min.Size = New System.Drawing.Size(15, 15)
        Me.min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.min.TabIndex = 11
        Me.min.TabStop = False
        '
        'title
        '
        Me.title.AutoSize = True
        Me.title.Font = New System.Drawing.Font("華康娃娃體W7", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.title.ForeColor = System.Drawing.Color.Black
        Me.title.Location = New System.Drawing.Point(402, 4)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(88, 16)
        Me.title.TabIndex = 1
        Me.title.Text = "閃球大作戰"
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox7.Image = Global.足球測試.My.Resources.Resources.f1title
        Me.PictureBox7.Location = New System.Drawing.Point(271, 121)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(363, 75)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox7.TabIndex = 10
        Me.PictureBox7.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.足球測試.My.Resources.Resources._333299974_m__1_
        Me.ClientSize = New System.Drawing.Size(800, 558)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.pnlTitleBar)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "閃球大作戰"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTitleBar.ResumeLayout(False)
        Me.pnlTitleBar.PerformLayout()
        CType(Me.shin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.closing, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.min, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents pnlTitleBar As Panel
    Friend WithEvents shin As PictureBox
    Friend WithEvents title As Label
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents closing As PictureBox
    Friend WithEvents min As PictureBox
End Class
