using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.ColorPick.Picker;
using DevExpress.XtraEditors.Popup;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraTab;

namespace DXSample {
    public partial class ColorSelectorControl : XtraUserControl {
        Color selectedColor;
        
        public ColorSelectorControl() {
            this.selectedColor = Color.Black;
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            InitControls();
        }

        public Color SelectedColor {
            get { return selectedColor; }
            set {
                Color old = value;
                if(SelectedColor == value)
                    return;
                selectedColor = value;
                OnSelectedColorChanged(old, SelectedColor);
            }
        }
        protected override void OnMouseWheel(MouseEventArgs e) {
            base.OnMouseWheel(e);
            InnerColorPickControlBase current = GetCurrentSelector();
            if(current != null) current.DoMouseWheel(e);
        }

        protected InnerColorPickControlBase GetCurrentSelector() {
            XtraTabPage page = this.xtraTabControl.SelectedTabPage;
            if(page == null || page.Controls.Count == 0) return null;
            return page.Controls[0] as InnerColorPickControlBase;
        }
        void OnSelectedColorChanged(Color oldColor, Color newColor) {
            if(SelectedColorChanged != null) SelectedColorChanged(this, new InnerColorPickControlSelectedColorChangedEventArgs(new ColorItem(oldColor), new ColorItem(newColor)));
        }

        void InitControls() {
            InitializeSystemColors();
            InitializeWebColors();
            SubscribeEvents();
        }

        void InitializeSystemColors() {
            this.systemColorListControl.Colors.AddColorRange(ColorListBoxViewInfo.SystemColors);
        }

        void InitializeWebColors() {
            this.webColorListControl.Colors.AddColorRange(ColorListBoxViewInfo.WebColors);
        }
        void SubscribeEvents() {
            this.colorPickControl.SelectedColorChanged += OnSelectedColorChanged;
            this.colorPickControl.MoreButtonClick += OnMoreButtonClick;
            this.systemColorListControl.SelectedColorChanged += OnSelectedColorChanged;
            this.webColorListControl.SelectedColorChanged += OnSelectedColorChanged;
        }

        public event EventHandler MoreButtonClick;
        
        void OnMoreButtonClick(object sender, EventArgs e) {
            if(MoreButtonClick != null) MoreButtonClick(this, EventArgs.Empty);
            DoShowColorDialog();
        }

        RepositoryItemColorPickEdit properties = null;
        RepositoryItemColorPickEdit Properties {
            get {
                if(properties == null) properties = new RepositoryItemColorPickEdit();
                return properties;
            }
        }

        protected virtual void DoShowColorDialog() {
            using(FrmColorPicker frm = new FrmColorPicker(Properties)) {
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.SelectedColor = this.selectedColor;
                if(frm.ShowDialog(GetOwner()) == DialogResult.OK) {
                    Color color = frm.SelectedColor;
                    DoSaveColor(color);
                }
            }
        }
        protected virtual IWin32Window GetOwner() {
            return null;
        }
        protected virtual void DoSaveColor(Color color) {
            Properties.RecentColors.InsertColor(color, 0);
            this.colorPickControl.RecentColors.Insert(0, new ColorItem(color));
            SelectedColor = color;
        }

        public Size CalcBestSize() {
            Size sz = new Size(Width, CalcBestHeight());
            return this.xtraTabControl.CalcSizeByPageClient(sz);
        }

        const int BorderSize = 2;
        protected int CalcBestHeight() {
            return this.colorPickControl.CalcBestHeight(10) + 2 * BorderSize;
        }
        void OnSelectedColorChanged(object sender, InnerColorPickControlSelectedColorChangedEventArgs e) {
            SelectedColor = e.NewColor;
        }
        public event InnerColorPickControlSelectedColorChangedEventHandler SelectedColorChanged;
    }
}
