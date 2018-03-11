using Config.Provider.Helper;
using CUDC.Lending.Service.Core;
using DE.Web.Services;
using System.Collections.Generic;
using System.Web.Http;

namespace DE.Web.Api.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            FundingService service = new FundingService();
            service.VerifyUserAccess();

            var r = ConfigProviderHelper.GetId();
            var s = new TestService().GetId();

            return new string[] { "value1", "value2" };
        }
    }
}
