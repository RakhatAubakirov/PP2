using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"D:\Desktop\PP2\Week 2\inf.txt" , FileMode.Open , FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string s = sr.ReadLine();
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            string s1 = new string(arr);
            if (s == s1)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
    }
}
