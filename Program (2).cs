﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isPrime(int x)
            {
                int crt = 0;
                for (int i = 1; i <= x; i++)
                {
                    if (x%i==0)
                    {
                        crt++;
                    }
                }
                if (crt == 2) return true;
                return false;
            }
            StreamReader sr = new StreamReader("input.txt");
            StreamWriter sw = new StreamWriter("output.txt");
            string[] arr = sr.ReadLine().Split(' ');
            for (int i = 0; i < arr.Length; i++)
            {
                int x = int.Parse(arr[i]);
                if (isPrime(x) == true)
                {         
                    sw.Write(x + " ");
                }
            }
            sr.Close();
            sw.Close();
            
        }
    }
}
