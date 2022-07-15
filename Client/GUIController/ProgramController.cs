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
            listaprograma = new BindingList<Domain.Program>(Communication.Instance.VratiListuPrograma());
           formaProgram.DataGridView1.DataSource = listaprograma;
            formaProgram.DataGridView1.Columns["Opis"].AutoSizeMode =  System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            // Timer t = new Timer();
            //t.Interval = 5000;
            //t.Tick += Osvezi;
            //t.Start();

        }

        internal void PretraziProgram(FormaProgram formaProgram)
        {
             string kriterijum = "";
               if (string.IsNullOrEmpty(formaProgram.TxtKriterijum.Text)== true)
            {
                MessageBox.Show("Niste uneli kriterijum za pretragu!");
                formaProgram.TxtKriterijum.BackColor = Color.Salmon;
            }else
               {
                string pokupljenkriterijum = formaProgram.TxtKriterijum.Text;
                   kriterijum = pokupljenkriterijum;
                  formaProgram.DataGridView1.DataSource = Communication.Instance.PretragaPrograma(kriterijum);
              formaProgram.TxtKriterijum.Text = null;


               }
        }

        internal void SacuvajProgram(FormaProgram formaProgram)
        {
            if (!Validacija(formaProgram))
            {
                return;
            }
            Domain.Program program = new Domain.Program();
            program.NazivPrograma = formaProgram.TxtNaziv.Text;
            program.Opis = formaProgram.RichTextBoxOpis.Text;
            Communication.Instance.SacuvajProgram(program);
            formaProgram.RichTextBoxOpis.Text = null;
            formaProgram.TxtNaziv.Text = null;
        }

        private bool Validacija(FormaProgram formaProgram)
        {
            bool uspesno = true;
            if (string.IsNullOrEmpty(formaProgram.TxtNaziv.Text))
            {
                MessageBox.Show("Niste uneli naziv PROGRAMA!");
                formaProgram.TxtNaziv.BackColor = Color.Salmon;
                uspesno = false;
            }
            if (string.IsNullOrEmpty(formaProgram.RichTextBoxOpis.Text))
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
            }

            izabraniProgram = Communication.Instance.UcitajProgram((Domain.Program)formaProgram.DataGridView1.SelectedRows[0].DataBoundItem);

            formaProgram.TxtNaziv.Text = izabraniProgram.NazivPrograma;
            formaProgram.RichTextBoxOpis.Text = izabraniProgram.Opis;

        }
    }
}
