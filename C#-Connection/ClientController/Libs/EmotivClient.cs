using System;
using System.Net.Sockets;
using System.Net;
using System.Text;

namespace Libs
{
    public class EmotivClient
    {
        //private TcpClient TCPclient;
        private IPAddress ip;
        private int port;
        private Socket socket;
        private IPEndPoint endPoint;

        public EmotivClient(String ip, int port){
            try
            {
                this.ip = IPAddress.Parse(ip);
                this.port = port;
                //TCPclient = new TcpClient();
                //socket = TCPclient.Client;
                this.socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                this.endPoint = new IPEndPoint(this.ip, this.port);
                Console.WriteLine("The connection was successfully initialized: {0}...", this.socket.RemoteEndPoint.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine("There was an error trying to initialize connection: {0}... {1}", this.socket.RemoteEndPoint.ToString(), e.StackTrace);
            }

        }

        public bool Connect()
        {
            try
            {
                socket.Connect(this.endPoint);
                Console.WriteLine("Connected to IP: {0}", this.socket.RemoteEndPoint.ToString());
                return true;
            }
            catch(Exception e)
            {
                Console.WriteLine("There was an error trying to connect IP: {0}... {1}", this.socket.RemoteEndPoint.ToString(), e.StackTrace);
                return false;
            }
        }

        public bool SendData()
        {
            try
            {
                byte[] message = Encoding.ASCII.GetBytes("Esta es una pruebinia.");
                int bytesSent = socket.Send(message);
                Console.WriteLine("The message was successfully sent... ");
                return true;
            }
            catch(Exception e)
            {
                Console.WriteLine("There was an error trying to send message... {0}", e.StackTrace);
                return false;
            }
        }

        public bool Disconnect()
        {
            try
            {
                socket.Shutdown(SocketShutdown.Both);
                socket.Dispose();
                Console.WriteLine("Disconnected to IP: {0}", this.socket.RemoteEndPoint.ToString());
                return true;
            }
            catch(Exception e)
            {
                Console.WriteLine("There was an error trying to connect IP: {0}... {1}", this.socket.RemoteEndPoint.ToString(), e.StackTrace);
                return false;
            }
        }
        
    }
}
