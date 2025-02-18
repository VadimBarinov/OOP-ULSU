using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Plant
    {
        public string name { get;set; } // имя
        public string type { get; set; } // вид

        public Plant(string name, string type)
        {
            this.name = name;
            this.type = type;
        }

        public void Print()
        {
            Console.WriteLine("Имя: {0}", this.name);
            Console.WriteLine("Вид: {0}", this.type);
        }

    }
}
