using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Project02
{
    static class Maths
    {
        public static int Add(int X, int Y) {return X + Y;}
        public static int Subtract(int X, int Y) { return X - Y; }
        public static int Multiply(int X, int Y) { return X * Y; }
        public static int Divide(int X, int Y)
        {
            if (Y != 0)
            {
                return X / Y;
            }
            else return -1;
        }
    }
}
