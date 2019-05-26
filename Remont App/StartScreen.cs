using System;
using System.Windows.Forms;

namespace Remont_App
{
    public partial class StartScreen : Form
    {
        public StartScreen()
        {
            InitializeComponent();
        }

        private void Client_Click(object sender, EventArgs e)
        {
            Hide();
            ClientRegistration reg = new ClientRegistration();
            reg.ShowDialog();
            Close();
        }

        private void Manager_Click(object sender, EventArgs e)
        {
            Hide();
            ViewDB db = new ViewDB();
            db.ShowDialog();
            Close();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
