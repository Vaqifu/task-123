using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "hello";
            string b=  (string)a.Clone();
            Console.WriteLine(b);

            string Str = "Hi,How are you? ";
            string bstr = (string)Str.Clone();
            Console.WriteLine(bstr);

            string ab = "Etel";
            String bc = "Lilian";
            string cd = "Voynic";
            string dc= (string.Concat(ab,bc,cd));
            Console.WriteLine(dc);

            string g = "hello teacher";
            string v = "hello ";
            Console.WriteLine(g.Contains(v));


            string Name = "eli";
            string Name1 = "eli";
            Console.WriteLine(Name.Equals(Name1));


            string Name2 = "Extra";
            int c = Name2.IndexOf("r");
            Console.WriteLine(c);


            string t = "wearing";
            string z = t.Substring(4);
            Console.WriteLine(z);

            string desstr = "Apple 3";
            string p = desstr.Trim();

            Console.WriteLine(p);


           



        }
    }
}
