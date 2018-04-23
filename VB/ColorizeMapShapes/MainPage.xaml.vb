Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Windows.Controls
Imports System.Windows.Media
Imports DevExpress.Xpf.Map
Namespace ColorizeMapShapes
	Partial Public Class MainPage
		Inherits UserControl
		Private loadedShapes As List(Of MapItem)

		Public Sub New()
			InitializeComponent()
		End Sub

		#Region "#ShapesLoaded"
		Private Sub ShapefileLoader_ShapesLoaded(ByVal sender As Object, ByVal e As ShapesLoadedEventArgs)
			loadedShapes = e.Shapes
			PrepareShapesByPopulation()

		End Sub
		#End Region ' #ShapesLoaded
		Private Sub PrepareShapesByPopulation()
			If loadedShapes IsNot Nothing Then
				For Each item As MapItem In loadedShapes
					Dim shape As MapShape = TryCast(item, MapShape)
					shape.Fill = New SolidColorBrush(ColorGenerator.GetColorByPopulation(Convert.ToInt32(CDbl(item.Attributes("POP_EST").Value))))
				Next item
			End If
		End Sub

	End Class
End Namespace
