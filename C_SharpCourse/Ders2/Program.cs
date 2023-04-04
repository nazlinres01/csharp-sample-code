using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders2
{
    class Program
    {
        //ctrl+k sonra ctrl+d kodları düzeltme işlemi
        static void Main(string[] args)
        {
            var number = 11;
            if (number == 10)
            {
                Console.WriteLine("Number is 10");
            }
            else if (number == 20)
            {
                Console.WriteLine("Number is 20");
            }
            else
            {
                Console.WriteLine("Number is not 10 or 20");
            }

            //var number2 = 20;

            //switch (number2)
            //{
            //    case 15:
            //        Console.WriteLine("Number is 15");
            //        break;
            //    case 30:
            //        Console.WriteLine("Number is 30");
            //        break;
            //    default:
            //        Console.WriteLine("Number is not 15 or 30");
            //        break;
            //}

            Console.ReadLine();
        }
    }
}
