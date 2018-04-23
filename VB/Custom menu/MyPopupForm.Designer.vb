Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication1
	Partial Public Class MyPopupForm
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
			Dim serializableAppearanceObject1 As New DevExpress.Utils.SerializableAppearanceObject()
			Me.imageListBoxControl1 = New DevExpress.XtraEditors.ImageListBoxControl()
			Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
			Me.buttonEdit1 = New DevExpress.XtraEditors.ButtonEdit()
			CType(Me.imageListBoxControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.buttonEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' imageListBoxControl1
			' 
			Me.imageListBoxControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.imageListBoxControl1.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned
			Me.imageListBoxControl1.HotTrackItems = True
			Me.imageListBoxControl1.ImageList = Me.imageList1
			Me.imageListBoxControl1.Location = New System.Drawing.Point(0, 20)
			Me.imageListBoxControl1.Name = "imageListBoxControl1"
			Me.imageListBoxControl1.Size = New System.Drawing.Size(203, 267)
			Me.imageListBoxControl1.TabIndex = 0
'			Me.imageListBoxControl1.Paint += New System.Windows.Forms.PaintEventHandler(Me.imageListBoxControl1_Paint);
			' 
			' imageList1
			' 
			Me.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
			Me.imageList1.ImageSize = New System.Drawing.Size(16, 16)
			Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
			' 
			' buttonEdit1
			' 
			Me.buttonEdit1.Dock = System.Windows.Forms.DockStyle.Top
			Me.buttonEdit1.Location = New System.Drawing.Point(0, 0)
			Me.buttonEdit1.Name = "buttonEdit1"
			Me.buttonEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "GO!", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", Nothing, Nothing, True)})
			Me.buttonEdit1.Properties.NullValuePrompt = "Search"
			Me.buttonEdit1.Properties.NullValuePromptShowForEmptyValue = True
			Me.buttonEdit1.Size = New System.Drawing.Size(203, 20)
			Me.buttonEdit1.TabIndex = 1
			' 
			' MyPopupForm
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(203, 287)
			Me.Controls.Add(Me.imageListBoxControl1)
			Me.Controls.Add(Me.buttonEdit1)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
			Me.Name = "MyPopupForm"
			Me.Text = "MyPopupForm"
'			Me.Deactivate += New System.EventHandler(Me.MyPopupForm_Deactivate);
			CType(Me.imageListBoxControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.buttonEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents imageListBoxControl1 As DevExpress.XtraEditors.ImageListBoxControl
		Private imageList1 As System.Windows.Forms.ImageList
		Private buttonEdit1 As DevExpress.XtraEditors.ButtonEdit

	End Class
End Namespace