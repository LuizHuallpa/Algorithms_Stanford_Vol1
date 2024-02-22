using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Stanford_Vol1
{
    internal class QuickUnionUF
    {
        //The class has two private integer arrays id and sz. id is used to store the parent of each element in the set,
        //and sz is used to store the size of each set.
        private int[] id;
        private int[] sz;

        //The constructor QuickUnionUF(int N) initializes the id array with values from 0 to N-1, and the sz array with values from 0 to N-1.
        //This means that initially, each element is its own parent and each set has a size of 1.
        public QuickUnionUF(int N)
        {
            id = new int[N];
            for (int i = 0; i < N; i++)
            {
                id[i] = i;
                sz[i] = i;

            }
        }

        //This is a private helper method that finds the root (or the parent) of the element i in the set. It does this by repeatedly following the parent pointers until it reaches the root.
        private int Root(int i)
        {
            while (i != id[i])
            {
                id[i] = id[id[i]];// Path compression
                i = id[i];
            }
            return i;
        }
        //The Connected(int p, int q) method checks if elements p and q are in the same set by comparing their roots.
        public bool Connected(int p, int q) =>  Root(p) == Root(q);

        //This method performs the union of sets containing elements p and q. It does this by setting the root of p to the root of q.
        public void QuickUnion(int p, int q)
        {
            int i = Root(p);
            int j = Root(q);
            id[i] = j;
        }

        //This method is an optimized version of the QuickUnion method. It first finds the roots of p and q, and then it checks which set has a smaller size.
        //It then sets the root of the smaller set to the root of the larger set and updates the size of the larger set.
        public void WeightedUnion(int p, int q)
        {
            int i = Root(p);
            int j = Root(q);
            if (i == j) return;
            if (sz[i] < sz[j]) { id[i] = j; sz[j] += sz[i]; }
            else { id[j] = i; sz[i] += sz[j]; }
        }
    }
}
