using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Formats.Asn1.AsnWriter;

namespace MultiLevel
{
    internal class Student
    {
        int rn;
        string name;
        public void GetDetails()
        {
            Console.WriteLine("Enter RollNo");
            rn = Byte.Parse(Console.ReadLine());
            Console.WriteLine("ENter NAme");
            name = Console.ReadLine();
        }
        public void DisplayDEtails()
        {
            Console.WriteLine("Rn is {0}", rn);
            Console.WriteLine("NAme is {0}", name);
        }
    }

    class Sports : Student
    {
        string sportsName;
        protected int score;
        public void GetDetails()
        {
           base.GetDetails();
            Console.WriteLine("ENter sportsName");
            sportsName = Console.ReadLine();
            Console.WriteLine("Enter score");
            score = Byte.Parse(Console.ReadLine());
        }
        public void DisplayDEtails()
        {base.DisplayDEtails();
            Console.WriteLine("sportsName is {0}", sportsName);
            Console.WriteLine("score is {0}", score);
        }
    }

    class Test : Sports
    {
        int[] marks = new int[5];
        protected int total = 0;
        public void GetDetails()
        {
            base.GetDetails();
            Console.WriteLine("ENter Marks ");
            for(int i=0;i<5;i++)
            {
                marks[i]= Byte.Parse(Console.ReadLine());
            }
            
        }
        public void CalculateTotalMarks()
        {

            for (int i = 0; i < 5; i++)
            {
                total += marks[i];
            }

        }
        public void DisplayDEtails()
        {base.DisplayDEtails();
            Console.WriteLine("total is {0}", total);
             
        }
    }

    class Result : Test
    {
        int totalScore;
        public void DispayResult()
        {
            totalScore = score + total;
            Console.WriteLine("Total SCore is " + totalScore);
        }
    }
}
