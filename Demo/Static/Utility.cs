using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Static
{
    // static class
    static class Utility
    {
        //public int X { get; set; }
        //public int Y { get; set; }

        // private static readonly double pi = 3.14 ;

        // constant
        private const double pi = 3.14;
        public static double PI
        {
            get { return pi; }
            //set { pi = value; }
        }

        //public Utility( int X , int Y)
        //{
        //    this.X = X;
        //    this.Y = Y;
        //    //pi = 3.14;
        //}


        // static ctor [max only one per class]
        // u can't specify access modifier or paramerter for static ctor
        //  will be called once per class lifetime before first usage of the class
        // the usage of the class as following
        // 1. Create object from class or another class inheriting from this class
        // 2. class static property
        // 3. call static mathod

        static Utility()
        {
            //pi = 3.14;
        }

        //public override string ToString()
        //{
        //    return $"({X} , {Y})";
        //}

        // Object Member method
        public static double CmToInch(double cm)
        {
            return cm / 2.54;
        }

        
        public static double calcCircleArea(double Raduis)
        {
            return PI * Math.Pow(Raduis, 2);
        }
    }
}
