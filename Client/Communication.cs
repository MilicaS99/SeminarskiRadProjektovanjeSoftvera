using Common;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
   public  class Communication
    {
        private static Communication instance;

        private CommunicationHelper helper;
        private Communication()
        {

        }
        public static Communication Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Communication();
                }
                return instance;
            }
        }

        

        internal object VratiSveUzraste()
        {
            Message m = new Message();

            m.Operation = Operation.UčitajListuUzrasta;
            helper.Send(m);
            Message receivemessage = helper.Receive<Message>();
            return (Array)receivemessage.messageResponse;
        }

        internal List<Grupa> VratiSveGrupe()
        {
            Message m = new Message();

            m.Operation = Operation.VratiSveGrupe;
            helper.Send(m);
            Message receivemessage = helper.Receive<Message>();
            return (List<Grupa>)receivemessage.messageResponse;
        }

        internal bool ZapamtiPohadjanje(Pohadjanje pohadjanje)
        {
            Message m = new Message();
            m.messageRequest = pohadjanje;
            m.Operation = Operation.ZapamtiPohadjanje;
            helper.Send(m);
            Message receivemessage = helper.Receive<Message>();
            if (receivemessage.isSuccesfull == true)
            {
                return true;

            }
            else
            {
                return false;

            }
        }

        internal List<Pohadjanje> VratiSvaPohadnja()
        {
            Message m = new Message();

            m.Operation = Operation.VratiPohadjanja;
            helper.Send(m);
            Message receivemessage = helper.Receive<Message>();
            return (List<Domain.Pohadjanje>)receivemessage.messageResponse;
        }

        internal List<Učenik> VratiListuUčenika()
        {
            Message m = new Message();

            m.Operation = Operation.UčitajListuUčenika;
            helper.Send(m);
            Message receivemessage = helper.Receive<Message>();
            return (List<Domain.Učenik>)receivemessage.messageResponse;
        }

        internal bool SacuvajGrupu(Grupa grupa, List<Pohadjanje> pohadjanja)
        {
            List<object> objektizacuvanje = new List<object>();
            objektizacuvanje.Add(grupa);
            objektizacuvanje.Add(pohadjanja);
            Message m = new Message();
            m.messageRequest = objektizacuvanje;
            m.Operation = Operation.ZapamtiGrupu;
            helper.Send(m);
            Message receivemessage = helper.Receive<Message>();
            if (receivemessage.isSuccesfull == true)
            {
                return true;

            }
            else
            {
                return false;

            }

        }



        internal List<Vaspitač> VratiSveVaspitače()
        {
            Message m = new Message();

            m.Operation = Operation.UčitajListuVaspitača;
            helper.Send(m);
            Message receivemessage = helper.Receive<Message>();
            return (List<Domain.Vaspitač>)receivemessage.messageResponse;
        }

        internal List<Domain.Program> VratiListuPrograma()
        {
            Message m = new Message();

            m.Operation = Operation.UčitajListuPrograma;
            helper.Send(m);
            Message receivemessage = helper.Receive<Message>();
            return (List<Domain.Program>)receivemessage.messageResponse;
        }

        internal object PretragaUčenika(string kriterijum)
        {
            Message m = new Message();
            m.messageRequest = kriterijum;
            m.Operation = Operation.PretražiUčenike;
            helper.Send(m);
            Message receivemessage = helper.Receive<Message>();
            if (receivemessage.isSuccesfull == true)
            {
                System.Windows.Forms.MessageBox.Show("Sistem je našao učenike po zadatoj vrednosti!");
                return (List<Domain.Učenik>)receivemessage.messageResponse;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Sistem ne može da nadje učenike po zadatoj vrednosti!");

            }
            return null;
        }

        internal List<Grupa> PretragaGrupa(string kriterijum)
        {
            Message m = new Message();
            m.messageRequest = kriterijum;
            m.Operation = Operation.NadjiGrupe;
            helper.Send(m);
            Message receivemessage = helper.Receive<Message>();
            if (receivemessage.isSuccesfull == true)
            {
                System.Windows.Forms.MessageBox.Show("Sistem je našao grupe po zadatoj vrednosti!");
                return (List<Domain.Grupa>)receivemessage.messageResponse;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Sistem ne može da nadje grupe po zadatoj vrednosti!");

            }
            return null;
        }

        internal bool SacuvajNovuGrupu(Grupa izabranaGrupa)
        {
            Message m = new Message();
            m.messageRequest = izabranaGrupa;
            m.Operation = Operation.ZapamtiNovuGrupu;
            helper.Send(m);
            Message receivemessage = helper.Receive<Message>();
            if (receivemessage.isSuccesfull == true)
            {
                return true;

            }
            else
            {
                return false;

            }
        }

        internal void SacuvajUcenika(Učenik ucenik)
        {
            Message m = new Message();
            m.messageRequest = ucenik;
            m.Operation = Operation.ZapamtiUčenika;
            helper.Send(m);
            Message receivemessage = helper.Receive<Message>();
            if (receivemessage.isSuccesfull == true)
            {
                System.Windows.Forms.MessageBox.Show($"{ucenik.Ime} {ucenik.Prezime},Učenik je zapamćen u sistem!");

            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Sistem ne može da zapamti unetog učenika!");

            }

        }

        internal IList<Vaspitač> VratiVaspitacePoKriterijumu(string kriterijum)
        {
            Message m = new Message();
            m.messageRequest = kriterijum;
            m.Operation = Operation.PretražiVaspitača;
            helper.Send(m);
            Message receivemessage = helper.Receive<Message>();
            if (receivemessage.isSuccesfull == true)
            {
                System.Windows.Forms.MessageBox.Show("Sistem je našao programe po zadatoj vrednosti!");
                return (List<Domain.Vaspitač>)receivemessage.messageResponse;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Sistem ne može da nadje programe po zadatoj vrednosti!");
                return new List<Vaspitač>();

            }
         
            
        }

        internal bool SacuvajIzmenjenogVaspitaca(Vaspitač izabraniRed)
        {
            Message m = new Message();
            m.messageRequest = izabraniRed;
            m.Operation = Operation.zapamtiNovogVaspitača;
            helper.Send(m);
            Message receivemessage = helper.Receive<Message>();
            if (receivemessage.isSuccesfull == true)
            {
                return true;

            }
            else
            {
                return false;

            }
        }

        internal void KreitajVaspitaca(Vaspitač v)
        {
            Message m = new Message();
            m.messageRequest = v;
            m.Operation = Operation.ZapamtiVaspitača;
            helper.Send(m);
            Message receivemessage = helper.Receive<Message>();
            if (receivemessage.isSuccesfull == true)
            {
                System.Windows.Forms.MessageBox.Show($"{v.Ime} {v.Prezime},Vaspitač je zapamćen u sistem!");

            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Sistem ne može da zapamti unetog vaspitača!");

            }

        }

        private Socket socket;
        public void Connect()
        {
            if (socket == null || !socket.Connected)
            {
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socket.Connect("127.0.0.1", 9999);
                helper = new CommunicationHelper(socket);
            }
        }

        internal object PretragaPrograma(string kriterijum)
        {
            Message m = new Message();
            m.messageRequest = kriterijum;
            m.Operation = Operation.NadjiPrograme;
            helper.Send(m);
            Message receivemessage = helper.Receive<Message>();
            if (receivemessage.isSuccesfull == true)
            {
                System.Windows.Forms.MessageBox.Show("Sistem je našao programe po zadatoj vrednosti!");
                return (List<Domain.Program>)receivemessage.messageResponse;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Sistem ne može da nadje programe po zadatoj vrednosti!");
                
            }
            return null;
        }

        internal void SacuvajProgram(Domain.Program program)
        {
            Message m = new Message();
            m.messageRequest = program;
            m.Operation = Operation.ZapamtiProgram;
            helper.Send(m);
            Message receivemessage = helper.Receive<Message>();
            if (receivemessage.isSuccesfull == true)
            {
                System.Windows.Forms.MessageBox.Show("Sistem je zapamtio program");

            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Sistem ne može da zapamti program");

            }
        }

        internal Korisnik LogIn(Korisnik k)
        {
            Message m = new Message();
            m.messageRequest = k;
            m.Operation = Operation.LogIN;
            helper.Send(m);
            Message receivemessage = helper.Receive<Message>();
            return (Korisnik)receivemessage.messageResponse;
        }

        internal Message ReadMessage()
        {
            return helper.Receive<Message>();
        }


        internal void Send(Message m)
        {
            helper.Send(m);
        }
        public void Close()
        {
            if (socket == null) return;
            Message request = new Message
            {
                Operation = Operation.Kraj,
            };
            helper.Send(request);

            socket.Shutdown(SocketShutdown.Both);
            socket.Close();
            socket = null;
        }
    }
}
