using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace KmnlkRealTimeDll.Models
{
    public class clsUser
    {
        public string uid { set; get; }
        public string sessionID { set; get; }
        public string userName { set; get; }
        public string timeAction { set; get; }
        public clsClient client;
    }
}
