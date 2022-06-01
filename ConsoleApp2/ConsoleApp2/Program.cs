using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Name = "All Right  ";
            string newName = Name.TrimEnd();
            Console.WriteLine(newName);

            string Str = "All Right is okay";
            string bstr = Str.Remove(5);
            Console.WriteLine(bstr);

            string nstr = "P227 examination ";
            string mstr=nstr.Substring(5,10);
            Console.WriteLine(mstr);

            string Name3 = "Hello World";
            for (int i = 0; i <Name3.Length; i++)
            {
                string newName3 = Name3.Substring(i, 1);
                Console.WriteLine(newName3); 
            }




            int[] Arr = { 1, 5, 7, 2, 4, 8 };
            int[] newArr = new int[6];
            

            Arr.CopyTo(newArr, 0);
            foreach (var item in newArr)
            {
                Console.WriteLine(item);
            }


            int[] Arrr = { 1, 5, 7, 2, 4, 8 };

            int[] newArrr = new int[7];
            Array.Resize( ref Arrr,7) ;

            foreach (var item in Arrr)
            {
                Console.WriteLine(item);
            }

        }
    }
}
