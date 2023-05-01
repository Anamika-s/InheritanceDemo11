using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProject
{
    internal   class Student
    {
        int rn;
        string name;
        string address;
        public Student()
        {

        }

         public Student(int rn , string name, string address)
        {
             this.rn= rn;
            this.name= name;
            this.address= address;
        }
        public void GetDetails()
        {
            Console.WriteLine("Enter Roll No");
            rn = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Enter Name");
            name = Console.ReadLine();
            Console.WriteLine("Enter Address");
            address = Console.ReadLine();
        }
        public void DisplayDetails()
        {
            Console.WriteLine("Roll No is  " + rn);
            Console.WriteLine("Name is  " + name);
            Console.WriteLine("Address is " + address);
        }


    }
}
