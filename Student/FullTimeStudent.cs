using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StudentProject
{
    internal class FullTimeStudent : Student
    {
        string batchCode, RegdDate;
        public void GetDetails()
        {

            base.GetDetails();
            Console.WriteLine("Enter batchCode");
            batchCode = Console.ReadLine();
            Console.WriteLine("Enter Address");
            RegdDate = Console.ReadLine();
        }
        public void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("batchCode is  " + batchCode);
            Console.WriteLine("RegdDate is " + RegdDate);
        }
    }
}
