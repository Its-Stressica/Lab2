﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_2
{
    internal class Emerald:Stone
    {
        public Emerald(string name, int weight, int price, string transperency, int numb)
            : base(name, weight, price, transperency, numb)
        { }
    }
}
