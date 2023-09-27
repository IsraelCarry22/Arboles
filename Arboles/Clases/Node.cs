using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arboles.Clases
{
    class Node
    {
        public int Value;
        public Node Right;
        public Node Left;

        public Node(int V)
        {
            Value = V;
            Left = null;
            Right = null;
        }
    }
}