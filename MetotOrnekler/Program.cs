


using System.Security.Cryptography;
using System.Text;

namespace MetotOrnekler
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //BreakReturnFark();
            //Substring();
            //StartsWithEndsWith();
            //StringBuilder();
            //StringSortCopyResizeClear();
            //StringMaxMinSum();
            //MetotTanımlama();
            MetotÖrnekler();


        }

        private static void MetotÖrnekler()
        {
            //BilgeAdam();
            //2)Çarpma ve toplama işlemlerini iki ayrı metodda yapan program;

            Console.WriteLine(İkiSayiToplam(10, 20));

            Console.WriteLine(İkiSayiCarpim(10, 20));

            //3)Klavyeden alınan sayının karesini al KareAl metodunda alıp ekrana yazdır.

            //KareAl();

            //Birden100e yaz

            // BirYuz();

            //birden bir yere kadar yazan 

            // BirdenBirYere(31);

            //toplamın küpünü almak

            // Console.WriteLine(SayiKüpü());

            //tek mi çift mi?

            TekCift();

            //çarpma metodunu toplamanın içinde çağırmak.

            //Console.WriteLine(Toplama(10, 20));

            BüyükSayi();
        }

        private static void BüyükSayi()
        {
            int s1, s2;
            Console.WriteLine("Lütfen iki sayı giriniz:");

            s1 = Convert.ToInt32(Console.ReadLine()); 
            s2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Math.Max(s1, s2));
            Console.WriteLine(Math.Min(s1, s2));



        }

        private static int Carpma(int x, int y)
        {
            return x * y;
        }

        private static int Toplama(int x, int y)
        {
            
            Console.WriteLine(Carpma(10, 20));
            return x + y;

        }

        private static void TekCift()
        {
            int sayi;
            Console.WriteLine("Lütfen bir sayı giriniz:");

            sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi%2== 0)
            {
                Console.WriteLine("Girdiğiniz sayı çifttir.");
            }
            else
            {
                Console.WriteLine("Girdiğiniz sayi tektir.");
            }
        }

        private static double SayiKüpü()
        {
            double s1, s2;
            Console.WriteLine("Lütfen iki sayı giriniz:");

            s1 = Convert.ToInt32(Console.ReadLine());   
            s2 = Convert.ToInt32(Console.ReadLine());

            double toplam = s1 + s2;
            double sonuc = (Math.Pow(toplam, 3));

            return sonuc;


        }

        private static void BirdenBirYere(int x)
        {
            for (int i = 1; i < x; i++)
            {
                Console.WriteLine(i);

            }
        }

        private static void BirYuz()
        {
            

            for (int i = 1; i < 101; i++)
            {
                Console.WriteLine(i);
            }
        }

        private static void KareAl()
        {
            Console.WriteLine("Lütfen karesini almak istediğiniz sayıyı giriniz:");
            
            int sayi = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Math.Pow(sayi,2));
        }

        private static int İkiSayiCarpim(int x, int y)
        {
            return x * y;
        }

        private static int İkiSayiToplam(int x, int y)
        {
            
            return x + y;
        }

        private static void BilgeAdam()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("BilgeAdam");
            }
        }

        private static void MetotTanımlama()
        {
            //metod yazarken metod adı, alacağı parametreler ve return değerini ayarlıyoruz önce.

            //dönüstipi MetodAdi (parametre/ler)
            //{ 
                 //bunlar yapılması gerekenler
            //}

            //dönüş tipine void yazarsam => bir dönüş tipi yok. ekrana sadece yazı yazdıran bir metodlarda falan kullanılır.
            //dönüş tipine int, float vs yazdığımda bir dönüş tipi var.

        }

        private static void StringMaxMinSum()
        {
            int[] sayilar = { 55, 95, 105, 115, -5, 201, -66 };

            Console.WriteLine(sayilar.Sum());
            Console.WriteLine(sayilar.Average());
            Console.WriteLine(sayilar.Max());
            Console.WriteLine(sayilar.Min());
            Console.WriteLine(sayilar.First());
            Console.WriteLine(sayilar.Last());
            Console.WriteLine(sayilar[sayilar.Length-1]); //buda sonuncusu demek.
            Console.WriteLine(sayilar.GetValue(1)); //buda birincinin değeri demek
            Console.WriteLine(sayilar[1]); //buda

        }

        private static void StringSortCopyResizeClear()
        {

            int[] sayilar = { 55, 95, 105, 115, -5, 201, -66 };

            Array.Sort(sayilar);
            Array.Reverse(sayilar);

            //foreach (var item in sayilar)
            //{
            //    Console.WriteLine(item);
            //}

            int[] kopya = new int[7];

            Array.Copy(sayilar, 2, kopya, 3, 2);

            Array.Resize(ref kopya, 20); //orijinal diziden daha küçük bir resize yaparsak geri kalan elemanları siler.

            Array.Clear(kopya);


            
        }

        private static void StringBuilder()
        {

            //string metotlar ve builder metotlar farklıymış onlara bak <3

            StringBuilder sb = new StringBuilder();

            sb.Append("abc");
            Console.WriteLine(sb);

            sb.Remove(0, 3);
            sb.Append("def");
            Console.WriteLine(sb);

           
        }

        private static void StartsWithEndsWith()
        {
            Console.WriteLine("Kelime yazınız");

            string kelime = Console.ReadLine();

            if (kelime.EndsWith('y'))
            {
                //Console.WriteLine($"{kelime.Substring(0, kelime.Length -1)}ies");
                Console.WriteLine($"{kelime.Substring(0,kelime.LastIndexOf('y'))}ies");
            }
            else if (kelime.EndsWith('s') || kelime.EndsWith('o'))
            {
                Console.WriteLine($"{kelime}es");
            }
            else
            {
                Console.WriteLine($"{kelime}s");
            }

            Console.WriteLine(kelime.Replace("a","b"));

        }

        private static void Substring()
        {
            string kelime = "Merhab.a";

            Console.WriteLine(kelime.Substring(4)); //aba yazacak.

            Console.WriteLine(kelime.Substring(4, 2)); //ab yazacak.

            Console.WriteLine(kelime.Substring(kelime.IndexOf(".") , 2)); //.a yazacak.

        }

        private static void BreakReturnFark()
        {
            #region Break-Return Fark

            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine(i);
                if (i == 4)
                    break; //bu for u tamamen keser.
            }

            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine(i);
                if (i == 4)
                    continue;  //4 ü bir kere yazar ve devam eder. continue gördüğü yerde orayı atlar ordan devam eder.
            }



            #endregion
        }
    }
}
