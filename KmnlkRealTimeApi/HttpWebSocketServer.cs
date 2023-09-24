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

namespace KmnlkRealTimeApi
{
    public class HttpWebSocketServer : HttpWebSocketServerContext,IHttpHandler
    {
        private PackageManagement package;
        public bool IsReusable
        {
            get
            {
                return false;
            }
        }

        public void ProcessRequest(HttpContext context)
        {
            package = new PackageManagement();
            if (context.IsWebSocketRequest || context.IsWebSocketRequestUpgrading)
            {

                context.AcceptWebSocketRequest(new WebSocketServerClient(null, package));
            }
            else
            {
                context.Response.ContentType = "text/plain";
                context.Response.Write("errr");
                context.Response.End();
            }
           // throw new NotImplementedException();
        }

    }
}