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
        string batchCode, regdDate;
        public FullTimeStudent() : base()
        {

        }

        public FullTimeStudent(int rn, string name,
            string address, string batchCode, string regdDate)
            : base(rn , name, address)
        {
            this.batchCode = batchCode;
            this.regdDate = regdDate;
        }
        public void GetDetails()
        {

            base.GetDetails();
            Console.WriteLine("Enter batchCode");
            batchCode = Console.ReadLine();
            Console.WriteLine("Enter Address");
            regdDate = Console.ReadLine();
        }
        public void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("batchCode is  " + batchCode);
            Console.WriteLine("RegdDate is " + regdDate);
        }
    }
}
