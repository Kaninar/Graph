using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscreteMath_2c._1h._8w
{
    internal class Node 
    {
        public List <Arc> Arcs;
        public int Index { get; set; }
        public int Weight { get; set; }
        public int Inners { get; set; }
        public int Outers { get; set; }
        public int Marker = 0;

        public Node() 
        {
            Index = 0;
            Weight = 0;
            Arcs = new List <Arc>();
        }
        public Node(int index)
        {
            Index = index;
            Arcs = new List<Arc>();
        }
        public Node(int index, int w)
        {
            Index = index;
            Weight = w;
            Arcs = new List<Arc>();
        }
    }
}
