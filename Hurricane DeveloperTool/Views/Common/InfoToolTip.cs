using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Hurricane_DeveloperTool.Views
{
    public static class InfoToolTip
    {
        private static ToolTip dashboardTooltip = new ToolTip();

        public static void InitializeTooltip(Form form)
        {
            dashboardTooltip.Draw += DashboardTooltip_Draw;
            foreach (var control in GetAll(form, typeof(HurricaneControls.HurricanePictureBox)))
            {
                if (control.Tag != string.Empty && control.Tag != null)
                {
                    control.MouseHover += new EventHandler(delegate (object sender, EventArgs a)
                    {
                        dashboardTooltip.Show((sender as HurricaneControls.HurricanePictureBox).Tag.ToString(), (sender as HurricaneControls.HurricanePictureBox));
                        dashboardTooltip.ToolTipTitle = "Info";
                        dashboardTooltip.OwnerDraw = true;
                    });
                }
            }
        }

        private static void DashboardTooltip_Draw(object sender, DrawToolTipEventArgs e)
        {
            dashboardTooltip.BackColor = Color.FromArgb(31, 31, 31);
            dashboardTooltip.ForeColor = Color.White;
            e.DrawBackground();
            e.DrawBorder();
            e.DrawText();
        }

        private static IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAll(ctrl, type))
                                      .Concat(controls)
                                      .Where(c => c.GetType() == type);
        }
    }
}
