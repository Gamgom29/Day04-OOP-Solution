using Demo.Abstraction;
using Demo.Casting_Operator_Overloading;
using Demo.Operators_Overloading;
using Demo.Static;

namespace Demo
{
    internal class Program
    {
        //static void PrintShapeInfo(Shape shape)
        //{

        //}
        //static void Draw2D(IDraw2D shape)
        //{
        //    shape.Draw();
        //}
        static void Main(string[] args)
        {
            //Complex C1 = new Complex() { Real = 2 , Imag = 4};
            //Complex C2 = new Complex() { Real = 3, Imag = 5 };

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

            #region Casting Operator Overloading
            #region Example 01
            ///Complex C1 = new Complex() { Real = 4 , Imag = 3};
            ///int Y = (int)C1;
            ///Console.WriteLine($"Y = {Y}");
            ///object O1 = 5;
            ///int X = (int)O1;  
            #endregion

            #region Example 02
            ///Complex C1 = new Complex() { Real = 4 , Imag = 3};
            ///string Y = (string)C1; // implicit casting
            ///Console.WriteLine($"Y = {Y}");
            ///object obj = "Ahmed";
            ///string X = (string)obj;
            ///Console.WriteLine(X); 
            #endregion

            #endregion

            #region Casting Operators Overloading - Business Need [Mapping]
            //User user = new User()
            //{
            //    Id = 1,
            //    Name = "Abdelrahman Gamgom",
            //    Email = "gamgom@gmail.com",
            //    Password = "@Password",
            //    SecurityStump = Guid.NewGuid(),
            //};

            // Mapping
            //UserViewModel viewModel = (UserViewModel) user;
            //Console.WriteLine(viewModel.Id);
            //Console.WriteLine(viewModel.FName);
            //Console.WriteLine(viewModel.LName);
            //Console.WriteLine(viewModel.Email);
            //Console.WriteLine(viewModel.Password); 
            #endregion

            #region Abstraction [Abstract Class  , Abstract Methods , Abstract Property]
            //Shape shape;

            ///Shape shape = new Shape();
            ///shape.CalcArea();
            /// shape = new Rect() { Dim01 = 10 , Dim02 = 20};
            ///decimal rectArea = rect.CalcArea();
            ///decimal rectPeri = rect.Perimeter;
            ///Console.WriteLine($"Rect Peri = {rectPeri}");
            ///Console.WriteLine($"Rect Area = {rectArea}");

            /// shape = new(20);
            ///decimal squarePeri = square.Perimeter;
            ///decimal squareArea = square.CalcArea();
            ///Console.WriteLine($"Square Peri = {squarePeri}");
            ///Console.WriteLine($"Sqaure Area = {squareArea}");

            /// shape = new(10);
            ///decimal circlePeri = circle.Perimeter;
            ///decimal cricleArea = circle.CalcArea();
            ///Console.WriteLine($"Circle Area = {cricleArea}");
            ///Console.WriteLine($"Circle Peri = {circlePeri}");


            #endregion

            #region Static [Class Attribute , Property , Constructor , Method] ans Const
            //Utility U01 = new Utility(1, 2);
            //Utility U02 = new Utility(5, 10);


            // The Result of calling this method will not be different by t the differrence oh the object state 
            //Console.WriteLine(Utility.CmToInch(254));
            //Console.WriteLine(Utility.CmToInch(254));
            //Console.WriteLine($"Circle Area {Utility.calcCircleArea(10)}");
            //Console.WriteLine($"Circle Area {Utility.calcCircleArea(10)}");
            //Console.WriteLine(Utility.calcCircleArea(10)); 
            #endregion
        }
    }
}
