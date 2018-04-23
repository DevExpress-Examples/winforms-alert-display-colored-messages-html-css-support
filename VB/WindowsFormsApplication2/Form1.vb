Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms

Namespace WindowsFormsApplication2
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub
		Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnColoredAlert.Click
			alertControl1.Show(Me, "Caption", "Text", "Hot-tracked text", Nothing, Nothing, colorPickEdit1.Color)
		End Sub

        Private Sub btnRegularAlert_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRegularAlert.Click
            alertControl1.Show(Me, "Caption", "Text", "Hot-tracked text")
        End Sub
	End Class
End Namespace
