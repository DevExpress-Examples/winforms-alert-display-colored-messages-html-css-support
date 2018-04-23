Imports Microsoft.VisualBasic
Imports System
Namespace WindowsFormsApplication2
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
			Me.btnColoredAlert = New DevExpress.XtraEditors.SimpleButton()
			Me.btnRegularAlert = New DevExpress.XtraEditors.SimpleButton()
			Me.colorPickEdit1 = New DevExpress.XtraEditors.ColorPickEdit()
			Me.alertControl1 = New WindowsFormsApplication2.CustomAlertControl(Me.components)
			CType(Me.colorPickEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' btnColoredAlert
			' 
			Me.btnColoredAlert.Location = New System.Drawing.Point(12, 12)
			Me.btnColoredAlert.Name = "btnColoredAlert"
			Me.btnColoredAlert.Size = New System.Drawing.Size(143, 31)
			Me.btnColoredAlert.TabIndex = 0
			Me.btnColoredAlert.Text = "Show alert with a color"
'			Me.btnColoredAlert.Click += New System.EventHandler(Me.simpleButton1_Click);
			' 
			' btnRegularAlert
			' 
			Me.btnRegularAlert.Location = New System.Drawing.Point(12, 49)
			Me.btnRegularAlert.Name = "btnRegularAlert"
			Me.btnRegularAlert.Size = New System.Drawing.Size(143, 31)
			Me.btnRegularAlert.TabIndex = 2
			Me.btnRegularAlert.Text = "Show regular alert"
'			Me.btnRegularAlert.Click += New System.EventHandler(Me.btnRegularAlert_Click);
			' 
			' colorPickEdit1
			' 
			Me.colorPickEdit1.EditValue = System.Drawing.Color.FromArgb((CInt(Fix((CByte(128))))), (CInt(Fix((CByte(128))))), (CInt(Fix((CByte(255))))))
			Me.colorPickEdit1.Location = New System.Drawing.Point(161, 18)
			Me.colorPickEdit1.Name = "colorPickEdit1"
			Me.colorPickEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.colorPickEdit1.Size = New System.Drawing.Size(213, 20)
			Me.colorPickEdit1.TabIndex = 3
			' 
			' alertControl1
			' 
			Me.alertControl1.FormShowingEffect = DevExpress.XtraBars.Alerter.AlertFormShowingEffect.SlideHorizontal
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(386, 262)
			Me.Controls.Add(Me.colorPickEdit1)
			Me.Controls.Add(Me.btnRegularAlert)
			Me.Controls.Add(Me.btnColoredAlert)
			Me.Name = "Form1"
			Me.Text = "Colored alerts"
			CType(Me.colorPickEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private alertControl1 As CustomAlertControl
		Private WithEvents btnColoredAlert As DevExpress.XtraEditors.SimpleButton
		Private WithEvents btnRegularAlert As DevExpress.XtraEditors.SimpleButton
		Private colorPickEdit1 As DevExpress.XtraEditors.ColorPickEdit
	End Class
End Namespace

