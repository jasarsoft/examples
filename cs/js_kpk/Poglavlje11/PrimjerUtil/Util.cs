using System;

namespace PrimjerUtil
{
    class Util
    {
        public static int Min(params int[] niz)
        {
            if (niz == null || niz.Length == 0)
            {
                throw new ArgumentException("Min argument");
            }

            int trenutniMin = niz[0];
            foreach (int i in niz)
            {
                trenutniMin = Min(trenutniMin, i);
            }

            return trenutniMin;
        }

        public static int Min(int lhs, int rhs)
        {
            return lhs < rhs ? lhs : rhs;
        }
    }
}
