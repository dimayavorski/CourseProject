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
        protected internal NetworkStream Stream { get; private set; }
        TcpClient client;
        public Context database;
        public ClientObject(TcpClient tcpClient)
        {
            
            client = tcpClient;
            database = new Context();

        }
        public void Process()
        {
            
            try
            {
                string message;
                Stream = client.GetStream();
                while (true)
                {
                    try
                    {
                        message = GetMessage();
                        Console.WriteLine(message);

                        if (message.Contains("Проекты"))
                        {
                            string namesOfProjects = "";
                          
                            foreach (var project in database.Projects)
                            {
                                message += project.Name + ",";
                            
                            }
                            message = message.Substring(0, message.Length - 1);
                            SendMessage(message);
                            Console.WriteLine(message);
                        }
                        else 
                        if (database.Projects.Where(proj => proj.Name == message).FirstOrDefault() != null)
                        {
                            var obj = database.Projects.Where(proj => proj.Name == message).FirstOrDefault();

                            var people = database.People.Where(p => p.ProjectId == obj.Id);
                            message = null;
                            foreach (var human in people)
                            {
                                message += String.Format("{0} {1} {2} возвраст: {3} \r\n", human.Name, human.FirstName,
                                    human.LastName, human.Age);
                            }
                            message += String.Format("{0} доход \r\n{1} расход \r\n", obj.Profit,obj.Expense);
                            message += String.Format("Количество человек в проекте {0} \r\n", database.People.Where(p => p.ProjectId == obj.Id).Count().ToString());
                            SendMessage(message);

                        }
                        else 
                        if (message.Contains("Рентабельность"))
                        {
                            string[] splitted = message.Split('|');
                            string some = splitted[1];
                            var obj = database.Projects.Where(pr => pr.Name==some).FirstOrDefault();
                            message = String.Format("Рентабельность = {0}%",Project.GetProfitAbility(obj.Profit, obj.Expense));
                            SendMessage(message);
                            Console.WriteLine(message);
                        }
                        else if (message.Contains("Посчитать"))
                        {
                            string[] splitted = message.Split('|');
                            double profit = Convert.ToDouble(splitted[1]);
                            double expense = Convert.ToDouble(splitted[2]);
                            SendMessage("Результат \r\n");
                            Thread.Sleep(100);
                            message = String.Format("{0} доход \r\n", profit);
                            Console.WriteLine(message);
                            SendMessage(message);
                            Thread.Sleep(100);
                            message = String.Format("{0} расход \r\n", expense);
                            Console.WriteLine(message);
                            SendMessage(message);
                            Thread.Sleep(100);
                            message = String.Format("Рентабельность = {0}%", Project.GetProfitAbility(profit,expense));
                            SendMessage(message);
                            Console.WriteLine(message);

                        }
                    }
                    catch
                    {
                        message = String.Format("покинул чат");
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

        public void SendMessage(string message)
        {
            byte[] data = Encoding.Unicode.GetBytes(message);
            Stream.Write(data, 0, data.Length);
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
