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
    public partial class FormaGrupa : Form
    {
        private GrupaController grupacontroller = new GrupaController();
        
        public FormaGrupa()
        {
            InitializeComponent();

             Inicijalizuj();
            #region inicijalizacija
            /* cbUzrast.DataSource = Communication.Instance.VratiSveUzraste();
            cbProgram.DataSource = Communication.Instance.VratiListuPrograma();
            cbVaspitač.DataSource = Communication.Instance.VratiSveVaspitače();
            cbUčenik.DataSource = Communication.Instance.VratiListuUčenika();*/
            #endregion


        }

        private void Inicijalizuj()
        {
            grupacontroller.Inicijalizuj(this);
        }

    


  
        private void btnPrikaziDetalje_Click(object sender, EventArgs e)
        {

            grupacontroller.prikaziDetaljnije(this);

            #region prikazidetaljnije

            /* if (dgvGrupe.SelectedRows.Count == 0)
             {
                 MessageBox.Show("Niste izabrali željenu grupu!");
                 return;
             }
             izabranoPohadjanje = (Pohadjanje)dgvGrupe.SelectedRows[0].DataBoundItem;

             izabranaGrupa = Communication.Instance.VratiTrazenuGrupu(izabranoPohadjanje.Grupa);
             txtNaziv.Text = izabranoPohadjanje.Grupa.NazivGrupe;
             cbUzrast.SelectedItem = izabranaGrupa.Uzrast;
             cbProgram.SelectedItem = izabranaGrupa.Program;
             cbVaspitač.SelectedItem = izabranaGrupa.Vaspitač;

             cbUčenik.SelectedItem = izabranoPohadjanje.Učenik;
             txtDatumOD.Text = izabranoPohadjanje.DatumOd.ToString();
             txtDatumDO.Text = izabranoPohadjanje.DatumDo.ToString();*/
            #endregion




        }

        private void btnZapamtiNovuGrupu_Click(object sender, EventArgs e)
        {

            grupacontroller.ZapamtiNovuGrupu(this);
            #region zapamti novu grupu
            /*
            if (!Provera())
            {
                return;
            }
            izabranaGrupa.NazivGrupe = txtNaziv.Text;
            izabranaGrupa.Uzrast =(Uzrast) cbUzrast.SelectedItem;
            izabranaGrupa.Program = (Domain.Program)cbProgram.SelectedItem;
            izabranaGrupa.Vaspitač = (Vaspitač)cbVaspitač.SelectedItem;
            dgvGrupe.Refresh();
            if (Communication.Instance.SacuvajNovuGrupu(izabranaGrupa,pohadjanja) == true)
            {
                MessageBox.Show("Sistem je zapamtio novu grupu!");
            }
            else
            {
                MessageBox.Show("Sistem ne može da zapamti novu grupu!");
            }

            btnZapamtiNovuGrupu.Enabled = true;*/
            #endregion
        }

        private void btnZapamtiGrupu_Click(object sender, EventArgs e)
        {

            grupacontroller.ZapamtiGrupu(this);

            #region zapamti grupu

            /*Grupa grupa = new Grupa();

            if (!Provera())
            {
                return;
            }

            grupa.NazivGrupe = txtNaziv.Text;
            grupa.Uzrast = (Uzrast)cbUzrast.SelectedItem;
            grupa.Program = (Domain.Program)cbProgram.SelectedItem;
            grupa.Vaspitač = (Domain.Vaspitač)cbVaspitač.SelectedItem;


            if (Communication.Instance.SacuvajGrupu(grupa,pohadjanja) == true)
            {
                MessageBox.Show($"{grupa.NazivGrupe}, Sistem je zapamtio grupu!");
            }
            else
            {
                MessageBox.Show("Sistem ne može da zapamti grupu!");
            }

            txtNaziv.Text = null;
            txtDatumOD.Text = null;
            txtDatumDO.Text = null;*/
            #endregion

        }
        #region provera dodaj ucenika
        /*
        private bool ProveraDodajUcenika()
        {
            bool ispravno = true;

            if (cbUčenik.SelectedItem == null)
            {
                MessageBox.Show("Neophodno je izabrati UČENIKA!");
                ispravno = false;
            }
           
            if (string.IsNullOrEmpty(txtDatumOD.Text))
            {
                MessageBox.Show("Niste unelili DATUMOD!");
                txtDatumOD.BackColor = Color.Salmon;
                ispravno = false;
            }
            
            
            if (string.IsNullOrEmpty(txtDatumDO.Text))
            {
                MessageBox.Show("Niste uneli DATUMDO!");
                txtDatumDO.BackColor = Color.Salmon;
                ispravno = false;
            }
           

            return ispravno;
        }*/
        #endregion

        private void btnDodajUcenika_Click(object sender, EventArgs e)
        {
            grupacontroller.dodajUcenika(this);
            #region dodaj ucenika
            /*
            if (!ProveraDodajUcenika())
            {
                return;
            }
            Pohadjanje p = new Pohadjanje();
            p.Učenik = (Učenik)cbUčenik.SelectedItem;
            p.DatumOd = DateTime.ParseExact(txtDatumOD.Text, "dd.MM.yyyy.", null);
            p.DatumDo = DateTime.ParseExact(txtDatumDO.Text, "dd.MM.yyyy.", null);
        
            pohadjanja.Add(p);
            MessageBox.Show($"Dodali ste učenika {p.Učenik.Ime} {p.Učenik.Prezime}");*/
            #endregion
        }

        
       private void btnObrisiUcenika_Click(object sender, EventArgs e)
        {
            grupacontroller.ObrisiUcenika(this);
        
        }
    
    

        private void cbProgram_SelectedValueChanged(object sender, EventArgs e)
        {
            grupacontroller.VaspitaciNaProgramu(this);
            #region
           // cbVaspitač.DataSource = Communication.Instance.VratiVaspitačeNaProgramu(cbProgram.SelectedItem as Domain.Program);
            #endregion
        }

        private void cbUčenik_SelectedValueChanged(object sender, EventArgs e)
        {
            grupacontroller.ResetujDatume(this);

            #region
            /* txtDatumOD.Text = null;
             txtDatumDO.Text = null;*/
            #endregion
        }

        private void txtPretraga_MouseClick(object sender, MouseEventArgs e)
        {
            grupacontroller.ResetujDataGridPrikazPretraga(this);
        }

        private void txtNaziv_Enter(object sender, EventArgs e)
        {
            grupacontroller.UnosNazivaGrupeEvent(this);
        }

        private void txtNaziv_Leave(object sender, EventArgs e)
        {
            grupacontroller.NapustanjePoljaNazivaGrupe(this);
        }

        private void txtDatumOD_Enter(object sender, EventArgs e)
        {
            grupacontroller.UnosDatumOdEvent(this);
        }

        private void txtDatumOD_Leave(object sender, EventArgs e)
        {
            grupacontroller.NapustanjePoljaDatumODevent(this);
        }

        private void txtPretraga_Enter(object sender, EventArgs e)
        {
            grupacontroller.UnosPretrageEvent(this);
        }

        private void txtPretraga_Leave(object sender, EventArgs e)
        {
            grupacontroller.NapustanjePretrageEvent(this);
        }

        private void txtDatumDO_Enter(object sender, EventArgs e)
        {

            grupacontroller.UnosDatumaDO(this);

        }

        private void txtDatumDO_Leave(object sender, EventArgs e)
        {
            grupacontroller.NapustanjeDatumaDOevent(this);
        }

        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            grupacontroller.Pretrazi(this);
        }
    }
}
