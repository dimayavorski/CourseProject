using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Server.Model;

namespace Server
{
    public class ClientObject
    {
        protected internal string Id { get; private set; }
        protected internal NetworkStream Stream { get; private set; }
        string userName;
        TcpClient client;
        public Context database;
        ServerObject server;
        public ClientObject(TcpClient tcpClient, ServerObject serverObject)
        {
            Id = Guid.NewGuid().ToString();
            client = tcpClient;
            server = serverObject;
            serverObject.AddConnection(this);
            database = new Context();

        }
        public void Process()
        {
            try
            {
                string message;
                Stream = client.GetStream();
                //message = GetMessage();
                //string namesOfProjects ="";
                //int i = 0;
                //foreach (var project in database.Projects)
                //{
                //    namesOfProjects += project.Name+",";
                //    i++;
                //}
                //namesOfProjects = namesOfProjects.Substring(0, namesOfProjects.Length - 1);
                //server.BroadcastMessage(namesOfProjects, this.Id);
                //Console.WriteLine(namesOfProjects);
                
                while (true)
                {
                    try
                    {
                        message = GetMessage();
                        Console.WriteLine(message);

                        if (message.Contains("Проекты"))
                        {
                            string namesOfProjects = "";
                            int i = 0;
                            foreach (var project in database.Projects)
                            {
                                namesOfProjects += project.Name + ",";
                                i++;
                            }
                            namesOfProjects = namesOfProjects.Substring(0, namesOfProjects.Length - 1);
                            server.BroadcastMessage(namesOfProjects, this.Id);
                            Console.WriteLine(namesOfProjects);
                        }
                        else 
                        if (database.Projects.Where(proj => proj.Name == message).FirstOrDefault() != null)
                        {
                            var obj = database.Projects.Where(proj => proj.Name == message).FirstOrDefault();
                            
                            //var response = database.People.Where(p => p.ProjectId == obj.Id).Count();
                            
                            message = String.Format("{0} доход", obj.Profit);
                            Console.WriteLine(message);
                            server.BroadcastMessage(message, this.Id);
                            message = String.Format("{0} расход", obj.Expense);
                            Console.WriteLine(message);
                            server.BroadcastMessage(message, this.Id);
                            message =String.Format("Количество человек в проекте {0}",database.People.Where(p => p.ProjectId == obj.Id).Count().ToString());
                            Console.WriteLine(message);
                            server.BroadcastMessage(message, this.Id);

                        }
                        else 
                        if (message.Contains("Рентабельность"))
                        {
                            string[] splitted = message.Split('|');
                            string some = splitted[1];
                            var obj = database.Projects.Where(pr => pr.Name==some).FirstOrDefault();
                            message = String.Format("Рентабельность = {0}%",Project.GetProfitAbility(obj.Profit, obj.Expense));
                            server.BroadcastMessage(message,this.Id);
                            Console.WriteLine(message);
                        }
                        else if (message.Contains("Посчитать"))
                        {
                            string[] splitted = message.Split('|');
                            double profit = Convert.ToDouble(splitted[1]);
                            double expense = Convert.ToDouble(splitted[2]);
                            server.BroadcastMessage("Результат вашей операции",this.Id);
                            Thread.Sleep(100);
                            message = String.Format("{0} доход",profit);
                            Console.WriteLine(message);
                            server.BroadcastMessage(message, this.Id);
                            Thread.Sleep(100);
                            message = String.Format("{0} расход",expense);
                            Console.WriteLine(message);
                            server.BroadcastMessage(message, this.Id);
                            Thread.Sleep(100);
                            message = String.Format("Рентабельность = {0}%", Project.GetProfitAbility(profit,expense));
                            server.BroadcastMessage(message,this.Id);
                            Console.WriteLine(message);

                        }


                        //else
                        //{
                        //    message.Split(',');
                        //}
                    }
                    catch
                    {
                        message = String.Format("{0}:покинул чат", userName);
                        Console.WriteLine(message);
                        break;
                    }

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            //finally
            //{
            //    server.RemoveConnection(this.Id);
            //    Close();
            //}
        }
        private string GetMessage()
        {
            byte[] data = new byte[64];
            StringBuilder builder = new StringBuilder();
            int bytes = 0;
            do
            {
                bytes = Stream.Read(data, 0, data.Length);
                builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
            } while (Stream.DataAvailable);
            return builder.ToString();
        }
  
        protected internal void Close()
        {
            if (Stream != null)
                Stream.Close();
            if (client != null)
                client.Close();
        }

    }
}
