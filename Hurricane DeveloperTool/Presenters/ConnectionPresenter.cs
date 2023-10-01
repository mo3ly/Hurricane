using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hurricane_DeveloperTool.Views;
using Hurricane_DeveloperTool.Models;

namespace Hurricane_DeveloperTool.Presenters
{
    public class ConnectionPresenter
    {
        private IConnectionView connectionView;
        private IConnectionRepository connectionRepository;

        public ConnectionPresenter (IConnectionView view)//, IConnectionRepository repository
        {
            connectionView = view;
            //connectionRepository = repository;
            connectionView.ConnectEvent += ConnectDatabaseEvent;
        }

        private void ConnectDatabaseEvent(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
