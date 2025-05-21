using System;
using System.Collections.Generic;

namespace HowManyOfThisType
{
    static class Checker
    {
        public static int HowManyOfType<T>(IEnumerable<object> items)
        {
            int count = 0;
            foreach (var item in items)
            {
                if (item is T)
                {
                    count++;
                }
            }
            return count;
        }
    }
}