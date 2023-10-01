using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Hurricane_DeveloperTool.Models
{
    public class ConnectionModel
    {
        private string host;
        private int port;
        private string username;
        private string password;
        private string accountDatabase;
        private string shardDatabase;
        private string shardLogDatabase;
        private bool useAutoAuth;

        [DisplayName("Server IP")]
        [Required(ErrorMessage = "Server IP is required")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Server Length must be between 1 and 50 characters.")]
        public string Host { get => host; set => host = value; }

        [DisplayName("Server Port")]
        public int Port { get => port; set => port = value; }

        [DisplayName("Username")]
        public string Username { get => username; set => username = value; }

        [DisplayName("Passowrd")]
        public string Password { get => password; set => password = value; }

        [DisplayName("Database Acccount")]
        public string AccountDatabase { get => accountDatabase; set => accountDatabase = value; }

        [DisplayName("Database Shard")]
        public string ShardDatabase { get => shardDatabase; set => shardDatabase = value; }

        [DisplayName("Database Shard Log")]
        public string ShardLogDatabase { get => shardLogDatabase; set => shardLogDatabase = value; }

        [DisplayName("System authentication")]
        public bool UseAutoConnect { get => useAutoAuth; set => useAutoAuth = value; }
    }
}
