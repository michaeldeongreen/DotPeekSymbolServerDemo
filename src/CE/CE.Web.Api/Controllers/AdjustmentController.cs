using Peekaboo.Liabilities.Services;
using Peekaboo.Liabilities.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CE.Web.Api.Controllers
{
    public class AdjustmentController : ApiController
    {
        private readonly ILiabilityAdjustmentService _liabilityAdjustmentService;
        public AdjustmentController(ILiabilityAdjustmentService liabilityAdjustmentService)
        {
            _liabilityAdjustmentService = liabilityAdjustmentService;
        }
        public IEnumerable<Liability> Get()
        {
            return ApplyAdjustments();
        }

        private IEnumerable<Liability> ApplyAdjustments()
        {
            List<LiabilityAdjustment> adjustments = new List<LiabilityAdjustment>() { new LiabilityAdjustment() { Id = 1, AccountNumber = "101",  PaymentAdjustment = 120.00m } };
            List<Liability> existingLiabilities = new List<Liability>() { new Liability() { AccountNumber = "500", Id = 1 }, new Liability() { Id = 2, AccountNumber = "101" } };
            _liabilityAdjustmentService.ApplyAdjustments(adjustments, existingLiabilities);

            return existingLiabilities;
        }
    }
}
