Namespace DXSample
    Partial Public Class ColorSelectorControl
        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Component Designer generated code"

        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.xtraTabControl = New DevExpress.XtraTab.XtraTabControl()
            Me.tabCustom = New DevExpress.XtraTab.XtraTabPage()
            Me.colorPickControl = New DevExpress.XtraEditors.InnerColorPickControl()
            Me.tabSystem = New DevExpress.XtraTab.XtraTabPage()
            Me.systemColorListControl = New DevExpress.XtraEditors.InnerColorListControl()
            Me.tabWeb = New DevExpress.XtraTab.XtraTabPage()
            Me.webColorListControl = New DevExpress.XtraEditors.InnerColorListControl()
            DirectCast(Me.xtraTabControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.xtraTabControl.SuspendLayout()
            Me.tabCustom.SuspendLayout()
            Me.tabSystem.SuspendLayout()
            Me.tabWeb.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' xtraTabControl1
            ' 
            Me.xtraTabControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xtraTabControl.Location = New System.Drawing.Point(0, 0)
            Me.xtraTabControl.Name = "xtraTabControl1"
            Me.xtraTabControl.SelectedTabPage = Me.tabCustom
            Me.xtraTabControl.Size = New System.Drawing.Size(273, 275)
            Me.xtraTabControl.TabIndex = 0
            Me.xtraTabControl.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() { Me.tabCustom, Me.tabSystem, Me.tabWeb})
            ' 
            ' tabCustom
            ' 
            Me.tabCustom.Controls.Add(Me.colorPickControl)
            Me.tabCustom.Name = "tabCustom"
            Me.tabCustom.Size = New System.Drawing.Size(267, 247)
            Me.tabCustom.Text = "Custom"
            ' 
            ' colorPickControl
            ' 
            Me.colorPickControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.colorPickControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.colorPickControl.Location = New System.Drawing.Point(0, 0)
            Me.colorPickControl.MaxRowItemCount = 10
            Me.colorPickControl.Name = "colorPickControl"
            Me.colorPickControl.Selectable = True
            Me.colorPickControl.Size = New System.Drawing.Size(267, 247)
            Me.colorPickControl.StandardColors.Add(New DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb((CInt((CByte(192)))), (CInt((CByte(0)))), (CInt((CByte(0)))))))
            Me.colorPickControl.StandardColors.Add(New DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb((CInt((CByte(240)))), (CInt((CByte(0)))), (CInt((CByte(0)))))))
            Me.colorPickControl.StandardColors.Add(New DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(192)))), (CInt((CByte(0)))))))
            Me.colorPickControl.StandardColors.Add(New DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(0)))))))
            Me.colorPickControl.StandardColors.Add(New DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb((CInt((CByte(146)))), (CInt((CByte(208)))), (CInt((CByte(80)))))))
            Me.colorPickControl.StandardColors.Add(New DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(176)))), (CInt((CByte(80)))))))
            Me.colorPickControl.StandardColors.Add(New DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(176)))), (CInt((CByte(240)))))))
            Me.colorPickControl.StandardColors.Add(New DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(112)))), (CInt((CByte(192)))))))
            Me.colorPickControl.StandardColors.Add(New DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(32)))), (CInt((CByte(96)))))))
            Me.colorPickControl.StandardColors.Add(New DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb((CInt((CByte(112)))), (CInt((CByte(48)))), (CInt((CByte(160)))))))
            Me.colorPickControl.TabIndex = 0
            Me.colorPickControl.ThemeColors.Add(New DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))))
            Me.colorPickControl.ThemeColors.Add(New DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(0)))), (CInt((CByte(0)))))))
            Me.colorPickControl.ThemeColors.Add(New DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb((CInt((CByte(238)))), (CInt((CByte(236)))), (CInt((CByte(225)))))))
            Me.colorPickControl.ThemeColors.Add(New DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb((CInt((CByte(31)))), (CInt((CByte(73)))), (CInt((CByte(125)))))))
            Me.colorPickControl.ThemeColors.Add(New DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb((CInt((CByte(79)))), (CInt((CByte(129)))), (CInt((CByte(189)))))))
            Me.colorPickControl.ThemeColors.Add(New DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb((CInt((CByte(192)))), (CInt((CByte(80)))), (CInt((CByte(77)))))))
            Me.colorPickControl.ThemeColors.Add(New DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb((CInt((CByte(155)))), (CInt((CByte(187)))), (CInt((CByte(89)))))))
            Me.colorPickControl.ThemeColors.Add(New DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb((CInt((CByte(128)))), (CInt((CByte(100)))), (CInt((CByte(162)))))))
            Me.colorPickControl.ThemeColors.Add(New DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb((CInt((CByte(75)))), (CInt((CByte(172)))), (CInt((CByte(198)))))))
            Me.colorPickControl.ThemeColors.Add(New DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb((CInt((CByte(247)))), (CInt((CByte(150)))), (CInt((CByte(70)))))))
            Me.colorPickControl.ThemeColors.Add(New DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb((CInt((CByte(242)))), (CInt((CByte(242)))), (CInt((CByte(242)))))))
            Me.colorPickControl.ThemeColors.Add(New DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb((CInt((CByte(127)))), (CInt((CByte(127)))), (CInt((CByte(127)))))))
            Me.colorPickControl.ThemeColors.Add(New DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb((CInt((CByte(221)))), (CInt((CByte(217)))), (CInt((CByte(195)))))))
            Me.colorPickControl.ThemeColors.Add(New DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb((CInt((CByte(198)))), (CInt((CByte(217)))), (CInt((CByte(240)))))))
            Me.colorPickControl.ThemeColors.Add(New DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb((CInt((CByte(219)))), (CInt((CByte(229)))), (CInt((CByte(241)))))))
            Me.colorPickControl.ThemeColors.Add(New DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb((CInt((CByte(242)))), (CInt((CByte(220)))), (CInt((CByte(219)))))))
            Me.colorPickControl.ThemeColors.Add(New DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb((CInt((CByte(235)))), (CInt((CByte(241)))), (CInt((CByte(221)))))))
            Me.colorPickControl.ThemeColors.Add(New DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb((CInt((CByte(229)))), (CInt((CByte(224)))), (CInt((CByte(236)))))))
            Me.colorPickControl.ThemeColors.Add(New DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb((CInt((CByte(219)))), (CInt((CByte(238)))), (CInt((CByte(227)))))))
            Me.colorPickControl.ThemeColors.Add(New DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb((CInt((CByte(253)))), (CInt((CByte(234)))), (CInt((CByte(218)))))))
            Me.colorPickControl.ThemeColors.Add(New DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb((CInt((CByte(216)))), (CInt((CByte(216)))), (CInt((CByte(216)))))))
            Me.colorPickControl.ThemeColors.Add(New DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb((CInt((CByte(89)))), (CInt((CByte(89)))), (CInt((CByte(89)))))))
            Me.colorPickControl.ThemeColors.Add(New DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb((CInt((CByte(196)))), (CInt((CByte(189)))), (CInt((CByte(151)))))))
            Me.colorPickControl.ThemeColors.Add(New DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb((CInt((CByte(141)))), (CInt((CByte(179)))), (CInt((CByte(226)))))))
            Me.colorPickControl.ThemeColors.Add(New DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(204)))), (CInt((CByte(228)))))))
            Me.colorPickControl.ThemeColors.Add(New DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb((CInt((CByte(229)))), (CInt((CByte(185)))), (CInt((CByte(183)))))))
            Me.colorPickControl.ThemeColors.Add(New DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb((CInt((CByte(215)))), (CInt((CByte(227)))), (CInt((CByte(188)))))))
            Me.colorPickControl.ThemeColors.Add(New DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb((CInt((CByte(204)))), (CInt((CByte(193)))), (CInt((CByte(217)))))))
            Me.colorPickControl.ThemeColors.Add(New DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb((CInt((CByte(183)))), (CInt((CByte(221)))), (CInt((CByte(232)))))))
            Me.colorPickControl.ThemeColors.Add(New DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb((CInt((CByte(251)))), (CInt((CByte(213)))), (CInt((CByte(181)))))))
            Me.colorPickControl.ThemeColors.Add(New DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb((CInt((CByte(191)))), (CInt((CByte(191)))), (CInt((CByte(191)))))))
            Me.colorPickControl.ThemeColors.Add(New DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb((CInt((CByte(63)))), (CInt((CByte(63)))), (CInt((CByte(63)))))))
            Me.colorPickControl.ThemeColors.Add(New DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb((CInt((CByte(147)))), (CInt((CByte(137)))), (CInt((CByte(83)))))))
            Me.colorPickControl.ThemeColors.Add(New DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb((CInt((CByte(84)))), (CInt((CByte(141)))), (CInt((CByte(212)))))))
            Me.colorPickControl.ThemeColors.Add(New DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb((CInt((CByte(149)))), (CInt((CByte(179)))), (CInt((CByte(215)))))))
            Me.colorPickControl.ThemeColors.Add(New DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb((CInt((CByte(217)))), (CInt((CByte(150)))), (CInt((CByte(148)))))))
            Me.colorPickControl.ThemeColors.Add(New DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb((CInt((CByte(195)))), (CInt((CByte(214)))), (CInt((CByte(155)))))))
            Me.colorPickControl.ThemeColors.Add(New DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb((CInt((CByte(178)))), (CInt((CByte(162)))), (CInt((CByte(199)))))))
            Me.colorPickControl.ThemeColors.Add(New DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb((CInt((CByte(146)))), (CInt((CByte(205)))), (CInt((CByte(220)))))))
            Me.colorPickControl.ThemeColors.Add(New DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb((CInt((CByte(250)))), (CInt((CByte(192)))), (CInt((CByte(143)))))))
            Me.colorPickControl.ThemeColors.Add(New DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb((CInt((CByte(165)))), (CInt((CByte(165)))), (CInt((CByte(165)))))))
            Me.colorPickControl.ThemeColors.Add(New DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb((CInt((CByte(38)))), (CInt((CByte(38)))), (CInt((CByte(38)))))))
            Me.colorPickControl.ThemeColors.Add(New DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb((CInt((CByte(73)))), (CInt((CByte(68)))), (CInt((CByte(41)))))))
            Me.colorPickControl.ThemeColors.Add(New DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb((CInt((CByte(23)))), (CInt((CByte(54)))), (CInt((CByte(93)))))))
            Me.colorPickControl.ThemeColors.Add(New DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb((CInt((CByte(54)))), (CInt((CByte(96)))), (CInt((CByte(146)))))))
            Me.colorPickControl.ThemeColors.Add(New DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb((CInt((CByte(149)))), (CInt((CByte(55)))), (CInt((CByte(52)))))))
            Me.colorPickControl.ThemeColors.Add(New DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb((CInt((CByte(118)))), (CInt((CByte(146)))), (CInt((CByte(60)))))))
            Me.colorPickControl.ThemeColors.Add(New DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb((CInt((CByte(95)))), (CInt((CByte(73)))), (CInt((CByte(122)))))))
            Me.colorPickControl.ThemeColors.Add(New DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb((CInt((CByte(49)))), (CInt((CByte(133)))), (CInt((CByte(155)))))))
            Me.colorPickControl.ThemeColors.Add(New DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb((CInt((CByte(227)))), (CInt((CByte(108)))), (CInt((CByte(9)))))))
            Me.colorPickControl.ThemeColors.Add(New DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb((CInt((CByte(127)))), (CInt((CByte(127)))), (CInt((CByte(127)))))))
            Me.colorPickControl.ThemeColors.Add(New DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb((CInt((CByte(12)))), (CInt((CByte(12)))), (CInt((CByte(12)))))))
            Me.colorPickControl.ThemeColors.Add(New DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb((CInt((CByte(29)))), (CInt((CByte(27)))), (CInt((CByte(16)))))))
            Me.colorPickControl.ThemeColors.Add(New DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb((CInt((CByte(15)))), (CInt((CByte(36)))), (CInt((CByte(62)))))))
            Me.colorPickControl.ThemeColors.Add(New DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb((CInt((CByte(36)))), (CInt((CByte(64)))), (CInt((CByte(97)))))))
            Me.colorPickControl.ThemeColors.Add(New DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb((CInt((CByte(99)))), (CInt((CByte(36)))), (CInt((CByte(35)))))))
            Me.colorPickControl.ThemeColors.Add(New DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb((CInt((CByte(79)))), (CInt((CByte(97)))), (CInt((CByte(40)))))))
            Me.colorPickControl.ThemeColors.Add(New DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb((CInt((CByte(63)))), (CInt((CByte(49)))), (CInt((CByte(81)))))))
            Me.colorPickControl.ThemeColors.Add(New DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb((CInt((CByte(32)))), (CInt((CByte(88)))), (CInt((CByte(103)))))))
            Me.colorPickControl.ThemeColors.Add(New DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb((CInt((CByte(151)))), (CInt((CByte(72)))), (CInt((CByte(6)))))))
            Me.colorPickControl.UserMouse = True
            ' 
            ' tabSystem
            ' 
            Me.tabSystem.Controls.Add(Me.systemColorListControl)
            Me.tabSystem.Name = "tabSystem"
            Me.tabSystem.Size = New System.Drawing.Size(267, 247)
            Me.tabSystem.Text = "System"
            ' 
            ' systemColorListControl
            ' 
            Me.systemColorListControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.systemColorListControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.systemColorListControl.Location = New System.Drawing.Point(0, 0)
            Me.systemColorListControl.Name = "systemColorListControl"
            Me.systemColorListControl.Selectable = True
            Me.systemColorListControl.Size = New System.Drawing.Size(267, 247)
            Me.systemColorListControl.TabIndex = 0
            Me.systemColorListControl.Text = "button2"
            Me.systemColorListControl.UserMouse = True
            ' 
            ' tabWeb
            ' 
            Me.tabWeb.Controls.Add(Me.webColorListControl)
            Me.tabWeb.Name = "tabWeb"
            Me.tabWeb.Size = New System.Drawing.Size(267, 247)
            Me.tabWeb.Text = "Web"
            ' 
            ' webColorListControl
            ' 
            Me.webColorListControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.webColorListControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.webColorListControl.Location = New System.Drawing.Point(0, 0)
            Me.webColorListControl.Name = "webColorListControl"
            Me.webColorListControl.Selectable = True
            Me.webColorListControl.Size = New System.Drawing.Size(267, 247)
            Me.webColorListControl.TabIndex = 0
            Me.webColorListControl.Text = "button3"
            Me.webColorListControl.UserMouse = True
            ' 
            ' ColorSelectorControl
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.xtraTabControl)
            Me.Name = "ColorSelectorControl"
            Me.Size = New System.Drawing.Size(273, 275)
            DirectCast(Me.xtraTabControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.xtraTabControl.ResumeLayout(False)
            Me.tabCustom.ResumeLayout(False)
            Me.tabSystem.ResumeLayout(False)
            Me.tabWeb.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private xtraTabControl As DevExpress.XtraTab.XtraTabControl
        Private tabCustom As DevExpress.XtraTab.XtraTabPage
        Private tabSystem As DevExpress.XtraTab.XtraTabPage
        Private tabWeb As DevExpress.XtraTab.XtraTabPage
        Private colorPickControl As DevExpress.XtraEditors.InnerColorPickControl
        Private systemColorListControl As DevExpress.XtraEditors.InnerColorListControl
        Private webColorListControl As DevExpress.XtraEditors.InnerColorListControl
    End Class
End Namespace
