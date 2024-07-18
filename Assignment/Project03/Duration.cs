using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Project03
{
    class Duration
    {
        private int Hours;
        private int Minutes;
        private int Seconds;
        public Duration()
        {

        }
        public Duration(int Hours, int Minutes, int Seconds)
        {
            this.Hours = Hours;
            this.Minutes = Minutes;
            this.Seconds = Seconds;
        }
        public Duration(int Seconds)
        {
            this.Hours = Seconds / 3600;
            this.Minutes = (Seconds % 3600) / 60;
            this.Seconds = (Seconds) % 60;

        }

        public static Duration operator +(Duration? left, Duration? right)
        {
            int h = (left?.Hours ?? 0) + (right?.Hours ?? 0);
            int m = (left?.Minutes ?? 0) + (right?.Minutes ?? 0);
            int s = (left?.Seconds ?? 0) + (right?.Seconds ?? 0);
            if (s >= 60)
            {
                m = s / 60;
                s %= 60;
            }
            if (m >= 60)
            {
                h += m / 60;
                m %= 60;
            }
            return new Duration(h, m, s);
        }
        public static Duration operator +(Duration? left, int Seconds)
        {
            int h = Seconds / 3600;
            int m = (Seconds % 3600) / 60;
            int s = (Seconds) % 60;

            return new Duration(h, m, s) + left;
        }

        public static Duration operator +(int Seconds, Duration? right)
        {
            int h = Seconds / 3600;
            int m = (Seconds % 3600) / 60;
            int s = (Seconds) % 60;

            return new Duration(h, m, s) + right;
        }

        public static Duration operator ++(Duration? D)
        {
            if (D is not null)
            {
                D.Minutes += 1;

                if (D?.Minutes >= 60)
                {
                    D.Hours += 1;
                    D.Minutes = 0;
                }

                return new Duration()
                {
                    Hours = D.Hours,
                    Minutes = D.Minutes,
                    Seconds = D.Seconds,
                };
            }
            return new Duration();
        }

        public static Duration operator --(Duration? D)
        {
            if (D is not null)
            {
                if (D.Minutes > 0)
                    D.Minutes -= 1;
                else
                    D.Hours -= 1;

                return new Duration(D.Hours, D.Minutes, D.Seconds);
            }
            return new Duration();
        }

        public static Duration operator -(Duration? left, Duration? right)
        {
            return new Duration()
            {
                Hours = (left?.Hours ?? 0) - (right?.Hours ?? 0),
                Minutes = (left?.Minutes ?? 0) - (right?.Minutes ?? 0),
                Seconds = (left?.Seconds ?? 0) - (right?.Seconds ?? 0)
            };
        }

        public static bool operator >(Duration? left , Duration? right)
        {
            if(left?.Hours == right?.Hours)
            {
                if(left?.Minutes == right?.Minutes)
                    return left?.Seconds > right?.Seconds;
                else 
                    return left?.Minutes > right?.Minutes;
            }
            else 
                return left?.Hours > right?.Hours;

        }

        public static bool operator <(Duration? left, Duration? right)
        {
            if (left?.Hours == right?.Hours)
            {
                if (left?.Minutes == right?.Minutes)
                    return left?.Seconds < right?.Seconds;
                else
                    return left?.Minutes < right?.Minutes;
            }
            else
                return left?.Hours < right?.Hours;

        }

        public static bool operator <=(Duration? left, Duration? right)
        {
            if (left?.Hours == right?.Hours)
            {
                if (left?.Minutes == right?.Minutes)
                    return left?.Seconds <= right?.Seconds;
                else
                    return left?.Minutes <= right?.Minutes;
            }
            else
                return left?.Hours <= right?.Hours;

        }

        public static bool operator >=(Duration? left, Duration? right)
        {
            if (left?.Hours == right?.Hours)
            {
                if (left?.Minutes == right?.Minutes)
                    return left?.Seconds >= right?.Seconds;
                else
                    return left?.Minutes >= right?.Minutes;
            }
            else
                return left?.Hours >= right?.Hours;

        }

        public static bool operator true (Duration? D)
        {
            return D is not null;
        }
        public static bool operator false(Duration? D)
        {
            return D is null;

        }

        public static  explicit operator DateTime(Duration? D)
        {
            
            return new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, D?.Hours ?? 0 , D?.Minutes ?? 0 , D?.Seconds ?? 0);
        }
        public override string ToString()
        {
            return $"Hours:{Hours} , Minutes:{Minutes} , Seconds:{Seconds}";
        }
        public override bool Equals(object? obj)
        {
            Duration? other = (Duration?)obj ;
            return (other?.Hours == this.Hours && other?.Minutes == this.Minutes && other?.Seconds == this.Seconds);
        }
        public override int GetHashCode()
        {
            int h = 100;
            h += Hours.GetHashCode();
            h += Minutes.GetHashCode();
            h += Seconds.GetHashCode();
            return h;
        }
    }
}
