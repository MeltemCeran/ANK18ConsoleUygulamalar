

using System;
using System.Threading.Channels;

namespace ExceptionsMathStringDateMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //TryCatchOrnek();
            //Soru1();
            //Soru2();
            //Soru3();
            //Soru4();
            //Soru5();
            //Soru6();
            //Soru7();
            //Soru8();
            //Soru9();
            StringMetotlar();
            //StringSoru1();
            //StringSoru2();
            //StringSoru3();
            //StringSoru4();
            //StringSoru5();
            //StringSoru6();
            //StringSoru7();
            //DateTimeSoru8();
            //DateTimeSoru9();
            //DateTimeSoru10();
            //DateTimeSoru11();
            //DateTimeSoru12();




        }

        private static void DateTimeSoru12()
        {
            //Girilen iki tarih arasındaki gün farkını  bulan programı yazınız. 
            //İPUCU: 2 datetime'ın farkını alıp TimeSpan türünde bir değişkene atayınız.
            //Sonra o TimeSpan türündeki değşkenin toplam gün sayısını .TotalDays ile bulunuz.


            DateTime tarih1;
            DateTime tarih2;

            Console.WriteLine("Bir tarih giriniz");

            tarih1 = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Bir tarih giriniz");

            tarih2 = Convert.ToDateTime(Console.ReadLine());

            TimeSpan fark = tarih1 - tarih2;

            Console.WriteLine(fark.TotalDays);
        }

        private static void DateTimeSoru11()
        {
            //Kullanıcıdan alınan doğum tarihi bilgisi ile kullanıcının yaşını hesaplayan program.
            //Year yazarak tarihin yılını bulabiliriz.

            DateTime dogumTarihi;

            Console.WriteLine("Doğum tarihinizi giriniz:");

            dogumTarihi = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine(DateTime.Now.Year - dogumTarihi.Year);

            string m = "selam merhaba";

           
        }

        private static void DateTimeSoru10()
        {
            //Ekrana sistemin anlık zaman 18 Temmuz 2024 15:26 şeklinde yazdırınız. İPUCU: ToLongDateString();

            DateTime now = DateTime.Now;

            Console.WriteLine($"{now.ToLongDateString()} , {now.ToShortTimeString()}");
        }

        private static void DateTimeSoru9()
        {
            //Ekrana sistemin anlık zaman ve saat bilgisini gg.aa.yyyy gün formatında yazan program.

            DateTime now = DateTime.Now;

            Console.WriteLine($"{now.ToShortDateString()}");
        }

        private static void DateTimeSoru8()
        {
            //Şimdiyi yazdır. 


            DateTime now = DateTime.Now;

            Console.WriteLine($"{now.ToLongDateString()} , {now.ToLongTimeString()}");

            Console.WriteLine($"{now.ToShortDateString()} , {now.ToShortTimeString()}");

        }

        private static void StringSoru7()
        {
            //Kullanıcı tarafından girilen bir cümle içerisinde, yine kullanıcı tarafından yazılan bir kelimeyi 
            //cümlede bulup, yerine yine kullanıcı tarafından girilen yeni bir kelime ile değiştiren programı yazınız.
            //İPUCU: Replace()

            string metin;
            Console.WriteLine("Lütfen bir cümle giriniz");
            metin = Console.ReadLine();

            string kelime;
            Console.WriteLine("Lütfen değiştirmek istediğiniz kelimeyi yazınız:");
            kelime = Console.ReadLine();

            string kelime2;
            Console.WriteLine("Yerine hangi kelimeyi koymak istiyorsunuz?");
            kelime2 = Console.ReadLine();

            Console.WriteLine(metin.Replace(kelime,kelime2));

        }

        private static void StringSoru6()
        {
            //Girilen bir kelimenin bütün harflerinin büyük harf ve daha sonra bütün harflerinin
            //küçük harf olacak şekilde ayrı ayrı ekrana yazdıran programı yazınız. ToUpper() ve ToLower()

            string k1= "meLteM";

            Console.WriteLine(k1.ToUpper());
            Console.WriteLine(k1.ToLower());
            Console.WriteLine(k1);


        }

        private static void StringSoru5()
        {
            //Kullanıcıdan alının ad,soyad ve yaş bilgilerini "benim adım ..... soyadım ...... ve yaşım .....'tır" 
            //şeklinde ekranda gösteren programı yazınız.İPUCU: +, String.Concat()

            Console.Write("Lütfen adınızı giriniz:");
            string ad = Console.ReadLine();

            Console.Write("Lütfen soyadınızı giriniz:");
            string soyad = Console.ReadLine();

            Console.Write("Lütfen yaşınızı giriniz:");
            string yaş = Console.ReadLine();

            Console.WriteLine(String.Concat($"Benim adım {ad}, soyadım {soyad}, yaşım {yaş}"));

        }

        private static void StringSoru4()
        {
            //Bir string ifade içerisinde kullanıcının girmiş olduğu karakteri arayan programı yazınız.
            //Arama: Aranan karakterin string içerisinde hangi İNDİSTE OLDUĞU anlamına gelmektedir.
            //İPUCU: IndexOf()

            string word = "Bu kekler neli?";
            Console.WriteLine(word.IndexOf('e'));
            Console.WriteLine(word.LastIndexOf('e'));


        }

        private static void StringSoru3()
        {

            //Kullanıcı tarafından girilen kelimenin sağındaki ve solundaki boşlukları temizleyen programı yazınız.

            string kelime;

            Console.Write("Lütfen bir kelime giriniz:");

            kelime = Console.ReadLine();

            Console.WriteLine("*" + kelime.Trim() + "*");
            Console.WriteLine("*" + kelime + "*");
        }

        private static void StringSoru2()
        {

            ////Kullanıcının girmiş olduğu iki metinsel ifadeyi karşılaştıran eşleşme durumunu gösteren
            ////programı yazınız. (kelimelerin eşit olup olmadığını bulunuz. 

            string m1;
            string m2;

            Console.Write("Lütfen bir kelime giriniz:");

            m1 = Console.ReadLine();

            Console.Write("Lütfen bir kelime giriniz:");

            m2 = Console.ReadLine();

            Console.WriteLine(String.Compare(m1, m2,true));
        }

        private static void StringSoru1()
        {
            //Kullanıcının girmiş olduğu cümlede hava kelimesini arayan programı yazınız.

            string metin = "Bugün çok güzel.";

            if (metin.Contains("hava"))
            {
                Console.WriteLine("varmış");
            }
            else
                Console.WriteLine("yokmuş");
        }

        private static void StringMetotlar()
        {


            //Bunu başlık gibi kullanıyorum. 

            Console.WriteLine("Burası başlık gibi");



        }

        private static void Soru9()
        {
            //Örnek9: Pi sayısını yazdırın. Math.PI
            try
            {
                Console.WriteLine(Math.PI);
            }

            catch (Exception ex)
            {

                Console.WriteLine(ex); ;
            }
        }

        private static void Soru8()
        {
            //Örnek8: E sayısını yazdırın. Math.E

            try
            {
                Console.WriteLine(Math.E);
            }

            catch (Exception ex)
            {

                Console.WriteLine(ex); ;
            }


        }

        private static void Soru7()
        {
            //Kullanıcı tarafından girilen iki sayıdan küçük olanı  hesaplayan programı yazınız. Math.Min();

            try
            {
                Console.WriteLine("Lütfen iki sayı giriniz:");
                int s1 = Convert.ToInt32(Console.ReadLine());
                int s2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(Math.Min(s1, s2));
            }

            catch (Exception ex)
            {

                Console.WriteLine(ex); ;
            }
        }


        private static void Soru6()
        {
            //Kullanıcı tarafından girilen iki sayıdan büyük olanı  hesaplayan programı yazınız. Math.Max();

            try
            {
                Console.WriteLine("Lütfen iki sayı giriniz:");
                int s1 = Convert.ToInt32(Console.ReadLine());
                int s2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(Math.Max(s1, s2));
            }

            catch (Exception ex)
            {

                Console.WriteLine(ex); ;
            }
        }

        private static void Soru5()
        {
            //Kullanıcı tarafından girilen bir sayının küpkökünü  hesaplayan programı yazınız. Math.Pow(...., 1/3.0);

            try
            {
                Console.WriteLine("Lütfen bir sayı giriniz:");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(Math.Pow(sayi, 1 / 3.0));
            }

            catch (Exception ex)
            {

                Console.WriteLine(ex); ;
            }
        }

        private static void Soru4()
        {
            //Kullanıcı tarafından girilen bir sayının karekökünü  hesaplayan programı yazınız. Math.Sqrt()

            try
            {
                Console.WriteLine("Lütfen bir sayı giriniz:");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(Math.Sqrt(sayi));
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }
        }

        private static void Soru3()
        {
            //Kullanıcı tarafından girilen bir sayının mutlak değerini hesaplayan programı yazınız. Math.Abs()

            try
            {
                Console.WriteLine("Lütfen bir sayı giriniz:");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(Math.Abs(sayi));
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }

        }

        private static void Soru2()
        {
            //Örnek 2: Kullanıcı tarafından girilen double türünden kilo değerini tamsayıya yuvarlayan programı yazınız.
            //Math.Floor(), Math.Ceiling(), Math.Round()

            try
            {
                Console.WriteLine("Lütfen bir kilogram değeri giriniz.");
                double kg = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Floor : {Math.Floor(kg)}");
                Console.WriteLine($"Round : {Math.Round(kg)}");
                Console.WriteLine($"Ceiling : {Math.Ceiling(kg)}");

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }
        }

        private static void Soru1()
        {
            //Soru1)Kullanıcı tarafından girilen bir sayının kullanıcı tarafından girilen kuvvetini alıp ekrana yazınız.
            //Üs için döngü kullanmayın. Math.Pow

            try
            {
                Console.WriteLine("Hangi sayının kaçıncı kuvvetini istiyorsunuz? İki sayı giriniz:");
                int sayi = Convert.ToInt32(Console.ReadLine());
                int us = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Sonuc : {Math.Pow(sayi, us)}");
            }
            catch (Exception ex)
            {

                Console.WriteLine("Girdiğiniz değer sayı değildir.");
            }

        }

        private static void TryCatchOrnek()
        {
            //int x;

            //try
            //{
            //    x = Convert.ToInt32(Console.ReadLine());
            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine($"Hata {ex}");
            //}
            //finally //her türlü çalışır try ya da catche girmesi farketmez. program çökmedi ve çalışmaya devam etti.
            //{
            //    Console.WriteLine("Her durumda çalışır");
            //}

            //throw new Exception("ANK18 exception");
            //throw new DivideByZeroException();


            Console.WriteLine("Sayı giriniz:");

            string sayiAdayi = Console.ReadLine();

            int sayi;

            //if (int.TryParse(sayiAdayi, out sayi))
            //{
            //    Console.WriteLine($"Sayi çevrildi. {sayi * 2}");
            //}
            //else
            //    Console.WriteLine("Sayı girilmedi.");

            while (!int.TryParse(sayiAdayi, out sayi))
            {
                Console.WriteLine("Lütfen tekrar sayı giriniz:");
                sayiAdayi = Console.ReadLine();

            }
            // ifli olanda aynı şeyi yapıyor nerdeyse.

        }
    }
}
