using System;
using System.IO;
using System.Net.Sockets;

namespace TCP_Client
{
    class Program
    {
        static void Main(string[] args)
        {
            //檔案
            FileStream fs = new FileStream(@"C:\Users\Alan\Desktop\test.txt" ,FileMode.Open, FileAccess.Read, FileShare.Read);
            byte[] bytes = new byte[fs.Length];
            fs.Read(bytes,0,(int)fs.Length);
            fs.Close();

            //連線
            TcpClient tcpClient = new TcpClient("localhost", 5000);
           var tcpStream=tcpClient.GetStream();
            tcpStream.Write(bytes,0,bytes.Length);
        }
    }
}
