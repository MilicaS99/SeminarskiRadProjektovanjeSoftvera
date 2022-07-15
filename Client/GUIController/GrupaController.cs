using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Client.GUIController
{
    class GrupaController
    {
        BindingList<Grupa> grupe;
        BindingList<Pohadjanje> pohadjanje;


        internal void Inicijalizuj(FormaGrupa formaGrupa)
        {
            formaGrupa.CbUzrast.DataSource = Communication.Instance.VratiSveUzraste();
            formaGrupa.CbProgram.DataSource  = Communication.Instance.VratiListuPrograma();
            formaGrupa.CbVaspitač.DataSource  = Communication.Instance.VratiSveVaspitače();
            formaGrupa.CbUčenik.DataSource= Communication.Instance.VratiListuUčenika();
            pohadjanje = new BindingList<Pohadjanje>(Communication.Instance.VratiSvaPohadnja());
            formaGrupa.DgvGrupe.DataSource = pohadjanje;
            formaGrupa.DgvDodatiUcenici.DataSource = pohadjanja;
            formaGrupa.DgvDodatiUcenici.Columns["Grupa"].Visible = false;
           
            //formaGrupa.DgvDodatiUcenici.Columns[0].Visible = false;

            //formaGrupa.DgvDodatiUcenici.Columns["Učenik"].HeaderText = "Dodati učenici";

           // formaGrupa.DgvDodatiUcenici.Columns["Učenik"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;

        }

      

        internal void Osvezi(FormaGrupa formaGrupa)
        {
            pohadjanje = new BindingList<Pohadjanje>(Communication.Instance.VratiSvaPohadnja());
           formaGrupa.DgvGrupe.DataSource = pohadjanje;
        }

        internal void Pretrazi(FormaGrupa formaGrupa)
        {
            string kriterijum = "";
            if (string.IsNullOrEmpty(formaGrupa.TxtPretraga.Text) == true)
            {
                MessageBox.Show("Niste uneli kriterijum za pretragu!");
                formaGrupa.TxtPretraga.BackColor = Color.Salmon;
            }
            else
            {
                string pretraga = formaGrupa.TxtPretraga.Text;
                //kriterijum = $"where g.NazivGrupe='{pretraga}'";
                kriterijum = pretraga;
                pohadjanje = new BindingList<Pohadjanje>(Communication.Instance.PretragaGrupa(kriterijum));
               formaGrupa.DgvGrupe.DataSource  = pohadjanje;
                formaGrupa.TxtPretraga.Text = null;


            }
        }
        public Grupa izabranaGrupa { get; set; }
        public Pohadjanje izabranoPohadjanje { get; set; }
        public List<object> listaobjekata { get; set; }
        internal void prikaziDetaljnije(FormaGrupa formaGrupa)
        {
            formaGrupa.BtnZapamtiGrupu.Enabled = false;
            if (formaGrupa.DgvGrupe.SelectedRows.Count == 0)
            {
                MessageBox.Show("Niste izabrali željenu grupu!");
                return;
            }
            izabranoPohadjanje = (Pohadjanje)formaGrupa.DgvGrupe.SelectedRows[0].DataBoundItem;

            //izabranaGrupa = Communication.Instance.VratiTrazenuGrupu(izabranoPohadjanje.Grupa);
            listaobjekata= Communication.Instance.VratiTrazenuGrupu(izabranoPohadjanje.Grupa);
            izabranaGrupa =(Grupa) listaobjekata[0];
            //formaGrupa.TxtNaziv.Text = izabranoPohadjanje.Grupa.NazivGrupe;
            formaGrupa.TxtNaziv.Text = izabranaGrupa.NazivGrupe;
            //formaGrupa.CbUzrast.SelectedItem = izabranaGrupa.Uzrast;
            formaGrupa.CbProgram.SelectedItem = izabranaGrupa.Program;
            formaGrupa.CbVaspitač.SelectedItem = izabranaGrupa.Vaspitač;

            /* formaGrupa.CbUčenik.SelectedItem = izabranoPohadjanje.Učenik;
             formaGrupa.TxtDatumOD.Text = izabranoPohadjanje.DatumOd.ToString();
             formaGrupa.TxtDatumDO.Text = izabranoPohadjanje.DatumDo.ToString();*/
            //formaGrupa.DgvDodatiUcenici.DataSource = new BindingList<Pohadjanje>((List<Pohadjanje>)listaobjekata[1]);

            pohadjanja = new BindingList<Pohadjanje>((List<Pohadjanje>)listaobjekata[1]);

            formaGrupa.DgvDodatiUcenici.DataSource = pohadjanja;
        }

        internal void ZapamtiNovuGrupu(FormaGrupa formaGrupa)
        {
            if (!Provera(formaGrupa))
            {
                return;
            }
            
            
            izabranaGrupa.NazivGrupe = formaGrupa.TxtNaziv.Text;
            izabranaGrupa.Uzrast = (Uzrast)formaGrupa.CbUzrast.SelectedItem;
            izabranaGrupa.Program = (Domain.Program)formaGrupa.CbProgram.SelectedItem;
            izabranaGrupa.Vaspitač = (Vaspitač)formaGrupa.CbVaspitač.SelectedItem;
            formaGrupa.DgvGrupe.Refresh();
          
            
            if (Communication.Instance.SacuvajNovuGrupu(izabranaGrupa, pohadjanja.ToList()) == true)
            {
                MessageBox.Show("Sistem je zapamtio novu grupu!");
            }
            else
            {
                MessageBox.Show("Sistem ne može da zapamti novu grupu!");
            }

            formaGrupa.BtnZapamtiNovuGrupu.Enabled = true;
        }

        private bool Provera(FormaGrupa formaGrupa)
        {
            bool ispravno = true;
            if (string.IsNullOrEmpty(formaGrupa.TxtNaziv.Text))
            {
                MessageBox.Show("Neophodno je uneti NAZIV GRUPE!");
                formaGrupa.TxtNaziv.BackColor= Color.Salmon;
                ispravno = false;
            }

            if (formaGrupa.CbUzrast.SelectedItem == null)
            {
                MessageBox.Show("Neophodno je izabrati UZRAST!");
                ispravno = false;
            }

            if (formaGrupa.CbProgram.SelectedItem == null)
            {
                MessageBox.Show("Neophodno je izabrati PROGRAM!");
                ispravno = false;
            }


            return ispravno;
        }

        internal void ZapamtiGrupu(FormaGrupa formaGrupa)
        {
            formaGrupa.DgvDodatiUcenici.DataSource = null;
            Grupa grupa = new Grupa();

            if (!Provera(formaGrupa))
            {
                return;
            }

            grupa.NazivGrupe = formaGrupa.TxtNaziv.Text;
            grupa.Uzrast = (Uzrast)formaGrupa.CbUzrast.SelectedItem;
            grupa.Program = (Domain.Program)formaGrupa.CbProgram.SelectedItem;
            grupa.Vaspitač = (Domain.Vaspitač)formaGrupa.CbVaspitač.SelectedItem;


            if (Communication.Instance.SacuvajGrupu(grupa, pohadjanja.ToList()) == true)
            {
                MessageBox.Show($"{grupa.NazivGrupe}, Sistem je zapamtio grupu!");
            }
            else
            {
                MessageBox.Show("Sistem ne može da zapamti grupu!");
            }

            formaGrupa.TxtNaziv.Text = null;
            formaGrupa.TxtDatumOD.Text = null;
            formaGrupa.TxtDatumDO.Text = null;
            formaGrupa.DgvDodatiUcenici.DataSource = null;
         
        }
        private BindingList<Pohadjanje> pohadjanja = new BindingList<Pohadjanje>();

        internal void dodajUcenika(FormaGrupa formaGrupa)
        {
            if (!ProveraDodajUcenika(formaGrupa))
            {
                return;
            }
            Pohadjanje p = new Pohadjanje();
            p.Učenik = (Učenik)formaGrupa.CbUčenik.SelectedItem;
            p.DatumOd = DateTime.ParseExact(formaGrupa.TxtDatumOD.Text, "dd.MM.yyyy.", null);
            p.DatumDo = DateTime.ParseExact(formaGrupa.TxtDatumDO.Text, "dd.MM.yyyy.", null);

            pohadjanja.Add(p);
            MessageBox.Show($"Dodali ste učenika {p.Učenik.Ime} {p.Učenik.Prezime}");

           // formaGrupa.DgvDodatiUcenici.DataSource = pohadjanja;
          /*  formaGrupa.DgvDodatiUcenici.Columns["Grupa"].Visible = false;
            formaGrupa.DgvDodatiUcenici.Columns["DatumOd"].Visible = false;
            formaGrupa.DgvDodatiUcenici.Columns["DatumDo"].Visible = false;
            formaGrupa.DgvDodatiUcenici.Columns[0].Visible = false;

            formaGrupa.DgvDodatiUcenici.Columns["Učenik"].HeaderText = "Dodati učenici";

            formaGrupa.DgvDodatiUcenici.Columns["Učenik"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;*/

        }

        private bool ProveraDodajUcenika(FormaGrupa formaGrupa)
        {
            bool ispravno = true;

            if (formaGrupa.CbUčenik.SelectedItem== null)
            {
                MessageBox.Show("Neophodno je izabrati UČENIKA!");
                ispravno = false;
            }

            if (string.IsNullOrEmpty(formaGrupa.TxtDatumOD.Text))
            {
                MessageBox.Show("Niste unelili DATUMOD!");
                formaGrupa.TxtDatumOD.BackColor = Color.Salmon;
                ispravno = false;
            }


            if (string.IsNullOrEmpty(formaGrupa.TxtDatumDO.Text))
            {
                MessageBox.Show("Niste uneli DATUMDO!");
                formaGrupa.TxtDatumDO.BackColor = Color.Salmon;
                ispravno = false;
            }


            return ispravno;
        }

        internal void ObrisiUcenika(FormaGrupa formaGrupa)
        {
            if (formaGrupa.DgvGrupe.SelectedRows.Count==0d)
            {
                MessageBox.Show("Niste odabrali učenika!");
                return;
            }

            Domain.Pohadjanje p = (Domain.Pohadjanje)formaGrupa.DgvGrupe.SelectedRows[0].DataBoundItem;
            pohadjanje.Remove(p);

            if (Communication.Instance.ObrisiUcenikaIzGrupe(p))
            {
                MessageBox.Show($"Učenik {p.Učenik} više ne pohadja grupu {p.Grupa}.");
            }
            else
            {
                MessageBox.Show("Greska pri uklanjanju učenika iz grupe!");
            }
        }

        internal void VaspitaciNaProgramu(FormaGrupa formaGrupa)
        {
           formaGrupa.CbVaspitač.DataSource = Communication.Instance.VratiVaspitačeNaProgramu(formaGrupa.CbProgram.SelectedItem as Domain.Program);
        }

        internal void ResetujDatume(FormaGrupa formaGrupa)
        {
            formaGrupa.TxtDatumOD.Text = null;
          
            formaGrupa.TxtDatumDO.Text = null; 
        }

        internal void ResetujDataGridPrikazPretraga(FormaGrupa formaGrupa)
        {
            pohadjanje = new BindingList<Pohadjanje>(Communication.Instance.VratiSvaPohadnja());
            formaGrupa.DgvGrupe.DataSource = pohadjanje;
        }
    }
}
