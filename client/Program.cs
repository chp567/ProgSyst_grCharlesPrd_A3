using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Client
{
    class Client
    {
        private static Socket Connect()
        {
            try
            {
                IPHostEntry host = Dns.GetHostEntry("Localhost");
                IPAddress iPAddress = host.AddressList[1];
                IPEndPoint remote = new IPEndPoint(iPAddress, 11000);

                Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                client.Connect(remote);
                Console.WriteLine($"Socket Connected {client.RemoteEndPoint}");


                return client;
            }
            catch (Exception e)
            {

                Console.WriteLine(e.ToString());

                return null;
            }

        }

        private static void Listenening(Socket client)
        {
            byte[] data = new byte[1024];
            int recv = client.Receive(data);
            string input, stringData;

            stringData = Encoding.UTF8.GetString(data, 0, recv);

            Console.WriteLine(stringData);

            while (true)
            {
                input = "f";

                Console.WriteLine("Client: " + input);
                client.Send(Encoding.UTF8.GetBytes(input));

                recv = client.Receive(data);

                stringData = Encoding.UTF8.GetString(data, 0, recv);

                if (stringData == "exit")

                {
                    client.Send(Encoding.UTF8.GetBytes(input));
                    Disconnect(client);
                    break;
                }

                Console.WriteLine("Server: " + stringData);
            }
        }

        public static void Disconnect(Socket Socket)
        {
            Socket.Shutdown(SocketShutdown.Both);
            Socket.Close();
        }

        static void Main(string[] args)
        {
            Socket client = Connect();
            Listenening(client);
            //Disconnect(client);
        }
    }
}