using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_3
{
    class Program
    {
        static void Print(int lvl)
        {
            for (int i = 0; i < lvl; i++)
                Console.Write(" ");
        }

            static void ex3(DirectoryInfo directory , int lvl)
        {
            FileInfo[] files = directory.GetFiles();
            DirectoryInfo[] directories = directory.GetDirectories();

                foreach(FileInfo file in files)
            {
                Print(lvl);
                Console.WriteLine(file.FullName);
            }
                foreach(DirectoryInfo dir in directories)
            {
                Print(lvl);
                Console.WriteLine(dir.FullName);
                ex3(dir, lvl + 1);
            }
        }
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"D:\Desktop\PP2\Week 2");
            ex3(dir, 0);

        }
    }
}
