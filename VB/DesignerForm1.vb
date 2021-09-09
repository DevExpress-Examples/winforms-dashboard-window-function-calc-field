Imports DevExpress.DashboardCommon
Imports System
Imports System.IO

Namespace WinFormsDashboard
	Partial Public Class DesignerForm1
		Inherits DevExpress.XtraBars.Ribbon.RibbonForm

		Public Sub New()
			InitializeComponent()

			dashboardDesigner.CreateRibbon()
			dashboardDesigner.DataSourceOptions.ObjectDataSourceLoadingBehavior = DevExpress.DataAccess.DocumentLoadingBehavior.LoadAsIs
			dashboardDesigner.LoadDashboard(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\..\dashboard1.xml"))
		End Sub

		Private Sub DashboardDesigner1_DataLoading(ByVal sender As Object, ByVal e As DataLoadingEventArgs) Handles dashboardDesigner.DataLoading
			If e.DataId = "odsSales" Then
				e.Data = ProductSales.GetProductSales()
			End If
		End Sub
	End Class
End Namespace
