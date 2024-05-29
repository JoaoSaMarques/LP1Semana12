using System;
using System.Collections.Generic;
using System.Linq;

namespace MultipleStuff
{
    class SuperList : List<double>
    {
        public void GetMinMax1(out double min, out double max)
        {
            min = this.Min();
            max = this.Max();
        }

        public MinMax GetMinMax2()
        {
            return new MinMax { Min = this.Min(), Max = this.Max() };
        }

        public (double, double) GetMinMax3()
        {
            return (this.Min(), this.Max());
        }

        public (double Min, double Max) GetMinMax4()
        {
            return (this.Min(), this.Max());
        }

        public struct MinMax
        {
            public double Min { get; set; }
            public double Max { get; set; }
        }
    }
}