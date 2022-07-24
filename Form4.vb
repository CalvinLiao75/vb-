Public Class Form4

    Dim x1 As Integer = 2                '第一顆球的位移
    Dim y1 As Integer = 4
    Dim x2 As Integer = 3                '第二顆球的位移
    Dim y2 As Integer = 5
    Dim x3 As Integer = 4                '第三顆球的位移
    Dim y3 As Integer = 4
    Dim x4 As Integer = 2                '第四顆球的位移
    Dim y4 As Integer = 5
    Dim x5 As Integer = 4                '第五顆球的位移
    Dim y5 As Integer = 6
    Dim x6 As Integer = 1                '第六顆球的位移
    Dim y6 As Integer = 3
    Dim x7 As Integer = 2                '第七顆球的位移
    Dim y7 As Integer = 4
    Dim x8 As Integer = 3                '第八顆球的位移
    Dim y8 As Integer = 4
    Dim A As Integer = 0                 '球的出現
    Dim B As Integer = 0                 '球的出現
    Dim D As Integer = 0                 '鑽石數量
    Dim I As Integer = 0                 '道具的出現
    Dim ball(7) As PictureBox            '球的陣列
    Dim item(11) As PictureBox           '道具的陣列
    Dim time As Integer = 1200           '秒數

    Sub MsgBoxQ()
        Me.Enabled = False
        My.Computer.Audio.Play(My.Resources.Sad, AudioPlayMode.BackgroundLoop)
        PictureBox1.Visible = False
        PictureBox6.Visible = True
        Me.PictureBox6.Parent = Me.greybg : Me.PictureBox6.Visible = True
        Dim Msg, Style, Title, Response
        Msg = "你輸了，還要再玩一場嗎?"
        Style = vbYesNo
        Title = "閃球大作戰"
        Response = MsgBox(Msg, Style, Title)
        If Response = vbYes Then

            My.Computer.Audio.Play(My.Resources.F4, AudioPlayMode.BackgroundLoop)
            Replay()
        Else
            Me.Close()
            My.Computer.Audio.Play(My.Resources.BGM, AudioPlayMode.BackgroundLoop)
        End If
    End Sub
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
    Sub MsgBoxW()
        Me.Enabled = False
        My.Computer.Audio.Play(My.Resources.win3, AudioPlayMode.BackgroundLoop)

        Me.PictureBox6.Parent = Me.greybg : Me.PictureBox6.Visible = True
        Dim Msg, Style, Title, Response
        Msg = "你贏了，還要再玩一場嗎?"
        Style = vbYesNo
        Title = "閃球大作戰"
        Response = MsgBox(Msg, Style, Title)
        If Response = vbYes Then

            My.Computer.Audio.Play(My.Resources.F4, AudioPlayMode.BackgroundLoop)
            Replay()
        Else
            Me.Close()
            My.Computer.Audio.Play(My.Resources.BGM, AudioPlayMode.BackgroundLoop)
        End If
    End Sub
    Private Sub Replay()
        Dim F4 As New Form4 '宣告一個新執行個體，此時就是一個全新的Form，其內所有的物件和變數都會回到初始狀態 
        F4.Show()
        Me.Close()
    End Sub


    ' Private Sub Form4_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
    '  If (e.CloseReason <> CloseReason.WindowsShutDown) Then
    '  If MessageBox.Show("確定要離開遊戲嗎?", "離開遊戲", MessageBoxButtons.YesNo) = DialogResult.No Then
    '               e.Cancel = True
    '   End If
    '   Else
    '  End
    '  End If
    '   End Sub
    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        My.Computer.Audio.Stop()
        PictureBox4.Visible = False
        PictureBox5.Visible = True
    End Sub


    Private Sub PictureBox15_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click

        My.Computer.Audio.Play(My.Resources.BGM, AudioPlayMode.BackgroundLoop)
        PictureBox5.Visible = False
        PictureBox4.Visible = True
    End Sub
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ControlBox = False
        Me.i1.Parent = Me.PictureBox1 : Me.i1.Visible = False
        Me.i2.Parent = Me.PictureBox1 : Me.i2.Visible = False
        Me.i3.Parent = Me.PictureBox1 : Me.i3.Visible = False
        Me.i4.Parent = Me.PictureBox1 : Me.i4.Visible = False
        Me.i5.Parent = Me.PictureBox1 : Me.i5.Visible = False
        Me.i6.Parent = Me.PictureBox1 : Me.i6.Visible = False
        Me.i7.Parent = Me.PictureBox1 : Me.i7.Visible = False
        Me.i8.Parent = Me.PictureBox1 : Me.i8.Visible = False
        Me.i9.Parent = Me.PictureBox1 : Me.i9.Visible = False
        Me.i10.Parent = Me.PictureBox1 : Me.i10.Visible = False
        Me.i11.Parent = Me.PictureBox1 : Me.i11.Visible = False
        Me.i12.Parent = Me.PictureBox1 : Me.i12.Visible = False
        Me.man.Parent = Me.PictureBox1 : Me.man.Visible = True
        Me.PictureBox2.Parent = Me.PictureBox1 : Me.PictureBox2.Visible = True
        Me.PictureBox4.Parent = Me.PictureBox1 : Me.PictureBox4.Visible = True
        Me.PictureBox5.Parent = Me.PictureBox1 : Me.PictureBox5.Visible = True
        Me.Label1.Parent = Me.PictureBox1 : Me.Label1.Visible = True
        Me.Label2.Parent = Me.PictureBox1 : Me.Label2.Visible = True
        Me.Label3.Parent = Me.PictureBox1 : Me.Label3.Visible = True
        Me.Label4.Parent = Me.PictureBox1 : Me.Label4.Visible = True
        Me.heart1.Parent = Me.PictureBox1 : Me.heart1.Visible = True
        Me.heart2.Parent = Me.PictureBox1 : Me.heart2.Visible = True
        Me.quit.Parent = Me.PictureBox1 : Me.quit.Visible = True


        Dim ballz60 As New Drawing2D.GraphicsPath
        Dim ballz80 As New Drawing2D.GraphicsPath
        ballz60.AddEllipse(0, 0, 56, 56)
        ballz80.AddEllipse(0, 0, 76, 76)

        ball01.Region = New Region(ballz80)
        ball02.Region = New Region(ballz60)
        ball03.Region = New Region(ballz80)
        ball04.Region = New Region(ballz60)
        ball05.Region = New Region(ballz80)
        ball06.Region = New Region(ballz60)
        ball07.Region = New Region(ballz60)
        ball08.Region = New Region(ballz80)


        Me.KeyPreview = True
        ball(0) = ball01
        ball(1) = ball02
        ball(2) = ball03
        ball(3) = ball04
        ball(4) = ball05
        ball(5) = ball06
        ball(6) = ball07
        ball(7) = ball08
        item(0) = i1
        item(1) = i2
        item(2) = i3
        item(3) = i4
        item(4) = i5
        item(5) = i6
        item(6) = i7
        item(7) = i8
        item(8) = i9
        item(9) = i10
        item(10) = i11
        item(11) = i12
    End Sub

    Private Sub Form4_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case 37
                man.Left -= 15
                If man.Left < 0 Then
                    man.Left = 0
                End If
            Case 39
                man.Left += 15
                If man.Left + man.Width > Me.Width Then
                    man.Left = Me.Width - man.Width
                End If
        End Select

    End Sub

    Private Sub it_Tick(sender As Object, e As EventArgs) Handles it.Tick
        Randomize()
        A = Int(Rnd() * 8)
        B = Int(Rnd() * 8)
        ball(A).Visible = True
        ball(B).Visible = True
        item(I).Visible = False
        I = Int(Rnd() * 12)
        item(I).Visible = True
    End Sub

    Private Sub bt_Tick(sender As Object, e As EventArgs) Handles bt.Tick

        If ball(0).Visible = True Then
            ball(0).Left = ball(0).Left + x1
            ball(0).Top = ball(0).Top + y1

            If ball(0).Top + ball(0).Height > Me.Height Or ball(0).Top < 0 Then
                y1 = -y1
                ball(0).Tag += 1
            End If
            If ball(0).Left > Me.Width Then
                ball(0).Visible = False
                ball(0).Location = New Point(-49, 151)
                ball(0).Tag = 0
            End If
        End If

        If ball(1).Visible = True Then
            ball(1).Left = ball(1).Left + x2
            ball(1).Top = ball(1).Top + y2
            If ball(1).Top + ball(1).Height > Me.Height Or ball(1).Top < 0 Then
                y2 = -y2
            End If
            If ball(1).Left > Me.Width Then
                ball(1).Visible = False
                ball(1).Location = New Point(-12, 319)
            End If
        End If

        If ball(2).Visible = True Then
            ball(2).Left = ball(2).Left + x3
            ball(2).Top = ball(2).Top + y3
            If ball(2).Top + ball(2).Height > Me.Height Or ball(2).Top < 0 Then
                y3 = -y3
            End If
            If ball(2).Left > Me.Width Then
                ball(2).Visible = False
                ball(2).Location = New Point(-12, 387)
            End If
        End If

        If ball(3).Visible = True Then
            ball(3).Left = ball(3).Left - x4
            ball(3).Top = ball(3).Top + y4
            If ball(3).Top + ball(3).Height > Me.Height Or ball(3).Top < 0 Then
                y4 = -y4
            End If
            If ball(3).Left + ball(3).Width < 0 Then
                ball(3).Visible = False
                ball(3).Location = New Point(1297, 73)
            End If
        End If

        If ball(4).Visible = True Then
            ball(4).Left = ball(4).Left - x5
            ball(4).Top = ball(4).Top + y5
            If ball(4).Top + ball(4).Height > Me.Height Or ball(4).Top < 0 Then
                y5 = -y5
            End If
            If ball(4).Left + ball(4).Width < 0 Then
                ball(4).Visible = False
                ball(4).Location = New Point(1259, 129)
            End If
        End If

        If ball(5).Visible = True Then
            ball(5).Left = ball(5).Left - x6
            ball(5).Top = ball(5).Top + y6
            If ball(5).Top + ball(5).Height > Me.Height Or ball(5).Top < 0 Then
                y6 = -y6
            End If
            If ball(5).Left + ball(5).Width < 0 Then
                ball(5).Visible = False
                ball(5).Location = New Point(1286, 281)
            End If
        End If

        If ball(6).Visible = True Then
            ball(6).Left = ball(6).Left - x7
            ball(6).Top = ball(6).Top + y7
            If ball(6).Top + ball(6).Height > Me.Height Or ball(6).Top < 0 Then
                y7 = -y7
            End If
            If ball(6).Left + ball(6).Width < 0 Then
                ball(6).Visible = False
                ball(6).Location = New Point(1271, 387)
            End If
        End If

        If ball(7).Visible = True Then
            ball(7).Left = ball(7).Left + x8
            ball(7).Top = ball(7).Top + y8
            If ball(7).Top + ball(7).Height > Me.Height Or ball(7).Top < 0 Then
                y8 = -y8
            End If
            If ball(7).Left > Me.Width Then
                ball(7).Visible = False
                ball(7).Location = New Point(-26, 2)
            End If
        End If

        '以下碰到球計算生命

        If man.Top < ball(0).Bottom Then
            If Math.Abs(man.Left - ball(0).Right) < 5 Or Math.Abs(ball(0).Left - man.Right) < 5 Then 'man.Left - ball(0).Right = 0 Or ball(0).Left - man.Right = 0 Or man.Left - ball(0).Left = 0 Or ball(0).Right - man.Right = 0 Then
                ball(0).Visible = False
                ball(0).Location = New Point(-49, 151)
                If heart2.Enabled = False Then
                    heart1.Enabled = False
                    bt.Stop()
                    it.Stop()
                    tt.Stop()
                    MsgBoxQ()
                    Form1.Show()
                    Me.Close()
                ElseIf heart2.Enabled = True Then
                    heart2.Enabled = False
                End If
            End If
        End If

        If man.Top < ball(1).Bottom Then
            If Math.Abs(man.Left - ball(1).Right) < 5 Or Math.Abs(ball(1).Left - man.Right) < 5 Then 'man.Left - ball(1).Right = 0 Or ball(1).Left - man.Right = 0 Or man.Left - ball(0).Left = 0 Or ball(0).Right - man.Right = 0 Then
                ball(1).Visible = False
                ball(1).Location = New Point(-12, 319)
                If heart2.Enabled = False Then
                    heart1.Enabled = False
                    bt.Stop()
                    it.Stop()
                    tt.Stop()
                    MsgBoxQ()
                    Form1.Show()
                    Me.Close()
                ElseIf heart2.Enabled = True Then
                    heart2.Enabled = False
                End If
            End If
        End If

        If man.Top < ball(2).Bottom Then
            If Math.Abs(man.Left - ball(2).Right) < 5 Or Math.Abs(ball(2).Left - man.Right) < 5 Then 'man.Left - ball(2).Right = 0 Or ball(1).Left - man.Right = 0 Or man.Left - ball(0).Left = 0 Or ball(0).Right - man.Right = 0 Then
                ball(2).Visible = False
                ball(2).Location = New Point(-12, 387)
                If heart2.Enabled = False Then
                    heart1.Enabled = False
                    bt.Stop()
                    it.Stop()
                    tt.Stop()
                    MsgBoxQ()
                    Form1.Show()
                    Me.Close()
                ElseIf heart2.Enabled = True Then
                    heart2.Enabled = False
                End If
            End If
        End If

        If man.Top < ball(3).Bottom Then
            If Math.Abs(man.Left - ball(3).Right) < 5 Or Math.Abs(ball(3).Left - man.Right) < 5 Then 'man.Left - ball(3).Right = 0 Or ball(3).Left - man.Right = 0 Or man.Left - ball(0).Left = 0 Or ball(0).Right - man.Right = 0 Then
                ball(3).Visible = False
                ball(3).Location = New Point(1297, 73)
                If heart2.Enabled = False Then
                    heart1.Enabled = False
                    bt.Stop()
                    it.Stop()
                    tt.Stop()
                    MsgBoxQ()
                    Form1.Show()
                    Me.Close()
                ElseIf heart2.Enabled = True Then
                    heart2.Enabled = False
                End If
            End If
        End If

        If man.Top < ball(4).Bottom Then
            If Math.Abs(man.Left - ball(4).Right) < 5 Or Math.Abs(ball(4).Left - man.Right) < 5 Then 'man.Left - ball(4).Right = 0 Or ball(4).Left - man.Right = 0 Or man.Left - ball(0).Left = 0 Or ball(0).Right - man.Right = 0 Then
                ball(4).Visible = False
                ball(4).Location = New Point(1259, 129)
                If heart2.Enabled = False Then
                    heart1.Enabled = False
                    bt.Stop()
                    it.Stop()
                    tt.Stop()
                    MsgBoxQ()
                    Form1.Show()
                    Me.Close()
                ElseIf heart2.Enabled = True Then
                    heart2.Enabled = False
                End If
            End If
        End If

        If man.Top < ball(5).Bottom Then
            If Math.Abs(man.Left - ball(5).Right) < 5 Or Math.Abs(ball(5).Left - man.Right) < 5 Then 'man.Left - ball(5).Right = 0 Or ball(4).Left - man.Right = 0 Or man.Left - ball(0).Left = 0 Or ball(0).Right - man.Right = 0 Then
                ball(5).Location = New Point(1286, 281)
                If heart2.Enabled = False Then
                    heart1.Enabled = False
                    bt.Stop()
                    it.Stop()
                    tt.Stop()
                    MsgBoxQ()
                    Form1.Show()
                    Me.Close()
                ElseIf heart2.Enabled = True Then
                    heart2.Enabled = False
                End If
            End If
        End If


        If man.Top < ball(6).Bottom Then
            If Math.Abs(man.Left - ball(6).Right) < 5 Or Math.Abs(ball(6).Left - man.Right) < 5 Then 'man.Left - ball(6).Right = 0 Or ball(4).Left - man.Right = 0 Or man.Left - ball(0).Left = 0 Or ball(0).Right - man.Right = 0 Then
                ball(6).Visible = False
                ball(6).Location = New Point(1271, 387)
                If heart2.Enabled = False Then
                    heart1.Enabled = False
                    bt.Stop()
                    it.Stop()
                    tt.Stop()
                    MsgBoxQ()
                    Form1.Show()
                    Me.Close()
                ElseIf heart2.Enabled = True Then
                    heart2.Enabled = False
                End If
            End If
        End If

        If man.Top < ball(7).Bottom Then
            If Math.Abs(man.Left - ball(7).Right) < 5 Or Math.Abs(ball(7).Left - man.Right) < 5 Then 'man.Left - ball(7).Right = 0 Or ball(7).Left - man.Right = 0 Or man.Left - ball(0).Left = 0 Or ball(0).Right - man.Right = 0 Then
                ball(7).Visible = False
                ball(7).Location = New Point(-26, 2)
                If heart2.Enabled = False Then
                    heart1.Enabled = False
                    bt.Stop()
                    it.Stop()
                    tt.Stop()
                    MsgBoxQ()
                    Form1.Show()
                    Me.Close()
                ElseIf heart2.Enabled = True Then
                    heart2.Enabled = False
                End If
            End If
        End If

        '以下吃道具

        If item(0).Visible = True Then
            If Math.Abs(man.Left - item(0).Right) < 9 Or Math.Abs(man.Right - item(0).Left) < 9 Then
                D += 1
                item(0).Visible = False
                Label4.Text = D
                If D = 20 Then
                    bt.Stop()
                    it.Stop()
                    tt.Stop()
                    MsgBoxW()
                    Form1.Show()
                    Me.Close()
                End If
            End If
        End If

        If item(1).Visible = True Then
            If Math.Abs(man.Left - item(1).Right) < 9 Or Math.Abs(man.Right - item(1).Left) < 9 Then
                D += 1
                item(1).Visible = False
                Label4.Text = D
                If D = 20 Then
                    bt.Stop()
                    it.Stop()
                    tt.Stop()
                    MsgBoxW()
                    Form1.Show()
                    Me.Close()
                End If
            End If
        End If

        If item(2).Visible = True Then
            If Math.Abs(man.Left - item(2).Right) < 9 Or Math.Abs(man.Right - item(2).Left) < 9 Then
                D += 1
                item(2).Visible = False
                Label4.Text = D
                If D = 20 Then
                    bt.Stop()
                    it.Stop()
                    tt.Stop()
                    MsgBoxW()
                    Form1.Show()
                    Me.Close()
                End If
            End If
        End If

        If item(3).Visible = True Then
            If Math.Abs(man.Left - item(3).Right) < 9 Or Math.Abs(man.Right - item(3).Left) < 9 Then
                D += 1
                item(3).Visible = False
                Label4.Text = D
                If D = 20 Then
                    bt.Stop()
                    it.Stop()
                    tt.Stop()
                    MsgBoxW()
                    Form1.Show()
                    Me.Close()
                End If
            End If
        End If

        If item(4).Visible = True Then
            If Math.Abs(man.Left - item(4).Right) < 9 Or Math.Abs(man.Right - item(4).Left) < 9 Then
                item(4).Visible = False
                time += 100
                Label1.Text = time
            End If
        End If

        If item(5).Visible = True Then
            If Math.Abs(man.Left - item(5).Right) < 9 Or Math.Abs(man.Right - item(5).Left) < 9 Then
                D += 1
                item(5).Visible = False
                Label4.Text = D
                If D = 20 Then
                    bt.Stop()
                    it.Stop()
                    tt.Stop()
                    MsgBoxW()
                    Form1.Show()
                    Me.Close()
                End If
            End If
        End If

        If item(6).Visible = True Then
            If Math.Abs(man.Left - item(6).Right) < 9 Or Math.Abs(man.Right - item(6).Left) < 9 Then
                D += 1
                item(6).Visible = False
                Label4.Text = D
                If D = 20 Then
                    bt.Stop()
                    it.Stop()
                    tt.Stop()
                    MsgBoxW()
                    Form1.Show()
                    Me.Close()
                End If
            End If
        End If

        If item(7).Visible = True Then
            If Math.Abs(man.Left - item(7).Right) < 9 Or Math.Abs(man.Right - item(7).Left) < 9 Then
                item(7).Visible = False
                If heart2.Enabled = False Then
                    heart2.Enabled = True
                End If
            End If
        End If

        If item(8).Visible = True Then
            If Math.Abs(man.Left - item(8).Right) < 9 Or Math.Abs(man.Right - item(8).Left) < 9 Then
                D += 1
                item(8).Visible = False
                Label4.Text = D
                If D = 20 Then
                    bt.Stop()
                    it.Stop()
                    tt.Stop()
                    MsgBoxW()
                    Form1.Show()
                    Me.Close()
                End If
            End If
        End If

        If item(9).Visible = True Then
            If Math.Abs(man.Left - item(9).Right) < 9 Or Math.Abs(man.Right - item(9).Left) < 9 Then
                D += 1
                item(9).Visible = False
                Label4.Text = D
                If D = 20 Then
                    bt.Stop()
                    it.Stop()
                    tt.Stop()
                    MsgBoxW()
                    Form1.Show()
                    Me.Close()
                End If
            End If
        End If

        If item(10).Visible = True Then
            If Math.Abs(man.Left - item(10).Right) < 9 Or Math.Abs(man.Right - item(10).Left) < 9 Then
                D += 1
                item(10).Visible = False
                Label4.Text = D
                If D = 20 Then
                    bt.Stop()
                    it.Stop()
                    tt.Stop()
                    MsgBoxW()
                    Form1.Show()
                    Me.Close()
                End If
            End If
        End If

        If item(11).Visible = True Then
            If Math.Abs(man.Left - item(11).Right) < 9 Or Math.Abs(man.Right - item(11).Left) < 9 Then
                D += 1
                item(11).Visible = False
                Label4.Text = D
                If D = 20 Then
                    bt.Stop()
                    it.Stop()
                    tt.Stop()
                    MsgBoxW()
                    Form1.Show()
                    Me.Close()
                End If
            End If
        End If

    End Sub


    Private Sub tt_Tick(sender As Object, e As EventArgs) Handles tt.Tick
        time -= 1
        Label1.Text = time / 10
        If time = 0 Then
            bt.Stop()
            it.Stop()
            tt.Stop()
            MsgBox("Game Over")
            Form1.Show()
            Me.Close()
        End If
    End Sub

    Private Sub quit_Click(sender As Object, e As EventArgs) Handles quit.Click
        Me.Close()
        My.Computer.Audio.Play(My.Resources.BGM, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles pnlTitleBar.Paint

    End Sub
End Class