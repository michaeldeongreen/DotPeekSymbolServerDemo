using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peekaboo.Liabilities.Services.Interfaces
{
    public interface ILiabilityAdjustmentService
    {
        void ApplyAdjustments(IEnumerable<LiabilityAdjustment> adjustments, IEnumerable<Liability> liabilities);
    }
}
