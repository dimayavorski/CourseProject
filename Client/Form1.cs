using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        public void ReceiveData()
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
                    }
                    while (stream.DataAvailable);
                    string message = builder.ToString();
                    string[] names = message.Split(',');
                    Invoke(new MethodInvoker(() =>
                    {
                        
                        outputBox.Text += message + "\r\n";
                        

                    }));


                
               

            }

        }
        public void ReceiveMessage()
        {

            
                
                    byte[] data = new byte[64]; // буфер для получаемых данных 
                    StringBuilder builder = new StringBuilder();
                    int bytes = 0;
                    do
                    {
                        bytes = stream.Read(data, 0, data.Length);
                        builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
                    }
                    while (stream.DataAvailable);
                    string message = builder.ToString();
                    string[] names = message.Split(',');
                    Invoke(new MethodInvoker(() =>
                    {
                        
                        comboBox1.Items.AddRange(names);
                        comboBox1.SelectedItem = names[0];

                    }));


                
                

            

        }
        static void SendMessage(string message)
        {

            byte[] data = Encoding.Unicode.GetBytes(message);
            stream.Write(data, 0, data.Length);
        }
        private void ShowProjectInfo_Click(object sender, EventArgs e)
        {
            
           
            var message = comboBox1.SelectedItem.ToString();
            outputBox.Clear();
            
            receiveThread = new Thread(ReceiveData);
            receiveThread.Start();
            SendMessage(message);

        }
        //static void Disconnect()
        //{
        //    if (stream != null)
        //        stream.Close();//отключение потока 
        //    if (client != null)
        //        client.Close();//отключение клиента 
        //    Environment.Exit(0); //завершение процесса 
        //}

        private void Connect_Click(object sender, EventArgs e)
        {
            try
            {
                userName = textBoxName.Text.ToString();
                client = new TcpClient();

                client.Connect(host, port);
                stream = client.GetStream();
                string message = userName;
                message = "Проекты";
                byte[] data = Encoding.Unicode.GetBytes(message);
                stream.Write(data, 0, data.Length);
                receiveThread = new Thread(ReceiveMessage);
                receiveThread.Start();
                messageLabel.Text = "Добро пожаловать " + userName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void ShowProfitAbility_Click(object sender, EventArgs e)
        {
           
            string values = outputBox.Text;
            string message = "Рентабельность|"+comboBox1.SelectedItem.ToString();
            

            SendMessage(message);

        }

        private void btnGetProfitAbility_Click(object sender, EventArgs e)
        {
            outputBox.Clear();
            string message =  "Посчитать"+ "|"+ txtProfit.Text + "|" + txtExpense.Text;
            SendMessage(message);
        }
    }
}
