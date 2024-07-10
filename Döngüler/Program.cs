

namespace Döngüler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Görev1();
            Görev2();

        }

        private static void Görev2()
        {
            //0 20 arasındaki sayıları sınırlar dahil çift sayıların toplamını ve tek sayıların toplamını
            //bulan programı yazınız. do- for- do while ile



            //int toplamçift = 0;
            //int toplamtek = 0;

            //for (int i = 0; i <= 20; i++)
            //    if (i % 2 == 0)
            //        toplamçift = toplamçift + i;
            //    else if (i % 2 == 1)
            //        toplamtek = toplamtek + i;

            //Console.WriteLine($"Çift sayılar toplamı: {toplamçift} ");
            //Console.WriteLine($"Çift sayılar toplamı: {toplamtek} ");

            Console.WriteLine("--------------");

            //int toplamçift = 0;
            //int toplamtek = 0;
            //int i = 0;

            //while (i <= 20)
            //{ 
            //    if (i % 2 == 0)
            //        toplamçift = toplamçift + i; 
                    
            //    else if (i % 2 == 1)
            //        toplamtek = toplamtek + i;

            //    i++;
            //}
            //Console.WriteLine($"Çift sayılar toplamı: {toplamçift} ");
            //Console.WriteLine($"Çift sayılar toplamı: {toplamtek} ");

            Console.WriteLine("--------------");

            int toplamçift = 0;
            int toplamtek = 0;
            int i = 0;

            do
            {
                if (i % 2 == 0)
                    toplamçift = toplamçift + i;

                else if (i % 2 == 1)
                    toplamtek = toplamtek + i;

                i++;

            } while (i <= 20);

            Console.WriteLine($"Çift sayılar toplamı: {toplamçift} ");
            Console.WriteLine($"Çift sayılar toplamı: {toplamtek} ");
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
