using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Dikdortgen
    {
        public int en;
        public int boy;
        public int cevre;
        public int alan;

        public void AlanHesapla()
        {
            alan = en * boy;
            Console.WriteLine("Alan:" + alan);
        }
        public void CevreHesapla()
        {
            cevre = 2 * (en + boy);
            Console.WriteLine("Cevre:" + cevre);
        }
    }
}
