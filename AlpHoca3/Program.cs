using System.Linq.Expressions;

namespace AlpHoca3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SwitchCaseOrnekler();

        }

        private static void SwitchCaseOrnekler()
        {

            int sayi;
            Console.WriteLine("Lütfen bir sayı yazınız");
            sayi = Convert.ToInt32(Console.ReadLine());

            switch (sayi)
            {
                case < 0:
                    Console.WriteLine("Negatif");
                    break;
                case 1:
                    Console.WriteLine("Uno");
                    break;
                case 2:
                    Console.WriteLine("Dos");
                    break;
                case 3:
                    Console.WriteLine("Tres");
                    break;
                case 4:
                    Console.WriteLine("Quatro");
                    break;
                case 5:
                    Console.WriteLine("Cinco");
                    break;
                default:
                    Console.WriteLine("Otro Numero");
                    break;

            }

            //eğer birden çok sayı kullanacaksam şöyle
            //case(<0 , < 0) diye yazıyoruz.
            //ya da case( <0, not 3) sayı1 sıfırdan küçük ve sayı2 3 değil.
            // ya da case(>-10 and <0 , <0) sayı1 sıfırdan küçük ve -10dan büyük sayı2 sıfırdan küçük
            // ya da case(>-10 and <0 , <0) when sayi !=88 
            //"when" switch dışındaki değişkenlerdir.


            Console.WriteLine("Lütfen bir ay giriniz");
            string ay = Console.ReadLine();

            switch (ay)
            {
                case "ocak":
                case "şubat":
                case "aralık":
                    Console.WriteLine("Kış");
                    break;

                case "mart" or "nisan" or "mayıs":
                    Console.WriteLine("İlkbahar");
                    break;
                case "haziran" or "temmuz" or "ağustos":
                    Console.WriteLine("Yaz");
                    break;
                case "eylül" or "ekim" or "kasım":
                    Console.WriteLine("sonbahar");
                    break;


                    default :
                    break;

            }



        }
    }
}
