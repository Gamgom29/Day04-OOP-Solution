using Assignment.Project01;
using Assignment.Project02;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Project01
            #region Q01
            //Point3D point = new Point3D(10, 10, 10);
            //Console.WriteLine(point.ToString()); 
            #endregion

            #region Q02
            //Point3D P1 ;
            //Point3D P2 ;
            //for (int i = 1; i <= 2; i++)
            //{
            //    Console.WriteLine($"Enter Point {i}");
            //    Console.Write($"Enter X{i}: ");
            //    int X = Convert.ToInt32( Console.ReadLine() );

            //    Console.Write($"Enter Y{i}: ");
            //    int Y = int.Parse( Console.ReadLine() ?? "0");

            //    Console.Write($"Enter Z{i}: ");
            //    int.TryParse(Console.ReadLine(), out int Z);

            //    if(i == 1)
            //        P1 = new Point3D(X, Y, Z);
            //    else 
            //        P2 = new Point3D(X, Y,Z);
            //} 
            #endregion

            #region Q04
            //if(P1 == P2)
            //    Console.WriteLine("P1 Equal P2");
            // It Dosenot work Because We Don't Overload the == Operator  
            #endregion

            #region Q05
            //Point3D[] Points = new Point3D[]
            //{
            //    new Point3D(1 ,2 , 3),
            //    new Point3D (1 ,3 ,4),
            //    new Point3D(2 , 1 , 4),
            //    new Point3D(2 , 2 ,2)
            //};
            //Array.Sort(Points);
            //foreach (Point3D p in Points)
            //    Console.WriteLine(p); 
            #endregion

            #region Q06
            //Point3D P1 = new Point3D(10, 20, 30);
            //Point3D P2 = (Point3D) P1.Clone(); 
            #endregion
            #endregion

            #region Project02
            Console.WriteLine($"3 * 5 = {Maths.Multiply(3,5)}");
            Console.WriteLine($"3 + 5 = {Maths.Add(3, 5)}");
            Console.WriteLine($"3 - 5 = {Maths.Subtract(3, 5)}");
            Console.WriteLine($"10 / 5 = {Maths.Add(10, 5)}");


            #endregion
        }
    }
}
