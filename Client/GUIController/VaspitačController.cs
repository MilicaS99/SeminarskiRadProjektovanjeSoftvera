using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.GUIController
{
    public class VaspitačController
    {
        BindingList<Vaspitač> listavaspitaca;
        internal void Inicijalizuj(FormaVaspitač formaVaspitač)
        {
           formaVaspitač.CbProgram.DataSource = Communication.Instance.VratiListuPrograma();
            listavaspitaca = new BindingList<Vaspitač>(Communication.Instance.VratiSveVaspitače());
           formaVaspitač.DataGridView1.DataSource = listavaspitaca;
        }

        internal void DodajVaspitaca(FormaVaspitač formaVaspitač)
        {
            formaVaspitač.DialogResult = DialogResult.OK;

            if (!ValidacijaDodajVaspitača(formaVaspitač))
            {
                return;
            }

            Vaspitač v = new Vaspitač();
            v.Ime = formaVaspitač.TxtIme.Text;
            v.Prezime = formaVaspitač.TxtPrezime.Text;
            v.Pol = formaVaspitač.TxtPol.Text;
            v.Kontakt = formaVaspitač.TxtKontakt.Text;
            v.Program = (Domain.Program)formaVaspitač.CbProgram.SelectedItem;
            Communication.Instance.KreitajVaspitaca(v);
            formaVaspitač.TxtIme.Text= null;
            formaVaspitač.TxtPrezime.Text = null;
            formaVaspitač.TxtPol.Text = null;
            formaVaspitač.TxtKontakt.Text = null;
        }

        private bool ValidacijaDodajVaspitača(FormaVaspitač formaVaspitač)
        {
            bool uspesno = true;
            if (string.IsNullOrEmpty(formaVaspitač.TxtIme.Text))
            {
                MessageBox.Show("Niste uneli ime vaspitača!");
                formaVaspitač.TxtIme.BackColor = Color.DarkSalmon;
                uspesno = false;
            }
            if (string.IsNullOrEmpty(formaVaspitač.TxtPrezime.Text))
            {
                MessageBox.Show("Niste uneli prezime vaspitača!");
                formaVaspitač.TxtPrezime.BackColor = Color.DarkSalmon;
                uspesno = false;
            }
            if (string.IsNullOrEmpty(formaVaspitač.TxtPol.Text))
            {
                MessageBox.Show("Niste uneli pol vaspitača!");
                formaVaspitač.TxtPol.BackColor = Color.DarkSalmon;
                uspesno = false;
            }
            if (string.IsNullOrEmpty(formaVaspitač.TxtKontakt.Text))
            {
                MessageBox.Show("Niste uneli kontakt telefon vaspitača vaspitača!");
                formaVaspitač.TxtKontakt.BackColor = Color.DarkSalmon;
                uspesno = false;
            }
            if (formaVaspitač.CbProgram.SelectedItem == null)
            {
                MessageBox.Show("Niste odabrali program za koji je vaspitač zadužen!");
                uspesno = false;
            }

            return uspesno;
        }

        internal void Pretrazi(FormaVaspitač formaVaspitač)
        {
            string kriterijum = "";
            if (string.IsNullOrEmpty(formaVaspitač.TxtPretraga.Text) == true)
            {
                MessageBox.Show("Niste uneli kriterijum za pretragu!");
                formaVaspitač.TxtPretraga.BackColor = Color.Salmon;
            }
            else
            {
                string pretraga = formaVaspitač.TxtPretraga.Text;
                //kriterijum = $"where p.Naziv='{pretraga}'";
                kriterijum = pretraga;
                listavaspitaca = new BindingList<Vaspitač>(Communication.Instance.VratiVaspitacePoKriterijumu(kriterijum));
                formaVaspitač.DataGridView1.DataSource = listavaspitaca;

            }
        }

        public Vaspitač izabraniRed { get; set; }
        internal void PrikaziDetaljnije(FormaVaspitač formaVaspitač)
        {
            if (formaVaspitač.DataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Niste izabrali kog vaspitača želite da izamenite!");
                return;
            }
            // izabraniRed = (Vaspitač)formaVaspitač.DataGridView1.SelectedRows[0].DataBoundItem;
            izabraniRed = Communication.Instance.UcitajVaspitaca((Vaspitač)formaVaspitač.DataGridView1.SelectedRows[0].DataBoundItem);
            formaVaspitač.BtnDodajVaspitača.Enabled = false;

            formaVaspitač.TxtIme.Text= izabraniRed.Ime;
            formaVaspitač.TxtPrezime.Text = izabraniRed.Prezime;
            formaVaspitač.TxtPol.Text  = izabraniRed.Pol;
            formaVaspitač.TxtKontakt.Text  = izabraniRed.Kontakt;
            formaVaspitač.CbProgram.SelectedItem = izabraniRed.Program;
            formaVaspitač.TxtKontakt.BackColor  = Color.Coral;
            formaVaspitač.CbProgram.BackColor = Color.Coral;
        }

        internal void IzmeniVaspitaca(FormaVaspitač formaVaspitač)
        {
            izabraniRed.Kontakt = formaVaspitač.TxtKontakt.Text;
            izabraniRed.Program = (Domain.Program)formaVaspitač.CbProgram.SelectedItem;
            formaVaspitač.DataGridView1.Refresh();
            if (Communication.Instance.SacuvajIzmenjenogVaspitaca(izabraniRed) == true)
            {
                MessageBox.Show("Sistem je zapamtio izmenjenog vaspitača!");
            }
            else
            {
                MessageBox.Show("Sistem ne može da zapamti izmenjenog vaspitača!");
            }
            formaVaspitač.TxtIme.Text = null;
            formaVaspitač.TxtPrezime.Text = null;
            formaVaspitač.TxtPol.Text = null;
            formaVaspitač.TxtKontakt.Text = null;
            formaVaspitač.BtnDodajVaspitača.Enabled = true;
        }
    }
}
