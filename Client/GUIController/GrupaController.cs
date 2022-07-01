using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Client.GUIController
{
    class GrupaController
    {
        BindingList<Grupa> grupe;
        private FormaGrupa formaGrupa;

       

        internal void Init(FormaGrupa formaGrupa)
        {
           formaGrupa.CbUzrast.DataSource = Communication.Instance.VratiSveUzraste();
            formaGrupa.CbProgram.DataSource = Communication.Instance.VratiListuPrograma();
           formaGrupa.CbVaspitač.DataSource = Communication.Instance.VratiSveVaspitače();

            Timer t = new Timer();
            t.Interval = 5000;
            t.Tick += Osvezi;
            t.Start();
        }

        internal void Osvezi(object sender, EventArgs e)
        {
             grupe = new BindingList<Grupa>(Communication.Instance.VratiSveGrupe());
            formaGrupa.DataGridView1.DataSource = grupe;
        }


    }
}
