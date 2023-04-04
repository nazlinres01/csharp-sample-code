using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci Ogr = new Ogrenci();
            Ogr.OgrenciAdi = "Nazli";
            Ogr.OgrenciNo = 191210074;
            Console.WriteLine(Ogr.OgrenciAdi);
            Console.WriteLine(Ogr.OgrenciNo);
            Console.ReadKey();
        }
    }
}
