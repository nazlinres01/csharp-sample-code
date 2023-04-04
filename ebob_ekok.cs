using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int buyuk = 0;
            Console.Write("bir sayi giriniz....:");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.Write("bir sayi giriniz....:");
            int sayi2 = int.Parse(Console.ReadLine());
            for (i = 1; i <= sayi1; i++) 
            {
                if (sayi1 % i == 0 & sayi2 % i == 0) 
                {

                   Console.Write(" {0}", i) ;//ortak çarpanlar
                   if (i> buyuk)
                   {
                     buyuk =i;

                   }
                } 
                
                
            }
            Console.WriteLine();
            Console.Write("EBOB:{0}", buyuk);
          
            Console.WriteLine();
            int ekok = (sayi1 * sayi2) / buyuk;//ekok kuralı 
            Console.Write("EKOK:{0}", ekok);
            Console.WriteLine();
           















        }
    }
}
