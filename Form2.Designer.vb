<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.shin = New System.Windows.Forms.PictureBox()
        Me.title = New System.Windows.Forms.Label()
        Me.pnlTitleBar = New System.Windows.Forms.Panel()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.shin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTitleBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("微軟正黑體", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.Location = New System.Drawing.Point(-127, -110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(160, 45)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "遊戲介紹"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("華康娃娃體W7", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(126, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(626, 369)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("華康娃娃體W7", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.Location = New System.Drawing.Point(119, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(163, 35)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "遊戲說明"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.足球測試.My.Resources.Resources.quit2
        Me.PictureBox2.Location = New System.Drawing.Point(736, 491)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(89, 39)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.足球測試.My.Resources.Resources._3r5n0002r02s3o209s59
        Me.PictureBox1.Location = New System.Drawing.Point(20, 365)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 98)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
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
        Me.title.Text = "遊戲說明"
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
        Me.pnlTitleBar.TabIndex = 33
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Moccasin
        Me.ClientSize = New System.Drawing.Size(873, 559)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlTitleBar)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "遊戲說明"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.shin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTitleBar.ResumeLayout(False)
        Me.pnlTitleBar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents shin As PictureBox
    Friend WithEvents title As Label
    Friend WithEvents pnlTitleBar As Panel
End Class
