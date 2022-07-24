Public Class Form1
    Dim nOldWndLeft As Integer
    Dim nOldWndTop As Integer
    Dim nClickX As Integer
    Dim nClickY As Integer





    Private Sub pnlTitleBar_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlTitleBar.MouseDown
        '紀錄滑鼠點選時的視窗位置與滑鼠點選位置
        nOldWndLeft = Me.Left
        nOldWndTop = Me.Top
        nClickX = e.X
        nClickY = e.Y
    End Sub

    Private Sub pnlTitleBar_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlTitleBar.MouseMove
        If pnlTitleBar.Capture = True Then      '如果滑鼠按著拖曳
            '設定新的視窗位置
            Me.Top = e.Y + nOldWndTop - nClickY
            Me.Left = e.X + nOldWndLeft - nClickX
            '更新紀錄的視窗位置
            nOldWndLeft = Me.Left
            nOldWndTop = Me.Top
        End If
    End Sub
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        PictureBox4.Visible = False
        PictureBox5.Visible = True
        Form2.Show()
        My.Computer.Audio.Play(My.Resources.OP2, AudioPlayMode.Background)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        PictureBox4.Visible = False
        PictureBox5.Visible = True
        Form3.Show()
        My.Computer.Audio.Play(My.Resources.goodw, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        PictureBox4.Visible = False
        PictureBox5.Visible = True
        Form4.Show()
        My.Computer.Audio.Play(My.Resources.F4, AudioPlayMode.BackgroundLoop)
    End Sub
    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        If Me.WindowState = FormWindowState.Minimized Then
            NotifyIcon1.Visible = True
            Me.Visible = False
        End If
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.BGM, AudioPlayMode.BackgroundLoop)

        If Me.WindowState = FormWindowState.Minimized Then
            Me.Hide()
        End If
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        My.Computer.Audio.Stop()
        PictureBox4.Visible = False
        PictureBox5.Visible = True
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        My.Computer.Audio.Play(My.Resources.BGM, AudioPlayMode.BackgroundLoop)
        PictureBox5.Visible = False
        PictureBox4.Visible = True
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        NotifyIcon1.Visible = False
        Me.Show()
        Me.Focus()
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub min_Click(sender As Object, e As EventArgs) Handles min.Click
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.ShowInTaskbar = False
        NotifyIcon1.Visible = True
        Me.Hide()
    End Sub



    Private Sub closing_Click(sender As Object, e As EventArgs) Handles closing.Click

        Me.Close()

    End Sub

    Private Sub pnlTitleBar_Paint(sender As Object, e As PaintEventArgs) Handles pnlTitleBar.Paint

    End Sub
End Class
