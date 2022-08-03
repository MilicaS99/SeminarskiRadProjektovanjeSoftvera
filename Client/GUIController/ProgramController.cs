using Client.Exceptions;
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
    public class ProgramController
    {
        BindingList<Domain.Program> listaprograma;
        internal void Inicijalizuj(FormaProgram formaProgram)
        {
           formaProgram.DialogResult  = DialogResult.OK;
            //listaprograma = new BindingList<Domain.Program>(Communication.Instance.VratiListuPrograma());
            listaprograma = new BindingList<Domain.Program>(Communication.Instance.PosaljiZahtevVratiRezultat<List<Domain.Program>>(Common.Operation.UčitajListuPrograma));
           formaProgram.DataGridView1.DataSource = listaprograma;
            formaProgram.DataGridView1.Columns["Opis"].AutoSizeMode =  System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
         

        }

        internal void PretraziProgram(FormaProgram formaProgram)
        {
             string kriterijum = "";
          
                string pokupljenkriterijum = formaProgram.TxtKriterijum.Text;
                   kriterijum = pokupljenkriterijum;
            try
            {
                //formaProgram.DataGridView1.DataSource = Communication.Instance.PretragaPrograma(kriterijum);
                formaProgram.DataGridView1.DataSource = Communication.Instance.PosaljiZahtevVratiRezultat<List<Domain.Program>>(Common.Operation.NadjiPrograme,kriterijum);
            }
            catch(SystemOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
             


               
        }

        internal void SacuvajProgram(FormaProgram formaProgram)
        {
            formaProgram.DialogResult = DialogResult.OK;
            if (!Validacija(formaProgram))
            {
                return;
            }
           
            Domain.Program program = new Domain.Program();
            program.NazivPrograma = formaProgram.TxtNaziv.Text;
            program.Opis = formaProgram.RichTextBoxOpis.Text;
            try
            {
                //Communication.Instance.SacuvajProgram(program);
                Communication.Instance.PosaljiZahtevBezRezultata(Common.Operation.ZapamtiProgram, program);
                System.Windows.Forms.MessageBox.Show("Sistem je zapamtio program");
            }
            catch(SystemOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            formaProgram.RichTextBoxOpis.Text = null;
            formaProgram.TxtNaziv.Text = null;
        }

        private bool Validacija(FormaProgram formaProgram)
        {
            bool uspesno = true;
            if (formaProgram.TxtNaziv.Text=="Naziv programa")
            {
                MessageBox.Show("Niste uneli naziv PROGRAMA!");
                formaProgram.TxtNaziv.BackColor = Color.Salmon;
                uspesno = false;
            }
            if (formaProgram.RichTextBoxOpis.Text=="Opis programa")
            {
                MessageBox.Show("Niste uneli opis PROGRAMA!");
                formaProgram.RichTextBoxOpis.BackColor = Color.Salmon;
                uspesno = false;
            }
            return uspesno;
        }

        public Domain.Program izabraniProgram { get; set; }
        internal void prikaziProgram(FormaProgram formaProgram)
        {
            if (formaProgram.DataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Niste izabrali nijedan program!");
                return;
            }

            //izabraniProgram = Communication.Instance.UcitajProgram((Domain.Program)formaProgram.DataGridView1.SelectedRows[0].DataBoundItem);
            izabraniProgram = Communication.Instance.PosaljiZahtevVratiRezultat<Domain.Program>(Common.Operation.UcitajProgram, (Domain.Program)formaProgram.DataGridView1.SelectedRows[0].DataBoundItem);

            if (izabraniProgram == null)
            {
                MessageBox.Show("Sistem ne može da učita program!");
                return;
            }
            formaProgram.TxtNaziv.Text = izabraniProgram.NazivPrograma;
            formaProgram.RichTextBoxOpis.Text = izabraniProgram.Opis;

        }

        internal void UkloniPHopis(FormaProgram formaProgram)
        {
            if (formaProgram.RichTextBoxOpis.Text == "")
            {
                formaProgram.RichTextBoxOpis.Text = "Opis programa";
            }
        }

        internal void UkloniPHnziv(FormaProgram formaProgram)
        {
            if (formaProgram.TxtNaziv.Text == "")
            {
                formaProgram.TxtNaziv.Text = "Naziv programa";
            }
        }

        internal void inicijalizujDGV(FormaProgram formaProgram)
        {
            formaProgram.DataGridView1.DataSource = listaprograma;
        }

        internal void PrikaziPHopis(FormaProgram formaProgram)
        {
            if (formaProgram.RichTextBoxOpis.Text== "Opis programa")
            {
                formaProgram.RichTextBoxOpis.Text= "";
            }
        }

        internal void PrikaziPHnaziv(FormaProgram formaProgram)
        {
            if (formaProgram.TxtNaziv.Text == "Naziv programa")
            {
                formaProgram.TxtNaziv.Text = "";
            }
        }

        internal void UkloniPH(FormaProgram formaProgram)
        {
            if (formaProgram.TxtKriterijum.Text == "")
            {
                formaProgram.TxtKriterijum.Text = "Naziv programa";
            }
        }

        internal void PrikaziPH(FormaProgram formaProgram)
        {
            if (formaProgram.TxtKriterijum.Text == "Naziv programa")
            {
                formaProgram.TxtKriterijum.Text = "";
            }
        }

      
    }
}
