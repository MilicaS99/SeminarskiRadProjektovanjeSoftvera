using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            // Timer t = new Timer();
            //t.Interval = 5000;
            //t.Tick += Osvezi;
            //t.Start();

        }

        internal void PretraziProgram(FormaProgram formaProgram)
        {
             string kriterijum = "";
               if (formaProgram.TxtKriterijum.Text != null)
               {
                string pokupljenkriterijum = formaProgram.TxtKriterijum.Text;
                   kriterijum = $"where Naziv='{pokupljenkriterijum}'";
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
                MessageBox.Show("Niste uneli naziv programa!");
                uspesno = false;
            }
            if (string.IsNullOrEmpty(formaProgram.RichTextBoxOpis.Text))
            {
                MessageBox.Show("Niste uneli opis programa!");
                uspesno = false;
            }
            return uspesno;
        }
    }
}
