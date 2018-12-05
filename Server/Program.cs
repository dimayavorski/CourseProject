using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Server.Model;

namespace Server
{
    class Program
    {
            static Context Database;
            static ServerObject server;
            static Thread listenThread;
            static void Main(string[] args)
                {
                try
            {
                server = new ServerObject();
                Database = new Context();
                listenThread = new Thread(server.Listen);
                listenThread.Start();
            }
            catch (Exception ex)
            {
                server.Disconnect();
                Console.WriteLine(ex.Message);
            }

               

            }
    }
    
}
