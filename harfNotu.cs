using System;

namespace ConsoleApp1
{
    class Program
    {

        
       
       
        static void Main(string[] args)
        {        
            string harf;
            Console.WriteLine("lütfen notunuzu giriniz:");
            harf=Console.ReadLine();
            if (harf == "A")
            {
                Console.WriteLine("basarılı");

            }
            else if (harf == "B")
            {
                Console.WriteLine("orta");
            }
            else if(harf=="C")
            {
                Console.WriteLine("basarısız");
            }



        }
    }
}

