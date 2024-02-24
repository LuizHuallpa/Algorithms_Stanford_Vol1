using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Stanford_Vol1
{
    internal class FixedCapacityQueueOfStrings
    {
        private string[] s;
        private int N = 0;
        private int _first, _last;

        public FixedCapacityQueueOfStrings()
        {
            s = new string[1];
            _first = 0;
            _last = 0;
        }

        public void Enqueue(string item)
        {
            if (_last == s.Length) Resize(2 * s.Length);
            N++;
            s[_last++] = item;
                    
        }

        public string Dequeue()
        {
            if (IsEmpty)
                throw new InvalidOperationException();
            string item = s[_first];
            s[_first++] = null;
            if (_first == _last && _first != 0) // Check if the array is empty
                _first = _last = 0;
            else if (_last - _first == s.Length / 4) // Check if resizing is necessary
                Resize(s.Length / 2);
            return item;

        }

        private void Resize(int capacity)
        {
            string[] copy = new string[capacity];
            for (int i = 0; i < N; i++)
            {
                copy[i] = s[i];
            }
            s = copy;
        }

        public bool IsEmpty => N == 0;
    }
}
