using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string Path1 = @"D:\Desktop\PP2\Week 2\file 1.txt";
            string Path2 = @"D:\Desktop\PP2\Week 2\file 2.txt";
            StreamWriter sw = new StreamWriter(Path1);
            sw.WriteLine("something");
            sw.Close();
            File.Copy(Path1, Path2);
            File.Delete(Path1);
        }
    }
}
