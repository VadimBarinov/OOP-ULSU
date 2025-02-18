using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class Int
    {
        private int value; 

        public Int() 
        {
            value = 0;
            Console.WriteLine("Вызван конструктор без параметров");
        }
        public Int(int value)
        {
            Console.WriteLine("Вызван конструктор с параметром");
            this.value = value;
        }
        public Int(Int i)
        {
            Console.WriteLine("Вызван конструктор копирования");
            this.value = i.value;
        }
        ~Int()
        {
            Console.WriteLine("Вызван деструктор");
        }

        public void SetValueNull() { this.value = 0; }

        public void SetValue(int number) { this.value = number; }

        public int GetValue() { return this.value; }

        public void Print() { Console.WriteLine("Значение числа: {0}\n", this.value); }
        public void SumValues(Int first, Int second) { this.value = first.value + second.value; }

    }
}
