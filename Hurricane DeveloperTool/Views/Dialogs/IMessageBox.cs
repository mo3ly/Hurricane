using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hurricane_DeveloperTool.Views.Dialogs
{
    public abstract class IMessageBox
    {
        public static DialogResult Show(string text)
        {
            DialogResult result;
            using (var msgForm = new MessageBoxView(text))
                result = msgForm.ShowDialog();

            return result;
        }
    }
}
