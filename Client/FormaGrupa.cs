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
        private GrupaController controller = new GrupaController();
        BindingList<Grupa> grupe;
        BindingList<Pohadjanje> pohadjanje;
        public FormaGrupa()
        {
            InitializeComponent();

         //   InitData();
       cbUzrast.DataSource = Communication.Instance.VratiSveUzraste();
            cbProgram.DataSource = Communication.Instance.VratiListuPrograma();
            cbVaspitač.DataSource = Communication.Instance.VratiSveVaspitače();
            cbUčenik.DataSource = Communication.Instance.VratiListuUčenika();
            
          
            Timer t = new Timer();
            t.Interval = 5000;
            t.Tick += Osvezi;
            t.Start();
        }

        private void InitData()
        {
            controller.Init(this);
        }

        private void Osvezi(object sender, EventArgs e)
        {
            //controller.Osvezi( sender,  e,this);
            // grupe = new BindingList<Grupa>(Communication.Instance.VratiSveGrupe());
            pohadjanje = new BindingList<Pohadjanje>(Communication.Instance.VratiSvaPohadnja());
            dataGridView1.DataSource = pohadjanje;
        }

        //BIO KOD ZA DODAVANJE GRUPE!!!
      
           /* Grupa grupa = new Grupa();

            if (!Provera())
            {
                return;
            }

            grupa.NazivGrupe = txtNaziv.Text;
            grupa.Uzrast = (Uzrast)cbUzrast.SelectedItem;
            grupa.Program = (Domain.Program)cbProgram.SelectedItem;
            grupa.Vaspitač = (Vaspitač)cbVaspitač.SelectedItem;

            if (Communication.Instance.SacuvajGrupu(grupa) == true)
            {
                MessageBox.Show($"{grupa.NazivGrupe}, Sistem je zapamtio grupu!");
            }
            else
            {
                MessageBox.Show("Sistem ne može da zapamti grupu!");
            }*/

        
        private bool Provera()
        {
            bool ispravno = true;
            if (txtNaziv.Text == null)
            {
                MessageBox.Show("Neophodno je uneti naziv grupe");
                ispravno = false;
            }
            else
            {
                ispravno = true;
            }
            if (cbUzrast.SelectedItem == null)
            {
                MessageBox.Show("Neophodno je izabrati uzrast");
                ispravno = false;
            }
            else
            {
                ispravno = true;
            }
            if (cbProgram.SelectedItem == null)
            {
                MessageBox.Show("Neophodno je izabrati Program");
                ispravno = false;
            }
            else
            {
                ispravno = true;
            }
            Domain.Program p =(Domain.Program) cbProgram.SelectedItem;
            Vaspitač v = (Vaspitač)cbVaspitač.SelectedItem;
            if (p.NazivPrograma != v.Program.NazivPrograma)
            {
                MessageBox.Show("Morate uneti Vaspitača nadležnog za taj program!");
                ispravno = false;
            }
            else
            {
                ispravno = true;
            }
            return ispravno;
        }

        private void btnPretrai_Click(object sender, EventArgs e)
        {
            string kriterijum = "";
            if (string.IsNullOrEmpty(txtPretraga.Text)!=false)
            {
                string pretraga = txtPretraga.Text;
                kriterijum = $"where g.NazivGrupe='{pretraga}'";
                if (Communication.Instance.PretragaGrupa(kriterijum)==null)
                {
                    return;
                }
                grupe = new BindingList<Grupa>(Communication.Instance.PretragaGrupa(kriterijum));
                dataGridView1.DataSource = grupe;

            }
        }

        public Grupa izabranaGrupa { get; set; }
        private void btnPrikaziDetalje_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Niste izabrali željenu grupu!");
                return;
            }
            izabranaGrupa = (Grupa)dataGridView1.SelectedRows[0].DataBoundItem;
            txtNaziv.Text = izabranaGrupa.NazivGrupe;
            cbUzrast.SelectedItem = izabranaGrupa.Uzrast;
            cbProgram.SelectedItem = izabranaGrupa.Program;
            cbVaspitač.SelectedItem = izabranaGrupa.Vaspitač;
        }

        private void btnZapamtiNovuGrupu_Click(object sender, EventArgs e)
        {
            izabranaGrupa.Uzrast =(Uzrast) cbUzrast.SelectedItem;
            izabranaGrupa.Vaspitač = (Vaspitač)cbVaspitač.SelectedItem;
            dataGridView1.Refresh();
            if (Communication.Instance.SacuvajNovuGrupu(izabranaGrupa) == true)
            {
                MessageBox.Show("Sistem je zapamtio novu grupu!");
            }
            else
            {
                MessageBox.Show("Sistem ne može da zapamti novu grupu!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Grupa grupa = new Grupa();

            if (!Provera())
            {
                return;
            }

            grupa.NazivGrupe = txtNaziv.Text;
            grupa.Uzrast = (Uzrast)cbUzrast.SelectedItem;
            grupa.Program = (Domain.Program)cbProgram.SelectedItem;
            grupa.Vaspitač = (Vaspitač)cbVaspitač.SelectedItem;


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
            txtDatumDO.Text = null;
           /* if (Communication.Instance.ZapamtiPohadjanje(p) == true)
            {
                MessageBox.Show("Uspešno ste dodali učenika u grupu!");
            }
            else
            {
                MessageBox.Show("Učenik nije dodat u grupu!");
            }*/
        }

        private List<Pohadjanje> pohadjanja = new List<Pohadjanje>();
        private void button2_Click(object sender, EventArgs e)
        {
            Pohadjanje p = new Pohadjanje();
            p.Učenik = (Učenik)cbUčenik.SelectedItem;
            p.DatumOd = DateTime.ParseExact(txtDatumOD.Text, "dd.MM.yyyy.", null);
            p.DatumDo = DateTime.ParseExact(txtDatumDO.Text, "dd.MM.yyyy.", null);
        
            pohadjanja.Add(p);
        }
    }
}
