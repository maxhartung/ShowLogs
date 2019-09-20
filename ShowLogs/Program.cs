using System;
using System.IO;

namespace ShowLogs
{
    class Program
    {
        void Show(string path)
        {
            string contents;
            path = path.Replace("\"", "");
            try
            {
                var logfiles = Directory.EnumerateFiles(path, "*.log", SearchOption.AllDirectories);
                foreach (string currentFile in logfiles)
                {
                    contents = File.ReadAllText(currentFile);
                    Console.WriteLine(contents);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void Main(string[] args)
        {
            bool exit = false;
            Console.Write("Enter folder path: ");
            var path = Console.ReadLine();
            Program p = new Program();
            Console.WriteLine("\n\n");
            p.Show(path);
            while (exit != true) {
                string s = Console.ReadLine();

                if (s == "") {
                    p.Show(path);
                }
                else if (s == "exit") {
                    break;
                }
            }
        }
        
    }
}
