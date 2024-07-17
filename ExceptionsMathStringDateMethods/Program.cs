

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
            Soru4();
            //Soru5();
            //Soru6();
            //Soru7();
            //Soru8();
            //Soru9();
           



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
                Console.WriteLine(Math.Pow(sayi, 1/3.0));
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

                Console.WriteLine($"Sonuc : {Math.Pow(sayi,us)}");
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
