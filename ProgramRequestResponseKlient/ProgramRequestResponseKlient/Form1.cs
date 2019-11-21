using NetMQ;
using NetMQ.Sockets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramRequestResponseKlient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void receiveData()
        {
            try
            {
                if (pickDate.Checked)
                {
                    using (var requestSocket = new RequestSocket(">tcp://localhost:5555"))
                    {
                        requestSocket.SendFrame("date");
                        windowLogs.Items.Add(DateTime.Now.ToString() + ". Wysłano prośbę o datę");
                        DateTime dateTime = DateTime.Parse(requestSocket.ReceiveFrameString());
                        windowLogs.Items.Add(DateTime.Now.ToString() + ". Odebraną datę: " + dateTime.ToString("dddd, dd MMMM yyyy"));
                    }
                }
                if(pickTime.Checked)
                {
                    using (var requestSocket = new RequestSocket(">tcp://localhost:5555"))
                    {
                        requestSocket.SendFrame("time");
                        windowLogs.Items.Add(DateTime.Now.ToString() + ". Wysłano prośbę o czas");
                        TimeSpan timeSpan = TimeSpan.Parse(requestSocket.ReceiveFrameString());
                        windowLogs.Items.Add(DateTime.Now.ToString() + ". Odebraną czas: " + timeSpan.ToString());
                    }
                }
            }
            catch(SocketException se)
            {
                MessageBox.Show(se.Message);
            }
        }

        private void pick5second_CheckedChanged(object sender, EventArgs e)
        {
            if (pick5second.Checked)
            {
                windowLogs.Items.Add("Wybrano opcje odświeżania co 5 sekund");
                pick10second.Enabled = false;
                pickEvery.Enabled = false;
                timer1.Interval = 5000; // czas w milisekundach czyli 5s = 5000
                timer1.Start();
            }
            else
            {
                pick10second.Enabled = true;
                pickEvery.Enabled = true;
                timer1.Stop();
            }
        }

        private void pick10second_CheckedChanged(object sender, EventArgs e)
        {
            if (pick10second.Checked)
            {
                windowLogs.Items.Add("Wybrano opcje odświeżania co 10 sekund");
                pick5second.Enabled = false;
                pickEvery.Enabled = false;
                timer1.Interval = 10000; // czas w milisekundach czyli 10s = 10000
                timer1.Start();
            }
            else
            {
                pick5second.Enabled = true;
                pickEvery.Enabled = true;
                timer1.Stop();
            }
        }

        private void pickEvery_CheckedChanged(object sender, EventArgs e)
        {
            if (pickEvery.Checked)
            {
                try
                {
                    windowLogs.Items.Add("Wybrano niestandardową opcje odświeżania co: " + textSecond.Text + " sekund.");
                    pick5second.Enabled = false;
                    pick10second.Enabled = false;
                    timer1.Interval = Int32.Parse(textSecond.Text) * 1000;
                    timer1.Start();
                }
                catch(FormatException fe)
                {
                    MessageBox.Show(fe.Message);
                    pickEvery.Checked = false;
                }
                
            }
            else
            {
                pick5second.Enabled = true;
                pick10second.Enabled = true;
                timer1.Stop();
            }
        }

        private void textSecond_TextChanged(object sender, EventArgs e)
        {
            timer1.Interval = Int32.Parse(textSecond.Text) * 1000;
        }

        private void receiveButton_Click(object sender, EventArgs e)
        {
            receiveData();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            receiveData();
        }
    }
}
