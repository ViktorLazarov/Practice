using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class ExtractEmails
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string pattern = @"(?<=\s|^)([a-z0-9]+(?:[_.-][a-z0-9]+)*@[a-z]+\-?[a-z]+(?:\.[a-z]+)+)\b";
            Regex regEx = new Regex(pattern);
            MatchCollection matches = regEx.Matches(input);
            for (int i = 0; i < matches.Count; i++)
            {
                Console.WriteLine(matches[i]);
            }


        }



    }
}
