using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая__5
{
    class Triad
    {
        public int First { get; set; }
        public int Second { get; set; }
        public int Third { get; set; }

        public Triad(int first, int second, int third)
        {
            First = first;
            Second = second;
            Third = third;
        }

        public Triad Add(int increase = 1)
        {
            return new Triad(First + increase, Second + increase, Third + increase);
        }

        public Triad SetParams(int increase = 10)
        {
            return new Triad(First + increase, Second + increase, Third + increase);
        }

        public Triad SetParams(int first, int second, int third)
        {
            return new Triad(First = first, Second = second, Third = third);
        }
    }
}
