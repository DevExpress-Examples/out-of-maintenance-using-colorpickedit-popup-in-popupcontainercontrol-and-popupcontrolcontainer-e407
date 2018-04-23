namespace DXSample {
    partial class ColorSelectorControl {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.xtraTabControl = new DevExpress.XtraTab.XtraTabControl();
            this.tabCustom = new DevExpress.XtraTab.XtraTabPage();
            this.colorPickControl = new DevExpress.XtraEditors.InnerColorPickControl();
            this.tabSystem = new DevExpress.XtraTab.XtraTabPage();
            this.systemColorListControl = new DevExpress.XtraEditors.InnerColorListControl();
            this.tabWeb = new DevExpress.XtraTab.XtraTabPage();
            this.webColorListControl = new DevExpress.XtraEditors.InnerColorListControl();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl)).BeginInit();
            this.xtraTabControl.SuspendLayout();
            this.tabCustom.SuspendLayout();
            this.tabSystem.SuspendLayout();
            this.tabWeb.SuspendLayout();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl.Name = "xtraTabControl1";
            this.xtraTabControl.SelectedTabPage = this.tabCustom;
            this.xtraTabControl.Size = new System.Drawing.Size(273, 275);
            this.xtraTabControl.TabIndex = 0;
            this.xtraTabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabCustom,
            this.tabSystem,
            this.tabWeb});
            // 
            // tabCustom
            // 
            this.tabCustom.Controls.Add(this.colorPickControl);
            this.tabCustom.Name = "tabCustom";
            this.tabCustom.Size = new System.Drawing.Size(267, 247);
            this.tabCustom.Text = "Custom";
            // 
            // colorPickControl
            // 
            this.colorPickControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.colorPickControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colorPickControl.Location = new System.Drawing.Point(0, 0);
            this.colorPickControl.MaxRowItemCount = 10;
            this.colorPickControl.Name = "colorPickControl";
            this.colorPickControl.Selectable = true;
            this.colorPickControl.Size = new System.Drawing.Size(267, 247);
            this.colorPickControl.StandardColors.Add(new DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))))));
            this.colorPickControl.StandardColors.Add(new DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))))));
            this.colorPickControl.StandardColors.Add(new DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))))));
            this.colorPickControl.StandardColors.Add(new DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))))));
            this.colorPickControl.StandardColors.Add(new DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(208)))), ((int)(((byte)(80)))))));
            this.colorPickControl.StandardColors.Add(new DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))))));
            this.colorPickControl.StandardColors.Add(new DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(240)))))));
            this.colorPickControl.StandardColors.Add(new DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(192)))))));
            this.colorPickControl.StandardColors.Add(new DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(96)))))));
            this.colorPickControl.StandardColors.Add(new DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(48)))), ((int)(((byte)(160)))))));
            this.colorPickControl.TabIndex = 0;
            this.colorPickControl.ThemeColors.Add(new DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))))));
            this.colorPickControl.ThemeColors.Add(new DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))))));
            this.colorPickControl.ThemeColors.Add(new DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(236)))), ((int)(((byte)(225)))))));
            this.colorPickControl.ThemeColors.Add(new DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(73)))), ((int)(((byte)(125)))))));
            this.colorPickControl.ThemeColors.Add(new DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))))));
            this.colorPickControl.ThemeColors.Add(new DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(80)))), ((int)(((byte)(77)))))));
            this.colorPickControl.ThemeColors.Add(new DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(187)))), ((int)(((byte)(89)))))));
            this.colorPickControl.ThemeColors.Add(new DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(100)))), ((int)(((byte)(162)))))));
            this.colorPickControl.ThemeColors.Add(new DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(172)))), ((int)(((byte)(198)))))));
            this.colorPickControl.ThemeColors.Add(new DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(150)))), ((int)(((byte)(70)))))));
            this.colorPickControl.ThemeColors.Add(new DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))))));
            this.colorPickControl.ThemeColors.Add(new DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))))));
            this.colorPickControl.ThemeColors.Add(new DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(217)))), ((int)(((byte)(195)))))));
            this.colorPickControl.ThemeColors.Add(new DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(217)))), ((int)(((byte)(240)))))));
            this.colorPickControl.ThemeColors.Add(new DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(229)))), ((int)(((byte)(241)))))));
            this.colorPickControl.ThemeColors.Add(new DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(220)))), ((int)(((byte)(219)))))));
            this.colorPickControl.ThemeColors.Add(new DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(241)))), ((int)(((byte)(221)))))));
            this.colorPickControl.ThemeColors.Add(new DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(224)))), ((int)(((byte)(236)))))));
            this.colorPickControl.ThemeColors.Add(new DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(238)))), ((int)(((byte)(227)))))));
            this.colorPickControl.ThemeColors.Add(new DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(234)))), ((int)(((byte)(218)))))));
            this.colorPickControl.ThemeColors.Add(new DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))))));
            this.colorPickControl.ThemeColors.Add(new DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))))));
            this.colorPickControl.ThemeColors.Add(new DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(189)))), ((int)(((byte)(151)))))));
            this.colorPickControl.ThemeColors.Add(new DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(179)))), ((int)(((byte)(226)))))));
            this.colorPickControl.ThemeColors.Add(new DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(204)))), ((int)(((byte)(228)))))));
            this.colorPickControl.ThemeColors.Add(new DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(185)))), ((int)(((byte)(183)))))));
            this.colorPickControl.ThemeColors.Add(new DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(188)))))));
            this.colorPickControl.ThemeColors.Add(new DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))))));
            this.colorPickControl.ThemeColors.Add(new DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(221)))), ((int)(((byte)(232)))))));
            this.colorPickControl.ThemeColors.Add(new DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(213)))), ((int)(((byte)(181)))))));
            this.colorPickControl.ThemeColors.Add(new DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))))));
            this.colorPickControl.ThemeColors.Add(new DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))))));
            this.colorPickControl.ThemeColors.Add(new DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(137)))), ((int)(((byte)(83)))))));
            this.colorPickControl.ThemeColors.Add(new DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(141)))), ((int)(((byte)(212)))))));
            this.colorPickControl.ThemeColors.Add(new DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))))));
            this.colorPickControl.ThemeColors.Add(new DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(150)))), ((int)(((byte)(148)))))));
            this.colorPickControl.ThemeColors.Add(new DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(214)))), ((int)(((byte)(155)))))));
            this.colorPickControl.ThemeColors.Add(new DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(162)))), ((int)(((byte)(199)))))));
            this.colorPickControl.ThemeColors.Add(new DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(205)))), ((int)(((byte)(220)))))));
            this.colorPickControl.ThemeColors.Add(new DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(192)))), ((int)(((byte)(143)))))));
            this.colorPickControl.ThemeColors.Add(new DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))))));
            this.colorPickControl.ThemeColors.Add(new DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))))));
            this.colorPickControl.ThemeColors.Add(new DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(68)))), ((int)(((byte)(41)))))));
            this.colorPickControl.ThemeColors.Add(new DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))))));
            this.colorPickControl.ThemeColors.Add(new DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(96)))), ((int)(((byte)(146)))))));
            this.colorPickControl.ThemeColors.Add(new DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(55)))), ((int)(((byte)(52)))))));
            this.colorPickControl.ThemeColors.Add(new DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(146)))), ((int)(((byte)(60)))))));
            this.colorPickControl.ThemeColors.Add(new DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(73)))), ((int)(((byte)(122)))))));
            this.colorPickControl.ThemeColors.Add(new DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(133)))), ((int)(((byte)(155)))))));
            this.colorPickControl.ThemeColors.Add(new DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(108)))), ((int)(((byte)(9)))))));
            this.colorPickControl.ThemeColors.Add(new DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))))));
            this.colorPickControl.ThemeColors.Add(new DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))))));
            this.colorPickControl.ThemeColors.Add(new DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(27)))), ((int)(((byte)(16)))))));
            this.colorPickControl.ThemeColors.Add(new DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(36)))), ((int)(((byte)(62)))))));
            this.colorPickControl.ThemeColors.Add(new DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(64)))), ((int)(((byte)(97)))))));
            this.colorPickControl.ThemeColors.Add(new DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(36)))), ((int)(((byte)(35)))))));
            this.colorPickControl.ThemeColors.Add(new DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(97)))), ((int)(((byte)(40)))))));
            this.colorPickControl.ThemeColors.Add(new DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(49)))), ((int)(((byte)(81)))))));
            this.colorPickControl.ThemeColors.Add(new DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(88)))), ((int)(((byte)(103)))))));
            this.colorPickControl.ThemeColors.Add(new DevExpress.XtraEditors.ColorItem(System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(72)))), ((int)(((byte)(6)))))));
            this.colorPickControl.UserMouse = true;
            // 
            // tabSystem
            // 
            this.tabSystem.Controls.Add(this.systemColorListControl);
            this.tabSystem.Name = "tabSystem";
            this.tabSystem.Size = new System.Drawing.Size(267, 247);
            this.tabSystem.Text = "System";
            // 
            // systemColorListControl
            // 
            this.systemColorListControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.systemColorListControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.systemColorListControl.Location = new System.Drawing.Point(0, 0);
            this.systemColorListControl.Name = "systemColorListControl";
            this.systemColorListControl.Selectable = true;
            this.systemColorListControl.Size = new System.Drawing.Size(267, 247);
            this.systemColorListControl.TabIndex = 0;
            this.systemColorListControl.Text = "button2";
            this.systemColorListControl.UserMouse = true;
            // 
            // tabWeb
            // 
            this.tabWeb.Controls.Add(this.webColorListControl);
            this.tabWeb.Name = "tabWeb";
            this.tabWeb.Size = new System.Drawing.Size(267, 247);
            this.tabWeb.Text = "Web";
            // 
            // webColorListControl
            // 
            this.webColorListControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.webColorListControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webColorListControl.Location = new System.Drawing.Point(0, 0);
            this.webColorListControl.Name = "webColorListControl";
            this.webColorListControl.Selectable = true;
            this.webColorListControl.Size = new System.Drawing.Size(267, 247);
            this.webColorListControl.TabIndex = 0;
            this.webColorListControl.Text = "button3";
            this.webColorListControl.UserMouse = true;
            // 
            // ColorSelectorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.xtraTabControl);
            this.Name = "ColorSelectorControl";
            this.Size = new System.Drawing.Size(273, 275);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl)).EndInit();
            this.xtraTabControl.ResumeLayout(false);
            this.tabCustom.ResumeLayout(false);
            this.tabSystem.ResumeLayout(false);
            this.tabWeb.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl;
        private DevExpress.XtraTab.XtraTabPage tabCustom;
        private DevExpress.XtraTab.XtraTabPage tabSystem;
        private DevExpress.XtraTab.XtraTabPage tabWeb;
        private DevExpress.XtraEditors.InnerColorPickControl colorPickControl;
        private DevExpress.XtraEditors.InnerColorListControl systemColorListControl;
        private DevExpress.XtraEditors.InnerColorListControl webColorListControl;
    }
}
