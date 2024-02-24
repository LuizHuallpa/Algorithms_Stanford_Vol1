using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Stanford_Vol1
{
    internal class LinkedQueueOfStrings
    {
        private Node? first, last;

        private class Node
        {
            public string Item { get; set; }
            public Node Next { get; set; }
        }

        public void Enqueue (string item)
        {
            Node oldlast = last;
            last = new Node();
            last.Item = item;
            last.Next = null;

            if (IsEmpty)
                first = last;
            else
                oldlast.Next = last;
        }

        public string Dequeue()
        {
            string item = first.Item;
            first = first.Next;
            if (IsEmpty) last = null;
            return item;
        }

        public bool IsEmpty => first != null;
    }
}
