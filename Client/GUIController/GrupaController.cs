using Client.Exceptions;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
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
            
            formaGrupa.CbUzrast.DataSource = Communication.Instance.PosaljiZahtevVratiRezultat<Array>(Common.Operation.UčitajListuUzrasta);

            
            formaGrupa.CbProgram.DataSource = Communication.Instance.PosaljiZahtevVratiRezultat<List<Domain.Program>>(Common.Operation.UčitajListuPrograma);
           
            formaGrupa.CbVaspitač.DataSource = Communication.Instance.PosaljiZahtevVratiRezultat<List<Vaspitač>>(Common.Operation.UčitajListuVaspitača);
          
            formaGrupa.CbUčenik.DataSource = Communication.Instance.PosaljiZahtevVratiRezultat<List<Učenik>>(Common.Operation.UčitajListuUčenika);
           
            pohadjanje = new BindingList<Pohadjanje>(Communication.Instance.PosaljiZahtevVratiRezultat<List<Pohadjanje>>(Common.Operation.VratiPohadjanja));
            formaGrupa.DgvGrupe.DataSource = pohadjanje;
            formaGrupa.DgvDodatiUcenici.DataSource = pohadjanja;
            formaGrupa.DgvDodatiUcenici.Columns["Grupa"].Visible = false;

       

         

        }

      

       /* internal void Osvezi(FormaGrupa formaGrupa)
        {
            pohadjanje = new BindingList<Pohadjanje>(Communication.Instance.VratiSvaPohadnja());
           formaGrupa.DgvGrupe.DataSource = pohadjanje;
        }*/

        internal void Pretrazi(FormaGrupa formaGrupa)
        {
           
            string kriterijum = "";
            string pretraga = formaGrupa.TxtPretraga.Text;
             
                kriterijum = pretraga;
            try
            {
                //pohadjanje = new BindingList<Pohadjanje>(Communication.Instance.PretragaGrupa(kriterijum));
                pohadjanje = new BindingList<Pohadjanje>(Communication.Instance.PosaljiZahtevVratiRezultat<List<Pohadjanje>>(Common.Operation.NadjiGrupe,kriterijum));
                //System.Windows.Forms.MessageBox.Show("Sistem je našao grupe po zadatoj vrednosti!");
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
               formaGrupa.DgvGrupe.DataSource  = pohadjanje;
               


            
        }
        public Grupa izabranaGrupa { get; set; }
        public Pohadjanje izabranoPohadjanje { get; set; }
        public List<object> listaobjekata { get; set; }
        internal void prikaziDetaljnije(FormaGrupa formaGrupa)
        {
            
            if (formaGrupa.DgvGrupe.SelectedRows.Count == 0)
            {
                MessageBox.Show("Niste izabrali željenu grupu!");
                return;
            }
            izabranoPohadjanje = (Pohadjanje)formaGrupa.DgvGrupe.SelectedRows[0].DataBoundItem;

            try
            {
                //izabranaGrupa = Communication.Instance.UcitajGrupu(izabranoPohadjanje.Grupa);
                izabranaGrupa = Communication.Instance.PosaljiZahtevVratiRezultat<Grupa>(Common.Operation.VratiTrazenuGrupu,izabranoPohadjanje.Grupa);
            }catch(SystemOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
       
          
            
            formaGrupa.TxtNaziv.Text = izabranaGrupa.NazivGrupe;
         
            formaGrupa.CbProgram.SelectedItem = izabranaGrupa.Program;
            formaGrupa.CbVaspitač.SelectedItem = izabranaGrupa.Vaspitač;

       
            pohadjanja = new BindingList<Pohadjanje>(izabranaGrupa.listapohadjanja);

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
            izabranaGrupa.listapohadjanja = pohadjanja.ToList();

            try
            {
                Communication.Instance.PosaljiZahtevBezRezultata(Common.Operation.ZapamtiNovuGrupu, izabranaGrupa);
                MessageBox.Show("Sistem je zapamtio novu grupu!");
            }
            catch(SystemOperationException ex)
            {
                MessageBox.Show(ex.Message);
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
            grupa.listapohadjanja = pohadjanja.ToList();

            try
            {
                Communication.Instance.PosaljiZahtevBezRezultata(Common.Operation.ZapamtiGrupu, grupa);
                MessageBox.Show($"{grupa.NazivGrupe}, Sistem je zapamtio grupu!");
            }
            catch(SystemOperationException ex)
            {
                MessageBox.Show(ex.Message);
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

        

        }

        private bool ProveraDodajUcenika(FormaGrupa formaGrupa)
        {
            bool ispravno = true;

            if (formaGrupa.CbUčenik.SelectedItem== null)
            {
                MessageBox.Show("Neophodno je izabrati UČENIKA!");
                ispravno = false;
            }

            if (!DateTime.TryParseExact(formaGrupa.TxtDatumOD.Text, "dd.MM.yyyy.", null, DateTimeStyles.None, out _))
            {
                MessageBox.Show("Datum nije u dobrom formatu!");
                formaGrupa.TxtDatumOD.BackColor = Color.Salmon;
                ispravno = false;
            }
            if (!DateTime.TryParseExact(formaGrupa.TxtDatumDO.Text, "dd.MM.yyyy.", null, DateTimeStyles.None, out _))
            {
                MessageBox.Show("Datum nije u dobrom formatu!");
                formaGrupa.TxtDatumDO.BackColor = Color.Salmon;
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
            if (formaGrupa.DgvDodatiUcenici.SelectedRows.Count==0)
            {
                MessageBox.Show("Niste odabrali učenika!");
                return;
            }

            Domain.Pohadjanje p = (Domain.Pohadjanje)formaGrupa.DgvDodatiUcenici.SelectedRows[0].DataBoundItem;
            pohadjanja.Remove(p);
           
           

        
        }

        internal void NapustanjePoljaNazivaGrupe(FormaGrupa formaGrupa)
        {
            if (formaGrupa.TxtNaziv.Text == "")
            {
                formaGrupa.TxtNaziv.Text = "Naziv grupe";
            }
        }

        internal void NapustanjePoljaDatumODevent(FormaGrupa formaGrupa)
        {
            if (formaGrupa.TxtDatumOD.Text == "")
            {
                formaGrupa.TxtDatumOD.Text = "dd.MM.yyyy.";
            }
        }

        internal void UnosPretrageEvent(FormaGrupa formaGrupa)
        {
            if (formaGrupa.TxtPretraga.Text == "Naziv grupe")
            {
                formaGrupa.TxtPretraga.Text = "";
            }
        }

        internal void UnosDatumaDO(FormaGrupa formaGrupa)
        {
            if (formaGrupa.TxtDatumDO.Text == "dd.MM.yyyy.")
            {
                formaGrupa.TxtDatumDO.Text = "";
            }
        }

        internal void NapustanjeDatumaDOevent(FormaGrupa formaGrupa)
        {
            if (formaGrupa.TxtDatumDO.Text == "")
            {
                formaGrupa.TxtDatumDO.Text = "dd.MM.yyyy.";
            }
        }

        internal void NapustanjePretrageEvent(FormaGrupa formaGrupa)
        {
           if(formaGrupa.TxtPretraga.Text=="Naziv grupe")
            {
                formaGrupa.TxtPretraga.Text = "";
            }
        }

        internal void UnosDatumOdEvent(FormaGrupa formaGrupa)
        {
            if (formaGrupa.TxtDatumOD.Text == "dd.MM.yyyy.")
            {
                formaGrupa.TxtDatumOD.Text = "";
            }
        }

        internal void UnosNazivaGrupeEvent(FormaGrupa formaGrupa)
        {
            if(formaGrupa.TxtNaziv.Text=="Naziv grupe")
            {
                formaGrupa.TxtNaziv.Text = "";
            }
        }

        internal void VaspitaciNaProgramu(FormaGrupa formaGrupa)
        {
            //formaGrupa.CbVaspitač.DataSource = Communication.Instance.VratiVaspitačeNaProgramu(formaGrupa.CbProgram.SelectedItem as Domain.Program);
            formaGrupa.CbVaspitač.DataSource = Communication.Instance.PosaljiZahtevVratiRezultat<List<Vaspitač>>(Common.Operation.VratiVaspitačeNaProgramu,(formaGrupa.CbProgram.SelectedItem as Domain.Program));
        }

        internal void ResetujDatume(FormaGrupa formaGrupa)
        {
            formaGrupa.TxtDatumOD.Text = null;
          
            formaGrupa.TxtDatumDO.Text = null; 
        }

        internal void ResetujDataGridPrikazPretraga(FormaGrupa formaGrupa)
        {
            //pohadjanje = new BindingList<Pohadjanje>(Communication.Instance.VratiSvaPohadnja());
            pohadjanje= new BindingList<Pohadjanje>(Communication.Instance.PosaljiZahtevVratiRezultat<List<Pohadjanje>>(Common.Operation.VratiPohadjanja));
            formaGrupa.DgvGrupe.DataSource = pohadjanje;
        }
    }
}
