
using KmnlkRealTimeApi.Management;
using Microsoft.Web.WebSockets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.WebSockets;
using static KmnlkCommon.Shareds.LoggerManagement;

namespace KmnlkRealTimeApi
{
    public class WebSocketServerClient : WebSocketHandler
    {

        private ILog logger;
        private AspNetWebSocketContext client;
        private PackageManagement package;

        public WebSocketServerClient(ILog logger,  PackageManagement package)
        {
            this.logger = logger;
            this.package = package;
            this.client = this.WebSocketContext;
            
        }
        public override void OnMessage(byte[] message)
        {
            base.OnMessage(message);
        }
        public override void OnMessage(string message)
        {
            base.OnMessage(message);
            //string msgBack = string.Format(
            // "You have sent {0} at {1}", message, DateTime.Now.ToLongTimeString());
            //this.Send(msgBack);
        }
        public override void OnOpen()
        {
            base.OnOpen();
            //this.Send("Welcom from " + this.WebSocketContext.UserHostAddress);
        }
        public override void OnClose()
        {
            base.OnClose();
        }
    
        //public bool isValid(object model)
        //{
        //    bool result = true;
        //    logger.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "", ENUM_TYPE_MSG_LOGGER.INFO, ENUM_TYPE_Block_LOGGER.START, modConstant.MSG_SUCCESS);

        //    logger.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "", ENUM_TYPE_MSG_LOGGER.INFO, ENUM_TYPE_Block_LOGGER.END, modConstant.MSG_SUCCESS);
        //    return result;
        //}
    }
}
