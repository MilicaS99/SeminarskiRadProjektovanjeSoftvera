using Client.Exceptions;
using Common;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization;
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
           
            PosaljiZahtev(Operation.UčitajListuUzrasta);
            Message receivemessage = helper.Receive<Message>();
            return (Array)receivemessage.messageResponse;
        }

        /*internal List<Grupa> VratiSveGrupe()
        {
           
            PosaljiZahtev(Operation.VratiSveGrupe);
            Message receivemessage = helper.Receive<Message>();
            return (List<Grupa>)receivemessage.messageResponse;
        }*/

        internal bool ZapamtiPohadjanje(Pohadjanje pohadjanje)
        {
            
            PosaljiZahtev(Operation.ZapamtiPohadjanje,pohadjanje);
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
           
            PosaljiZahtev(Operation.VratiPohadjanja);
            Message receivemessage = helper.Receive<Message>();
            return (List<Domain.Pohadjanje>)receivemessage.messageResponse;
        }

        internal List<Učenik> VratiListuUčenika()
        {
            
            PosaljiZahtev(Operation.UčitajListuUčenika);
            Message receivemessage = helper.Receive<Message>();
            return (List<Domain.Učenik>)receivemessage.messageResponse;
        }

        internal bool SacuvajGrupu(Grupa grupa, List<Pohadjanje> pohadjanja)
        {
            List<object> objektizacuvanje = new List<object>();
            objektizacuvanje.Add(grupa);
            objektizacuvanje.Add(pohadjanja);
            PosaljiZahtev(Operation.ZapamtiGrupu,objektizacuvanje);
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
            PosaljiZahtev(Operation.UčitajListuVaspitača);
            Message receivemessage = helper.Receive<Message>();
            return (List<Domain.Vaspitač>)receivemessage.messageResponse;
        }

        internal Domain.Program UcitajProgram(Domain.Program program)
        {
            PosaljiZahtev(Operation.UcitajProgram, program);
            Message receivemessage = helper.Receive<Message>();

            return (Domain.Program)receivemessage.messageResponse;
        }

        internal List<Domain.Program> VratiListuPrograma()
        {
            PosaljiZahtev(Operation.UčitajListuPrograma);
            Message receivemessage = helper.Receive<Message>();
            return (List<Domain.Program>)receivemessage.messageResponse;
        }

        internal object PretragaUčenika(string kriterijum)
        {
            PosaljiZahtev(Operation.PretražiUčenike,kriterijum);
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

        internal Učenik UcitajUcenika(Učenik ucenik)
        {
            PosaljiZahtev(Operation.UcitajUcenika, ucenik);
            Message receivemessage = helper.Receive<Message>();

            return (Učenik)receivemessage.messageResponse;
        }

        internal List<object> VratiTrazenuGrupu(Grupa grupa)
        {
            PosaljiZahtev(Operation.VratiTrazenuGrupu, grupa);
            Message receivemessage = helper.Receive<Message>();
           
                return (List<object>)receivemessage.messageResponse;
            
          
        }

        internal Vaspitač UcitajVaspitaca(Vaspitač vaspitac)
        {
            PosaljiZahtev(Operation.UcitajVaspitaca, vaspitac);
            Message receivemessage = helper.Receive<Message>();
            return (Vaspitač)receivemessage.messageResponse;
            
        }

        internal List<Pohadjanje> PretragaGrupa(string kriterijum)
        {
            PosaljiZahtev(Operation.NadjiGrupe,kriterijum);
            Message receivemessage = helper.Receive<Message>();
            if (receivemessage.messageResponse!=null)
            {
                System.Windows.Forms.MessageBox.Show("Sistem je našao grupe po zadatoj vrednosti!");
                return (List<Domain.Pohadjanje>)receivemessage.messageResponse;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Sistem ne može da nadje grupe po zadatoj vrednosti!");
                return new List<Pohadjanje>();

            }
           
        }

        internal bool SacuvajNovuGrupu(Grupa izabranaGrupa, List<Pohadjanje> pohadjanja)
        {
           
          
            List<object> objektizacuvanje = new List<object>();
            objektizacuvanje.Add(izabranaGrupa);
            objektizacuvanje.Add(pohadjanja);
            PosaljiZahtev(Operation.ZapamtiNovuGrupu,objektizacuvanje);
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
            PosaljiZahtev(Operation.ZapamtiUčenika, ucenik);
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

        internal List<Vaspitač> VratiVaspitacePoKriterijumu(string kriterijum)
        {
            PosaljiZahtev(Operation.PretražiVaspitača,kriterijum);
            Message receivemessage = helper.Receive<Message>();
            if (receivemessage.isSuccesfull == true)
            {
                System.Windows.Forms.MessageBox.Show("Sistem je našao vaspitače po zadatoj vrednosti!");
                return (List<Domain.Vaspitač>)receivemessage.messageResponse;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Sistem ne može da nadje vaspitače po zadatoj vrednosti!");
                return new List<Vaspitač>();

            }
         
            
        }

        internal List<Vaspitač> VratiVaspitačeNaProgramu(Domain.Program program)
        {
            PosaljiZahtev(Operation.VratiVaspitačeNaProgramu, program);
            Message receivemessage = helper.Receive<Message>();
            return (List<Domain.Vaspitač>)receivemessage.messageResponse;
        }

        internal bool ObrisiUcenikaIzGrupe(Pohadjanje pohadjanje)
        {
            PosaljiZahtev(Operation.ObrišiUčenikaizGrupe,pohadjanje);
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


        private void PosaljiZahtev(Operation operacija,object requestObject=null)
        {
            try
            {
                Message m = new Message();
                m.Operation = operacija;
                m.messageRequest = requestObject;
                helper.Send(m);
            }catch(IOException ex)
            {
                throw new ServerCommunicationException(ex.Message);
            }
        }
        internal bool SacuvajIzmenjenogVaspitaca(Vaspitač izabraniRed)
        {

            PosaljiZahtev(Operation.zapamtiNovogVaspitača, izabraniRed);
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

        internal void KreitajVaspitaca(Vaspitač vaspitac)
        {
            PosaljiZahtev(Operation.ZapamtiVaspitača, vaspitac);
            Message receivemessage = helper.Receive<Message>();
            if (receivemessage.isSuccesfull == true)
            {
                System.Windows.Forms.MessageBox.Show($"{vaspitac.Ime} {vaspitac.Prezime},Vaspitač je zapamćen u sistem!");

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
            PosaljiZahtev(Operation.NadjiPrograme, kriterijum);
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
            PosaljiZahtev(Operation.ZapamtiProgram, program);
           
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

        internal Korisnik LogIn(Korisnik korisnik)
        {
            PosaljiZahtev(Operation.LogIN, korisnik);
            Message m = new Message();
            Message receivemessage = helper.Receive<Message>();
            return (Korisnik)receivemessage.messageResponse;
        }

        
        public void Close()
        {
            try
            {


                PosaljiZahtev(Operation.EndCommunication);
                socket.Shutdown(SocketShutdown.Both);
                socket.Close();
                socket = null;
            }
            catch (IOException ex)
            {
                Debug.WriteLine(ex.Message);
                throw;
            }
        }
    }
}
