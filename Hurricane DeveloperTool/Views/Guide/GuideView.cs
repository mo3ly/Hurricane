using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hurricane_DeveloperTool.Views
{
    public partial class GuideView : Form, IGuideView
    {
        private static GuideView instance;

        public GuideView()
        {
            InitializeComponent();
            InfoToolTip.InitializeTooltip(this);
        }


        public static GuideView GetInstance(DashboardView parent)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new GuideView();
                instance.TopLevel = false;
                instance.Dock = DockStyle.Fill;
                parent.AddView(instance);
            }

            parent.SetView(instance);

            return instance;
        }

        private void hurricaneButton2_Click_1(object sender, EventArgs e)
        {
            if (hurricaneProgressBar1.Value < 100)
                hurricaneProgressBar1.Value += 3;
        }
    }
}
