using KmnlkRealTimeDll.Management;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static KmnlkCommon.Shareds.LoggerManagement;

namespace KmnlkRealTimeApi.Management
{
    public class ContextManagement
    {


        public ILog logger;
       // public ConnectionManager connectionManager;

        public ContextManagement(/*ConnectionManager connectionManager,*/ ILog logger)
        {
            //this.connectionManager = connectionManager;
            this.logger = logger;
        }


        private BussinessRealTimeManagement bussinessRealTimeManagement;
        public BussinessRealTimeManagement instanceBussinessRealTimeManagement()
        {
            if (bussinessRealTimeManagement == null)
            {
                bussinessRealTimeManagement = new BussinessRealTimeManagement(/*connectionManager,*/ logger);

            }
            return bussinessRealTimeManagement;
        }

     
     

    }
}