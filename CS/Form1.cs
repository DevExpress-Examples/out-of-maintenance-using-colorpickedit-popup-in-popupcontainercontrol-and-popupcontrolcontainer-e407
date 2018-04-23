using System.ComponentModel;
using DevExpress.XtraBars.ColorPick.Popup;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;

namespace DXSample {
    public partial class Form1 : RibbonForm {
        public Form1() {
            InitializeComponent();
        }
        void colorPickEditPopupControl_QueryResultValue(object sender, QueryResultValueEventArgs e) {
            object res = e.Value;
        }
        void colorPickEditPopupControl_Properties_QueryPopUp(object sender, CancelEventArgs e) {
            this.colorPickEditPopupContainerControl1.UpdateLayout();
        }
        void colorPickEditPopupContainerControl1_ResultColorChanged(object sender, ColorChangedEventArgs e) {
            colorPickEditPopupControl.EditValue = e.Color;
            colorPickEditPopupControl.ClosePopup();
        }
        void colorPickEditPopupControlContainer1_ResultColorChanged(object sender, DevExpress.XtraBars.ColorPick.Popup.ColorChangedEventArgs e) {
            string msg = string.Format("Selected Color: {0}", this.colorPickEditPopupControlContainer1.ResultColor);
            XtraMessageBox.Show(msg, "Color Info");
        }
    }
}
