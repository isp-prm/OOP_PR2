using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Nakladnaya: Document
    {
        private string From;
        private string To;

        public Nakladnaya() : base() {
            From = String.Empty;
            To = String.Empty;
        }

        public Nakladnaya(string from, string to) : base()
        {
            From = from;
            To = to;
        }

        public Nakladnaya(int paySize, string number) : base(paySize, number)
        {
            From = String.Empty;
            To = String.Empty;
        }

        public Nakladnaya(int paySize, string number, string from, string to): base(paySize, number)
        {
            From = from;
            To = to;
        }

        public override string ToString()
        {
            return base.ToString() + $" Откуда: {From} Куда: {To}";
        }
    }
}
