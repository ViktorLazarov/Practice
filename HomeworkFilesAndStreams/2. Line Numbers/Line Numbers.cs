using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
class LineNumbers
{
    static void Main()
    {
        StreamReader reader = new StreamReader("../../Line Numbers.cs");
        StreamWriter writer = new StreamWriter("../../result-text.txt");

        using (reader)
        {
            using (writer)
            {
                int lineCount = 1;
                while (true)
                {
                    string line = reader.ReadLine();
                    if (line == null)
                    {
                        break;
                    }
                    writer.WriteLine("{0} {1}", lineCount, line);
                    lineCount++;
                }

            }
        }
    }
}

