using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();//input number of decimals
            string s2 = Console.ReadLine();// input decimals
            int n = int.Parse(s1);//convert number of decimals from string to int
            string[] mas = s2.Split();//make an array from second string
            for (int i = 0; i < mas.Length; ++i)//make cycle from 0 to length-1
            {
                int x = int.Parse(mas[i]);//convert from string to int
                for (int j = 0; j < 2; ++j)//because of this is cycle in cycle we will output answer twice, when j = 0 and j = 1
                {
                    Console.Write(x + " ");
                }
            }
        }

    }

}
