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
             bool IsPrime(int x)
            {
                bool ch = true;
                if (x == 1)
                    ch = false;
                for(int i = 2; i < x; i++)
                {
                    if (x % i == 0)
                        ch = false;
                }
                return ch;
            }
            int n = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            string[] arr = s.Split();
            int cnt = 0;
            
            for(int i = 0; i < n; i++)
            {
                int b = int.Parse(arr[i]);
                if (IsPrime(b))
                {
                    cnt++;
                }
            }
            Console.WriteLine(cnt);
            for(int i = 0; i < n; i++)
            {
                int b = int.Parse(arr[i]);
                if (IsPrime(b))
                {
                    Console.Write(b + " ");
                }

                    
            }
        }
    }
}
