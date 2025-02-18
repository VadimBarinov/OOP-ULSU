using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Flower: Plant
    {
        public double stemLength {  get; set; }

        public Flower(string name, string type, double stemLength): base(name, type) 
        {
            this.stemLength = stemLength;
        }

        void Print()
        {
            base.Print();
            Console.WriteLine("Длина стебля: {0}" ,this.stemLength);
        }
    }
}
