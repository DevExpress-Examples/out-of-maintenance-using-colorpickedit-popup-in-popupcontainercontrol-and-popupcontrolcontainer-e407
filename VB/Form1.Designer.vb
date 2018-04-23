Imports DevExpress.XtraEditors
Namespace DXSample
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.colorPickEditPopupControl = New DevExpress.XtraEditors.PopupContainerEdit()
			Me.colorPickEditPopupContainerControl1 = New DXSample.ColorPickEditPopupContainerControl()
			Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
			Me.barItem1 = New DevExpress.XtraBars.BarButtonItem()
			Me.colorPickEditPopupControlContainer1 = New DXSample.ColorPickEditPopupControlContainer()
			Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
			Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			CType(Me.colorPickEditPopupControl.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.colorPickEditPopupContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.colorPickEditPopupControlContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' colorPickEditPopupControl
			' 
			Me.colorPickEditPopupControl.Location = New Point(12, 190)
			Me.colorPickEditPopupControl.Name = "colorPickEditPopupControl"
			Me.colorPickEditPopupControl.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.colorPickEditPopupControl.Properties.CloseOnLostFocus = False
			Me.colorPickEditPopupControl.Properties.CloseOnOuterMouseClick = False
			Me.colorPickEditPopupControl.Properties.PopupControl = Me.colorPickEditPopupContainerControl1
			Me.colorPickEditPopupControl.Properties.PopupSizeable = False
			Me.colorPickEditPopupControl.Properties.ShowPopupCloseButton = False
'			Me.colorPickEditPopupControl.Properties.QueryPopUp += New System.ComponentModel.CancelEventHandler(Me.colorPickEditPopupControl_Properties_QueryPopUp)
			Me.colorPickEditPopupControl.Size = New Size(237, 20)
			Me.colorPickEditPopupControl.TabIndex = 1
'			Me.colorPickEditPopupControl.QueryResultValue += New DevExpress.XtraEditors.Controls.QueryResultValueEventHandler(Me.colorPickEditPopupControl_QueryResultValue)
			' 
			' colorPickEditPopupContainerControl1
			' 
			Me.colorPickEditPopupContainerControl1.Location = New Point(567, 210)
			Me.colorPickEditPopupContainerControl1.Name = "colorPickEditPopupContainerControl1"
			Me.colorPickEditPopupContainerControl1.Size = New Size(268, 267)
			Me.colorPickEditPopupContainerControl1.TabIndex = 9
'			Me.colorPickEditPopupContainerControl1.ResultColorChanged += New System.EventHandler(Of DevExpress.XtraBars.ColorPick.Popup.ColorChangedEventArgs)(Me.colorPickEditPopupContainerControl1_ResultColorChanged)
			' 
			' ribbonControl1
			' 
			Me.ribbonControl1.ExpandCollapseItem.Id = 0
			Me.ribbonControl1.ExpandCollapseItem.Name = ""
			Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.ribbonControl1.ExpandCollapseItem, Me.barItem1})
			Me.ribbonControl1.Location = New Point(0, 0)
			Me.ribbonControl1.MaxItemId = 4
			Me.ribbonControl1.Name = "ribbonControl1"
			Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.ribbonPage1})
			Me.ribbonControl1.Size = New Size(851, 144)
			' 
			' barItem1
			' 
			Me.barItem1.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
			Me.barItem1.Caption = "Item"
			Me.barItem1.DropDownControl = Me.colorPickEditPopupControlContainer1
			Me.barItem1.Id = 3
			Me.barItem1.Name = "barItem1"
			' 
			' colorPickEditPopupControlContainer1
			' 
			Me.colorPickEditPopupControlContainer1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.colorPickEditPopupControlContainer1.CloseOnLostFocus = False
			Me.colorPickEditPopupControlContainer1.CloseOnOuterMouseClick = False
			Me.colorPickEditPopupControlContainer1.Location = New Point(274, 210)
			Me.colorPickEditPopupControlContainer1.Name = "colorPickEditPopupControlContainer1"
			Me.colorPickEditPopupControlContainer1.ResultColor = Color.Empty
			Me.colorPickEditPopupControlContainer1.Ribbon = Me.ribbonControl1
			Me.colorPickEditPopupControlContainer1.Size = New Size(268, 267)
			Me.colorPickEditPopupControlContainer1.TabIndex = 5
			Me.colorPickEditPopupControlContainer1.Visible = False
'			Me.colorPickEditPopupControlContainer1.ResultColorChanged += New System.EventHandler(Of DevExpress.XtraBars.ColorPick.Popup.ColorChangedEventArgs)(Me.colorPickEditPopupControlContainer1_ResultColorChanged)
			' 
			' ribbonPage1
			' 
			Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.ribbonPageGroup1})
			Me.ribbonPage1.Name = "ribbonPage1"
			Me.ribbonPage1.Text = "Home"
			' 
			' ribbonPageGroup1
			' 
			Me.ribbonPageGroup1.ItemLinks.Add(Me.barItem1)
			Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
			Me.ribbonPageGroup1.Text = "Group"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.ClientSize = New Size(851, 489)
			Me.Controls.Add(Me.colorPickEditPopupContainerControl1)
			Me.Controls.Add(Me.colorPickEditPopupControlContainer1)
			Me.Controls.Add(Me.ribbonControl1)
			Me.Controls.Add(Me.colorPickEditPopupControl)
			Me.Name = "Form1"
			Me.Ribbon = Me.ribbonControl1
			Me.Text = "Form1"
			CType(Me.colorPickEditPopupControl.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.colorPickEditPopupContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.colorPickEditPopupControlContainer1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents colorPickEditPopupControl As DevExpress.XtraEditors.PopupContainerEdit
		Private ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
		Private ribbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
		Private ribbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private barItem1 As DevExpress.XtraBars.BarButtonItem
		Private WithEvents colorPickEditPopupControlContainer1 As ColorPickEditPopupControlContainer
		Private WithEvents colorPickEditPopupContainerControl1 As ColorPickEditPopupContainerControl
	End Class
End Namespace
