using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPSIT_ToolLibrary;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        int CounterA;
        String sub = "", subdue = "";

        private void btnAnalizza_Click(object sender, EventArgs e)
        {

            CounterA++;
                String prova = "";
             int lunghezza = 0, lunghezzadue = 0;
                String provadue = "";
             txtReply.Text = txtGet.Text;
                String Url = txtSito.Text;
                Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPAddress[] host = Dns.GetHostAddresses(Url);
                IPAddress Ip_Host = host[0];
             socket.Connect(Ip_Host.ToString(), 80);
      string getRequest =
            "GET / HTTP/1.1\r\n" +
            "Host: " + Ip_Host +
            "\r\nConnection: keep-alive\r\n" +
            "Accept: text/html\r\n" +
            "User-Agent: Google\r\n\r\n";
             socket.Send(Encoding.ASCII.GetBytes(getRequest));
                String page = null;
            byte[] bytesReceived = new byte[1024];
                  int bytes = 0;
            do
            {
                bytes = socket.Receive(bytesReceived, bytesReceived.Length, 0);
                page += Encoding.ASCII.GetString(bytesReceived, 0, bytes);

            } while (bytes == bytesReceived.Length);

            txtGet.Text = page;
            if (CounterA == 2)
            {

                prova = txtGet.Text;
                lunghezza = prova.Length;
                provadue = txtReply.Text;
                lunghezzadue = provadue.Length;
                sub = prova.Substring(0, lunghezza);
                subdue = provadue.Substring(0, lunghezzadue);
            }
            if (prova != provadue)
            {
                Console.WriteLine(prova);
                Console.WriteLine(provadue);
                sendemail();
                MessageBox.Show("|- INVIO MAIL EFFETTUATO -|");
            }

        }

        private void txtReply_TextChanged(object sender, EventArgs e)
        {

        }

        public void sendemail()
        {

            byte[] bytes = new byte[1024];
            String url = "smtp.gmail.com";
            IPHostEntry ipHostInfo = Dns.GetHostEntry(url);
            IPAddress ipAddress = ipHostInfo.AddressList[0];
            IPEndPoint remoteEP = new IPEndPoint(ipAddress, 465);
            // Create a TCP/IP  socket.  
            SocketSSL client = new SocketSSL(url, ipAddress.AddressFamily,
                SocketType.Stream, ProtocolType.Tcp);

            try
            {
                client.Connect(remoteEP);

                btnAnalizza.Enabled = false;


                byte[] msg = Encoding.ASCII.GetBytes("EHLO SmtpViaSocketV2" + Environment.NewLine); //textBox3.Text + 
                int bytesSent = client.Send(msg);
                int bytesRec = client.Receive(bytes);
                String message = Encoding.ASCII.GetString(bytes, 0, bytesRec);


                msg = Encoding.ASCII.GetBytes("auth login" + Environment.NewLine);
                bytesSent = client.Send(msg);
                bytesRec = client.Receive(bytes);
                message = Encoding.ASCII.GetString(bytes, 0, bytesRec);


                msg = Encoding.ASCII.GetBytes(Base64Encode("antonelli.nicola@franchettisalviani.net") + Environment.NewLine);
                bytesSent = client.Send(msg);
                bytesRec = client.Receive(bytes);
                message = Encoding.ASCII.GetString(bytes, 0, bytesRec);


                msg = Encoding.ASCII.GetBytes(Base64Encode("Nick0311") + Environment.NewLine);
                bytesSent = client.Send(msg);
                bytesRec = client.Receive(bytes);
                message = Encoding.ASCII.GetString(bytes, 0, bytesRec);


                msg = Encoding.ASCII.GetBytes("MAIL FROM: <" + "antonelli.nicola@franchettisalviani.net" + ">" + Environment.NewLine);
                bytesSent = client.Send(msg);
                bytesRec = client.Receive(bytes);
                message = Encoding.ASCII.GetString(bytes, 0, bytesRec);


                msg = Encoding.ASCII.GetBytes("RCPT TO: <" + "francesco.adriani@franchettisalviani.net" + ">" + Environment.NewLine);
                bytesSent = client.Send(msg);
                bytesRec = client.Receive(bytes);
                message = Encoding.ASCII.GetString(bytes, 0, bytesRec);


                msg = Encoding.ASCII.GetBytes("DATA" + Environment.NewLine);
                bytesSent = client.Send(msg);
                bytesRec = client.Receive(bytes);
                message = Encoding.ASCII.GetString(bytes, 0, bytesRec);


                msg = Encoding.ASCII.GetBytes("From: antonelli.nicola@franchettisalviani.net \n To: francesco.adriani@franchettisalviani.net  \n\r Subject: COMPITI PER 19 OTTOBRE  \n\r /COMPITO COMPLETATO" + Environment.NewLine + "." + Environment.NewLine);
                bytesSent = client.Send(msg);
                bytesRec = client.Receive(bytes);
                message = Encoding.ASCII.GetString(bytes, 0, bytesRec);

                client.Shutdown(SocketShutdown.Both);
                client.Close();
            }

            catch (Exception ex) { }
        }



        public static String REQ_HTTP(string Url)
        {
                HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(Url);
            myRequest.Method = "GET";
                WebResponse myResponse = myRequest.GetResponse();
                StreamReader sr = new StreamReader(myResponse.GetResponseStream(), System.Text.Encoding.UTF8);
            string result = sr.ReadToEnd();
            sr.Close();
            myResponse.Close();

            return result;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
