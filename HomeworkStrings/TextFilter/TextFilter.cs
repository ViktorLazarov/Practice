using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFilter
{
    class TextFilter
    {
        static void Main()
        {
            Console.Write("Input: ");
            string[] bannedWords = Console.ReadLine().Split(',').Select(p => p.Trim()).ToArray();
            

            Console.Write("Please enter text: ");
            string text = Console.ReadLine();
            StringBuilder textResult = new StringBuilder(text);

            foreach (string word in bannedWords)
            {
                string changedWord = new string('*', word.Length);
                textResult.Replace(word, changedWord);
            }
            Console.WriteLine(textResult.ToString());
            


        }
    }
}
