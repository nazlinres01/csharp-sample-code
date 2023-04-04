using System;

namespace ConsoleApp2
{
    class Program
    {   
        static void Main(string[] args)
        {
            Console.WriteLine("bir islem seciniz:");
            char islem = char.Parse(Console.ReadLine());
            Console.WriteLine("2 tane sayi giriniz:");
            Console.Write("sayi1:");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.Write("sayi2:");
            int sayi2 = int.Parse(Console.ReadLine());
           
            switch (islem)
            {

               case '+' : 
                    int toplam=sayi1 + sayi2;
                    Console.Write("toplam:{0}",toplam);
                    break;

                case '-':
                    int cıkarım = sayi1 - sayi2;
                    Console.Write("cıkarım:{0}", cıkarım);
                    break;

                case '*':
                    int carpım = sayi1 * sayi2;
                    Console.Write("carpım:{0}", carpım);
                    break;

                case '/':
                    int bolum = sayi1/sayi2;
                    Console.Write("bolum:{0}", bolum);
                    int kalan = sayi1 % sayi2;
                    Console.Write("kalan:{0}", kalan);
                    break;

            }














           


        }
    }
}
