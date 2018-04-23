Imports System.ComponentModel
Imports DevExpress.XtraBars.ColorPick.Popup
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Namespace DXSample
	Partial Public Class Form1
		Inherits RibbonForm
		Public Sub New()
			InitializeComponent()
		End Sub
		Private Sub colorPickEditPopupControl_QueryResultValue(ByVal sender As Object, ByVal e As QueryResultValueEventArgs) Handles colorPickEditPopupControl.QueryResultValue
			Dim res As Object = e.Value
		End Sub
		Private Sub colorPickEditPopupControl_Properties_QueryPopUp(ByVal sender As Object, ByVal e As CancelEventArgs) Handles colorPickEditPopupControl.Properties.QueryPopUp
			Me.colorPickEditPopupContainerControl1.UpdateLayout()
		End Sub
		Private Sub colorPickEditPopupContainerControl1_ResultColorChanged(ByVal sender As Object, ByVal e As ColorChangedEventArgs) Handles colorPickEditPopupContainerControl1.ResultColorChanged
			colorPickEditPopupControl.EditValue = e.Color
			colorPickEditPopupControl.ClosePopup()
		End Sub
		Private Sub colorPickEditPopupControlContainer1_ResultColorChanged(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ColorPick.Popup.ColorChangedEventArgs) Handles colorPickEditPopupControlContainer1.ResultColorChanged
			Dim msg As String = String.Format("Selected Color: {0}", Me.colorPickEditPopupControlContainer1.ResultColor)
			XtraMessageBox.Show(msg, "Color Info")
		End Sub
	End Class
End Namespace
