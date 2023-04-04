using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            Islem islem= new Islem();
            islem.topla(4, 6);
            islem.topla(4, 5, 7);
            islem.topla(4.4, 5.7);
            Console.WriteLine(islem.topla(4, 6));
            Console.WriteLine(islem.topla(4.4, 5.7));
            Console.WriteLine(islem.topla(4, 5, 7));
            islem.topla();

            Console.ReadKey();




           
        }
    }
}
