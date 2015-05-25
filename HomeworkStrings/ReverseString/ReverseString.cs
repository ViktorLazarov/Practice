using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
      
        string input = Console.ReadLine();
        char[] Arr = input.ToArray();
        Array.Reverse(Arr);
        for (int i = 0; i < Arr.Length; i++)
        {
            Console.Write(Arr[i]);
        }
        Console.WriteLine();
        

        

       
        

        
        

    }
}
