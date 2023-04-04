using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
			int sonuc = 1;
			Console.WriteLine("lutfen bir sayi giriniz.....");
			int sayi=int.Parse(Console.ReadLine());
			for(int i=1;i<=sayi;i++)
			{
				sonuc = sonuc *i;
				Console.WriteLine(sonuc);

			}
			





		}
    }
}



