using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using Hurricane_DeveloperTool.APIs;
using Hurricane_DeveloperTool.HurricaneControls;
using Hurricane_DeveloperTool.Views.Dialogs;
using Hurricane_DeveloperTool.Core.Config;
using Hurricane_DeveloperTool.Core;

namespace Hurricane_DeveloperTool.Views
{
    public partial class DashboardView : Form, IDashboardView
    {
        /// <summary>
        /// TODO:
        ///     Watch Generics, Async, Socket, OOP, Dapper, Delegates Event tutorials
        /// </summary>

        private List<Icon> loggerIconsList;
        private HurricaneButton currentActiveButton;

        public event EventHandler ShowConnectionView;
        public event EventHandler ShowGuideView;
        public event EventHandler ShowStatisticsView;

        /// <summary>
        /// Dashboard constuctor
        /// </summary>
        public DashboardView()
        {
            InitializeComponent();
            InitializeLogger();
            SetupDashboard();
            RaiseEvents();
        }

        /// <summary>
        /// Setup the dashboard properties
        /// </summary>
        private void SetupDashboard()
        {
            SetStyle(ControlStyles.UserPaint, false);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            BackColor = Color.FromArgb(18, 18, 18);
            TransparencyKey = BackColor;
            currentActiveButton = buttonConnection;
        }

        /// <summary>
        /// Initalaize the logger data
        /// </summary>
        private void InitializeLogger()
        {
            try
            {
                loggerIconsList = new List<Icon>();

                loggerIconsList.AddRange(new []
                {
                    Icon.ExtractAssociatedIcon(Constants.Directories.Icons + "icon-warning.ico"),
                    Icon.ExtractAssociatedIcon(Constants.Directories.Icons + "icon-failed.ico"),
                    Icon.ExtractAssociatedIcon(Constants.Directories.Icons + "icon-success.ico")
                });

                EventController.RegsiterEvent(EventAttributes.OnAddLog, new Action<string, LogType>(WriteLog));
            }
            catch { }
        }

        /// <summary>
        /// Associate and raise the events
        /// </summary>
        private void RaiseEvents()
        {
            buttonConnection.Click += delegate { 
                ShowConnectionView?.Invoke(this, EventArgs.Empty);
                ActivateSideBarButton(buttonConnection);
            };

            buttonStatistics.Click += delegate {
                ShowStatisticsView?.Invoke(this, EventArgs.Empty);
                ActivateSideBarButton(buttonStatistics);
            };

            buttonGuide.Click += delegate { 
                ShowGuideView?.Invoke(this, EventArgs.Empty);
                ActivateSideBarButton(buttonGuide);
            };
        }

        /// <summary>
        /// Add view to the content panel
        /// </summary>
        /// <param name="view"></param>
        public void AddView(Form view){
            panelContent.Controls.Add(view);
        }

        /// <summary>
        /// Set the current view to a specified view
        /// </summary>
        /// <param name="view"></param>
        public void SetView(Form view)
        {
            foreach (Control control in panelContent.Controls)
            {
                if (control != view) 
                    control.Hide(); 
                else
                    view.Show();
            }
        }

        /// <summary>
        /// Activate a side bar button
        /// </summary>
        /// <param name="button"></param>
        private void ActivateSideBarButton(HurricaneButton button)
        {
            if(currentActiveButton != null)
            {
                currentActiveButton.BackColor = Color.FromArgb(30, 30, 30);
                currentActiveButton.ForeColor = Color.FromArgb(220,220,220) ;
                currentActiveButton.BorderColor = Color.FromArgb(60, 60, 60);
            }

            button.BackColor = Color.FromArgb(208, 168, 92);
            button.ForeColor = Color.FromArgb(40, 40, 40);
            button.BorderColor = Color.FromArgb(30, 30, 30);

            currentActiveButton = button;
        }

