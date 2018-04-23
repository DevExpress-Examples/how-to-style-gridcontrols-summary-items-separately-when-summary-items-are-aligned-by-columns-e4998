﻿Imports Microsoft.VisualBasic
Imports System
Imports System.Linq
Imports System.Windows
Imports DevExpress.Data
Imports DevExpress.Xpf.Grid
Imports System.Windows.Controls
Imports System.Collections.Generic

Namespace DXSample
	Public Class GroupSummaryDataTemplateSelector
		Inherits DataTemplateSelector
		Private privateTemplate1 As DataTemplate
		Public Property Template1() As DataTemplate
			Get
				Return privateTemplate1
			End Get
			Set(ByVal value As DataTemplate)
				privateTemplate1 = value
			End Set
		End Property
		Private privateTemplate2 As DataTemplate
		Public Property Template2() As DataTemplate
			Get
				Return privateTemplate2
			End Get
			Set(ByVal value As DataTemplate)
				privateTemplate2 = value
			End Set
		End Property
		Private privateTemplate3 As DataTemplate
		Public Property Template3() As DataTemplate
			Get
				Return privateTemplate3
			End Get
			Set(ByVal value As DataTemplate)
				privateTemplate3 = value
			End Set
		End Property

		Public Overrides Function SelectTemplate(ByVal item As Object, ByVal container As DependencyObject) As DataTemplate
			Dim data As GridGroupSummaryData = TryCast(item, GridGroupSummaryData)

			If data Is Nothing Then
				Return Template1
			End If

			If data.Column.FieldName = "Count" Then
				Return Template2
			End If
			If data.Column.FieldName = "Price" AndAlso data.SummaryItem.SummaryType = SummaryItemType.Sum Then
				Return Template3
			Else
				Return Template1
			End If
		End Function
	End Class
End Namespace