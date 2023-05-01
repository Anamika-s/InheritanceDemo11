using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_Interface_EcxceptionHandling
{
    internal class Square
    {
        int side, area;
        public  void GetDimensions()
        {
            Console.WriteLine("Enter side");
            side = byte.Parse(Console.ReadLine());
        }

        public void CalculateArea()
        {
            area = side * side;
        }
        public void DisplayArea()
        {
            Console.WriteLine("Area is {0} ", area);
        }
    }

}
