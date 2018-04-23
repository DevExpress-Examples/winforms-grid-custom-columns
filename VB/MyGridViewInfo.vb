Imports System
Imports System.Drawing
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Namespace MyXtraGrid
	Public Class MyGridViewInfo
		Inherits DevExpress.XtraGrid.Views.Grid.ViewInfo.GridViewInfo

		Public Sub New(ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
			MyBase.New(gridView)
		End Sub


		Public Overrides Function CalcRowHeight(ByVal graphics As Graphics, ByVal rowHandle As Integer, ByVal rowVisibleIndex As Integer, ByVal min As Integer, ByVal level As Integer, ByVal useCache As Boolean, ByVal columns As GridColumnsInfo) As Integer
			Return MyBase.CalcRowHeight(graphics, rowHandle, rowVisibleIndex, min - 2, level, useCache, columns)
		End Function
	End Class
End Namespace
