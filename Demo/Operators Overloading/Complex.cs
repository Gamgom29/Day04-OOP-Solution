using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Operators_Overloading
{
    internal class Complex
    {
        public int Real { get; set; }
        public int Imag { get; set; }

        public override string ToString()
        {
            return $"{Real} + {Imag}i";
        }

        #region Operators Overloading
        // overloading operator : must be non private class member function

        #region Binary Operators
        public static Complex operator +(Complex left, Complex right)
        {
            return new Complex()
            {
                Real = (left?.Real ?? 0) + (right?.Real ?? 0),
                Imag = (left?.Imag ?? 0) + (right?.Imag ?? 0)
            };
        }

        public static Complex operator -(Complex left, Complex right)
        {
            return new Complex()
            {
                Real = (left?.Real ?? 0) - (right?.Real ?? 0),
                Imag = (left?.Imag ?? 0) - (right?.Imag ?? 0)
            };
        }
        #endregion

        #region Unary Operators
        public static Complex operator ++(Complex C)
        {
            return new Complex()
            {
                Real = (C?.Real ?? 0) + 1,
                Imag = (C?.Imag ?? 0)
            };
        }

        public static Complex operator --(Complex C)
        {
            return new Complex()
            {
                Real = (C?.Real ?? 0) - 1,
                Imag = (C?.Imag ?? 0)
            };
        }
        #endregion

        #region Comparison Operators [Relational Operators]
        public static bool operator >(Complex left, Complex right)
        {
            if (left?.Real == right?.Real)
                return left?.Imag > right?.Imag;
            else
                return left?.Real > right?.Real;
        }

        public static bool operator <(Complex left, Complex right)
        {
            if (left?.Real == right?.Real)
                return left?.Imag < right?.Imag;
            else
                return left?.Real < right?.Real;
        }
        #endregion


        #endregion

        #region Casting operators overloading
        // Overloadnig Casting Operator : Create Non private Class member Function
        public static /*int*/ explicit operator int (Complex C)
        {
            return (C?.Real ?? 0);
        }
        public static /*string*/ explicit operator string (Complex C)
        {
            return C?.ToString() ?? string.Empty;
        }
        #endregion
    }
}
 