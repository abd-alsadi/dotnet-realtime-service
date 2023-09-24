using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using KmnlkRealTimeApi_Context;

[assembly: OwinStartup(typeof(KmnlkRealTimeApi.Startup))]

namespace KmnlkRealTimeApi
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=316888
        }
    }
}
