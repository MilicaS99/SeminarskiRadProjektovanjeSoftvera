using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
   public  class Server
    {
        private Socket serverSocket;
        private bool isRunning = false;
        private List<ClientHandler> clients = new List<ClientHandler>();

        public bool  Start()
        {
            try
            {
                serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                serverSocket.Bind(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999));
                serverSocket.Listen(5);
                return true;
            }catch(Exception ex)
            {
                Debug.WriteLine(">>>" + ex.Message);
                return false;
            }
        }

        public void HandleClients()//listen
        {
            try
            {
                while (true)
                {
                    Socket clientSocket = serverSocket.Accept();
                    ClientHandler clienthandler = new ClientHandler(clientSocket);
                    clients.Add(clienthandler);
                    clienthandler.OdjavljenKlijent += Handler_OdjavljenKlijent;
                    Thread  nitklijenta = new Thread(clienthandler.handleRequest);

                    nitklijenta.Start();



                }
            }
            catch (SocketException ex)
            {
                Debug.WriteLine(">>>" + ex.Message);
            }
        }

        private void Handler_OdjavljenKlijent(object sender, EventArgs e)
        {
            clients.Remove((ClientHandler)sender);
        }
        public void Stop()
        {
           
            serverSocket.Close();
            foreach(ClientHandler handler in clients.ToList())
            {
                handler.CloseSocket();
            }
        }
    }
}
