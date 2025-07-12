using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedProject.Extension
{
    public static class CharExtension
    {
        public static int ToInt(this char c)
        {
            int.TryParse(c.ToString(), out var res);
            return res;
        }
    }
}
