using System;
using System.IO;

namespace _002
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = new string[100];
            try
            {
                using (StreamReader sr = new StreamReader ("D:/vs/workspace/001.txt"))
                {
                    string line;
                    int i = 0;
                    // 从文件读取并显示行，直到文件的末尾 
                    while ((line = sr.ReadLine()) != null)
                    {

                        
                             if (line.Contains("Hello world"))
                             {
                               line = line.Replace("Hello world", "Hello <你的名字>");
                             }
                        
                        lines[i] = line;
                        i++;
                        
                    }

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("error");

            }

            using (StreamWriter sw = new StreamWriter ("D:/vs/workspace/002.txt"))
            {
                for (int i = 0; i < lines.Length; i++)
                {
                    sw.WriteLine(lines[i]);
                }
                sw.Close();
            }

            Console.ReadKey();

        }
    }
}
