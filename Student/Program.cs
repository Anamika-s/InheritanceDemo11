namespace StudentProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Student student = new Student();
            //student.GetDetails();
            //student.DisplayDetails();

            Console.WriteLine("PArtTime");
            PartTimeStudent partTimeStudent = new PartTimeStudent();
            partTimeStudent.GetDetails();
            //partTimeStudent.GetPartTimeStudentDetails();
            partTimeStudent.DisplayDetails();
            //partTimeStudent.DisplayPartTimeStudentDetails();


            Console.WriteLine("FullTime");


            FullTimeStudent fullTimeStudent = new FullTimeStudent();    
            fullTimeStudent.GetDetails();
            fullTimeStudent.DisplayDetails();

        }
    }
}