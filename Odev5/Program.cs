

namespace Odev5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Soru1();
            //Soru2();
            //Soru3();
            Soru4();
            
           
               
            
        }

        private static void Soru4()
        {
            //Armstrong sayıları

            int sayi = 0, bs = 0; 
            int yedek;
            bool hata = false;
            double toplam = 0;


            do
            {
                hata = false;
                try
                {
                    Console.WriteLine("Lütfen bir sayı giriniz:");
                    sayi = Convert.ToInt32(Console.ReadLine()); 
                }
                catch (Exception ex)
                {
                    hata = true;
                    Console.WriteLine($"Hata! {ex.Message}");
                    
                }

            } while (sayi<0 || hata);


            for (int i = 0; i <= sayi; i++) 
            {
                bs = 0;
                toplam= 0;  
                yedek = i;
                while (yedek != 0)
                {
                    bs++;
                    yedek /= 10;
                }
                yedek = i;
                while (yedek != 0)
                {
                    toplam += Math.Pow(yedek%10, bs);
                    yedek /= 10;
                }

                if(toplam == i)
                    Console.WriteLine(i);

            }


            
            
                
            
            

            


        }

        private static void Soru3()
        {
            //bir sayının karekökünü bulmak.


            Console.WriteLine("Lütfen bir sayı giriniz:");
            double sayi = Convert.ToDouble(Console.ReadLine());

            double sayiAdayi = 0.0001;
            double artisMiktari = 0.0001;
            double fark = Math.Abs((sayiAdayi * sayiAdayi) - sayi);

            while(fark>0.001)
            {
                sayiAdayi += artisMiktari;
                fark = Math.Abs((sayiAdayi * sayiAdayi) - sayi);
            }

            Console.WriteLine($"Sayının yaklaşık karekökü: {sayiAdayi}");
            Console.WriteLine($"Sayının karekökü: {Math.Sqrt(sayi)}");
        }

        private static void Soru2()
        {
            //Bir dart turnuvasında 5 oyuncu vardır. Oynanacak turlarda klavyeden seçilen bir oyuncu için rastgele bir rakip seçen program.
            //Oyuncular A,C,H,R,S


            Random rastgele = new Random();
            char oyuncu;
            int rastgeleIndis;
            char[] oyuncular = new char[5];

            oyuncular[0] = 'A';
            oyuncular[1] = 'C';
            oyuncular[2] = 'H';
            oyuncular[3] = 'R';
            oyuncular[4] = 'S';

            Console.WriteLine("Lütfen bir oyuncu kodu giriniz:");

            oyuncu = Convert.ToChar(Console.ReadLine());

            while (!oyuncular.Contains(oyuncu))
            {
                Console.WriteLine("Geçersiz karakter girdiniz.");
                oyuncu = Convert.ToChar(Console.ReadLine());
            }

            rastgeleIndis = rastgele.Next(0, 5);

            while (oyuncular[rastgeleIndis] == oyuncu)
            {
                rastgeleIndis = rastgele.Next(0, 5);
            }

            Console.WriteLine($"Rakibiniz: {oyuncular[rastgeleIndis]}");





        }

        private static void Soru1()
        {
            //Soru1) Klavyeden girilen bir kelimenin sesli harf içerip içermediğini kontrol eden programı yazınız.

            string kelime;

            Console.WriteLine("Lütfen bir kelime giriniz:");
            kelime = Console.ReadLine();

            if (kelime.Contains('a') || kelime.Contains('A') || kelime.Contains('e') || kelime.Contains('E') || kelime.Contains('I'))
            {
                Console.WriteLine("Kelime Sesli Harf İçeriyor");
            }
            else if (kelime.Contains('i') || kelime.Contains('O') || kelime.Contains('o') || kelime.Contains('U') || kelime.Contains('u'))
            {
                Console.WriteLine("Kelime Sesli Harf İçeriyor");
            }
            else
            {
                Console.WriteLine("Kelime Sesli Harf İçermiyor");
            }


            Console.WriteLine("------------");

            bool iceriyorMu = false;

            char[] sesliler = { 'a', 'e', 'i', 'ı', 'o', 'ö', 'ü', 'u' };

            foreach (var harf in sesliler)
            {
                if (kelime.Contains(harf)) // if(kelime.IndexOf(harf) != -1) bunu da kullanabiliriz.
                {
                    Console.WriteLine("Sesli harf içeriyor.");
                    iceriyorMu = true;
                    break;
                }

            }
            if (!iceriyorMu)
            {
                Console.WriteLine("Sesli harf içermiyor");
            }


        }


    }
}
