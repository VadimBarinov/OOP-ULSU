using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    internal class Wood: Plant
    {
        public int age { get; set; }

        public Wood(string name, string type, int age): base(name, type) 
        {
            this.age = age;
        }
        
        public override void Print()
        {
            base.Print();
            Console.WriteLine("Возраст: {0} лет", this.age);
        }

        public override string ToString()
        {
            return base.ToString() + string.Format("Возраст: {0}; ", this.age);
        }
    }
}
