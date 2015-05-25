using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace _1.Series_of_Letters
{
    class SeriesofLetters
    {
        static void Main()
        {
            string input = "aaaabbbvvvdddeeeee";
            string pattern = @"([a-z])\1+";
            Regex regEx = new Regex(pattern);
            MatchCollection matches = regEx.Matches(input);
            for (int i = 0; i < matches.Count; i++)
            {
                string tempPattern = matches[i].ToString();
                string replace = tempPattern.First().ToString();
                Regex tempRegEx = new Regex(tempPattern);
                input = tempRegEx.Replace(input, replace);
            }
            Console.WriteLine(input);

 
        }
    }
}
