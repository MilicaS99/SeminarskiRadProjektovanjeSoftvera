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
    public partial class FormaPohadjanje : Form
    {
        public FormaPohadjanje()
        {
            InitializeComponent();
            cbUčenik.DataSource = Communication.Instance.VratiListuUčenika();
            cbGrupa.DataSource = Communication.Instance.VratiSveGrupe();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (!Validacija())
            {
                return;
            }
            Pohadjanje pohadjanje = new Pohadjanje();
            pohadjanje.Učenik = (Učenik)cbUčenik.SelectedItem;
            pohadjanje.Grupa = (Grupa)cbGrupa.SelectedItem;
            pohadjanje.DatumDo = DateTime.ParseExact(txtDatumDO.Text, "dd.MM.yyyy.", null);
            pohadjanje.DatumOd = DateTime.ParseExact(txtDatumOD.Text, "dd.MM.yyyy.", null);

            if (Communication.Instance.ZapamtiPohadjanje(pohadjanje)==true)
            {
                MessageBox.Show("Sistem je uspešno zapamtio pohadjanje!");
            }
            else
            {
                MessageBox.Show("Došlo je do greške prilikom pamćenja pohadjanja!");
            }
        }

        private bool Validacija()
        {
            bool ispravno = true;
            if (cbGrupa.SelectedItem == null)
            {
                MessageBox.Show("Morate da izaberete grupu!");
                ispravno= false;
            }
            else
            {
                ispravno= true;
            }
            if (cbUčenik.SelectedItem == null)
            {
                MessageBox.Show("Morate da izaberete učenika !");
                ispravno=false;
            }
            else
            {
                ispravno= true;
            }
            if (txtDatumOD.Text == null)
            {
                MessageBox.Show("Unesite DatumOD");
                ispravno=false;
            }
            else
            {
                ispravno= true;
            }
            if (txtDatumDO.Text== null)
            {
                MessageBox.Show("Unesite DatumDO");
                ispravno=false;
            }
            else
            {
                ispravno=true;
            }
            Učenik učenik = (Učenik)cbUčenik.SelectedItem;
            int brojgodina = DateTime.Now.Year - učenik.DatumRodjenja.Year;
            Grupa grupa = (Grupa)cbGrupa.SelectedItem;
            if (brojgodina != (int)grupa.Uzrast+3)
            {
                MessageBox.Show("Učenik ne može da pripada ovoj starosnoj grupi!");
                ispravno= false;
            }
            return ispravno;
        }
    }
}
