using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please provide an integer parameter: ");
            string userInput = Console.ReadLine();
            int x;
            int y;

            if (int.TryParse(userInput, out x) == false)
            {
                Console.WriteLine("You did not provide a valid integer.");
                Console.ReadLine();
                Environment.Exit(1);
            }

            Console.WriteLine("Please provide another integer parameter: ");
            userInput = Console.ReadLine();

            if (int.TryParse(userInput, out y) == false)
            {
                Console.WriteLine("You did not provide a valid integer.");
                Console.ReadLine();
                Environment.Exit(1);
            }

            int area = AreaRect(x, y);
            Console.WriteLine("The calculated area is: {0}.", area);

            Console.ReadLine();
        }

        static int AreaRect(int x, int y)
        {
            int area = x * y;
            return area;
        }
    }
}
