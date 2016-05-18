using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 6, 17, 30, 9, 3, 10 };

            Console.WriteLine("The largest number in the array is {0}", Max(array));

            Console.ReadLine();
        }

        static int Max(int[] array)
        {
            int max = array[0];
            int l = array.Length;

            for (int i = 1; i < l; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }

            return max;
        }
    }
}
