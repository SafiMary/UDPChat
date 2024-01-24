using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace UDPChat
{
    public partial class Form1 : Form
    {
        IPEndPoint remoteEndPoint;
        Thread threadRec;
        public Form1()
        {
            InitializeComponent();
            //buttonConnect_Click(null, null);
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            UdpClient udpClient = new UdpClient();
            byte[] buffer = Encoding.Unicode.GetBytes(textBoxMess.Text);
            udpClient.Send(buffer,buffer.Length,remoteEndPoint);
            udpClient.Close();
            //textBoxAllmess.Text+= ("$$$" + textBoxMess.Text+ "\r\n");
            //textBoxMess.Clear();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            remoteEndPoint =  new IPEndPoint(IPAddress.Parse(MTIPadress.Text),(int)NUPort.Value);
            //remoteEndPoint = new IPEndPoint(IPAddress.Any, (int)NUPort.Value);
            //remoteEndPoint = new IPEndPoint(IPAddress.Parse("192.168.88.0"), (int)NUPort.Value);
            threadRec = new Thread(new ThreadStart(ThreadReceive));
            threadRec.Start();
        }
        public void ThreadReceive()
        {
            try
            {
                while (true) { 
                UdpClient udpClient = new UdpClient((int)NUPort.Value);
                 IPEndPoint recEndPoint = new IPEndPoint(IPAddress.Any,(int)NUPort.Value);
                byte[] response = udpClient.Receive(ref recEndPoint);
                Invoke((MethodInvoker)delegate
                {
                    //textBoxAllmess.Lines.Append(Encoding.Unicode.GetString(response));
                    textBoxAllmess.Text+= recEndPoint.Address.ToString() + " "+ (Encoding.Unicode.GetString(response) + "\r\n");
                });
                udpClient.Close();
                }
            }
            catch { }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
           
            threadRec.Abort();
        }
    }
}
