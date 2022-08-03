using ApplicationLogic;
using Common;
using Domain;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class ClientHandler
    {
        private Socket clientSocket;
        private CommunicationHelper helper;
        public EventHandler OdjavljenKlijent;

        public ClientHandler(Socket clientSocket)
        {
            this.clientSocket = clientSocket;
            helper = new CommunicationHelper(clientSocket);
        }

      //  private bool kraj = false;
        internal void handleRequest()
        {
            try
            {
                Message messagerequest;
                while ((messagerequest = helper.Receive<Message>()).Operation!=Operation.EndCommunication)
                {
                     
                    Message response;
                    try
                    {
                        response = CreateResponse(messagerequest);

                    }catch(Exception ex)
                    {
                        response = new Message();
                        response.isSuccesfull = false;
                        Debug.WriteLine(">>>" + ex.Message);
                    }
                    helper.Send(response);
                }
            }
            catch (IOException ex)
            {
                Debug.WriteLine(">>>" + ex.Message);
            }
            finally
            {
                CloseSocket();
            }
        }
        private Message CreateResponse(Message messagerequest)
        {
            Message response = new Message();

            switch (messagerequest.Operation)
            {
                case Operation.LogIN:
                    response.Operation = Operation.LogIN;
                    response.messageResponse = Controller.Instance.LogIN(messagerequest.messageRequest as Korisnik);
                    if (response.messageResponse == null)
                    {
                        response.ClientMessage = "Neuspešan LogIN, pokušjte ponovo";
                        response.isSuccesfull = false;
                    }
                    break;
                case Operation.ZapamtiProgram:
                    response.Operation = Operation.ZapamtiProgram;
                    response.isSuccesfull = Controller.Instance.ZapamtiProgram(messagerequest.messageRequest as Domain.Program);
                    if (!response.isSuccesfull)
                    {
                        response.ClientMessage = "Sistem ne može da zapamti program";
                    }
                    break;
                case Operation.NadjiPrograme:
                    response.Operation = Operation.NadjiPrograme;
                    response.messageResponse = Controller.Instance.NadjiPrograme(messagerequest.messageRequest as string);
                    if (response.messageResponse == null)
                    {
                        response.isSuccesfull = false;
                        response.ClientMessage = "Sistem ne može da nadje programe po zadatoj vrednosti!";
                    }
                    
                    break;
                case Operation.UčitajListuPrograma:
                    response.messageResponse = Controller.Instance.VratiListuPrograma();
                    break;
                case Operation.ZapamtiVaspitača:
                    response.isSuccesfull = Controller.Instance.ZapamtiVaspitaca(messagerequest.messageRequest as Vaspitač);
                    if (!response.isSuccesfull)
                    {
                        response.ClientMessage = "Sistem ne moze da zapamti vaspitaca!";
                    }
                    break;
                case Operation.ZapamtiUčenika:
                    response.isSuccesfull = Controller.Instance.ZapamtiUčenika(messagerequest.messageRequest as Učenik);
                    if (!response.isSuccesfull)
                    {
                        response.ClientMessage = "Sistem ne može da zapamti unetog učenika!";
                    }
                    break;
                case Operation.UčitajListuVaspitača:
                    response.messageResponse = Controller.Instance.VratiListuVaspitaca();
                    break;
                case Operation.PretražiVaspitača:
                    response.messageResponse = Controller.Instance.PretraziVaspitace(messagerequest.messageRequest as string);
                    if (response.messageResponse == null)
                    {
                        response.isSuccesfull = false;
                        response.ClientMessage = "Sistem ne može da nadje vaspitače po zadatoj vrednosti!";
                    }
                
                    break;
                case Operation.zapamtiNovogVaspitača:
                    response.isSuccesfull = Controller.Instance.ZapamtiNovogVaspitaca(messagerequest.messageRequest as Vaspitač);
                    if (!response.isSuccesfull)
                    {
                        response.ClientMessage = "Sistem ne može da zapamti izmenjenog vaspitača!";
                    }
                   
                    break;
                case Operation.UčitajListuUčenika:
                    response.messageResponse = Controller.Instance.VratiListuUčenika();
                    break;
                case Operation.PretražiUčenike:
                    response.messageResponse = Controller.Instance.PretraziUcenike(messagerequest.messageRequest as string);
                    if (response.messageResponse == null)
                    {
                        response.isSuccesfull = false;
                        response.ClientMessage = "Sistem ne moze da nadje ucenike po zadatoj vrednosti!";
                    }
                  
                    break;
                case Operation.UčitajListuUzrasta:
                    response.messageResponse = Controller.Instance.VratiListuUzrasta();
                    break;
                case Operation.ZapamtiGrupu:
                    response.isSuccesfull = Controller.Instance.ZapamtiGrupu(messagerequest.messageRequest as   Grupa);
                    if (!response.isSuccesfull)
                    {
                        response.ClientMessage = "Sistem ne može da zapamti grupu!";
                    }
                    break;
              
                case Operation.NadjiGrupe:
                    response.messageResponse = Controller.Instance.NadjiGrupe(messagerequest.messageRequest as string);
                    if (response.messageResponse == null)
                    {
                        response.isSuccesfull = false;
                        response.ClientMessage = "Sistem ne može da nadje grupe po zadatoj vrednosti!";
                    }
                  
                    break;
                case Operation.ZapamtiNovuGrupu:
                    response.isSuccesfull = Controller.Instance.ZapamtiNovuGrupu(messagerequest.messageRequest as Grupa);
                    if (!response.isSuccesfull)
                    {
                        response.ClientMessage = "Sistem ne može da zapamti novu grupu!";
                    }
                    break;
            
                case Operation.VratiPohadjanja:
                   response.messageResponse = Controller.Instance.VratiSvaPohadjanja();
                    break;
                
                case Operation.VratiTrazenuGrupu:
                    response.messageResponse = Controller.Instance.UcitajGrupu(messagerequest.messageRequest as Grupa);
                    if (response.messageResponse == null)
                    {
                        response.ClientMessage = "Sistem ne može da učita grupu!";
                        response.isSuccesfull = false;
                    }

                    break;
              
                case Operation.VratiVaspitačeNaProgramu:
                    response.messageResponse = Controller.Instance.VratiVaspitaceNaProgramu(messagerequest.messageRequest as Domain.Program);
                    break;
                case Operation.UcitajVaspitaca:
                    response.messageResponse = Controller.Instance.UcitajVaspitaca(messagerequest.messageRequest as Vaspitač);
                    if (response.messageResponse == null)
                    {
                        response.ClientMessage = "Sistem ne može da učita vaspitaca!";
                        response.isSuccesfull = false;
                    }

                    break;
                case Operation.UcitajUcenika:
                    response.messageResponse = Controller.Instance.UcitajUcenika(messagerequest.messageRequest as Učenik);
                    if (response.messageResponse == null)
                    {
                        response.ClientMessage = "Sistem ne može da učita učenika!";
                        response.isSuccesfull = false;
                    }
                    break;
                case Operation.UcitajProgram:
                    response.messageResponse = Controller.Instance.UcitajProgram(messagerequest.messageRequest as Domain.Program);
                    if (response.messageResponse == null)
                    {
                        response.ClientMessage = "Sistem ne može da učita program!";
                        response.isSuccesfull = false;

                    }
                    break;
                case Operation.ObisiVaspitaca:
                    response.isSuccesfull = Controller.Instance.ObrisiVaspitaca(messagerequest.messageRequest as Vaspitač);
                    if (!response.isSuccesfull)
                    {
                        response.ClientMessage = "Sistem ne može da obrise vaspitaca";
                    }
                    break;
               /* case Operation.EndCommunication:
                    kraj = true;
                    break;*/
                default:break;

            }
            return response;
        }

        private object lockobject = new object();
        internal void CloseSocket()
        {
            lock (lockobject)
            {
                if (clientSocket != null)
                {
                    
                    clientSocket.Shutdown(SocketShutdown.Both);
                    clientSocket.Dispose();
                    
                    clientSocket = null;
                    OdjavljenKlijent?.Invoke(this, EventArgs.Empty);//?/provera da li j enull
                }
            }
        }
    }
}
