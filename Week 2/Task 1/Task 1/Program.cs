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
            FileStream fs = new FileStream(@"D:\Desktop\PP2\Week 2\inf.txt" , FileMode.Open , FileAccess.Read);//open a stream
            StreamReader sr = new StreamReader(fs);//read from file
            string s = sr.ReadLine();// read string
            char[] arr = s.ToCharArray();//check string to all of chars;
            Array.Reverse(arr);//reverse array
            string s1 = new string(arr);
            if (s == s1)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
    }
}
