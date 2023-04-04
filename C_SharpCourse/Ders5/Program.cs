using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ders5
{
    class Program
    {
        static void Main(string[] args)
        {
            //for(int i=100;i>=0;i-=2)
            //{
            //    Console.WriteLine(i);
            //}
            int number = 100;
            while(number>=0)
            {
                Console.WriteLine(number);
                number--;

            }
            int number2 = 10;
            do
            {
                Console.WriteLine(number2);
                number2--;

            } while (number2>=0);
            //şart sağlanmadığında ekrana number2 değeri çıkar

            //asal sayı olup olmama durumu
            if(IsPrimeNumber(9))
            {
                Console.WriteLine("This is a prime number");
            }
            else 
            {
                Console.WriteLine("This is not a prime number");
            }

            Console.ReadLine();
        }
        private static bool IsPrimeNumber(int number)
        {
            bool result = true;
            for(int i=2;i<=number-1;i++)
            {
                if(number%i==0)
                {
                    result = false;
                    i = number;//gereksiz çalışması engellenir
                   
                }

            }
            return result;

        }


    }
}
