using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Kvitanciya: Document
    {
        protected string ForWhat;

        public Kvitanciya() : base() {
            ForWhat = string.Empty;
        }

        public Kvitanciya(string forWhat) : base()
        {
            ForWhat = forWhat;
        }

        public Kvitanciya(int paySize, string number): base(paySize, number)
        {
            ForWhat = string.Empty;
        }

        public Kvitanciya(int paySize, string number, string forWhat): base(paySize, number)
        {
            ForWhat = forWhat;
        }

        public override string ToString()
        {
            return base.ToString() + $" За что: {ForWhat}";
        }
    }
}
