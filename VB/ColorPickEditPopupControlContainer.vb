Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.ColorPick.Popup

Namespace DXSample
	Friend Class ColorPickEditPopupControlContainer
		Inherits PopupControlContainer
		Implements ISupportPopupHidding

		Private Sub ISupportPopupHidding_HidePopup() Implements ISupportPopupHidding.HidePopup
			MyBase.HidePopup()
		End Sub

		Public Sub New()
			Me.TabControl = New ColorPickEditTabControlPopupBase(Me)
			AddHandler Me.TabControl.ResultColorChanged, AddressOf OnTabControlResultColorChanged
			SubscribeEvents()
		End Sub
		Public Property ResultColor() As Color
			Get
				Return TabControl.ResultColor
			End Get
			Set(ByVal value As Color)
				TabControl.ResultColor = value
			End Set
		End Property

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

		Protected Overrides Sub OnLoaded()
			MyBase.OnLoaded()
			Initialize()
		End Sub
		Protected Overrides Sub OnPopup()
			ForceUpdateLayout()
			MyBase.OnPopup()
		End Sub
		Public Overrides Overloads Sub ShowPopup(ByVal manager As BarManager, ByVal p As Point)
			ForceUpdateLayout()
			MyBase.ShowPopup(manager, p)
		End Sub
		Protected Overridable Sub Initialize()
			Controls.Add(TabControl)
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
		Private Sub OnTabControlResultColorChanged(ByVal sender As Object, ByVal e As ColorChangedEventArgs)
			HidePopup()
		End Sub
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			UnsubscribeEvents()
			If disposing Then
				If TabControl IsNot Nothing Then
					TabControl.Dispose()
					RemoveHandler TabControl.ResultColorChanged, AddressOf OnTabControlResultColorChanged
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
	End Class
End Namespace
