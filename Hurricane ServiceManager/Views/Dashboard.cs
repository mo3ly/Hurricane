using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Windows.Forms;
using HurricaneServiceManager.Views.Pages;

namespace HurricaneServiceManager
{
    public partial class Dashboard : Form
    {
        #region Members
        /**
         * Indicates wheather the sider bar is visible or not
         */
        bool isSidebarVisible = false;

        /**
         * Indicates wheather log tab is visible or not
         */
        bool isLogVisible = false;

        /**
         * Dashboard navigation panel width
         */
        int panelWidth;

        /**
         * Dashboard tooltip
         */
        private ToolTip dashboardTooltip;

        /**
         * Current displayed page
         */
        private UserControl CurrentPage;

        /**
         * Store previous active side bar button
         */
        private Button pButton;

        /**
         * Store previous active side bar button color
         */
        private Color pButtonColor;

        /**
         * connection page
         */
        ConnectionPage connectionPage;

        #endregion

        /**
         * Dashboard Constructor
         */
        public Dashboard()
        {
            InitializeComponent();
            InitializeData();
            InitializeTooltip();
            InitializeLogger();
            InitializePages();
        }

        /**
         * Dashboard loaded event callback
         */
        private void Dashboard_Load(object sender, EventArgs e)
        {
            WriteLog("Hurricane Service Manager has been loaded successfully!", 1);
        }

        #region Tooltip
        private void InitializeTooltip()
        {
            dashboardTooltip = new ToolTip();
            dashboardTooltip.Draw += DashboardTooltip_Draw;
            foreach (var button in GetAll(this, typeof(Button)))
            {
                if (button.Tag != string.Empty && button.Tag != null)
                {
                    button.MouseHover += new EventHandler(delegate (object sender, EventArgs a)
                    {
                        dashboardTooltip.Show((sender as Button).Tag.ToString(), (sender as Button));
                        dashboardTooltip.ToolTipTitle = "Info";
                        dashboardTooltip.OwnerDraw = true;
                    });
                }
            }
        }

        private void DashboardTooltip_Draw(object sender, DrawToolTipEventArgs e)
        {
            dashboardTooltip.BackColor = Color.FromArgb(31, 31, 31);
            dashboardTooltip.ForeColor = Color.White;
            e.DrawBackground();
            e.DrawBorder();
            e.DrawText();
        }

        public IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAll(ctrl, type))
                                      .Concat(controls)
                                      .Where(c => c.GetType() == type);
        }
        #endregion

        private void InitializeData()
        {
            Global.Dashboard = this;
            panelWidth = pNavButtons.Width;
            pNavButtons.Enabled = false;
        }

        private void InitializePages()
        {
            connectionPage = new ConnectionPage();
            // navigate to connection page
            Navigation(connectionPage, pConnectionButton);
        }

        public void Navigation(UserControl control, Button button)
        {
            CurrentPage = control;
            mContent.Controls.Clear();
            control.Height = mContent.Height;
            control.Width = mContent.Width;

            // for responsive size
            mContent.Controls.Add(control);
            control.Show();

            // active the clicked button
            if (pButton != null)
                pButton.BackColor = pButtonColor;

            pButton = button;
            pButtonColor = button.BackColor;
            button.BackColor = Color.FromArgb(208, 168, 92);
        }

        #region Header
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
            Environment.Exit(0);
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void HeaderPanel_MouseMove(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                WindowsAPI.ReleaseCapture();
                WindowsAPI.SendMessage(Handle, WindowsAPI.WM_NCLBUTTONDOWN, WindowsAPI.HT_CAPTION, 0);
                /*CurrentPage.Size = mContent.Size;*/
            }
        }
        #endregion

        #region Logger
        private void InitializeLogger()
        {
            try
            {
                string ImageSrc = Directory.GetCurrentDirectory() + "/Resources/icons/";
                ImageList LogImageList = new ImageList();
                LogImageList.Images.Add(Image.FromFile(ImageSrc + "icon-failed.png"));
                LogImageList.Images.Add(Image.FromFile(ImageSrc + "icon-success.png"));
                LogImageList.Images.Add(Image.FromFile(ImageSrc + "icon-warning.png"));
                sLogList.SmallImageList = LogImageList;
            } catch { }
        }

        // change the type to enum instead of number
        // improve the log function and the text log one also
        private static object ListLocker = new object();
        public void WriteLog(string msg, int type = 2)
        {
            string mType;
            Color color;
            try
            {
                if (sLogList.InvokeRequired)
                    sLogList.Invoke(new MethodInvoker(delegate
                    {
                        WriteLog(msg, type);

                    }));
                else
                {
                    lock (ListLocker)
                    {
                        switch (type)
                        {
                            case 0:
                                color = Color.Red;
                                mType = "[FATAL]";
                                break;
                            case 1:
                                color = Color.DarkOliveGreen;
                                mType = "[NOTIFY]";
                                break;
                            case 2:
                                color = Color.FromArgb(70, 68, 52);
                                mType = "[INFO]";
                                break;
                            default:
                                color = Color.FromArgb(70, 68, 52);
                                mType = "[INFO]";
                                break;
                        }
                        string[] Message = { "", DateTime.Now.ToLongTimeString(), msg };
                        ListViewItem item = new ListViewItem(Message, type);
                        item.ForeColor = color;

                        sLogList.Items.Add(item);
                        sLogList.Items[sLogList.Items.Count - 1].EnsureVisible();
                        sLogList.Columns[sLogList.Columns.Count - 1].Width = -2;
                        // add to text file add file handeling
                        string LogMessage = $"{mType} \t {DateTime.Now} \t {msg}\n";
                        // create log every day
                        File.AppendAllText(Path.Combine(Directory.GetCurrentDirectory(), "Data/logs/log.txt"), LogMessage);
                        // show message box if Log panel is hidden
                        //if (isLogVisible)
                            //new message(msg).Show();
                        // new alert type
                        //new alert(msg, type);
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion

        private void LogButton_Click(object sender, EventArgs e)
        {
            if (isLogVisible)
            {
                pLogList.Visible = true;
                isLogVisible = false;
                pLogList.Height = 110;
                this.Refresh();
            }
            else
            {
                pLogList.Visible = false;
                isLogVisible = true;
                pLogList.Height = 0;
                this.Refresh();
                //new alert("Log panel is hidden.");

            }
            CurrentPage.Size = mContent.Size;
        }

        private void LogClear_Click(object sender, EventArgs e)
        {
            sLogList.Items.Clear();
            //new alert("Log panel has been cleared.");
        }

        private void pDirShortcutsButton_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(Directory.GetCurrentDirectory());
            }
            catch 
            { 
                WriteLog("Couldn't open app location.", 0); 
            }

        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            pSlideTimer.Start();
        }

        private void pSlideTimer_Tick(object sender, EventArgs e)
        {

            if (isSidebarVisible)
            {
                pNavButtons.Width = pNavButtons.Width + 10;
                if (pNavButtons.Width >= panelWidth)
                {
                    pSlideTimer.Stop();
                    isSidebarVisible = false;
                    this.Refresh();
                }
            }
            else
            {
                pNavButtons.Width = pNavButtons.Width - 10;
                if (pNavButtons.Width <= 0)
                {
                    pSlideTimer.Stop();
                    isSidebarVisible = true;
                    this.Refresh();
                }
            }
            CurrentPage.Size = mContent.Size;
        }
    }
}
