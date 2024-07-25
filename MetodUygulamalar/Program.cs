using System;
using System.Collections;
using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Text;

namespace MetodUygulamalar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            //basamak();


            //int s1, s2;

            //Console.WriteLine("Lütfen iki sayı giriniz:");

            //s1= Convert.ToInt32(Console.ReadLine());
            //s2= Convert.ToInt32(Console.ReadLine());


            //for (int i = s1; i <= s2; i++)
            //{
            //    if(asalSayi(i))
            //        Console.WriteLine(i + " asaldır");
            //    else
            //        Console.WriteLine(i + " asal değildir");

            //}

            double y = 35e3;
            Console.WriteLine(y); //bunu yeni öğrendimmm

            int x = 10;
            int z = 5;

            Console.WriteLine(x>z);

            Console.WriteLine("------------------");

            Console.WriteLine("Öğrenci numaranızı giriniz:");
            string numara = Console.ReadLine();

            if (OgrenciNo(numara))
            {
                Console.WriteLine("Öğrenci numarası doğru.");
            }
            else
            {
                Console.WriteLine("Öğrenci numarası geçersizdir.");
            }



            Console.WriteLine("------------------");




            Console.WriteLine("Lütfen 5 elemanlı bir dizi giriniz:");

            int[] monoton = new int[5];

            for (int i = 0; i < monoton.Length; i++)
            {
                Console.Write($"{i+1}. ");
                monoton[i] = Convert.ToInt32(Console.ReadLine());
            }

            MonotonDizi(monoton);

            //if(MonotonDizi(monoton))
            //{
            //    Console.WriteLine("Tebrikler doğru bir dizi girdiniz.");
            //}
            //else
            //{
            //    Console.WriteLine("Dizi geçersizdir");
            //}

            Console.WriteLine(MonotonDizi(monoton)? "Monotondur": "Monoton değildir");

        }

        private static bool MonotonDizi(int[] monoton)
        {
            //monoton artan dizi. aynı eleman olamaz. aynı miktarda artarak gidecek.

            for (int i = 0; i < monoton.Length-1; i++)
            {
                if (monoton[i] >= monoton[i + 1])
                {
                    return false;

                }
                                               
            }
            return true;
        }

        private static bool OgrenciNo(string numara)
        {
           
            if (numara.Length != 8)
            {
                return false;
            }
            
            if (!(Convert.ToInt32(numara.Substring(0, 2)) <= 24 && Convert.ToInt32(numara.Substring(0, 2)) >= 20))
            {
                return false;
            }

            if (!(numara[2] == 'L' || (numara[2] == 'Y' || (numara[2] == 'D'))))
            {
                return false;
            }

            if (!(Convert.ToInt32(numara.Substring(3,5)) <= 10000 || Convert.ToInt32(numara.Substring(3, 5)) >=1)) 
            {
                return false;
            }
            
                return true;
            







        }

        private static bool asalSayi(int sayi)
        {
          
            int sayac = 0;

            for (int i = 2; i < sayi; i++)
            {
                if (sayi % i == 0)
                {
                    sayac++;
                    break;
                }

            }
            if (sayac == 0)
            {
                return true;
            }
            else
            {
                return false;
            }



        }

        private static void basamak()
        {
            //Bir tamsayı alan ve tamsayı basamaklarını çözümleyen bir program yazınız.

            string klavyedenAlinanSayi;
            int gercekSayi;
            int us = 0;

            Console.WriteLine("Lütfen ilerlemek için bir sayı giriniz çıkmak için 'exit' yazınız:");

            klavyedenAlinanSayi = Console.ReadLine();

            while (true)
            {
                if (klavyedenAlinanSayi.ToUpper() == "EXIT")
                    return;
                else if (int.TryParse(klavyedenAlinanSayi, out gercekSayi))
                {
                    while (gercekSayi != 0)
                    {
                        Console.WriteLine(gercekSayi % 10 * Math.Pow(10, us));
                        us++;
                        gercekSayi /= 10;
                    }
                }
                else
                {
                    Console.WriteLine("Geçersiz sayı girdiniz:");
                }
                Console.WriteLine("Sayıyı giriniz:");
                klavyedenAlinanSayi = Console.ReadLine();
                us = 0;
            }



        }
    }
}
