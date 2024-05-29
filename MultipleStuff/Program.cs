using System;

namespace MultipleStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperList list = new SuperList { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            double min1, max1;
            list.GetMinMax1(out min1, out max1);
            Console.WriteLine($"GetMinMax1: Min = {min1}, Max = {max1}");

            MinMax minMax2 = list.GetMinMax2();
            Console.WriteLine($"GetMinMax2: Min = {minMax2.Min}, Max = {minMax2.Max}");

            (double min3, double max3) = list.GetMinMax3();
            Console.WriteLine($"GetMinMax3: Min = {min3}, Max = {max3}");

            (double MinValue, double MaxValue) = list.GetMinMax4();
            Console.WriteLine($"GetMinMax4: Min = {MinValue}, Max = {MaxValue}");
        }
    }
}