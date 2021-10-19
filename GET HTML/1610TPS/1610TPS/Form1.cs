using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using System.Net.Sockets;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnAnalizza_Click(object sender, EventArgs e)
        {
            IPHostEntry ipHostInfo = Dns.GetHostEntry(txtSito.Text);
            IPAddress ipAddress = ipHostInfo.AddressList[0];
            IPEndPoint remoteEP = new IPEndPoint(ipAddress, 80);

            Socket client = new Socket(ipAddress.AddressFamily,
                SocketType.Stream, ProtocolType.Tcp);

            try
            {
                string getRequest = "GET " + txtSito.Text + " HTTP/1.1\r\n" +
                    "Host: " + ipAddress.ToString() + "\r\n" +
                    "\r\n";

                client.Connect(remoteEP);
                client.Send(Encoding.ASCII.GetBytes(getRequest));
                String page = "";
                byte[] bytesRecived = new byte[1024];
                int bytesCnt = 0;

                do
                {
                    bytesCnt = client.Receive(bytesRecived, bytesRecived.Length, 0);
                    page = page + Encoding.ASCII.GetString(bytesRecived, 0, bytesCnt);
                } while (bytesCnt == bytesRecived.Length);

                txtbho.Text = page;

            }

            catch { }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
