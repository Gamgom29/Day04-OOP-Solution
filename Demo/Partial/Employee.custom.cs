using Demo.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Partial
{
    internal partial class Employee : Parent
    {
        public string? Address { get; set; }

        partial void DoSomeCode()
        {
            int X = 10;
            X++;
            Console.WriteLine(X);
        }
    }
}
