using Config.Provider.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DE.Web.Services
{
    public class TestService
    {
        public Guid GetId()
        {
            return ConfigProviderHelper.GetId();
        }
    }
}
