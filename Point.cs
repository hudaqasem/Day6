using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    internal struct Point
    {
        /*can't inherit ==> value type */
        public int X;
        public int Y;
        
        public Point()
        {
            X = 0; Y = 0;
        }
        public Point(int X )
        {
            this.X = X;
            this.Y = 0;
        }
        
        public Point(int x, int y)
        { 
            X = x;
            Y = y;
        }
        public override string ToString()
        {
            return $"Point ({X} , {Y})";
        }
    }
   
}
