using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Student
    {
        public string name;
        public string id;
        public int year = 1;
        public Student(string name, string id)
        {
            this.name = name;
            this.id = id;
        }
        public void print()
        {
            year++;

            Console.WriteLine(name + " " + id + " " + year);
        }

    }
    
        class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("Rakhat", "18BD110360");
            s.print();
          
        }
    }

}











