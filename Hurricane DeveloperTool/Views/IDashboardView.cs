using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hurricane_DeveloperTool.Views
{
    public interface IDashboardView
    {
        event EventHandler ShowConnectionView;
        event EventHandler ShowGuideView;
        event EventHandler ShowStatisticsView;
    }
}
