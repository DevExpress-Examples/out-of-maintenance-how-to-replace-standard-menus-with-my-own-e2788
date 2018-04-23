Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.Utils
Imports DevExpress.Utils.Drawing

Namespace WindowsApplication1
	Partial Public Class MyPopupForm
		Inherits DevExpress.XtraEditors.XtraForm
		Private _appObject As New AppearanceObject()
		Public Sub New(ByVal menu As DXPopupMenu)
			InitializeComponent()
			PupulateListBoxControl(menu)
			AddHandler imageListBoxControl1.Click, AddressOf listBoxControl1_Click
			_appObject.Font = New Font(AppearanceObject.DefaultFont.FontFamily, 8)
		End Sub

		Private Sub listBoxControl1_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim item As ImageListBoxItem = TryCast(imageListBoxControl1.SelectedItem, ImageListBoxItem)
			TryCast(item.Value, DXMenuItemWrapper).GenerateClickEvent()
			Close()
		End Sub

		Private Function GetImageIndex(ByVal item As DXMenuItem) As Integer
			If item.Image Is Nothing Then
				Return - 1
			Else
				Return imageList1.Images.Add(item.Image, Color.Transparent)
			End If
		End Function
		Public Sub PupulateListBoxControl(ByVal menu As DXPopupMenu)
			For Each item As DXMenuItem In menu.Items
				imageListBoxControl1.Items.Add(New DXMenuItemWrapper(item), GetImageIndex(item))
			Next item
		End Sub

		Private Sub MyPopupForm_Deactivate(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Deactivate
			Close()
		End Sub

		Private maxHeight As Integer = 200
		Public ReadOnly Property BestSize() As Size
			Get
				Return New Size(150, Math.Min(maxHeight, (imageListBoxControl1.ItemCount + 1) * 20))
			End Get
		End Property

		Private Sub imageListBoxControl1_Paint(ByVal sender As Object, ByVal e As PaintEventArgs) Handles imageListBoxControl1.Paint
			Dim bounds As Rectangle = imageListBoxControl1.ClientRectangle
			bounds.Y = bounds.Height - 10
			bounds.Height = 10
			e.Graphics.DrawLine(Pens.Red, bounds.Location, New Point(bounds.Width, bounds.Y))
			_appObject.ForeColor = Color.Black
			_appObject.DrawString(New GraphicsCache(e.Graphics), "Custom menu", bounds)
			bounds.Offset(-1, -1)
			_appObject.ForeColor = Color.Yellow
			_appObject.DrawString(New GraphicsCache(e.Graphics), "Custom menu", bounds)
		End Sub
	End Class
End Namespace