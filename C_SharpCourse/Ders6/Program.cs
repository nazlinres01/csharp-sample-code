using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders6
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = "Ankara";
            //Console.WriteLine(city[0]);
            //for (int i = 0; i < city.Length; i++)
            //{
            //    Console.WriteLine(city[i]);
            //}

            foreach (var item in city)
            {
                Console.WriteLine(item);
            }

            string city2 = "İstanbul";
            string result = city + city2;
            Console.WriteLine(result);
            Console.WriteLine(String.Format("{0} {1}", city, city2));

            string sentence = "My name is Nazlı Nur Esmeray";
            Console.WriteLine(sentence.Length);//karakter sayısı
            Console.WriteLine(sentence.Clone());
            //sentence = "My name is Mercan Yıldız";
            //Clone(),sentence içeriğini değiştirsem bile önceki içerik klonlanmış oluyor
            Console.WriteLine(sentence.EndsWith("y"));//cümle sonu y ile bitiyor mu false or true
            Console.WriteLine(sentence.StartsWith("M"));
            Console.WriteLine(sentence.IndexOf("name"));//n nin indeksi
            //bulamıdığında o içeriği -1 ekrana çıkar
            Console.WriteLine(sentence.LastIndexOf("name"));
            //aramaya sondan başlar
            Console.WriteLine(sentence.Insert(0,"Hello, "));
            Console.WriteLine(sentence.Substring(3));//"My " kısmı almadı cümle parçalandı
            Console.WriteLine(sentence.Substring(3, 4));//"name" kısmını alır 4 karakter alır
            //Console.WriteLine(sentence.ToLower());//cümleyi küçük harf yapar
            //Console.WriteLine(sentence.ToUpper());//cümleyi büyük harf yapar
            //Console.WriteLine(sentence.Replace(" ", "-"));//değiştirme işlemi
            //Console.WriteLine(sentence.Remove(4));//"My n" alır gerisi atar  
            Console.WriteLine(sentence.Remove(2,5));//My dan sonra 5 karakteri atar

            Console.ReadLine();
        }
    }
}
