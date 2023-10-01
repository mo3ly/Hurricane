using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HurricaneServiceManager.Logic
{
    public sealed class DBConnection
    {

        public bool isConnected { get; private set; } = false;

        public string Server { get; set; }

        public string Port { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string DatabaseName { get; set; }

        public MySqlConnection Connection { get; set; }

        private static DBConnection _instance = null;

        private DBConnection()
        {

        }

        public static DBConnection Instance()
        {
            if (_instance == null)
            {
                _instance = new DBConnection();
            }

            return _instance;
        }

        public async Task<bool> Connect()
        {
            if (string.IsNullOrEmpty(DatabaseName)) //|| Connection != null
                return isConnected = false;

            try
            {
                Connection = new MySqlConnection(string.Format("Server={0}; Port={1}; database={2}; UID={3}; password={4}", Server, Port, DatabaseName, UserName, Password));
                await Connection.OpenAsync();
                return isConnected = true;
            } 
            catch (Exception e)
            {
                Global.Dashboard.WriteLog("Error while connecting to database. Error:" + e.ToString(), 0);
                return isConnected = false;
            }

        }

        public async Task<bool> Disconnect()
        {
            if (isConnected)
            {
                try
                {
                    await Connection.CloseAsync();
                    isConnected = false;
                    return true;
                }
                catch (Exception e)
                {
                    Global.Dashboard.WriteLog("Error while connecting to database. Error:" + e.ToString(), 0);
                    return false;
                }
             }
            else
            {
                return true;
            }
        }
    }
}
