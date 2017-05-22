<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TwoPlayer
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
        Me.BackToMainToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HighScoreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveHighscoreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewHighscoreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Ball_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Point_counter = New System.Windows.Forms.Timer(Me.components)
        Me.Timersend = New System.Windows.Forms.Timer(Me.components)
        Me.Asset_Ball = New System.Windows.Forms.PictureBox()
        Me.Asset_Bar = New System.Windows.Forms.PictureBox()
        Me.Asset_Bar2 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.Asset_Ball, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Asset_Bar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Asset_Bar2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingsToolStripMenuItem, Me.HighScoreToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(673, 24)
        Me.MenuStrip1.TabIndex = 0
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
        Me.BackToMainToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BackToMainToolStripMenuItem.Text = "Back to Main"
        '
        'QuitToolStripMenuItem
        '
        Me.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem"
        Me.QuitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
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
        'Ball_Timer
        '
        '
        'Point_counter
        '
        '
        'Timersend
        '
        '
        'Asset_Ball
        '
        Me.Asset_Ball.Image = Global.MemeGame.My.Resources.Resources.Asset_ball
        Me.Asset_Ball.Location = New System.Drawing.Point(318, 234)
        Me.Asset_Ball.Margin = New System.Windows.Forms.Padding(2)
        Me.Asset_Ball.Name = "Asset_Ball"
        Me.Asset_Ball.Size = New System.Drawing.Size(64, 67)
        Me.Asset_Ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Asset_Ball.TabIndex = 3
        Me.Asset_Ball.TabStop = False
        '
        'Asset_Bar
        '
        Me.Asset_Bar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Asset_Bar.Location = New System.Drawing.Point(298, 510)
        Me.Asset_Bar.Margin = New System.Windows.Forms.Padding(2)
        Me.Asset_Bar.Name = "Asset_Bar"
        Me.Asset_Bar.Size = New System.Drawing.Size(119, 24)
        Me.Asset_Bar.TabIndex = 4
        Me.Asset_Bar.TabStop = False
        '
        'Asset_Bar2
        '
        Me.Asset_Bar2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Asset_Bar2.Location = New System.Drawing.Point(298, 36)
        Me.Asset_Bar2.Margin = New System.Windows.Forms.Padding(2)
        Me.Asset_Bar2.Name = "Asset_Bar2"
        Me.Asset_Bar2.Size = New System.Drawing.Size(119, 24)
        Me.Asset_Bar2.TabIndex = 5
        Me.Asset_Bar2.TabStop = False
        '
        'TwoPlayer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(673, 558)
        Me.Controls.Add(Me.Asset_Bar2)
        Me.Controls.Add(Me.Asset_Bar)
        Me.Controls.Add(Me.Asset_Ball)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "TwoPlayer"
        Me.Text = "TwoPlayer"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.Asset_Ball, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Asset_Bar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Asset_Bar2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BackToMainToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HighScoreToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveHighscoreToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewHighscoreToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Ball_Timer As Timer
    Friend WithEvents Point_counter As Timer
    Friend WithEvents Timersend As Timer
    Friend WithEvents Asset_Ball As PictureBox
    Friend WithEvents Asset_Bar As PictureBox
    Friend WithEvents Asset_Bar2 As PictureBox
End Class
