using System;
using System.Net;
using System.Net.Sockets;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public class SocketServer
    {
        private IPHostEntry localHostname;
        private IPAddress ip;
        private int port;
        private IPEndPoint localEndPoint;
        private Socket listener;

        public SocketServer(int port)
        {
            try
            {
                //Console.WriteLine("Inicializando configuracion del Server...");
                this.localHostname = Dns.Resolve(Dns.GetHostName());
                this.ip = localHostname.AddressList[0];
                this.port = port;
                Console.WriteLine("Se inicializo la configuracion del server correctamente...");

                //Console.WriteLine("Inicializando Socket...");
                this.listener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                Console.WriteLine("Se finalizo la creacion del socket correctamente...");

                //Console.WriteLine("Inicializando el endpoint...");
                this.localEndPoint = new IPEndPoint(this.ip, this.port);
                Console.WriteLine("El endpoint fue levantado exitosamente...");

                Console.WriteLine("The server was successfully initialized...");
                //Console.WriteLine("\n");
            }
            catch(Exception e)
            {
                Console.WriteLine("\n");
                Console.WriteLine("************************************************************************\n");
                Console.WriteLine("There was an error trying to initialize the server... {0}", e.StackTrace);
                Console.WriteLine("************************************************************************\n");
                Console.WriteLine("\n");
                Console.WriteLine("\n");
            }
        }

        public bool Bind()
        {
            try
            {
                //Console.WriteLine("Binding listener socket to this server process...");
                this.listener.Bind(localEndPoint);
                this.listener.Listen(2);
                Console.WriteLine("Se finalizo el bind y se levanto el listener correctamente...");
                Console.WriteLine("\n");
                //Console.WriteLine("\n"); 
                return true;
            }
            catch(Exception e)
            {
                Console.WriteLine("\n");
                Console.WriteLine("************************************************************************\n");
                Console.WriteLine("There was an error trying to binding socket... {0}", e.StackTrace);
                Console.WriteLine("************************************************************************\n");
                Console.WriteLine("\n");
                Console.WriteLine("\n");
                return false;
            }
        }

        public bool startListeningServer()
        {
            try
            {
                byte[] bytes = new Byte[20];
                String message;

                while (true)
                {
                    Console.WriteLine("Esperando nuevas conexiones...");
                    message = "";
                    Socket clientSocket = listener.Accept();
                    Console.WriteLine("Se recibio una nueva conexion de la IP: {0}...", clientSocket.RemoteEndPoint);
                    //Console.WriteLine("Se recibio una nueva conexion de la IP: {0}...", clientSocket.LocalEndPoint);

                    //Console.WriteLine("Se esta transmitiendo informacion...");
                    int bytesReceived = clientSocket.Receive(bytes);
                    while(bytesReceived!=0)
                    {
                        message += Encoding.ASCII.GetString(bytes, 0, bytesReceived);
                        bytesReceived = clientSocket.Receive(bytes);
                    }
                    Console.WriteLine("Finalizo la transmision de informacion...");
                    Console.WriteLine("\n");

                    Console.WriteLine("Mensaje recibido: {0}", message);
                    Console.WriteLine("\n");

                    //Console.WriteLine("Desconectandose de cliente...");
                    clientSocket.Shutdown(SocketShutdown.Both);
                    clientSocket.Close();
                    Console.WriteLine("Client disconnected...");
                    Console.WriteLine("\n");
                }

                Console.WriteLine("\n");
                //Console.WriteLine("\n");
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("\n");
                Console.WriteLine("************************************************************************\n");
                Console.WriteLine("There was an error while listening... {0}", e.StackTrace);
                Console.WriteLine("************************************************************************\n");
                Console.WriteLine("\n");
                Console.WriteLine("\n");
                return false;
            }
        }
    }
}
