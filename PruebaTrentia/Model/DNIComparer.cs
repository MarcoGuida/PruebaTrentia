using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTrentia.Model
{
    class DNIComparer : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            x = x.Substring(0, 8);
            y = y.Substring(0, 8);

            int xInt = int.Parse(x);
            int yInt = int.Parse(y);

            if (xInt > yInt)
                return 1;
            else
                return -1;
        }
    }
}
