using System;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();//input string - number of stars
            int n = int.Parse(s);// convert string to int
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write("*");// output triangle
                }
                Console.WriteLine();
            }

        }
    }
}
