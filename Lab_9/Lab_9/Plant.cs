using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    internal class Plant: IPlant
    {
        public string name { get;set; } // имя
        public string type { get; set; } // вид

        private static int _objectCounter;
        private int _objectNumber;

        // Статический конструктор
        static Plant()
        {
            // Инициализация статического поля
            _objectCounter = 0;
        }

        public Plant(string name, string type)
        {
            this.name = name;
            this.type = type;
            _objectCounter++;
            _objectNumber = _objectCounter;
        }

        public static int ObjectCounter
        {
            get { return _objectCounter; }
        }
        public override string ToString()
        {
            return string.Format($"Имя: {this.name}; Вид: {this.type}; ");
        }

        public virtual void PrintDetails()
        {
            Console.WriteLine(this.ToString());
        }


        public static void PrintObjectCount()
        {
            Console.WriteLine($"Общее количество созданных объектов: {_objectCounter}");
        }

    }
}
