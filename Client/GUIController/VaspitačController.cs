using Client.Exceptions;
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
            //formaVaspitač.CbProgram.DataSource = Communication.Instance.VratiListuPrograma();

            formaVaspitač.CbProgram.DataSource = Communication.Instance.PosaljiZahtevVratiRezultat<List<Domain.Program>>(Common.Operation.UčitajListuPrograma);
            
            // listavaspitaca = new BindingList<Vaspitač>(Communication.Instance.VratiSveVaspitače());
            listavaspitaca= new BindingList<Vaspitač>(Communication.Instance.PosaljiZahtevVratiRezultat<List<Vaspitač>>(Common.Operation.UčitajListuVaspitača));

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
            try {
               //Communication.Instance.KreirajVaspitaca(v);
               Communication.Instance.PosaljiZahtevBezRezultata(Common.Operation.ZapamtiVaspitača, v);
               //MessageBox.Show($"{v.Ime} {v.Prezime},Vaspitač je zapamćen u sistem!");
            }
            catch (SystemOperationException m)
            {
                MessageBox.Show(m.Message);
            }
            
            formaVaspitač.TxtIme.Text= null;
            formaVaspitač.TxtPrezime.Text = null;
            formaVaspitač.TxtPol.Text = null;
            formaVaspitač.TxtKontakt.Text = null;
        }

        private bool ValidacijaDodajVaspitača(FormaVaspitač formaVaspitač)
        {
            bool uspesno = true;
            if (formaVaspitač.TxtIme.Text=="Ime")
            {
                MessageBox.Show("Niste uneli ime vaspitača!");
                formaVaspitač.TxtIme.BackColor = Color.DarkSalmon;
                uspesno = false;
            }
            if (formaVaspitač.TxtPrezime.Text=="Prezime")
            {
                MessageBox.Show("Niste uneli prezime vaspitača!");
                formaVaspitač.TxtPrezime.BackColor = Color.DarkSalmon;
                uspesno = false;
            }
            if (formaVaspitač.TxtPol.Text=="Pol")
            {
                MessageBox.Show("Niste uneli pol vaspitača!");
                formaVaspitač.TxtPol.BackColor = Color.DarkSalmon;
                uspesno = false;
            }
            if (formaVaspitač.TxtKontakt.Text=="06XXXXXXXX")
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
                try
                {
                    // listavaspitaca = new BindingList<Vaspitač>(Communication.Instance.VratiVaspitacePoKriterijumu(kriterijum));
                    listavaspitaca = new BindingList<Vaspitač>(Communication.Instance.PosaljiZahtevVratiRezultat<List<Vaspitač>>(Common.Operation.PretražiVaspitača, kriterijum));
                    System.Windows.Forms.MessageBox.Show("Sistem je našao vaspitače po zadatoj vrednosti!");
                }
                catch(SystemOperationException ex)
                {
                    MessageBox.Show(ex.Message);
                }
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
            try
            {
                // izabraniRed = Communication.Instance.UcitajVaspitaca((Vaspitač)formaVaspitač.DataGridView1.SelectedRows[0].DataBoundItem);
                izabraniRed = Communication.Instance.PosaljiZahtevVratiRezultat<Vaspitač>(Common.Operation.UcitajVaspitaca, (Vaspitač)formaVaspitač.DataGridView1.SelectedRows[0].DataBoundItem);
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }

            formaVaspitač.BtnDodajVaspitača.Enabled = true;

            formaVaspitač.TxtIme.Text= izabraniRed.Ime;
            formaVaspitač.TxtPrezime.Text = izabraniRed.Prezime;
            formaVaspitač.TxtPol.Text  = izabraniRed.Pol;
            formaVaspitač.TxtKontakt.Text  = izabraniRed.Kontakt;
            formaVaspitač.CbProgram.SelectedItem = izabraniRed.Program;
       
        }

        internal void IzmeniVaspitaca(FormaVaspitač formaVaspitač)
        {
            izabraniRed.Kontakt = formaVaspitač.TxtKontakt.Text;
            izabraniRed.Program = (Domain.Program)formaVaspitač.CbProgram.SelectedItem;
            formaVaspitač.DataGridView1.Refresh();
            try
            {
                Communication.Instance.PosaljiZahtevBezRezultata( Common.Operation.zapamtiNovogVaspitača,izabraniRed);
                MessageBox.Show("Sistem je zapamtio izmenjenog vaspitača!");

            }
            catch(SystemOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            /*if (Communication.Instance.SacuvajIzmenjenogVaspitaca(izabraniRed) == true)
            {
                MessageBox.Show("Sistem je zapamtio izmenjenog vaspitača!");
            }
            else
            {
                MessageBox.Show("Sistem ne može da zapamti izmenjenog vaspitača!");
            }*/

            ocistiFormu(formaVaspitač);
        }
        private void ocistiFormu(FormaVaspitač formaVaspitač)
        {
            formaVaspitač.TxtIme.Text = null;
            formaVaspitač.TxtPrezime.Text = null;
            formaVaspitač.TxtPol.Text = null;
            formaVaspitač.TxtKontakt.Text = null;
            formaVaspitač.BtnDodajVaspitača.Enabled = true;
        }

        internal void obrisiVaspitaca(FormaVaspitač formaVaspitač)
        {
            try
            {
                Communication.Instance.PosaljiZahtevBezRezultata(Common.Operation.ObisiVaspitaca, izabraniRed);
                MessageBox.Show("Sistem je obrisao vaspitaca");
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        internal void dodajPHime(FormaVaspitač formaVaspitač)
        {
            if (formaVaspitač.TxtIme.Text == "Ime")
            {
                formaVaspitač.TxtIme.Text = "";
            }
        }

        internal void skloniPHime(FormaVaspitač formaVaspitač)
        {
            if (formaVaspitač.TxtIme.Text == "")
            {
                formaVaspitač.TxtIme.Text = "Ime";
            }
        }

        internal void dodajPHprezime(FormaVaspitač formaVaspitač)
        {
            if (formaVaspitač.TxtPrezime.Text == "Prezime")
            {
                formaVaspitač.TxtPrezime.Text = "";
            }
        }

        internal void skloniPHprezime(FormaVaspitač formaVaspitač)
        {
            if (formaVaspitač.TxtPrezime.Text == "")
            {
                formaVaspitač.TxtPrezime.Text = "Prezime";
            }
        }

        internal void skloniPHpol(FormaVaspitač formaVaspitač)
        {
            if (formaVaspitač.TxtPol.Text == "")
            {
                formaVaspitač.TxtPol.Text = "Pol";
            }
        }

        internal void skloniPHkonakttelefn(FormaVaspitač formaVaspitač)
        {
            if (formaVaspitač.TxtKontakt.Text == "")
            {
                formaVaspitač.TxtKontakt.Text = "06XXXXXXXX";
            }
        }

        internal void dodajphUnesiteProgram(FormaVaspitač formaVaspitač)
        {
           if(formaVaspitač.TxtPretraga.Text== "Unesite program")
            {
                formaVaspitač.TxtPretraga.Text = "";
            }
        }

        internal void InicijalizujDGV(FormaVaspitač formaVaspitač)
        {
            //listavaspitaca = new BindingList<Vaspitač>(Communication.Instance.VratiSveVaspitače());
            listavaspitaca = new BindingList<Vaspitač>(Communication.Instance.PosaljiZahtevVratiRezultat<List<Vaspitač>>(Common.Operation.UčitajListuVaspitača));
            formaVaspitač.DataGridView1.DataSource = listavaspitaca;
        }

        internal void skloniPHunesiteProgram(FormaVaspitač formaVaspitač)
        {
            if (formaVaspitač.TxtPretraga.Text == "")
            {
                formaVaspitač.TxtPretraga.Text = "Unesite program";
            }
        }

        internal void dodajPHkontakttelefon(FormaVaspitač formaVaspitač)
        {
            if(formaVaspitač.TxtKontakt.Text== "06XXXXXXXX")
            {
                formaVaspitač.TxtKontakt.Text = "";
            }
        }

        internal void dodajPHpol(FormaVaspitač formaVaspitač)
        {
            if (formaVaspitač.TxtPol.Text == "Pol")
            {
                formaVaspitač.TxtPol.Text = "";
            }
        }
    }
}
