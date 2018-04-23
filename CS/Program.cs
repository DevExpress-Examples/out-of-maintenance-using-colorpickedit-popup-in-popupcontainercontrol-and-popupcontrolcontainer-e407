// Developer Express Code Central Example:
// Using ColorPickEdit popup in PopupContainerControl and PopupControlContainer
// 
// This example illustrates how to use the ColorPickEdit popup with
// PopupContainerControl and PopupControlContainer.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E4075

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.LookAndFeel;

namespace DXSample {
    static class Program {
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            SkinManager.EnableFormSkins();
            UserLookAndFeel.Default.SetSkinStyle("Black");
            Application.Run(new Form1());
        }
    }
}
