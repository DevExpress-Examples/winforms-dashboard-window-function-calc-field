using DevExpress.DashboardCommon;
using System;
using System.IO;

namespace WinFormsDashboard {
    public partial class DesignerForm1 : DevExpress.XtraBars.Ribbon.RibbonForm {
        public DesignerForm1() {
            InitializeComponent();

            dashboardDesigner.CreateRibbon();
            dashboardDesigner.DataSourceOptions.ObjectDataSourceLoadingBehavior = DevExpress.DataAccess.DocumentLoadingBehavior.LoadAsIs;
            dashboardDesigner.LoadDashboard(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\dashboard1.xml"));
        }

        private void DashboardDesigner1_DataLoading(object sender, DataLoadingEventArgs e) {
            if (e.DataId == "odsSales") {
                e.Data = ProductSales.GetProductSales();
            }
        }
    }
}
