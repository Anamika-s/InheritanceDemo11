namespace Constructors_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentProject.PartTimeStudent partTimeStudent1 = new StudentProject.PartTimeStudent();
            partTimeStudent1.GetDetails();
            partTimeStudent1.DisplayDetails();

            StudentProject.PartTimeStudent partTimeStudent2 =
                new StudentProject.PartTimeStudent(rn: 1, address: "Delhi",
                slot: "11-2", name: "Sagar", courseCode:"C001");
                
            partTimeStudent2.DisplayDetails();



        }
    }
}