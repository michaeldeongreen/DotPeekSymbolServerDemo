﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peekaboo.Liabilities.Services
{
    public class Liability
    {
        public int Id { get; set; }
        public string AccountNumber { get; set; }
        public decimal? Payment { get; set; }
    }
}
