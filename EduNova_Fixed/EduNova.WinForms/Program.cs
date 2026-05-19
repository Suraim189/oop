using System;
using System.Windows.Forms;
using EduNova.WinForms.Forms.Common;

namespace EduNova.WinForms
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmSplash());
        }
    }
}
