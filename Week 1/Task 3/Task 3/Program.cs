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
            string s1 = Console.ReadLine();//input number of decimals
            string s2 = Console.ReadLine();// input decimals
            int n = int.Parse(s1);//convert number of decimals from string to int
            string[] mas = s2.Split();//make an array from second string
            List<int> list = new List<int>();// make an dynamic array
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < 2; j++)
                {
                    list.Add(int.Parse(mas[i]));//convert string to int and fill the array
                }
            }
            
            for (int i = 0; i < list.Count; i++)// go through array
            {
                Console.Write(list[i] + " ");// print all numbers of array
            }

        }

    }

}
