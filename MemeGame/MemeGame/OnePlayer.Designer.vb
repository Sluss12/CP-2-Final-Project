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
        Me.BackToMainMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Ball_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Asset_Bar = New System.Windows.Forms.PictureBox()
        Me.Asset_Ball = New System.Windows.Forms.PictureBox()
        Me.Point_counter = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        CType(Me.Asset_Bar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Asset_Ball, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(569, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackToMainMenuToolStripMenuItem, Me.QuitToolStripMenuItem})
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(74, 24)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'BackToMainMenuToolStripMenuItem
        '
        Me.BackToMainMenuToolStripMenuItem.Name = "BackToMainMenuToolStripMenuItem"
        Me.BackToMainMenuToolStripMenuItem.Size = New System.Drawing.Size(211, 26)
        Me.BackToMainMenuToolStripMenuItem.Text = "Back to main menu"
        '
        'QuitToolStripMenuItem
        '
        Me.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem"
        Me.QuitToolStripMenuItem.Size = New System.Drawing.Size(211, 26)
        Me.QuitToolStripMenuItem.Text = "Quit"
        '
        'Ball_Timer
        '
        Me.Ball_Timer.Interval = 50
        '
        'Asset_Bar
        '
        Me.Asset_Bar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Asset_Bar.Location = New System.Drawing.Point(231, 421)
        Me.Asset_Bar.Name = "Asset_Bar"
        Me.Asset_Bar.Size = New System.Drawing.Size(121, 30)
        Me.Asset_Bar.TabIndex = 1
        Me.Asset_Bar.TabStop = False
        '
        'Asset_Ball
        '
        Me.Asset_Ball.Image = Global.MemeGame.My.Resources.Resources.Asset_ball
        Me.Asset_Ball.Location = New System.Drawing.Point(219, 127)
        Me.Asset_Ball.Name = "Asset_Ball"
        Me.Asset_Ball.Size = New System.Drawing.Size(75, 60)
        Me.Asset_Ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Asset_Ball.TabIndex = 2
        Me.Asset_Ball.TabStop = False
        '
        'Point_counter
        '
        '
        'OnePlayer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(569, 463)
        Me.Controls.Add(Me.Asset_Ball)
        Me.Controls.Add(Me.Asset_Bar)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
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
End Class
