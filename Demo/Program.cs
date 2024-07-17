using Demo.Operators_Overloading;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Complex C1 = new Complex() { Real = 2 , Imag = 4};
            Complex C2 = new Complex() { Real = 3, Imag = 5 };

            #region Binary Operators
            //Complex C3 = default;

            //C3 = C1 + C2;
            //Console.WriteLine($"C1 = {C1}");
            //Console.WriteLine($"C2 = {C2}");
            //Console.WriteLine("----------------");
            //Console.WriteLine($"C3 = {C3}");

            //Complex C4 = C1 + C2 + C3; 
            #endregion

            #region Unary Operators
            //Console.WriteLine($"C1 = {C1}");

            //Complex C3 = C1++; Console.WriteLine("After ++C1 ");

            //Console.WriteLine($"C1 = {C1}");
            //Console.WriteLine($"C3 = {C3}"); 
            #endregion

            #region Comparison operators [Relational]
            //if(C1 > C2)
            //    Console.WriteLine($"C1 Is Greater Than C2");
            //else if(C1 < C2)
            //    Console.WriteLine("C1 Is Less Than C2");
            //else
            //    Console.WriteLine("C1 Is Equal Than C2"); 
            #endregion

        }
    }
}
