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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.topbar = New System.Windows.Forms.Panel
        Me.daten = New System.Windows.Forms.Label
        Me.clocks = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.lockima = New System.Windows.Forms.ImageList(Me.components)
        Me.animator = New System.Windows.Forms.Timer(Me.components)
        Me.bottombar = New System.Windows.Forms.Panel
        Me.bottomlocker = New System.Windows.Forms.Panel
        Me.ololo = New System.Windows.Forms.PictureBox
        Me.lock = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.blackie = New System.Windows.Forms.Panel
        Me.blankscreen = New System.Windows.Forms.Timer(Me.components)
        Me.animout = New System.Windows.Forms.Timer(Me.components)
        Me.topbar.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bottombar.SuspendLayout()
        Me.bottomlocker.SuspendLayout()
        CType(Me.ololo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'topbar
        '
        Me.topbar.Controls.Add(Me.daten)
        Me.topbar.Controls.Add(Me.clocks)
        Me.topbar.Controls.Add(Me.PictureBox1)
        Me.topbar.Location = New System.Drawing.Point(0, 2)
        Me.topbar.Name = "topbar"
        Me.topbar.Size = New System.Drawing.Size(540, 76)
        Me.topbar.TabIndex = 1
        '
        'daten
        '
        Me.daten.AutoSize = True
        Me.daten.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.daten.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.daten.ForeColor = System.Drawing.Color.White
        Me.daten.Location = New System.Drawing.Point(210, 41)
        Me.daten.Name = "daten"
        Me.daten.Size = New System.Drawing.Size(89, 20)
        Me.daten.TabIndex = 3
        Me.daten.Text = "10.01.2011"
        '
        'clocks
        '
        Me.clocks.AutoSize = True
        Me.clocks.BackColor = System.Drawing.Color.DarkGray
        Me.clocks.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.clocks.ForeColor = System.Drawing.Color.White
        Me.clocks.Location = New System.Drawing.Point(222, 7)
        Me.clocks.Name = "clocks"
        Me.clocks.Size = New System.Drawing.Size(64, 24)
        Me.clocks.TabIndex = 2
        Me.clocks.Text = "00:00"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.topbar
        Me.PictureBox1.Location = New System.Drawing.Point(0, -4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(545, 77)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'lockima
        '
        Me.lockima.ImageStream = CType(resources.GetObject("lockima.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.lockima.TransparentColor = System.Drawing.Color.Transparent
        Me.lockima.Images.SetKeyName(0, "1")
        Me.lockima.Images.SetKeyName(1, "2")
        Me.lockima.Images.SetKeyName(2, "3")
        Me.lockima.Images.SetKeyName(3, "4")
        Me.lockima.Images.SetKeyName(4, "5")
        Me.lockima.Images.SetKeyName(5, "6.bmp")
        Me.lockima.Images.SetKeyName(6, "7.bmp")
        Me.lockima.Images.SetKeyName(7, "8.bmp")
        Me.lockima.Images.SetKeyName(8, "9.bmp")
        Me.lockima.Images.SetKeyName(9, "20.bmp")
        Me.lockima.Images.SetKeyName(10, "10.bmp")
        Me.lockima.Images.SetKeyName(11, "11.bmp")
        Me.lockima.Images.SetKeyName(12, "12.bmp")
        Me.lockima.Images.SetKeyName(13, "13.bmp")
        Me.lockima.Images.SetKeyName(14, "14.bmp")
        Me.lockima.Images.SetKeyName(15, "15.bmp")
        Me.lockima.Images.SetKeyName(16, "16.bmp")
        Me.lockima.Images.SetKeyName(17, "17.bmp")
        Me.lockima.Images.SetKeyName(18, "18.bmp")
        Me.lockima.Images.SetKeyName(19, "19.bmp")
        '
        'animator
        '
        Me.animator.Enabled = True
        '
        'bottombar
        '
        Me.bottombar.Controls.Add(Me.bottomlocker)
        Me.bottombar.Controls.Add(Me.PictureBox2)
        Me.bottombar.Location = New System.Drawing.Point(0, 392)
        Me.bottombar.Name = "bottombar"
        Me.bottombar.Size = New System.Drawing.Size(543, 78)
        Me.bottombar.TabIndex = 3
        '
        'bottomlocker
        '
        Me.bottomlocker.Controls.Add(Me.ololo)
        Me.bottomlocker.Controls.Add(Me.lock)
        Me.bottomlocker.Location = New System.Drawing.Point(169, 6)
        Me.bottomlocker.Name = "bottomlocker"
        Me.bottomlocker.Size = New System.Drawing.Size(205, 64)
        Me.bottomlocker.TabIndex = 6
        '
        'ololo
        '
        Me.ololo.Image = Global.WindowsApplication1.My.Resources.Resources.arrow_black
        Me.ololo.Location = New System.Drawing.Point(8, 18)
        Me.ololo.Name = "ololo"
        Me.ololo.Size = New System.Drawing.Size(48, 32)
        Me.ololo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.ololo.TabIndex = 7
        Me.ololo.TabStop = False
        '
        'lock
        '
        Me.lock.Image = Global.WindowsApplication1.My.Resources.Resources._1
        Me.lock.Location = New System.Drawing.Point(-9, 0)
        Me.lock.Name = "lock"
        Me.lock.Size = New System.Drawing.Size(224, 67)
        Me.lock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.lock.TabIndex = 6
        Me.lock.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.WindowsApplication1.My.Resources.Resources.topbar
        Me.PictureBox2.Location = New System.Drawing.Point(-2, 1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(545, 77)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'blackie
        '
        Me.blackie.BackColor = System.Drawing.Color.Black
        Me.blackie.Location = New System.Drawing.Point(145, 302)
        Me.blackie.Name = "blackie"
        Me.blackie.Size = New System.Drawing.Size(32, 28)
        Me.blackie.TabIndex = 4
        Me.blackie.Visible = False
        '
        'blankscreen
        '
        Me.blankscreen.Enabled = True
        Me.blankscreen.Interval = 8000
        '
        'animout
        '
        Me.animout.Enabled = True
        Me.animout.Interval = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(542, 470)
        Me.ControlBox = False
        Me.Controls.Add(Me.blackie)
        Me.Controls.Add(Me.bottombar)
        Me.Controls.Add(Me.topbar)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.TransparencyKey = System.Drawing.Color.Red
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.topbar.ResumeLayout(False)
        Me.topbar.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bottombar.ResumeLayout(False)
        Me.bottomlocker.ResumeLayout(False)
        Me.bottomlocker.PerformLayout()
        CType(Me.ololo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents topbar As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents clocks As System.Windows.Forms.Label
    Friend WithEvents lockima As System.Windows.Forms.ImageList
    Friend WithEvents animator As System.Windows.Forms.Timer
    Friend WithEvents bottombar As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents bottomlocker As System.Windows.Forms.Panel
    Friend WithEvents ololo As System.Windows.Forms.PictureBox
    Friend WithEvents lock As System.Windows.Forms.PictureBox
    Friend WithEvents daten As System.Windows.Forms.Label
    Friend WithEvents blackie As System.Windows.Forms.Panel
    Friend WithEvents blankscreen As System.Windows.Forms.Timer
    Friend WithEvents animout As System.Windows.Forms.Timer

End Class
