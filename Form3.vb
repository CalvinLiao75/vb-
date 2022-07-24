Public Class Form3

    Dim x1 As Integer = 2    'x位移量
    Dim y1 As Integer = 2    'Y位移量
    Dim x2 As Integer = 2    'x位移量
    Dim y2 As Integer = 2    'Y位移量
    Dim x3 As Integer = 2    'x位移量
    Dim y3 As Integer = 2    'Y位移量
    Dim x4 As Integer = 2    'x位移量
    Dim y4 As Integer = 2    'Y位移量
    Dim x5 As Integer = 2    'x位移量
    Dim y5 As Integer = 2    'Y位移量
    Dim x6 As Integer = 2    'x位移量
    Dim y6 As Integer = 2    'Y位移量
    Dim x7 As Integer = 2    'x位移量
    Dim y7 As Integer = 2    'Y位移量
    Dim x8 As Integer = 2    'x位移量
    Dim y8 As Integer = 2    'Y位移量
    Dim x9 As Integer = 2    'x位移量
    Dim y9 As Integer = 2    'Y位移量
    Dim x10 As Integer = 2    'x位移量
    Dim y10 As Integer = 2    'Y位移量
    ' Dim x11 As Integer = 2    'x位移量
    ' Dim y11 As Integer = 2    'Y位移量
    ' Dim x12 As Integer = 2    'x位移量
    ' Dim y12 As Integer = 2    'Y位移量
    Dim counter As Integer = 0
    Dim balln(9) As PictureBox '隨機跳12顆球
    'Private Sub Form3_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
    'If (e.CloseReason <> CloseReason.WindowsShutDown) Then
    ' If MessageBox.Show("確定要離開遊戲嗎?", "離開遊戲", MessageBoxButtons.YesNo) = DialogResult.No Then
    '         e.Cancel = True
    'Else If 
    '  End
    'End If

    '  End Sub



    Private Sub Replay()
        Dim F3 As New Form3 '宣告一個新執行個體，此時就是一個全新的Form，其內所有的物件和變數都會回到初始狀態 
        F3.Show()
        Me.Close()
    End Sub
    Sub MsgBoxQuestionIcon()
        Me.Enabled = False
        My.Computer.Audio.Play(My.Resources.Sad, AudioPlayMode.BackgroundLoop)
        PictureBox1.Visible = False
        PictureBox2.Visible = True
        Me.PictureBox2.Parent = Me.greybg : Me.PictureBox2.Visible = True
        Dim Msg, Style, Title, Response
        Msg = "你輸了，還要再玩一場嗎?"
        Style = vbYesNo
        Title = "閃球大作戰"
        Response = MsgBox(Msg, Style, Title)
        If Response = vbYes Then
            Replay()
            My.Computer.Audio.Play(My.Resources.goodw, AudioPlayMode.BackgroundLoop)
        Else
            My.Computer.Audio.Play(My.Resources.BGM, AudioPlayMode.BackgroundLoop)
            Me.Close()
        End If
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.ball01.Parent = Me.PictureBox1 : Me.ball01.Visible = False
        Me.ball02.Parent = Me.PictureBox1 : Me.ball02.Visible = False
        Me.ball03.Parent = Me.PictureBox1 : Me.ball03.Visible = False
        Me.ball04.Parent = Me.PictureBox1 : Me.ball04.Visible = False
        Me.ball05.Parent = Me.PictureBox1 : Me.ball05.Visible = False
        Me.ball06.Parent = Me.PictureBox1 : Me.ball06.Visible = False
        Me.ball07.Parent = Me.PictureBox1 : Me.ball07.Visible = False
        Me.ball08.Parent = Me.PictureBox1 : Me.ball08.Visible = False
        Me.ball09.Parent = Me.PictureBox1 : Me.ball09.Visible = False
        Me.ball10.Parent = Me.PictureBox1 : Me.ball10.Visible = False
        Me.man.Parent = Me.PictureBox1 : Me.man.Visible = True
        Me.man.Parent = Me.PictureBox1 : Me.man.Visible = True
        Me.Label1.Parent = Me.PictureBox1 : Me.Label1.Visible = True
        Me.Label2.Parent = Me.PictureBox1 : Me.Label2.Visible = True
        Me.heart1.Parent = Me.PictureBox1 : Me.heart1.Visible = True
        Me.heart2.Parent = Me.PictureBox1 : Me.heart2.Visible = True
        Me.heart3.Parent = Me.PictureBox1 : Me.heart3.Visible = True
        Me.PictureBox4.Parent = Me.PictureBox1 : Me.PictureBox4.Visible = True
        Me.PictureBox5.Parent = Me.PictureBox1 : Me.PictureBox5.Visible = True
        Me.PictureBox14.Parent = Me.PictureBox1 : Me.PictureBox14.Visible = True
        Me.quit.Parent = Me.PictureBox1 : Me.quit.Visible = True


        PictureBox5.Visible = False
        Dim ballz60 As New Drawing2D.GraphicsPath
        Dim ballz80 As New Drawing2D.GraphicsPath
        Dim ballz160 As New Drawing2D.GraphicsPath
        ballz60.AddEllipse(2, 2, 52, 52)
        ballz80.AddEllipse(4, 4, 74, 74)
        ballz160.AddEllipse(4, 4, 152, 152)
        ball01.Region = New Region(ballz160)
        ball02.Region = New Region(ballz60)
        ball03.Region = New Region(ballz80)
        ball04.Region = New Region(ballz60)
        ball05.Region = New Region(ballz80)
        ball06.Region = New Region(ballz160)
        ball07.Region = New Region(ballz160)
        ball08.Region = New Region(ballz60)
        ball09.Region = New Region(ballz80)
        ball10.Region = New Region(ballz60)
        'ball11.Region = New Region(ballz50)
        'ball12.Region = New Region(ballz50)
        Me.KeyPreview = True
        balln(0) = ball01
        balln(1) = ball02
        balln(2) = ball03
        balln(3) = ball04
        balln(4) = ball05
        balln(5) = ball06
        balln(6) = ball07
        balln(7) = ball08
        balln(8) = ball09
        balln(9) = ball10



        BackgroundWorker1.RunWorkerAsync()

        ' balln(10) = ball11
        ' balln(11) = ball12

    End Sub




    Private Sub Form3_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
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

    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick
        If balln(0).Visible = True Then
            balln(0).Left = balln(0).Left + x1
            balln(0).Top = balln(0).Top + y1
            If balln(0).Top + balln(0).Height > Me.Height Or balln(0).Top < 0 Then
                y1 = -y1 * 1.25
            End If
            If balln(0).Left > Me.Width Then
                balln(0).Visible = False
                balln(0).Location = New Point(-49, 151)
            End If
        End If

        If balln(1).Visible = True Then
            balln(1).Left = balln(1).Left + x2
            balln(1).Top = balln(1).Top + y2
            If balln(1).Top + balln(1).Height > Me.Height Or balln(1).Top < 0 Then
                y2 = -y2 * 1.25
            End If
            If balln(1).Left > Me.Width Then
                balln(1).Visible = False
                balln(1).Location = New Point(-12, 319)
            End If
        End If

        If balln(2).Visible = True Then
            balln(2).Left = balln(2).Left + x3
            balln(2).Top = balln(2).Top + y3
            If balln(2).Top + balln(2).Height > Me.Height Or balln(2).Top < 0 Then
                y3 = -y3 * 1.25
            End If
            If balln(2).Left > Me.Width Then
                balln(2).Visible = False
                balln(2).Location = New Point(-12, 387)
            End If
        End If

        If balln(3).Visible = True Then
            balln(3).Left = balln(3).Left - x4
            balln(3).Top = balln(3).Top + y4
            If balln(3).Top + balln(3).Height > Me.Height Or balln(3).Top < 0 Then
                y4 = -y4 * 1.25
            End If
            If balln(3).Left + balln(3).Width < 0 Then
                balln(3).Visible = False
                balln(3).Location = New Point(1297, 73)
            End If
        End If

        If balln(4).Visible = True Then
            balln(4).Left = balln(4).Left - x5
            balln(4).Top = balln(4).Top + y5
            If balln(4).Top + balln(4).Height > Me.Height Or balln(4).Top < 0 Then
                y5 = -y5 * 1.25
            End If
            If balln(4).Left + balln(4).Width < 0 Then
                balln(4).Visible = False
                balln(4).Location = New Point(1259, 129)
            End If
        End If

        If balln(5).Visible = True Then
            balln(5).Left = balln(5).Left - x6
            balln(5).Top = balln(5).Top + y6
            If balln(5).Top + balln(5).Height > Me.Height Or balln(5).Top < 0 Then
                y6 = -y6 * 1.25
            End If
            If balln(5).Left + balln(5).Width < 0 Then
                balln(5).Visible = False
                balln(5).Location = New Point(1286, 281)
            End If
        End If

        If balln(6).Visible = True Then
            balln(6).Left = balln(6).Left - x7
            balln(6).Top = balln(6).Top + y7
            If balln(6).Top + balln(6).Height > Me.Height Or balln(6).Top < 0 Then
                y7 = -y7 * 1.25
            End If
            If balln(6).Left + balln(6).Width < 0 Then
                balln(6).Visible = False
                balln(6).Location = New Point(1271, 266)
            End If
        End If

        If balln(7).Visible = True Then
            balln(7).Left = balln(7).Left + x8
            balln(7).Top = balln(7).Top + y8
            If balln(7).Top + balln(7).Height > Me.Height Or balln(7).Top < 0 Then
                y8 = -y8 * 1.25
            End If
            If balln(7).Left > Me.Width Then
                balln(7).Visible = False
                balln(7).Location = New Point(-26, 2)
            End If
        End If

        If balln(8).Visible = True Then
            balln(8).Left = balln(8).Left + x9
            balln(8).Top = balln(8).Top + y9
            If balln(8).Top + balln(8).Height > Me.Height Or balln(8).Top < 0 Then
                y9 = -y9 * 1.25
            End If
            If balln(8).Left > Me.Width Then
                balln(8).Visible = False
                balln(8).Location = New Point(-26, 324)
            End If
        End If

        If balln(9).Visible = True Then
            balln(9).Left = balln(9).Left + x10
            balln(9).Top = balln(9).Top + y10
            If balln(9).Top + balln(9).Height > Me.Height Or balln(9).Top < 0 Then
                y10 = -y10 * 1.25
            End If
            If balln(9).Left > Me.Width Then
                balln(9).Visible = False
                balln(9).Location = New Point(-26, 375)
            End If
        End If

        'If balln(10).Visible = True Then
        'balln(10).Left = balln(10).Left - x11
        'balln(10).Top = balln(10).Top + y11
        'If balln(10).Top + balln(10).Height > Me.Height Or balln(10).Top < 0 Then
        'y11 = -y11 * 1.25
        '  End If
        'If balln(10).Left + balln(10).Width < 0 Then
        'balln(10).Visible = False
        'alln(10).Location = New Point(1271, 400)
        'End If
        ' End If

        ' If balln(11).Visible = True Then
        '    balln(11).Left = balln(11).Left - x12
        ' balln(11).Top = balln(11).Top + y12
        ' If balln(11).Top + balln(11).Height > Me.Height Or balln(11).Top < 0 Then
        ' y12 = -y12 * 1.25
        ' End If
        '     If balln(11).Left + balln(11).Width < 0 Then
        '' balln(11).Visible = False
        '  balln(11).Location = New Point(1271, 328)
        '  End If
        '  End If

        '以下碰到球計算生命

        If man.Top < balln(0).Bottom Then
            If Math.Abs(man.Left - balln(0).Right) < 5 Or Math.Abs(balln(0).Left - man.Right) < 5 Then
                balln(0).Visible = False
                balln(0).Location = New Point(-49, 151)
                If heart2.Enabled = False Then
                    heart1.Enabled = False
                    Timer1.Stop()
                    Timer2.Stop()
                    Timer3.Stop()
                    MsgBoxQuestionIcon()
                    Form1.Show()
                    Me.Close()
                ElseIf heart3.Enabled = True Then
                    heart3.Enabled = False
                ElseIf heart2.Enabled = True Then
                    heart2.Enabled = False
                End If
            End If
        End If

        If man.Top < balln(1).Bottom Then
            If Math.Abs(man.Left - balln(1).Right) < 5 Or Math.Abs(balln(1).Left - man.Right) < 5 Then
                balln(1).Visible = False
                balln(1).Location = New Point(-12, 319)
                If heart2.Enabled = False Then
                    heart1.Enabled = False
                    Timer1.Stop()
                    Timer2.Stop()
                    Timer3.Stop()
                    MsgBoxQuestionIcon()
                    Form1.Show()
                    Me.Close()
                ElseIf heart3.Enabled = True Then
                    heart3.Enabled = False
                ElseIf heart2.Enabled = True Then
                    heart2.Enabled = False
                End If
            End If
        End If

        If man.Top < balln(2).Bottom Then
            If Math.Abs(man.Left - balln(2).Right) < 5 Or Math.Abs(balln(2).Left - man.Right) < 5 Then
                balln(2).Visible = False
                balln(2).Location = New Point(-12, 387)
                If heart2.Enabled = False Then
                    heart1.Enabled = False
                    Timer1.Stop()
                    Timer2.Stop()
                    Timer3.Stop()
                    MsgBoxQuestionIcon()
                    Form1.Show()
                    Me.Close()
                ElseIf heart3.Enabled = True Then
                    heart3.Enabled = False
                ElseIf heart2.Enabled = True Then
                    heart2.Enabled = False
                End If
            End If
        End If

        If man.Top < balln(3).Bottom Then
            If Math.Abs(man.Left - balln(3).Right) < 5 Or Math.Abs(balln(3).Left - man.Right) < 5 Then
                balln(3).Visible = False
                balln(3).Location = New Point(1297, 73)
                If heart2.Enabled = False Then
                    heart1.Enabled = False
                    Timer1.Stop()
                    Timer2.Stop()
                    Timer3.Stop()
                    MsgBoxQuestionIcon()
                    Form1.Show()
                    Me.Close()
                ElseIf heart3.Enabled = True Then
                    heart3.Enabled = False
                ElseIf heart2.Enabled = True Then
                    heart2.Enabled = False
                End If
            End If
        End If

        If man.Top < balln(4).Bottom Then
            If Math.Abs(man.Left - balln(4).Right) < 5 Or Math.Abs(balln(4).Left - man.Right) < 5 Then
                balln(4).Visible = False
                balln(4).Location = New Point(1259, 129)
                If heart2.Enabled = False Then
                    heart1.Enabled = False
                    Timer1.Stop()
                    Timer2.Stop()
                    Timer3.Stop()
                    MsgBoxQuestionIcon()
                    Form1.Show()
                    Me.Close()
                ElseIf heart3.Enabled = True Then
                    heart3.Enabled = False
                ElseIf heart2.Enabled = True Then
                    heart2.Enabled = False
                End If
            End If
        End If

        If man.Top < balln(5).Bottom Then
            If Math.Abs(man.Left - balln(5).Right) < 5 Or Math.Abs(balln(5).Left - man.Right) < 5 Then
                balln(5).Location = New Point(1286, 281)
                If heart2.Enabled = False Then
                    heart1.Enabled = False
                    Timer1.Stop()
                    Timer2.Stop()
                    Timer3.Stop()
                    MsgBoxQuestionIcon()
                    Form1.Show()
                    Me.Close()
                ElseIf heart3.Enabled = True Then
                    heart3.Enabled = False
                ElseIf heart2.Enabled = True Then
                    heart2.Enabled = False
                End If
            End If
        End If

        If man.Top < balln(6).Bottom Then
            If Math.Abs(man.Left - balln(6).Right) < 5 Or Math.Abs(balln(6).Left - man.Right) < 5 Then
                balln(6).Visible = False
                balln(6).Location = New Point(1271, 387)
                If heart2.Enabled = False Then
                    heart1.Enabled = False
                    Timer1.Stop()
                    Timer2.Stop()
                    Timer3.Stop()
                    MsgBoxQuestionIcon()
                    Form1.Show()
                    Me.Close()
                ElseIf heart3.Enabled = True Then
                    heart3.Enabled = False
                ElseIf heart2.Enabled = True Then
                    heart2.Enabled = False
                End If
            End If
        End If

        If man.Top < balln(7).Bottom Then
            If Math.Abs(man.Left - balln(7).Right) < 5 Or Math.Abs(balln(7).Left - man.Right) < 5 Then
                balln(7).Visible = False
                balln(7).Location = New Point(-26, 2)
                If heart2.Enabled = False Then
                    heart1.Enabled = False
                    Timer1.Stop()
                    Timer2.Stop()
                    Timer3.Stop()
                    MsgBoxQuestionIcon()
                    Form1.Show()
                    Me.Close()
                ElseIf heart3.Enabled = True Then
                    heart3.Enabled = False
                ElseIf heart2.Enabled = True Then
                    heart2.Enabled = False
                End If
            End If
        End If

        If man.Top < balln(8).Bottom Then
            If Math.Abs(man.Left - balln(8).Right) < 5 Or Math.Abs(balln(8).Left - man.Right) < 5 Then
                balln(8).Visible = False
                balln(8).Location = New Point(-26, 324)
                If heart2.Enabled = False Then
                    heart1.Enabled = False
                    Timer1.Stop()
                    Timer2.Stop()
                    Timer3.Stop()
                    MsgBoxQuestionIcon()
                    Form1.Show()
                    Me.Close()
                ElseIf heart3.Enabled = True Then
                    heart3.Enabled = False
                ElseIf heart2.Enabled = True Then
                    heart2.Enabled = False
                End If
            End If
        End If

        If man.Top < balln(9).Bottom Then
            If Math.Abs(man.Left - balln(9).Right) < 5 Or Math.Abs(balln(9).Left - man.Right) < 5 Then
                balln(9).Visible = False
                balln(9).Location = New Point(-26, 375)
                If heart2.Enabled = False Then
                    heart1.Enabled = False
                    Timer1.Stop()
                    Timer2.Stop()
                    Timer3.Stop()
                    MsgBoxQuestionIcon()
                    Form1.Show()
                    Me.Close()
                ElseIf heart3.Enabled = True Then
                    heart3.Enabled = False
                ElseIf heart2.Enabled = True Then
                    heart2.Enabled = False
                End If
            End If
        End If

        'If man.Top < balln(10).Bottom Then
        'If Math.Abs(man.Left - balln(10).Right) < 5 Or Math.Abs(balln(10).Left - man.Right) < 5 Then
        'balln(10).Visible = False
        'balln(10).Location = New Point(1271, 400)
        '  If heart2.Enabled = False Then
        '    heart1.Enabled = False
        '    Timer1.Stop()
        '                Timer2.Stop()
        '    Timer3.Stop()
        '    MsgBox("你輸了")
        '    Form1.Show()
        '                 Me.Close()
        '   ElseIf heart3.Enabled = True Then
        '     heart3.Enabled = False
        '            ElseIf heart2.Enabled = True Then
        '    heart2.Enabled = False
        '      End If
        '        End If
        '  End If

        '   If man.Top < balln(11).Bottom Then
        '  If Math.Abs(man.Left - balln(11).Right) < 5 Or Math.Abs(balln(11).Left - man.Right) < 5 Then
        '   balln(11).Visible = False
        '   balln(11).Location = New Point(1271, 458)
        '   If heart2.Enabled = False Then
        '   heart1.Enabled = False
        '   Timer1.Stop()
        '   Timer2.Stop()
        '    Timer3.Stop()
        '  MsgBox("你輸了")
        '                  Form1.Show()
        '  Me.Close()
        '           ElseIf heart3.Enabled = True Then
        '  heart3.Enabled = False
        '            ElseIf heart2.Enabled = True Then
        '    heart2.Enabled = False
        '   End If
        '   End If
        '   End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        Randomize()
        Dim i As Integer = Int(Rnd() * 10)
        Dim a As Integer = Int(Rnd() * 10)
        Dim b As Integer = Int(Rnd() * 10)
        balln(a).Visible = True
        balln(b).Visible = True
        balln(i).Visible = True

    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick

        counter += 10

        Label1.Text = counter / 100

    End Sub




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

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub quit_Click(sender As Object, e As EventArgs) Handles quit.Click
        Me.Close()
        My.Computer.Audio.Play(My.Resources.BGM, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        PictureBox1.Image = My.Resources.f3bg
    End Sub

    Private Sub ball10_Click(sender As Object, e As EventArgs) Handles ball10.Click

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
    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class