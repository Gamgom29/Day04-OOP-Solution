using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Sealed
{
    class Parent
    {
        public virtual int Salary { get; set; }

        public virtual void print()
        {
            Console.WriteLine("Iam Parent");
        }

    }
    class Child : Parent
    {
        // Sealed Property
        public sealed override int Salary 
        {
            get  { return base.Salary;  } set { base.Salary = value < 5000 ? 5000 : value;  }
        }

        // Sealed Method
        public sealed override void print()
        {
            Console.WriteLine("Iam A Child");
        }
    }

    // Sealed Class 
    sealed class GrandChild : Child
    {
        public new int Salary
        {
            get { return base.Salary; }
            set { base.Salary = value < 6000 ? 6000 : value; }
        }
        public new void print()
        {
            Console.WriteLine("Grand Child");
        }
    }

}
