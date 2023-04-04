using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    { 
        static void Main(string[] args)
        {
            Dikdortgen dikdortgen = new Dikdortgen();

            dikdortgen.en = int.Parse(Console.ReadLine());
            dikdortgen.boy = int.Parse(Console.ReadLine());
            dikdortgen.AlanHesapla();
            dikdortgen.CevreHesapla();
            Console.ReadKey();
        }
    }
}
