namespace Abstract_Class_Interface_EcxceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name");
            string name = Console.ReadLine();

            Console.WriteLine(name);

            char ch;
            Console.WriteLine("ENter Charactyer");
            ch = (char)Console.Read();


            int c = 0;
            Console.WriteLine("The series is:");
            for (int i = 1; i < 10; i++)
            {
                c = c + i;
                Console.Write(c + " ");
            }

            Console.Write("\nPress 'Enter' to exit the process...");

            while (Console.ReadKey().Key != ConsoleKey.Escape)
            {
                Console.WriteLine("You pressed Enter Key");
            }


        }
    }
}