using Microsoft.Web.WebSockets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KmnlkRealTimeDll.Models
{
    public static class clsObjectModel
    {
      
        public static List<clsUser> clients = new List<clsUser>();

        public class clsEntity
        {
            public List<clsUser> clients { set; get; }
            public clsEntity()
            {
                clients = clsObjectModel.clients;
            }

        }
    }
}
