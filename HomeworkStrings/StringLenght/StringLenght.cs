using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class StringLenght
{
    static void Main()
    {
        string def = new string('*', 20);
        string input = Console.ReadLine();
        int strLenght = input.Length;

        if (strLenght <= 20)
        {
            string tempStr = def.Remove(0, strLenght);
            string result = input + tempStr;
            Console.WriteLine(result);    
 
        }
        
    }
}

