using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTest2
{
    static class Extensions
    {
        public static IEnumerable<T> GetElementsByCondition<T>(this IEnumerable<T> collection,
            Predicate<T> predicate) // linq.Where()
        {
            foreach (T item in collection)
            {
                if(predicate(item))
                {
                    yield return item;
                }
            }
        }

        public static T GetFirstElementByCondition<T>(this IEnumerable<T> collection,
            Predicate<T> predicate) // linq.FirstOrDefault
        {
            foreach (T item in collection)
            {
                if (predicate(item))
                {
                    return item;
                }
            }

            return default(T);
        }
        public static void MakeAction<T>(this IEnumerable<T> collection, Action<T> action)
        {
            foreach (T item in collection)
            {
                action(item);
            }
        }

        public static IEnumerable<T> MySkipWhile<T>(this IEnumerable<T> collection, Predicate<T> predicate)
        {
            bool skip = true;

            foreach (T item in collection)
            {
                if(!predicate(item))
                {
                    skip = false;
                }

                if(skip)
                {
                    continue;
                }

                yield return item;
            }
        }

        public static bool MyContains<T>(this IEnumerable<T> collection, T element)
        {
            foreach (T item in collection)
            {
                if (item.Equals(element))
                    return true;
            }

            return false;
        }

        public static IEnumerable<T> MyExcept<T>(this IEnumerable<T> first, IEnumerable<T> second)
        {
            foreach (T item in first)
            {
                if(!second.Contains(item))
                {
                    yield return item;
                }
            }
        }
    }
}