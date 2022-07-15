using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnProgram_Click(object sender, EventArgs e)
        {
            FormaProgram frmprogram = new FormaProgram();
            frmprogram.ShowDialog();
           

        }

        private void btnVaspitac_Click(object sender, EventArgs e)
        {
            FormaVaspitač frmvaspitac = new FormaVaspitač();
            frmvaspitac.ShowDialog();
        }

        private void btnUčenik_Click(object sender, EventArgs e)
        {
            FormaUčenik frmucenik = new FormaUčenik();
            frmucenik.ShowDialog();
        }

        private void btnGrupa_Click(object sender, EventArgs e)
        {
            FormaGrupa frmgrupa = new FormaGrupa();
            frmgrupa.ShowDialog();
        }
        /// <summary>
        /// mislim da ti ovo ne trebba
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
       // private void btnPohadjanje_Click(object sender, EventArgs e)
        //{
          //  FormaPohadjanje frmpohadjanje = new FormaPohadjanje();
            //frmpohadjanje.ShowDialog();
        //}

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                Communication.Instance.Close();
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
