using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
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
                    
                        message = GetMessage();
                        Console.WriteLine(message);

                        if (message.Contains("Авторизация"))
                        {
                            string[] splitted = message.Split('|');
                            var email = splitted[1];
                            var password = splitted[2];
                            var user = database.Users.Where(u => u.Email == email && u.Password == password).FirstOrDefault();
                            if (user != null)
                            {
                                message = String.Format("Подтверждено{0} {1} {2}|{3}|",user.SecondName,user.Name,user.MiddleName,user.Email);
                                foreach (var project in database.Projects)
                                {
                                    message += project.Name + "|";

                                }
                                message = message.Substring(0, message.Length - 1);
                                SendMessage(message);
                                Console.WriteLine(message);
                            }
                            else
                            {
                                SendMessage("Отказано в доступе");
                            }
                           
                        }
                        else 
                        if (database.Projects.Where(proj => proj.Name == message).FirstOrDefault() != null)
                        {
                            var obj = database.Projects.Where(proj => proj.Name == message).FirstOrDefault();

                            var people = database.People.Where(p => p.ProjectId == obj.Id);
                            message = null;
                            foreach (var human in people)
                            {
                                message += String.Format("{0} {1} {2} возвраст: {3} лет \r\n", human.Name, human.FirstName,
                                    human.LastName, human.Age);
                            }
                            message += String.Format("{0} доход \r\n{1} расход \r\n", obj.Profit,obj.Expense);
                            message += String.Format("Количество человек в проекте {0} \r\n", database.People.Where(p => p.ProjectId == obj.Id).Count().ToString());
                            SendMessage(message);

                        }
                        else 
                        if (message.Contains("рентабельность"))
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
                            var projname = splitted[3];
                            var obj = database.Projects.Where(p => p.Name == projname).FirstOrDefault();
                            if (obj != null)
                            {
                                obj.Profit = profit;
                                obj.Expense = expense;
                                database.SaveChanges();
                            }
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
                        else 
                        if (message.Contains("Почта"))
                        {
                           
                            SendEmail(message);
                        }
                    }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Клиент покинул сервер");
            }
          
        }

        private void SendEmail(string text)
        {
            
            //string[] splitted = text.Split('|');
            //string[] email = new string[] {splitted[1],splitted[2]};
            //string sender = splitted[0];
            //string body = splitted[3];
            //string projectName = splitted[4];
            string login = "yavorsky.dmitri@yandex.ru";
            string mailStepa = "rafalovich99@yandex.ru";
            string password = "test12345";
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(login);
            mail.Subject = "Анализ рентабельности проекта";
            mail.Body = String.Format("Отправитель : \r\nИнформация по проекту:\r\n");
            SmtpClient client = new SmtpClient("smtp.yandex.ru");
            
                mail.To.Add("galax_e@mail.ru, dimonsalyerrooock@mail.ru");
                client.Port = 25;
                client.Credentials = new NetworkCredential(login, password);
                client.EnableSsl = true;
                client.Send(mail);
            
          
        
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
