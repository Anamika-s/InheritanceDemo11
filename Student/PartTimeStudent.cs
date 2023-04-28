using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProject
{
    internal class PartTimeStudent : Student
    {
        string Slot, CourseCode;
        public void GetDetails()
        {
            base.GetDetails();
            Console.WriteLine("Enter Slot");
            Slot = Console.ReadLine();
            Console.WriteLine("Enter CourseCode");
            CourseCode = Console.ReadLine();
        }
        public void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("Slot is  " + Slot);
            Console.WriteLine("CourseCode is " + CourseCode);
        }
    }
}
