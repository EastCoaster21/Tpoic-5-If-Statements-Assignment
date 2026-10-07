using System.Security.Cryptography.X509Certificates;

namespace Tpoic_5_If_Statements_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Part1();
            Part2();
        }
        public static void Part1()
        {

            int age;
            Console.WriteLine("How Old Are You?");
            age = Convert.ToInt32(Console.ReadLine());
            if (age <= 16)
            {
                Console.WriteLine("You can't drive.");

            }
            else if (age <= 18)
            {
                Console.WriteLine("You can't vote.");

            }
            else if (age <= 20)
            {
                Console.WriteLine("You can't rent a car.");

            }
            else if (age > 20)
            {
                Console.WriteLine("You can do anything! (thats legal).");

            }
            string firstname = "Bob";
            Console.WriteLine("Please enter your name.");
            firstname = Console.ReadLine();
            if (firstname.ToLower() == "bob")
            {
                Console.WriteLine("Nice name");
            }
           Console.WriteLine("Thank you, sir.");
            Console.WriteLine("Press Enter to enter the Pizza Shop");
            Console.ReadLine();
        }
        public static void Part2()
        {
            //Console.WriteLine("Pizza making");
            Console.WriteLine("Welcome to E's Pizza!");
            Console.WriteLine("Press Enter To Continue");
            
        }
    }
}
