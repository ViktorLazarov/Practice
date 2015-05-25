using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Linq;

public class WordCount
{
    public static void Main()
    {
        StreamReader fileWords = new StreamReader("words.txt", Encoding.UTF8);
        StreamReader fileText = new StreamReader("text.txt", Encoding.UTF8);
        StreamWriter fileDestination = new StreamWriter("result.txt");

        Dictionary<string, int> wordsDict = new Dictionary<string, int>();
        using (fileWords)
        {
            string line = fileWords.ReadLine();
            while (line != null)
            {
                string[] lineWords = line.Split(new char[] { ' ', '\n', '.', '!', '?', '-', ',' }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < lineWords.Length; i++)
                {
                    lineWords[i] = lineWords[i].ToLower();
                    if (!(wordsDict.ContainsKey(lineWords[i])))
                    {
                        wordsDict.Add(lineWords[i], 0);
                    }
                    
                }

                line = fileWords.ReadLine();

            }

            using (fileText)
            {
                using (fileDestination)
                {
                    string lineText = fileText.ReadLine();
                    while (lineText != null)
                    {
                        string[] lineTextSplitted = lineText.Split(new char[] { ' ', '\n', '.', '!', '?', '-', ',' }, StringSplitOptions.RemoveEmptyEntries);
                        for (int j = 0; j < lineTextSplitted.Length; j++)
                        {
                            lineTextSplitted[j] = lineTextSplitted[j].ToLower();
                            if (wordsDict.ContainsKey(lineTextSplitted[j]))
                            {
                                wordsDict[lineTextSplitted[j]] += 1;
                            }
                        }
                        lineText = fileText.ReadLine();
                    }
                    foreach (var wordCount in wordsDict.OrderByDescending(key => key.Value))
                    {
                        fileDestination.WriteLine("{0}-{1}",wordCount.Key,wordCount.Value);
                    }
                    Console.WriteLine("done");
                }
            }

        }
        

    }
}