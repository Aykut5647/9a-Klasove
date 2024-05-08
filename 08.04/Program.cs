using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08._04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kolko danni shte vivejdash: ");
            int n = int.Parse(Console.ReadLine());
            string str = "Hello, Aykut v C#";
            Console.WriteLine(str);
            Console.WriteLine("Samo 1 ime");
            string name =Console.ReadLine();
            Console.WriteLine("Hi, "+ name);
            Console.WriteLine("Samo 2 ime");
            string last_name =Console.ReadLine();
            Console.WriteLine("Hi,{0},{1}",name, last_name);
            Console.WriteLine("Samo 3 ime");
            string family_name =Console.ReadLine();
            Console.WriteLine ($"Hi,{name},{last_name},{family_name}");
            int result = string.Compare(name, last_name, true);
            Console.WriteLine(result);
            string str1 = string.Concat(name, family_name);
            Console.WriteLine(str1);
            int firstIndex = str.IndexOf(",");
            Console.WriteLine(firstIndex);
            int secondIndex= str.IndexOf("a", 1);
            Console.WriteLine(secondIndex);
            int notFound = str.IndexOf("/");
            Console.WriteLine(notFound);
            string name1= str.Substring(7,5);
            Console.WriteLine(name1);
            string nameAndExtension= str.Substring(0,5);
            Console.WriteLine(nameAndExtension);
            string replaced = str.Replace("v C#", "si otiva");
            Console.WriteLine(replaced);
        }
    }
}
