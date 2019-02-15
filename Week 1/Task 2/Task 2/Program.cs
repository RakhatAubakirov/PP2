using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Student//create new class student
    {
        public string name;
        public string id;
        public int year = 1;//year by default is eaual to 1
        public Student(string name, string id)
        {
            this.name = name;//access to name
            this.id = id;//access to id
        }
        public void print()//function for printing
        {
            year++;//increment year

            Console.WriteLine(name + " " + id + " " + year);//print
        }

    }
    
        class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("Rakhat", "18BD110360");//create new  copy
            s.print();//call function print
          
        }
    }

}











