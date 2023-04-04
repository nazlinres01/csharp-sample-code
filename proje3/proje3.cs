using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {

            double basarıNotu;

            string[] bilgiler = File.ReadAllLines(@"C:\Okul\Öğrenci_Bilgileri.txt");

            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine(bilgiler[i]);
            }
            basarıNotu = Convert.ToInt32(bilgiler[3]) * 24.75 / 100 + Convert.ToInt32(bilgiler[4]) * 5.5 / 100 + Convert.ToInt32(bilgiler[5]) * 5.5 / 100 + Convert.ToInt32(bilgiler[6]) * 5.5 / 100
                        + Convert.ToInt32(bilgiler[7]) * 13.75 / 100 + Convert.ToInt32(bilgiler[8]) * 45.00 / 100;

            string basarı = Convert.ToString(basarıNotu);
            Console.Write("Başarı Notu:{0}", basarı);
            Console.WriteLine();
            harfNotu();

            Console.WriteLine();
            for (int i = 10; i < 19; i++)
            {
                Console.WriteLine(bilgiler[i]);
            }
            basarıNotu = Convert.ToInt32(bilgiler[13]) * 24.75 / 100 + Convert.ToInt32(bilgiler[14]) * 5.5 / 100 + Convert.ToInt32(bilgiler[15]) * 5.5 / 100 + Convert.ToInt32(bilgiler[16]) * 5.5 / 100
                        + Convert.ToInt32(bilgiler[17]) * 13.75 / 100 + Convert.ToInt32(bilgiler[18]) * 45.00 / 100;

            string basarı2 = Convert.ToString(basarıNotu);
            Console.Write("Başarı Notu:{0}", basarı2);
            Console.WriteLine();
            harfNotu();


            Console.WriteLine();
            for (int i = 20; i < 29; i++)
            {
                Console.WriteLine(bilgiler[i]);
            }

            basarıNotu = Convert.ToInt32(bilgiler[23]) * 24.75 / 100 + Convert.ToInt32(bilgiler[24]) * 5.5 / 100 + Convert.ToInt32(bilgiler[25]) * 5.5 / 100 + Convert.ToInt32(bilgiler[26]) * 5.5 / 100
                      + Convert.ToInt32(bilgiler[27]) * 13.75 / 100 + Convert.ToInt32(bilgiler[28]) * 45.00 / 100;
            string basarı3 = Convert.ToString(basarıNotu);
            Console.Write("Başarı Notu:{0}", basarı3);
            Console.WriteLine();
            harfNotu();

            Console.WriteLine();
            for (int i = 30; i < 39; i++)
            {
                Console.WriteLine(bilgiler[i]);
            }
            basarıNotu = Convert.ToInt32(bilgiler[33]) * 24.75 / 100 + Convert.ToInt32(bilgiler[34]) * 5.5 / 100 + Convert.ToInt32(bilgiler[35]) * 5.5 / 100 + Convert.ToInt32(bilgiler[36]) * 5.5 / 100
                     + Convert.ToInt32(bilgiler[37]) * 13.75 / 100 + Convert.ToInt32(bilgiler[38]) * 45.00 / 100;
            string basarı4 = Convert.ToString(basarıNotu);
            Console.Write("Başarı Notu:{0}", basarı4);
            Console.WriteLine();
            harfNotu();

            Console.WriteLine();
            for (int i = 40; i < 49; i++)
            {
                Console.WriteLine(bilgiler[i]);
            }
            basarıNotu = Convert.ToInt32(bilgiler[43]) * 24.75 / 100 + Convert.ToInt32(bilgiler[44]) * 5.5 / 100 + Convert.ToInt32(bilgiler[45]) * 5.5 / 100 + Convert.ToInt32(bilgiler[46]) * 5.5 / 100
                     + Convert.ToInt32(bilgiler[47]) * 13.75 / 100 + Convert.ToInt32(bilgiler[48]) * 45.00 / 100;
            string basarı5 = Convert.ToString(basarıNotu);
            Console.Write("Başarı Notu:{0}", basarı5);
            Console.WriteLine();
            harfNotu();

            Console.WriteLine();
            for (int i = 50; i < 59; i++)
            {
                Console.WriteLine(bilgiler[i]);
            }
            basarıNotu = Convert.ToInt32(bilgiler[53]) * 24.75 / 100 + Convert.ToInt32(bilgiler[54]) * 5.5 / 100 + Convert.ToInt32(bilgiler[55]) * 5.5 / 100 + Convert.ToInt32(bilgiler[56]) * 5.5 / 100
                     + Convert.ToInt32(bilgiler[57]) * 13.75 / 100 + Convert.ToInt32(bilgiler[58]) * 45.00 / 100;
            string basarı6 = Convert.ToString(basarıNotu);
            Console.Write("Başarı Notu:{0}", basarı6);
            Console.WriteLine();
            harfNotu();

            Console.WriteLine();
            for (int i = 60; i < 69; i++)
            {
                Console.WriteLine(bilgiler[i]);
            }
            basarıNotu = Convert.ToInt32(bilgiler[63]) * 24.75 / 100 + Convert.ToInt32(bilgiler[64]) * 5.5 / 100 + Convert.ToInt32(bilgiler[65]) * 5.5 / 100 + Convert.ToInt32(bilgiler[66]) * 5.5 / 100
                     + Convert.ToInt32(bilgiler[67]) * 13.75 / 100 + Convert.ToInt32(bilgiler[68]) * 45.00 / 100;
            string basarı7 = Convert.ToString(basarıNotu);
            Console.Write("Başarı Notu:{0}", basarı7);
            Console.WriteLine();
            harfNotu();

            Console.WriteLine();
            for (int i = 70; i < 79; i++)
            {
                Console.WriteLine(bilgiler[i]);
            }
            basarıNotu = Convert.ToInt32(bilgiler[73]) * 24.75 / 100 + Convert.ToInt32(bilgiler[74]) * 5.5 / 100 + Convert.ToInt32(bilgiler[75]) * 5.5 / 100 + Convert.ToInt32(bilgiler[76]) * 5.5 / 100
                     + Convert.ToInt32(bilgiler[77]) * 13.75 / 100 + Convert.ToInt32(bilgiler[78]) * 45.00 / 100;
            string basarı8 = Convert.ToString(basarıNotu);
            Console.Write("Başarı Notu:{0}", basarı8);
            Console.WriteLine();
            harfNotu();

            Console.WriteLine();
            for (int i = 80; i < 89; i++)
            {
                Console.WriteLine(bilgiler[i]);
            }
            basarıNotu = Convert.ToInt32(bilgiler[83]) * 24.75 / 100 + Convert.ToInt32(bilgiler[84]) * 5.5 / 100 + Convert.ToInt32(bilgiler[85]) * 5.5 / 100 + Convert.ToInt32(bilgiler[86]) * 5.5 / 100
                     + Convert.ToInt32(bilgiler[87]) * 13.75 / 100 + Convert.ToInt32(bilgiler[88]) * 45.00 / 100;
            string basarı9 = Convert.ToString(basarıNotu);
            Console.Write("Başarı Notu:{0}", basarı9);
            Console.WriteLine();
            harfNotu();

            Console.WriteLine();
            for (int i = 90; i < 99; i++)
            {
                Console.WriteLine(bilgiler[i]);
            }
            basarıNotu = Convert.ToInt32(bilgiler[93]) * 24.75 / 100 + Convert.ToInt32(bilgiler[94]) * 5.5 / 100 + Convert.ToInt32(bilgiler[95]) * 5.5 / 100 + Convert.ToInt32(bilgiler[96]) * 5.5 / 100
                     + Convert.ToInt32(bilgiler[97]) * 13.75 / 100 + Convert.ToInt32(bilgiler[98]) * 45.00 / 100;
            string basarı10 = Convert.ToString(basarıNotu);
            Console.Write("Başarı Notu:{0}", basarı10);
            Console.WriteLine();
            harfNotu();

            Console.WriteLine();
            for (int i = 100; i < 109; i++)
            {
                Console.WriteLine(bilgiler[i]);
            }

            basarıNotu = Convert.ToInt32(bilgiler[103]) * 24.75 / 100 + Convert.ToInt32(bilgiler[104]) * 5.5 / 100 + Convert.ToInt32(bilgiler[105]) * 5.5 / 100 + Convert.ToInt32(bilgiler[106]) * 5.5 / 100
                         + Convert.ToInt32(bilgiler[107]) * 13.75 / 100 + Convert.ToInt32(bilgiler[108]) * 45.00 / 100;
            string basarı11 = Convert.ToString(basarıNotu);
            Console.Write("Başarı Notu:{0}", basarı11);
            Console.WriteLine();
            harfNotu();

            Console.WriteLine();
            for (int i = 110; i < 119; i++)
            {
                Console.WriteLine(bilgiler[i]);
            }
            basarıNotu = Convert.ToInt32(bilgiler[113]) * 24.75 / 100 + Convert.ToInt32(bilgiler[114]) * 5.5 / 100 + Convert.ToInt32(bilgiler[115]) * 5.5 / 100 + Convert.ToInt32(bilgiler[116]) * 5.5 / 100
                        + Convert.ToInt32(bilgiler[117]) * 13.75 / 100 + Convert.ToInt32(bilgiler[118]) * 45.00 / 100;
            string basarı12 = Convert.ToString(basarıNotu);
            Console.Write("Başarı Notu:{0}", basarı12);
            Console.WriteLine();
            harfNotu();

            Console.WriteLine();
            for (int i = 120; i < 129; i++)
            {
                Console.WriteLine(bilgiler[i]);
            }

            basarıNotu = Convert.ToInt32(bilgiler[123]) * 24.75 / 100 + Convert.ToInt32(bilgiler[124]) * 5.5 / 100 + Convert.ToInt32(bilgiler[125]) * 5.5 / 100 + Convert.ToInt32(bilgiler[126]) * 5.5 / 100
                      + Convert.ToInt32(bilgiler[127]) * 13.75 / 100 + Convert.ToInt32(bilgiler[128]) * 45.00 / 100;
            string basarı13 = Convert.ToString(basarıNotu);
            Console.Write("Başarı Notu:{0}", basarı13);
            Console.WriteLine();
            harfNotu();

            Console.WriteLine();
            for (int i = 130; i < 139; i++)
            {
                Console.WriteLine(bilgiler[i]);
            }
            basarıNotu = Convert.ToInt32(bilgiler[133]) * 24.75 / 100 + Convert.ToInt32(bilgiler[134]) * 5.5 / 100 + Convert.ToInt32(bilgiler[135]) * 5.5 / 100 + Convert.ToInt32(bilgiler[136]) * 5.5 / 100
                     + Convert.ToInt32(bilgiler[137]) * 13.75 / 100 + Convert.ToInt32(bilgiler[138]) * 45.00 / 100;
            string basarı14 = Convert.ToString(basarıNotu);
            Console.Write("Başarı Notu:{0}", basarı14);
            Console.WriteLine();
            harfNotu();

            Console.WriteLine();
            for (int i = 140; i < 149; i++)
            {
                Console.WriteLine(bilgiler[i]);
            }
            basarıNotu = Convert.ToInt32(bilgiler[143]) * 24.75 / 100 + Convert.ToInt32(bilgiler[144]) * 5.5 / 100 + Convert.ToInt32(bilgiler[145]) * 5.5 / 100 + Convert.ToInt32(bilgiler[146]) * 5.5 / 100
                     + Convert.ToInt32(bilgiler[147]) * 13.75 / 100 + Convert.ToInt32(bilgiler[148]) * 45.00 / 100;
            string basarı15 = Convert.ToString(basarıNotu);
            Console.Write("Başarı Notu:{0}", basarı15);
            Console.WriteLine();
            harfNotu();

            Console.WriteLine();
            for (int i = 150; i < 159; i++)
            {
                Console.WriteLine(bilgiler[i]);
            }
            basarıNotu = Convert.ToInt32(bilgiler[153]) * 24.75 / 100 + Convert.ToInt32(bilgiler[154]) * 5.5 / 100 + Convert.ToInt32(bilgiler[155]) * 5.5 / 100 + Convert.ToInt32(bilgiler[156]) * 5.5 / 100
                     + Convert.ToInt32(bilgiler[157]) * 13.75 / 100 + Convert.ToInt32(bilgiler[158]) * 45.00 / 100;
            string basarı16 = Convert.ToString(basarıNotu);
            Console.Write("Başarı Notu:{0}", basarı16);
            Console.WriteLine();
            harfNotu();

            Console.WriteLine();
            for (int i = 160; i < 169; i++)
            {
                Console.WriteLine(bilgiler[i]);
            }
            basarıNotu = Convert.ToInt32(bilgiler[163]) * 24.75 / 100 + Convert.ToInt32(bilgiler[164]) * 5.5 / 100 + Convert.ToInt32(bilgiler[165]) * 5.5 / 100 + Convert.ToInt32(bilgiler[166]) * 5.5 / 100
                     + Convert.ToInt32(bilgiler[167]) * 13.75 / 100 + Convert.ToInt32(bilgiler[168]) * 45.00 / 100;
            string basarı17 = Convert.ToString(basarıNotu);
            Console.Write("Başarı Notu:{0}", basarı17);
            Console.WriteLine();
            harfNotu();


            Console.WriteLine();
            for (int i = 170; i < 179; i++)
            {
                Console.WriteLine(bilgiler[i]);
            }

            basarıNotu = Convert.ToInt32(bilgiler[173]) * 24.75 / 100 + Convert.ToInt32(bilgiler[174]) * 5.5 / 100 + Convert.ToInt32(bilgiler[175]) * 5.5 / 100 + Convert.ToInt32(bilgiler[176]) * 5.5 / 100
                 + Convert.ToInt32(bilgiler[177]) * 13.75 / 100 + Convert.ToInt32(bilgiler[178]) * 45.00 / 100;
            string basarı18 = Convert.ToString(basarıNotu);
            Console.Write("Başarı Notu:{0}", basarı18);
            Console.WriteLine();
            harfNotu();

            Console.WriteLine();
            for (int i = 180; i < 189; i++)
            {
                Console.WriteLine(bilgiler[i]);
            }
            basarıNotu = Convert.ToInt32(bilgiler[183]) * 24.75 / 100 + Convert.ToInt32(bilgiler[184]) * 5.5 / 100 + Convert.ToInt32(bilgiler[195]) * 5.5 / 100 + Convert.ToInt32(bilgiler[196]) * 5.5 / 100
                     + Convert.ToInt32(bilgiler[197]) * 13.75 / 100 + Convert.ToInt32(bilgiler[198]) * 45.00 / 100;
            string basarı19 = Convert.ToString(basarıNotu);
            Console.Write("Başarı Notu:{0}", basarı19);
            Console.WriteLine();
            harfNotu();

            Console.WriteLine();
            for (int i = 190; i < 199; i++)
            {
                Console.WriteLine(bilgiler[i]);
            }
            basarıNotu = Convert.ToInt32(bilgiler[193]) * 24.75 / 100 + Convert.ToInt32(bilgiler[194]) * 5.5 / 100 + Convert.ToInt32(bilgiler[195]) * 5.5 / 100 + Convert.ToInt32(bilgiler[196]) * 5.5 / 100
                     + Convert.ToInt32(bilgiler[197]) * 13.75 / 100 + Convert.ToInt32(bilgiler[198]) * 45.00 / 100;
            string basarı20 = Convert.ToString(basarıNotu);
            Console.Write("Başarı Notu:{0}", basarı20);
            Console.WriteLine();
            harfNotu();
            void harfNotu()
            {
                int AA_sayısı=0;
                int BA_sayısı=0;
                int BB_sayısı=0;
                int CB_sayısı=0;
                int CC_sayısı=0;
                int DC_sayısı=0;
                int DD_sayısı=0;
                int FD_sayısı=0;
                int FF_sayısı=0;

                if (basarıNotu <= 100.00 && basarıNotu >= 90.00)
                {
                    Console.Write("Harf Notu AA'dır.");
                }
                else if (basarıNotu <= 89.99 && basarıNotu >= 85.00)
                {
                    BA_sayısı = BA_sayısı + 1;
                    
                    Console.Write("Harf Notu BA'dır.");
                }
                else if (basarıNotu <= 84.99 && basarıNotu >= 80.00)
                {
                    BB_sayısı = BB_sayısı + 1;
                    
                    Console.Write("Harf Notu BB'dir.");
                }
                else if (basarıNotu <= 79.99 && basarıNotu >= 75.00)
                {
                    CB_sayısı = CB_sayısı + 1;
                    
                    Console.Write("Harf Notu CB'dir.");
                }
                else if (basarıNotu <= 74.99 && basarıNotu >= 65.00)
                {
                    CC_sayısı=CC_sayısı+1;
                   

                    Console.Write("Harf Notu CC'dir.");
                }
                else if (basarıNotu <= 64.99 && basarıNotu >= 58.00)
                {
                    DC_sayısı = DC_sayısı + 1;

                    Console.Write("Harf Notu DC'dir.");
                }
                else if (basarıNotu <= 57.99 && basarıNotu >= 50.00)
                {
                    DD_sayısı = DD_sayısı + 1;

                    Console.Write("Harf Notu DD'dir.");
                }
                else if (basarıNotu <= 49.99 && basarıNotu >= 40.00)
                {
                    FD_sayısı = FD_sayısı + 1;

                    Console.Write("Harf Notu FD'dir.");
                }
                else if (basarıNotu <= 39.99 && basarıNotu >= 0)
                {
                    FF_sayısı = FF_sayısı + 1;

                   Console.Write("Harf Notu FF'dir.");
                }
                 

            }
            Console.WriteLine();



            int AA_sayısı = 0;
            int BA_sayısı = 0;
            int BB_sayısı = 0;
            int CB_sayısı = 0;
            int CC_sayısı = 0;
            int DC_sayısı = 0;
            int DD_sayısı = 0;
            int FD_sayısı = 0;
            int FF_sayısı = 0;

            if (basarıNotu <= 100.00 && basarıNotu >= 90.00)
            {
                for (int i = 0; i < AA_sayısı; i++) 
                {

                }
                
                
            }
            else if (basarıNotu <= 89.99 && basarıNotu >= 85.00)
            {
                BA_sayısı = BA_sayısı + 1;

                
            }
            else if (basarıNotu <= 84.99 && basarıNotu >= 80.00)
            {
                BB_sayısı = BB_sayısı + 1;

                
            }
            else if (basarıNotu <= 79.99 && basarıNotu >= 75.00)
            {
                CB_sayısı = CB_sayısı + 1;

               
            }
            else if (basarıNotu <= 74.99 && basarıNotu >= 65.00)
            {
                CC_sayısı = CC_sayısı + 1;


                
            }
            else if (basarıNotu <= 64.99 && basarıNotu >= 58.00)
            {
                DC_sayısı = DC_sayısı + 1;

                
            }
            else if (basarıNotu <= 57.99 && basarıNotu >= 50.00)
            {
                DD_sayısı = DD_sayısı + 1;

              
            }
            else if (basarıNotu <= 49.99 && basarıNotu >= 40.00)
            {
                FD_sayısı = FD_sayısı + 1;

               
            }
            else if (basarıNotu <= 39.99 && basarıNotu >= 0)
            {
                FF_sayısı = FF_sayısı + 1;

               
            }
            Console.Write(AA_sayısı);





        }

    }
}
