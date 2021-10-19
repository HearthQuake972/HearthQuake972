using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Net.Sockets;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TPSIT_ToolLibrary
{
    public class SocketSSL
    {
        private Socket socket;
        Stream networkStream;
        SslStream sslStream;
        String serverNameForCertificate;
        public SocketSSL(String serverNameForCertificate, AddressFamily addressFamily, SocketType socketType, ProtocolType protocolType)
        {
            socket = new Socket(addressFamily, socketType, protocolType);
            this.serverNameForCertificate = serverNameForCertificate;
        }

        public void Connect(EndPoint endPoint )
        {
            socket.Connect(endPoint);
            networkStream = new NetworkStream(socket);
            //sslStream = new SslStream(networkStream, false,
            //    new RemoteCertificateValidationCallback(ValidateServerCertificate), null);
            // Create a TCP/IP client socket. machineName is the host running the server application.

            sslStream = new SslStream(
                networkStream,
                false,
                new RemoteCertificateValidationCallback(ValidateServerCertificate),
                null);

            try
            {
                sslStream.AuthenticateAsClient(serverNameForCertificate);
            }
            catch (AuthenticationException e)
            {
                Console.WriteLine("Exception: {0}", e.Message);
                if (e.InnerException != null)
                {
                    Console.WriteLine("Inner exception: {0}", e.InnerException.Message);
                }
                Console.WriteLine("Authentication failed - closing the connection.");
                socket.Close();
                return;
            }
        }



        public int Send(byte[] buffer)
        {
            sslStream.Write(buffer, 0, buffer.Length);
            return buffer.Length;
        }

        public int Receive(byte[] buffer)
        {
            return sslStream.Read(buffer, 0, buffer.Length);
        }

        public void Shutdown(SocketShutdown sd)
        {
            socket.Shutdown(sd);
        }
        public void Close()
        {
            socket.Close();
        }

        //public static bool ValidateServerCertificate(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
        //{
        //    return true;
        //}

        private static Hashtable certificateErrors = new Hashtable();

        // The following method is invoked by the RemoteCertificateValidationDelegate.

        private static bool ValidateServerCertificate(
              object sender,
              X509Certificate certificate,
              X509Chain chain,
              SslPolicyErrors sslPolicyErrors)
        {
            if (sslPolicyErrors == SslPolicyErrors.None)
                return true;
            Console.WriteLine("Certificate error: {0}", sslPolicyErrors);
            // Do not allow this client to communicate with unauthenticated servers.
            return false;
        }
    }
}
