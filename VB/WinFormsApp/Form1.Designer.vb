Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraBars

Namespace WinFormsApp
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
			Me.customGridLookUpEdit1 = New WinFormsApp.CustomGridLookUpEdit()
			Me.customGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
			CType(Me.customGridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.customGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' customGridLookUpEdit1
			' 
			Me.customGridLookUpEdit1.Location = New System.Drawing.Point(154, 92)
			Me.customGridLookUpEdit1.Name = "customGridLookUpEdit1"
			Me.customGridLookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.customGridLookUpEdit1.Properties.View = Me.customGridLookUpEdit1View
			Me.customGridLookUpEdit1.Size = New System.Drawing.Size(374, 20)
			Me.customGridLookUpEdit1.TabIndex = 0
			' 
			' customGridLookUpEdit1View
			' 
			Me.customGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
			Me.customGridLookUpEdit1View.Name = "customGridLookUpEdit1View"
			Me.customGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
			Me.customGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(672, 504)
			Me.Controls.Add(Me.customGridLookUpEdit1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.customGridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.customGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

				#End Region

		Private customGridLookUpEdit1 As CustomGridLookUpEdit
		Private customGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView

	End Class
End Namespace