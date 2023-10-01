using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using HurricaneServiceManager.Logic;

namespace HurricaneServiceManager.Views.Pages
{
    public partial class ConnectionPage : UserControl
    {

        static DBConnection dbConnection = Global.DBConnection;

        static PusherConnection pusherClient = Global.pusherClient;

        public ConnectionPage()
        {
            InitializeComponent();
        }

        private async void bSQLConnect_Click(object sender, EventArgs e)
        {
            bSQLConnect.Enabled = false;

            //sqlConnection = new MySQLConnection(tSQLHost.Text, tSQLPort.Text, tSQLUser.Text, tSQLPassword.Text, tSQLDatabase.Text);
            dbConnection = DBConnection.Instance();
            dbConnection.Server = tSQLHost.Text;
            dbConnection.Port = tSQLPort.Text;
            dbConnection.UserName = tSQLUser.Text;
            dbConnection.Password = tSQLPassword.Text;
            dbConnection.DatabaseName = tSQLDatabase.Text;

            if (await dbConnection.Connect())
            {
                bSQLConnect.Enabled = true;
                bSQLConnect.Visible = false;
                bSQLDisconnect.Visible = true;
                sConnectionPanel.Enabled = false;
                ISQLStatus.ForeColor = Color.DarkOliveGreen;
                ISQLStatus.Text = "Connected";
                shouldEnableServices();
                Global.Dashboard.WriteLog("Database connection has been established successfully!", 1);

                /*string query = "SELECT email,name FROM users";
                var cmd = new MySqlCommand(query, sqlConnection.Connection);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string col1 = reader.GetString(0);
                    string col2 = reader.GetString(1);
                    Global.Dashboard.WriteLog(col1 + " , " + col2);
                }*/

            } 
            else
            {
                bSQLConnect.Enabled = true;
                Global.Dashboard.WriteLog("Failed to establish a connection to the database!", 0);
            }
        }

        private async void bSQLDisconnect_Click(object sender, EventArgs e)
        {
            bSQLDisconnect.Enabled = false;
            if (await dbConnection.Disconnect())
            {
                bSQLDisconnect.Enabled = true;
                bSQLDisconnect.Visible = false;
                bSQLConnect.Visible = true;
                sConnectionPanel.Enabled = true;
                ISQLStatus.ForeColor = Color.DarkRed;
                ISQLStatus.Text = "Disconnected";
                shouldEnableServices();
                Global.Dashboard.WriteLog("Disconnected the database connection.", 0);
            } 
            else
            {
                bSQLDisconnect.Enabled = true;
            }
        }

        private async void bPusherConnect_Click(object sender, EventArgs e)
        {
            bPusherConnect.Enabled = false;

            //if (pusherClient == null)
            pusherClient = new PusherConnection(tPusherHost.Text, tPusherPort.Text, tPusherKey.Text);

            if (await pusherClient.Connect())
            {
                bPusherConnect.Enabled = true;
                bPusherConnect.Visible = false;
                bPusherDisconnect.Visible = true;
                pConnectionPanel.Enabled = false;
                IPusherStatus.ForeColor = Color.DarkOliveGreen;
                IPusherStatus.Text = "Connected";
                shouldEnableServices();

                bool isSubscribed = await pusherClient.SubscribeServiceManagerChannel();
                Global.Dashboard.WriteLog(isSubscribed ?
                    "Service Manager Channel subscription has been made successfully." :
                    "Service Manager Channel subscription has been made successfully.", 1);
            }
            else
            {
                bPusherConnect.Enabled = true;
                Global.Dashboard.WriteLog("Failed to established the connection to pusher.", 0);
            }
        }

        private async void bPusherDisconnect_Click(object sender, EventArgs e)
        {
            bPusherDisconnect.Enabled = false;

            if (await pusherClient.Disconnect())
            {
                bPusherDisconnect.Enabled = true;
                bPusherDisconnect.Visible = false;
                bPusherConnect.Visible = true;
                pConnectionPanel.Enabled = true;
                IPusherStatus.ForeColor = Color.DarkRed;
                IPusherStatus.Text = "Disconnected";
                shouldEnableServices();
            } 
            else
            {
                bPusherDisconnect.Visible = true;
            }
        }

        private void shouldEnableServices()
        {
            if (dbConnection == null || pusherClient == null) return;

            Global.Dashboard.pNavButtons.Enabled = dbConnection.isConnected && pusherClient.isConnected;
        }
    }
}
