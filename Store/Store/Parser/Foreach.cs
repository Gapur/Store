using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Store.Parser
{
    public static class Foreach
    {
        public static IEnumerable<T> ForEach<T>(this IEnumerable<T> enumeration, Action<T> action)
        {
            foreach (var item in enumeration)
            {
                action(item);
                yield return item;
            }
        }

        public static IEnumerable<KeyValuePair<T, TE>> ForEach<T, TE>(this IDictionary<T, TE> enumeration, Action<KeyValuePair<T, TE>> action)
        {
            foreach (var item in enumeration)
            {
                action(item);
                yield return item;
            }
        }
    }
}