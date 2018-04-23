// Developer Express Code Central Example:
// Using ColorPickEdit popup in PopupContainerControl and PopupControlContainer
// 
// This example illustrates how to use the ColorPickEdit popup with
// PopupContainerControl and PopupControlContainer.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E4075

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
            this.components = new System.ComponentModel.Container();
            this.popupContainerEdit = new DevExpress.XtraEditors.PopupContainerEdit();
            this.popupContainerControl = new DevExpress.XtraEditors.PopupContainerControl();
            this.popupContainerControlColorSelector = new DXSample.ColorSelectorControl();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.popupControlContainer = new DevExpress.XtraBars.PopupControlContainer(this.components);
            this.popupControlContainerColorSelector = new DXSample.ColorSelectorControl();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.popupContainerEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupContainerControl)).BeginInit();
            this.popupContainerControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupControlContainer)).BeginInit();
            this.popupControlContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // popupContainerEdit
            // 
            this.popupContainerEdit.Location = new System.Drawing.Point(12, 207);
            this.popupContainerEdit.Name = "popupContainerEdit";
            this.popupContainerEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.popupContainerEdit.Properties.CloseOnLostFocus = false;
            this.popupContainerEdit.Properties.CloseOnOuterMouseClick = false;
            this.popupContainerEdit.Properties.PopupControl = this.popupContainerControl;
            this.popupContainerEdit.Properties.PopupSizeable = false;
            this.popupContainerEdit.Properties.ShowPopupCloseButton = false;
            this.popupContainerEdit.Size = new System.Drawing.Size(237, 20);
            this.popupContainerEdit.TabIndex = 1;
            // 
            // popupContainerControl
            // 
            this.popupContainerControl.Controls.Add(this.popupContainerControlColorSelector);
            this.popupContainerControl.Location = new System.Drawing.Point(664, 210);
            this.popupContainerControl.Name = "popupContainerControl";
            this.popupContainerControl.Size = new System.Drawing.Size(269, 267);
            this.popupContainerControl.TabIndex = 9;
            // 
            // popupContainerControlColorSelector
            // 
            this.popupContainerControlColorSelector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.popupContainerControlColorSelector.Location = new System.Drawing.Point(0, 0);
            this.popupContainerControlColorSelector.Name = "popupContainerControlColorSelector";
            this.popupContainerControlColorSelector.SelectedColor = System.Drawing.Color.Black;
            this.popupContainerControlColorSelector.Size = new System.Drawing.Size(269, 267);
            this.popupContainerControlColorSelector.TabIndex = 0;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barItem1});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 4;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(945, 144);
            // 
            // barItem1
            // 
            this.barItem1.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.barItem1.Caption = "Item";
            this.barItem1.DropDownControl = this.popupControlContainer;
            this.barItem1.Id = 3;
            this.barItem1.Name = "barItem1";
            // 
            // popupControlContainer
            // 
            this.popupControlContainer.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.popupControlContainer.CloseOnLostFocus = false;
            this.popupControlContainer.CloseOnOuterMouseClick = false;
            this.popupControlContainer.Controls.Add(this.popupControlContainerColorSelector);
            this.popupControlContainer.Location = new System.Drawing.Point(367, 210);
            this.popupControlContainer.Name = "popupControlContainer";
            this.popupControlContainer.Ribbon = this.ribbonControl1;
            this.popupControlContainer.Size = new System.Drawing.Size(269, 267);
            this.popupControlContainer.TabIndex = 5;
            this.popupControlContainer.Visible = false;
            // 
            // popupControlContainerColorSelector
            // 
            this.popupControlContainerColorSelector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.popupControlContainerColorSelector.Location = new System.Drawing.Point(0, 0);
            this.popupControlContainerColorSelector.Name = "popupControlContainerColorSelector";
            this.popupControlContainerColorSelector.SelectedColor = System.Drawing.Color.Black;
            this.popupControlContainerColorSelector.Size = new System.Drawing.Size(269, 267);
            this.popupControlContainerColorSelector.TabIndex = 0;
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
            this.ClientSize = new System.Drawing.Size(945, 489);
            this.Controls.Add(this.popupContainerControl);
            this.Controls.Add(this.popupControlContainer);
            this.Controls.Add(this.popupContainerEdit);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "Form1";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.popupContainerEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupContainerControl)).EndInit();
            this.popupContainerControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupControlContainer)).EndInit();
            this.popupControlContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PopupContainerEdit popupContainerEdit;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem barItem1;
        private DevExpress.XtraBars.PopupControlContainer popupControlContainer;
        private DevExpress.XtraEditors.PopupContainerControl popupContainerControl;
        private ColorSelectorControl popupContainerControlColorSelector;
        private ColorSelectorControl popupControlContainerColorSelector;
    }
}
