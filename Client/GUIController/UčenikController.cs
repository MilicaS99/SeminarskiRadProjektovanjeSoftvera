using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
                uspesno = false;
            }
            if (string.IsNullOrEmpty(formaUčenik.TxtPrezime.Text))
            {
                MessageBox.Show("Niste uneli prezime učenika!");
                uspesno = false;
            }
            if (string.IsNullOrEmpty(formaUčenik.TxtDatumRodjenja.Text))
            {
                MessageBox.Show("Niste uneli datum rodjenja učenika!");
                uspesno = false;
            }
            if (string.IsNullOrEmpty(formaUčenik.TxtPol.Text))
            {
                MessageBox.Show("Niste uneli pol učenika!");
                uspesno = false;
            }
            if (string.IsNullOrEmpty(formaUčenik.TxtKontaktRoditelja.Text))
            {
                MessageBox.Show("Niste uneli kontakt telefon roditelja učenika!");
                uspesno = false;
            }
            return uspesno;
        }

        internal void Pretrazi(FormaUčenik formaUčenik)
        {
            string kriterijum = "";
            if (formaUčenik.TxtPretraga.Text != null)
            {
                string pokupljenkriterijum = formaUčenik.TxtPretraga.Text;
                kriterijum = $"where Ime='{pokupljenkriterijum}'";
               formaUčenik.DataGridView1.DataSource = Communication.Instance.PretragaUčenika(kriterijum);


            }
        }
    }
}
