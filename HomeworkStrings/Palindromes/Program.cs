using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromes
{
    class Program
    {
        static bool IsPalyndrome(string word) 
        {
            if (word.Length == 1)
            {
                return true;
            }
            int lenght = word.Length;
            for (int i = 0; i < lenght/2; i++)
            {
                if (word[i] != word[lenght-i-1])
                {
                    return false;
                }
            }
            return true;
        }
        static void Main()
        {
            SortedSet<string> palyndromes = new SortedSet<string>();

            char[] delimeters = { ' ', ',', '.', '?', '!' };        

            string inputText = Console.ReadLine();
            string[] inputArr = inputText.Split(delimeters, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < inputArr.Length; i++)
            {
                inputArr[i].Trim();
            }
            
            List<string> inputList = inputArr.ToList();
            foreach (string word in inputList)
            {
                if (IsPalyndrome(word))
                {
                    palyndromes.Add(word);
                }
            }
            Console.WriteLine(string.Join(", ",palyndromes));

        }
    }
}
