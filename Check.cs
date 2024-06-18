using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Check: Document
    {
        protected int PositionsCount;

        public Check() : base() { }

        public Check(int positionCount) : base()
        {
            PositionsCount = positionCount;
        }

        public Check(int paySize, string number) : base(paySize, number)
        {
            PositionsCount = 0;
        }

        public Check(int positionCount, int paySize, string number): base(paySize, number) { 
            PositionsCount = positionCount;
        }

        public override string ToString()
        {
            return base.ToString() + $" Кол-во позиций: {PositionsCount}";
        }
    }
}
