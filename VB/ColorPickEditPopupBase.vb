Imports DevExpress.XtraBars.ColorPick.Popup
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.ColorPick.Popup.Galleries
Imports DevExpress.XtraEditors.Popup
Imports DevExpress.XtraTab

Namespace DXSample
	Public Interface ISupportPopupHidding
		Sub HidePopup()
	End Interface

	Public Class ColorPickEditTabControlPopupBase
		Inherits ColorEditTabControlBase
		Private popup As ISupportPopupHidding
		Public Sub New(ByVal popup As ISupportPopupHidding)
			Me.popup = popup
			Me.ResultColor = Color.Empty
			Me.InternalEdit = New InternalColorPickEdit()
			Me.PopupForm = New PopupColorPickEditForm(InternalEdit)
			Me.Custom = New InternalCustomGalleryUserControl(popup, PopupForm)
			Me.Web = New WebColorsGalleryUserControl(PopupForm)
			Me.System = New SystemGalleryUserControl(PopupForm)
			Me.WebSafe = New WebSafeGalleryUserControl(PopupForm)
			Initialize()
		End Sub
		Protected Overrides Sub CreatePages()
			TabPages.AddRange(New XtraTabPage() { New XtraTabPage(), New XtraTabPage(), New XtraTabPage() })
		End Sub
		Protected Overridable Sub Initialize()
			InitCustomTab(TabPages(0))
			InitWebTab(TabPages(1))
			InitSystemTab(TabPages(2))
		End Sub
		Protected Overridable Sub InitCustomTab(ByVal page As XtraTabPage)
			page.Text = "Custom"
			AddHandler Custom.ColorChanged, AddressOf OnColorPopupColorChanged
			page.Controls.Add(Custom)
			Custom.Dock = DockStyle.Fill
		End Sub
		Protected Overridable Sub InitWebTab(ByVal page As XtraTabPage)
			page.Text = "Web"
			AddHandler Web.ColorChanged, AddressOf OnColorPopupColorChanged
			page.Controls.Add(Web)
			Web.Dock = DockStyle.Fill
		End Sub
		Protected Overridable Sub InitSystemTab(ByVal page As XtraTabPage)
			page.Text = "System"
			AddHandler System.ColorChanged, AddressOf OnColorPopupColorChanged
			page.Controls.Add(System)
			System.Dock = DockStyle.Fill
		End Sub
		Private privateResultColor As Color
		Public Property ResultColor() As Color
			Get
				Return privateResultColor
			End Get
			Set(ByVal value As Color)
				privateResultColor = value
			End Set
		End Property
		Public Function CalcBestSize() As Size
			Dim width As Integer = WebSafe.CalcBestWidth()
			Dim height As Integer = Custom.CalcBestHeight(width)
			Return CalcSizeByPageClient(New Size(width, height))
		End Function
		Protected Overridable Sub OnColorPopupColorChanged(ByVal sender As Object, ByVal e As ColorChangedEventArgs)
			ResultColor = e.Color
			OnResultColorChanged(New ColorChangedEventArgs(e.Color))
		End Sub
		Protected Overridable Sub OnResultColorChanged(ByVal e As ColorChangedEventArgs)
			RaiseEvent ResultColorChanged(Me, e)
		End Sub
		Public Event ResultColorChanged As EventHandler(Of ColorChangedEventArgs)

		Private privateInternalEdit As InternalColorPickEdit
		Protected Property InternalEdit() As InternalColorPickEdit
			Get
				Return privateInternalEdit
			End Get
			Private Set(ByVal value As InternalColorPickEdit)
				privateInternalEdit = value
			End Set
		End Property
		Private privateCustom As InternalCustomGalleryUserControl
		Protected Friend Property Custom() As InternalCustomGalleryUserControl
			Get
				Return privateCustom
			End Get
			Private Set(ByVal value As InternalCustomGalleryUserControl)
				privateCustom = value
			End Set
		End Property
		Private privateWeb As WebColorsGalleryUserControl
		Protected Friend Property Web() As WebColorsGalleryUserControl
			Get
				Return privateWeb
			End Get
			Private Set(ByVal value As WebColorsGalleryUserControl)
				privateWeb = value
			End Set
		End Property
		Private privateSystem As SystemGalleryUserControl
		Protected Friend Property System() As SystemGalleryUserControl
			Get
				Return privateSystem
			End Get
			Private Set(ByVal value As SystemGalleryUserControl)
				privateSystem = value
			End Set
		End Property
		Private privateWebSafe As WebSafeGalleryUserControl
		Protected Friend Property WebSafe() As WebSafeGalleryUserControl
			Get
				Return privateWebSafe
			End Get
			Private Set(ByVal value As WebSafeGalleryUserControl)
				privateWebSafe = value
			End Set
		End Property
		Private privatePopupForm As PopupColorPickEditForm
		Protected Property PopupForm() As PopupColorPickEditForm
			Get
				Return privatePopupForm
			End Get
			Private Set(ByVal value As PopupColorPickEditForm)
				privatePopupForm = value
			End Set
		End Property

		#Region "InternalColorPickEdit"
		Protected Friend Class InternalColorPickEdit
			Inherits ColorPickEdit
		End Class
		#End Region
		#Region "InternalCustomGalleryUserControl"
		Protected Friend Class InternalCustomGalleryUserControl
			Inherits CustomGalleryUserControl
			Private popup As ISupportPopupHidding
			Public Sub New(ByVal popup As ISupportPopupHidding, ByVal owner As IPopupColorEdit)
				MyBase.New(owner)
				Me.popup = popup
			End Sub
			Protected Overrides Sub OnMoreColorsItemClick(ByVal sender As Object, ByVal e As GalleryItemClickEventArgs)
				popup.HidePopup()
				MyBase.OnMoreColorsItemClick(sender, e)
			End Sub
		End Class
		#End Region
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				RemoveHandler Custom.ColorChanged, AddressOf OnColorPopupColorChanged
				RemoveHandler Web.ColorChanged, AddressOf OnColorPopupColorChanged
				RemoveHandler System.ColorChanged, AddressOf OnColorPopupColorChanged
				InternalEdit.Dispose()
				PopupForm.Dispose()
				Custom.Dispose()
				Web.Dispose()
				System.Dispose()
				WebSafe.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub
	End Class
End Namespace
