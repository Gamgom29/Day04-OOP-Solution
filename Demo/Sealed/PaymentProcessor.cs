using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Sealed
{
    sealed class PaymentProcessor
    {
        public void ProcessPayment(decimal Amount)
        {
            Console.WriteLine($"Amount = {Amount}");

        }
    }

    //class MyPaymentProcessor : PaymentProcessor
    //{
    //    public new void ProcessPayment (decimal Amount)
    //    {
    //        Console.WriteLine($"Amount = {Amount + 20}");
    //    }
    //}
}
