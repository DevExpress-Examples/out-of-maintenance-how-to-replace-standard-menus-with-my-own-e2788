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

Namespace WindowsApplication1
	Public Class DXMenuItemWrapper

		Private _Item As DXMenuItem
		Public Sub New(ByVal item As DXMenuItem)
			_Item = item
		End Sub

		Public Overrides Function ToString() As String
			Return _Item.Caption
		End Function

		Public Sub GenerateClickEvent()
			_Item.GenerateClickEvent()
		End Sub
	End Class
End Namespace
