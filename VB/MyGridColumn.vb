Imports System
Imports DevExpress.Utils.Serializing
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base

Namespace MyXtraGrid

	Public Class MyGridColumn
		Inherits GridColumn

		Public Sub New()
		End Sub

		Private customDataValue As String = String.Empty

		<XtraSerializableProperty()>
		Public Property CustomData() As String
			Get
				Return customDataValue
			End Get
			Set(ByVal value As String)
				customDataValue = value
			End Set
		End Property

		Protected Overrides Sub Assign(ByVal column As GridColumn)
			MyBase.Assign(column)
			If TypeOf column Is MyGridColumn Then
				Me.CustomData = DirectCast(column, MyGridColumn).CustomData
			End If
		End Sub
	End Class

	Public Class MyGridColumnCollection
		Inherits GridColumnCollection

		Public Sub New(ByVal view As ColumnView)
			MyBase.New(view)
		End Sub

		Protected Overrides Function CreateColumn() As GridColumn
			Return New MyGridColumn()
		End Function
	End Class
End Namespace