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
    public partial class ConnectionView : Form, IConnectionView
    {
        private static ConnectionView instance;
        private static DashboardView dashboard;

        public event EventHandler ConnectEvent;

        public string Host { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Port { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Username { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Password { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string DatabaseAccount { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string DatabaseShard { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string DatabaseShardLog { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsAutoAuth { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsSuccessful { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Message { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public ConnectionView()
        {
            InitializeComponent();
            InfoToolTip.InitializeTooltip(this);
        }

        public static ConnectionView GetInstance(DashboardView parent)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new ConnectionView();
                dashboard = parent;
                instance.TopLevel = false;
                instance.Dock = DockStyle.Fill;
                parent.AddView(instance);
            }

            parent.SetView(instance);

            return instance;
        }
    }
}
