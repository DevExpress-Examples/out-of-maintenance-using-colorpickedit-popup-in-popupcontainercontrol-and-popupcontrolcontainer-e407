using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraBars.ColorPick.Popup;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.ColorPick.Popup.Galleries;
using DevExpress.XtraEditors.Popup;
using DevExpress.XtraTab;

namespace DXSample {
    public interface ISupportPopupHidding {
        void HidePopup();
    }
    
    public class ColorPickEditTabControlPopupBase : ColorEditTabControlBase {
        ISupportPopupHidding popup;
        public ColorPickEditTabControlPopupBase(ISupportPopupHidding popup) {
            this.popup = popup;
            this.ResultColor = Color.Empty;
            this.InternalEdit = new InternalColorPickEdit();
            this.PopupForm = new PopupColorPickEditForm(InternalEdit);
            this.Custom = new InternalCustomGalleryUserControl(popup, PopupForm);
            this.Web = new WebColorsGalleryUserControl(PopupForm);
            this.System = new SystemGalleryUserControl(PopupForm);
            this.WebSafe = new WebSafeGalleryUserControl(PopupForm);
            Initialize();
        }
        protected override void CreatePages() {
            TabPages.AddRange(new XtraTabPage[] { new XtraTabPage(), new XtraTabPage(), new XtraTabPage() });
        }
        protected virtual void Initialize() {
            InitCustomTab(TabPages[0]);
            InitWebTab(TabPages[1]);
            InitSystemTab(TabPages[2]);
        }
        protected virtual void InitCustomTab(XtraTabPage page) {
            page.Text = "Custom";
            Custom.ColorChanged += OnColorPopupColorChanged;
            page.Controls.Add(Custom);
            Custom.Dock = DockStyle.Fill;
        }
        protected virtual void InitWebTab(XtraTabPage page) {
            page.Text = "Web";
            Web.ColorChanged += OnColorPopupColorChanged;
            page.Controls.Add(Web);
            Web.Dock = DockStyle.Fill;
        }
        protected virtual void InitSystemTab(XtraTabPage page) {
            page.Text = "System";
            System.ColorChanged += OnColorPopupColorChanged;
            page.Controls.Add(System);
            System.Dock = DockStyle.Fill;
        }
        public Color ResultColor {
            get;
            set;
        }
        public Size CalcBestSize() {
            int width = WebSafe.CalcBestWidth();
            int height = Custom.CalcBestHeight(width);
            return CalcSizeByPageClient(new Size(width, height));
        }
        protected virtual void OnColorPopupColorChanged(object sender, ColorChangedEventArgs e) {
            ResultColor = e.Color;
            OnResultColorChanged(new ColorChangedEventArgs(e.Color));
        }
        protected virtual void OnResultColorChanged(ColorChangedEventArgs e) {
            if(ResultColorChanged != null) 
                ResultColorChanged(this, e);
        }
        public event EventHandler<ColorChangedEventArgs> ResultColorChanged;
        
        protected InternalColorPickEdit InternalEdit { get; private set; }
        protected internal InternalCustomGalleryUserControl Custom { get; private set; }
        protected internal WebColorsGalleryUserControl Web { get; private set; }
        protected internal SystemGalleryUserControl System { get; private set; }
        protected internal WebSafeGalleryUserControl WebSafe { get; private set; }
        protected PopupColorPickEditForm PopupForm { get; private set; }

        #region InternalColorPickEdit
        protected internal class InternalColorPickEdit : ColorPickEdit {
        }
        #endregion
        #region InternalCustomGalleryUserControl
        protected internal class InternalCustomGalleryUserControl : CustomGalleryUserControl {
            ISupportPopupHidding popup;
            public InternalCustomGalleryUserControl(ISupportPopupHidding popup, IPopupColorPickEdit owner) : base(owner) {
                this.popup = popup;
            }
            protected override void OnMoreColorsItemClick(object sender, GalleryItemClickEventArgs e) {
                popup.HidePopup();
                base.OnMoreColorsItemClick(sender, e);
            }
        }
        #endregion
        protected override void Dispose(bool disposing) {
            if(disposing) {
                Custom.ColorChanged -= OnColorPopupColorChanged;
                Web.ColorChanged -= OnColorPopupColorChanged;
                System.ColorChanged -= OnColorPopupColorChanged;
                InternalEdit.Dispose();
                PopupForm.Dispose();
                Custom.Dispose();
                Web.Dispose();
                System.Dispose();
                WebSafe.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
