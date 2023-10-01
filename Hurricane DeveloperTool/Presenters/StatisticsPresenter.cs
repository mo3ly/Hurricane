using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hurricane_DeveloperTool.Views;

namespace Hurricane_DeveloperTool.Presenters
{
    public class StatisticsPresenter
    {
        private IStatisticsView statisticsView;

        public StatisticsPresenter(IStatisticsView view)
        {
            statisticsView = view;
        }
    }
}
