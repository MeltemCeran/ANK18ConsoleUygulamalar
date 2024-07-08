using System.ComponentModel.Design;
using System.Runtime.Intrinsics.X86;

namespace Odev2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1)Kullanıcı adı ve şifrenin yazıldığı, kullanıcı adı ve şifre doğru ise "Giriş Başarılı" 
             * değil ise "Giriş Başarısız" mesajını ekrana veren programı yazınız. 
             * Kullanıcı adınız kendi adınız ve soyadınız olmalıdır. 
             * (Adın ilk harfi ve soyadın ilk harfi büyük, diğer harfler küçük olmalıdır. 
             *Şifre ise AnK18!Bu olmalıdır. Ör: Alp Ceyhan için kullanıcı adı AlpCeyhan olmalıdır.
             */

            string kullaniciAdi, sifre;

            Console.WriteLine("Lütfen kullanıcı adınızı giriniz:");
            kullaniciAdi = Console.ReadLine();

            Console.WriteLine("Lütfen şifrenizi giriniz:");
            sifre = Console.ReadLine();


            if (kullaniciAdi == "MeltemCeran" && sifre == "AnK18!")
            {
                Console.WriteLine("Giriş Başarılıdır");
            }
            else
                Console.WriteLine("Giriş Başarısız");


            ////2)Klavyeden girilen bir sayı tek ise 2 katını, çift ise yarısını ekrana yazdrıran programı yazınız.


            double sayi;

            Console.WriteLine("Lütfen bir sayı giriniz:");

            sayi = Convert.ToDouble(Console.ReadLine());

            if (sayi % 2 == 1)
            {
                Console.WriteLine($"Sonuç: {sayi * 2}");
            }
            else
            {
                Console.WriteLine($"Sonuç {sayi / 2}");
            }



            /*3)Kullanıcıdan alınan nota göre ekrana harf notunu yazdıran programı yazınız. 
             * [90,100] aralığında ise A, [80,89] aralığında ise B, [70,79] aralığında ise C, 
             * [60,69] aralığında ise D, [0,59] aralığında ise F, diğer durumlarda "geçersiz not" yazdırılmalıdır.
             */


            double sayii;

            Console.WriteLine("Lütfen sınav sonucunuzu giriniz:");

            sayii = Convert.ToDouble(Console.ReadLine());

            if (sayii <= 100 && sayi >= 90)
            {
                Console.WriteLine("Puanınız : A");
            }
            else if (sayii <= 89 && sayii >= 80)
                Console.WriteLine("Puanınız : B");
            else if (sayii <= 79 && sayii >= 70)
                Console.WriteLine("Puanınız : C");
            else if (sayii <= 69 && sayii >= 60)
                Console.WriteLine("Puanınız : D");
            else if (sayii <= 59 && sayii >= 0)
                Console.WriteLine("Puanınız : F");
            else
                Console.WriteLine("Geçersiz not.");


            ///*4)Kullanıcının girdiği üç kenar uzunluğunun, bir üçgen oluşturup oluşturmadığını kontrol eden programı yazınız. 
            // * İki kenarın toplam uzunluğu üçüncü kenardan büyük olmalıdır. 
            // * Eğer bu koşul sağlanıyorsa, üç kenar bir üçgen oluşturabilir. Aksi halde, oluşturamaz.
            // */

            double a, b, c;

            Console.WriteLine("Lütfen 3 kenar uzunluğu giriniz:");

            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());

            if (a + b > c && b + c > a && a + c > b)
            {
                Console.WriteLine("Girdiğiniz değerler bir üçgen oluşturur");
            }
            else
                Console.WriteLine("Girdiğiniz değerler bir üçgen oluşturmaz");



            ///*5)Bir mağazadan alınan ürünün fiyatı 2500 TL ve üzerinde ise 75 TL olan kargo ücreti alınmamaktadır. 
            // * Ürünün fiyatı girildiğinde toplam ödenmesi gereken tutarı gösteren programı yazınız.
            // */

            double fiyat;

            Console.WriteLine("Lütfen ürün fiyatını giriniz:");
            fiyat = Convert.ToDouble(Console.ReadLine());

            if (fiyat > 2500)
            {
                Console.WriteLine($"Toplam: {fiyat}");
            }
            else
            {
                Console.WriteLine($"Toplam: {fiyat + 75.00}");
            }


            ///*6)Bir mağazada kampanya yapılmaktadır. Alınan 2 ürünün toplamı 3000 TL'den fazla olursa fiyatı düşük olan 
            // * üründen %25 indirim yapılmaktadır. (Eğer fiyatlar eşit ise herhangi birisinden %25 indirim olacaktır) 
            // * Bu bilgilere göre kullanıcı tarafından girilen 2 ürün fiyatına göre toplam yapılacak ödeme miktarını 
            // * hesaplayan programı yazınız.
            // */

            double f1, f2;
            Console.WriteLine("Lütfen 2 ürünün de fiyatını giriniz:");
            f1 = Convert.ToDouble(Console.ReadLine());
            f2 = Convert.ToDouble(Console.ReadLine());

            if (f1 + f2 > 3000)
            {
                if (f1 <= f2)
                {
                    Console.WriteLine($"Ödeme toplamı: {f1 * 0.75 + f2}");
                }
                else
                {
                    Console.WriteLine($"Ödeme toplamı: {f2 * 0.75 + f1}");
                }

            }
            else
            {
                Console.WriteLine($"Ödeme toplamı: {f2 + f1}");
            }


            /*7) Kullanıcı tarafından girilen 4 basamaklı bir sayının tersi ile aynı olup olmadığını bulan programı yazınız.
             * Eğer girilen sayı 4 basamaklı değilse "4 basamaklı sayı girmediniz" uyarısı gelmelidir. 
             * Ör: 2552, 7887, 9229 vb.. sayılar tersten de aynıdır fakat 1456, 7841, 1120  vb.. 
             * sayılar tersten aynı değildir.
             */


            int number, e, f, g, h;

            Console.WriteLine("Lütfen 4 basamaklı bir sayı giriniz:");

            number = Convert.ToInt32(Console.ReadLine());

            if ((number >= 1000 && number <= 9999) || (number >= -9999 && number <= -1000))
            {
                h = number % 10;
                g = (number % 100) / 10;
                f = (number % 1000) / 100;
                e = number / 1000;

                Console.WriteLine($" Basamaklar: {e}, {f}, {g}, {h}");

                if (h == e && g == f)
                {
                    Console.WriteLine("Kurala uygundur");
                }
                else
                    Console.WriteLine("Kurala uygun değildir");
            }
            else
                Console.WriteLine("4 basamaklı sayı girmediniz");



            /*8)Kullanıcı tarafından girilen 2 sayıdan hangisinin büyük olduğunu bulan programı yazınız. 
             * Sayılar eşit ise "Sayılar eşittir" yazmalıdır.
             */

            int s1, s2;

            Console.WriteLine("Lütfen 2 sayı giriniz:");
            s1 = Convert.ToInt32(Console.ReadLine());
            s2 = Convert.ToInt32(Console.ReadLine());

            if (s1 == s2)
            {
                Console.WriteLine("Sayılar birbirine eşittir");
            }
            else if (s1 > s2)
            {
                Console.WriteLine("S2 büyüktür");
            }
            else
                Console.WriteLine("S1 büyüktür");



            //9) Kullanıcı tarafından yazılan bir sayının İspanyolcasını ekrana yazan programı yazınız.
            //1 ise uno, 2 ise dos, 3 ise tres, 4 ise cuatro, 5 ise cinco, diğer durumlar "Otro numero" yazmalıdır.


            int n;
            Console.WriteLine("Lütfen bir sayı yazınız");
            n = Convert.ToInt32(Console.ReadLine());

            if (n == 1)
            {
                Console.WriteLine("Uno");
            }
            else if (n == 2)
            {
                Console.WriteLine("Dos");
            }
            else if (n == 3)
            {
                Console.WriteLine("Tres");
            }
            else if (n == 4)
            {
                Console.WriteLine("Cuatro");
            }
            else if (n == 5)
            {
                Console.WriteLine("Cinco");
            }
            else
            {
                Console.WriteLine("Otro numero");
            }


        }
    }
}
