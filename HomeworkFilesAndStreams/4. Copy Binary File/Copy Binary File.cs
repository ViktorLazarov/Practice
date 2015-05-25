using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class CopyBinaryFile
    {
        static void Main()
        {
            FileStream inputStream = new FileStream("tattoo.png", FileMode.Open);
            FileStream outputStream = new FileStream("tattoo-copy.png", FileMode.Create);
            
            using (inputStream)
            {
                using (outputStream)
                {
                    byte[] buffer = new byte[4096];
                    while (true)
                    {
                        int readByte = inputStream.Read(buffer, 0, buffer.Length);
                        if (readByte == 0)
                        {
                            break;
                        }
                        outputStream.Write(buffer, 0, readByte);
                    }

                }
            }

        }
    }

