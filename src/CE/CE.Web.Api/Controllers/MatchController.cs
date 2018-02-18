using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Peekaboo.Liabilities.Services;
using Peekaboo.Liabilities.Services.Interfaces;

namespace CE.Web.Api.Controllers
{
    public class MatchController : ApiController
    {
        private readonly ILiabilityMatchService _liabilityMatchService;
        public MatchController(ILiabilityMatchService liabilityMatchService)
        {
            _liabilityMatchService = liabilityMatchService;
        }
        public IEnumerable<Liability> Get()
        {
            return FindMatches();
        }
        
        private IEnumerable<Liability> FindMatches()
        {
            List<Liability> creditLiabilities = new List<Liability>() { new Liability() { AccountNumber = "101", Id = 1 }, new Liability() { Id = 2, AccountNumber = "102" } };
            List<Liability> existingLiabilities = new List<Liability>() { new Liability() { AccountNumber = "500", Id = 1 }, new Liability() { Id = 2, AccountNumber = "101" } };
            var matches = _liabilityMatchService.FindMatch(creditLiabilities, existingLiabilities);
            return matches;
        }
    }
}
