using KmnlkRealTimeDll.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KmnlkRealTimeDll.Interfaces
{
    public interface IServerOperations
    {
        bool register(clsUser user);
        List<clsUser> getUsers(clsUser user);

        bool publish(clsUser user,clsMessage message);

    }
}
