using KmnlkRealTimeApi_Context;
using KmnlkRealTimeApi.Management;
using Microsoft.Web.WebSockets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using static KmnlkCommon.Shareds.LoggerManagement;

namespace KmnlkRealTimeApi_Context
{
    public class HttpWebSocketServerTcp : HttpWebSocketServerContext
    {
        private PackageManagement package;
        private static bool isRun;
        private static TcpListener server;
        public static string IP;
        public static string PORT;
        public HttpWebSocketServerTcp()
        {
            this.package = new PackageManagement();
            isRun = false;
        }
        public HttpWebSocketServerTcp(string IpAddress, string port)
        {
            this.package = new PackageManagement();
            isRun = false;
            IP = IpAddress;
            PORT = port;
            runServer();
        }
        private static void runServer()
        {
            if (!isRun)
            {
                HttpWebSocketServerTcp instance = new HttpWebSocketServerTcp();
                Thread thread = new Thread(new ThreadStart(instance.listenerServer));
                thread.Start();
            }
        }
        public void listenerServer()
        {
                isRun = !isRun;
                server = new TcpListener(IPAddress.Parse(IP), int.Parse(PORT));
                server.Start();

            while (true)
            {
                TcpClient client = server.AcceptTcpClient();
                package.context.instanceBussinessRealTimeManagement().RTM.register(client);
            }
        }
    }
}