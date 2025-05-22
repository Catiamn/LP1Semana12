using System;
using System.Collections.Generic;

namespace HowManyOfThisType
{
    public static class BeforeUtils
    {
        public static IEnumerable<T> GetTheOnesBefore<T>(IEnumerable<T> items, T threshold)
        {
            foreach (T item in items)
            {
                if (Comparer<T>.Default.Compare(item, threshold) < 0)
                {
                    yield return item;
                }
            }
        }
    }
}