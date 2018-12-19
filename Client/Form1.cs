using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        private static string userName;
        private const string host = "127.0.0.1";
        private const int port = 8888;
        static TcpClient client;
        private static Thread receiveThread;
        public delegate void InvokeDel();
        static NetworkStream stream;
        public Form1()
        {
            InitializeComponent();
            tabControl1.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
      

 
        public void ReceiveMessage()
        {
            try
            {
                while (true)
                {
                    
                    byte[] data = new byte[64]; // буфер для получаемых данных 
                    StringBuilder builder = new StringBuilder();
                    int bytes = 0;
                    do
                    {
                        bytes = stream.Read(data, 0, data.Length);
                        builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
                    } while (stream.DataAvailable);

                    string message = builder.ToString();
                    if (message.Contains("Подтверждено"))
                    {
                        message = message.Substring(12);
                        string[] names = message.Split('|');

                        Invoke(new MethodInvoker(() =>
                        {

                            tabControl1.Visible = true;
                            txtFIO.Text = names[0];
                            txtEmail.Text = names[1];
                            for (int i = 2; i < names.Length; i++)
                            {
                            comboBox1.Items.Add(names[i]);

                            }
                            comboBox1.SelectedItem = names[2];

                        }));
                    }
                    else if (message == "Отказано в доступе")
                    {
                        MessageBox.Show("Отказано в доступе");
                    }
                    else
                    {
                        string[] names = message.Split(',');
                        Invoke(new MethodInvoker(() =>
                        {
                            outputBox.Text += message;
                            txtComment.Text = outputBox.Text;
                        }));
                       
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Disconnect();
            }

        }
        static void SendMessage(string message)
        {

            byte[] data = Encoding.Unicode.GetBytes(message);
            stream.Write(data, 0, data.Length);
        }
        private void ShowProjectInfo_Click(object sender, EventArgs e)
        {
            outputBox.Clear();
            var message = comboBox1.SelectedItem.ToString();
            SendMessage(message);
            

        }
        static void Disconnect()
        {
            if (stream != null)
                stream.Close();//отключение потока 
            if (client != null)
                client.Close();//отключение клиента 
            Environment.Exit(0); //завершение процесса 
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            try
            {
                userName = textBoxName.Text.ToString();
                client = new TcpClient();

                client.Connect(host, port);
                stream = client.GetStream();
               
                string message = "Авторизация|" + textBoxName.Text + '|' + txtPassword.Text; 
                SendMessage(message);
                receiveThread = new Thread(ReceiveMessage);
                receiveThread.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void ShowProfitAbility_Click(object sender, EventArgs e)
        {
           
            string values = outputBox.Text;
            string message = "рентабельность|"+comboBox1.SelectedItem.ToString();
            SendMessage(message);

        }

        private void btnGetProfitAbility_Click(object sender, EventArgs e)
        {
            outputBox.Clear();
            string message =  "Посчитать"+ "|"+ txtProfit.Text + "|" + txtExpense.Text + "|" + comboBox1.SelectedItem.ToString();
            SendMessage(message);
        }

     
        

        private void SendEmail_Click(object sender, EventArgs e)
        {
            var emails =  txtEmail.Text.Split(',');
            //string message = "Почта" + txtFIO.Text + "|" + emails[0] + "|" +emails[1]  + "|" + txtComment.Text + "|" + comboBox1.SelectedItem.ToString();
            SendMessage("Почта");
            MessageBox.Show("Сообщение отправлено");

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
