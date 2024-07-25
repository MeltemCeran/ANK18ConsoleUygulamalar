namespace Odev4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Odev4();
            //ArraySoru1();
            //ArraySoru2();
            //ArraySoru3();
            //ArraySoru4();
            //ArraySoru5();

        }

        private static void ArraySoru5()
        {
            //Rastgele [1,10] arasında 10 elemanlı diziye sayı atayan programı yazınız. HER SAYI 1 KERE GELMELİDİR.

            int[] dizi = new int[10];
            bool sayivarmi =false;
            int rastgeleSayi;



            for (int i = 0; i < dizi.Length; i++)
            {
                rastgeleSayi = new Random().Next(1,11);
                for (int j = 0; j < dizi.Length; j++)
                {
                   if (dizi[j] == rastgeleSayi)
                    {
                        sayivarmi = true;
                        break;
                    }
                }

               
            }


        }

        private static void ArraySoru4()
        {
            //10 öğrenciden oluşan bir sınıfta öğrencilerin, programlamanın temelleri dersinden aldıkları notların 
            //toplamını ve ortalamasını bulan programı yazınız. Notlar klavyeden girilecektir.

            int[] dizi = new int[10];
           
            int toplam = 0;
            int ortalama;

            for (int i = 0; i < dizi.Length; i++)
            {
                Console.WriteLine($"{i+1} . notunuzu giriniz:");

                dizi[i] = Convert.ToInt32(Console.ReadLine());

                toplam = toplam + dizi[i];
               
            }

           
            Console.WriteLine($"Notların toplamı: {toplam}");
            Console.WriteLine($"Notların ortalaması: {toplam/10}");



        }

        private static void ArraySoru3()
        {
            //10 elemanlı bir dizinin elemanlarına [1-1000] arasında rastgele değer atanmasını sağlayınız.
            //Bu dizideki[501, 600] arasındaki sayıların toplamı ile[100, 500] arasındaki sayıların adedini bulan programı yazınız.

            int[] dizi = new int[10];

            int toplam = 0;

            int adet = 0;

            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = new Random().Next(1, 1001);
            }

            for (int i = 0;i < dizi.Length; i++)
            {
                Console.WriteLine(dizi[i]);
            }

            Console.WriteLine("----------");

            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] >= 501 && dizi[i] <=600)
                {
                    toplam = toplam + dizi[i];
                }


                if (dizi[i] >= 100 &&  dizi[i] <=500)
                {
                    adet++;
                }
            }


            Console.WriteLine($"501-600 arasında gelen rastgele sayıların toplamı: {toplam}");

            Console.WriteLine($"100-500 arasında gelen rastgele sayıların adedi: {adet}");


        }

        private static void ArraySoru2()
        {
            //Klavyeden kullanıcı tarafından girilen, beş elemanlı bir sayı dizisinde, son rakamı 0(sıfır) olan sayıların
            //sayısını bulan programı yazınız.

            int[] dizi = new int[5];
            int toplam = 0;

            for (int i = 0; i < dizi.Length; i++)
            {
                Console.WriteLine($"Lütfen {i+1} . sayıyı giriniz: ");

                int sayi = Convert.ToInt32(Console.ReadLine());

                dizi[i] = sayi;
            }
            
            for (int i = 0;i < dizi.Length;i++)
            {
                if (dizi[i] % 10 == 0)
                    toplam++;
            }

            Console.WriteLine($"Son rakamı 0 olan sayılar : {toplam}");
        }

        private static void ArraySoru1()
        {
            //Klavyeden kullanıcı tarafından girilen 6 sayıdan en büyüğünü bulan programı dizi kullanarak yazınız.
            //(maksimumdan büyük olan maksimumdur fikri ile)

            int[] dizi = new int[6];

            for (int i = 0; i < 6 ; i++)
            {
                Console.WriteLine("Lütfen bir sayı giriniz:");

                int sayi = Convert.ToInt32(Console.ReadLine());

                dizi[i] = sayi;
            }

            Console.WriteLine("-------");

            for (int i = 0;i < dizi.Length ; i++)
            {
                Console.WriteLine(dizi[i]);
            }

            Console.WriteLine("-------");

            int max = dizi[0];

            for (int i = 1; i < dizi.Length; i++)
            {
                if (dizi[i] > max)
                    max = dizi[i];
            }
            
            Console.WriteLine($"En büyük değer : {max}");


        }
        //bir inpıt al 5 tane
        //listeye at
        //listeyi yazdır
        //listeyi sırayla dön
        //karşılaştır büyük olanı tempmax a at
        //console temp max

        private static void Odev4()
        {
            //Katsayıları kullanıcı tarafından girilen 2. derece denklemin reel köklerinin olup olmadığını,
            //varsa kaç adet olduğunu neler olduğunu bulan programı yazınız. 

            int a, b, c;

            double kok1;
            double kok2;
            double delta;

            bool devamMi = true;

            while (devamMi) 
            { 
            
            }
            try
            {
                Console.WriteLine("Lütfen köklerini bulmak istediğiniz denklemin katsayılarını giriniz:");
                Console.Write("a : ");
                a = Convert.ToInt32(Console.ReadLine());

                if (a == 0)
                {
                    Console.WriteLine("Katsayıların birincisi 0 olamaz");
                    return; 
                }

                Console.Write("b : ");
                b = Convert.ToInt32(Console.ReadLine());

                Console.Write("c : ");
                c = Convert.ToInt32(Console.ReadLine());

                delta = Math.Pow(b, 2) - 4 * a * c;

                if (delta > 0)
                {
                    kok1 = (-b + Math.Sqrt(delta)) / 2 * a;

                    kok2 = (-b - Math.Sqrt(delta)) / 2 * a;

                    Console.WriteLine($"x1 : {kok1} x2 : {kok2}");
                }
                else if (delta == 0)
                {
                    kok1 = -b / (2 * a);

                    Console.WriteLine($"x1 {kok1}");
                }
                else
                {
                    Console.WriteLine("Kök hesaplanamaz");
                }
                Console.WriteLine($"delta = {delta}");
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Hata {ex.Message}");
            }
            


            
        }
    }
}
