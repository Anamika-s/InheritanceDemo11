using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_Interface_EcxceptionHandling
{
    internal class Triangle : Shape
    {
        int Base, height;
        public override void CalculateArea()
        {
            area =  (int)  .5 * Base * height;
        }
        public override void GetDimensions()
        {
            
        }
    }
}
