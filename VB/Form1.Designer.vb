' Developer Express Code Central Example:
' Using ColorPickEdit popup in PopupContainerControl and PopupControlContainer
' 
' This example illustrates how to use the ColorPickEdit popup with
' PopupContainerControl and PopupControlContainer.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E4075

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
            Me.components = New System.ComponentModel.Container()
            Me.popupContainerEdit = New DevExpress.XtraEditors.PopupContainerEdit()
            Me.popupContainerControl = New DevExpress.XtraEditors.PopupContainerControl()
            Me.popupContainerControlColorSelector = New DXSample.ColorSelectorControl()
            Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
            Me.barItem1 = New DevExpress.XtraBars.BarButtonItem()
            Me.popupControlContainer = New DevExpress.XtraBars.PopupControlContainer(Me.components)
            Me.popupControlContainerColorSelector = New DXSample.ColorSelectorControl()
            Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
            Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            DirectCast(Me.popupContainerEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.popupContainerControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.popupContainerControl.SuspendLayout()
            DirectCast(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.popupControlContainer, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.popupControlContainer.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' popupContainerEdit
            ' 
            Me.popupContainerEdit.Location = New System.Drawing.Point(12, 207)
            Me.popupContainerEdit.Name = "popupContainerEdit"
            Me.popupContainerEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.popupContainerEdit.Properties.CloseOnLostFocus = False
            Me.popupContainerEdit.Properties.CloseOnOuterMouseClick = False
            Me.popupContainerEdit.Properties.PopupControl = Me.popupContainerControl
            Me.popupContainerEdit.Properties.PopupSizeable = False
            Me.popupContainerEdit.Properties.ShowPopupCloseButton = False
            Me.popupContainerEdit.Size = New System.Drawing.Size(237, 20)
            Me.popupContainerEdit.TabIndex = 1
            ' 
            ' popupContainerControl
            ' 
            Me.popupContainerControl.Controls.Add(Me.popupContainerControlColorSelector)
            Me.popupContainerControl.Location = New System.Drawing.Point(664, 210)
            Me.popupContainerControl.Name = "popupContainerControl"
            Me.popupContainerControl.Size = New System.Drawing.Size(269, 267)
            Me.popupContainerControl.TabIndex = 9
            ' 
            ' popupContainerControlColorSelector
            ' 
            Me.popupContainerControlColorSelector.Dock = System.Windows.Forms.DockStyle.Fill
            Me.popupContainerControlColorSelector.Location = New System.Drawing.Point(0, 0)
            Me.popupContainerControlColorSelector.Name = "popupContainerControlColorSelector"
            Me.popupContainerControlColorSelector.SelectedColor = System.Drawing.Color.Black
            Me.popupContainerControlColorSelector.Size = New System.Drawing.Size(269, 267)
            Me.popupContainerControlColorSelector.TabIndex = 0
            ' 
            ' ribbonControl1
            ' 
            Me.ribbonControl1.ExpandCollapseItem.Id = 0
            Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.ribbonControl1.ExpandCollapseItem, Me.barItem1})
            Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
            Me.ribbonControl1.MaxItemId = 4
            Me.ribbonControl1.Name = "ribbonControl1"
            Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.ribbonPage1})
            Me.ribbonControl1.Size = New System.Drawing.Size(945, 144)
            ' 
            ' barItem1
            ' 
            Me.barItem1.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
            Me.barItem1.Caption = "Item"
            Me.barItem1.DropDownControl = Me.popupControlContainer
            Me.barItem1.Id = 3
            Me.barItem1.Name = "barItem1"
            ' 
            ' popupControlContainer
            ' 
            Me.popupControlContainer.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.popupControlContainer.CloseOnLostFocus = False
            Me.popupControlContainer.CloseOnOuterMouseClick = False
            Me.popupControlContainer.Controls.Add(Me.popupControlContainerColorSelector)
            Me.popupControlContainer.Location = New System.Drawing.Point(367, 210)
            Me.popupControlContainer.Name = "popupControlContainer"
            Me.popupControlContainer.Ribbon = Me.ribbonControl1
            Me.popupControlContainer.Size = New System.Drawing.Size(269, 267)
            Me.popupControlContainer.TabIndex = 5
            Me.popupControlContainer.Visible = False
            ' 
            ' popupControlContainerColorSelector
            ' 
            Me.popupControlContainerColorSelector.Dock = System.Windows.Forms.DockStyle.Fill
            Me.popupControlContainerColorSelector.Location = New System.Drawing.Point(0, 0)
            Me.popupControlContainerColorSelector.Name = "popupControlContainerColorSelector"
            Me.popupControlContainerColorSelector.SelectedColor = System.Drawing.Color.Black
            Me.popupControlContainerColorSelector.Size = New System.Drawing.Size(269, 267)
            Me.popupControlContainerColorSelector.TabIndex = 0
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
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(945, 489)
            Me.Controls.Add(Me.popupContainerControl)
            Me.Controls.Add(Me.popupControlContainer)
            Me.Controls.Add(Me.popupContainerEdit)
            Me.Controls.Add(Me.ribbonControl1)
            Me.Name = "Form1"
            Me.Ribbon = Me.ribbonControl1
            Me.Text = "Form1"
            DirectCast(Me.popupContainerEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.popupContainerControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.popupContainerControl.ResumeLayout(False)
            DirectCast(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.popupControlContainer, System.ComponentModel.ISupportInitialize).EndInit()
            Me.popupControlContainer.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        #End Region

        Private popupContainerEdit As DevExpress.XtraEditors.PopupContainerEdit
        Private ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
        Private ribbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
        Private ribbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Private barItem1 As DevExpress.XtraBars.BarButtonItem
        Private popupControlContainer As DevExpress.XtraBars.PopupControlContainer
        Private popupContainerControl As DevExpress.XtraEditors.PopupContainerControl
        Private popupContainerControlColorSelector As ColorSelectorControl
        Private popupControlContainerColorSelector As ColorSelectorControl
    End Class
End Namespace
