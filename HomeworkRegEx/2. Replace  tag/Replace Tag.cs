using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ReplaceATag
{
    class ReplaceATag
    {
        static void Main()
        {
            string text = Console.ReadLine();
            string pattern = @"(?<tag><a href=)(?<link>\w+:\/\/[\w+\.\-]+\w+\.\w+)>(?<text>\w+)(<\/a>)";
            Match match = Regex.Match(text, pattern);
            string replace = "[URL href=" + match.Groups["link"] + "]" + match.Groups["text"] + "[/URL]";
            string result = Regex.Replace(text, pattern, replace);
            Console.WriteLine(replace);
        }
    }
}