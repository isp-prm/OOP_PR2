using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Document : IComparable, ICloneable
    {
        protected int paySize;
        protected string number;

        public Document() {
            this.paySize = 0;
            this.number = string.Empty;
        }

        public Document(int paySize, string number) {
            this.paySize = paySize;
            this.number = number;
        }

        public override string ToString()
        {
            return $"Сумма: {this.paySize} Номер: {this.number}";
        }

        public int PaySize {
            set
            {
                if (value > 0) { 
                    this.paySize = value;
                }
            }
            get => this.paySize;
        }

        public string Number
        {
            set => this.number = value; 
            get => this.number;
        }

        public int CompareTo(object doc)
        {
            Document tmp = (Document)doc;
            if (this.paySize > tmp.paySize) { return 1; }
            if (this.paySize < tmp.paySize) { return -1; }
            return 0;
        }

        public object Clone()
        {
            return new Document(this.PaySize, $"Копия {this.Number}");
        }
    }
}
