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

        public Duration(int Hours , int Minutes , int Seconds)
        {
            this.Hours = Hours;
            this.Minutes = Minutes;
            this.Seconds = Seconds;
        }
        public Duration(int Seconds)
        {
            this.Hours = Seconds /= 3600;
            this.Minutes = Seconds /= 60;
            this.Seconds = Seconds ;
            
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
