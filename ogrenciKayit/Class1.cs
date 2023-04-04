using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Ogrenci
    {
        public int OgrenciNo;
        public string OgrenciAdi;
        public Ogrenci()
        {
            Console.WriteLine("KAYIT OLUŞTURULDU");
        }

        static Ogrenci()
        {
            Console.WriteLine("static kurucusu çalıştı");
        }





    }
}
