
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders4
{
    class Program
    {
        static void Main(string[] args)
        {
            //tek boyutlu diziler
            //string[] students = new string[3];
            //students[0] = "Engin";
            //students[1] = "Derin";
            //students[2] = "Salih";

            //string[] students2 = { "Engin", "Derin", "Salih" };

            //foreach (var student in students)
            //{
            //    Console.WriteLine(student);
            //}
            //çok boyutlu diziler
            string[,] regions = new string[5, 3]
            {
                {"İstanbul","İzmir","Edirne"},
                {"Ankara","Konya","Kırıkkale"},
                {"Antalya","Adana","Mersin"},
                {"Rize","Trabzon","Ordu"},
                {"İzmir","Muğla","Manisa"}

            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++)//satır
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)//sütun
                {
                    Console.WriteLine(regions[i, j]);
                }
                Console.WriteLine("************");
            }


           
            Console.ReadLine();
        }

    }
}
