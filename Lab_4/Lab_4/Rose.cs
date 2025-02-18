using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    internal class Rose: Flower
    {
        public string color { get; set; }

        public Rose(string name, string type, double stemLength, string color): base(name, type, stemLength)
        {
            this.color = color;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Цвет: {0}", this.color);
        }

        public override string ToString()
        {
            return base.ToString() + string.Format("Цвет: {0}; ", this.color);
        }

        public override string? GetColor() {  return color; }

    }
}
