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

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            controller.Pretrazi(this);
            #region pretraga
            /*string kriterijum = "";
            if (txtPretraga.Text != null)
            {
                string pokupljenkriterijum = txtPretraga.Text;
                kriterijum = $"where Ime='{pokupljenkriterijum}'";
                dataGridView1.DataSource = Communication.Instance.PretragaUčenika(kriterijum);


            }*/
            #endregion
        }

        private void button1_Click(object sender, EventArgs e)
        {
            controller.prikaziDetalje(this);
        }
    }
}
