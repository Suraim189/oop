using System;
using System.Windows.Forms;
using EduNova.WinForms.Helpers;

namespace EduNova.WinForms.Forms.Common
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
            Opacity = 0;
            timerFade.Start();
            timerProgress.Start();
        }

        private void timerFade_Tick(object sender, EventArgs e)
        {
            if (Opacity < 1.0)
                Opacity += 0.05;
            else
                timerFade.Stop();
        }

        private void timerProgress_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
                progressBar1.Value += 5;
            else
            {
                timerProgress.Stop();
                timerFade.Stop();
                frmLogin login = new frmLogin();
                login.Show();
                Hide();
            }
        }
    }
}
