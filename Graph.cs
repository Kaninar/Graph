using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscreteMath_2c._1h._8w
{
    internal class Graph : Node
    {
        public Node[] Nodes;
        public List<Arc> GraphArcs;
        public int Length { get; }
        int lowerBound = 1;
        public int upperBound { get; set; }
        public Graph(int Size)
        {
            Length = Size;
            Nodes = new Node[Size];
            GraphArcs = new List<Arc>();
        }
        public Graph(int Size, Dictionary<int, int> WeightsDict)
        {
            Length = Size;
            Nodes = new Node[Size]; 
            GraphArcs = new List<Arc>();
            for (int i = 1; i <= Size; i++)
            {
                this[i] = new Node();
                this[i].Index = i;
                this[i].Weight = WeightsDict[i];
            }
        }
        public Graph(int Size, Dictionary<int, int> WeightsDict, List<Arc> ArcsList)
        {
            Length = Size;
            upperBound = Size;
            Nodes = new Node[Size];
            GraphArcs = ArcsList;
            for (int i = 1; i <= Size; i++)
            {
                this[i] = new Node(i, WeightsDict[i]);
            }
            foreach (Arc Arc in GraphArcs)
            {
                this[Arc.From].Arcs.Add(Arc);
                this[Arc.To].Arcs.Add(Arc);
                this[Arc.To].Inners++;
                this[Arc.From].Outers++;
            }

        }
        public Node this[int index]
        {
            get { return this.Nodes[index - lowerBound]; }
            set {  Nodes[index - lowerBound] = value; }
        }
        public void RemoveAt(int index)
        {
            foreach (Arc NodeArch in this[index].Arcs)
            {
                if(this[NodeArch.To].Inners != 0)
                    this[NodeArch.To].Inners--;
                if(this[NodeArch.From].Outers != 0)
                    this[NodeArch.From].Outers--;
                
            }
        }
    }
}
