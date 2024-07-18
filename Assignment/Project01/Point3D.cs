using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Project01
{
    internal class Point3D : IComparable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public Point3D()
        {
            
        }
        public Point3D(int X , int Y)
        {
            this.X = X;
            this.Y = Y;
        }
        public Point3D(int X , int Y , int Z) :this(X,Y)
        {
            this.Z = Z;
        }

        public override string ToString()
        {
            return $"({X} , {Y} , {Z})";
        }

        public int CompareTo(object? obj)
        {
            Point3D? P = (Point3D?)obj;
            if(this.X == P?.X)
                return this.Y.CompareTo(P?.Y);
            else 
                return this.X.CompareTo(P?.X);
        }
    }
}
