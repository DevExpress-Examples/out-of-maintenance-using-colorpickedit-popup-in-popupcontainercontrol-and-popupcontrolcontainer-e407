using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraBars.ColorPick.Popup;
using DevExpress.XtraEditors;

namespace DXSample {
    public class ColorPickEditPopupContainerControl : PopupContainerControl, ISupportPopupHidding {
        public ColorPickEditPopupContainerControl() {
            this.TabControl = new ColorPickEditTabControlPopupBase(this);
        }
        protected override void OnLoaded() {
            base.OnLoaded();
            Initialize();
        }
        protected virtual void Initialize() {
            Controls.Add(TabControl);
            SubscribeEvents();
            ForceUpdateLayout();
        }
        protected override Rectangle GetScaledBounds(Rectangle bounds, SizeF factor, BoundsSpecified specified) {
            Rectangle res = base.GetScaledBounds(bounds, factor, specified);
            return new Rectangle(res.Location, TabControl.CalcBestSize());
        }
        protected internal void ForceUpdateLayout() {
            TabControl.Size = TabControl.CalcBestSize();
            Size = TabControl.Size;
        }
        
        public event EventHandler<ColorChangedEventArgs> ResultColorChanged;
        protected virtual void OnResultColorChanged(ColorChangedEventArgs e) {
            if(ResultColorChanged != null) ResultColorChanged(this, e);
        }

        void SubscribeEvents() {
            if(TabControl == null)
                return;
            TabControl.ResultColorChanged += TabControl_ResultColorChanged;
        }
        void UnsubscribeEvents() {
            if(TabControl == null)
                return;
            TabControl.ResultColorChanged -= TabControl_ResultColorChanged;
        }
        void TabControl_ResultColorChanged(object sender, ColorChangedEventArgs e) {
            OnResultColorChanged(e);
        }

        public virtual void UpdateLayout() {
            ForceUpdateLayout();
        }
        protected override void Dispose(bool disposing) {
            UnsubscribeEvents();
            if(disposing) {
                if(TabControl != null)
                    TabControl.Dispose();
                TabControl = null;
            }
            base.Dispose(disposing);
        }
        protected ColorPickEditTabControlPopupBase TabControl { get; private set; }
        
        #region ISupportPopupHidding
        public void HidePopup() {
            OwnerEdit.ClosePopup();
        }
        #endregion
    }
}
