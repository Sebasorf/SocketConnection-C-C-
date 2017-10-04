using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class ServerInitializeException: Exception
    {
        public ServerInitializeException(String IP, int port): base("Could not initialize connection to server " + IP + ":" + port + ".")
        {
        }
    }
}
