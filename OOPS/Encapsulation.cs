using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    public class Encapsulation
    {
        public double length;
        internal double width;
        protected double area;

        public void AcceptDetails()
        {
            Console.Write("Enter lenght : ");
            length = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter width : ");
            width = Convert.ToDouble(Console.ReadLine());
        }

        public double CalculateArea(double l, double w)
        {
            length = l;
            width = w;
            double area = length * width;
            Console.WriteLine("Area = {0}", area);
            return area;
        }
    }
}
