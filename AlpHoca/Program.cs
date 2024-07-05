namespace AlpHoca1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ekrana yazdırma başlangıç
            //string isim;
            //int yas = 88;
            //double ss1 = 4.4;
            //float ss2;


            //Console.WriteLine("Hello, World!");
            //Console.WriteLine("isim");
            //Console.WriteLine("İsminizi giriniz:");
            //isim = Console.ReadLine(); //input
            //Console.WriteLine($"Merhaba " + isim);   //output

            //Console.WriteLine("Yaşı giriniz:");
            //yas = Convert.ToInt32(Console.ReadLine());  //input
            //Console.WriteLine("Yaşınız: " + yas); //ya da
            //Console.WriteLine($"Yaşınız: {yas}"); // bu
            #endregion

            #region Uygulamalar 

            //Girilen 5 adet sayının aritmetik ortalarının hesaplandığı programı yazın.

            int sayi1, sayi2, sayi3, sayi4, sayi5;

            Console.WriteLine("Lütfen 1 adet sayı giriniz: ");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen 1 adet sayı giriniz: ");
            sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen 1 adet sayı giriniz: ");
            sayi3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen 1 adet sayı giriniz: ");
            sayi4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen 1 adet sayı giriniz: ");
            sayi5 = Convert.ToInt32(Console.ReadLine());

            double toplam = ((sayi1 + sayi2 + sayi3 + sayi4 + sayi5) / 5.0);
            Console.WriteLine($"Sayıların aritmetik ortalaması: {toplam}");
            Console.WriteLine("Sayıların aritmetik ortalaması :" + toplam);
            Console.WriteLine($"Sayıların aritmetik ortalaması: {Convert.ToDouble((sayi1 + sayi2 + sayi3 + sayi4 + sayi5) / 5.0)}");

            //Tam biletin fiyatı 150, öğrenci biletinin fiyatı 80 tl olan bir sinemada
            //kişilerin ödemesi gereken toplam miktarı hesaplayan programı yazınız. 
            //Ör: Öğrenci sayısını giriniz.Yetişkin sayısını giriniz.Ödemeniz şu kadar.

            int o, y;

            Console.WriteLine("Öğrenci sayısını giriniz: ");
            o = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Yetişkin sayısını giriniz: ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Ödeme toplamı {(o * 80) + (y * 150)}");

            //burda sonucu sonuca atayıp daha sonra yazdırsaydık değer int olacaktı
            //ve başka hesaplamalar yapılabilecekti çünkü console writeline string çıkartıyor.

            //Yarıçapı verilen bir çemberin alanını ve çevresini hesaplayan programı yazınız.
            //pi=22/7


            double alan, cevre;

            Console.WriteLine("Yarıçap değerini giriniz: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            cevre = 2 * 22 / 7.0 * radius;
            alan = 22 / 7.0 * radius * radius;

            Console.WriteLine($"Çemberin çevre uzunluğu: {cevre}");
            Console.WriteLine($"ÇEmberin alanı: {alan}");

        //ya da

            Console.WriteLine($"Alanı: {22/7.0 * radius * radius}");
            Console.WriteLine($"Çevresi: {2 * 22 / 7.0 * radius }");


            //Klavyeden girilen iki sayının karelerinin toplamını hesaplayan programı yazınız.

            int s1, s2;
            Console.WriteLine("Lütfen iki sayı giriniz");
            s1 = Convert.ToInt32(Console.ReadLine());
            s2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Giridiğiniz sayıların kareleri toplamı: {(s1 * s1) + (s2 * s2)}");

            //Doğum yılı girildiğinde yaşı hesaplayan programı yazınız.

            int yil;
            Console.WriteLine("Lütfen doğum yılınızı giriniz:");
            yil = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Yaşınız: {2024 - yil}");







            #endregion



        }
    }
}
