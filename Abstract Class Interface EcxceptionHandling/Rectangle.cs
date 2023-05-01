using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_Interface_EcxceptionHandling
{
    internal class Rectangle : Shape
    {
        int length , breadth;
        public  override void GetDimensions()
        {
            Console.WriteLine("Enter length");
            length = byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter breadth");
            breadth = byte.Parse(Console.ReadLine());
        }

        public override void CalculateArea()
        {
            area = length * breadth;
        } 
    }
}
