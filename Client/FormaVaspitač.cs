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
    public partial class FormaVaspitač : Form
    {
        VaspitačController vaspitackontroler = new VaspitačController();
        
        public FormaVaspitač()
        {
            InitializeComponent();
            Inicijalizuj();
            #region incijalizacija

            /* cbProgram.DataSource = Communication.Instance.VratiListuPrograma();
             listavaspitaca = new BindingList<Vaspitač>(Communication.Instance.VratiSveVaspitače());
             dataGridView1.DataSource = listavaspitaca;*/
            #endregion
        }

        private void Inicijalizuj()
        {
            vaspitackontroler.Inicijalizuj(this);
        }

        private void btnDodajVaspitača_Click(object sender, EventArgs e)
        {

            vaspitackontroler.DodajVaspitaca(this);
            #region dodajvaspitaca
            /* DialogResult = DialogResult.OK;

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
             txtKontakt.Text = null;*/
            #endregion



        }
        #region validacija
        /*
        private bool ValidacijaDodajVaspitača()
        {
            bool uspesno = true;
            if (string.IsNullOrEmpty(txtIme.Text))
            {
                MessageBox.Show("Niste uneli ime vaspitača!");
                txtIme.BackColor = Color.DarkSalmon;
                uspesno = false;
            }
            if (string.IsNullOrEmpty(txtPrezime.Text))
            {
                MessageBox.Show("Niste uneli prezime vaspitača!");
                txtPrezime.BackColor = Color.DarkSalmon;
                uspesno = false;
            }
            if (string.IsNullOrEmpty(txtPol.Text))
            {
                MessageBox.Show("Niste uneli pol vaspitača!");
                txtPol.BackColor = Color.DarkSalmon;
                uspesno = false;
            }
            if (string.IsNullOrEmpty(txtKontakt.Text))
            {
                MessageBox.Show("Niste uneli kontakt telefon vaspitača vaspitača!");
                txtKontakt.BackColor = Color.DarkSalmon;
                uspesno = false;
            }
            if (cbProgram.SelectedItem == null)
            {
                MessageBox.Show("Niste odabrali program za koji je vaspitač zadužen!");
                uspesno = false;
            }

            return uspesno;
        }*/
        #endregion

        private void btnPretrazi_Click(object sender, EventArgs e)
        {

            vaspitackontroler.Pretrazi(this);
            #region pretrazi
            /*
            string kriterijum = "";
            if (string.IsNullOrEmpty(txtPretraga.Text) == true)
            {
                MessageBox.Show("Niste uneli kriterijum za pretragu!");
                txtPretraga.BackColor = Color.Salmon;
            }
            else
            {
                string pretraga = txtPretraga.Text;
                kriterijum = $"where p.Naziv='{pretraga}'";
                listavaspitaca = new BindingList<Vaspitač>(Communication.Instance.VratiVaspitacePoKriterijumu(kriterijum));
                dataGridView1.DataSource = listavaspitaca;

            }*/
            #endregion
        }

        private void btnPrikaziDetljnije_Click(object sender, EventArgs e)
        {

            vaspitackontroler.PrikaziDetaljnije(this);
            #region prikazidetaljnije
            /* if (dataGridView1.SelectedRows.Count == 0)
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
             txtKontakt.BackColor = Color.Coral;
             cbProgram.BackColor = Color.Coral;*/
            #endregion


        }


        private void btnIzmeniVaspitača_Click(object sender, EventArgs e)
        {

            vaspitackontroler.IzmeniVaspitaca(this);

            #region izmeni
            /*izabraniRed.Kontakt = txtKontakt.Text;
            izabraniRed.Program = (Domain.Program)cbProgram.SelectedItem;
            //dataGridView1.Refresh();
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
            btnDodajVaspitača.Enabled = true;*/
            #endregion
        }

        private void txtIme_Enter(object sender, EventArgs e)
        {
            vaspitackontroler.dodajPHime(this);
        }

        private void txtIme_Leave(object sender, EventArgs e)
        {
            vaspitackontroler.skloniPHime(this);
        }

        private void txtPrezime_Enter(object sender, EventArgs e)
        {
            vaspitackontroler.dodajPHprezime(this);
        }

        private void txtPrezime_Leave(object sender, EventArgs e)
        {
            vaspitackontroler.skloniPHprezime(this);
        }

        private void txtPol_Enter(object sender, EventArgs e)
        {
            vaspitackontroler.dodajPHpol(this);
        }

        private void txtPol_Leave(object sender, EventArgs e)
        {
            vaspitackontroler.skloniPHpol(this);
        }

        private void txtKontakt_Enter(object sender, EventArgs e)
        {
            vaspitackontroler.dodajPHkontakttelefon(this);
        }

        private void txtKontakt_Leave(object sender, EventArgs e)
        {
            vaspitackontroler.skloniPHkonakttelefn(this);
        }

        private void txtPretraga_Enter(object sender, EventArgs e)
        {
            vaspitackontroler.dodajphUnesiteProgram(this);
        }

        private void txtPretraga_Leave(object sender, EventArgs e)
        {
            vaspitackontroler.skloniPHunesiteProgram(this);
        }

        private void txtPretraga_Click(object sender, EventArgs e)
        {
            vaspitackontroler.InicijalizujDGV(this);
        }

        private void btnobrisivaspitaca_Click(object sender, EventArgs e)
        {
            vaspitackontroler.obrisiVaspitaca(this);
        }
    }
}

