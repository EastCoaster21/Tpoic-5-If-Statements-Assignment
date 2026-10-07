namespace Tpoic_5_If_Statements_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("How Old Are You?");
            age = Convert.ToInt32(Console.ReadLine());
            if (age<=16)
            { Console.WriteLine("You can't drive."); 
            
            }
            else if (age<=18)
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
           
            if (firstname == "Bob")
            {
                Console.WriteLine("Nice name");
            }
            Console.WriteLine("Thank you, sir.");
        }
    }
}
