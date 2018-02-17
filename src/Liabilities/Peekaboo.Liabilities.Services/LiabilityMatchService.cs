using Peekaboo.Liabilities.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peekaboo.Liabilities.Services
{
    public class LiabilityMatchService : ILiabilityMatchService
    {
        public IEnumerable<Liability> FindMatch(IEnumerable<Liability> creditLabilities, IEnumerable<Liability> existingLiabilities)
        {
            var matches =
                from c in creditLabilities
                join e in existingLiabilities on c.AccountNumber equals e.AccountNumber
                select e;

            return matches;
        }
    }
}
