using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Slicing_Files
{ // Big THANKS to EBojilova
    class SlicingFiles
    {
        static void Main()
        {
            Console.Write("parts:");
            int parts = int.Parse(Console.ReadLine());
            SliceFile(parts);
            for (int i = 0; i < parts; i++)
            {
                AssembleFile(i);
            }
            
        }

        public static void AssembleFile(int i)
        {
            using (FileStream source = new FileStream(string.Format("../../file part-{0}.jpg", i), FileMode.Open))
            {
                using (FileStream output = new FileStream("../../assembledFile.jpg",FileMode.Append))
                {
                    byte[] buffer = new byte[source.Length];
                    source.Read(buffer, 0, buffer.Length);
                    output.Write(buffer, 0, buffer.Length);
                }
                
            }

        }
        public static void SliceFile(int parts) 
        {
            using (FileStream source = new FileStream("../../file.jpg", FileMode.Open))
            {
                long sliceSize = source.Length / parts;
                long leftOver = source.Length - sliceSize * parts;
                for (int i = 0; i < parts; i++)
                {
                    using (FileStream output = new FileStream(string.Format("../../file part-{0}.jpg",i),FileMode.Create))
                    {
                        if (i > parts -1)
                        {
                            sliceSize = sliceSize + leftOver;
                        }
                        byte[] buffer = new byte[sliceSize];
                        source.Read(buffer, 0, buffer.Length);
                        output.Write(buffer, 0, buffer.Length);
                   }
                }   
            }
        }
    }
}
