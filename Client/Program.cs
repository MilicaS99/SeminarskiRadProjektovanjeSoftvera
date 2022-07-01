using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            /* FrmLogIn frmlogin = new FrmLogIn();
             if (frmlogin.ShowDialog() == DialogResult.OK)
             {
                 Application.Run(new FrmMain());
             }*/
            while (true)
            {
                try
                {
                    FrmLogIn frmLogin = new FrmLogIn();
                    frmLogin.ShowDialog();
                    DialogResult result = frmLogin.DialogResult;
                    frmLogin.Dispose();

                    if (result == DialogResult.OK)
                    {
                        Application.Run(new FrmMain());
                    }
                    if (result == DialogResult.Cancel)
                    {
                        break;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Greska pri radu sa serverom!");
                }
            }

        }
    }
}
