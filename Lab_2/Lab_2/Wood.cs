using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Wood: Plant
    {
        public int age { get; set; }

        public Wood(string name, string type, int age): base(name, type) 
        {
            this.age = age;
        }
        
        public void Print()
        {
            base.Print();
            Console.WriteLine("Возраст: {0} лет", this.age);
        }
    }
}
