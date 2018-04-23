' Developer Express Code Central Example:
' Using ColorPickEdit popup in PopupContainerControl and PopupControlContainer
' 
' This example illustrates how to use the ColorPickEdit popup with
' PopupContainerControl and PopupControlContainer.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E4075

Imports System.ComponentModel
Imports System.Drawing
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Namespace DXSample
    Partial Public Class Form1
        Inherits RibbonForm

        Public Sub New()
            InitializeComponent()
        End Sub
        Protected Overrides Sub OnLoad(ByVal e As System.EventArgs)
            MyBase.OnLoad(e)
            InitPopupControlContainer()
            InitPopupContainerControl()
        End Sub

        Private Sub InitPopupControlContainer()
            AddHandler Me.popupControlContainerColorSelector.SelectedColorChanged, Sub(sender, e)
                Me.popupControlContainer.HidePopup()
                Text = e.NewColor.ToString()
                Me.popupControlContainer.Height = Me.popupControlContainerColorSelector.CalcBestSize().Height
            End Sub
            AddHandler Me.popupControlContainerColorSelector.MoreButtonClick, Sub(sender, e) Me.popupControlContainer.HidePopup()
        End Sub

        Private Sub InitPopupContainerControl()
            AddHandler Me.popupContainerControlColorSelector.SelectedColorChanged, Sub(sender, e)
                Me.popupContainerControl.OwnerEdit.EditValue = e.NewColor
                Me.popupContainerControl.OwnerEdit.ClosePopup()
                Me.popupContainerControl.Height = popupContainerControlColorSelector.CalcBestSize().Height
                Text = e.NewColor.ToString()
            End Sub
        End Sub
    End Class
End Namespace
