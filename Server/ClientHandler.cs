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

        private bool kraj = false;
        internal void handleRequest()
        {
            try
            {
                while (!kraj)
                {
                    Message messagerequest = helper.Receive<Message>();
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
                    break;
                case Operation.ZapamtiProgram:
                    response.Operation = Operation.ZapamtiProgram;
                    response.isSuccesfull = Controller.Instance.ZapamtiProgram(messagerequest.messageRequest as Domain.Program);
                    break;
                case Operation.NadjiPrograme:
                    response.Operation = Operation.NadjiPrograme;
                    response.messageResponse = Controller.Instance.NadjiPrograme(messagerequest.messageRequest as string);
                    if (response.messageResponse == null)
                    {
                        response.isSuccesfull = false;
                    }
                    else
                    {
                        response.isSuccesfull = true;
                    }
                    break;
                case Operation.UčitajListuPrograma:
                    response.messageResponse = Controller.Instance.VratiListuPrograma();
                    break;
                case Operation.ZapamtiVaspitača:
                    response.isSuccesfull = Controller.Instance.ZapamtiVaspitaca(messagerequest.messageRequest as Vaspitač);
                    break;
                case Operation.ZapamtiUčenika:
                    response.isSuccesfull = Controller.Instance.ZapamtiUčenika(messagerequest.messageRequest as Učenik);
                    break;
                case Operation.UčitajListuVaspitača:
                    response.messageResponse = Controller.Instance.VratiListuVaspitaca();
                    break;
                case Operation.PretražiVaspitača:
                    response.messageResponse = Controller.Instance.VratiVaspitacePoKriterijumu(messagerequest.messageRequest as string);
                    if (response.messageResponse == null)
                    {
                        response.isSuccesfull = false;
                    }
                    else
                    {
                        response.isSuccesfull = true;
                    }
                    break;
                case Operation.zapamtiNovogVaspitača:
                    response.isSuccesfull = Controller.Instance.ZapamtiIzmenjenogVaspitača(messagerequest.messageRequest as Vaspitač);
                    break;
                case Operation.UčitajListuUčenika:
                    response.messageResponse = Controller.Instance.VratiListuUčenika();
                    break;
                case Operation.PretražiUčenike:
                    response.messageResponse = Controller.Instance.NadjiUčenike(messagerequest.messageRequest as string);
                    if (response.messageResponse == null)
                    {
                        response.isSuccesfull = false;
                    }
                    else
                    {
                        response.isSuccesfull = true;
                    }
                    break;
                case Operation.UčitajListuUzrasta:
                    response.messageResponse = Controller.Instance.VratiListuUzrasta();
                    break;
                case Operation.ZapamtiGrupu:
                    response.isSuccesfull = Controller.Instance.ZapamtiGrupu(messagerequest.messageRequest as List<object>);
                    break;
                case Operation.VratiSveGrupe:
                    response.messageResponse = Controller.Instance.VratiSveGrupe();
                    break;
                case Operation.NadjiGrupe:
                    response.messageResponse = Controller.Instance.NadjiGrupe(messagerequest.messageRequest as string);
                    if (response.messageResponse == null)
                    {
                        response.isSuccesfull = false;
                    }
                    else
                    {
                        response.isSuccesfull = true;
                    }
                    break;
                case Operation.ZapamtiNovuGrupu:
                    response.isSuccesfull = Controller.Instance.ZapamtiNovuGrupu(messagerequest.messageRequest as Grupa);
                    break;
                case Operation.ZapamtiPohadjanje:
                    response.isSuccesfull = Controller.Instance.ZapamtiPohadjanje(messagerequest.messageRequest as Pohadjanje);
                    break;
                case Operation.VratiPohadjanja:
                    response.messageResponse = Controller.Instance.VratiPohadjanja();
                    break;
                case Operation.Kraj:
                    kraj = true;
                    break;
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
                    kraj = true;
                    clientSocket.Shutdown(SocketShutdown.Both);
                    clientSocket.Close();
                    clientSocket = null;
                    OdjavljenKlijent?.Invoke(this, EventArgs.Empty);
                }
            }
        }
    }
}
