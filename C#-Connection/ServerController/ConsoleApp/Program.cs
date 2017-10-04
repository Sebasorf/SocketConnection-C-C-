using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lib;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SocketServer server = new SocketServer(8000);
            if (server.Bind())
            {
                server.startListeningServer();

            }

            Console.WriteLine("El sistema finalizo con errores...");
        }
    }
}
