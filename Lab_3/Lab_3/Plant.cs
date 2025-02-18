using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    internal class Plant: AllPlants
    {
        public string name { get;set; } // имя
        public string type { get; set; } // вид

        public Plant(string name, string type)
        {
            this.name = name;
            this.type = type;
        }

        public override void Print()
        {
            Console.WriteLine("Имя: {0}", this.name);
            Console.WriteLine("Вид: {0}", this.type);
        }

        public override string ToString()
        {
            return string.Format("Имя: {0}; Вид: {1}; ", this.name, this.type);
        }
    }
}
