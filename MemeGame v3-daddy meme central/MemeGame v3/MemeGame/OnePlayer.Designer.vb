<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OnePlayer
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResumeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackToMainMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HighScoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewHighscoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveYourScoreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Ball_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Asset_Bar = New System.Windows.Forms.PictureBox()
        Me.Asset_Ball = New System.Windows.Forms.PictureBox()
        Me.Point_counter = New System.Windows.Forms.Timer(Me.components)
        Me.lblScore = New System.Windows.Forms.Label()
        Me.lblLives = New System.Windows.Forms.Label()
        Me.LifeChecker = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        CType(Me.Asset_Bar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Asset_Ball, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingsToolStripMenuItem, Me.HighScoresToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(932, 31)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ResumeToolStripMenuItem, Me.BackToMainMenuToolStripMenuItem, Me.QuitToolStripMenuItem})
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(83, 27)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'ResumeToolStripMenuItem
        '
        Me.ResumeToolStripMenuItem.Name = "ResumeToolStripMenuItem"
        Me.ResumeToolStripMenuItem.Size = New System.Drawing.Size(234, 28)
        Me.ResumeToolStripMenuItem.Text = "Resume"
        '
        'BackToMainMenuToolStripMenuItem
        '
        Me.BackToMainMenuToolStripMenuItem.Name = "BackToMainMenuToolStripMenuItem"
        Me.BackToMainMenuToolStripMenuItem.Size = New System.Drawing.Size(234, 28)
        Me.BackToMainMenuToolStripMenuItem.Text = "Back to main menu"
        '
        'QuitToolStripMenuItem
        '
        Me.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem"
        Me.QuitToolStripMenuItem.Size = New System.Drawing.Size(234, 28)
        Me.QuitToolStripMenuItem.Text = "Quit"
        '
        'HighScoresToolStripMenuItem
        '
        Me.HighScoresToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewHighscoresToolStripMenuItem, Me.SaveYourScoreToolStripMenuItem})
        Me.HighScoresToolStripMenuItem.Name = "HighScoresToolStripMenuItem"
        Me.HighScoresToolStripMenuItem.Size = New System.Drawing.Size(112, 27)
        Me.HighScoresToolStripMenuItem.Text = "High Scores"
        '
        'ViewHighscoresToolStripMenuItem
        '
        Me.ViewHighscoresToolStripMenuItem.Name = "ViewHighscoresToolStripMenuItem"
        Me.ViewHighscoresToolStripMenuItem.Size = New System.Drawing.Size(208, 28)
        Me.ViewHighscoresToolStripMenuItem.Text = "View highscores"
        '
        'SaveYourScoreToolStripMenuItem
        '
        Me.SaveYourScoreToolStripMenuItem.Name = "SaveYourScoreToolStripMenuItem"
        Me.SaveYourScoreToolStripMenuItem.Size = New System.Drawing.Size(208, 28)
        Me.SaveYourScoreToolStripMenuItem.Text = "Save your score"
        '
        'Ball_Timer
        '
        Me.Ball_Timer.Interval = 50
        '
        'Asset_Bar
        '
        Me.Asset_Bar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Asset_Bar.Location = New System.Drawing.Point(396, 631)
        Me.Asset_Bar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Asset_Bar.Name = "Asset_Bar"
        Me.Asset_Bar.Size = New System.Drawing.Size(153, 30)
        Me.Asset_Bar.TabIndex = 1
        Me.Asset_Bar.TabStop = False
        '
        'Asset_Ball
        '
        Me.Asset_Ball.Image = Global.MemeGame.My.Resources.Resources.Asset_ball
        Me.Asset_Ball.Location = New System.Drawing.Point(284, 103)
        Me.Asset_Ball.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Asset_Ball.Name = "Asset_Ball"
        Me.Asset_Ball.Size = New System.Drawing.Size(85, 71)
        Me.Asset_Ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Asset_Ball.TabIndex = 2
        Me.Asset_Ball.TabStop = False
        '
        'Point_counter
        '
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblScore.Location = New System.Drawing.Point(7, 37)
        Me.lblScore.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(133, 32)
        Me.lblScore.TabIndex = 3
        Me.lblScore.Text = "Your Score:"
        '
        'lblLives
        '
        Me.lblLives.AutoSize = True
        Me.lblLives.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLives.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblLives.Location = New System.Drawing.Point(7, 68)
        Me.lblLives.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLives.Name = "lblLives"
        Me.lblLives.Size = New System.Drawing.Size(126, 32)
        Me.lblLives.TabIndex = 4
        Me.lblLives.Text = "Your Lives:"
        '
        'LifeChecker
        '
        '
        'OnePlayer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(932, 705)
        Me.Controls.Add(Me.lblLives)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.Asset_Ball)
        Me.Controls.Add(Me.Asset_Bar)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "OnePlayer"
        Me.Text = "OnePlayer"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.Asset_Bar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Asset_Ball, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BackToMainMenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Ball_Timer As Timer
    Friend WithEvents Asset_Bar As PictureBox
    Friend WithEvents Asset_Ball As PictureBox
    Friend WithEvents Point_counter As Timer
    Friend WithEvents HighScoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewHighscoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveYourScoreToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblScore As Label
    Friend WithEvents ResumeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblLives As Label
    Friend WithEvents LifeChecker As Timer
End Class
