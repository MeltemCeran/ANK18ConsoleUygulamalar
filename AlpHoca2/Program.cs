using System.ComponentModel.Design;
using System.Transactions;

namespace AlpHoca2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Aritmetik Operatörler

            //int sayi1 = 105;
            //int sayi2 = 15;
            //int toplam = sayi1 + sayi2;
            //Console.WriteLine($"Sonuç: {toplam}");
            //Console.WriteLine($"Sonuç: {sayi1 + sayi2}");


            //int fark = sayi1 - sayi2;
            //Console.WriteLine($"Sonuç: {fark}");
            //Console.WriteLine($"Sonuç: {sayi1 - sayi2}");

            //int carpim = sayi1 * sayi2;
            //Console.WriteLine($"Sonuç: {carpim}");
            //Console.WriteLine($"Sonuç: {sayi1 * sayi2}");

            //int bolme = sayi1 / sayi2;
            //Console.WriteLine($"Sonuç: {bolme}");
            //Console.WriteLine($"Sonuç: {sayi1 / sayi2}");

            //int kalan = sayi1 % sayi2;
            //Console.WriteLine($"Sonuç: {kalan}");
            //Console.WriteLine($"Sonuç: {sayi1 % sayi2}");

            //++ ==> 1 artırmak
            //-- ==> 1 eksiltmek
            // sayi++: önce sayıyı alır sonra artırır 
            // ++sayi: önce artırır sonra sayıyı yazar

            int x = 9;
            int y = 10;

            //x++;
            //Console.WriteLine(x);

            //++y;
            //Console.WriteLine(y);

            Console.WriteLine(x++ + ++y + 8 + ++x);
            Console.WriteLine(x);
            Console.WriteLine(y);


            Console.WriteLine(x++ + 7);
            Console.WriteLine(x);
            Console.WriteLine(++y + 7);
            Console.WriteLine(y);

            // += kullanımı değişkenin kendisiyle toplanmasını gösterir şöyle; eksi, bçlü, çarpma içinde geçerli
            /* x += 7 ==> x = x + 7
             * x -= 2 ==> x = x - 2
             * x *= 3 ==> x = x * 3
             * x /= 2 ==> x = x / 2
             * x %= 3 ==> x = x % 3
             * */

            #endregion


            #region IfKullanımı

            //hiçbir zaman tek başına else if başlamaz. neyin ifisin?? if tek başınada kullanılır.
            //1)girilen sayının tek mi çift mi olduğunu bulup ekrana yazdıran programı yazınız.

            int sayi;

            Console.WriteLine("Lütfen bir sayı giriniz: ");
            sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi % 2 == 0)
            
                Console.WriteLine("Girilen sayı çifttir:");

            else
                Console.WriteLine("Girilen sayi tektir");

            #endregion

            #region Ternary IF

            //yukardaki örneğin tek satırda yapılması


            Console.WriteLine(sayi % 2 == 0 ? "ÇİFT" : "TEK");

            int u;

            u = sayi % 2 == 0 ? 1 : 0; //bu kısası aşağıyada iflisini yazıyorum

            if (sayi % 2 == 0)
            {
                u = 1;
            }
            else
            {
                u = 0;
            }


            #endregion










        }
    }
}
