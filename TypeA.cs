using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    internal class TypeA
    {
        private int F; // only within this class
        internal int G;
        public int H;

        public TypeA()
        {
            H = 5;
            F = 5;
            G = 5;
        }
        public TypeA(int F , int G , int H)
        {
            this.F = F;
            this.G = G;
            this.H = H;
        }
        public int GetF()
        {
            return F; 
        }
            
    }
}
