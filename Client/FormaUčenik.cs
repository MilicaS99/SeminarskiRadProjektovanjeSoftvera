using ApplicationLogic;
using Client.GUIController;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class FormaUčenik : Form
    {
        UčenikController controller = new UčenikController();
        /*BindingList<Učenik> listaucenika;*/
        public FormaUčenik()
        {
            InitializeComponent();
            Inicijalizuj();
            #region inicijalizacija
            /*listaucenika = new BindingList<Učenik>(Communication.Instance.VratiListuUčenika());
            dataGridView1.DataSource = listaucenika;*/
            #endregion
        }

        private void Inicijalizuj()
        {
            controller.Inicijalizuj(this);
        }

        private void btnSacuvajUcenika_Click(object sender, EventArgs e)
        {
            controller.SacuvajUcenika(this);
            #region sacuvaj ucenika


            /* DialogResult = DialogResult.OK;
             if (!Validacija())
             {
                 return;
             }
             Učenik ucenik = new Učenik();
             ucenik.Ime = txtIme.Text;
             ucenik.Prezime = txtPrezime.Text;
             ucenik.DatumRodjenja = DateTime.ParseExact(txtDatumRodjenja.Text, "dd.MM.yyyy. HH:mm", null);
             ucenik.Pol = txtPol.Text;
             ucenik.TelefonRoditelja = txtKontaktRoditelja.Text;
             Communication.Instance.SacuvajUcenika(ucenik);*/
            #endregion

        }
        #region validacija
        /* private bool Validacija()
         {
             bool uspesno = true;
             if (string.IsNullOrEmpty(txtIme.Text))
             {
                 MessageBox.Show("Niste uneli ime učenika!");
                 uspesno = false;
             }
             if (string.IsNullOrEmpty(txtPrezime.Text))
             {
                 MessageBox.Show("Niste uneli prezime učenika!");
                 uspesno = false;
             }
             if (string.IsNullOrEmpty(txtDatumRodjenja.Text))
             {
                 MessageBox.Show("Niste uneli datum rodjenja učenika!");
                 uspesno = false;
             }
             if (string.IsNullOrEmpty(txtPol.Text))
             {
                 MessageBox.Show("Niste uneli pol učenika!");
                 uspesno = false;
             }
             if (string.IsNullOrEmpty(txtKontaktRoditelja.Text))
             {
                 MessageBox.Show("Niste uneli kontakt telefon roditelja učenika!");
                 uspesno = false;
             }
             return uspesno;
         }*/
        #endregion region

     

        private void button1_Click(object sender, EventArgs e)
        {
            controller.prikaziDetalje(this);
        }

        private void txtIme_Enter(object sender, EventArgs e)
        {
            controller.prikaziImePH(this);
        }

        private void txtIme_Leave(object sender, EventArgs e)
        {
            controller.ukloniImePH(this);
        }

        private void txtPrezime_Enter(object sender, EventArgs e)
        {
            controller.prikatiPrezimePH(this);
        }

        private void txtPrezime_Leave(object sender, EventArgs e)
        {
            controller.ukloniPrezimePH(this);
        }

        private void txtDatumRodjenja_Enter(object sender, EventArgs e)
        {
            controller.prikaziDatumRodjenjaPH(this);
        }

        private void txtDatumRodjenja_Leave(object sender, EventArgs e)
        {
            controller.ukloniDatumRodjenjaPH(this);
        }

        private void txtPol_Enter(object sender, EventArgs e)
        {
            controller.prikaziPolPH(this);
        }

        private void txtPol_Leave(object sender, EventArgs e)
        {
            controller.ukloniPolPH(this);
        }

        private void txtKontaktRoditelja_Enter(object sender, EventArgs e)
        {
            controller.prikaziKontakRoditeljaPH(this);
        }

        private void txtKontaktRoditelja_Leave(object sender, EventArgs e)
        {
            controller.ukloniKontaktRoditeljaPH(this);
        }

       

       

        private void txtPretraga_Click(object sender, EventArgs e)
        {
            controller.InicijalitujDGV(this);
        }

        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            controller.Pretrazi(this);
        }


      
    }
}
