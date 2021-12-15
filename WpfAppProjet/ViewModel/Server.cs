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
        public Socket ServerConnect()
        {
            IPHostEntry host = Dns.GetHostEntry("localhost");
            IPAddress ipAddress = host.AddressList[1];
            //Console.WriteLine(ipAddress);
            IPEndPoint Local = new IPEndPoint(ipAddress, 11000);

            try
            {
                Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                server.Bind(Local);

                server.Listen(100);

                //Console.WriteLine("Waiting for a connection");

                return server;
            }
            catch (Exception e)
            {

                //Console.WriteLine(e.ToString());

                return null;
            }
        }

        public Socket ClientConnect(Socket socket)
        {

            try
            {
                Socket client = socket.Accept();


                IPEndPoint ClientInfo = client.RemoteEndPoint as IPEndPoint;

                string ClientIP = ClientInfo.Address.ToString();
                string ClientPort = ClientInfo.Port.ToString();

                //Console.WriteLine(ClientIP + "\n" + ClientPort);

                return client;
            }
            catch (Exception e)
            {

                //Console.WriteLine(e.ToString());
                return null;
            }
        }

        public void NetworkListener(Socket client, List<string> logs)
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

                        //Console.WriteLine("Client: " + Encoding.UTF8.GetString(data, 0, recv));

                        input = log;

                        //Console.WriteLine("Server : " + input);

                        client.Send(Encoding.UTF8.GetBytes(input));
                    }
                    input = "exit";
                    break;
                }
                catch (SocketException e)
                {
                    //Console.WriteLine("Error receiving data.");
                }
            }
            /*
            //données du client
            string data = null;
            byte[] bytes = null;

            while (true)
            {
                bytes = new byte[1024];
                int bytesRec = client.Receive(bytes);
                data += Encoding.ASCII.GetString(bytes, 0, bytesRec);
                if (data.IndexOf("<EOF>") > -1)
                {
                    break;
                }
                Console.WriteLine($"Client : {data}");

                byte[] msg = Encoding.ASCII.GetBytes(data);
                client.Send(msg);
            }*/
        }

        public void Disconnecting(Socket socket)
        {
            //socket.Shutdown(SocketShutdown.Both);
            socket.Close();
        }
    }
}
