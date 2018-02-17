using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peekaboo.Liabilities.Services.Interfaces
{
    public interface ILiabilityMatchService
    {
        IEnumerable<Liability> FindMatch(IEnumerable<Liability> creditLabilities, IEnumerable<Liability> existingLiabilities);
    }
}
