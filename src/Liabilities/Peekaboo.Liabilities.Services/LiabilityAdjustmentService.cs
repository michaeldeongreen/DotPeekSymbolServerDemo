using Peekaboo.Liabilities.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peekaboo.Liabilities.Services
{
    public class LiabilityAdjustmentService : ILiabilityAdjustmentService
    {
        public void ApplyAdjustments(IEnumerable<LiabilityAdjustment> adjustments, IEnumerable<Liability> liabilities)
        {
            foreach (var adjustment in adjustments)
            {
                (from liability in liabilities
                 where liability.AccountNumber == adjustment.AccountNumber
                 select liability)
                .ToList()
                .ForEach(l => l.Payment = adjustment.PaymentAdjustment);
            }
        }
    }
}
