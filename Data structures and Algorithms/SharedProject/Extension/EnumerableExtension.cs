using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedProject.Extension
{
    public static class EnumerableExtension
    {
        public static int FindIndex<T>(this IEnumerable<T> source, T target)
        {
            int index = 0;
            foreach (T item in source)
            {
                if (EqualityComparer<T>.Default.Equals(item, target))
                {
                    return index;
                }
                index++;
            }

            return -1; // Not found
        }


    }
}
