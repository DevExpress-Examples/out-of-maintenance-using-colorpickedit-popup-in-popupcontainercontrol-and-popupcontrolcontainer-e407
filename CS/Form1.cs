// Developer Express Code Central Example:
// Using ColorPickEdit popup in PopupContainerControl and PopupControlContainer
// 
// This example illustrates how to use the ColorPickEdit popup with
// PopupContainerControl and PopupControlContainer.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E4075

using System.ComponentModel;
using System.Drawing;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;

namespace DXSample {
    public partial class Form1 : RibbonForm {
        public Form1() {
            InitializeComponent();
        }
        protected override void OnLoad(System.EventArgs e) {
            base.OnLoad(e);
            InitPopupControlContainer();
            InitPopupContainerControl();
        }

        void InitPopupControlContainer() {
            this.popupControlContainerColorSelector.SelectedColorChanged += (sender, e) => {
                this.popupControlContainer.HidePopup();
                Text = e.NewColor.ToString();
                this.popupControlContainer.Height = this.popupControlContainerColorSelector.CalcBestSize().Height;
            };
            this.popupControlContainerColorSelector.MoreButtonClick += (sender, e) => this.popupControlContainer.HidePopup();
        }

        void InitPopupContainerControl() {
            this.popupContainerControlColorSelector.SelectedColorChanged += (sender, e) => {
                this.popupContainerControl.OwnerEdit.EditValue = e.NewColor;
                this.popupContainerControl.OwnerEdit.ClosePopup();
                this.popupContainerControl.Height = popupContainerControlColorSelector.CalcBestSize().Height;
                Text = e.NewColor.ToString();
            };
        }
    }
}
