using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Stanford_Vol1
{
    internal class BinarySearchClass
    {
        public static int BinarySearch(int[] a, int key)
        {
            int lo = 0, hi = a.Length - 1;
            while (lo <= hi)
            {
                int mid = lo + (hi - lo) / 2;
                if (key < a[mid]) hi = mid - 1;
                else if (key > a[mid]) lo = mid + 1;
                else return mid;
            }
            return -1;
        }
    }
}

