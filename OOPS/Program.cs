﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class Program
    {
        static void Main(string[] args)
        {
            Encapsulation e = new Encapsulation();            
            e.AcceptDetails();
           double area = e.CalculateArea();
            Console.WriteLine("area of object is : {0}", area);
            Console.ReadLine();
        }
    }
}
