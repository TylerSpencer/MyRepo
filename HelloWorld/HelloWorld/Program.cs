using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            int input = 0;

            while (input != 2)
            {
                            Console.WriteLine("Enter 1 to display a message or 2 to exit the program: ");
                input = Convert.ToInt32(Console.ReadLine());

                if (input == 1)
                {
                    Console.WriteLine("Please enter a message to display: ");
                    string message = Console.ReadLine();

                    Console.WriteLine("Your message says '" + message + "'");
                }
                else if (input == 2)
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
                Console.WriteLine(" ");
            }



        }
    }
}
