using Assignment.Project01;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Project01
            //Point3D point = new Point3D(10, 10, 10);
            //Console.WriteLine(point.ToString());

            Point3D P1 ;
            Point3D P2 ;
            for (int i = 1; i <= 2; i++)
            {
                Console.WriteLine($"Enter Point {i}");
                Console.Write($"Enter X{i}: ");
                int X = Convert.ToInt32( Console.ReadLine() );

                Console.Write($"Enter Y{i}: ");
                int Y = int.Parse( Console.ReadLine() ?? "0");

                Console.Write($"Enter Z{i}: ");
                int.TryParse(Console.ReadLine(), out int Z);

                if(i == 1)
                    P1 = new Point3D(X, Y, Z);
                else 
                    P2 = new Point3D(X, Y,Z);
            }

            //if(P1 == P2)
            //    Console.WriteLine("P1 Equal P2");
            // It Dosenot work Because We Don't Overload the == Operator 
            #endregion
        }
    }
}
