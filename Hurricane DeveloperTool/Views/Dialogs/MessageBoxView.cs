using System;
using System.Drawing;
using System.Windows.Forms;
using Hurricane_DeveloperTool.APIs;


namespace Hurricane_DeveloperTool.Views.Dialogs
{
    public partial class MessageBoxView : Form
    {
        public MessageBoxView(string message)
        {
            InitializeComponent();
            InitializeUI();
            SetupMessageBox();
            labelMessage.Text = message;
        }

        private void InitializeUI()
        {
            buttonOK.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Select();
            buttonCancel.Font = new Font(buttonCancel.Font, FontStyle.Underline);
        }

        private void SetupMessageBox()
        {
            SetStyle(ControlStyles.UserPaint, false);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            BackColor = Color.FromArgb(20, 20, 20);
            TransparencyKey = BackColor;
        }

        private void panelHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                WindowsAPI.ReleaseCapture();
                WindowsAPI.SendMessage(Handle, WindowsAPI.WM_NCLBUTTONDOWN, WindowsAPI.HT_CAPTION, 0);
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
