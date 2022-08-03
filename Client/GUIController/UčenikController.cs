using Client.Exceptions;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.GUIController
{
    public class UčenikController
    {
        BindingList<Učenik> listaucenika;
        internal void Inicijalizuj(FormaUčenik formaUčenik)
        {
            // listaucenika = new BindingList<Učenik>(Communication.Instance.VratiListuUčenika());
            listaucenika = new BindingList<Učenik>(Communication.Instance.PosaljiZahtevVratiRezultat<List<Učenik>>(Common.Operation.UčitajListuUčenika));
            formaUčenik.DataGridView1.DataSource = listaucenika;
        }

        internal void SacuvajUcenika(FormaUčenik formaUčenik)
        {
           formaUčenik.DialogResult = DialogResult.OK;
            if (!Validacija(formaUčenik))
            {
                return;
            }

         
            Učenik ucenik = new Učenik();
            ucenik.Ime = formaUčenik.TxtIme.Text;
            ucenik.Prezime = formaUčenik.TxtPrezime.Text;
            ucenik.DatumRodjenja = DateTime.ParseExact(formaUčenik.TxtDatumRodjenja.Text, "dd.MM.yyyy. HH:mm", null);
            ucenik.Pol = formaUčenik.TxtPol.Text;
            ucenik.TelefonRoditelja =formaUčenik.TxtKontaktRoditelja .Text;

            try {
                //Communication.Instance.SacuvajUcenika(ucenik);
                Communication.Instance.PosaljiZahtevBezRezultata(Common.Operation.ZapamtiUčenika, ucenik);
                System.Windows.Forms.MessageBox.Show($"{ucenik.Ime} {ucenik.Prezime},Učenik je zapamćen u sistem!");
            }catch(SystemOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private bool Validacija(FormaUčenik formaUčenik)
        {
            bool uspesno = true;
            if (formaUčenik.TxtIme.Text=="Ime")
            {
                MessageBox.Show("Niste uneli ime učenika!");
                formaUčenik.TxtIme.BackColor = Color.Salmon;
                uspesno = false;
            }
            if (formaUčenik.TxtPrezime.Text=="Prezime")
            {
                MessageBox.Show("Niste uneli prezime učenika!");
                formaUčenik.TxtPrezime.BackColor = Color.Salmon;
                uspesno = false;
            }
            if (!DateTime.TryParseExact(formaUčenik.TxtDatumRodjenja.Text, "dd.MM.yyyy. HH:mm", null, DateTimeStyles.None, out _) )
            {
                MessageBox.Show("Niste uneli datum rodjenja učenika!");
                formaUčenik.TxtDatumRodjenja.BackColor = Color.Salmon;
                uspesno = false;
            }
            if (formaUčenik.TxtPol.Text=="Pol")
            {
                MessageBox.Show("Niste uneli pol učenika!");
                formaUčenik.TxtPol.BackColor = Color.Salmon;
                uspesno = false;
            }
            if (formaUčenik.TxtKontaktRoditelja.Text=="KontaktRoditelja")
            {
                formaUčenik.TxtKontaktRoditelja.BackColor = Color.Salmon;
                MessageBox.Show("Niste uneli kontakt telefon roditelja učenika!");
                uspesno = false;
            }
            return uspesno;
        }

        internal void Pretrazi(FormaUčenik formaUčenik)
        {
            resetujFormu(formaUčenik);
            string kriterijum = "";
            string pokupljenkriterijum = formaUčenik.TxtPretraga.Text;
                kriterijum = pokupljenkriterijum;

            try
            {
                // formaUčenik.DataGridView1.DataSource = Communication.Instance.PretragaUčenika(kriterijum);
                formaUčenik.DataGridView1.DataSource = Communication.Instance.PosaljiZahtevVratiRezultat<List<Učenik>>(Common.Operation.PretražiUčenike, kriterijum);
                // System.Windows.Forms.MessageBox.Show("Sistem je našao učenike po zadatoj vrednosti!");
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }


            
        }

        private void resetujFormu(FormaUčenik formaUčenik)
        {
            formaUčenik.BtnSacuvajUcenika.Enabled = true;
            formaUčenik.TxtIme.Text = "Ime";
            formaUčenik.TxtPrezime.Text = "Prezime";
            formaUčenik.TxtDatumRodjenja.Text = "dd.MM.yyyy. HH:mm";
            formaUčenik.TxtPol.Text = "Pol";
            formaUčenik.TxtKontaktRoditelja.Text = "KontaktRoditelja";

        }

        public Učenik izabraniUčenik { get; set; }
        internal void prikaziDetalje(FormaUčenik formaUčenik)
        {
            if (formaUčenik.DataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Niste izebrali nijedan red!");
                    return;
            }
            // izabraniUčenik = Communication.Instance.UcitajUcenika((Učenik)formaUčenik.DataGridView1.SelectedRows[0].DataBoundItem);

            try
            {
                izabraniUčenik = Communication.Instance.PosaljiZahtevVratiRezultat<Učenik>(Common.Operation.UcitajUcenika, (Učenik)formaUčenik.DataGridView1.SelectedRows[0].DataBoundItem);

            }catch(SystemOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }

            

          
            formaUčenik.TxtIme.Text = izabraniUčenik.Ime;
            formaUčenik.TxtPrezime.Text = izabraniUčenik.Prezime;
           formaUčenik.TxtDatumRodjenja.Text = izabraniUčenik.DatumRodjenja.ToString();
           // formaUčenik.TxtDatumRodjenja.Text = DateTime.ParseExact(izabraniUčenik.DatumRodjenja.ToString(), "MM/dd/yyyy HH:mm:ss tt ", null).ToString();
            formaUčenik.TxtPol.Text = izabraniUčenik.Pol;
            formaUčenik.TxtKontaktRoditelja.Text = izabraniUčenik.TelefonRoditelja;

            formaUčenik.BtnSacuvajUcenika.Enabled = false;

        }

        internal void prikaziDatumRodjenjaPH(FormaUčenik formaUčenik)
        {
            if(formaUčenik.TxtDatumRodjenja.Text=="dd.MM.yyyy. HH:mm")
            {
                formaUčenik.TxtDatumRodjenja.Text = "";
            }
        }

        internal void prikaziPolPH(FormaUčenik formaUčenik)
        {
            if (formaUčenik.TxtPol.Text == "Pol")
            {
                formaUčenik.TxtPol.Text = "";
            }
        }

        internal void prikaziKontakRoditeljaPH(FormaUčenik formaUčenik)
        {
            if (formaUčenik.TxtKontaktRoditelja.Text == "KontaktRoditelja")
            {
                formaUčenik.TxtKontaktRoditelja.Text = "";
            }
        }

        internal void ukloniKontaktRoditeljaPH(FormaUčenik formaUčenik)
        {
            if (formaUčenik.TxtKontaktRoditelja.Text == "")
            {
                formaUčenik.TxtKontaktRoditelja.Text = "KontaktRoditelja";
            }
        }

        internal void ukloniImeUcenikaPH(FormaUčenik formaUčenik)
        {
            if (formaUčenik.TxtPretraga.Text == "")
            {
                formaUčenik.TxtPretraga.Text = "Ime ucenika";
            }
        }

        internal void InicijalitujDGV(FormaUčenik formaUčenik)
        {
            formaUčenik.DataGridView1.DataSource = listaucenika;
            formaUčenik.TxtPretraga.Text = null;
        }

        internal void prikaziImeUcenikaPH(FormaUčenik formaUčenik)
        {
            if(formaUčenik.TxtPretraga.Text=="Ime ucenika")
            {
                formaUčenik.TxtPretraga.Text = "";
            }
        }

        internal void ukloniPolPH(FormaUčenik formaUčenik)
        {
            if (formaUčenik.TxtPol.Text == "")
            {
                formaUčenik.TxtPol.Text = "Pol";
            }
        }

        internal void ukloniDatumRodjenjaPH(FormaUčenik formaUčenik)
        {
            if (formaUčenik.TxtDatumRodjenja.Text == "")
            {
                formaUčenik.TxtDatumRodjenja.Text = "dd.MM.yyyy. HH:mm";
            }
        }

        internal void ukloniPrezimePH(FormaUčenik formaUčenik)
        {
            if (formaUčenik.TxtPrezime.Text == "")
            {
                formaUčenik.TxtPrezime.Text = "Prezime";
            }
        }

        internal void prikatiPrezimePH(FormaUčenik formaUčenik)
        {
            if (formaUčenik.TxtPrezime.Text == "Prezime")
            {
                formaUčenik.TxtPrezime.Text = "";
            }
        }

        internal void ukloniImePH(FormaUčenik formaUčenik)
        {
            if (formaUčenik.TxtIme.Text == "")
            {
                formaUčenik.TxtIme.Text = "Ime";
            }
        }

        internal void prikaziImePH(FormaUčenik formaUčenik)
        {
            if (formaUčenik.TxtIme.Text == "Ime")
            {
                formaUčenik.TxtIme.Text = "";
            }
        }
    }
}
