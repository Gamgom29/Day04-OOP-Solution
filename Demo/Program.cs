﻿using Demo.Casting_Operator_Overloading;
using Demo.Operators_Overloading;

namespace Demo
{
    internal class Program
    {
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

        }
    }
}
