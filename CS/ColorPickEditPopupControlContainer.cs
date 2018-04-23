using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.ColorPick.Popup;
using System;

namespace DXSample {
    class ColorPickEditPopupControlContainer : PopupControlContainer, ISupportPopupHidding {
        public ColorPickEditPopupControlContainer() {
            this.TabControl = new ColorPickEditTabControlPopupBase(this);
            this.TabControl.ResultColorChanged += OnTabControlResultColorChanged;
            SubscribeEvents();
        }
        public Color ResultColor {
            get { return TabControl.ResultColor; }
            set { TabControl.ResultColor = value; }
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

        protected override void OnLoaded() {
            base.OnLoaded();
            Initialize();
        }
        protected override void OnPopup() {
            ForceUpdateLayout();
            base.OnPopup();
        }
        public override void ShowPopup(BarManager manager, Point p) {
            ForceUpdateLayout();
            base.ShowPopup(manager, p);
        }
        protected virtual void Initialize() {
            Controls.Add(TabControl);
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
        void OnTabControlResultColorChanged(object sender, ColorChangedEventArgs e) {
            HidePopup();
        }
        protected override void Dispose(bool disposing) {
            UnsubscribeEvents();
            if(disposing) {
                if(TabControl != null) {
                    TabControl.Dispose();
                    TabControl.ResultColorChanged -= OnTabControlResultColorChanged;
                }
                TabControl = null;
            }
            base.Dispose(disposing);
        }
        protected ColorPickEditTabControlPopupBase TabControl { get; private set; }
    }
}
