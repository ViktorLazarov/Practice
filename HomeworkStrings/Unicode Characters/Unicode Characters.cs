using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unicode_Characters
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            foreach (char character in input)
            {
                Console.Write(@"\u{0}",((int) character).ToString("x4"));
            }
            Console.WriteLine();     
                      
        }
    }
}
