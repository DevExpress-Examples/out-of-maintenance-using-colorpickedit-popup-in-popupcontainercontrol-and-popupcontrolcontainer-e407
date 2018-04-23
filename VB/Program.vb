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
