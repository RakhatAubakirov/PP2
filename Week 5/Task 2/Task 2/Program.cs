using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Task_2
{
    public class Mark
    {
        public int a;
        public string letter;
        public Mark() { }
        public Mark(int a)
        {
            this.a = a;
            this.getLetter();
        }

        public void getLetter()
        {

            if (a <= 100 && a >= 95) letter = "A";
            else if (a < 95 && a >= 90) letter = "A-";
            else if (a < 90 && a >= 85) letter = "B+";
            else if (a < 85 && a >= 80) letter = "B";
            else if (a < 80 && a >= 75) letter = "B-";
            else if (a < 75 && a >= 70) letter = "C+";
            else if (a < 70 && a >= 65) letter = "C";
            else if (a < 65 && a >= 60) letter = "C-";
            else if (a < 60 && a >= 55) letter = "D+";
            else if (a < 55 && a >= 50) letter = "D";
            else if (a < 50) letter = "F";
        }
        public override string ToString()
        {
            return a + " " + letter;
        }
    }    
        public class ListOfMarks
    {
        public List<Mark> ListOfmarks;
        public ListOfMarks()
        {
            ListOfmarks = new List<Mark>();
        }
        public void ser(ListOfMarks listOfMarks)
        {
            FileStream fs = new FileStream(@"D:\Desktop\PP2\marks.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xml = new XmlSerializer(typeof(ListOfMarks));
            xml.Serialize(fs, listOfMarks);
            fs.Close();
        }
    }
    class Program
    {
        public static void f1()
        {
            Mark s1 = new Mark(100);
            Mark s2 = new Mark(89);
            Mark s3 = new Mark(80);
            ListOfMarks list = new ListOfMarks();
            list.ListOfmarks.Add(s1);
            list.ListOfmarks.Add(s2);
            list.ListOfmarks.Add(s3);
            list.ser(list);
                
        }
        public static void deser()
        {
            FileStream fs = new FileStream(@"D:\Desktop\PP2\marks.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(ListOfMarks));
            ListOfMarks list = xs.Deserialize(fs) as ListOfMarks;
            fs.Close();
            foreach (Mark m in list.ListOfmarks)
            {
                Console.WriteLine(m);
            }
        }
        static void Main(string[] args)
        {
            f1();
            deser();
        }
    }
}
