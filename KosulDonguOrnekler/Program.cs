namespace KosulDonguOrnekler
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Soru1();
            //Soru2();
            //Soru3();
            //Soru4();
            Soru5();
            //Soru6();

        }

        private static void Soru6()
        {
            //6: A ve B grubu olamak üzere öğrenciler vardır. Klavyeden yaş ve öğrenci grubu girilsin.
            //B grubu ise ve yaşı büyük eşit 18 ise şartları sağlıyorsunuz,
            //B grubu ise ama yaşı 18'den küçükse yaş şartını sağlamıyorsunuz,
            //A grubu ve yaşı 18'den büyükse B grubunda olmanız gerekiyor,
            //diğer durumlar da şartları sağlamıyorsunuz uyarıları gelmelidir. 

            int yas;
            char ogrenci;

            Console.WriteLine("Lütfen yaşınızı giriniz:");

            yas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lütfen grubunuzu giriniz:");

            ogrenci = Convert.ToChar(Console.ReadLine());


            if (yas >= 18 && ogrenci == 'B')
                Console.WriteLine("Şartları sağlıyorsunuz");

            else if (yas < 18 && ogrenci == 'B')
                Console.WriteLine("Yaş şartını sağlamıyorsunuz");

            else if (yas >= 18 && ogrenci == 'A')
                Console.WriteLine("B grubunda olmanız gerekiyor");

            else
                Console.WriteLine("Şartları sağlamıyorsunuz.");




        }

        private static void Soru5()
        {
            //Kullanıcıdan alınan vize ve final notuna göre ortalama hesaplayıp
            //puanı harf notuna çeviren ve harf notu bilgisine göre geçip kalma durumunu  ekrana yazan program...
            //Arasınav ve final klavyeden alınacak.
            //Arasınavın %40 ile finalin %60'ının toplamı aşağıdaki sınırlandırmaya göre harf notunu ve durumunu yazdırınız
            //
            //[90,100] ==> A
            //[80, 89] ==> B
            //[70, 79] ==> C
            //[60, 69] ==> D
            //[0,59] ==> F


            double ara, final, ort;

            Console.WriteLine("Lütfen ara sınav sonucunuzu giriniz:");

            ara = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Lütfen final sınavı sonucunuzu giriniz:");

            final = Convert.ToDouble(Console.ReadLine());

            ort = ara * 0.40 + final * 0.60;

            if (ara < 0 || ara > 100 || final < 0 || final > 100)
                Console.WriteLine("Girdiğiniz değerler geçersizdir.");

            switch (ort)
            {
                case var x when ort >= 90 && ort <= 100:
                    Console.WriteLine("A");
                    break;
                case var x when ort >= 80 && ort <= 89:
                    Console.WriteLine("B");
                    break;
                case var x when ort >= 70 && ort <= 79:
                    Console.WriteLine("C");
                    break;
                case var x when ort >= 60 && ort <= 69:
                    Console.WriteLine("D");
                    break;
                case var x when ort >= 0 && ort <= 59:
                    Console.WriteLine("F");
                    break;


            }


        }

        private static void Soru4()
        {
            //4)Görev4:
            //Kullanıcıdan alınan sayı bilgisine göre haftanın hangi günü olduğunu ekrana yazdıran program.

            int sayi;

            Console.WriteLine("Lütfen bir sayı giriniz:");
            sayi = Convert.ToInt32(Console.ReadLine());

            switch (sayi)
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
                default:
                    Console.WriteLine("Geçersiz giriş yaptınız.");
                    break;

            }

        }

        private static void Soru3()
        {
            //3)Bir kişi mağazadan 300 TL ve üzeri alışveriş yaparsa %10 indirim,
            //500 TL ve üzeri alışveriş yaparsa %15 indirim, 600 TL ve üzeri alışveriş yaparsa %20 indirim kazandığını
            //ve ödeyeceği miktarı ekrana yazan programı yazınız. (Tutar klavyeden alınacaktır)

            double fiyat;

            Console.WriteLine("Lütfen fiyatı giriniz:");
            fiyat = Convert.ToDouble(Console.ReadLine());

            //if (fiyat >= 300 && fiyat < 500)

            //    Console.WriteLine($"Toplam ödeme: {fiyat * 0.90}");

            //else if (fiyat >= 500 && fiyat < 600)

            //    Console.WriteLine($"Toplam ödeme: {fiyat * 0.85}");

            //else if (fiyat >= 600)

            //    Console.WriteLine($"Toplam ödeme: {fiyat * 0.80}");

            //else
            //    Console.WriteLine($"Toplam ödeme: {fiyat}");


            switch (fiyat)
            {
                case var y when fiyat >= 300 && fiyat < 500:
                    Console.WriteLine($"Toplam ödeme: {fiyat * 0.90}");
                    break;
                case var y when fiyat >= 500 && fiyat < 600:
                    Console.WriteLine($"Toplam ödeme: {fiyat * 0.85}");
                    break;
                case >= 600:
                    Console.WriteLine($"Toplam ödeme: {fiyat * 0.80}");
                    break;
                case < 300:
                    Console.WriteLine($"Toplam ödeme: {fiyat}");
                    break;

            }


        }

        private static void Soru2()
        {
            ////2) Bir fabrikada maaşla çalışan kişiler, aile durumlarına göre ek maaş almaktadır.
            //Bekar olanlar sadece maaş, evli ve çocuğu olmayanlar (negatif girilirse de) % 3 ek maaş,
            //çocuk sayısı 1 olanlar % 5 ek maaş, çocuk sayısı 2 olanlar % 10 ek maaş,
            //çocuk sayısı 3 ve daha fazla olanlar ise % 15 kadar ek maaş almaktadır.
            //Bu göre, kullanıcıdan kişinin maaşı ve çocuk sayısını isteyerek,
            //gerekli hesaplamayı yapıp ekrana yazdıran programı yazınız.
            //Önce maaşı sorsun
            //Medeni durumunu sorsun
            //Evli ise çocuk sayısını sorsun.


            double maas;

            Console.WriteLine("Lütfen maaşınızı giriniz");
            maas = Convert.ToDouble(Console.ReadLine());

            char medeni;

            Console.WriteLine("Medeni durumunuzu giriniz");
            medeni = Convert.ToChar(Console.ReadLine());

            int cocuk;

            Console.WriteLine("Lütfen çocuk sayısını giriniz:");
            cocuk = Convert.ToInt32(Console.ReadLine());

            if (cocuk < 0)
                Console.WriteLine("Eksi değer girilemez");

            else if (medeni == 'E' || medeni == 'e' && cocuk == 0)

                Console.WriteLine($"Toplam: {maas * 1.03}");

            else if (medeni == 'E' || medeni == 'e' && cocuk == 1)
                Console.WriteLine($"Toplam: {maas * 1.05}");

            else if (medeni == 'E' || medeni == 'e' && cocuk == 2)
                Console.WriteLine($"Toplam: {maas * 1.10}");

            else if (medeni == 'E' || medeni == 'e' && cocuk >= 3)
                Console.WriteLine($"Toplam: {maas * 1.15}");

            else if (medeni == 'B' || medeni == 'b')
                Console.WriteLine(maas);

        }

        private static void Soru1()
        {
            //string karakter kümesi "asdf"
            //char bir karakter 'a'
            //bool true/yanlış değerlerini  alan bir değişken

            //1)Kullanıcan alınan iki sayı arasında yapılmak istenen işlem için seçilen işlem tipine
            //göre ekrana yazdıran program. 
            //sayı float tipinde olacak. Kullanıcının işlem seçimi char olacak.
            //Toplama için T/t, Çıkartma için C/c, Çarpma için X/x, Bölme için B/b, Mod alma için M/m
            //Bölme işleminde payda 0 ise "sıfır ile bölünemez hatası gelsin ve programdan çıksın.

            float s1, s2;

            Console.WriteLine("Lütfen 2 sayı giriniz:");
            s1 = Convert.ToInt32(Console.ReadLine());
            s2 = Convert.ToInt32(Console.ReadLine());

            char islem;

            Console.WriteLine("Lütfen yapmak istediğiniz işlemi giriniz: ");

            islem = Convert.ToChar(Console.ReadLine());

            if (islem == 'T' || islem == 't')
            {
                Console.WriteLine($"Sonuç: {s1 + s2}");
            }
            else if (islem == 'C' || islem == 'c')
            {
                Console.WriteLine($"Sonuç: {s1 - s2}");
            }
            else if (islem == 'X' || islem == 'x')
            {
                Console.WriteLine($"Sonuç: {s1 * s2}");
            }
            else if (islem == 'M' || islem == 'm')
            {
                Console.WriteLine($"Sonuç: {s1 % s2}");
            }
            else if (islem == 'B' || islem == 'b')
            {
                if (s2 == 0)
                    Console.WriteLine("Sıfır ile bölünemez");
                else
                    Console.WriteLine($"Sonuç: {s1 / s2}");


            }

        }
    }
}
