using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool IsPrime(int x)//I created a function that check number prime or not
            {
                bool ch = true;//in the beginning ch is true 
                if (x == 1)//if number = it's automatically prime
                    ch = false;
                for (int i = 2; i < x; i++)//to know number prime or not it's enough to check does this number divide by two to this number-1
                {
                    if (x % i == 0)// if number is divide by decimal except for 1 and itself number isn't prime 
                        ch = false;
                }
                return ch;
            }
            int n = int.Parse(Console.ReadLine());// input a number of decimals
            string s = Console.ReadLine();//input decimals in string
            string[] arr = s.Split();//make a array 
            int cnt = 0;// make a counter

            for (int i = 0; i < n; i++)
            {
                int b = int.Parse(arr[i]);
                if (IsPrime(b))//if nubmer prime counter increase
                {
                    cnt++;//counter show how many primes we have
                }
            }
            Console.WriteLine(cnt);//output number of primes
            for (int i = 0; i < n; i++)
            {
                int b = int.Parse(arr[i]);
                if (IsPrime(b))
                {
                    Console.Write(b + " ");//if prime output decimals
                }


            }
        }
    }
}

