Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.ColorPick.Picker
Imports DevExpress.XtraEditors.Popup
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraTab

Namespace DXSample
    Partial Public Class ColorSelectorControl
        Inherits XtraUserControl


        Private selectedColor_Renamed As Color

        Public Sub New()
            Me.selectedColor_Renamed = Color.Black
            InitializeComponent()
        End Sub
        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            InitControls()
        End Sub

        Public Property SelectedColor() As Color
            Get
                Return selectedColor_Renamed
            End Get
            Set(ByVal value As Color)
                Dim old As Color = value
                If SelectedColor = value Then
                    Return
                End If
                selectedColor_Renamed = value
                OnSelectedColorChanged(old, SelectedColor)
            End Set
        End Property
        Protected Overrides Sub OnMouseWheel(ByVal e As MouseEventArgs)
            MyBase.OnMouseWheel(e)
            Dim current As InnerColorPickControlBase = GetCurrentSelector()
            If current IsNot Nothing Then
                current.DoMouseWheel(e)
            End If
        End Sub

        Protected Function GetCurrentSelector() As InnerColorPickControlBase
            Dim page As XtraTabPage = Me.xtraTabControl.SelectedTabPage
            If page Is Nothing OrElse page.Controls.Count = 0 Then
                Return Nothing
            End If
            Return TryCast(page.Controls(0), InnerColorPickControlBase)
        End Function
        Private Sub OnSelectedColorChanged(ByVal oldColor As Color, ByVal newColor As Color)
            RaiseEvent SelectedColorChanged(Me, New InnerColorPickControlSelectedColorChangedEventArgs(New ColorItem(oldColor), New ColorItem(newColor)))
        End Sub

        Private Sub InitControls()
            InitializeSystemColors()
            InitializeWebColors()
            SubscribeEvents()
        End Sub

        Private Sub InitializeSystemColors()
            Me.systemColorListControl.Colors.AddColorRange(ColorListBoxViewInfo.SystemColors)
        End Sub

        Private Sub InitializeWebColors()
            Me.webColorListControl.Colors.AddColorRange(ColorListBoxViewInfo.WebColors)
        End Sub
        Private Sub SubscribeEvents()
            AddHandler Me.colorPickControl.SelectedColorChanged, AddressOf OnSelectedColorChanged
            AddHandler Me.colorPickControl.MoreButtonClick, AddressOf OnMoreButtonClick
            AddHandler Me.systemColorListControl.SelectedColorChanged, AddressOf OnSelectedColorChanged
            AddHandler Me.webColorListControl.SelectedColorChanged, AddressOf OnSelectedColorChanged
        End Sub

        Public Event MoreButtonClick As EventHandler

        Private Sub OnMoreButtonClick(ByVal sender As Object, ByVal e As EventArgs)
            RaiseEvent MoreButtonClick(Me, EventArgs.Empty)
            DoShowColorDialog()
        End Sub


        Private properties_Renamed As RepositoryItemColorPickEdit = Nothing
        Private ReadOnly Property Properties() As RepositoryItemColorPickEdit
            Get
                If properties_Renamed Is Nothing Then
                    properties_Renamed = New RepositoryItemColorPickEdit()
                End If
                Return properties_Renamed
            End Get
        End Property

        Protected Overridable Sub DoShowColorDialog()
            Using frm As New FrmColorPicker(Properties)
                frm.StartPosition = FormStartPosition.CenterScreen
                frm.SelectedColor = Me.selectedColor_Renamed
                If frm.ShowDialog(GetOwner()) = DialogResult.OK Then
                    Dim color As Color = frm.SelectedColor
                    DoSaveColor(color)
                End If
            End Using
        End Sub
        Protected Overridable Function GetOwner() As IWin32Window
            Return Nothing
        End Function
        Protected Overridable Sub DoSaveColor(ByVal color As Color)
            Properties.RecentColors.InsertColor(color, 0)
            Me.colorPickControl.RecentColors.Insert(0, New ColorItem(color))
            SelectedColor = color
        End Sub

        Public Function CalcBestSize() As Size
            Dim sz As New Size(Width, CalcBestHeight())
            Return Me.xtraTabControl.CalcSizeByPageClient(sz)
        End Function

        Private Const BorderSize As Integer = 2
        Protected Function CalcBestHeight() As Integer
            Return Me.colorPickControl.CalcBestHeight(10) + 2 * BorderSize
        End Function
        Private Sub OnSelectedColorChanged(ByVal sender As Object, ByVal e As InnerColorPickControlSelectedColorChangedEventArgs)
            SelectedColor = e.NewColor
        End Sub
        Public Event SelectedColorChanged As InnerColorPickControlSelectedColorChangedEventHandler
    End Class
End Namespace
