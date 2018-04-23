Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.Utils.Menu

Namespace WindowsApplication1
	Public Class MyMenuManager
		Implements IDXMenuManager

		Public Sub New()

		End Sub



		#Region "IDXMenuManager Members"

		Private Function Clone(ByVal newForm As Form) As IDXMenuManager Implements IDXMenuManager.Clone
			Return Me
		End Function

		Private Sub DisposeManager() Implements IDXMenuManager.DisposeManager

		End Sub

		Private Sub ShowPopupMenu(ByVal menu As DXPopupMenu, ByVal control As Control, ByVal pos As Point) Implements IDXMenuManager.ShowPopupMenu
			ShowMyCustomMenu(menu, control, pos)
		End Sub


		Private Sub ShowMyCustomMenu(ByVal menu As DXPopupMenu, ByVal control As Control, ByVal pos As Point)
			Dim popupForm As New MyPopupForm(menu)
			Dim maxHeight As Integer = Screen.GetWorkingArea(control).Bottom - pos.Y
			popupForm.Show()
			popupForm.Location = control.PointToScreen(pos)
			Dim size As Size = popupForm.BestSize
			popupForm.Height = Math.Min(maxHeight, size.Height)
			popupForm.Width = size.Width

		End Sub
		#End Region
	End Class
End Namespace
