Public Class Form2

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


    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
        My.Computer.Audio.Play(My.Resources.BGM, AudioPlayMode.BackgroundLoop)
    End Sub
End Class