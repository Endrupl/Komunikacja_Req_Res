using NetMQ;
using NetMQ.Sockets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramRequestResponseServer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Task task = Task.Run(() => server());
        }
        void server()
        {
            using (var responseSocket = new ResponseSocket("@tcp://*:5555"))
            {
                while (true)
                {
                    string response = responseSocket.ReceiveFrameString();
                    switch (response)
                    {
                        case "date":
                            responseSocket.SendFrame(DateTime.Now.ToString("dddd, dd MMMM yyyy"));
                            break;
                        case "time":
                            responseSocket.SendFrame(DateTime.Now.ToString("HH:mm:ss"));
                            break;
                    }
                    MethodInvoker methodInvoker = () => sendLogs(response);
                    Invoke(methodInvoker);
                }
            }
        }

        void sendLogs(string message)
        {
            switch (message)
            {
                case "date":
                    windowLogs.Items.Add(DateTime.Now.ToString() + ". Pomyślnie otrzymaną prośbę o datę");
                    break;
                case "time":
                    windowLogs.Items.Add(DateTime.Now.ToString() + ". Pomyślnie otrzymaną prośbę o czas");
                    break;
            }
        }
    }
}
