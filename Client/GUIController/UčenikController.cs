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
    public class UčenikController
    {
        BindingList<Učenik> listaucenika;
        internal void Inicijalizuj(FormaUčenik formaUčenik)
        {
            listaucenika = new BindingList<Učenik>(Communication.Instance.VratiListuUčenika());
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
            Communication.Instance.SacuvajUcenika(ucenik);
        }

        private bool Validacija(FormaUčenik formaUčenik)
        {
            bool uspesno = true;
            if (string.IsNullOrEmpty(formaUčenik.TxtIme.Text))
            {
                MessageBox.Show("Niste uneli ime učenika!");
                formaUčenik.TxtIme.BackColor = Color.Salmon;
                uspesno = false;
            }
            if (string.IsNullOrEmpty(formaUčenik.TxtPrezime.Text))
            {
                MessageBox.Show("Niste uneli prezime učenika!");
                formaUčenik.TxtPrezime.BackColor = Color.Salmon;
                uspesno = false;
            }
            if (string.IsNullOrEmpty(formaUčenik.TxtDatumRodjenja.Text))
            {
                MessageBox.Show("Niste uneli datum rodjenja učenika!");
                formaUčenik.TxtDatumRodjenja.BackColor = Color.Salmon;
                uspesno = false;
            }
            if (string.IsNullOrEmpty(formaUčenik.TxtPol.Text))
            {
                MessageBox.Show("Niste uneli pol učenika!");
                formaUčenik.TxtPol.BackColor = Color.Salmon;
                uspesno = false;
            }
            if (string.IsNullOrEmpty(formaUčenik.TxtKontaktRoditelja.Text))
            {
                formaUčenik.TxtKontaktRoditelja.BackColor = Color.Salmon;
                MessageBox.Show("Niste uneli kontakt telefon roditelja učenika!");
                uspesno = false;
            }
            return uspesno;
        }

        internal void Pretrazi(FormaUčenik formaUčenik)
        {
            string kriterijum = "";
            if (string.IsNullOrEmpty(formaUčenik.TxtPretraga.Text) == true)
            {
                MessageBox.Show("Niste uneli kriterijum za pretragu!");
                formaUčenik.TxtPretraga.BackColor = Color.Salmon;
            }else
            {
                string pokupljenkriterijum = formaUčenik.TxtPretraga.Text;
                kriterijum = pokupljenkriterijum;
               formaUčenik.DataGridView1.DataSource = Communication.Instance.PretragaUčenika(kriterijum);


            }
        }

        public Učenik izabraniUčenik { get; set; }
        internal void prikaziDetalje(FormaUčenik formaUčenik)
        {
            if (formaUčenik.DataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Niste izebrali nijedan red!");
                    return;
            }
            izabraniUčenik = Communication.Instance.UcitajUcenika((Učenik)formaUčenik.DataGridView1.SelectedRows[0].DataBoundItem);
            formaUčenik.TxtIme.Text = izabraniUčenik.Ime;
            formaUčenik.TxtPrezime.Text = izabraniUčenik.Prezime;
            formaUčenik.TxtDatumRodjenja.Text = izabraniUčenik.DatumRodjenja.ToString();
            formaUčenik.TxtPol.Text = izabraniUčenik.Pol;
            formaUčenik.TxtKontaktRoditelja.Text = izabraniUčenik.TelefonRoditelja;

        }
    }
}
