using System;
using System.Net.Sockets;
using System.Net;
using System.Text;
using Exceptions;

namespace Lib
{
    public class Client
    {
        //private TcpClient TCPclient;
        private IPAddress ip;
        private int port;
        private Socket socket;
        private IPEndPoint endPoint;

        public Client(String ip, int port)
        {
            try
            {
                Console.WriteLine("Inicializando configuracion de EmotivClient...");
                this.ip = IPAddress.Parse(ip);
                this.port = port;
                Console.WriteLine("Se inicializo la configuracion del cliente correctamente...");

                Console.WriteLine("Inicializando Socket...");
                this.socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                Console.WriteLine("Se finalizo la creacion del socket correctamente...");
                
                Console.WriteLine("Inicializando el endpoint...");
                this.endPoint = new IPEndPoint(this.ip, this.port);
                Console.WriteLine("El endpoint fue levantado exitosamente...");
                
                Console.WriteLine("The connection was successfully initialized: {0}...", this.ip);
                Console.WriteLine("\n");
            }
            catch (Exception e)
            {
                Console.WriteLine("\n");
                Console.WriteLine("************************************************************************\n");
                Console.WriteLine("There was an error trying to initialize connection: {0}... {1}", this.ip, e.StackTrace);
                Console.WriteLine("************************************************************************\n");
                Console.WriteLine("\n");
                Console.WriteLine("\n");
            }

        }

        public void Connect()
        {
            try
            {                
                Console.WriteLine("Conectandose por socket al endpoint...");
                this.socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socket.Connect(this.endPoint);
                Console.WriteLine("Connected to IP: {0}", this.ip);
                Console.WriteLine("\n");
            }
            catch (Exception)
            {
                throw new ServerInitializeException(this.ip.ToString(), this.port);
            }
        }

        public void SendCommand(String cmd)
        {
            try
            {
                this.Connect();
                byte[] message = Encoding.ASCII.GetBytes(cmd);
                Console.WriteLine("Enviando un mensaje al servidor...");
                int bytesSent = socket.Send(message);
                Console.WriteLine("The message was successfully sent... ");
                Console.WriteLine("\n");
                this.Disconnect();
            }
            catch (Exception)
            {
                throw new MessageSenderException(this.ip.ToString(), this.port, cmd);
            }
        }

        public bool SendData()
        {
            try
            {
                byte[] message = Encoding.ASCII.GetBytes("Hoolaaa paochitaa.. Esta es una prueba para ver que pasa si en c# pongo un mensaje monstruoso. Tene en cuenta que C no tiene idea la cantidad de caracteres que le voy a enviar. Entonces, en C deberia hacer un Loop intentando ir cargando partes del mensaje y evitando que ocurra un buffer overflow. Estoy enviando este mensaje desde windows en c#, asi que quien va a mostrar este mensaje es el linux con un script en C");
                Console.WriteLine("Enviando un mensaje al servidor...");
                int bytesSent = socket.Send(message); 
                Console.WriteLine("The message was successfully sent... ");
                Console.WriteLine("\n");
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("\n");
                Console.WriteLine("************************************************************************\n");
                Console.WriteLine("There was an error trying to send message... {0}", e.StackTrace);
                Console.WriteLine("************************************************************************\n");
                Console.WriteLine("\n");
                Console.WriteLine("\n");
                return false;
            }
        }

        public void Disconnect()
        {
            try
            {
                Console.WriteLine("Desconectando el socket...");
                //socket.Shutdown(SocketShutdown.Both);
                socket.Dispose();
                Console.WriteLine("Disconnected to IP: {0}", this.ip);
                Console.WriteLine("\n");
            }
            catch (Exception)
            {
                throw new ServerDisconnectException(this.ip.ToString(), this.port);
            }
        }

        public IPAddress Ip
        {
            set { this.ip = value; }
            get { return this.ip; }
        }

        public int Port
        {
            set { this.port = value; }
            get { return this.port; }
        }


        public void ResetConfig()
        {
            Ip = null;
            port = 0;
        }
    }
}                                                                                                                                                                                                                                                             