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
            string Path1 = @"D:\Desktop\PP2\Week 2\file 1.txt";//path for original file
            string Path2 = @"D:\Desktop\PP2\Week 2\file 2.txt";//path for new file
            StreamWriter sw = new StreamWriter(Path1);//creates new file
            sw.WriteLine("something");
            sw.Close();
            File.Copy(Path1, Path2);//copies from 1 to 2
            File.Delete(Path1);//delete original
        }
    }
}
