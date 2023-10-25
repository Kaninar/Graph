using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscreteMath_2c._1h._8w
{
    internal class Arc
    {
        public int From, To;
        public Arc()
        {
            From = 0;
            To = 0;
        }
        public Arc(int f, int t)
        {
            From = f;
            To = t;
        }
    }
}
