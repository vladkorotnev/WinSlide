Public Class Form1
    Dim animcnt As Integer
    Dim animax As Integer
    Dim keyspressed As Integer
    Dim shouldanimateslideout As Boolean
    '-----------------------------------
    '       Screen blank
    '-----------------------------------

    Sub blankScr()
        blackie.Visible = True
        blankscreen.Enabled = False
        animator.Enabled = False
        Windows.Forms.Cursor.Hide()
    End Sub

    Sub unblankScr()
        If blackie.Visible Then
            blackie.Visible = False
            blankscreen.Enabled = True
            animator.Enabled = True
            Windows.Forms.Cursor.Show()
        End If
    End Sub




    Private Sub animator_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles animator.Tick
        If animcnt < animax Then
            lock.Image = lockima.Images.Item(animcnt)
            animcnt = animcnt + 1
        Else
            animcnt = 1
        End If
        clocks.Text = TimeString
        daten.Text = DateString
    End Sub

    Private Sub Form1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp

        If blackie.Visible Then
            unblankScr()
            Exit Sub
        End If

        keyspressed = keyspressed + 1
        ololo.Left = ololo.Left + 15
        If ololo.Left >= lock.Left + lock.Width - ololo.Width - 20 Then
            shouldanimateslideout = True
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        animax = lockima.Images.Count
        animcnt = 1

        Dim sndPing As New System.Media.SoundPlayer("lock.wav")
        sndPing.Play()

        On Error Resume Next
        Me.BackgroundImage = System.Drawing.Image.FromFile("C:\LockWall.jpg")

        Me.TopMost = True

        '------------------------------------------------
        '               TOP SIZE
        '------------------------------------------------
        PictureBox1.Width = Screen.PrimaryScreen.Bounds.Width
        topbar.Width = Screen.PrimaryScreen.Bounds.Width
        clocks.Left = topbar.Width / 2 - clocks.Width
        daten.Left = clocks.Left

        '-----------------------------------------------
        '               BOTTOM SIZE
        '-----------------------------------------------
        bottombar.Width = Screen.PrimaryScreen.Bounds.Width
        bottombar.Top = Me.Height - bottombar.Height
        PictureBox2.Width = Screen.PrimaryScreen.Bounds.Width
        bottomlocker.Left = PictureBox2.Width / 2 - bottomlocker.Width / 2

        '-----------------------------------------------
        '               SCREEN BLANKER
        '-----------------------------------------------
        blackie.Width = Screen.PrimaryScreen.Bounds.Width
        blackie.Height = Screen.PrimaryScreen.Bounds.Height
        blackie.Left = 0
        blackie.Top = 0
    End Sub

    Private Sub blankscreen_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles blankscreen.Tick
        blankScr()
    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        unblankScr()
    End Sub

    Private Sub blackie_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles blackie.MouseDown
        unblankScr()
    End Sub


    Private Sub animout_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles animout.Tick

        If shouldanimateslideout And topbar.Top > 0 - topbar.Height Then
            topbar.Top = topbar.Top - 7
            bottombar.Top = bottombar.Top + 7
            Me.Opacity = Me.Opacity - 0.08
            unblankScr()
        ElseIf shouldanimateslideout And topbar.Top <= 0 - topbar.Height Then
            Dim sndPing As New System.Media.SoundPlayer("unlock.wav")
            sndPing.PlaySync()
            End
        End If
    End Sub
End Class
