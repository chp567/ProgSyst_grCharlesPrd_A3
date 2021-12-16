using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppProjet.ViewModel
{
    class Server
    {
        public Socket ServerConnect() //prepare the server connection
        {
            IPHostEntry host = Dns.GetHostEntry("localhost");
            IPAddress ipAddress = host.AddressList[1];
            IPEndPoint Local = new IPEndPoint(ipAddress, 11000);

            try
            {
                Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                server.Bind(Local);

                server.Listen(100);

                return server;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public Socket ClientConnect(Socket socket) //connect the client
        {

            try
            {
                Socket client = socket.Accept();


                IPEndPoint ClientInfo = client.RemoteEndPoint as IPEndPoint;

                string ClientIP = ClientInfo.Address.ToString();
                string ClientPort = ClientInfo.Port.ToString();

                return client;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public void NetworkListener(Socket client, List<string> logs) //listen the network to see if message is sent
        {
            string input; int recv;
            string welcome = "Bienvenue sur le serveur ...";

            byte[] data = new byte[1024];

            data = Encoding.UTF8.GetBytes(welcome);

            client.Send(data, data.Length, SocketFlags.None);


            while (true)
            {
                try
                {
                    foreach (string log in logs)
                    {
                        recv = client.Receive(data);

                        input = log;

                        client.Send(Encoding.UTF8.GetBytes(input));
                    }
                    input = "exit";
                    break;
                }
                catch (SocketException e)
                {

                }
            }
        }

        public void Disconnecting(Socket socket) //disconnect the server
        {
            socket.Close();
        }
    }
}
