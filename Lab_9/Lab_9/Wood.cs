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
        public override string ToString()
        {
            return base.ToString() + string.Format($"Возраст: {this.age}; ");
        }
        
        public override void PrintDetails()
        {
            Console.WriteLine(this.ToString());
        }

        public void IncreaseAge(ref int additionalAge)
        {
            this.age += additionalAge;
            additionalAge = this.age; // Возвращаем обновленное количество лет
        }

    }
}
