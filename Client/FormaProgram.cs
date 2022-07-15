﻿using Client.GUIController;
using System;

using System.Windows.Forms;

namespace Client
{
    public partial class FormaProgram : Form
    {
        private ProgramController controller = new ProgramController();

        /*BindingList<Domain.Program> listaprograma;*/
        public FormaProgram()
        {
            InitializeComponent();
            Inicijalizuj();
            #region inicijalizacija
            /* DialogResult = DialogResult.OK;
             listaprograma = new BindingList<Domain.Program>(Communication.Instance.VratiListuPrograma());
             dataGridView1.DataSource = listaprograma;*/

            // Timer t = new Timer();
            //t.Interval = 5000;
            //t.Tick += Osvezi;
            //t.Start();
            #endregion


        }

        private void Inicijalizuj()
        {
            controller.Inicijalizuj(this);
        }

   



        private void btnPretražiProgram_Click(object sender, EventArgs e)
            {

            controller.PretraziProgram(this);
            #region pretrazi
            /* string kriterijum = "";
             if (txtKriterijum.Text != null)
             {
                 string pokupljenkriterijum = txtKriterijum.Text;
                 kriterijum = $"where Naziv='{pokupljenkriterijum}'";
                 dataGridView1.DataSource = Communication.Instance.PretragaPrograma(kriterijum);
             txtKriterijum.Text = null;


             }*/
            #endregion
        }

        private void button1_Click(object sender, EventArgs e)
        {
            controller.SacuvajProgram(this);
            #region sacuvaj
            /* if (!Validacija())
             {
                 return;
             }
             Domain.Program program = new Domain.Program();
             program.NazivPrograma = txtNaziv.Text;
             program.Opis = richTextBoxOpis.Text;
             Communication.Instance.SacuvajProgram(program);
            /* richTextBoxOpis.Text = null;
             txtNaziv.Text = null;*/
            #endregion
        }
        #region validacija
        /* private bool Validacija()
         {
             bool uspesno = true;
             if (string.IsNullOrEmpty(txtNaziv.Text ))
             {
                 MessageBox.Show("Niste uneli naziv programa!");
                 uspesno = false;
             }
             if (string.IsNullOrEmpty(richTextBoxOpis.Text))
             {
                 MessageBox.Show("Niste uneli opis programa!");
                 uspesno = false;
             }
             return uspesno;
         }*/
        #endregion

        private void btnPrikaziProgram_Click(object sender, EventArgs e)
        {
            controller.prikaziProgram(this);
        }
    }
}
