using Client.GUIController;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Client
{
    public partial class FrmLogIn : Form
    {

        private LogInController controller;
        public FrmLogIn()
        {
          
            InitializeComponent();
            controller = new LogInController();
        }
       /* private void InitClient()
        {
            try {
                Communication.Instance.Connect();
            }catch(Exception ex)
            {
                Debug.WriteLine(">>>" + ex.Message);
            }

        }*/
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            controller.Login(this);
        

        }
    }
}
