﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IctFest
{
    public interface IEventWithFees
    {
        int CalculateFees();
        void PayFees();
    }
}