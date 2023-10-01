using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hurricane_DeveloperTool.Models
{
    public interface IConnectionRepository
    {
        void Edit(ConnectionModel connectionModel);
        ConnectionModel GetConnection();
    }
}
