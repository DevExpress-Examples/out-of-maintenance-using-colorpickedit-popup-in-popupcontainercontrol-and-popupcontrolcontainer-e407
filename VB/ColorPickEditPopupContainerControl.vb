Imports DevExpress.XtraBars.ColorPick.Popup
Imports DevExpress.XtraEditors

Namespace DXSample
	Public Class ColorPickEditPopupContainerControl
		Inherits PopupContainerControl
		Implements ISupportPopupHidding
		Public Sub New()
			Me.TabControl = New ColorPickEditTabControlPopupBase(Me)
		End Sub
		Protected Overrides Sub OnLoaded()
			MyBase.OnLoaded()
			Initialize()
		End Sub
		Protected Overridable Sub Initialize()
			Controls.Add(TabControl)
			SubscribeEvents()
			ForceUpdateLayout()
		End Sub
		Protected Overrides Function GetScaledBounds(ByVal bounds As Rectangle, ByVal factor As SizeF, ByVal specified As BoundsSpecified) As Rectangle
			Dim res As Rectangle = MyBase.GetScaledBounds(bounds, factor, specified)
			Return New Rectangle(res.Location, TabControl.CalcBestSize())
		End Function
		Protected Friend Sub ForceUpdateLayout()
			TabControl.Size = TabControl.CalcBestSize()
			Size = TabControl.Size
		End Sub

		Public Event ResultColorChanged As EventHandler(Of ColorChangedEventArgs)
		Protected Overridable Sub OnResultColorChanged(ByVal e As ColorChangedEventArgs)
			RaiseEvent ResultColorChanged(Me, e)
		End Sub

		Private Sub SubscribeEvents()
			If TabControl Is Nothing Then
				Return
			End If
			AddHandler TabControl.ResultColorChanged, AddressOf TabControl_ResultColorChanged
		End Sub
		Private Sub UnsubscribeEvents()
			If TabControl Is Nothing Then
				Return
			End If
			RemoveHandler TabControl.ResultColorChanged, AddressOf TabControl_ResultColorChanged
		End Sub
		Private Sub TabControl_ResultColorChanged(ByVal sender As Object, ByVal e As ColorChangedEventArgs)
			OnResultColorChanged(e)
		End Sub

		Public Overridable Sub UpdateLayout()
			ForceUpdateLayout()
		End Sub
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			UnsubscribeEvents()
			If disposing Then
				If TabControl IsNot Nothing Then
					TabControl.Dispose()
				End If
				TabControl = Nothing
			End If
			MyBase.Dispose(disposing)
		End Sub
		Private privateTabControl As ColorPickEditTabControlPopupBase
		Protected Property TabControl() As ColorPickEditTabControlPopupBase
			Get
				Return privateTabControl
			End Get
			Private Set(ByVal value As ColorPickEditTabControlPopupBase)
				privateTabControl = value
			End Set
		End Property

		#Region "ISupportPopupHidding"
		Public Sub HidePopup() Implements ISupportPopupHidding.HidePopup
			OwnerEdit.ClosePopup()
		End Sub
		#End Region
	End Class
End Namespace
