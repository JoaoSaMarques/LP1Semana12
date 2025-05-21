using System;
using System.Collections.Generic;

namespace TheyCameBefore
{
    static class BeforeUtils
    {
        public static IEnumerable<T> GetTheOnesBefore<T>(IEnumerable<T> items, T item) where T : struct, IComparable<T>
        {
            
        }
    }
}
