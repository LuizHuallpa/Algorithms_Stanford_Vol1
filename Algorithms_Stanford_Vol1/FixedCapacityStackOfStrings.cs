using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Stanford_Vol1
{
    internal class FixedCapacityStackOfStrings
    {
        private string[] s;
        private int N = 0;

        public FixedCapacityStackOfStrings()
        {
            s = new string[1];
        }

        public bool IsEmpty => N == 0;

        public void Push(string item)
        {
            if(N == s.Length) Resize(2 * s.Length);
            s[N++] = item;
        }

        private void Resize(int capacity) 
        {
            string[] copy = new string[capacity];
            for(int i = 0; i < N; i++) {
                copy[i] = s[i];
            }
            s = copy;
        }

        public string Pop()
        {
            string item = s[--N];
            s[N] = null;
            if(N> 0 && N == s.Length/4) Resize(s.Length/2);
            return item;
            
        }

    }
}
