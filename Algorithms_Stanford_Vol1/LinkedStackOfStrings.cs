using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Stanford_Vol1
{
    internal class LinkedStackOfStrings
    {
        private Node? first = null;

        private class Node
        {
            public string Item { get; set; }
            public Node Next { get; set; }
        }

        public void Push(string item)
        {
            Node oldfirst = first;
            first = new Node();
            first.Item = item;
            first.Next = oldfirst;
        }

        public string Pop()
        {
            string item = first.Item;
            first = first.Next;
            return item;
        }

        public bool IsEmpty => first != null;
    }
}
