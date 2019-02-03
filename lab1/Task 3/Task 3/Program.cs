using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            int n = int.Parse(s1);
            string[] mas = s2.Split();
            for(int i = 0; i < mas.Length; ++i)
            {
                int x = int.Parse(mas[i]);
                    for(int j = 0; j < 2; ++j)
                {
                    Console.Write(x + " ");
                }
            }
        }
    }
}
