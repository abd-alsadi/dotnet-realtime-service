using KmnlkRealTimeDll.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KmnlkRealTimeDll.Models;
using static KmnlkCommon.Shareds.LoggerManagement;
using System.Net.Sockets;
using System.Threading;
using KmnlkRealTimeDll.Helpers;

namespace KmnlkRealTimeDll.Management
{
    public class RealTimeManagement : /*IServerOperations,*/IValidationOperations
    {
        private ILog logger;
        public RealTimeManagement(ILog logger)
        {
            this.logger = logger;
        }
        public List<TcpClient> getUsers(clsUser client)
        {
            throw new NotImplementedException();
        }

        public bool isValid(object model)
        {
            throw new NotImplementedException();
        }

        public bool publish(TcpClient client, clsMessage message)
        {
            throw new NotImplementedException();
        }

        public bool register(TcpClient client)
        {
            Thread thread = new Thread(new ThreadStart(() => {

                MainHelper.decodeSocket(client);
                //NetworkStream stream = client.GetStream();
                ////enter to an infinite cycle to be able to handle every change in stream
                //while (true)
                //{
                //    while (!stream.DataAvailable) ;
                //    while (client.Available < 3) ; // match against "get"
                //    Byte[] bytes = new Byte[client.Available];

                //    stream.Read(bytes, 0, bytes.Length);
                //    string s = Encoding.UTF8.GetString(bytes);
                //}
            }));
            thread.Start();
            return true;
        }
    }
}
