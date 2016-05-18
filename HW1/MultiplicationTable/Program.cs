using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please provide an integer parameter: ");
            string userInput = Console.ReadLine();
            int x;

            if (int.TryParse(userInput, out x) == false)
            {
                Console.WriteLine("You did not enter a valid integer.");
                Console.ReadLine();
                Environment.Exit(1);
            }

            for (int i = 1; i <= x; i++)
            {
                for (int j = 1; j <= x; j++)
                {
                    Console.Write(i * j);
                    Console.Write(" ");
                }

                Console.Write("\n");
            }

            Console.ReadLine();
        }
    }
}
