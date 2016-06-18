using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace RoadCodeTransfer
{
    class SocketUtil
    {
        public string errMessage { get; set; }

        public Socket getConnection(string ipAdd, string port)
        {
            IPAddress ip = IPAddress.Parse(ipAdd);
            Socket clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                clientSocket.Connect(new IPEndPoint(ip, Int32.Parse(port)));
                return clientSocket;
            }
            catch
            {                
                return null;
            }
        }

        public bool disConnection(Socket clientSocket)
        {
            try
            {
                clientSocket.Shutdown(SocketShutdown.Both);
                clientSocket.Close();
                return true;
            }
            catch
            {
                return false;
            }
            
        }

        public bool sendMessage(Socket clientSocket,string message)
        {
            try
            {
                clientSocket.Send(Encoding.ASCII.GetBytes(message));
                return true;
            }
            catch
            {
                return false;
            }
        }

        public string receiveMessage(Socket clientSocket)
        {
            try
            {
                byte[] message = new byte[1024];
                int receiveLength = clientSocket.Receive(message);
                string msgStr = Encoding.ASCII.GetString(message, 0, receiveLength);
                return msgStr;
            }
            catch
            {
                return null;
            }
        }
    }
}
