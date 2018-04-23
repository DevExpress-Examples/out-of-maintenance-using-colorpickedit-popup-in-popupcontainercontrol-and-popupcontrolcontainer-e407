' Developer Express Code Central Example:
' Using ColorPickEdit popup in PopupContainerControl and PopupControlContainer
' 
' This example illustrates how to use the ColorPickEdit popup with
' PopupContainerControl and PopupControlContainer.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E4075

Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.Skins
Imports DevExpress.LookAndFeel

Namespace DXSample
    Friend NotInheritable Class Program

        Private Sub New()
        End Sub

        <STAThread> _
        Shared Sub Main()
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)

            SkinManager.EnableFormSkins()
            UserLookAndFeel.Default.SetSkinStyle("Black")
            Application.Run(New Form1())
        End Sub
    End Class
End Namespace
