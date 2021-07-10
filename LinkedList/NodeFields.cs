using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class NodeFields
    {
        public int data;
        public NodeFields next;

        public NodeFields(int d)
        {
            data = d;
            next = null;
        }
    }
}
