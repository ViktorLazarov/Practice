using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

  class ValidUsername
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string pattern = @"\b(([a-zA-Z][\w+\d+]{2,24}))\b";
            Regex regEx = new Regex(pattern);
            MatchCollection matches = regEx.Matches(input);
            int sum = 0;
            int bestSum = int.MinValue;
            int first = 0;
            int second = 1;
            for (int i = 0; i < matches.Count - 1; i++)
            {
                sum = matches[i].Length + matches[i + 1].Length;
                if (sum > bestSum)
                {
                    bestSum = sum;
                    first = i;
                    second = i + 1;
                }
            }
            Console.WriteLine(matches[first]);
            Console.WriteLine(matches[second]);

        }
    }