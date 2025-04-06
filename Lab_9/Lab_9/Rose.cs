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

        public override void PrintDetails()
        {
            Console.WriteLine(this.ToString());
        }

        public override string ToString()
        {
            return base.ToString() + string.Format($"Цвет: {this.color}; ");
        }

        public void GetColor(out string getColor)
        {
            getColor = this.color; // Присваиваем значение параметру
        }

    }
}
