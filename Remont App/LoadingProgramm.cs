using System;
using System.Windows.Forms;

namespace Remont_App
{
    public partial class LoadingProgramm : Form
    {
        public LoadingProgramm()
        {
            InitializeComponent();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity += .03;
            if (this.Opacity == 1)
            {
                StartScreen str = new StartScreen();
                Hide();
                str.ShowDialog();
                Close();
            }
        }
    }
}
