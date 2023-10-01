using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hurricane_DeveloperTool.Views;

namespace Hurricane_DeveloperTool.Presenters
{
    public class GuidePresenter
    {
        private IGuideView guideView;

        public GuidePresenter(IGuideView view)
        {
            guideView = view;
        }
    }
}
