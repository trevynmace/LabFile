using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabFile
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintPoem("Poem.txt");
            SavePoemWithLineNumbers();
        }

        static void PrintPoem(String fileName)
        {
            try
            {
                using (StreamReader reader = new StreamReader(fileName))
                {
                    Console.Write(reader.ReadToEnd());
                }
            }
            catch(Exception ex)
            {
                //do something
            }
        }

        static void SavePoemWithLineNumbers()
        {
            try
            {
                using (StreamReader reader = new StreamReader("Poem.txt"))
                {
                    using (StreamWriter writer = new StreamWriter("Poem1.txt"))
                    {
                        int count = 1;

                        while (!reader.EndOfStream)
                        {
                            string line = reader.ReadLine();
                            writer.WriteLine(string.Format("{0:00} {1}", count, line));
                            count++;
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                //do something
            }
        }
    }
}
