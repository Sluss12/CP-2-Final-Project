<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TwoPlayerNetwork
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Asset_Bar2 = New System.Windows.Forms.PictureBox()
        Me.Asset_Bar = New System.Windows.Forms.PictureBox()
        Me.Asset_Ball = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackToMainToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HighScoreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveHighscoreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewHighscoreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MultiplayerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FindGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StartGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Ball_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Point_counter = New System.Windows.Forms.Timer(Me.components)
        Me.servertimer = New System.Windows.Forms.Timer(Me.components)
        Me.Movecount = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.clienttimer = New System.Windows.Forms.Timer(Me.components)
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        CType(Me.Asset_Bar2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Asset_Bar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Asset_Ball, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(12, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 20)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Label1"
        '
        'Asset_Bar2
        '
        Me.Asset_Bar2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Asset_Bar2.Location = New System.Drawing.Point(298, 28)
        Me.Asset_Bar2.Margin = New System.Windows.Forms.Padding(2)
        Me.Asset_Bar2.Name = "Asset_Bar2"
        Me.Asset_Bar2.Size = New System.Drawing.Size(119, 24)
        Me.Asset_Bar2.TabIndex = 10
        Me.Asset_Bar2.TabStop = False
        '
        'Asset_Bar
        '
        Me.Asset_Bar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Asset_Bar.Location = New System.Drawing.Point(298, 503)
        Me.Asset_Bar.Margin = New System.Windows.Forms.Padding(2)
        Me.Asset_Bar.Name = "Asset_Bar"
        Me.Asset_Bar.Size = New System.Drawing.Size(119, 24)
        Me.Asset_Bar.TabIndex = 9
        Me.Asset_Bar.TabStop = False
        '
        'Asset_Ball
        '
        Me.Asset_Ball.Image = Global.MemeGame.My.Resources.Resources.Asset_ball
        Me.Asset_Ball.Location = New System.Drawing.Point(318, 227)
        Me.Asset_Ball.Margin = New System.Windows.Forms.Padding(2)
        Me.Asset_Ball.Name = "Asset_Ball"
        Me.Asset_Ball.Size = New System.Drawing.Size(64, 67)
        Me.Asset_Ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Asset_Ball.TabIndex = 8
        Me.Asset_Ball.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingsToolStripMenuItem, Me.HighScoreToolStripMenuItem, Me.MultiplayerToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(675, 24)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackToMainToolStripMenuItem, Me.QuitToolStripMenuItem})
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.SettingsToolStripMenuItem.Text = "settings"
        '
        'BackToMainToolStripMenuItem
        '
        Me.BackToMainToolStripMenuItem.Name = "BackToMainToolStripMenuItem"
        Me.BackToMainToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.BackToMainToolStripMenuItem.Text = "Back to Main"
        '
        'QuitToolStripMenuItem
        '
        Me.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem"
        Me.QuitToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.QuitToolStripMenuItem.Text = "Quit"
        '
        'HighScoreToolStripMenuItem
        '
        Me.HighScoreToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveHighscoreToolStripMenuItem, Me.ViewHighscoreToolStripMenuItem})
        Me.HighScoreToolStripMenuItem.Name = "HighScoreToolStripMenuItem"
        Me.HighScoreToolStripMenuItem.Size = New System.Drawing.Size(74, 20)
        Me.HighScoreToolStripMenuItem.Text = "HighScore"
        '
        'SaveHighscoreToolStripMenuItem
        '
        Me.SaveHighscoreToolStripMenuItem.Name = "SaveHighscoreToolStripMenuItem"
        Me.SaveHighscoreToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.SaveHighscoreToolStripMenuItem.Text = "Save Highscore"
        '
        'ViewHighscoreToolStripMenuItem
        '
        Me.ViewHighscoreToolStripMenuItem.Name = "ViewHighscoreToolStripMenuItem"
        Me.ViewHighscoreToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.ViewHighscoreToolStripMenuItem.Text = "View Highscore"
        '
        'MultiplayerToolStripMenuItem
        '
        Me.MultiplayerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FindGameToolStripMenuItem, Me.StartGameToolStripMenuItem})
        Me.MultiplayerToolStripMenuItem.Name = "MultiplayerToolStripMenuItem"
        Me.MultiplayerToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
        Me.MultiplayerToolStripMenuItem.Text = "multiplayer"
        '
        'FindGameToolStripMenuItem
        '
        Me.FindGameToolStripMenuItem.Name = "FindGameToolStripMenuItem"
        Me.FindGameToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.FindGameToolStripMenuItem.Text = "find game"
        '
        'StartGameToolStripMenuItem
        '
        Me.StartGameToolStripMenuItem.Name = "StartGameToolStripMenuItem"
        Me.StartGameToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.StartGameToolStripMenuItem.Text = "start game"
        '
        'Ball_Timer
        '
        Me.Ball_Timer.Interval = 80
        '
        'Point_counter
        '
        '
        'servertimer
        '
        '
        'Movecount
        '
        Me.Movecount.Enabled = True
        Me.Movecount.Interval = 70
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'clienttimer
        '
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(583, 28)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(80, 82)
        Me.ListBox1.TabIndex = 12
        '
        'TwoPlayerNetwork
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(675, 534)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Asset_Bar2)
        Me.Controls.Add(Me.Asset_Bar)
        Me.Controls.Add(Me.Asset_Ball)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "TwoPlayerNetwork"
        Me.Text = "TwoPlayerNetwork"
        CType(Me.Asset_Bar2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Asset_Bar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Asset_Ball, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Asset_Bar2 As PictureBox
    Friend WithEvents Asset_Bar As PictureBox
    Friend WithEvents Asset_Ball As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BackToMainToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HighScoreToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveHighscoreToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewHighscoreToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Ball_Timer As Timer
    Friend WithEvents Point_counter As Timer
    Friend WithEvents servertimer As Timer
    Friend WithEvents Movecount As Timer
    Friend WithEvents Timer1 As Timer
    Friend WithEvents MultiplayerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FindGameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StartGameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents clienttimer As Timer
    Friend WithEvents ListBox1 As ListBox
End Class
