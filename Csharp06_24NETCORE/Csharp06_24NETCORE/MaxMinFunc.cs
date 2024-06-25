using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxMin
{
    internal class MaxMinFunc
    {
        public int Max(int x, int y)
        {
            return (x > y) ? x : y;
        }
        public int Min(int x, int y)
        {
            return (x < y) ? x : y;
        }
    }
}
