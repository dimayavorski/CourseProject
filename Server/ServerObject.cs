using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Server.Model;

namespace Server
{
    public class ServerObject
    {
        static TcpListener tcpListener;
        List<ClientObject> clients = new List<ClientObject>();
        protected internal void AddConnection(ClientObject clientObject)
        {
            clients.Add(clientObject);
        }
        protected internal void RemoveConnection(string Id)
        {
            ClientObject client = clients.FirstOrDefault(c => c.Id == Id);
            if (client != null)
            {
                clients.Remove(client);
            }
        }

        protected internal void Disconnect()
        {
            tcpListener.Stop();
            for (int i = 0; i < clients.Count; i++)
            {
                clients[i].Close();

            }
            Environment.Exit(0);
        }
        protected internal void Listen()
        {
            try
            {
                tcpListener = new TcpListener(IPAddress.Any, 8888);
                tcpListener.Start();
                Console.WriteLine("Сервер запущен. Ожидание подключений");
                while (true)
                {
                    TcpClient tcpClient = tcpListener.AcceptTcpClient();
                    ClientObject clientObject = new ClientObject(tcpClient, this);
                    Thread clientThread = new Thread(clientObject.Process);
                    clientThread.Start();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }
        protected internal void BroadcastMessage(string message, string Id)
        {
            //byte[] data = Encoding.Unicode.GetBytes(message);
            //for (int i = 0; i < clients.Count; i++)
            //{
            //    if (clients[i].Id != Id)
            //    {
            //        clients[i].Stream.Write(data, 0, data.Length);
            //    }
            //}
            byte[] data = Encoding.Unicode.GetBytes(message);
            var client = clients.Where(c => c.Id == Id).SingleOrDefault();
            //TcpClient clientStr = tcpListener.AcceptTcpClient();

            //using (MemoryStream ms = new MemoryStream())
            //{
            //    Message message = Helper.Serialize(projects);

            //}
            client.Stream.Write(data, 0, data.Length);
        }
    }
}
