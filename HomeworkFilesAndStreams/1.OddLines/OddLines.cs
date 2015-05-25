using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


class OddLines
{
    static void Main()
    {
        StreamReader reader = new StreamReader("../../OddLines.cs");
        using (reader)
        {
            int lineCount = 0;
            while (true)
            {
                string line = reader.ReadLine();
                if (line == null)
                {
                    break;
                }
                if (lineCount % 2 != 0)
                {
                    Console.WriteLine("{0} {1}", lineCount, line);
                }
                lineCount++;
            }
        }
    }
}
