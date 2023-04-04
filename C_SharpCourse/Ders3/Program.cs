using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders3
{
    class Program
    {
        static void Main(string[] args)
        {
            Add();

            Console.WriteLine(Add2());

            int number1 = 20;//(out için değer olmasa da olur)
            int number2 = 100;
            Console.WriteLine(Add3(ref number1,number2));
            Console.WriteLine(number1);
            //number1=20 ref olursa number1=30 olur
            //ref  yerine out(number1 in değeri olmasa da olur) da yazılabilir
            Console.WriteLine(Multiply(2,3));
            Console.WriteLine(Multiply(2,3,6));
            Console.WriteLine(Add4(1, 2, 3, 4, 5, 6, 7, 8, 9, 10));
            Console.ReadLine();
        }

        static void Add()
        {
            Console.WriteLine("Added!");
        }

        static int Add2(int number1=20,int number2=10)
        //number1=10 number2 hatalı
        //number1=10 number2=20 olur
        //number1 number2=20 olur
        //mantık şu parametre değerleri çağırılırken verilmezse bu değerler kullanılır
        {
            var result=number1 + number2;
            return result;
        }

        static int Add3(ref int number1,int number2)
        {
            number1 = 30;
            return number1 + number2;

        }
        static int Multiply(int number1, int number2)
        {
            return number1 * number2;

        }
        //method isimleri aynı olabilir (aşırı yüklenme olayı)
        static int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;

        }
        static int Add4(params int[] numbers)
        {
            return numbers.Sum();//Sum topla anlamında 
            //paramsla istediğin kadar parametre gir

        }


    }
}
