using Demo.Operators_Overloading;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Complex C1 = new Complex() { Real = 2 , Imag = 4};
            Complex C2 = new Complex() { Real = 3, Imag = 5 };

            Complex C3 = default;

            C3 = C1 + C2;
            Console.WriteLine($"C1 = {C1}");
            Console.WriteLine($"C2 = {C2}");
            Console.WriteLine("----------------");
            Console.WriteLine($"C3 = {C3}");

            Complex C4 = C1 + C2 + C3;

        }
    }
}
