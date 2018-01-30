using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, enter one number at a time, and I will add them together.");
            Console.WriteLine("Please type in your first number.");
            int numbHolder = 0;
            
            while (true) {
                string userNumb = Console.ReadLine();
                if (userNumb == "ok") {
                    break;
                }
                int numbConvert = Convert.ToInt32(userNumb);
                numbHolder += numbConvert;
                numbConvert = 0;
                Console.WriteLine("Enter your next number or type 'ok' to if that was your last number.");
                }
            Console.WriteLine("Great, you've finished typing your numbers, your final total is, \n {0}", numbHolder);
        }
    }
}
