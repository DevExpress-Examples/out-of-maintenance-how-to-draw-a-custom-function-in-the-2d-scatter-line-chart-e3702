Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Controls
Imports DevExpress.Xpf.Charts


Namespace ScatterLineWithCustomFunction
	Partial Public Class MainPage
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
			CreateArchimedianSpiralPoints()
		End Sub

		Private Sub CreateArchimedianSpiralPoints()
			For i As Integer = 0 To 719 Step 15
				Dim t As Double = CDbl(i) / 180 * Math.PI
				Dim x As Double = t * Math.Cos(t)
				Dim y As Double = t * Math.Sin(t)
				ArchimedianSpiral.Points.Add(New SeriesPoint(x, y))
			Next i
		End Sub

	End Class
End Namespace
