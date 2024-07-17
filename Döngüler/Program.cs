


using System.Numerics;

namespace Döngüler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Görev1();
            //Görev2();
            //Görev3();
            //Görev4();
            //Görev5();
            //Görev6();
            //Görev7();
            //Görev8();
            //Görev9();
            //Görev10();
            //Görev11();
            //Görev12();
            //Görev13();
            //Görev14();
            //Görev15();
            //Görev16();
            //Görev17();
            MinikBirOyun();
            

        }

        private static void MinikBirOyun()
        {
            int sayi, tutulanSayi, denemeSayisi=0;
            bool kazadiMi = false;
            tutulanSayi = new Random().Next(1, 21);

            Console.WriteLine("Sayı Tahmini Oyunu! Hoşgeldiniz:)");
            Console.WriteLine("10 tane tahmin hakkınız vardır.");

            for (int tahminAdimi = 1; tahminAdimi <= 10; tahminAdimi++)
            {

                denemeSayisi++;
                Console.WriteLine($"{tahminAdimi} . tahmin hakkınızı yazınız:");
                sayi = Convert.ToInt32(Console.ReadLine());
                while (sayi < 1 || sayi > 20)
                {
                    Console.WriteLine("Lütfen 1-20 arasında bir değer giriniz:");
                    sayi = Convert.ToInt32(Console.ReadLine()) ;
                }
                if(sayi==tutulanSayi)
                {
                    kazadiMi=true;
                    Console.WriteLine($"Tebrikler {denemeSayisi} . denemede bildiniz!");
                    break;
                }
                else if(sayi < tutulanSayi)
                {
                    Console.WriteLine("Yukarı :)");
                }
                else
                    Console.WriteLine("Aşağı :)");
            }
            if(!kazadiMi)
                Console.WriteLine($"Kaybettiniz :( Sayı {tutulanSayi} idi.");





        }   




        private static void Görev17()
        {
            //Klavyeden girilen 10 adet sayıdan (int) 3 basamaklı olanları do-while ile ekrana yazdırınız.

            int sayi;
            int sayac = 1;


            do
            {
                Console.WriteLine($"Lütfen {sayac} .  sayıyı giriniz:");
                sayi = Convert.ToInt32(Console.ReadLine());

                if ((sayi >= 100 && sayi <= 999) || (sayi >= -999 && sayi <= -100))
                {
                    Console.WriteLine(sayi);
                }

                sayac++;
            } while (sayac <= 10);






        }

        private static void Görev16()
        {
            //Klavyeden bir kelime istenmelidir. Bu kelime ANK18 olunca program sonlanmalıdır. Bunu do-while ile yazınız.




            string metin;
            do
            {
                Console.WriteLine("Dilediğiniz bir cümle giriniz:");

                metin = Console.ReadLine();

            } while (metin != "ANK18");
        }

        private static void Görev15()
        {
            //Klavyeden girilen 10 adet sayıdan sadece 3'e, sadece 5'e ve ikisinede tam bölünenlerin adetleri.


            int sayi;
            int i = 0;
            int sayac3 = 0;
            int sayac5 = 0;
            int sayac35 = 0;

            while (i < 10)
            {
                Console.WriteLine($"Lütfen {i + 1} . sayıyı giriniz:");
                sayi = Convert.ToInt32(Console.ReadLine());
                i++;

                if (sayi % 3 == 0 && sayi % 5 != 0)
                {
                    sayac3++;
                }
                else if (sayi % 5 == 0 && sayi % 3 != 0)
                {
                    sayac5++;
                }
                else if (sayi % 3 == 0 && sayi % 5 == 0)
                {
                    sayac35++;
                }


            }
            Console.WriteLine($"3'e bölünenler: {sayac3} , 5'e bölünenler: {sayac5} , 3'e ve 5'e bölünenler: {sayac35}");
        }

        private static void Görev14()
        {
            //Klavyeden girilen iki sayının çarpımını * kullanmadan while ve + ile yapınız.

            Console.WriteLine($"Lütfen bir sayı giriniz:");

            uint s1 = Convert.ToUInt32(Console.ReadLine());

            Console.WriteLine($"Lütfen bir sayı giriniz:");//3

            uint s2 = Convert.ToUInt32(Console.ReadLine());   //5

            uint sayac = 1;

            uint sonuc = 0;

            while (sayac <= s1)
            {
                sonuc += s2;
                sayac++;
            }
            Console.WriteLine($"Sonuç: {sonuc}");


        }

        private static void Görev13()
        {
            //Klavyeden girilen iki sayı arasındaki sayıların toplamını while ile.

            Console.WriteLine("Lütfen iki sayı giriniz:");

            int sayi1 = Convert.ToInt32(Console.ReadLine());

            int sayi2 = Convert.ToInt32(Console.ReadLine());

            int toplam = 0;

            if (sayi1 < sayi2)
            {

                while (sayi1 <= sayi2)
                {
                    toplam += sayi1;
                    sayi1 += 1;

                }
                Console.WriteLine($"Sonuç: {toplam}");
            }
            else if (sayi2 < sayi1)
            {

                while (sayi2 <= sayi1)
                {
                    toplam += sayi2;
                    sayi2 += 1;

                }
                Console.WriteLine($"Sonuç: {toplam}");
            }
            else
            {
                Console.WriteLine("Lütfen birbirine eşit olmayan iki sayı giriniz.");
            }

            //Bunu yedekleyerek yapabiliriz. sayıların yerini değiştirmek için.
        }

        private static void Görev12()
        {

            //int toplam = 1;

            //Console.WriteLine("Lütfen bir sayı giriniz:");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //for (int i = 1; i <= sayi; i++)
            //{
            //    toplam = toplam * i;

            //}
            //Console.WriteLine($"Sonuç: {toplam}");

            Console.WriteLine("----------------");

            //int toplam = 1;
            //int i = 1;

            //Console.WriteLine("Lütfen bir sayı giriniz:");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //while (i <= sayi)
            //{
            //    toplam = toplam * i;
            //        i++;
            //}
            //Console.WriteLine($"Sonuç: {toplam}");

            Console.WriteLine("----------------");

            double toplam = 1;
            double i = 1;

            Console.WriteLine("Lütfen bir sayı giriniz:");
            double sayi = Convert.ToDouble(Console.ReadLine());

            do
            {
                toplam = toplam * i;
                i++;
            } while (i <= sayi);
            Console.WriteLine($"Sonuç: {toplam}");

        }

        private static void Görev11()
        {
            int sayi = 1;
            int toplam = 0;

            while (sayi <= 100)
            {
                toplam = toplam + sayi;
                sayi++;
            }

            Console.WriteLine($"Toplam: {toplam}");
        }

        private static void Görev10()
        {
            int sayi;

            Console.WriteLine("Lütfen bir sayı giriniz:");
            sayi = Convert.ToInt32(Console.ReadLine());

            while (sayi != 0)
            {
                Console.WriteLine($" {sayi} Karesi: {sayi * sayi}");

                Console.WriteLine("Lütfen bir sayı giriniz:");
                sayi = Convert.ToInt32(Console.ReadLine());

            }

        }

        private static void Görev9()
        {
            int sayi = 1;

            while (sayi <= 10)
            {
                Console.WriteLine($" 7 * {sayi} = {sayi * 7}");
                sayi++;
            }
        }

        private static void Görev8()
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i} * {j} = {i * j}");
                }

                Console.WriteLine("----------");
            }


        }

        private static void Görev7()
        {
            //0-100 arasında ikiside dahil 10 not girilecek ve bunların en büyüğü ve en küçüğü bulunacak
            //ve notların ortalaması alınacak. Eğer geçersiz not girilirse tekrar sor.

            int not;
            int min = 100;
            int max = 0;
            int toplam = 0;

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Lütfen notunuzu giriniz:");
                not = Convert.ToInt32(Console.ReadLine());

                while (not < 0 || not > 100)
                {
                    Console.WriteLine("Lütfen 0-100 arasında bir değer giriniz");
                    not = Convert.ToInt32(Console.ReadLine());
                }

                if (not < min)
                {
                    min = not;
                }
                if (not > max)
                    max = not;

                toplam += not;

            }
            Console.WriteLine($"Minimum: {min}");
            Console.WriteLine($"Maksimum: {max}");
            Console.WriteLine($"Toplam: {toplam / 10.0}");
            Console.WriteLine($"Toplam: {toplam}");


        }

        private static void Görev6()
        {

            int e;
            int b;

            Console.WriteLine("lütfen bir değer giriniz:");
            e = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lütfen bir değer giriniz");
            b = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= e; i++)
            {
                for (int j = 1; j <= b; j++)
                {
                    if (i == 1 || i == e)
                        Console.Write("*");
                    else

                    if (j == 1 || j == b)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }





        }

        private static void Görev5()
        {
            int en;
            int boy;

            Console.WriteLine("Lütfen bir uzunluk değeri giriniz:");
            en = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lütfen bir uzunluk değeri giriniz:");
            boy = Convert.ToInt32(Console.ReadLine());


            for (int i = 1; i <= en; i++)
            {
                for (int j = 1; j <= boy; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }



        }

        private static void Görev4()
        {

            int toplam = 0;
            int adet = 0;

            for (int i = 1; i < 1000; i++)
            {
                if (i % 5 == 0 && i % 7 != 0)
                {
                    Console.WriteLine(i);
                    toplam += i;
                    adet++;
                }
            }
            Console.WriteLine($"Sayıların toplamı: {toplam}");
            Console.WriteLine($"Sayı adedi: {adet}");
        }

        private static void Görev3()
        {
            int adet = 12;
            int toplam = 0;
            int sayi = 0;

            for (int i = 0; i < adet; i++)
            {
                Console.WriteLine("Lütfen bir sayı giriniz:");
                sayi = Convert.ToInt32(Console.ReadLine());
                toplam = toplam + sayi;
            }

            Console.WriteLine($"Sayıların toplamı: {toplam}");
            Console.WriteLine($"Sayıların ortalaması: {toplam / 12.0}");
        }

        private static void Görev2()
        {
            //0 20 arasındaki sayıları sınırlar dahil çift sayıların toplamını ve tek sayıların toplamını
            //bulan programı yazınız. do- for- do while ile


            int toplamçift = 0;
            int toplamtek = 0;

            for (int i = 0; i <= 20; i++)
            {
                if (i % 2 == 0)
                    toplamçift = toplamçift + i;
                else if (i % 2 == 1)
                    toplamtek = toplamtek + i;
            }

            Console.WriteLine($"Çift sayılar toplamı: {toplamçift} ");
            Console.WriteLine($"Çift sayılar toplamı: {toplamtek} ");


            Console.WriteLine("--------------");

            int toplamçift1 = 0;
            int toplamtek1 = 0;
            int j = 0;

            while (j <= 20)
            {
                if (j % 2 == 0)
                    toplamçift1 = toplamçift1 + j;

                else if (j % 2 == 1)
                    toplamtek1 = toplamtek1 + j;

                j++;
            }

            Console.WriteLine($"Çift sayılar toplamı: {toplamçift1} ");
            Console.WriteLine($"Çift sayılar toplamı: {toplamtek1} ");


            Console.WriteLine("--------------");

            int toplamçift2 = 0;
            int toplamtek2 = 0;
            int k = 0;

            do
            {
                if (k % 2 == 0)
                    toplamçift2 = toplamçift2 + k;

                else if (k % 2 == 1)
                    toplamtek2 = toplamtek2 + k;

                k++;

            } while (k <= 20);

            Console.WriteLine($"Çift sayılar toplamı: {toplamçift2} ");
            Console.WriteLine($"Çift sayılar toplamı: {toplamtek2} ");
        }

        private static void Görev1()
        {
            //Ekrana 10 kere BilgeAdam yazınız.Hem for hem while hem do while ile.

            for (int l = 0; l < 10; l++)
            {
                Console.WriteLine("BilgeAdam");
            }

            Console.WriteLine("-----------");

            int i = 0;

            while (i < 10)
            {
                Console.WriteLine("BilgeAdam");
                i++;
            }

            Console.WriteLine("-----------");

            int j = 0;
            do
            {
                Console.WriteLine("BilgeAdam"); j++;
            } while (j < 10);

        }
        
    }
}
