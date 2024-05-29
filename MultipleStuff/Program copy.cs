using System;
using System.Collections.Generic;

namespace MultipleStuff
{
    class SuperList : List<double>
    {
        public void GetMinMax1(out double min, out double max)
        {
            min = this.Min();
            max = this.Max();
        }
    }
}