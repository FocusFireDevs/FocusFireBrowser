<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.WebView1 = New Microsoft.Web.WebView2.WinForms.WebView2()
        Me.WebView2 = New Microsoft.Web.WebView2.WinForms.WebView2()
        Me.WebView3 = New Microsoft.Web.WebView2.WinForms.WebView2()
        Me.WebView4 = New Microsoft.Web.WebView2.WinForms.WebView2()
        Me.Back = New Guna.UI2.WinForms.Guna2Button()
        Me.Forward = New Guna.UI2.WinForms.Guna2Button()
        Me.Reload = New Guna.UI2.WinForms.Guna2Button()
        Me.Home = New Guna.UI2.WinForms.Guna2Button()
        Me.Search = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Tab4 = New Guna.UI2.WinForms.Guna2Button()
        Me.Tab3 = New Guna.UI2.WinForms.Guna2Button()
        Me.Tab2 = New Guna.UI2.WinForms.Guna2Button()
        Me.Tab1 = New Guna.UI2.WinForms.Guna2Button()
        Me.MS = New Guna.UI2.WinForms.Guna2Button()
        Me.FS = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.WebView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WebView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WebView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WebView4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'WebView1
        '
        Me.WebView1.AllowExternalDrop = True
        Me.WebView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WebView1.BackColor = System.Drawing.SystemColors.Control
        Me.WebView1.CreationProperties = Nothing
        Me.WebView1.DefaultBackgroundColor = System.Drawing.Color.White
        Me.WebView1.Location = New System.Drawing.Point(0, 91)
        Me.WebView1.Margin = New System.Windows.Forms.Padding(0)
        Me.WebView1.Name = "WebView1"
        Me.WebView1.Size = New System.Drawing.Size(800, 512)
        Me.WebView1.Source = New System.Uri("https://ghosterysearch.com/", System.UriKind.Absolute)
        Me.WebView1.TabIndex = 9
        Me.WebView1.ZoomFactor = 1.0R
        '
        'WebView2
        '
        Me.WebView2.AllowExternalDrop = True
        Me.WebView2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WebView2.BackColor = System.Drawing.SystemColors.Control
        Me.WebView2.CreationProperties = Nothing
        Me.WebView2.DefaultBackgroundColor = System.Drawing.Color.White
        Me.WebView2.Location = New System.Drawing.Point(0, 91)
        Me.WebView2.Margin = New System.Windows.Forms.Padding(0)
        Me.WebView2.Name = "WebView2"
        Me.WebView2.Size = New System.Drawing.Size(800, 512)
        Me.WebView2.Source = New System.Uri("https://ghosterysearch.com/", System.UriKind.Absolute)
        Me.WebView2.TabIndex = 13
        Me.WebView2.ZoomFactor = 1.0R
        '
        'WebView3
        '
        Me.WebView3.AllowExternalDrop = True
        Me.WebView3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WebView3.BackColor = System.Drawing.SystemColors.Control
        Me.WebView3.CreationProperties = Nothing
        Me.WebView3.DefaultBackgroundColor = System.Drawing.Color.White
        Me.WebView3.Location = New System.Drawing.Point(0, 91)
        Me.WebView3.Margin = New System.Windows.Forms.Padding(0)
        Me.WebView3.Name = "WebView3"
        Me.WebView3.Size = New System.Drawing.Size(800, 512)
        Me.WebView3.Source = New System.Uri("https://ghosterysearch.com/", System.UriKind.Absolute)
        Me.WebView3.TabIndex = 14
        Me.WebView3.ZoomFactor = 1.0R
        '
        'WebView4
        '
        Me.WebView4.AllowExternalDrop = True
        Me.WebView4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WebView4.BackColor = System.Drawing.SystemColors.Control
        Me.WebView4.CreationProperties = Nothing
        Me.WebView4.DefaultBackgroundColor = System.Drawing.Color.White
        Me.WebView4.Location = New System.Drawing.Point(0, 91)
        Me.WebView4.Margin = New System.Windows.Forms.Padding(0)
        Me.WebView4.Name = "WebView4"
        Me.WebView4.Size = New System.Drawing.Size(800, 512)
        Me.WebView4.Source = New System.Uri("https://ghosterysearch.com/", System.UriKind.Absolute)
        Me.WebView4.TabIndex = 15
        Me.WebView4.ZoomFactor = 1.0R
        '
        'Back
        '
        Me.Back.AutoRoundedCorners = True
        Me.Back.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Back.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Back.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Back.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Back.FillColor = System.Drawing.SystemColors.ControlLight
        Me.Back.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Back.ForeColor = System.Drawing.Color.White
        Me.Back.Image = CType(resources.GetObject("Back.Image"), System.Drawing.Image)
        Me.Back.ImageSize = New System.Drawing.Size(16, 16)
        Me.Back.Location = New System.Drawing.Point(13, 46)
        Me.Back.Margin = New System.Windows.Forms.Padding(4)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(32, 32)
        Me.Back.TabIndex = 19
        '
        'Forward
        '
        Me.Forward.AutoRoundedCorners = True
        Me.Forward.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Forward.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Forward.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Forward.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Forward.FillColor = System.Drawing.SystemColors.ControlLight
        Me.Forward.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Forward.ForeColor = System.Drawing.Color.White
        Me.Forward.Image = CType(resources.GetObject("Forward.Image"), System.Drawing.Image)
        Me.Forward.ImageSize = New System.Drawing.Size(16, 16)
        Me.Forward.Location = New System.Drawing.Point(53, 46)
        Me.Forward.Margin = New System.Windows.Forms.Padding(4)
        Me.Forward.Name = "Forward"
        Me.Forward.Size = New System.Drawing.Size(32, 32)
        Me.Forward.TabIndex = 20
        '
        'Reload
        '
        Me.Reload.AutoRoundedCorners = True
        Me.Reload.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Reload.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Reload.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Reload.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Reload.FillColor = System.Drawing.SystemColors.ControlLight
        Me.Reload.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Reload.ForeColor = System.Drawing.Color.White
        Me.Reload.Image = CType(resources.GetObject("Reload.Image"), System.Drawing.Image)
        Me.Reload.ImageSize = New System.Drawing.Size(16, 16)
        Me.Reload.Location = New System.Drawing.Point(93, 46)
        Me.Reload.Margin = New System.Windows.Forms.Padding(4)
        Me.Reload.Name = "Reload"
        Me.Reload.Size = New System.Drawing.Size(32, 32)
        Me.Reload.TabIndex = 21
        '
        'Home
        '
        Me.Home.AutoRoundedCorners = True
        Me.Home.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Home.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Home.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Home.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Home.FillColor = System.Drawing.SystemColors.ControlLight
        Me.Home.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Home.ForeColor = System.Drawing.Color.White
        Me.Home.Image = CType(resources.GetObject("Home.Image"), System.Drawing.Image)
        Me.Home.ImageSize = New System.Drawing.Size(16, 16)
        Me.Home.Location = New System.Drawing.Point(133, 46)
        Me.Home.Margin = New System.Windows.Forms.Padding(4)
        Me.Home.Name = "Home"
        Me.Home.Size = New System.Drawing.Size(32, 32)
        Me.Home.TabIndex = 22
        '
        'Search
        '
        Me.Search.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Search.AutoRoundedCorners = True
        Me.Search.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Search.BorderColor = System.Drawing.SystemColors.ControlLight
        Me.Search.BorderThickness = 0
        Me.Search.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Search.DefaultText = ""
        Me.Search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Search.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Search.FillColor = System.Drawing.SystemColors.ControlLight
        Me.Search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Search.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Search.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Search.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Search.IconLeft = CType(resources.GetObject("Search.IconLeft"), System.Drawing.Image)
        Me.Search.IconLeftSize = New System.Drawing.Size(16, 16)
        Me.Search.Location = New System.Drawing.Point(173, 46)
        Me.Search.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Search.Name = "Search"
        Me.Search.PlaceholderForeColor = System.Drawing.SystemColors.ControlText
        Me.Search.PlaceholderText = ""
        Me.Search.SelectedText = ""
        Me.Search.Size = New System.Drawing.Size(534, 32)
        Me.Search.TabIndex = 28
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel1.Controls.Add(Me.Tab4)
        Me.Guna2Panel1.Controls.Add(Me.Tab3)
        Me.Guna2Panel1.Controls.Add(Me.Tab2)
        Me.Guna2Panel1.Controls.Add(Me.Tab1)
        Me.Guna2Panel1.FillColor = System.Drawing.SystemColors.ControlLightLight
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(800, 30)
        Me.Guna2Panel1.TabIndex = 29
        '
        'Tab4
        '
        Me.Tab4.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Tab4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Tab4.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Tab4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Tab4.FillColor = System.Drawing.SystemColors.ControlLightLight
        Me.Tab4.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tab4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Tab4.Location = New System.Drawing.Point(600, 2)
        Me.Tab4.Margin = New System.Windows.Forms.Padding(0)
        Me.Tab4.Name = "Tab4"
        Me.Tab4.Size = New System.Drawing.Size(200, 26)
        Me.Tab4.TabIndex = 31
        Me.Tab4.Text = "Tab 4"
        '
        'Tab3
        '
        Me.Tab3.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Tab3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Tab3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Tab3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Tab3.FillColor = System.Drawing.SystemColors.ControlLightLight
        Me.Tab3.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tab3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Tab3.Location = New System.Drawing.Point(400, 2)
        Me.Tab3.Margin = New System.Windows.Forms.Padding(0)
        Me.Tab3.Name = "Tab3"
        Me.Tab3.Size = New System.Drawing.Size(200, 26)
        Me.Tab3.TabIndex = 30
        Me.Tab3.Text = "Tab 3"
        '
        'Tab2
        '
        Me.Tab2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Tab2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Tab2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Tab2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Tab2.FillColor = System.Drawing.SystemColors.ControlLightLight
        Me.Tab2.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tab2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Tab2.Location = New System.Drawing.Point(200, 2)
        Me.Tab2.Margin = New System.Windows.Forms.Padding(0)
        Me.Tab2.Name = "Tab2"
        Me.Tab2.Size = New System.Drawing.Size(200, 26)
        Me.Tab2.TabIndex = 29
        Me.Tab2.Text = "Tab 2"
        '
        'Tab1
        '
        Me.Tab1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Tab1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Tab1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Tab1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Tab1.FillColor = System.Drawing.SystemColors.ControlLightLight
        Me.Tab1.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tab1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Tab1.Location = New System.Drawing.Point(0, 2)
        Me.Tab1.Margin = New System.Windows.Forms.Padding(0)
        Me.Tab1.Name = "Tab1"
        Me.Tab1.Size = New System.Drawing.Size(200, 26)
        Me.Tab1.TabIndex = 28
        Me.Tab1.Text = "Tab 1"
        '
        'MS
        '
        Me.MS.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MS.AutoRoundedCorners = True
        Me.MS.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.MS.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.MS.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.MS.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.MS.FillColor = System.Drawing.SystemColors.ControlLight
        Me.MS.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MS.ForeColor = System.Drawing.Color.White
        Me.MS.Image = CType(resources.GetObject("MS.Image"), System.Drawing.Image)
        Me.MS.ImageSize = New System.Drawing.Size(16, 16)
        Me.MS.Location = New System.Drawing.Point(715, 46)
        Me.MS.Margin = New System.Windows.Forms.Padding(4)
        Me.MS.Name = "MS"
        Me.MS.Size = New System.Drawing.Size(32, 32)
        Me.MS.TabIndex = 31
        '
        'FS
        '
        Me.FS.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FS.AutoRoundedCorners = True
        Me.FS.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.FS.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.FS.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.FS.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.FS.FillColor = System.Drawing.SystemColors.ControlLight
        Me.FS.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FS.ForeColor = System.Drawing.Color.White
        Me.FS.Image = CType(resources.GetObject("FS.Image"), System.Drawing.Image)
        Me.FS.ImageSize = New System.Drawing.Size(16, 16)
        Me.FS.Location = New System.Drawing.Point(755, 46)
        Me.FS.Margin = New System.Windows.Forms.Padding(4)
        Me.FS.Name = "FS"
        Me.FS.Size = New System.Drawing.Size(32, 32)
        Me.FS.TabIndex = 30
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.MS)
        Me.Controls.Add(Me.FS)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Search)
        Me.Controls.Add(Me.Home)
        Me.Controls.Add(Me.Reload)
        Me.Controls.Add(Me.Forward)
        Me.Controls.Add(Me.Back)
        Me.Controls.Add(Me.WebView4)
        Me.Controls.Add(Me.WebView3)
        Me.Controls.Add(Me.WebView2)
        Me.Controls.Add(Me.WebView1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(3840, 2160)
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FocusFire"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.WebView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WebView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WebView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WebView4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents WebView1 As Microsoft.Web.WebView2.WinForms.WebView2
    Friend WithEvents WebView2 As Microsoft.Web.WebView2.WinForms.WebView2
    Friend WithEvents WebView3 As Microsoft.Web.WebView2.WinForms.WebView2
    Friend WithEvents WebView4 As Microsoft.Web.WebView2.WinForms.WebView2
    Friend WithEvents Back As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Forward As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Reload As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Home As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Search As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Tab4 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Tab3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Tab2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Tab1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents MS As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents FS As Guna.UI2.WinForms.Guna2Button
End Class
