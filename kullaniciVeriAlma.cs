using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course1
{
    class Program
    {
        static void Main(string[] args)
        {
            string isim = Console.ReadLine();//kullanıcıdan veri alma
            Console.WriteLine("Adım " + isim);
            Console.ReadKey();

            string veri = Console.ReadLine();
            int sayi = int.Parse(veri);//Convert.ToInt32();
        }
    }
}
