using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq.Expressions;

namespace Ödev3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Soru1();
            //Soru2();
            //Soru3();
            //Soru4();
            //Soru5();
            //Soru6();
            //Soru7();
            //Soru8();
            Soru9();
            //Soru10();

        }

        private static void Soru10()
        {
            //Soru10)Madeni bir para havaya atılarak tura geldiği durumlar tutulmak isteniyor.
            //Bu havaya atma işlemi belli seferler ile yapılacaktır. Buna deney sayısı denmektedir.
            //Deney sayısı arttıkça, tura geldiği durumların toplam deney sayısına oranının
            //0.5’e yaklaştığını gösteriniz.  
            //İPUCU1: Önce az atış sayısı ile tura gelmesini yapınız sonra atış sayısını arttırınız. 
            //İPUCU2: Yazı gelmesine 1, tura gelmesine 0 diyelim.
            //O zaman [0,1] aralığında rastgele sayılar oluşturarak,
            //0’ların sayısını toplam deney sayısına oranlarsak istediğimiz sonucu buluruz. 

            int yazi = 0;
            int yaziSayac = 0;
            int tura = 1;
            int turaSayac = 0;
            Random random = new Random();

            Console.WriteLine("Para 10 kez atılacaktır.");

            for (int i = 0; i < 10; i++)
            {
                int sonuc = random.Next(0, 2);

                if (sonuc == 0)
                {
                    //Console.WriteLine($"Sonuç yazı geldi:");
                    yaziSayac++;
                }
                else if (sonuc ==1)
                {
                    //Console.WriteLine($"Sonuç tura geldi:");
                    turaSayac++;
                }
            }

            Console.WriteLine($"Toplam yazı : {yaziSayac} , toplam tura : {turaSayac} ");
            Console.WriteLine($"Toplam deney sayısı = 10 , Tura gelme ihtimali = {turaSayac/10.0}");

            Console.WriteLine("----------------");

            Console.WriteLine("Para 100 kez atılacaktır.");

            for (int i = 0; i < 100; i++)
            {
                int sonuc = random.Next(0, 2);

                if (sonuc == 0)
                {
                    //Console.WriteLine($"Sonuç yazı geldi:");
                    yaziSayac++;
                }
                else if (sonuc == 1)
                {
                    //Console.WriteLine($"Sonuç tura geldi:");
                    turaSayac++;
                }
            }

            Console.WriteLine($"Toplam yazı : {yaziSayac} , toplam tura : {turaSayac} ");
            Console.WriteLine($"Toplam deney sayısı = 10 , Tura gelme ihtimali = {turaSayac / 100.0}");

            Console.WriteLine("----------------");

            Console.WriteLine("Para 1000 kez atılacaktır.");

            for (int i = 0; i < 1000; i++)
            {
                int sonuc = random.Next(0, 2);

                if (sonuc == 0)
                {
                    //Console.WriteLine($"Sonuç yazı geldi:");
                    yaziSayac++;
                }
                else if (sonuc == 1)
                {
                    //Console.WriteLine($"Sonuç tura geldi:");
                    turaSayac++;
                }
            }

            Console.WriteLine($"Toplam yazı : {yaziSayac} , toplam tura : {turaSayac} ");
            Console.WriteLine($"Toplam deney sayısı = 10 , Tura gelme ihtimali = {turaSayac / 1000.0}");




        }

        private static void Soru9()
        {
            //Soru9) Klavyeden 1 girildiği sürece iki adet zar atan console uygulamasını yazınız
            //(Her adımda iki adet zar atılmalıdır. ) 1 yazıldığı zaman zarları atmaya devam etmeli
            //0 girildiği zaman program sonlanmalıdır.
            //1 ve 0 dışında bir sayı girildiği zaman geçersiz tercih uyarısı gelmeli
            //ve tercih tekrar sorulmalıdır.
            //Her adımda zarların değerleri ve toplamları da ekrana yazdırılmalıdır.
            //Toplamları çift ise çift, tek ise tek bilgisi de yazdırılmalıdır. 

            while (true)
            {
                Console.WriteLine("Lütfen bir sayı giriniz");

                int sayi = Convert.ToInt32(Console.ReadLine());

                int zar1;
                int zar2;
                Random random = new Random();
                

                if (sayi == 1)
                {
                    zar1 = random.Next(1,7);
                    zar2 = random.Next(1,7);
                    int toplam = zar1 + zar2;
                    Console.WriteLine($"Birinci zar {zar1} ve ikinci zar {zar2} gelmiştir");
                    Console.WriteLine($"Toplam = {toplam}");
                    if (toplam % 2==0)
                    {
                        Console.WriteLine($"Toplamları çifttir");
                    }
                    else
                    {
                        Console.WriteLine($"Toplamları tektir");
                    }
                }else if (sayi == 0)
                {
                    return;
                } 
                else
                {
                    Console.WriteLine("Geçersiz bir giriş yaptınız lütfen tekrar bir sayı giriniz.");
                }

            }


        }

        private static void Soru8()
        {
            //Soru8)Klavyeden yazılan bir sayının armstrong sayısı olup olmadığını bulan programı yazınız. 

            //önce sayının basamak sayısını bulmamız gereklidir. Bunu bulmadan üssünü alamayız. 2 ayrı döngü lazım.


            int sayi, basamakSayisi = 0, yedek, basamakDegeri;
            int us = 1;
            int toplam = 0;
            Console.WriteLine("Sayıyı giriniz:");
            sayi = Convert.ToInt32(Console.ReadLine());
            yedek = sayi;

            while (yedek != 0)
            {
                yedek /= 10;
                basamakSayisi++;            }

            yedek = sayi;

            while (yedek != 0)
            {
                us = 1;
                basamakDegeri = yedek%10; //basamakDegerinin basamakSayısıncı üssü

                for (int i = 0; i < basamakSayisi; i++)
                {
                    us *= basamakDegeri; 
                }
                toplam += us;

                yedek /= 10;

            }
            if(toplam == sayi)
                Console.WriteLine("Armstrong sayısıdır.");
            else
                Console.WriteLine("Armstrong sayısı değildir.");

        }

        private static void Soru7()
        {
            Console.WriteLine("Lütfen bir sayı giriniz:");

            int sayi = Convert.ToInt32(Console.ReadLine());
            int toplam = 0;

            for (int i = 1; i < sayi; i++)
            {
                if (sayi % i == 0) //burada sayının kendinden önceki sayılara tam bölünüp bölünmediği
                {
                    toplam = toplam + i;//eğer bölünüyorsa toplama ekle
                }
   
            }
            if (toplam == sayi)
            {
                Console.WriteLine("Girdiğiniz sayı mükemmeldir");
            }
            else
            {
                Console.WriteLine("Girdiğiniz sayı mükemmel değildir.");
            }
            

        }

        private static void Soru6()
        {
            //Soru6)Klavyeden yazılan bir sayının asal sayı olup olmadığını bulan programı yazınız. 

            Console.WriteLine("Lütfen bir sayı giriniz:");

            int sayi = Convert.ToInt32(Console.ReadLine());
            int sayac = 0;

            while (sayi <2)
            {
                Console.WriteLine("Asal sayılar 2'den başlar. Lütfen yeni bir değer giriniz");
                sayi = Convert.ToInt32(Console.ReadLine());
            }
            
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
                Console.WriteLine("Girdiğiniz sayı asaldır.");

            }
            else
            {
                Console.WriteLine("Girdiğiniz sayı asal değildir.");
            }

        }   

        private static void Soru5()
        {
            //Soru5)Klavyeden yazılan iki sayı arasındaki sayıları çarpıp sonucunu ekrana yazdıran
            //programı yazınız. (Alt ve üst sınırlar dahil değildir) 

            Console.WriteLine("Lütfen iki sayı giriniz:");

            int s1 = Convert.ToInt32(Console.ReadLine());
            int s2 = Convert.ToInt32(Console.ReadLine());
            int carpim = 1;


            for (int i = s1+1; i < s2; i++)
            {
                carpim *= i;
            }
            Console.WriteLine($"Sonuç: {carpim}");

        }

        private static void Soru4()
        {
            //Soru4) Klavyeden yazılan iki sayı arasındaki sayılardan tek olanları olduğu gibi alıp,
            //çift olanların da -1 ile çarpılmış halini alıp, toplayıp sonucu ekrana yazdıran programı
            //yazınız. (alt sınır dahil üst sınır dahil değildir) 

            Console.WriteLine("Lütfen iki sayı giriniz:");

            int s1 = Convert.ToInt32(Console.ReadLine());
            int s2 = Convert.ToInt32(Console.ReadLine());

            int toplam = 0;

            for (int i = s1; i < s2; i++)
            {
                if (i % 2 == 1) 
                {  
                    toplam = toplam + i; 
                }
                else 
                {
                    toplam = toplam + (i * -1);
                }

            }
            Console.WriteLine($"İşlem sonucu: {toplam}");
        }

        private static void Soru3()
        {
            //Soru3) Klavyeden 1 girildiği sürece rastgele haftanın bir gününü ekrana yazdıran programı
            //yazınız. 0 girilince program sonlanmalıdır. (0  ve 1 dışında girilen değerler için geçersiz
            //tercih uyarısı gelmeli ve program tercihi tekrar sormalıdır)  
            
            while (true)
            {
                Console.WriteLine("Lütfen bir sayı giriniz:");

                int sayi = Convert.ToInt32(Console.ReadLine());

                if (sayi == 1)
                {
                    int number = new Random().Next(8);

                    switch (number)
                    {
                        case 1:
                            Console.WriteLine("Pazartesi");
                            break;
                        case 2:
                            Console.WriteLine("Salı");
                            break;
                        case 3:
                            Console.WriteLine("Çarşamba");
                            break;
                        case 4:
                            Console.WriteLine("Perşembe");
                            break;
                        case 5:
                            Console.WriteLine("Cuma");
                            break;
                        case 6:
                            Console.WriteLine("Cumartesi");
                            break;
                        case 7:
                            Console.WriteLine("Pazar");
                            break;
                    }
                }
                else if (sayi == 0)
                {
                    Console.WriteLine("bye :( ");
                    break;
                }
                else
                {
                    Console.WriteLine("Geçersiz bir giriş yaptınız. Yeniden giriniz.");
                }

            }
        }

        private static void Soru2()
        {

            //Soru2) Rastgele haftanın bir gününü ekrana yazdıran bir program yazınız. 

            int number = new Random().Next(1, 8);

            switch (number)
            {
                case 1:
                    Console.WriteLine("Pazartesi");
                    break;
                case 2:
                    Console.WriteLine("Salı");
                    break;
                case 3:
                    Console.WriteLine("Çarşamba");
                    break;
                case 4:
                    Console.WriteLine("Perşembe");
                    break;
                case 5:
                    Console.WriteLine("Cuma");
                    break;
                case 6:
                    Console.WriteLine("Cumartesi");
                    break;
                case 7:
                    Console.WriteLine("Pazar");
                    break;

            }

            Console.WriteLine(number==1?"Pazartesi": number==2?"Salı": number == 3 ? "Çarşamba" :
                number == 4 ? "Perşembe" : number == 5 ? "Cuma" : number == 6 ? "Cumartesi" : "Pazar" );


        }

        private static void Soru1()
        {
            //Soru1) 50 ile 300 arasında rastgele bir sayı ekrana yazan programı yazınız. (50 ve 300 dahil) 

            int sayi;
            sayi = new Random().Next(50, 301);
            Console.WriteLine($"50-300 arasında bir sayı: {sayi} ");
        }
    }
}
