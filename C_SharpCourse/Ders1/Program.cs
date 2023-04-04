using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders1
{
    class Program
    {
        static void Main(string[] args)
        {
            //byte 8 bitlik, short 16 bitlik , int 32 bitlik , long 64 bitlik yer kaplar
            //byte 0-255 arası değer alabilir
            //bool (boolean) mantıksal veri tipi True,False 
            //double 64 bitlik yer tutar, ondalıklı sayılar için kullanılır
            //double-decimal(virgülden sonra daha çok basamak tutar)
            decimal number2 = 10.4M;//m 
            decimal number3 = 10;
            char character = 'A';
            //variable (var) değişkeni tanımlarken kullanılabilir
            string sehir = "Kars";
            Console.WriteLine("Hello World!");
            int number1 = 1000000000;
            Console.WriteLine("Number1 is {0}",number1);
            Console.WriteLine("Character is : {0}", character);
            Console.WriteLine("Character is : {0}", (int)character);//A değerinin sayısal karşılığı
            Console.WriteLine(Days.Friday);
            Console.WriteLine((int)Days.Friday);
            Console.ReadLine();

        }
        enum Days
        {
            Monday=10,Tuesday=20,Wednesday,Thursday,Friday,Saturday,Sunday
        }

    }
}
