using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Islem
    {
        public int sonuc = 0;
        public double sonuc2 = 0;
        public int sonuc3 = 0;
        public int topla(int x, int y)
        {
           Console.WriteLine("int x+int y");
            sonuc = x + y;
            return sonuc;
        }
        public double topla(double x, double y)
        {
            Console.WriteLine("double x+double y");
            sonuc2 = x + y;
            return sonuc2;
        }

        public double topla(int x, int y,int z)
        {
            Console.WriteLine("int x+int y+int z");
            sonuc3 = x + y + z;
            return sonuc3;
        }

        public int topla(int[] x)
        {
            int sum = 0;
            for (int i = 0; i < x.Length;i++)
            {
                sum = sum + x[i];
            }
            return sum;
        }
       





    }
}
