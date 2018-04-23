using DevExpress.XtraEditors;
namespace DXSample {
    partial class Form1 {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.colorPickEditPopupControl = new DevExpress.XtraEditors.PopupContainerEdit();
            this.colorPickEditPopupContainerControl1 = new DXSample.ColorPickEditPopupContainerControl();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.colorPickEditPopupControlContainer1 = new DXSample.ColorPickEditPopupControlContainer();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.colorPickEditPopupControl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorPickEditPopupContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorPickEditPopupControlContainer1)).BeginInit();
            this.SuspendLayout();
            // 
            // colorPickEditPopupControl
            // 
            this.colorPickEditPopupControl.Location = new System.Drawing.Point(12, 190);
            this.colorPickEditPopupControl.Name = "colorPickEditPopupControl";
            this.colorPickEditPopupControl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.colorPickEditPopupControl.Properties.CloseOnLostFocus = false;
            this.colorPickEditPopupControl.Properties.CloseOnOuterMouseClick = false;
            this.colorPickEditPopupControl.Properties.PopupControl = this.colorPickEditPopupContainerControl1;
            this.colorPickEditPopupControl.Properties.PopupSizeable = false;
            this.colorPickEditPopupControl.Properties.ShowPopupCloseButton = false;
            this.colorPickEditPopupControl.Properties.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.colorPickEditPopupControl_Properties_QueryPopUp);
            this.colorPickEditPopupControl.Size = new System.Drawing.Size(237, 20);
            this.colorPickEditPopupControl.TabIndex = 1;
            this.colorPickEditPopupControl.QueryResultValue += new DevExpress.XtraEditors.Controls.QueryResultValueEventHandler(this.colorPickEditPopupControl_QueryResultValue);
            // 
            // colorPickEditPopupContainerControl1
            // 
            this.colorPickEditPopupContainerControl1.Location = new System.Drawing.Point(567, 210);
            this.colorPickEditPopupContainerControl1.Name = "colorPickEditPopupContainerControl1";
            this.colorPickEditPopupContainerControl1.Size = new System.Drawing.Size(268, 267);
            this.colorPickEditPopupContainerControl1.TabIndex = 9;
            this.colorPickEditPopupContainerControl1.ResultColorChanged += new System.EventHandler<DevExpress.XtraBars.ColorPick.Popup.ColorChangedEventArgs>(this.colorPickEditPopupContainerControl1_ResultColorChanged);
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.ExpandCollapseItem.Name = "";
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barItem1});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 4;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(851, 144);
            // 
            // barItem1
            // 
            this.barItem1.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.barItem1.Caption = "Item";
            this.barItem1.DropDownControl = this.colorPickEditPopupControlContainer1;
            this.barItem1.Id = 3;
            this.barItem1.Name = "barItem1";
            // 
            // colorPickEditPopupControlContainer1
            // 
            this.colorPickEditPopupControlContainer1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.colorPickEditPopupControlContainer1.CloseOnLostFocus = false;
            this.colorPickEditPopupControlContainer1.CloseOnOuterMouseClick = false;
            this.colorPickEditPopupControlContainer1.Location = new System.Drawing.Point(274, 210);
            this.colorPickEditPopupControlContainer1.Name = "colorPickEditPopupControlContainer1";
            this.colorPickEditPopupControlContainer1.ResultColor = System.Drawing.Color.Empty;
            this.colorPickEditPopupControlContainer1.Ribbon = this.ribbonControl1;
            this.colorPickEditPopupControlContainer1.Size = new System.Drawing.Size(268, 267);
            this.colorPickEditPopupControlContainer1.TabIndex = 5;
            this.colorPickEditPopupControlContainer1.Visible = false;
            this.colorPickEditPopupControlContainer1.ResultColorChanged += new System.EventHandler<DevExpress.XtraBars.ColorPick.Popup.ColorChangedEventArgs>(this.colorPickEditPopupControlContainer1_ResultColorChanged);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Home";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barItem1);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Group";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 489);
            this.Controls.Add(this.colorPickEditPopupContainerControl1);
            this.Controls.Add(this.colorPickEditPopupControlContainer1);
            this.Controls.Add(this.ribbonControl1);
            this.Controls.Add(this.colorPickEditPopupControl);
            this.Name = "Form1";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.colorPickEditPopupControl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorPickEditPopupContainerControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorPickEditPopupControlContainer1)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.PopupContainerEdit colorPickEditPopupControl;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem barItem1;
        private ColorPickEditPopupControlContainer colorPickEditPopupControlContainer1;
        private ColorPickEditPopupContainerControl colorPickEditPopupContainerControl1;
    }
}
