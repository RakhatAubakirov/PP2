using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Task_1
{
    public class ComplexNumber
    {
        public double a;
        public double b;
        public string s;
        public ComplexNumber()
        {

        }
        public ComplexNumber(double a, double b)
        {
            this.a = a;
            this.b = b;
            s = a + " " + "+" + " " + b + "i";
        }
        public override string ToString()
        {
            return s;
        }

    }
    class Program
    {
        public static void Ser()
        {
            ComplexNumber complex = new ComplexNumber(5.8, 4.5);
            FileStream fs = new FileStream(@"D:\Desktop\PP2\seri.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer ser = new XmlSerializer(typeof(ComplexNumber));
            ser.Serialize(fs, complex);
            fs.Close();
        }
        public static void deser()
        {
            FileStream fis = new FileStream(@"D:\Desktop\PP2\seri.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer ser = new XmlSerializer(typeof(ComplexNumber));
            ComplexNumber complex = ser.Deserialize(fis) as ComplexNumber;
            fis.Close();
            Console.WriteLine(complex);
        }
        static void Main(string[] args)
        {
            Ser();
            deser();
        }
    }
}
