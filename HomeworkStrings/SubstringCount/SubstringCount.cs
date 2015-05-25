using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubstringCount
{
    class SubstringCount
    {
        static void Main()
        {
            Console.WriteLine("Please enter text:");
            Console.WriteLine("------------------");
            string input = Console.ReadLine();
            Console.WriteLine("------------------");
            Console.WriteLine("Please enter keyword:");
            string keyWord = Console.ReadLine();
            Console.WriteLine("******************");
            int count = 0;
            int startIndex = 0;
            while (input.IndexOf(keyWord,startIndex,StringComparison.OrdinalIgnoreCase) >= 0)
            {
                count++;
                startIndex = input.IndexOf(keyWord, startIndex, StringComparison.OrdinalIgnoreCase) + 1;
            }
            Console.Write("Keyword count is:");
            Console.WriteLine(count);
            
            
        }
    }
}
