using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedProject.Extension
{
    public static class QueueExtensions
    {
        public static bool IsEmpty<T>(this Queue<T> queue)
        {
            return queue.Count == 0;
        }
    }
}
