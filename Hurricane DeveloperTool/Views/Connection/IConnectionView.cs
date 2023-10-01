using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hurricane_DeveloperTool.Views
{
    public interface IConnectionView
    {
        string Host { get; set;  }
        string Port { get; set; } 
        string Username { get; set; }
        string Password { get; set; }
        string DatabaseAccount { get; set; }
        string DatabaseShard { get; set; }
        string DatabaseShardLog { get; set; }
        bool IsAutoAuth { get; set; }


        bool IsSuccessful { get; set;  }
        string Message { get; set; }

        event EventHandler ConnectEvent;
    }
}
