﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    internal class Flower: Plant
    {
        public double stemLength {  get; set; }

        public Flower(string name, string type, double stemLength): base(name, type) 
        {
            this.stemLength = stemLength;
        }
        public override string ToString()
        {
            return base.ToString() + string.Format($"Длина стебля: {this.stemLength}; ");
        }

        public override void PrintDetails()
        {
            Console.WriteLine(this.ToString());
        }

    }
}
