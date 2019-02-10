using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool IsPrime(int x)
            {
                int cnt = 0;
                for(int i = 1; i <= x; i++)
                {
                    if (x % i == 0)
                        cnt++;
                }
                if (cnt == 2)
                    return true;
                return false;
            }
            StreamReader sr = new StreamReader(@"D:\Desktop\PP2\Week 2\info.txt");
            StreamWriter sw = new StreamWriter(@"D:\Desktop\PP2\Week 2\answer.txt");
            string[] arr = sr.ReadLine().Split(' ');
            for(int i = 0; i < arr.Length; i++)
            {
                int x = int.Parse(arr[i]);
                if (IsPrime(x))
                    sw.Write(x + " ");

            }
            sr.Close();
            sw.Close();

           
        }
    }
}
