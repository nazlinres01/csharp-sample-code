using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            string str ="Bilgisayar_Mühendisliği";
            string str2 = "mühendis";
            string str3 = "Mühendis";
          


            Console.WriteLine(str.Contains(str2));
            Console.WriteLine(str.Contains(str3));
            int a = str.IndexOf(str2);
            Console.WriteLine(str.IndexOf(str2));
            if(a>=0)
            {
                Console.WriteLine("var");
            }   
            else
            {
                Console.WriteLine("yok");
            }





        }
    }
}
