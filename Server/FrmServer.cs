using ApplicationLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Server
{
    public partial class FrmServer : Form
    {
        Server server;
        public FrmServer()
        {
            
            InitializeComponent();
            btnPokreni.Enabled = true;
            btnZaustavi.Enabled = false;
            this.FormClosed += FrmServer_FormClosed;
            

        }

        private void FrmServer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnPokreni_Click(object sender, EventArgs e)
        {
            server = new Server();
            if (server.Start())
            {
                btnPokreni.Enabled = false;
                 btnZaustavi.Enabled= true;
                MessageBox.Show("Server je pokrenut!");
                Thread nit = new Thread(server.HandleClients);
             
                nit.Start();
            }
            else
            {
                MessageBox.Show("Server nije pokrenut!");
            }
        }

        private void btnZaustavi_Click(object sender, EventArgs e)
        {
            server?.Stop();
            server = null;
            btnPokreni.Enabled = true;
            btnZaustavi.Enabled = false;
            MessageBox.Show("Server je zaustavljen!");
        }
    }
}