        /// <summary>
        /// Write log message to the log bar
        /// </summary>
        /// <param name="message"></param>
        /// <param name="logType"></param>
        public void WriteLog(string message, LogType logType = LogType.NOTIFY)
        {
            try
            {
                Icon icon = null;
                Color color = Color.White;
                switch (logType)
                {
                    case LogType.NOTIFY:
                        icon = loggerIconsList[0];
                        color = Color.White;
                        break;
                    case LogType.WARN:
                        icon = loggerIconsList[0];
                        color = Color.White;
                        break;
                    case LogType.ERROR:
                        icon = loggerIconsList[1];
                        color = Color.IndianRed;
                        break;
                    case LogType.SUCCESS:
                        icon = loggerIconsList[2];
                        color = Color.GreenYellow;
                        break;
                }
                int rowIndex = logsGrid.Rows.Add(icon, message, DateTime.Now.ToString("HH:mm:ss tt"));
                logsGrid.Rows[rowIndex].DefaultCellStyle.ForeColor  = color;
                logsGrid.FirstDisplayedScrollingRowIndex = logsGrid.RowCount - 1;

            }
            catch { }
        }

        #region Header
        private void panelTitleHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                WindowsAPI.ReleaseCapture();
                WindowsAPI.SendMessage(Handle, WindowsAPI.WM_NCLBUTTONDOWN, WindowsAPI.HT_CAPTION, 0);
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            DialogResult result = IMessageBox.Show("Are you sure you want to exit!");

            if (result == DialogResult.OK)
            {
                Application.Exit();
                //Environment.Exit(0);
                //Close();
            }
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void dropMenuButton_Click(object sender, EventArgs e)
        {
            dropDownMenu.PrimaryColor = Color.FromArgb(30, 30, 30);
            dropDownMenu.BackColor = Color.FromArgb(80, 80, 80);
            dropDownMenu.MenuItemTextColor = Color.FromArgb(200, 200, 200);
            dropDownMenu.Cursor = Cursors.Hand;
            dropDownMenu.IsMainMenu = true;
            dropDownMenu.Show(dropMenuButton, dropMenuButton.Width, 0);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = IMessageBox.Show("Here is our message which explains our situation regarding that issue!");

            if(result == DialogResult.OK)
                WriteLog("OK has been pressed!", LogType.SUCCESS);
            else
                WriteLog("Cancel has been pressed!", LogType.NOTIFY);
        }

        private void hideToTrayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = IMessageBox.Show("Are you sure you want to hide the appliction!");

            if (result == DialogResult.OK)
            {
                notifyTray.Visible = true;
                Hide();
                notifyTray.ShowBalloonTip(2000);
            }
        }

        private void notifyTray_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            notifyTray.Visible = false;
            Show();
            WindowState = FormWindowState.Normal;
        }
        #endregion

        private void DashboardView_Load(object sender, EventArgs e)
        {
            WriteLog("Hurricane Developer Tool has been loaded successfully!", LogType.SUCCESS);
            // test the config
            Config config = new Config();
            var configAttr = config.GetAttribute(ConfigCategory.LIMITS, "MAX_USER");
            if (configAttr != null)
            {
                Log.Notify(configAttr.Name);
                Log.Notify(configAttr.Description);
            }
            else Log.Notify("This configAttr1 is not found!");


            var configAttr2 = config.GetAttribute(ConfigCategory.LIMITS, "MAX_GUILD");
            if (configAttr2 != null)
            {
                Log.Notify(configAttr2.Name);
                Log.Notify(configAttr2.Description);
            }
            else Log.Notify("This configAttr2 is not found!");

            var configAttr3 = config.GetAttribute(ConfigCategory.DELAYS, "STALL_DELAY");
            if (configAttr3 != null)
            {
                Log.Notify(configAttr3.Name);
                Log.Notify(configAttr3.Description);
            }
            else WriteLog("This configAttr3 is not found!");

            int val = config.Get<int>("STALL_DELAY");
            Log.Notify(val + 50);
            config.Set("STALL_DELAY", 50);
            Log.Notify(config.Get<int>("STALL_DELAY"));
            Log.Notify(ConfigCategory.SQL);
        }
    }
}
