﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ThePattern.Stratigy
{
    public class FlatRateDiscountStratigy : IDiscountStratigy
    {
        private const long FIXED_AMOUNT = 300;
        private readonly long _price;

        public FlatRateDiscountStratigy(long price)
        {
            _price = price;
        }

        public long Discount()
        {
            return _price - FIXED_AMOUNT;
        }
    }
}
