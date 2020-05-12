using System;
using System.Collections.Generic;
using System.Text;

namespace Pactice.LinkedList
{
    internal class DNode
    {
        internal int data;
        internal DNode prev;
        internal DNode next;
        public DNode(int d)
        {
            data = d;
            prev = null;
            next = null;
        }
    }
}
