using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Abstraction
{
    // Abstract class
    // is a partial implementation for other classes
    // is a container for commom code [implemented members , Abstract Members ]among many classes
    // U Can't Create Object from abstract class [it is not fully implemented]

    abstract class Shape
    {
        protected Shape(decimal Dim01 , decimal Dim02)
        {
            this.Dim01 = Dim01;
            this.Dim02 = Dim02;
        }
        public decimal Dim01 { get; set; }
        public decimal Dim02 { get; set; }
        // Abstract Property
        public abstract decimal Perimeter { get;  }
        // Abstract Method
        public abstract decimal CalcArea();
    }

    class Parent
    {
        private protected int salary;

        // Abstract property = virtual without implementation
        public virtual int Salary { get { return salary; } set { salary = salary < 5000 ? 5000 : value;  } } 
        
        // Abstract method = virtual method without implementation
        public virtual void Print()
        {
            Console.WriteLine("Iam Parent");
        }

    }

    class Child : Parent 
    {
        public override int Salary { get { return base.salary;  }set { base.salary = value + 2000; } }
        public override void Print()
        {
            Console.WriteLine(" Iam Child");
        }
    }

    abstract class RectBase : Shape
    {
        protected RectBase(decimal Dim01 , decimal Dim02):base(Dim01,Dim02)
        {
            
        }
        public override decimal CalcArea()
        {
            return Dim01 * Dim02;
        }
    }

    // Concrete Class
    class Rect : RectBase
    {
        public Rect(decimal Dim01, decimal Dim02) : base(Dim01, Dim02)
        {

        }
        public override decimal Perimeter
        {
            get { return (Dim01 + Dim02) * 2; }
        }

       
    }
    class Square : RectBase
    { 
        public override decimal Perimeter
        {
            get { return Dim01 * 4; }
        }

        public Square(int Dim):base(Dim,Dim)
        {
           // this.Dim01 = this.Dim02 = Dim;
            
        }
        
    }

    class Circle : Shape
    {
        public Circle(decimal Raduis):base(Raduis , Raduis)
        {
            //this.Dim01 = this.Dim02 = Raduis;
            
        }
        public override decimal Perimeter
        {
            get { return 2 * 3.14m * this.Dim01; }
        }

        public override decimal CalcArea()
        {
            return 3.14M * this.Dim01 * this.Dim02;
        }

        //void IDraw2D.Draw()
        //{
        //    throw new NotImplementedException();
        //}

        //void IDraw3D.Draw()
        //{
        //    throw new NotImplementedException();
        //}
    }

    //interface IDraw2D
    //{
    //    public void Draw();
    //}
    //interface IDraw3D
    //{
    //    public void Draw(); 
    //}

    class Triangle : Shape
    {
        public decimal Dim03 { get; set; }
        public Triangle(decimal Dim01 , int Dim02 , int Dim03):base(Dim01 , Dim02)
        {
         
            this.Dim03 = Dim03;
        }
        public override decimal Perimeter => throw new NotImplementedException();

        public override decimal CalcArea()
        {
            throw new NotImplementedException();
        }
    }
}
