using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hurricane_DeveloperTool.Views;
using Hurricane_DeveloperTool.Models;
using System.Windows.Forms;
using System.Drawing;

namespace Hurricane_DeveloperTool.Presenters
{
    public class DashboardPresenter
    {
        private IDashboardView dashboardView;
        private readonly string sqlConnectionString;

        public DashboardPresenter(IDashboardView view)
        {
            dashboardView = view;
            dashboardView.ShowConnectionView += ShowConnectionView;
            dashboardView.ShowGuideView += ShowGuideView;
            dashboardView.ShowStatisticsView += ShowStatisticsView;

            ShowConnectionView(this, EventArgs.Empty);
        }

        private void ShowConnectionView(object sender, EventArgs e)
        {
            IConnectionView view = ConnectionView.GetInstance((DashboardView)dashboardView);
            //IConnectionRepository repository = new ConnectionRepository();
            // make this one singlton also!
            new ConnectionPresenter(view);
        }

        private void ShowStatisticsView(object sender, EventArgs e)
        {
            IStatisticsView view = StatisticsView.GetInstance((DashboardView)dashboardView);
            new StatisticsPresenter(view);
        }

        private void ShowGuideView(object sender, EventArgs e)
        {
            IGuideView view = GuideView.GetInstance((DashboardView)dashboardView);
            new GuidePresenter(view);
        }
    }
}
