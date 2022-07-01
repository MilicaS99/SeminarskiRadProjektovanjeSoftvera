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
    public partial class FormaVaspitač : Form
    {
        BindingList<Vaspitač> listavaspitaca;
        public FormaVaspitač()
        {
            InitializeComponent();
           
          cbProgram.DataSource = Communication.Instance.VratiListuPrograma();
            listavaspitaca = new BindingList<Vaspitač>(Communication.Instance.VratiSveVaspitače());
            dataGridView1.DataSource = listavaspitaca;
        }

        private void btnDodajVaspitača_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

            if (!ValidacijaDodajVaspitača())
            {
                return;
            }

            Vaspitač v = new Vaspitač();
            v.Ime = txtIme.Text;
            v.Prezime = txtPrezime.Text;
            v.Pol = txtPol.Text;
            v.Kontakt = txtKontakt.Text;
            v.Program = (Domain.Program)cbProgram.SelectedItem;
            Communication.Instance.KreitajVaspitaca(v);
            txtIme.Text = null;
            txtPrezime.Text = null;
            txtPol.Text = null;
            txtKontakt.Text = null;



        }
        private bool ValidacijaDodajVaspitača()
        {
            bool uspesno = true;
            if (string.IsNullOrEmpty(txtIme.Text))
            {
                MessageBox.Show("Niste uneli ime vaspitača!");
                uspesno = false;
            }
            if (string.IsNullOrEmpty(txtPrezime.Text))
            {
                MessageBox.Show("Niste uneli prezime vaspitača!");
                uspesno = false;
            }
            if (string.IsNullOrEmpty(txtPol.Text))
            {
                MessageBox.Show("Niste uneli pol vaspitača!");
                uspesno = false;
            }
            if (string.IsNullOrEmpty(txtKontakt.Text))
            {
                MessageBox.Show("Niste uneli kontakt telefon vaspitača vaspitača!");
                uspesno = false;
            }
            if (cbProgram.SelectedItem == null)
            {
                MessageBox.Show("Niste odabrali program za koji je vaspitač zadužen!");
                uspesno = false;
            }
            return uspesno;
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            string kriterijum = "";
            if (txtPretraga.Text != null)
            {
                string pretraga = txtPretraga.Text;
                kriterijum = $"where p.Naziv='{pretraga}'";
                listavaspitaca = new BindingList<Vaspitač>(Communication.Instance.VratiVaspitacePoKriterijumu(kriterijum));
                dataGridView1.DataSource = listavaspitaca;

            }
        }
        public Vaspitač izabraniRed { get; set; }
        private void btnPrikaziDetljnije_Click(object sender, EventArgs e)
        {
           
            if (dataGridView1.SelectedRows.Count==0)
            {
                MessageBox.Show("Niste izabrali kog vaspitača želite da izamenite!");
                return;
            }
            izabraniRed = (Vaspitač)dataGridView1.SelectedRows[0].DataBoundItem;
            btnDodajVaspitača.Enabled = false;
           
            txtIme.Text = izabraniRed.Ime;
            txtPrezime.Text = izabraniRed.Prezime;
            txtPol.Text = izabraniRed.Pol;
            txtKontakt.Text = izabraniRed.Kontakt;
            cbProgram.SelectedItem = izabraniRed.Program;

        }

        /// <summary>
        /// OSMISLI VALIDACIJU VASPITACA MALO BOLJE
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIzmeniVaspitača_Click(object sender, EventArgs e)
        {
            //if (!ValidacijaIzmeniVaspitača())
           // {
             //   return;
            //}
            izabraniRed.Kontakt = txtKontakt.Text;
            izabraniRed.Program = (Domain.Program)cbProgram.SelectedItem;
            dataGridView1.Refresh();
            if (Communication.Instance.SacuvajIzmenjenogVaspitaca(izabraniRed) == true)
            {
                MessageBox.Show("Sistem je zapamtio izmenjenog vaspitača!");
            }
            else
            {
                MessageBox.Show("Sistem ne može da zapamti izmenjenog vaspitača!");
            }
            txtIme.Text = null;
            txtPrezime.Text = null;
            txtPol.Text = null;
            txtKontakt.Text = null;
            btnDodajVaspitača.Enabled = true;
        }
       /* private bool ValidacijaIzmeniVaspitača()
        {
            bool uspesno = true;
            if(txtIme.Text==izabraniRed.Ime && txtPrezime.Text==izabraniRed.Prezime&& txtPol.Text==izabraniRed.Pol &&txtKontakt.Text==izabraniRed.Kontakt && cbProgram.SelectedItem == izabraniRed.Program)
            {
                MessageBox.Show("Niste izmenili podatke o vaspitaču,sistem ne želi da zapamti iste podatke!");
                uspesno = false;
            }
            return uspesno;*/
        }
    }

