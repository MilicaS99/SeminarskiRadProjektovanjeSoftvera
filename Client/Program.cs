using Client.Exceptions;
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

            bool cancel = false;
            while (!cancel)
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
                    else
                    {
                        cancel = true;
                    }
                }
                catch (ServerCommunicationException)
                {
                    MessageBox.Show("Server je prestao sa radom!");
                }
            }

        }
    }
}
